using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlynhanvien
{
    public partial class Project : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-E12JERN\SQLEXPRESS;Initial Catalog=DTqlsv;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from project";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtpr.DataSource = table;

        }
        public Project()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Project set tiendo='" + tb_td.Text + "', ngaybatdau='" + dateTimePicker1.Text + "' where project = '" + tb_tenpr.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Project where project = ('" + tb_tenpr.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dtpr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_tenpr.ReadOnly = true;

            int i;
            i = dtpr.CurrentRow.Index;
            tb_tenpr.Text = dtpr.Rows[i].Cells[0].Value.ToString();
            dateTimePicker1.Text = dtpr.Rows[i].Cells[2].Value.ToString();
            tb_td.Text = dtpr.Rows[i].Cells[1].Value.ToString();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Project values('" + tb_tenpr.Text + "','" + tb_td.Text + "','" + dateTimePicker1.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
