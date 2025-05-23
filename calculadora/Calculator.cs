namespace Operations
{
    public class Calculator
    {
        public string Add(double a, double b)
        {
            double result = a + b;
            return OperationResult(result);
        }

        public string Substract(double a, double b)
        {
            double result = a - b;
            return OperationResult(result);
        }

        public string Multiply(double a, double b)
        {
            double result = a * b;
            return OperationResult(result);
        }

        public string Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }
            double result = a / b;
            return OperationResult(result);
        }

        private string OperationResult(double result)
        {
            return $"The result of the operation is: {result}";
        }
    }
}