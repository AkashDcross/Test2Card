using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moonpig;
namespace Minterface
{
    public partial class v : Form
    {

        List<Card> Cardlist;
        Card card;
        Customer customer;
        Reciever Recepriant;
        List<Reciever> Receptiantlist;
        List<Customer> CustomersList;
      
        public v()
        {
            InitializeComponent();
            Card Cards = new Card();
            Cardlist = new List<Card>();
            card = new Card();
            CustomersList = new List<Customer>();
            customer = new Customer();
            Receptiantlist = new List<Reciever>();
            Recepriant = new Reciever();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtAge.Visible = false;
            //label3.Visible = false;
            //label2.Visible = false;

            //txtMsg.Visible = false;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        
        }

     
        private void Button1_Click(object sender, EventArgs e)
        {


            customer.name = Convert.ToString(txtCustn.Text);
            customer.age = Convert.ToString(txtCustage.Text);
            customer.email = Convert.ToString(txtEmail.Text);

            MessageBox.Show("Customer Created");



            CustomersList.Add(customer);



            foreach (Customer C in CustomersList)
            {
                listView1.Items.Add(C.name);
                listView1.Items.Add(C.age);
                listView1.Items.Add(C.email);
            }

        }
    }
}
