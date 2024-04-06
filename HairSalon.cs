using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    //Statement of Authorship: I, Mohamed Shimash Mohamed Sirajul Hasan, 000899687 certify that this material is my original work.No other person's work has been used without due acknowledgement.
    //This is a Windows Forms application which calculates the total price of a Hair Salon Services, created on 31.10.2023 
    public partial class HairSalon : Form
    {
        

        public HairSalon()
        {
            InitializeComponent();
        }

        //variable to hold hairdresser price
        double hairDresser;
        //variable to hold service price
        double service;
        //variable to hold total price
        double sum;
        private void hairdresserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        // event handler to calculate total price when 'Calculate Total' button is clicked
        private void totalBtn_Click(object sender, EventArgs e)
        {
            sum = 0;

            foreach (object obj in priceList.Items)
            {
                sum += Convert.ToDouble(obj.ToString().Substring(1));
            }

            totaltxt.Text = sum.ToString("$" + "0.00");
        }

        //event handler to defalut form load
        private void HairSalon_Load(object sender, EventArgs e)
        {
            hairdresserCombo.SelectedItem = "Jane";
            hairdresserCombo.Focus();
            serviceBtn.Enabled = false;
            totalBtn.Enabled = false;
        }

        // event handler to exit the program when 'Exit' button is clicked
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // event handler when a service is selected from the service list
        private void serviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceList.SelectedItem != null)
            {
                serviceBtn.Enabled = true;
            }
            else
            {
                serviceBtn.Enabled = false;
            }
        }

        // event handler when 'Add service' button is clicked
        private void serviceBtn_Click(object sender, EventArgs e)
        {
            // assigning prices based on selected hairdresser
            if (hairdresserCombo.Text == "Jane")
            {
                hairDresser = 30;
            }
            else if (hairdresserCombo.Text == "Pat")
            {
                hairDresser = 45;
            }
            else if (hairdresserCombo.Text == "Ron")
            {
                hairDresser = 40;
            }
            else if (hairdresserCombo.Text == "Sue")
            {
                hairDresser = 50;
            }
            else if (hairdresserCombo.Text == "Laurie")
            {
                hairDresser = 55;
            }

            // adding selected service to the list
            if (priceList.Items.Count == 0)
            {
                chargedItemsList.Items.Add(hairdresserCombo.SelectedItem);
                priceList.Items.Add(hairDresser.ToString("$" + "0.00"));
                hairdresserCombo.Enabled = false;
                totalBtn.Enabled = true;
            }



            // assigning prices based on selected service
            if (serviceList.Text == "Cut")
            {
                service = 30;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            if (serviceList.Text == "Wash, blow-dry, and style")
            {
                service = 20;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            if (serviceList.Text == "Colour")
            {
                service = 40;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            if (serviceList.Text == "Highlights")
            {
                service = 50;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            if (serviceList.Text == "Extension")
            {
                service = 200;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            if (serviceList.Text == "Up-do")
            {
                service = 60;
                chargedItemsList.Items.Add(serviceList.Text);
                priceList.Items.Add(service.ToString("$" + "0.00"));
            }
            serviceBtn.Focus();
        }

        // event handler to reset the program to default when 'reset' button is clicked
        private void resetBtn_Click(object sender, EventArgs e)
        {
            hairdresserCombo.SelectedItem = "Jane";
            hairdresserCombo.Enabled = true;
            hairdresserCombo.Focus();

            serviceList.SelectedItem = "";
            chargedItemsList.Items.Clear();
            priceList.Items.Clear();
            serviceBtn.Enabled = false;
            totalBtn.Enabled = false;
            totaltxt.Text = "";
            
        }
    }
}






