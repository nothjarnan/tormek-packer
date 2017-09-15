using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Tormek_Test
{
    public partial class Form1 : Form
    {
        List<double> width;
        List<double> height;
        List<double> depth;
        List<double> weight;
        List<string> description;

        SqlConnection connection;
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Tormek_Test.Properties.Settings.ProductsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateRecipes();

        }
        private void populateRecipes() {

            using (connection = new SqlConnection(connectionString))
            
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", connection))
            {
                connection.Open();
                DataTable products = new DataTable();
                adapter.Fill(products);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";
                listBox1.DataSource = products;
                
            }

 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Text = "DELETE " + listBox1.SelectedItem.ToString();
            richTextBox1.Text = listBox1.GetItemText(listBox1.SelectedItem);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Product VALUES (@ProductName, @Width, @Height, @Depth, @Weight, @Description);";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                if (checkBox1.Checked)
                {
                    connection.Open();
                    label6.Text = "Status: connecting..";
                    command.Parameters.AddWithValue("@ProductName", textBox1.Text);
                    command.Parameters.AddWithValue("@Width", textBox2.Text);
                    command.Parameters.AddWithValue("@Height", textBox3.Text);
                    command.Parameters.AddWithValue("@Depth", textBox4.Text);
                    command.Parameters.AddWithValue("@Weight", textBox6.Text);
                    command.Parameters.AddWithValue("@Description", textBox5.Text);
                    label6.Text = "Status: connected and added items.";
                    command.ExecuteScalar();
                    label6.Text = "Status: executed NonQuery";
                    connection.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label6.Text = "Status: connection closed successfully";
                    populateRecipes();
                }
                else {
                    label6.Text = "ERROR: Make sure to double-check variables.";
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
