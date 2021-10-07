using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcApp
{
    public partial class FormCalc : Form
    {
        Contoller con;

        public void initializeCalc()
        {
            con = new Contoller();
            updateLabel();
        }
        public FormCalc()
        {
            InitializeComponent();
            initializeCalc();
            
        }


        private void button_Number_Click(object sender, EventArgs e)
        {
            con.enterNum(((Button)sender).Text);
            updateLabel();
        }
        
        private void button_Code_Click(object sender, EventArgs e)
        {
            con.enterCode(((Button)sender).Text);
            updateLabel();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            con.enterDot(((Button)sender).Text);
            updateLabel();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            con.clear();
            updateLabel();
        }

        private void updateLabel()
        {
            labelEnter.Text = con.getEnteredNum();
            labelFormula.Text = con.getFormula();
        }
        

        private void buttonCE_Click(object sender, EventArgs e)
        {
            con.clearEnter();
            updateLabel();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            con.backEnterNum();
            updateLabel();
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            con.changePM();
            updateLabel();
        }

        private void buttonEqure_Click(object sender, EventArgs e)
        {
            con.enterEqual();
            updateLabel();
        }

        private void buttonDenominator_Click(object sender, EventArgs e)
        {
            con.enterFraction();
            updateLabel();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            con.enterSqr();
            updateLabel();
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            con.enterSqrt();
            updateLabel();
        }

        private void buttonPer_Click(object sender, EventArgs e)
        {

        }
    }

}
