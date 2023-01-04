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

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection con  = new SqlConnection();
        SqlCommand command= new SqlCommand();
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            //ADO.NET
            LoadData();

        }

        private void LoadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["TrungNghia"].ConnectionString;
            command.Connection = con;
            command.CommandText = "GetAllStudent";
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            ds.Tables.Clear();
            adapter.Fill(ds);
            bindingSource1.DataSource = ds.Tables[0];
            table.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            //data binding
            txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName");
            txtLastName.DataBindings.Add("Text", bindingSource1, "LastName");
            rdGender.DataBindings.Add("Checked", bindingSource1, "Gender");
            txtId.DataBindings.Add("Text", bindingSource1, "Id");
            dtpDob.DataBindings.Add("Value", bindingSource1, "Dob");
        }

        private void searching_TextChanged(object sender, EventArgs e)
        {
            //    ds.Tables[0].DefaultView. = select * from student
            //  Rowfilter = where 
            ds.Tables[0].DefaultView.RowFilter = $" FirstName LIKE '%{searching.Text}%'"; 
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 )
            {
                textBox1.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATESTUDENT";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName",txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
            command.Parameters.AddWithValue("@Gender",rdGender.Checked);
            command.Parameters.AddWithValue("@Dob", dtpDob.Value);
            command.Parameters.AddWithValue("@Id", txtId.Text);
            con.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Success", "Info");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            { 
                con.Close();
                command.Parameters.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                txtId.DataBindings.Clear();
                rdGender.DataBindings.Clear();
                dtpDob.DataBindings.Clear();
                LoadData();
            }
            
        }

        private void btnUpdateAdapter_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetUpdateCommand();
            try
            {
                adapter.Update(ds.Tables[0]);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error");

            }
        }
    }
}
