using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_EP;
using Task_EP.Pattern;
using Task_EP.FileRepository;
using Task_EP.Repository;
using Task_EP.Classes;
using Task_EP.Response;

namespace CinemaUserWindowsForm
{
    public partial class Form1 : Form
    {
        readonly PopCorn popCorn = null;
        readonly AbstractFactoryPattern abstractF = null;
        readonly IRepository<Actor> actorrep = null;
        readonly IRepository<Client> clientrep = null;
        readonly IRepository<Ticket> ticketrep = null;


        readonly ResponseFile respones = null;

        public Form1()
        {
            InitializeComponent();

            
            abstractF = HelperCreateRep.CreateRepositoryOfPattern();//file
            actorrep = abstractF.GetRepositoryActor();
            clientrep = abstractF.GetRepositoryClient();
            ticketrep = abstractF.GetRepositoryTicket();

            respones = new ResponseFile();

            popCorn= new PopCorn();
        }

       
        private void button_Click_RefreshTickets(object sender, EventArgs e)
        {
            
            ticketrep.GetMetodToRead();
            BindingSource bs = new BindingSource();
            bs.DataSource = ticketrep.Array();

            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void button_Click_PoplarMovie(object sender, EventArgs e)
        {
            string str = ticketrep.PopularObjStr();
            MessageBox.Show(str, "The most popular movie:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Click_AddTicket(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var movie = textBox2.Text;
            var home = textBox3.Text;
            try
            {

                clientrep.Add(new Client(name, home, movie));

                MessageBox.Show("Succesfully bought a ticket!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click_AddResponse(object sender, EventArgs e)
        {
            try
            {
                var responesTxt = textBox4.Text;
                var nameTxt = textBox5.Text;
                respones.AddResponse(nameTxt + ":  " + responesTxt);

                MessageBox.Show("Succesfully sent!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label_Click_PopularActor(object sender, EventArgs e)
        {
            label9.Text = actorrep.PopularObjStr();
        }

        private void button_Click_RefreshActors(object sender, EventArgs e)
        {
            
            actorrep.GetMetodToRead();
            BindingSource bs = new BindingSource();
            bs.DataSource = actorrep.Array();

            dataGridView2.DataSource = bs;

            dataGridView2.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ticketrep.Array();
            dataGridView2.DataSource = actorrep.Array();
        }

        private void linkLabel_LinkClicked_Instagram(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.instagram.com/maria.hrtv/");
        }

        private void label_Click_PopularActor2(object sender, EventArgs e)
        {
            label17.Text = actorrep.PopularObjStr();
        }

        private void button_Click_PopCornCaramel(object sender, EventArgs e)
        {
            popCorn.Caramel++;
            label19.Text = popCorn.Caramel.ToString();
        }

        private void button_Click_PopCornCheese(object sender, EventArgs e)
        {
            popCorn.Chesse++;
            label20.Text = popCorn.Chesse.ToString();
        }

        private void button_Click_PopCornBacon(object sender, EventArgs e)
        {
            popCorn.Bacon++;
            label23.Text = popCorn.Bacon.ToString();
        }

        private void button_Click_PopCornSalt(object sender, EventArgs e)
        {
            popCorn.Salt++;
            label21.Text = popCorn.Salt.ToString();
        }

        private void button_Click_PopCornSugar(object sender, EventArgs e)
        {
            popCorn.Sugar++;
            label22.Text = popCorn.Sugar.ToString();
        }

        private void button_Click_PopCornChocolate(object sender, EventArgs e)
        {
            popCorn.Chocolate++;
            label24.Text = popCorn.Chocolate.ToString();
        }

        private void linkLabel_LinkClicke_Oskar(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=modPonPyQ6E");
        }
    }
}
