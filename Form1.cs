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
                        if (t_locationInput.Text != "추가 검색") // 체크박스로 입력 안하고 검색 추가해야할걸
                        {
                            // 검색창에 검색한 것 db에서 찾아라 count를 찾는것이고 없다면 -1을 리턴할거야
                            searchString[1] = t_locationInput.Text;
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
                                    string[] arr = new string[8]; 
                                    arr[0] = reader.GetString(0);
                                    for(int index = 1; index < 5; index++)
                                    {
                                        arr[1] += reader.GetString(index);
                                    }
                                    arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                    arr[3] = reader.GetString(6);
                                    arr[4] = reader.GetString(7);
                                    arr[5] = reader.GetString(8);
                                    arr[6] = reader.GetString(9);
                                    arr[7] = reader.GetString(10);
                                    l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]));
                                    // 이제 하나하나 라벨에 추가해라
                                    // 각종 사망 등 정보도 가져와서 모두 합칠것 이것 또한 라벨로 표현
                               }
                            }
                        }
                        DBconnection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
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
                l_changeName.Text = forShow.name;
            }
        }
    }
}
