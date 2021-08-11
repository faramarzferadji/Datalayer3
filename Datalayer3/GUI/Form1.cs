using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalayer3.business;

namespace Datalayer3.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Windows_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
            cus.FirstName = textBoxFirstName.Text;
            cus.LastName = textBoxLastName.Text;
            cus.PhoneNumber = maskedTextBoxPhonNumber.Text;

            cus.SaveCustomer(cus);
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus = cus.AddRecord(Convert.ToInt32(textBoxCustomerID.Text));
            if(cus != null)
            {
                ListViewItem item = new ListViewItem(cus.CustomerID.ToString());
                item.SubItems.Add(cus.FirstName);
                item.SubItems.Add(cus.LastName);
                item.SubItems.Add(cus.PhoneNumber);


               // listView1.Items.Add(item);

            }
            else
            {
                MessageBox.Show("Customer not found");
            }
        }

        private void buttonListCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus = cus.AddRecord(Convert.ToInt32(textBoxCustomerID.Text));
            ListViewItem item = new ListViewItem(cus.CustomerID.ToString());
            item.SubItems.Add(cus.FirstName);
            item.SubItems.Add(cus.LastName);
            item.SubItems.Add(cus.PhoneNumber);

            listView1.Items.Add(item);

        }
    }
}
