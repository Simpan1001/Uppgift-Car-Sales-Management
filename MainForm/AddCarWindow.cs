using CarObject;
using RepositoryForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AddCarWindow : Form
    {
        Repository Repo = new Repository();
        public AddCarWindow()
        {
            InitializeComponent();
            button1.Text = "Close";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Car c = new Car() { Brand = textBox1.Text, Model = textBox2.Text };
            Repo.Save(c);
            //textBox1.Clear();
            //textBox2.Clear();
            MessageBox.Show(string.Format("There are " + Repo.Count() + " cars in storage"));
        }
    }
}
