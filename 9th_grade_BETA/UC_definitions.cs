using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC9G
{
    public partial class UC_definitions : UserControl
    {
        public UC_definitions()
        {
            InitializeComponent();
        }

        private void UC_definitions_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Насочено движение на електрични заряди.");
        }
        private void b2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За протичане на ел. ток ни трябва: \n-проводник \n-източник на напрежение \n- да се образува затворена ел. верига");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I е равна на ел. заряд, пренесен за единица време през напречното сечение на проводника: \nI = q / t .");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Големината на тока, който тече по проводника, е правопорпорционална на напрежението, приложено в краищата му, и обратнопропорционална на неговото съпротивление: \nI = U/R .");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Съпротивлението на проводника е правопропорционално на дължината му l и обратнопропорционално на неговото напречно сечение S: \nR = ρ*l/S .");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Произведението от съпротивлението на резистора и големината на протичащия през него ток: \nU = I*R .");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Съпротивлението на консуматор, с което може да се замени разглежданата комбинация от свързани консуматори, без това да се отрази на останалата част от веригата.");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-I = const \n-U = U1 + U2 + U3 ... \n-R = R1 + R2 + R3 ...");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-U = const \n-I = I1 + I2 + I3 ... \n-1/R = 1/R1 + 1/R2 + 1/R3 ...");
        }
    }
}
