using System.Data;

namespace ContactBook
{
    public partial class Form1 : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone");
            contacts.Columns.Add("Email");

            dataGridView1.DataSource = contacts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            textBox2.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            textBox3.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            textBox4.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();

            editing = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["First Name"] = textBox1.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Last Name"] = textBox1.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Phone"] = textBox1.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Email"] = textBox1.Text;
            }
            else
            {
                contacts.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            editing = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Not a valid row");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            textBox2.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            textBox3.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            textBox4.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

       
    }
}