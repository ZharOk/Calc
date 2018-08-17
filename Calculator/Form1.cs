using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = " ";
            buttonMP.Enabled = false;
            buttonMM.Enabled = false;
            buttonMR.Enabled = false;
            this.Size = new Size(421, 541);
        }
        
        public double mem = 0;  // для сохраненного значения
        public double text1, text2, text3, textH, type = 0; // 3 переменных для расчета и тип для операции равно
        public int EXACTLYchek=0 ; // после нажатия ровно можна начинать писать с пустой строки 
        public int ErrorChek = 0; // выцеплять некоторые ошибки.
        public string chekforZnak="";

        private void EqualKey_Block()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button0.Enabled = false;
            buttonCOMA.Enabled = false;
            buttonDIVISION.Enabled = false;
            buttonMULTIPLICATION.Enabled = false; ;
            buttonMINUS.Enabled = false;
            buttonPLUS.Enabled = false;
            buttonPERSENT.Enabled = false;
            buttonINVERSE.Enabled = false;
            buttonEXACTLY.Enabled = false;
            buttonBACK.Enabled = false;
            buttonC.Enabled = false;
            buttonCE.Enabled = true;
            buttonPM.Enabled = false;
            buttonSQRT.Enabled = false;
            buttonMC.Enabled = false;
            buttonMR.Enabled = false;
            buttonMS.Enabled = false;
            buttonMP.Enabled = false;
            buttonMM.Enabled = false;
        }

        private void EqualKey_UnBlock()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button0.Enabled = true;
            buttonCOMA.Enabled = true;
            buttonDIVISION.Enabled = true;
            buttonMULTIPLICATION.Enabled = true; ;
            buttonMINUS.Enabled = true;
            buttonPLUS.Enabled = true;
            buttonPERSENT.Enabled = true;
            buttonINVERSE.Enabled = true;
            buttonEXACTLY.Enabled = true;
            buttonBACK.Enabled = true;
            buttonC.Enabled = true;
            buttonCE.Enabled = true;
            buttonPM.Enabled = true;
            buttonSQRT.Enabled = true;
            buttonMC.Enabled = true;
            buttonMS.Enabled = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Paint += new PaintEventHandler(Form1_Paint);//перерисовываем
        }
        void Form1_Paint(object sender, PaintEventArgs e) // рамочка для textBox
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.White, 4);
            pen.LineJoin = LineJoin.Bevel;//задаем скошенные углы
            pen.MiterLimit = 4;//задаем ограничение толщины скошенных углов
            g.DrawRectangle(pen, new Rectangle(textBox1.Location.X - 1, textBox1.Location.Y - 1, textBox1.Width + 1, textBox1.Height + 1)); // для textBox1
            g.DrawRectangle(pen, new Rectangle(textBox2.Location.X - 1, textBox2.Location.Y - 1, textBox2.Width + 1, textBox2.Height + 1)); // для textBox2
            //рисуем прямоугольник с параметрами испоьзуемыми выше            
            // ex Hermein
        }

        private void вставитьCTRLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = CopyAndPaste;
        }
        // Цифры от 0 до 9
        private void button0_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 0;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "0";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 1;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "1";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 2;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "2";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 3;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "3";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 4;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "4";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 5;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "5";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 6;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "6";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 7;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "7";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 8;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "8";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (chekforZnak == "")
            {
                buttonCE.PerformClick();
            }
            if (EXACTLYchek != 0)
            {
                EXACTLYchek = 0;
                textBox1.Text = "";
                textBox1.Text += 9;
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "9";
                else if (textBox1.MaxLength > textBox1.TextLength) // проверка не привишает ли строка максимальный размер. 
                    textBox1.Text += 9;
            }
        }
// ================================================================================
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // корекция ввода для textBox1
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (textBox2.Text.Contains(",") || textBox2.Text.Contains("."))
                        {
                            e.Handled = true;
                        }
                }
                else
                {
                    e.Handled = true;
                }

            }
        }
        // ================================================================================
        // Мат операции
        private void buttonDIVISION_Click(object sender, EventArgs e) // "/"
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            EXACTLYchek = 0;
            if (textBox1.Text == "")// проверка на коректность
            {
                type = 1;
                textBox1.Focus();
                label2.Text = "/";
                chekforZnak = "division";
            }
            else
            {

                buttonEXACTLY.PerformClick();
                type = 1;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "/";
                chekforZnak = "division";
                textBox1.Text = "";
            }
        }

        private void buttonMULTIPLICATION_Click(object sender, EventArgs e) // "*"
        {

            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold); 
            EXACTLYchek = 0;
            if (textBox1.Text == "")// проверка на коректность
            {
                type = 2;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "*";
                chekforZnak = "multiplication";

            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 2;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "*";
                chekforZnak = "multiplication";
                textBox1.Text = "";

            }
        }

        private void buttonMINUS_Click(object sender, EventArgs e) // минус
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold); 
            EXACTLYchek = 0;
            if (textBox1.Text == "")// проверка на коректность
            {
                type = 3;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "-";
                chekforZnak = "minus";
            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 3;
                EXACTLYchek = 1;
                text1 = Convert.ToDouble(textBox1.Text);
                textBox1.Focus();
                label2.Text = "-";
                chekforZnak = "minus";
                textBox1.Text = "";
            }
            
        }

        private void buttonPLUS_Click(object sender, EventArgs e) //"+"
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold); 
            EXACTLYchek = 0;
            if (textBox1.Text == "") // проверка на коректность
            {
                type = 4;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "+";
                chekforZnak = "plus";
            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 4;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "+";
                chekforZnak = "plus";
                textBox1.Text = "";
            }
        }

        private void Help_textH()
        {
            if ((chekforZnak == "plus" || chekforZnak == "minus" || chekforZnak == "division" || chekforZnak == "multiplication" || chekforZnak == "^" || chekforZnak == "x^(1/n)" || chekforZnak == "mod") && textBox1.Text != "")
            {
                textH = Double.Parse(textBox1.Text);
            }
        }
        private void buttonEXACTLY_Click(object sender, EventArgs e) // "="
        {
            Help_textH();
            EXACTLYchek += 1;
            if (textBox1.Text != "")
            {
                if (EXACTLYchek <= 1)
                {
                    text2 = text1;
                    text1 = Double.Parse(textBox1.Text);
                    if (type == 1)
                    {
                        if (text1 == 0)
                        {
                            label2.Font = new Font("Arial", 12, FontStyle.Bold);
                            label2.Text = "Неможлива операція. Натисніть 'CE' ";
                            EqualKey_Block();
                            textBox1.Text = "";
                        }
                        else
                        {
                            text3 = text2 / text1;
                            textBox1.Text = text3.ToString();
                            label2.Text = "";
                        }
                        EXACTLYchek += 1;

                    }
                    if (type == 2)
                    {

                        text3 = text1 * text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 3)
                    {

                        text3 = text2 - text1;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek = 1;
                    }
                    if (type == 4)
                    {

                        text3 = text1 + text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 5)
                    {
                        if (text1 == 0)
                        {
                            textBox1.Text = "1";
                        }
                        else if (text1 == 1)
                        {
                            textBox1.Text = text2.ToString();
                        }

                        else
                        {
                            text3 = text2;
                            for (int i = 2; i <= text1; i++)
                            {
                                text3 *= text2;
                            }
                            textBox1.Text = text3.ToString();
                            label2.Text = "";
                            EXACTLYchek += 1;
                        }
                    }
                    if (type == 6)
                    {
                        
                        text3 = Math.Pow(text2, (double)1 / text1);
                        textBox1.Text = text3.ToString();
                        //textBox1.Text = Math.Pow(text2, (double)1 / text1).ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 7)
                    {

                        text3 = text2 % text1;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                }
                else
                {
                    text2 = textH;
                    text1 = Double.Parse(textBox1.Text);
                    if (type == 1)
                    {
                        if (text2 == 0)
                        {
                            label2.Font = new Font("Arial", 12, FontStyle.Bold);
                            label2.Text = "Неможлива операція. Натисніть 'CE' ";
                            EqualKey_Block();
                            textBox1.Text = "";
                        }
                        else
                        {
                            text3 = text1 / text2;
                            textBox1.Text = text3.ToString();
                            label2.Text = "";
                        }
                        EXACTLYchek += 1;

                    }
                    if (type == 2)
                    {

                        text3 = text1 * text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 3)
                    {

                        text3 = text1 - text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek = 1;
                    }
                    if (type == 4)
                    {

                        text3 = text1 + text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 5)
                    {
                        if (text2 == 0)
                        {
                            textBox1.Text = "1";
                        }
                        else if (text2 == 1)
                        {
                            textBox1.Text = text1.ToString();
                        }

                        else
                        {
                            text3 = text1;
                            for (int i = 2; i <= text2; i++)
                            {
                                text3 *= text1;
                            }
                            textBox1.Text = text3.ToString();
                            label2.Text = "";
                            EXACTLYchek += 1;
                        }
                    }
                    if (type == 6)
                    {

                        text3 = Math.Pow(text1, (double)1 / text2);
                        textBox1.Text = text3.ToString();
                        //textBox1.Text = Math.Pow(text2, (double)1 / text1).ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                    if (type == 7)
                    {

                        text3 = text1 % text2;
                        textBox1.Text = text3.ToString();
                        label2.Text = "";
                        EXACTLYchek += 1;
                    }
                }

                chekforZnak = "";
            }
        }


        // расположение кнопок в обычном режиме
        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(421, 541); 
            button1.Location = new Point(34, 369);
            button2.Location = new Point(104, 369);
            button3.Location = new Point(174, 369);
            button4.Location = new Point(34, 313);
            button5.Location = new Point(104, 313);
            button6.Location = new Point(174, 313);
            button7.Location = new Point(34, 257);
            button8.Location = new Point(104, 257);
            button9.Location = new Point(174, 257);
            button0.Location = new Point(34, 425);
            buttonCOMA.Location = new Point(174, 425);
            buttonDIVISION.Location = new Point(244, 257);
            buttonMULTIPLICATION.Location = new Point(244, 313);
            buttonMINUS.Location = new Point(244, 369);
            buttonPLUS.Location = new Point(244, 425);
            buttonPERSENT.Location = new Point(314, 257);
            buttonINVERSE.Location = new Point(314, 313);
            buttonEXACTLY.Location = new Point(314, 369);
            buttonBACK.Location = new Point(34, 201);
            buttonC.Location = new Point(174, 201);
            buttonCE.Location = new Point(104, 201);
            buttonPM.Location = new Point(244, 201);
            buttonSQRT.Location = new Point(314, 201);
            buttonMC.Location = new Point(34, 145);
            buttonMR.Location = new Point(104, 145);
            buttonMS.Location = new Point(174, 145);
            buttonMP.Location = new Point(244, 145);
            buttonMM.Location = new Point(314, 145);

        }

        private void buttonBACK_Click(object sender, EventArgs e) // "<-"
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch (Exception) { }
        }

        private void buttonCE_Click(object sender, EventArgs e) // "CE"
        {
            EqualKey_UnBlock();
            textBox1.Clear();
            type = 0;
            text1 = 0;
            text2 = 0;
            text3 = 0;
            textH = 0;
            label2.Text = "";
            chekforZnak = "CE";
        }

        private void buttonC_Click(object sender, EventArgs e) // "C"
        {
            textBox1.Text = "0";
        }
    public double PMHelp; //для смены знака
        private void buttonPM_Click(object sender, EventArgs e) // "+/-"
        {
            if (textBox1.Text != "")
            {
                PMHelp = Double.Parse(textBox1.Text) * (-1);
                textBox1.Text = PMHelp.ToString();
            }
            label2.Text = "";
            chekforZnak = "PM";
        }

        private void buttonSQRT_Click(object sender, EventArgs e) // "Корень квадратный"
        {
            if (textBox1.Text != "")
            {
                if (Double.Parse(textBox1.Text) < 0)
                {
                    label2.Font = new Font("Arial", 12, FontStyle.Bold);
                    label2.Text = "Неможлива операція. Натисніть 'CE' ";
                    EqualKey_Block();
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
                }
            }
            label2.Text = " ";
            chekforZnak = "sqrt";

        }

        private void buttonPERSENT_Click(object sender, EventArgs e) // "проценты"
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = (Convert.ToDouble(textBox1.Text)/100).ToString();
            }
            label2.Text = " ";
            chekforZnak = "persent";
        }

        private void buttonINVERSE_Click(object sender, EventArgs e) // "1/х"
        {
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                textBox1.Text = (1/Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (textBox1.Text == "0")
            {
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label2.Text = "Неможлива операція. Натисніть 'CE' ";
                EqualKey_Block();
                textBox1.Text = "";
            }
            label2.Text = " ";
            chekforZnak = "inverse";
        }

        private void buttonMC_Click(object sender, EventArgs e) // Очистить память
        {
            mem = 0;
            textBox2.Text = "";
            chekforZnak = "MC";
            buttonMP.Enabled = false;
            buttonMM.Enabled = false;
            buttonMR.Enabled = false;
        }

        private void buttonMR_Click(object sender, EventArgs e) // Считать из памяти
        {
            if (textBox2.Text != "")
            {
                buttonMR.Enabled = true;
                textBox1.Text = textBox2.Text;
                
            }
            else 
            {
                buttonMR.Enabled = false;
            }
            chekforZnak = "MR";
        }

        private void buttonMS_Click(object sender, EventArgs e) // Сохранить в память
        {
            if (textBox1.Text != "")
            {
                mem = Double.Parse(textBox1.Text);
                textBox2.Text = mem.ToString();
                textBox1.Text = "0";
                buttonMP.Enabled = true;
                buttonMM.Enabled = true;
                buttonMR.Enabled = true;
            }
            chekforZnak = "MS";
        }

        private void buttonMP_Click(object sender, EventArgs e) // "М+"
        {
            double Num2;
            if (textBox2.Text != "")
            {
                buttonMP.Enabled = true;
                Num2 = Double.Parse(textBox1.Text);
                mem += Num2;
                textBox2.Text = mem.ToString();
                textBox1.Text = "0";
                textBox1.MaxLength = 18;
            }
            else 
            {
                buttonMP.Enabled = false;
            }
            chekforZnak = "MP";
        }

        private void buttonMM_Click(object sender, EventArgs e) //"М-"
        {
            double Num2;
            if (textBox2.Text != "")
            {
                buttonMM.Enabled = true;
                Num2 = Double.Parse(textBox1.Text);
                mem -= Num2;
                textBox2.Text = mem.ToString();
                textBox1.Text = "0";
            }
            else
            {
                buttonMM.Enabled = false;
            }
            chekforZnak = "MM";
        }
        public string CopyAndPaste = "";
        private void копироватьCtrlCToolStripMenuItem_Click(object sender, EventArgs e) // Копировать из строки ввода
        {
            CopyAndPaste = textBox1.Text;
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e) // переход к инженерному виду
        {
            this.Size = new Size(819, 541);
        }

        private void buttonxV2_Click(object sender, EventArgs e) // х^2
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "x^2";
        }

        private void buttonxV3_Click(object sender, EventArgs e) // x^3
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "x^3";
        }

        private void buttonxVy_Click(object sender, EventArgs e) //x^y
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            EXACTLYchek = 0;
            if (textBox1.Text == "") // проверка на коректность
            {
                type = 5;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "^";
                chekforZnak = "^";
            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 4;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "^";
                chekforZnak = "^";
                textBox1.Text = "";
            }
           
        }

        private void buttonsqrt3x_Click(object sender, EventArgs e) // Корень кубический с х
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(Double.Parse(textBox1.Text), (double)1 / 3).ToString();
            }
            chekforZnak = "x^(1/3)";
        }

        private void buttonsqrtNx_Click(object sender, EventArgs e) // Корень n-го степени с x
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            EXACTLYchek = 0;
            if (textBox1.Text == "") // проверка на коректность
            {
                type = 6;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "x^(1/n)";
                chekforZnak = "x^(1/n)";
            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 6;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "x^(1/n)";
                chekforZnak = "x^(1/n)";
                textBox1.Text = "";
            }
            //if (textBox1.Text != "")
            //{
            //    textBox1.Text = Math.Pow(Double.Parse(textBox1.Text), (double)1 / ).ToString();
            //}
            //chekforZnak = "x^(1/n)";
        }
        double a;
        private void buttonFactorial_Click(object sender, EventArgs e) // n! не для всех чисел
        {
            if (textBox1.Text != "" && Double.Parse(textBox1.Text) > 0 && (Math.Floor(Double.Parse(textBox1.Text)) == Double.Parse(textBox1.Text))) // функция возвращения дробной чати числа почему то работает некоректно
            {
                int res = 1;
                for (int j = 1; j <= Double.Parse(textBox1.Text); j++)
                {
                    res *= j;
                }
                textBox1.Text = res.ToString();
                
            }
            chekforZnak = "n!";
            label2.Text = "";
        }

        private void button10Vx_Click(object sender, EventArgs e) // 10^x
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(10, (double)Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "10^x";
            label2.Text = "";
        }

        private void buttonln_Click(object sender, EventArgs e) // ln(x)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Log(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "ln";
            label2.Text = "";
        }

        private void buttonlg_Click(object sender, EventArgs e) //lg(x)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Log10(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "lg";
            label2.Text = "";
        }

        private void buttone_Click(object sender, EventArgs e) // "e"
        {
            textBox1.Text = Math.E.ToString();
        }

        private void buttonpi_Click(object sender, EventArgs e) //"pi"
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void buttonsin_Click(object sender, EventArgs e) // sin(x)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sin(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "sin";
            label2.Text = "";
        }

        private void buttoncos_Click(object sender, EventArgs e) // cos(x)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Cos(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "cos";
            label2.Text = "";
        }

        private void buttontg_Click(object sender, EventArgs e) //tg(x)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Tan(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "tan";
            label2.Text = "";
        }

        private void buttonmod_Click(object sender, EventArgs e) // Остача от деления
        {
            label2.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            EXACTLYchek = 0;
            if (textBox1.Text == "") // проверка на коректность
            {
                type = 7;
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "mod";
                chekforZnak = "mod";
            }
            else
            {
                buttonEXACTLY.PerformClick();
                type = 7;
                text1 = Convert.ToDouble(textBox1.Text);
                EXACTLYchek = 1;
                textBox1.Focus();
                label2.Text = "mod";
                chekforZnak = "mod";
                textBox1.Text = "";
            }
           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator v1.0\nBy Bevz D.O. FIOT IS-41(02) \ne-mail:dominusfortuna@gmail.com\nmob(life): +38(063)-27-94-073\nmob(Kievstar): +38(068)-86-78-320", "О программе калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonexp_Click(object sender, EventArgs e)// exp
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Exp(Double.Parse(textBox1.Text)).ToString();
            }
            chekforZnak = "tan";
            label2.Text = "";
        }

        private void просмотретьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.drive.google.com/file/d/0By0BT_3u9hd9UnVpclNBNnlBQUE/view");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






  

    }
}
