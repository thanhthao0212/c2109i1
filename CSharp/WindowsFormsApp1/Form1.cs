using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        SqlCommand command= new SqlCommand();
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataSet ds= new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["thanhthao"].ConnectionString;

            command.Connection = connection;
            command.CommandText = "select * from Student;select Id , Firstname from Student ";
            command.CommandType = CommandType.Text;
            adapter.SelectCommand= command;
            adapter.Fill(ds);
            table.DataSource = ds.Tables[1].DefaultView;
        }
    }
}
