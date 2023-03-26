using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace davaidaxao
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*public static string str = @"Data Source=LAPTOP-B9NL3QIJ\SQLEXPRESS;Initial Catalog=iof;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);*/
        public MainWindow()
        {
            InitializeComponent();
        }
        /*public static void InsertUser(string log, string pass, string fir)
        {
            using (var oleDbConn = new OleDbConnection(str))
            {
                oleDbConn.Open();
                var sql = "INSERT INTO tof (номер, пароль, код) VALUES (tex1.text, tex2.text, tex3.text)";
                using (var oleComm = new OleDbCommand(sql, oleDbConn)) ;
                
            }
        }*/
        private void auto_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "12345678")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }

        private void commit_Click(object sender, RoutedEventArgs e)
        {
            string nom = tex1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-B9NL3QIJ\SQLEXPRESS;Initial Catalog=iof;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tof where номер="+nom+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("vaayEbat");
            }
            else
            {
                MessageBox.Show("0-0");
            }
        }
    }
}
