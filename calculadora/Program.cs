using Operations;

Operations.Calculator calculator = new Operations.Calculator();

string myAddResult = calculator.Add(5, 10);
Console.WriteLine(myAddResult);

string mySubstractResult = calculator.Substract(5, 10);
Console.WriteLine(mySubstractResult);

string myMultiplyResult = calculator.Multiply(5, 10);
Console.WriteLine(myMultiplyResult);

string myDivideResult = calculator.Divide(5, 10);
Console.WriteLine(myDivideResult);
