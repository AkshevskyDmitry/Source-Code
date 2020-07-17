using System;
using System.Windows.Forms;
using System.Drawing;
using TranslateSQL;

namespace TranslationSystem
{
    public partial class Form1 : Form
    {

        public Form1(string db, string server)
        {
            InitializeComponent();
            ConnectionHelper.DatabaseName = db;
            ConnectionHelper.ServerName = server;
            richTextQuest.Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular);
            richTextBox1.Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular);
            richTextBox2.Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //q.ExecuteQuery(richTextQuest.Text, comboBox1.SelectedItem.ToString());
            richTextBox1.Text = SQLQueryBuilder.Build(richTextQuest.Text);
            richTextBox2.Text = new QueryExecution.QueryExecutor(ConnectionHelper.ConnectionString).ExecuteQuery(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!label1.Visible)
            {
                richTextBox1.Visible = true;
                label1.Visible = true;
                button2.Text = "Спрятать запрос";
            }
            else
            {
                richTextBox1.Visible = false;
                label1.Visible = false;
                button2.Text = "Показать запрос";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }
    }
}
