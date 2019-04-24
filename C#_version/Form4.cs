// Form of updating records

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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        //Update button
        private void Button1_Click(object sender, EventArgs e)            
        {
            try
            {
                bool res = true;

                //Get values from form
                MainInformation.Add_ID = _UPDID.Text;
                MainInformation.Add_Bonus = _UPDBONUS.Text;

                //Check values
                if (MainInformation.Add_ID == "" || MainInformation.Add_Bonus == "")
                {
                    MessageBox.Show("Заполните все поля");
                }

                else
                {
                    //Check numbers
                    foreach (char c in MainInformation.Add_ID)
                    {
                        if (!Char.IsDigit(c))
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
            catch (Exception)
            {
                MessageBox.Show("Ошибка обновления");
            }
        }


    }
}
