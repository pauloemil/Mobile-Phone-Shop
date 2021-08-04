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
    public partial class addItemForm : Form //need to add records to gard table
    {
        Database dbObject;
        public addItemForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد إضافة هذا المنتج؟", "إضافة منتج جديد", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int amount;
                double price;
                if (int.TryParse(newamount.Text, out amount) && double.TryParse(newprice.Text, out price))
                {
                    dbObject.exe("INSERT INTO `items` (`name`, `amount`, `price`) VALUES ('" + newname.Text + "', '" + amount + "', '" + price + "');");
                    string text = "تم إضافة " + newname.Text + " و الكمية " + amount + "و سعر القطعة " + price + " جنية مصري";
                    dbObject.exe("INSERT INTO `ta3delat` (`elTa3del`, `date`, `time`) VALUES ('" + text + "', '" + DateTime.Today.ToString("yyyy/MM/dd") + "', '" + DateTime.Now.ToString("h:mm:ss tt") + "');");
                    MessageBox.Show("تم إضافة " + newname.Text + "\nبكمية " + amount + "\nو سعر القطعة " + price + " جنية مصري");
                    newamount.Clear();
                    newname.Clear();
                    newprice.Clear();
                    refresh();
                }
                else
                    MessageBox.Show("ضع ارقام فقط في خانة الكمية و السعر");
            }
        }

        private void addItemForm_Load(object sender, EventArgs e)
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
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد تعديل هذا المنتج؟", "تعديل منتج", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int amount;
                double price;
                if (int.TryParse(changeamount.Text, out amount) && double.TryParse(changeprice.Text, out price))
                {
                    dbObject.exe("UPDATE `items` SET `price` = '" + price + "',  `amount` = '" + amount + "' WHERE(`name` = '" + comboBox1.Text + "');");
                    string text = "تم تعديل " + comboBox1.Text + " و الكمية الجديدة هي " + amount + " و السعر الجديد " + price + " جنية مصري";
                    dbObject.exe("INSERT INTO `ta3delat` (`elTa3del`, `date`, `time`) VALUES ('" + text + "', '" + DateTime.Today.ToString("yyyy/MM/dd") + "', '" + DateTime.Now.ToString("h:mm:ss tt") + "');");
                    changeamount.Clear();
                    changeprice.Clear();
                    comboBox1.Text = "";
                }
                else
                    MessageBox.Show("ضع ارقام فقط في خانة الكمية و السعر");
            }
            
        }
        private void refresh()
        {
            try
            {
                dbObject.openConnection();

                comboBox1.Items.Clear();
                SQLiteDataReader reader = dbObject.readme("SELECT name FROM items");
                while (reader.Read())
                    comboBox1.Items.Add(reader.GetString(0));
            }
            catch (Exception ee)
            {
                MessageBox.Show(1 + ee.ToString());
            }
            finally
            {
                dbObject.closeConnection();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbObject.openConnection();
                changeamount.Clear();
                changeprice.Clear();
                SQLiteDataReader reader = dbObject.readme("SELECT amount, price FROM items WHERE(`name` = '" + comboBox1.Text + "');");
                while (reader.Read())
                {
                    changeamount.Text = reader.GetInt32(0).ToString();
                    changeprice.Text = reader.GetDouble(1).ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(1 + ee.ToString());
            }
            finally
            {
                dbObject.closeConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد مسح هذا المنتج؟", "مسح منتج", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                dbObject.exe("DELETE FROM `items` WHERE(`Name` = '" + comboBox1.Text + "');");
                string text = "تم مسح " + comboBox1.Text;
                dbObject.exe("INSERT INTO `ta3delat` (`elTa3del`, `date`, `time`) VALUES ('" + text + "', '" + DateTime.Today.ToString("yyyy/MM/dd") + "', '" + DateTime.Now.ToString("h:mm:ss tt") + "');");
                changeamount.Clear();
                changeprice.Clear();
                comboBox1.Text = "";
                refresh();
            }
        }
    }
}
