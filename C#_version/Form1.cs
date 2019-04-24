//Main form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Discount_sh
{
    public partial class MainForm : Form
    {
        //Necessary paths/values
        private const String dbFileName = @"C:\base\TestDB.db";
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        //General function to execute sql query
        private void RunSQL(string sSql)
            //sql - query
        {
            try
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=" + dbFileName + "; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    //define query
                    string commandText = sSql;

                    //Create table if not exists
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open(); // open connection
                    Command.ExecuteNonQuery(); //execute
                    Connect.Close(); // close connection
                }
            }
            catch (Exception)
            {
                MessageBox.Show("RunSQL error");
            }
        }

        //Function of sql query with select 
        private void ComplexSQL(string sQuery, string sMessage, bool bSelect)
        //query - query
        //message - result message
        //select - select bool flag
        {
            try
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=" + dbFileName + "; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    //define query
                    string commandText = @"SELECT * FROM CLIENTS WHERE ID = " + MainInformation.Add_ID + ";";

                    DataTable dTable = new DataTable();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(commandText, Connect);
                    adapter.Fill(dTable);

                    //Set datagrid parameters for visual interface
                    var column_ID = new DataGridViewColumn();
                    var column_NAME = new DataGridViewColumn();
                    var column_PHONE = new DataGridViewColumn();
                    var column_BONUS = new DataGridViewColumn();

                    column_ID.Name = "ID";
                    column_NAME.Name = "NAME";
                    column_PHONE.Name = "PHONE";
                    column_BONUS.Name = "BONUS";

                    column_ID.CellTemplate = new DataGridViewTextBoxCell();
                    column_NAME.CellTemplate = new DataGridViewTextBoxCell();
                    column_PHONE.CellTemplate = new DataGridViewTextBoxCell();
                    column_BONUS.CellTemplate = new DataGridViewTextBoxCell();

                    dataGridView.Columns.Add(column_ID);
                    dataGridView.Columns.Add(column_NAME);
                    dataGridView.Columns.Add(column_PHONE);
                    dataGridView.Columns.Add(column_BONUS);

                    // Add select result to datagrid
                    if (bSelect)
                    {
                        if (dTable.Rows.Count > 0)
                        {
                            dataGridView.Rows.Clear();

                            for (int i = 0; i < dTable.Rows.Count; i++)
                                dataGridView.Rows.Add(dTable.Rows[i].ItemArray);

                            label_IDvalue.Text = dataGridView[0, 0].Value.ToString();
                            label_NAMEvalue.Text = dataGridView[1, 0].Value.ToString();
                            label_PHONEvalue.Text = dataGridView[2, 0].Value.ToString();
                            label_BONUS.Text = dataGridView[3, 0].Value.ToString() + '%';
                        }

                        else
                            MessageBox.Show("ID не найден");
                    }
                    //Execute main query
                    else
                    {
                        if (dTable.Rows.Count > 0)
                        {
                            dataGridView.Rows.Clear();

                            RunSQL(sQuery);

                            MessageBox.Show(sMessage);
                        }

                        else
                            MessageBox.Show("ID не найден");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ComplexSQL error");
            }
        }      
public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            //Create database if not exists
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName); 

               // create table query
                RunSQL(@"CREATE TABLE CLIENTS( 
                             ID INT PRIMARY KEY     NOT NULL, 
		                     NAME           TEXT    NOT NULL, 
		                     PHONE          TEXT    NOT NULL, 
		                     BONUS          INT     NOT NULL);");         
            }
        }

        //Insert button
        private void Button3_Click(object sender, EventArgs e)
        {
            Form ifrm3 = new AddForm();
            ifrm3.ShowDialog();

            if (MainInformation.Add_ID != "" || MainInformation.Add_Name != "" || MainInformation.Add_Phone != "" || MainInformation.Add_Bonus != "")
            {
                try
                {
                    // query
                    RunSQL( @"INSERT INTO CLIENTS (ID,NAME,PHONE,BONUS)   
                                VALUES (" + MainInformation.Add_ID + ", '" + MainInformation.Add_Name + "', '" + MainInformation.Add_Phone + "', " + MainInformation.Add_Bonus + ");");

                    MessageBox.Show("Запись добавлена");
                   
                    MainInformation.ResetValues();
                
                }
                    catch(Exception)
                    {
                        MessageBox.Show("Ошибка добавления: ID уже существует");
                    }
            }
        }

            // select button
            private void Button4_Click(object sender, EventArgs e)
            {               
                 Form ifrm2 = new FindForm();
                
                 label_IDvalue.Text    = "-";
                 label_NAMEvalue.Text  = "-";
                 label_PHONEvalue.Text = "-";
                 label_BONUS.Text      = "%";
                
                 ifrm2.ShowDialog();
                
                 if (MainInformation.Add_ID != "")
                 {
                    ComplexSQL("", "", true);                  
                 }
                
                 MainInformation.ResetValues();
        }

        //Delete button
        private void Button5_Click(object sender, EventArgs e)
        {
            Form ifrm2 = new FindForm();
            ifrm2.ShowDialog();

            if (MainInformation.Add_ID != "")
            {
                ComplexSQL(@"DELETE FROM CLIENTS WHERE ID = " + MainInformation.Add_ID + ";", "Запись удалена", false);                
                MainInformation.ResetValues();              
            }
        }

        // Update button
        private void Button6_Click(object sender, EventArgs e)
        {
            Form ifrm4 = new UpdateForm();
            ifrm4.ShowDialog();

            if (MainInformation.Add_Bonus != "" && MainInformation.Add_ID != "")
            {
                ComplexSQL(@"UPDATE CLIENTS SET BONUS = " + MainInformation.Add_Bonus + " WHERE ID = " + MainInformation.Add_ID + ";", "Запись изменена", false);           
                MainInformation.ResetValues();              
            }
        }
    }

    //Helper class
    public static class MainInformation
    {
        public static void ResetValues()
        {
            Add_ID    = "";
            Add_Name  = "";
            Add_Phone = "";
            Add_Bonus = "";
        }

        public static string Add_ID    = "";
        public static string Add_Name  = "";
        public static string Add_Phone = "";
        public static string Add_Bonus = "";
    }
}