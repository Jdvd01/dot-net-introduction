namespace Operations
{
    public static class Calculator
    {
        public static string Add(double a, double b)
        {
            double result = a + b;
            return OperationResult(result);
        }

        public static string Substract(double a, double b)
        {
            double result = a - b;
            return OperationResult(result);
        }

        public static string Multiply(double a, double b)
        {
            double result = a * b;
            return OperationResult(result);
        }

        public static string Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }
            double result = a / b;
            return OperationResult(result);
        }

        private static string OperationResult(double result)
        {
            return $"The result of the operation is: {result}";
        }
    }
}