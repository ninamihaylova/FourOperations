class FourOperations
{
    static void Main(string[] args)

    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double additionSum = firstNumber + secondNumber;
        double subtractionSum = firstNumber - secondNumber;
        double multiplicationSum = firstNumber * secondNumber;
        double divisionSum = firstNumber / secondNumber;
        
        Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {firstNumber+secondNumber:F2}");
        Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {firstNumber-secondNumber:F2}");
        Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {firstNumber*secondNumber:F2}");
        Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {firstNumber/secondNumber:F2}");
        

    }
}