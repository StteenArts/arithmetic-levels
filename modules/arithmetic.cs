namespace Modules.arithmetic;

public class Arithmetic
{
    public float firstNum;
    public float secondNum;


    public void showResult(float result, bool num1, bool num2)
    {
        if (num1 == true && num2 == true)
        {
            // Show the result in console 
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"El resultado es: {result}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"Error! No se puede sumar letras y numeros");
        }

    }
    public static float levelBasic(float firstNum, float secondNum)
    {
        float plus = firstNum + secondNum;
        // Console.WriteLine(plus);
        return plus;
    }
}