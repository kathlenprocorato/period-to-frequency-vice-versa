namespace Period_to_Frequency_vice_versa
{
    public partial class PeriodToFrequencyConverter : Form
    {
        public Button selectedButton = new Button();
        public Period_Frequency_Converter pfs = new Period_Frequency_Converter();
        public PeriodToFrequencyConverter()
        {
            InitializeComponent();
            comboBox1.Items.Add("Period");
            comboBox1.Items.Add("Frequency");



            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

            button12.Enabled = false;

            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button15.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if ()
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //set select frequency buttons true
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;

                //set select frequency buttons false
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = true;

                //set converting period buttons false
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;

                //frequency converting buttons true
                button15.Enabled = true;
                button14.Enabled = true;
                button13.Enabled = true;
                button12.Enabled = true;
                button1.Enabled = true;

                label2.Text = "Frequency";

                if (textBox1 != null)
                {

                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                //set select frequency buttons false
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;

                //set select frequency buttons true
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;

                //set converting period buttons true
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                //frequency converting buttons false
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                button12.Enabled = false;
                button1.Enabled = false;

                label2.Text = "Period";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedButton = button2;
            button2.BackColor = Color.AliceBlue;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedButton = button3;
            button2.BackColor = Color.White;
            button3.BackColor = Color.AliceBlue;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedButton = button4;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.AliceBlue;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedButton = button5;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.AliceBlue;
            button6.BackColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedButton = button7;
            button7.BackColor = Color.AliceBlue;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedButton = button8;
            button7.BackColor = Color.White;
            button8.BackColor = Color.AliceBlue;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedButton = button9;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.AliceBlue;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedButton = button10;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.AliceBlue;
            button11.BackColor = Color.White;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectedButton = button11;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.AliceBlue;
        }

        //conversion to seconds
        private void button20_Click(object sender, EventArgs e)
        {
            var result = pfs.FrequencyToPeriod(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button20.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var result = pfs.PeriodToFrequency(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button15.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var result = pfs.FrequencyToPeriod(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button19.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var result = pfs.FrequencyToPeriod(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button18.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var result = pfs.FrequencyToPeriod(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button17.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var result = pfs.FrequencyToPeriod(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button16.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var result = pfs.PeriodToFrequency(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button14.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var result = pfs.PeriodToFrequency(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button13.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            var result = pfs.PeriodToFrequency(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button12.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = pfs.PeriodToFrequency(Convert.ToDouble(textBox1.Text), (selectedButton.Text).ToString(), (button1.Text).ToString());
            textBox2.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedButton = button6;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.AliceBlue;
        }
    }
}