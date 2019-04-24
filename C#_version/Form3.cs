//Form of adding new records

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discount_sh
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            _ADDPHONE.Text += "+7";
        }

        // Adding button
        private void Button1_Click(object sender, EventArgs e)
        {
            bool res = true;

            //Get values from form
            MainInformation.Add_ID    = _ADDID.Text;
            MainInformation.Add_Name  = _ADDNAME.Text;
            MainInformation.Add_Phone = _ADDPHONE.Text;
            MainInformation.Add_Bonus = _ADDBONUS.Text;

            //Check values
            if (MainInformation.Add_ID == "" || MainInformation.Add_Name == "" || MainInformation.Add_Phone == "" || MainInformation.Add_Bonus == "")
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {   
                // Check numbers
                foreach(char c in MainInformation.Add_ID)
                {
                    if(!Char.IsDigit(c))
                    {
                        MessageBox.Show("ID: неверный формат");

                        MainInformation.ResetValues();
                        res = false;
                        break;                       
                    }

                    else 
                        foreach (char c1 in MainInformation.Add_Bonus)
                             {                                
                                 if (!Char.IsDigit(c1))
                                 {
                                     MessageBox.Show("Скидка: неверный формат");
                                     MainInformation.ResetValues();
                                     res = false;
                                     break;                                    
                                 }
                                
                             }                 
                }
                 
                //Success
                 if (res)
                    {
                        this.Close();
                    }              
            }
        }
    }
}
