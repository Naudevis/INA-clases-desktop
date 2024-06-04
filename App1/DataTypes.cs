using System;
using System.Windows.Forms;

namespace App1
{
    public partial class DataTypes : Form
    {
        double globalValue = 1;
        enum nums
        {
            unos, dos, tres
        }
        public DataTypes()
        {
            InitializeComponent();      
            
        }        

        private void DataTypes_Load_1(object sender, EventArgs e)
        {
            /*
             sbyte -128 127
            byte 0 255
            short -32768 32767
            short
            int
            uint
            long
            ulong 99999999999999999999
            Int32
            float 3.14f
            double 3.14
            decimal 3.14m
            double fromInt= (int) 2;
            fromInt = Double.Parse(2);
            fromInt = Convert.ToDouble(2);
             */
            double a = 100;
            double b = 100;
            Console.WriteLine(nums.);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text =String.Empty;
            TxtNum1.Clear();
            TxtNum2.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = TxtNum1.Text+
                "+"+ TxtNum2.Text+
                "="+ (Double.Parse(TxtNum1.Text) +
                Double.Parse(TxtNum2.Text)) ;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            lblResult.Text = TxtNum1.Text +
                "X" + TxtNum2.Text +
                "=" + (Double.Parse(TxtNum1.Text) *
                Double.Parse(TxtNum2.Text));    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblExample.Text=(++globalValue).ToString();
        }
    }

}
