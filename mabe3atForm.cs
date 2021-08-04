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

namespace jaimeMarket
{
    public partial class mabe3atForm : Form
    {
        Database dbObject;
        public mabe3atForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mabe3atForm_Load(object sender, EventArgs e)
        {
            try
            {
                dbObject = new Database();
                dbObject.getconnection();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            dayCBox.SelectedIndex = 0;
            monthCBox.SelectedIndex = 0;
            yearCBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soldView.Visible = true;
            ta3delatView.Visible = false;
            double totala = 0;
            try
            {
                dbObject.openConnection();

                soldView.Rows.Clear();
                SQLiteDataReader reader;

                if (monthcheckBox.Checked && daycheckBox.Checked)
                    reader = dbObject.readme("SELECT * FROM sold WHERE (day = " + dayCBox.Text + " AND year = " + yearCBox.Text + " AND month = " + monthCBox.Text + ");");
                else if (monthcheckBox.Checked)
                    reader = dbObject.readme("SELECT * FROM sold WHERE (year = " + yearCBox.Text + " AND month = " + monthCBox.Text + ");"); 
                else if (daycheckBox.Checked)
                    reader = dbObject.readme("SELECT * FROM sold WHERE (day = " + dayCBox.Text + " AND year = " + yearCBox.Text + ");"); 
                else
                    reader = dbObject.readme("SELECT * FROM sold WHERE (year = " + yearCBox.Text + ");");

                while (reader.Read())
                {
                    string mortg3 = "";
                    if (reader.GetInt32(9) == 1)
                        mortg3 = "مرتجع";
                    soldView.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), mortg3, reader.GetInt32(5) + ":" + reader.GetInt32(6) + ":" + reader.GetInt32(7), reader.GetString(8));
                    totala += reader.GetDouble(4);
                }
                totalTextbox.Text = totala + "";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                dbObject.closeConnection();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalTextbox.Text = "0";
            soldView.Visible = false;
            ta3delatView.Visible = true;
            try
            {
                dbObject.openConnection();

                ta3delatView.Rows.Clear();
                SQLiteDataReader reader;
                reader = dbObject.readme("SELECT * FROM ta3delat");
                while (reader.Read())
                {
                    ta3delatView.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                dbObject.closeConnection();
            }
        }
    }
}
