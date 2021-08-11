using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Datalayer3.business;
using System.Windows.Forms;

namespace Datalayer3.DataAcsess
{
  public static class CustomerIO
    {
        const string dir = @"";
        const string filepath = dir + "customer.dat";

        public static void SaveRecord(Customer cus)
        {
            StreamWriter sWriter = new StreamWriter(filepath, true);
            sWriter.WriteLine(cus.CustomerID + "," + cus.FirstName + "," +
                cus.LastName + "," + cus.PhoneNumber);
            MessageBox.Show("Record Save Successfuly");

            sWriter.Close();
        }
        public static Customer AddRecord(int id)

        {
            Customer cus = new Customer();
            if (File.Exists(filepath))
            {
                StreamReader sReader = new StreamReader(filepath);
                string line = sReader.ReadLine();
                bool found = false;
                while(line != null)
                {
                    string[] fildes = line.Split(',');
                    if(Convert.ToInt32(fildes[0])== id)
                    {
                        cus.CustomerID = Convert.ToInt32(fildes[0]);
                        cus.FirstName = fildes[1];
                        cus.LastName = fildes[2];
                        cus.PhoneNumber = fildes[3];

                        found = true;
                        break;
                    }
                    line = sReader.ReadLine();
                }
                MessageBox.Show("Data added to list");
                sReader.Close();
                if (!found)
                {
                    cus = null;
                }

            }
            else
            {
                MessageBox.Show("File not found");

            }

            return cus;


        }
        public static Customer AddRecord(string input)
        {
            Customer cus = new Customer();
            return cus;
        }
    }
}
