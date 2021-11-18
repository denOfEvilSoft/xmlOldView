/*
 
지금 좀 복잡한데 결국 계산을 하려면 급식소의 위도 경도를 전부 구해야해, 그런데 급식소 데이터를 가져오는 부분이 객채 생성과 붙어있어
떠오르는 방법은 2가지
    1. 객채 생성하는 부분은 일단 그래도 두고 따로 함수를 작성한다. 물론 객채 생성할 때, db 정보가져올 때 위도 경도는 가져와야함. 
    이 함수는 객채 생성 바로 뒤에 올 것이다. 정확히 적자면 reader 가 끝나는 부분. 그 후 reader 를 작성해서 리스트박스를 하나씩 클릭하고, 클랙된 객채에 데이터를 주입한다.
    함수의 내용은 하나씩 위와 같다
    
    2. 객채 생성할 때 관여하지 말고 버튼을 하나 만들어서 그 버튼을 누르면 급식소 위도경도 가져오고 모든 위도경도를 가져오는 방법
    사용자 친화적인 방법은 아니니 고려 대상이 아니다. 아무튼 생각난 방법중 하나 
 여기서 브랜치 하나 만들어야 할것 같아 이걸 쓰는날이 오다니
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace xmlOldViewer
{
    public partial class mainForm : Form
    {
        double latitude;
        double longtitude;
        string connectionString;
        public mainForm()
        {
            InitializeComponent();
            c_location1.SelectedIndex = 0;
            connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }

        private void l_exitLabel_Click(object sender, EventArgs e)
        {
            reallyExit forExit = new reallyExit();
            forExit.Show();
        }

        private void l_windowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void t_locationInput_Click(object sender, EventArgs e)
        {
            if(t_locationInput.Text =="추가 검색")
            {
                t_locationInput.Text = "";
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string[] searchString = new string[2];
            string query = null;
            searchString[0] = c_location1.Text; // 콤보박스
            searchString[1] = null; // 추가검색
            using(MySqlConnection DBconnection = new MySqlConnection())
            {
                using(MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        DBconnection.ConnectionString = connectionString;
                        cmd.Connection = DBconnection;
                        DBconnection.Open();
                        if (t_locationInput.Text != "추가 검색" || t_locationInput.Text == "" || t_locationInput.Text == " ") // 체크박스로 입력 안하고 검색 추가해야할걸
                        {
                            // 검색창에 검색한 것 db에서 찾아라 count를 찾는것이고 없다면 -1을 리턴할거야
                            searchString[1] = t_locationInput.Text;
                            query =
                                "SELECT COUNT(*) " +
                                "FROM 전국무료급식소 " +
                                "WHERE Si = '" + searchString[0] + "' and (Gun like '%" + searchString[1] + "%' or Other like '%" + searchString[1] + "');";
                            cmd.CommandText = query;
                            int isDataThere = Convert.ToInt32(cmd.ExecuteScalar());
                            if (isDataThere == 0)
                            {
                                MessageBox.Show("검색 결과가 없어요");
                                return;
                            }
                            if(g_data.Text == "결과 (검색 대기중)")
                            {
                                g_data.Text = "결과 (";
                            }
                            g_data.Text = g_data.Text + isDataThere.ToString() + "개 검색됨)";
                            query =
                               "SELECT * " +
                               "FROM 전국무료급식소 " +
                               "WHERE Si = '" + searchString[0] + "' and (Gun like '%" + searchString[1] + "%' or Other like '%" + searchString[1] + "');";
                            cmd.CommandText = query;
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                               while (reader.Read())
                               {
                                    // 0번 : 대표이름
                                    // 1번 : 주소
                                    // 2번 : 관리기관
                                    // 3번 : 전화번호
                                    // 4번 : 위치
                                    // 5번 : 대상
                                    // 6번 : 시간
                                    // 7번 : 날
                                    // 위도 경도 추라고 받아야 한다 추가해
                                    double[] getDoubls = new double[2];
                                    string[] arr = new string[8]; 
                                    arr[0] = reader.GetString(0);
                                    for(int index = 1; index < 5; index++)
                                    {
                                        arr[1] += reader.GetString(index);
                                    }
                                    if (arr[1].Length > 22)
                                    {
                                        arr[1] = arr[1].Insert(22, "\n");
                                    }
                                    arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                    arr[3] = reader.GetString(6);
                                    arr[4] = reader.GetString(7);
                                    arr[5] = reader.GetString(8);
                                    arr[6] = reader.GetString(9);
                                    arr[7] = reader.GetString(10);
                                    getDoubls[0] = reader.GetDouble(11);
                                    getDoubls[1] = reader.GetDouble(12);
                                    //l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1], counts[0], counts[1], counts[2]));

                               }
                            }
                        }
                        else // 텍스트가 추가입력일때
                        {
                            query =
                                "SELECT COUNT(*) " +
                                "FROM 전국무료급식소 " +
                                "WHERE Si = '" + searchString[0] + "';";
                            cmd.CommandText = query;
                            int isDataThere = Convert.ToInt32(cmd.ExecuteScalar());
                            if(isDataThere == 0)
                            {
                                MessageBox.Show("검색된 데이터가 없어요");
                                return;
                            }
                            if(g_data.Text == "결과 (검색 대기중)")
                            {
                                g_data.Text = "결과 (";
                            }
                            g_data.Text = g_data.Text + isDataThere.ToString() + "개 검색됨)";

                            // 사고 데이터 가져오는부분
                            int[] counts = new int[3];
                            counts[0] = 0; counts[1] = 0; counts[2] = 0;
// 사고다발지 현항 말고 다른것도 가져와야지, 전부 가져오는부분 해결하고 그것으로 테스트 진행한다. 일단 여기서 이건 멈춰 가지 추가해라 아마도
                            query =
                            "SELECT Latitude, Longtitude, dead, severelyInjured, minorInjury " + // 사망 중상 경상
                            "FROM 사고다발지현황;";
                            cmd.CommandText = query;
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double latitude = reader.GetDouble(0);
                                    double longtitude = reader.GetDouble(1);
                                    if ((latitude * latitude) + (longtitude * longtitude) <= 0.02 * 0.02)
                                    {
                                        counts[0] += reader.GetInt32(2); // 사망
                                        counts[1] += reader.GetInt32(3); // 중상
                                        counts[2] += reader.GetInt32(4); // 경상
                                    }
                                }
                            }
                            // 급식소 정보 가져오는 쿼리
                            query =
                                "SELECT * " +
                                "FROM 전국무료급식소 " +
                                "WHERE Si = '" + searchString[0] + "';";
                            cmd.CommandText = query;

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double[] getDoubls = new double[2];
                                    string[] arr = new string[8];
                                    arr[0] = reader.GetString(0);
                                    for (int index = 1; index < 5; index++)
                                    {
                                        arr[1] += reader.GetString(index);
                                    }
                                    if(arr[1].Length > 22)
                                    {
                                        arr[1] = arr[1].Insert(22, "\n");
                                    }
                                    arr[2] = reader.GetString(5);
                                    arr[3] = reader.GetString(6);
                                    arr[4] = reader.GetString(7);
                                    arr[5] = reader.GetString(8);
                                    arr[6] = reader.GetString(9);
                                    arr[7] = reader.GetString(10);
                                    getDoubls[0] = reader.GetDouble(11);
                                    getDoubls[1] = reader.GetDouble(12);
                                    l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1], counts[0], counts[1], counts[2]));
                                }
                            }
                        }

                        // !! 야 이거 코드 위쪽 객채 생성지역으로 이동시켜라 !!

                        // 위도경도 0.01 범위

                        // x^2 + y^2 <= r^2 : x는 latitude y = longtitude r은 0.02? 
                        // 0 : 사망
                        // 1 : 중상
                        // 2 : 경상
                        

                        // 사고정보 총합 출력부분
                        DBconnection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            if(l_names.Items.Count == 0)
            {
                MessageBox.Show("먼저 검색부터 해주세요.");
                return;
            }
        }

        private void l_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            forPrintClass forShow;
            if(l_names.SelectedIndex != -1)
            {
                forShow = (forPrintClass)l_names.SelectedItem;
                forPrintClass getAndConvert = forShow;
                // 위치 정보 그룹박스 안의 라벨 변경
                l_changeInstitution.Text = forShow.institution;
                l_changeLocation.Text = forShow.loaction;
                l_changeDayOfWeek.Text = forShow.dayOfTheWeek;
                l_changeTarget.Text = forShow.target;
                l_changeTime.Text = forShow.time;
                // 사고정보 라벨 변경
                int[] forLabel = new int[3];
                forLabel[0] = forShow.dead;
                forLabel[1] = forShow.severelyInjured;
                forLabel[2] = forShow.minorInjury;
                l_changeDead.Text = forLabel[0].ToString();
                l_changeSeverelyInjured.Text = forLabel[1].ToString();
                l_changeMinorInjury.Text = forLabel[2].ToString();
                l_changeAll.Text = (forLabel[0] + forLabel[1] + forLabel[2]).ToString();
            }
        }

        private void t_locationInput_Leave(object sender, EventArgs e)
        {
            if(t_locationInput.Text =="" || t_locationInput.Text==" ")
            {
                t_locationInput.Text = "추가 검색";
            }
        }

        private void b_searchAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlConnection DBconnection = new MySqlConnection())
                    {
                        DBconnection.ConnectionString = connectionString;
                        cmd.Connection = DBconnection;
                        DBconnection.Open();
                        string query;
                        int[] counts = new int[3];
                        counts[0] = counts[1] = counts[2] = 0;
                        query =
                           "SELECT latitude, longtitude, dead, severelyInjured, minorInjury " + // 사망 중상 경상
                           "FROM 사고다발지현황;";
                        cmd.CommandText = query;
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double latitude = reader.GetDouble(0);
                                double longtitude = reader.GetDouble(1);
                                if ((latitude * latitude) + (longtitude * longtitude) <= 0.02 * 0.02)
                                {
                                    counts[0] += reader.GetInt32(2); // 사망
                                    counts[1] += reader.GetInt32(3); // 중상
                                    counts[2] += reader.GetInt32(4); // 경상
                                }
                            }
                        }
                        query =
                           "SELECT Latitude, Longitude, dead, severelyInjured, minorInjury " + // 사망 중상 경상
                           "FROM 보행노인사고다발지현황;";
                        cmd.CommandText = query;
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double latitude = reader.GetDouble(0);
                                double longtitude = reader.GetDouble(1);
                                if ((latitude * latitude) + (longtitude * longtitude) <= 0.02 * 0.02)
                                {
                                    counts[0] += reader.GetInt32(2); // 사망
                                    counts[1] += reader.GetInt32(3); // 중상
                                    counts[2] += reader.GetInt32(4); // 경상
                                }
                            }
                        }
                        query =
                           "SELECT Latitude, Longitude, dead, severelyInjured, minorInjury " + // 사망 중상 경상
                           "FROM 무단횡단사고다발지현황;";
                        cmd.CommandText = query;
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double latitude = reader.GetDouble(0);
                                double longtitude = reader.GetDouble(1);
                                // 
                                if ((latitude * latitude) + (longtitude * longtitude) <= )
                                {
                                    counts[0] += reader.GetInt32(2); // 사망
                                    counts[1] += reader.GetInt32(3); // 중상
                                    counts[2] += reader.GetInt32(4); // 경상
                                }
                            }
                        }
                        query =
                            "SELECT * " +
                            "FROM 전국무료급식소";
                        cmd.CommandText = query;
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double[] getDoubls = new double[2];
                                string[] arr = new string[8];
                                arr[0] = reader.GetString(0);
                                for (int index = 1; index < 5; index++)
                                {
                                    arr[1] += reader.GetString(index);
                                }
                                if (arr[1].Length > 22)
                                {
                                    arr[1] = arr[1].Insert(22, "\n");
                                }
                                arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                arr[3] = reader.GetString(6);
                                arr[4] = reader.GetString(7);
                                arr[5] = reader.GetString(8);
                                arr[6] = reader.GetString(9);
                                arr[7] = reader.GetString(10);
                                getDoubls[0] = reader.GetDouble(11);
                                getDoubls[1] = reader.GetDouble(12);
                                l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1], counts[0], counts[1], counts[2]));
                            }
                        }
                        DBconnection.Close();
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show("검색할때 오류생김\n\n" + ex);
                this.Cursor = Cursors.Default;
            }
        }
    }
}
