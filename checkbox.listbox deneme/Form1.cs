namespace checkbox.listbox_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = string.Empty, TCNO = string.Empty, cinsiyet = string.Empty, öðrenim = string.Empty, diller = string.Empty, uzmanlýk = string.Empty;

            TCNO = textBox2.Text;
            adsoyad = textBox1.Text;

            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
                öðrenim = radioButton3.Text;
            else if (radioButton4.Checked == true)
                öðrenim = radioButton4.Text;
            else if (radioButton5.Checked == true)
                öðrenim = radioButton5.Text;
            else if (radioButton6.Checked == true)
                öðrenim = radioButton6.Text;
            else if (radioButton7.Checked == true)
                öðrenim = radioButton7.Text;
            else if (radioButton8.Checked == true)
                öðrenim = radioButton8.Text;

            if (checkBox1.Checked == true)
                diller = diller + "," + checkBox1.Text;
            if (checkBox2.Checked == true)
                diller = diller + "," + checkBox2.Text;
            if (checkBox3.Checked == true)
                diller = diller + "," + checkBox3.Text;
            if (checkBox4.Checked == true)
                diller = diller + "," + checkBox4.Text;
            if (checkBox5.Checked == true)
                diller = diller + "," + checkBox5.Text;
            if (checkBox6.Checked == true)
                diller = diller + "," + checkBox6.Text;
            diller = diller.Substring(1);

            if (checkBox7.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox7.Text;
            if (checkBox8.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox8.Text;
            if (checkBox9.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox9.Text;
            if (checkBox10.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox10.Text;
            if (checkBox11.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox11.Text;
            if (checkBox12.Checked == true)
                uzmanlýk = uzmanlýk + "," + checkBox12.Text;
            uzmanlýk = uzmanlýk.Substring(1);

            listBox1.Items.Add("TC NO:" + TCNO + "  /  " + "Adý-Soyadý:" + adsoyad + "  /  " + "cinsiyet:" + cinsiyet + "  /  " + "Öðrenim Durumu:" + öðrenim + "  /  " + "Hakim Olduðu Diller:" + diller + "  /  " + "Yazýlýmda Uzmanlýk Alanlarý:" + uzmanlýk);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            if (radioButton1.Checked == true)
                radioButton1.Checked = false;
            else if (radioButton2.Checked == true)
                radioButton2.Checked = false;


            if (radioButton3.Checked == true)
                radioButton3.Checked = false;
            else if (radioButton4.Checked == true)
                radioButton4.Checked = false;
            else if (radioButton5.Checked == true)
                radioButton5.Checked = false;
            else if (radioButton6.Checked == true)
                radioButton6.Checked = false;
            else if (radioButton7.Checked == true)
                radioButton7.Checked = false;
            else if (radioButton8.Checked == true)
                radioButton8.Checked = false;

            if (checkBox1.Checked == true)
                checkBox1.Checked = false;
            if (checkBox2.Checked == true)
                checkBox2.Checked = false;
            if (checkBox3.Checked == true)
                checkBox3.Checked = false;
            if (checkBox4.Checked == true)
                checkBox4.Checked = false;
            if (checkBox5.Checked == true)
                checkBox5.Checked = false;
            if (checkBox6.Checked == true)
                checkBox6.Checked = false;

            if (checkBox7.Checked == true)
                checkBox7.Checked = false;
            if (checkBox8.Checked == true)
                checkBox8.Checked = false;
            if (checkBox9.Checked == true)
                checkBox9.Checked = false;
            if (checkBox10.Checked == true)
                checkBox10.Checked = false;
            if (checkBox11.Checked == true)
                checkBox11.Checked = false;
            if (checkBox12.Checked == true)
                checkBox12.Checked = false;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
                this.BackColor = Color.Gray;

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
                this.BackColor = Color.Red;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
                this.BackColor = Color.White;
        }
    }
}