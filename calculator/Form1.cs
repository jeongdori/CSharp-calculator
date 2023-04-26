using System.Xml.Serialization;

namespace calculator
{

    public partial class Form1 : Form
    {

        Operator Oper_Con = new Operator();

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        // AC
        private void clear_button(object sender, EventArgs e)
        {
            display.Text = "0";
            Oper_Con.Clear();
        }
        // 사칙연산
        private void OperationsButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Oper_Con.Operations(btn, display);
        }

        // 결과
        private void EqualsSignButton(object sender, EventArgs e)
        {
            Oper_Con.EqualsSign(display);
        }

        // 숫자클릭
        private void btnNumClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string strNumber = btn.Text;

            Oper_Con.btnNum(display, btn);
        }


    }


}