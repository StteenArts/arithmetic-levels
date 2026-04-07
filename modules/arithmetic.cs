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

public class Students
{
    public string nameStudent { get; set; }
    public string lastNameStudent { get; set; }
    
    public void student(string firstName, string secondName)
    {
        this.nameStudent = firstName;
        this.lastNameStudent = secondName;
    }
    
    public void addStudent(string firstName, string secondName, List<Students> listStudents)
    {
        Students student = new Students();
        student.nameStudent = firstName;
        student.lastNameStudent = secondName;
        
        listStudents.Add(student);
        // Console.WriteLine("Estudiante añadido con exito! ");
    }
    
    // Logic patron menu
    
    // Create student
    public void createStudent(List<Students> ListStudents)
    {
        Console.WriteLine("Digite el nombre del estudiante: ");
        string firstNameStudent = Console.ReadLine()??"No name";
        
        Console.WriteLine("Digite el apellido del estudiante: ");
        string lastNameStudent = Console.ReadLine()??"No last name";
        if(firstNameStudent == "" && lastNameStudent == "")
        {
            Console.WriteLine("El estudiante no puede estar vacío");
        }
        else
        {
            Console.WriteLine("Creando el estudiante...");
            addStudent(firstNameStudent, lastNameStudent, ListStudents);
            Console.WriteLine("Estudiante añadido a la lista con exito!");
        }
    }
    
    public void listStudents(List<Students> students)
    {
        Console.WriteLine("Lista de estudiantes");
        if (students.Count() > 0)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Nombre: {student.nameStudent}, Apellido: {student.lastNameStudent}");
            }
        }
        else
        {
            Console.WriteLine("La lista de estudiantes se encuentra vacía");
        }

    }

    public void deleteStudent(int indexStudent, List<Students> listStudents)
    {
        // Looking for if exist the index in the list
        if (listStudents.Count > 0 && indexStudent < listStudents.Count)
        {
            listStudents.RemoveAt(indexStudent);
        }
        else
        {
            Console.WriteLine("La lista se encuentra vacía o supera los limites esperados");
        }
        

    }

    
    
    
}