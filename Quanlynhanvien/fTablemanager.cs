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
    public partial class fTablemanager : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-E12JERN\SQLEXPRESS;Initial Catalog=DTqlsv;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhanvien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        public fTablemanager()
        {
            InitializeComponent();
            
        }

        private void fTablemanager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTqlsvDataSet2.project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.dTqlsvDataSet2.project);
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "delete from Nhanvien where idnhanvien = ('" + tb_id.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Nhanvien set tennv='" + tb_name.Text + "', ngaysinh='" + dateTimePicker1.Text + "',gioitinh='" + comboBox1.Text + "',sodienthoai='" + tb_sdt.Text + "',phongban='" + tb_pb.Text + "',chucvu='" + tb_cv.Text + "',project='" + comboBox2.Text + "' where idnhanvien = '" + tb_id.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Nhanvien values('" + tb_id.Text + "','" + tb_name.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + tb_sdt.Text + "','" + tb_pb.Text + "','" + tb_cv.Text + "','" + comboBox2.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            
            i = dataGridView1.CurrentRow.Index;
            tb_id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_name.Text= dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[i].Cells[2].Value.ToString();
            
            tb_sdt.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
            tb_pb.Text= dataGridView1.Rows[i].Cells[5].Value.ToString();
            tb_cv.Text= dataGridView1.Rows[i].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

        }

        private void tb_pr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            admin f = new admin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Project f = new Project();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
