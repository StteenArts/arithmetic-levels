using Modules.arithmetic;

// The control of ours system
bool cycle = true;
Arithmetic viewResult = new Arithmetic();
while (cycle)
{
    Console.WriteLine("");
    Console.WriteLine(@"
        --- Centro de Entrenamiento Técnico ---

        Nivel 1: Suma y validación numérica
        Nivel 2: Cálculo y condicionales
        Nivel 3: Manipulación de Cadenas
        Nivel 4: Operaciones Lógicas (Calculadora)
        Nivel 5: Análisis Numérico (Listas de enteros)
        Nivel 6: Gestión de Tareas (Listas de cadenas)
        Nivel 7: Arreglos y Búsqueda
        Nivel 8: Colecciones de Objetos (Clases List<estudiante>)
        Nivel 9: Salir
    ");
    Console.Write("Seleccione un nivel para iniciar >: ");
    string choise = Console.ReadLine()!;
    bool next = int.TryParse(choise, out int choiseInt);
    
    // Validation to know if the writter by users is one number
    if (next == false)
    {
        Console.WriteLine("Porfavor digite un valor valido del menú y no letras!");
        continue;
    }
    
    // In case that takes an option we continue with her choise
    switch (choiseInt)
    {
        // Questions for register pascient
        case 1:
            Console.Write("Nivel 1: Suma y validación numérica");
            Console.WriteLine("");
            
            Console.Write("Porfavor digite el primer numero: ");
            bool validate1 = float.TryParse(Console.ReadLine(), out float num1);
            
            Console.Write("Porfavor digite el segundo numero: ");
            bool validate2 =float.TryParse(Console.ReadLine(), out float num2);
            
            float resultPlus = Arithmetic.plusLevel(num1, num2);
            viewResult.showResult(resultPlus, validate1, validate2);
            
            break;
        case 2:
            Console.WriteLine("Nivel 2: Calculo y condicionales");
            Console.WriteLine("");
            
            // Form request numbers
            Console.Write("Porfavor digite la (Primera) calificación: ");
            bool response1 = float.TryParse(Console.ReadLine(), out float average1);
            Console.Write("Porfavor digite la (Segunda) calificación: ");
            bool response2 = float.TryParse(Console.ReadLine(), out float average2);
            Console.Write("Porfavor digite la (Tercera) calificación: ");
            bool response3 = float.TryParse(Console.ReadLine(), out float average3);
            
            // Operational Mathematics
            double averageResult = Arithmetic.averageLevel(average1, average2, average3);
            viewResult.showResult(averageResult, response1, response2,response3);
            
            break;
        case 3:
            Console.WriteLine("Nivel 3: Manipulación de Cadenas");
            Console.WriteLine("");
            
            // Form request names
            Console.Write("Porfavor digite su primer Nombre: ");
            string firstName = Console.ReadLine()!;
            Console.Write("Porfavor digite su segundo Nombre: ");
            string secondName = Console.ReadLine()!;
            
            // Meeting
            viewResult.meetingLevel(firstName, secondName);
            
            break;
        case 4:
            Console.WriteLine("Nivel 4: Operaciones Lógicas y Control de Flujo");
            Console.WriteLine("");
            
            // Form request numbers
            Console.Write("Porfavor digite el primer número: ");
            bool calc1 = float.TryParse(Console.ReadLine(), out float number1);
            Console.Write("Porfavor digite el segundo número: ");
            bool calc2 = float.TryParse(Console.ReadLine(), out float number2);
            Console.Write("Porfavor digite el tipo de calculo (+, -, /, *): ");
            string type = Console.ReadLine()!;
            viewResult.calculatorLevel(number1, number2, type, calc1, calc2);
            
            break;
        case 5:
            Console.WriteLine("Nivel 5: Análisis Numérico");
            Console.WriteLine("");
            
            // Form request numbers
            LogicList.ListNumbers();
            break;
        default:
            Console.WriteLine("Porfavor seleccione una opción valida ");
            continue;
        
    }
}