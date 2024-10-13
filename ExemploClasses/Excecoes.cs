try
{
    int divisor = 0;
    int result = 10 / divisor;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divisão por zero");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}