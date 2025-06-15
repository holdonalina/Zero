Console.WriteLine("Enter the first number:");
bool numberA = int.TryParse(Console.ReadLine(), out var a);

Console.WriteLine("Enter the operator(+, -, * or /):");
string operators = Console.ReadLine();

Console.WriteLine("Enter the second number:");
bool numberB = int.TryParse(Console.ReadLine(), out var b);

try
{
  if (operators == "/" && b == 0)
  {
    throw new Exception("Divide by 0");
  }
  double result = operators switch
  {
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,
    "/" => a / b,
  };
  Console.WriteLine($"{a} {operators} {b} = {result}");
}
catch (Exception)
{
  Console.WriteLine("Divide by 0 is not possible");
}
