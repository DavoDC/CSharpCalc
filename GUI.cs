namespace CSharpCalc
{
    /**
     * GUI 'back-end' code
     */
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
            double num1;
            double num2;
            try
            {
                // Try parsing as doubles
                num1 = Convert.ToDouble(Num1.Text);
                num2 = Convert.ToDouble(Num2.Text);
            }
            catch (Exception)
            {
                // Notify if there was an error parsing
                string errMsg = "Invalid numerical input. Please enter valid numbers.";
                Console.WriteLine(errMsg);
                Error.Text = errMsg;
                return;
            }

            // If parsing was successful
            Console.WriteLine("Parsed doubles successfully");
            Error.Text = "None";


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

                // Modulo
                case "%":
                    result = num1 % num2;
                    break;

                // Raise to Power
                case "^":
                    result = Math.Pow(num1, num2);
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

        /**
         * Division button action
         */
        private void Div_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        /**
         * Addition button action
         */
        private void Add_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        /**
         * Subtraction button action
         */
        private void Sub_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        /**
         * Modulo button action
         */
        private void Mod_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        /**
         * 'Raise to Power' button action
         */
        private void Pow_Click(object sender, EventArgs e)
        {
            doOperation(sender);
        }

        /**
         * Places result in num 1 box
         */
        private void Num1Place_Click(object sender, EventArgs e)
        {
            Num1.Text = Result.Text;
        }

        /**
         * Places result in num 2 box
         */
        private void Num2Place_Click(object sender, EventArgs e)
        {
            Num2.Text = Result.Text;
        }
    }
}