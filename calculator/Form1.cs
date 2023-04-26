using System.Xml.Serialization;

namespace calculator
{

    public partial class Form1 : Form
    {

        testClass tc = new testClass();

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        // AC
        private void clear_button(object sender, EventArgs e)
        {
            display.Text = "0";
            tc.clear_fn();
        }
        // 사칙연산
        private void cal_button(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            tc.oper_fn(btn, display);
        }

        // 결과
        private void result_button(object sender, EventArgs e)
        {
            tc.result_fn(display);
        }

        // 숫자클릭
        private void btnNumClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string strNumber = btn.Text;
            
            tc.num_fn(display, btn);
        }


    }


}