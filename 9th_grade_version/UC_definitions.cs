using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            string theme = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt");
            if (theme == "light")
            {
                titlePanel1.BackColor = Color.FromArgb(217, 205, 199);
                BackColor = Color.FromArgb(217, 205, 199);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Насочено движение на електрични заряди.");
        }
        private void b2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За протичане на ел. ток ни трябва: \n-проводник \n-източник на напрежение \n- да се образува затворена ел. верига.");
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

        private void b10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работата на тока за даден участък от електрическата верига е равна на произведението от напрежението в краищата на участъка, големината на тока и времето, за което той протича: \n-W = А = U*I*t \n-W = A = I^2*R*t \n-W = A = t*U^2/R");
        }

        private void b11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работата, която токът извършва през консуматор за единица време. Единицата за измерване е ват[W].");
        }

        private void b12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мощността на ел. ток в даден консуматор е равна на произведението от напрежението, приложението в краищата му, и големинатана протеклия през него ток: \n-P = I*U \n-P = I^2*R (за последователно свързване)\n-P = U^2*R (за успоредно свързване)");
        }

        private void b13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При успоредно свързване на консуматори по- мощни са тези, които имат по- малко съпротивление, а при последователно свързване- тези, които имат по- голямо съпротивление.");
        }

        private void b14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Електродвижещото напрежение на един източник се измерва с работата, която страничните сили извършват за пренасяне на единица положителен заряд от отрицателния до положителния полюс на източника: \n-ε = А стр / q");
        }

        private void b15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Големината на тока в затворена ел. верига е равна на отношението м-у ЕДН на източника и общото съпротивление на веригата.");
        }

        private void b16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При включване на метален проводник към източник на ЕДН под действие на ел. сили електроните придобиват скорост на насочено движение. Това движение, което се извършва заедно с топлинното им движение, представлява ел. ток. ");
        }

        private void b17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Съпротивлението на метален проводник  нараства заедно със температурата, тъй като зависимостта на съпротивлението от температурата е линейна.");
        }

        private void b18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Материали, при които съпротивлението спада със скок до нула при температури малко над абсолютната нула. При свръхпроводимост енергия не се губи и токът трябва да тече практически вечно.");
        }

        private void b19_Click(object sender, EventArgs e)
        {

        }

        private void b20_Click(object sender, EventArgs e)
        {

        }

        private void b21_Click(object sender, EventArgs e)
        {

        }
    }
}
