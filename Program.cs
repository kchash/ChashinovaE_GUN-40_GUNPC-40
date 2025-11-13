class Program
{
    static void Cunc()
    {
        Console.Write("Enter first number ");
         if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number ");
            return;
        }
        
        Console.Write("Enter second number ");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number");
            return;
        }
        
        Console.Write("Enter operator &, |, ^ ");
        var s = Console.ReadLine();
        
        if (string.IsNullOrEmpty(s) || s.Length != 1 || (s[0] != '&' && s[0] != '|' && s[0] != '^'))
        {
            Console.WriteLine("Wrong operator!");
            return;
        }
        
        int result = 0;
        switch (s[0])
        {
            case '&':
                result = a & b; 
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Wrong operator");
                return;
        }
        Console.WriteLine("Number: " + result);
        Console.WriteLine("Binary: " + Convert.ToString(result, 2));
        Console.WriteLine("Hex: " + result.ToString("X"));
    }
}