using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2105401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
              
                textBox3.Clear();
                textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            txtCake1.Enabled = false;
            if (checkBox9.Checked == true)
            {
                txtCake1.Clear();
                txtCake1.Enabled = true;
            } 
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            txtCake2.Enabled = false;
            if (checkBox10.Checked == true)
                txtCake2.Clear(); txtCake2.Enabled = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            txtCake3.Enabled = false;
            if (checkBox11.Checked == true)
                txtCake3.Clear(); txtCake3.Enabled = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            txtCake4.Enabled = false;
            if (checkBox12.Checked == true)
                txtCake4.Clear(); txtCake4.Enabled = true;

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            txtCake5.Enabled = false;
            if (checkBox13.Checked == true)
                txtCake5.Clear(); txtCake5.Enabled = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            txtCake6.Enabled = false;
            if (checkBox14.Checked == true)
                txtCake6.Clear(); txtCake6.Enabled = true;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            txtCake7.Enabled = false;
            if (checkBox15.Checked == true)
                txtCake7.Clear(); txtCake7.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            txtCake8.Enabled = false;
            if (checkBox16.Checked == true)
                txtCake8.Clear(); txtCake8.Enabled = true;
        }

        private void txtCake1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCake3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           
            double Cake1 = Convert.ToDouble(txtCake1.Text);
            double Cake2 = Convert.ToDouble(txtCake2.Text);
            double Cake3 = Convert.ToDouble(txtCake3.Text);
            double Cake4 = Convert.ToDouble(txtCake4.Text);
            double Cake5 = Convert.ToDouble(txtCake5.Text);
            double Cake6 = Convert.ToDouble(txtCake6.Text);
            double Cake7 = Convert.ToDouble(txtCake7.Text);
            double Cake8 = Convert.ToDouble(txtCake8.Text);
            double Cake1_Cost = 17;
            double Cake2_Cost = 15; 
            double Cake3_Cost = 20;
            double Cake4_Cost = 24;
            double Cake5_Cost = 22;
            double Cake6_Cost = 19;
            double Cake7_Cost = 23;
            double Cake8_Cost = 23;
            //  Drinks
            // To user enter value
            double deink1 = double.Parse(textBox1.Text);
            double deink2 = double.Parse(textBox2.Text); 
            double deink3 = double.Parse(textBox3.Text); 
            double deink4 = double.Parse(textBox4.Text); 
            double deink5 = double.Parse(textBox5.Text); 
            double deink6 = double.Parse(textBox6.Text); 
            double deink7 = double.Parse(textBox7.Text); 
            double deink8 = double.Parse(textBox8.Text); 

            double drink1Cost = 10.1;
            double drink2Cost = 10.00;
            double drink3Cost = 10.65;
            double drink4Cost = 10.2;
            double drink5Cost = 10.1;
            double drink6Cost = 10.90;
            double drink7Cost = 10.8;
            double drink8Cost = 10.5;

            double CostOfCakes = (Cake1_Cost * Cake1) +(Cake2_Cost * Cake2) + (Cake3_Cost * Cake3) +
                (Cake4_Cost * Cake4) + (Cake5_Cost * Cake5) + (Cake6_Cost * Cake6) +
                (Cake7_Cost * Cake7) + (Cake8_Cost * Cake8);
            CostCakestextBox.Text = "ر.س" + CostOfCakes.ToString();

            double cost = ((deink1 * drink1Cost) +
                           (deink2 * drink2Cost) +
                           (deink3 * drink3Cost) +
                           (deink4 * drink4Cost) +
                           (deink5 * drink5Cost) +
                           (deink6 * drink6Cost) +
                           (deink7 * drink7Cost) +
                           (deink8 * drink8Cost));
           CostDrinkstextBox.Text= "ر.س"+cost.ToString() ;

             Double ServiceCharge = 1.75;
            ServiceChargetextBox.Text = "ر.س" + ServiceCharge.ToString();

            Double Tax = 10.5;
            TaxtextBox.Text = "ر.س" + Tax.ToString();

            
            
            Double SubTotal1 = cost + CostOfCakes + ServiceCharge;
            SubTotaltextBox.Text = "ر.س" + SubTotal1.ToString();

            Double Total = cost + CostOfCakes + Tax + ServiceCharge ;
            
            TotaltextBox.Text = "ر.س" + Total.ToString();







        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
               
               textBox1.Clear();
                textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
               
                textBox2.Clear();
                textBox2.Enabled = true;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
               
                textBox4.Clear();
                textBox4.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                
                textBox5.Clear();
                textBox5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
               
                textBox6.Clear();
                textBox6.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
               ;
                textBox7.Clear();
                textBox7.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                
                textBox8.Clear();
                textBox8.Enabled = true;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TaxtextBox.Clear();
            CostCakestextBox.Clear();
            CostDrinkstextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;

            textBox1.Text = "0";
            textBox1.Enabled = false;
            textBox2.Text = "0";
            textBox2.Enabled = false;
            textBox3.Text = "0";
            textBox3.Enabled = false;
            textBox4.Text = "0";
            textBox4.Enabled = false;
            textBox5.Text = "0";
            textBox5.Enabled = false;
            textBox6.Text = "0";
            textBox6.Enabled = false;
            textBox7.Text = "0";
            textBox7.Enabled = false;
            textBox8.Text = "0";
            textBox8.Enabled = false;
            txtCake1.Text = "0";
            txtCake1.Enabled = false;
            txtCake2.Text = "0";
            txtCake2.Enabled = false;
            txtCake3.Text = "0";
            txtCake3.Enabled = false;
            txtCake4.Text = "0";
            txtCake4.Enabled = false;
            txtCake5.Text = "0";
            txtCake5.Enabled = false;
            txtCake6.Text = "0";
            txtCake6.Enabled = false;
            txtCake7.Text = "0";
            txtCake7.Enabled = false;
            txtCake8.Text = "0";
            txtCake8.Enabled = false;
            // for clear Bill
            BilllistBox.Items.Clear();




        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

            //Bili
           

         
              BilllistBox.Items.Add("** Drinks **\n"); 
           
            if (checkBox1.Checked == true)
            {
                BilllistBox.Items.Add(checkBox1.Text + "         " + textBox1.Text + "\n");
              
            }
            if (checkBox2.Checked == true)
            {
                BilllistBox.Items.Add(checkBox2.Text + "         " + textBox2.Text+"\n");
              
            }
            if (checkBox3.Checked == true)
            {
                BilllistBox.Items.Add(checkBox3.Text + "         " + textBox3.Text + "\n");
               
            }
            if (checkBox4.Checked == true)
            {
                BilllistBox.Items.Add(checkBox4.Text + "         " + textBox4.Text + "\n");
                
            }
            if (checkBox5.Checked == true)
            {
                BilllistBox.Items.Add(checkBox5.Text + "         " + textBox5.Text + "\n");
            }
            if (checkBox6.Checked == true)
            {
                BilllistBox.Items.Add(checkBox6.Text + "         " + textBox6.Text + "\n");
            }
            if (checkBox7.Checked == true)
            {
                BilllistBox.Items.Add(checkBox7.Text + "         " + textBox7.Text + "\n");
            }
            if (checkBox8.Checked == true)
            {
                BilllistBox.Items.Add(checkBox8.Text + "         " + textBox8.Text + "\n");
            }
           
            BilllistBox.Items.Add("** Cakes **" + "\n");
            if (checkBox9.Checked == true)
            {
                BilllistBox.Items.Add(checkBox9.Text + "         " + txtCake1.Text + "\n");

             
            }
            if (checkBox10.Checked == true)
            {
                BilllistBox.Items.Add(checkBox10.Text + "         " + txtCake2.Text + "\n");
               
            }
            if (checkBox11.Checked == true)
            {
                BilllistBox.Items.Add(checkBox11.Text + "         " + txtCake3.Text + "\n");
            }
            if (checkBox12.Checked == true)
            {
                BilllistBox.Items.Add(checkBox12.Text + "         " + txtCake4.Text + "\n");
            }
            if (checkBox13.Checked == true)
            {
                BilllistBox.Items.Add(checkBox13.Text + "         " + txtCake5.Text + "\n");
            }
            if (checkBox14.Checked == true)
            {
                BilllistBox.Items.Add(checkBox14.Text + "         " + txtCake6.Text + "\n");
            }
            if (checkBox15.Checked == true)
            {
                BilllistBox.Items.Add(checkBox15.Text + "         " + txtCake7.Text + "\n");
            }
            if (checkBox16.Checked == true)
            {
                BilllistBox.Items.Add(checkBox16.Text + "         " + txtCake8.Text + "\n");
            }
            BilllistBox.Items.Add("---------------------------------------------");
           
            BilllistBox.Items.Add("Service Charge         " + ServiceChargetextBox.Text );
         
            BilllistBox.Items.Add("Tax                          " + TaxtextBox.Text );
           
            BilllistBox.Items.Add("Sub Total                " + SubTotaltextBox.Text );
           
            BilllistBox.Items.Add("Total Cost               " + TotaltextBox.Text );
           
            BilllistBox.Items.Add("---------------------------------------------");
           
        }

        private void BilllistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
