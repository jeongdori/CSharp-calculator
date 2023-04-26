using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Operator
    {

        //필드
        double memory_num = 0;
        bool oper_ON = true;
        char oper = '0';
        char divide;

        //생성자
        public Operator() { }


        // 속성

        //클리어
        public void Clear()
        {
            memory_num = 0;
            oper_ON = true;
        }

        // 연산클릭 -> 
        public void Operations(Button btn, Label display)
        {
            double num = Convert.ToDouble(display.Text);
            if (oper == '0' && oper_ON ==false)
            {
                memory_num = num;
                display.Text = Convert.ToString(memory_num);
                oper_ON = true;

            }
            else if(oper_ON == false)
            {
                EqualsSign(display);
                oper_ON = true;
            }
            oper = Convert.ToChar(btn.Text); 
        }

        // 숫자 클릭 -> 현재 클릭한 숫자 보이기
        public void btnNum(Label display, Button btn)
        {
            if (oper_ON == true)
            {
                display.Text = btn.Text;
                char oper = '0';
                oper_ON = false;
            }
            else
            {
                display.Text += btn.Text;
            }
        }

        // 연산기능
        // enum?
        public void EqualsSign(Label display)
        {
            double num = Convert.ToDouble(display.Text);
            switch (oper)
            {
                case '+':
                    memory_num += num;
                    break;
                case '-':
                    memory_num -= num;
                    break;
                case 'x':
                    memory_num *= num;
                    break;
                case '÷':
                    memory_num /= num;
                    break;
                   
            }
            display.Text = Convert.ToString(memory_num);
            oper_ON = true;
            oper = '0';
        }






    }
}
