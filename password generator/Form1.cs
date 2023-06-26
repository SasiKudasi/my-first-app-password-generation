namespace password_generator
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random first = new Random();
            int b1 = first.Next(10);
            int b2 = first.Next(10);
            string[] chars  = new string[] {"!", "Ф", "#", "$", "%", "&", "Т", "(", ")", "*"};
            string b3 = chars[new Random().Next(0, chars.Length)];
            string b4 = chars[new Random().Next(0, chars.Length)];
            string b5 = chars[new Random().Next(0, chars.Length)];
            string[] symbols = new string[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
            string b6 = symbols[new Random().Next(0, symbols.Length)];
            string b7 = symbols[new Random().Next(0, symbols.Length)];
            string b8 = symbols[new Random().Next(0, symbols.Length)];
            int b10 = first.Next(10);
            int b11 = first.Next(10);
            int b12 = first.Next(10);

            string identif = Convert.ToString(maskedTextBox2.Text);
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            foreach (char i in identif)
            {
                if (char.IsUpper(i)==true)
                {
                    upperCase.Add(i.ToString());
                }
               else if (char.IsUpper(i)==false)
                {lowerCase.Add(i.ToString());

                }
            }
            int length = lowerCase.Count;
            int P = ((length ^ 2) % 10) + ((length ^ 3) % 10) + 1;
            string b9 = lowerCase[P];

            var password = b1.ToString() + b2.ToString() + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10.ToString() + b11.ToString() + b12.ToString();
               maskedTextBox1.Text = password;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (Keys)e.KeyChar == Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || (Keys)e.KeyChar == Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("ƒопустимы только латинские буквы и цифры!");
            }
        }
    }
}