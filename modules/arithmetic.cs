namespace Modules.arithmetic;

public class Arithmetic
{
    public float FirstNum;
    public float SecondNum;

    //Function type void to show resulting's operation
    // This validate for that the result will be of type correct (float and numbers)
    public void showResult(dynamic result, params bool[] numbers)
    {
        // condition to validate if they are numbers
        if (numbers.All(x => x == true))
        {
            // Show the result in console 
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"El resultado es: {result}");
            Console.WriteLine("");
        }
        // In case that doesn't return in console a message
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Error! No se puede sumar letras y numeros");
        }

    }
    // Function static:  operate plus in the system
    //Level 1: "Manipulación Numérica Básica"
    public static float plusLevel(float firstNum, float secondNum)
    {
        float plus = firstNum + secondNum;
        // Console.WriteLine(plus);
        return plus;
    }
    
    // Function static: Operate average in the system
    public static double averageLevel(float average1, float average2, float average3)
    {
        float averages = average1 + average2 + average3;
        double average = averages / 3;
        return average;
    }

    public void meetingLevel(string firstName, string secondName)
    {
        Console.WriteLine($"Hola! {firstName}, {secondName}, es un gusto saludarte");
    }

    public void calculatorLevel(float firstNum, float secondNum, string typeOp, params bool[] numbers)
    {
        switch (typeOp)
        {
            case "+":

                float resultPlus = plusLevel(firstNum, secondNum);
                showResult(resultPlus, numbers);
                break;
            case "-":
                float resultRest = firstNum - secondNum;
                showResult(resultRest, numbers);
                break;
            case "*":
                float resultMultiplication = firstNum * secondNum;
                showResult(resultMultiplication, numbers);
                break;
            case "/":
                float resultDivide = firstNum / secondNum;
                showResult(resultDivide, numbers);
                break;
            default:
                Console.WriteLine("No se encontro signo logico para operar");
                break;
        }
    }

    public static List<int> listLevel(params int[] numbers)
    {
        List<int> listNumbers = new List<int>();
        foreach (var number in numbers)
        {
            listNumbers.Add(number);
        }
        Console.WriteLine($"Se han añadido los numeros a la lista ");
        return listNumbers;
    }
}

public static class LogicList
{
    public static void ListNumbers()
    {
        int sum = 0;
        Console.Write("Porfavor digite un numero: ");
        bool response1 = int.TryParse(Console.ReadLine(), out int number1);
        Console.Write("Porfavor digite un numero: ");
        bool response2 = int.TryParse(Console.ReadLine(), out int number2);
        Console.Write("Porfavor digite un numero: ");
        bool response3 = int.TryParse(Console.ReadLine(), out int number3);
        Console.Write("Porfavor digite un numero: ");
        bool response4 = int.TryParse(Console.ReadLine(), out int number4);
        Console.Write("Porfavor digite un numero: ");
        bool response5 = int.TryParse(Console.ReadLine(), out int number5);
        List<int> listNumber = Arithmetic.listLevel(number1, number2, number3, number4, number5);
        
        foreach (var number in listNumber)
        {
            sum += number;    
        }
        Console.WriteLine("");
        Console.WriteLine($"La suma de la lista de numeros es: {sum}");
        Console.WriteLine($"El numero mayor: {listNumber.Max()}");
        Console.WriteLine($"El numero menor: {listNumber.Min()}");
    }
}