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
            button2.Text = "Add Car";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Car c = new Car() { Brand = textBox1.Text, 
                                Model = textBox2.Text,
                                Number = int.Parse(textBox3.Text), 
                                Color = textBox4.Text, 
                                HP = textBox5.Text,
                                Distance = textBox6.Text};
            Repo.Save(c);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show(string.Format("There are " + Repo.Count() + " cars in storage"));
        }
    }
}
