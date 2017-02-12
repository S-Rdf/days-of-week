using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Days.of.Week
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool isSuccess = int.TryParse(txbDayNO.Text,out num);
            if (isSuccess == true) 
                DaysOfWeek(num); 
           // else MessageBox.Show("عددی بین 0 تا 6 وارد کنید");
            else MessageBox.Show("عددی بین 0 تا 6 وارد کنید");

        }

        void DaysOfWeek(int noDay) {

            switch (noDay)
            {
                case 0:
                    MessageBox.Show("شنبه");
                        break;             
                case 1:
                    MessageBox.Show("یکشنبه");
                    break;
                case 2:
                    MessageBox.Show("دوشنبه");
                    break;
                case 3:
                    MessageBox.Show("سه شنبه");
                    break;
                case 4:
                    MessageBox.Show("چهارشنبه");
                    break;
                case 5:
                    MessageBox.Show("پنجشنبه");
                    break;
                case 6:
                    MessageBox.Show("جمعه");
                    break;
                default:
                    MessageBox.Show("عددی بین 0 تا 6 وارد کنید");
                    break;

            }
            
        }

    }
}
