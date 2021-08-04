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
    public partial class ma5znForm : Form
    {
        Database dbObject;
        public ma5znForm()
        {
            InitializeComponent();
        }

        private void ma5znForm_Load(object sender, EventArgs e)
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
            try
            {
                dbObject.openConnection();     //id, name, amount, price
                SQLiteDataReader reader = dbObject.readme("SELECT * FROM items");
                while(reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    int amount = reader.GetInt32(2);
                    double price = reader.GetDouble(3);
                    dataGridView1.Rows.Add(id.ToString(), name, amount.ToString(), price.ToString());
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("الإسم غير صحيح");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                dbObject.closeConnection();
            }
        }
    }
}
