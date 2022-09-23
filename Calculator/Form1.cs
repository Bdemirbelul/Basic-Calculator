namespace Calculator
{
    public partial class Form1 : Form



    { 

        // hello welcome to the calculator by balamir demirkan belül 
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private double valuethird = 0;
        private decimal result = 0.0m;
        private string operations = "+";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text += "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text += "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text += "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operations = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operations = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear(); 
            operations = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operations = "x";
        }

        private void button11_Click(object sender, EventArgs e)
            
        {
            
            

            
            
            switch (operations)
            {
                case "+":
                    valuesecond = decimal.Parse(textBox2.Text);
                  
                    result = valuefirst + valuesecond;
                    textBox2.Text = result.ToString();
                    label1.Text = valuefirst + " " + operations +    " " + valuesecond;
                    break;

                case "-":
                    valuesecond = decimal.Parse(textBox2.Text);
                    result = valuefirst - valuesecond;
                    textBox2.Text = result.ToString();
                    label1.Text = valuefirst + " " + operations + " " + valuesecond;

                    break;
                case "/":
                    valuesecond = decimal.Parse(textBox2.Text);
                    result = valuefirst / valuesecond;
                    textBox2.Text = result.ToString();
                    label1.Text = valuefirst + " " + operations + " " + valuesecond;
                    break;
                case "x":
                    valuesecond = decimal.Parse(textBox2.Text);
                    result = valuefirst * valuesecond;
                    label1.Text = valuefirst + " " + operations + " " + valuesecond;
                    textBox2.Text = result.ToString();
                        break;
                case "Sqrt":
                  //there can be a problem in this section if you find it please try to help me :( 
                    valuethird = double.Parse(textBox2.Text);
                    result = (decimal)Math.Sqrt(valuethird);
                    label1.Text = operations +" " + valuethird;
                    textBox2.Text = result.ToString();
                    break;
                case "ýlovemath":
                    break;
                case "%":
                    valuesecond = decimal.Parse(textBox2.Text);
                    result = valuefirst * valuesecond / 100 ;
                    label1.Text =valuefirst + " "+ operations + " " + valuesecond;
                    textBox2.Text = result.ToString();
                    
                    break;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valuefirst = 0.0m;
            valuesecond = 0.0m;
            textBox2.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = result + " " + operations;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                textBox2.Text = textBox2.Text.Trim('-');
            }
            else
            {
                textBox2.Text = '-' + textBox2.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // ý dont understand why ým  having a problem with sqrt operation you need to give number twice Exp 64 sqrt 64 and it gives 8 :(((
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operations = "Sqrt";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operations = "%";
            //-... . -. .. / ... . ...- .. -.-- --- .-. ..- -- / -. . .... .. .-.
        }
    }
}