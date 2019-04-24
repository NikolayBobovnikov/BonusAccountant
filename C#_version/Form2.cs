//Find/delete form

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
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        //Find/delete button
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                bool res = true;
                MainInformation.Add_ID = _FINDID.Text;

                //Check value
                if (MainInformation.Add_ID == "")
                {
                    MessageBox.Show("Введите ID");
                }

                else
                {
                    //Check number
                    foreach (char c in MainInformation.Add_ID)
                    {

                        if (!Char.IsDigit(c))
                        {
                            MessageBox.Show("ID: неверный формат");

                            MainInformation.ResetValues();
                            res = false;
                            break;

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
                MessageBox.Show("Ошибка поиска");
            }
        }
    }
}
