namespace CSharpCalc
{
    public partial class GUI : Form
    {
        /**
         * GUI Constructor
         */ 
        public GUI()
        {
            InitializeComponent();
        }

        /**
         * Helper method for doing operations
         */
        private void doOperation(object sender)
        {
            // Get numbers
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);

            // Get operation
            Button button = (Button) sender;
            string operation = button.Text;

            // Do operation
            double result = 0;
            switch (operation)
            {
                // Multiplication
                case "x":
                    result = num1 * num2;
                    break;

                // Division
                case "/":
                    result = num1 / num2;
                    break;

                // Addition
                case "+":
                    result = num1 + num2;
                    break;

                // Subtraction
                case "-":
                    result = num1 - num2;
                    break;

            }

            // Show result
            Result.Text = "" + result;
        }

        /**
         * Multiply button action
         */ 
        private void Mult_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        private void Div_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }
    }
}