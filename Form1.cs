namespace ASC_AutomatDeVanzari
{
    public partial class Form1 : Form
    {
        static int cents = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void HistoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NickelButton_Click(object sender, EventArgs e)
        {
            cents += 5;
            PrelucrareDate(ref cents);
        }

        private void DimeButton_Click(object sender, EventArgs e)
        {
            cents += 10;
            PrelucrareDate(ref cents);
        }

        private void QuarterButton_Click(object sender, EventArgs e)
        {
            cents += 25;
            if (cents == 40)
            {
                HistoryTextBox.Text += "Produs eliberat, 2 monede Dime rest\r\n";
                cents %= 20;
                RefreshCentsLabel(CentsLabel);
            }
            else 
            { 
                PrelucrareDate(ref cents); 
            }
            
        }

        private void PrelucrareDate(ref int cents)
        {
            if (cents >= 20)
            {
                cents %= 20;
                RestCents(cents);
                cents = 0;
            }
            RefreshCentsLabel(CentsLabel);
        }
        private void RestCents(int cents)
        {
            switch(cents) 
            {
                case 0: HistoryTextBox.Text += "Produs eliberat, nici-un cent rest\r\n";break;
                case 5: HistoryTextBox.Text += "Produs eliberat, un Nickel rest\r\n"; break;
                case 10: HistoryTextBox.Text += "Produs eliberat, un Dime rest\r\n"; break;
                case 15: HistoryTextBox.Text += "Produs eliberat, un Nickel si un Dime rest\r\n"; break;
                default:throw new Exception();
            }
        }
        private static void RefreshCentsLabel(Label centsLabel)
        {
            centsLabel.Text = $"Cents: {cents}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}