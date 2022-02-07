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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public карточка_водителя driver { get; set; } = null;
        private void Form3_Load(object sender, EventArgs e)
        {
            if (driver == null)
            {
                карточка_водителяBindingSource.AddNew();
                this.Text = "Добавление нового водителя";
            }
            else
            {
                карточка_водителяBindingSource.Add(driver);
                iDTextBox.ReadOnly = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (driver == null)
            {
                driver = (карточка_водителя)карточка_водителяBindingSource.Current;
                db.карточка_водителя.Add(driver);
            }
        }
    }
}
