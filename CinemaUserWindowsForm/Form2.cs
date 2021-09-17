using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaUserWindowsForm
{
    
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("We are glad to hepl u!");
                Close();
                this.mainForm.Label26Text("Thanks for joining us!:)");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.No;
                MessageBox.Show("Sorry for wasting your time");
                Close();
                this.mainForm.Label27Text("Sorry! Goodbye!:)");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }     

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.mainForm.MoveBottom(10);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.mainForm.MoveRight(10);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.mainForm.MoveLeft(10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mainForm.MoveUp(10);
        }
    }
}
