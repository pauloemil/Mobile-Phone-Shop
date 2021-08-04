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
    public partial class sellerForm : Form
    {
        Database dbObject;
        public sellerForm()
        {
            InitializeComponent();
        }

        private void sellerForm_Load(object sender, EventArgs e)
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
            refresh(itemCBox, false);
            itemCBox.Text = "";
            amountCBox.SelectedIndex = 0;
            refresh(mortg3CBox, true);
            mortg3CBox.Text = "";
            comboBox2.SelectedIndex = 0;
        }
        private void refresh(ComboBox box, bool all)
        {
            try
            {
                dbObject.openConnection();

                box.Items.Clear();
                SQLiteDataReader reader = dbObject.readme("SELECT name, amount FROM items");
                while (reader.Read())
                {
                    if(!all)
                    {
                        if (reader.GetInt32(1) > 0)
                        {
                            box.Items.Add(reader.GetString(0));
                        }
                    }
                    else
                    {
                        box.Items.Add(reader.GetString(0));
                    }

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

        private void addButton_Click(object sender, EventArgs e)
        {
            try    
            {
                dbObject.openConnection();     //id, name, amount, price
                SQLiteDataReader reader = dbObject.readme("SELECT * FROM items WHERE(`name` = '" + itemCBox.Text + "');");
                reader.Read();

                int id = reader.GetInt32(0); 
                string name = reader.GetString(1);
                int amount = reader.GetInt32(2);
                double price = reader.GetDouble(3);

                if (amount < int.Parse(amountCBox.Text))
                {
                    MessageBox.Show("غير متبقي من هذا المنتج غير " + amount.ToString() + "فقط");
                    dataGridView1.Rows.Add(id.ToString(), name, amount.ToString(), price.ToString(), (amount * price).ToString());
                    totalTextbox.Text = (double.Parse(totalTextbox.Text) + amount * price).ToString();
                }
                else
                {
                    dataGridView1.Rows.Add(id.ToString(), name, amountCBox.Text, price.ToString(), (int.Parse(amountCBox.Text) * price).ToString());
                    totalTextbox.Text = (double.Parse(totalTextbox.Text) + int.Parse(amountCBox.Text) * price).ToString();
                }
                

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("الإسم غير صحيح");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                dbObject.closeConnection();
                refresh(itemCBox, false);
                itemCBox.Text = "";
                amountCBox.SelectedIndex = 0;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;
            for(int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                total += double.Parse(dataGridView1.Rows[rows].Cells[4].Value.ToString());
            }
            totalTextbox.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد اتمام عملية البيع؟", "البيع", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                double totalPaid = 0;
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    int id = int.Parse(dataGridView1.Rows[rows].Cells[0].Value.ToString());
                    string name = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                    int amount = int.Parse(dataGridView1.Rows[rows].Cells[2].Value.ToString());
                    double total = double.Parse(dataGridView1.Rows[rows].Cells[4].Value.ToString());
                    DateTime currentDateTime = DateTime.Now;
                    string year, month, day;
                    year = currentDateTime.Year.ToString();
                    month = currentDateTime.Month.ToString();
                    day = currentDateTime.Day.ToString();
                    string time = currentDateTime.ToString("h:mm:ss tt");
                    try
                    {
                        dbObject.openConnection();     //id, name, amount, price
                        SQLiteDataReader reader = dbObject.readme("SELECT amount FROM items WHERE(`id` = '" + id + "');");
                        reader.Read();
                        int amountdb = reader.GetInt32(0);

                        if (amountdb >= amount)
                        {
                            dbObject.exe("UPDATE `items` SET `amount` = '" + (amountdb - amount) + "' WHERE(`id` = '" + id + "');");
                            dbObject.exe("INSERT INTO `sold` (`itemID`, `itemName`, `amount`, `totalPrice`, `year`, `month`, `day`, `time`, added)" +
                            " VALUES ('" + id + "', '" + name + "', '" + amount + "', '" + total + "', '" + year + "', '" + month + "', '" + day + "', '" + time + "', '" + 0 + "');");
                            totalPaid += total;
                        }
                        else
                            MessageBox.Show("غير متبقي من " + name);
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
                button2_Click(sender, e);
                MessageBox.Show("المطلوب من الزبون: " + totalPaid.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد إرجاع هذا المنتج؟", "إرجاع منتج", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int id, amount;
                double price;
                string name;
                try
                {
                    dbObject.openConnection();

                    SQLiteDataReader reader = dbObject.readme("SELECT * FROM items WHERE(`name` = '" + mortg3CBox.Text + "'); ");
                    reader.Read();
                    id = reader.GetInt32(0);
                    name = reader.GetString(1);
                    //amount = reader.GetInt32(2);
                    price = reader.GetDouble(3);
                    DateTime currentDateTime = DateTime.Now;
                    string year, month, day;
                    year = currentDateTime.Year.ToString();
                    month = currentDateTime.Month.ToString();
                    day = currentDateTime.Day.ToString();
                    string time = currentDateTime.ToString("h:mm:ss tt");

                    dbObject.exe("UPDATE `items` SET  `amount` = amount + " + comboBox2.Text + " WHERE(`name` = '" + mortg3CBox.Text + "');");

                    dbObject.exe("INSERT INTO `sold` (`itemID`, `itemName`, `amount`, `totalPrice`, `year`, `month`, `day`, `time`, added)" +
                            " VALUES ('" + id + "', '" + name + "', '" + comboBox2.Text + "', '" + -1 * price * int.Parse(comboBox2.Text) + "', '" + year + "', '" + month + "', '" + day + "', '" + time + "', '" + 1 + "');");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(1 + ee.ToString());
                }
                finally
                {
                    dbObject.closeConnection();
                    refresh(itemCBox, false);
                    mortg3CBox.Text = "";
                    comboBox2.SelectedIndex = 0;
                }
                
                
            }
            
        }
    }
}
