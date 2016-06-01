using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                SelectData(textBox1.Text);
            }
        }
            private void SelectData( string selectCommandText)
        {
            try
            {
                

                string selectConnection=
                    
                    //"Data Source=localhost;" + "Initial Catalog = Northwind;" + "Integrated Security=True;" + "Connect Timeout=30;User Instance=True;" + "Trusted_Connection = True";

                @"Data Source=MAMANI\SQLEXPRESS;" +
                    @"Initial Catalog=" +
                    @"Northwind;" + 
                    @"Integrated Security=False;" + 
                    @"Connect Timeout=30;User Instance=True";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectConnection, selectCommandText);
                   DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        }
    }

