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
    public partial class admin : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-E12JERN\SQLEXPRESS;Initial Catalog=DTqlsv;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Account";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtadmin.DataSource = table;

        }
        public admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dtadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_tennd.ReadOnly = true;

            int i;
            i =dtadmin.CurrentRow.Index;
            tb_tennd.Text = dtadmin.Rows[i].Cells[0].Value.ToString();
            tb_tk.Text = dtadmin.Rows[i].Cells[1].Value.ToString();
            tb_mk.Text = dtadmin.Rows[i].Cells[2].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Account values('" + tb_tennd.Text + "','" + tb_tk.Text + "','" + tb_mk.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Account where tenht = ('" + tb_tennd.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Account set tk='" + tb_tk.Text + "', mk='" + tb_mk.Text + "' where tenht = '" + tb_tennd.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
