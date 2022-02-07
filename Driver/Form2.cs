using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void Form2_Load(object sender, EventArgs e)
        {
            карточкаводителяBindingSource.DataSource = db.карточка_водителя.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            карточка_водителя driver = (карточка_водителя)карточкаводителяBindingSource.Current;

            DialogResult dr = MessageBox.Show("Удалить запись?" + driver.ID + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.карточка_водителя.Remove(driver);
                try
                {
                    db.SaveChanges();

                    карточкаводителяBindingSource.DataSource = db.карточка_водителя.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
    }
}
