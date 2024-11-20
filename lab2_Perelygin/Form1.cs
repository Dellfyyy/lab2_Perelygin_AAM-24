namespace lab2_Perelygin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pricePerCup = 0;
            int cups = (int)numericUpDown1.Value;
            string coffeeType = comboBox1.SelectedItem.ToString();

            foreach (var item in checkedListBox1.CheckedItems) 
            { 
                pricePerCup += 0.5;
            }

            switch (coffeeType)
            {
                case "„ерный":
                    pricePerCup += 2.0;
                    break;
                case "Ёспрессо":
                    pricePerCup += 2.5;
                    break;
                case "Ћатте":
                    pricePerCup += 3.0;
                    break;
            }

            double totalCost = cups * pricePerCup;
            textBox1.Text = $"{totalCost}";
        }
    }
}
