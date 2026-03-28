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
        Nivel 8: Programación Orientada a Objetos (Clases)
        Nivel 9: CRUD de Objetos (Listas de objetos)
        Nivel 10: Salir
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
            
            float result = Arithmetic.levelBasic(num1, num2);
            viewResult.showResult(result, validate1, validate2);
            
            break;
        case 2:
          
            break;
        case 3:
           
            
            break;
        case 4:
            
            break;
        default:
            Console.WriteLine("Porfavor seleccione una opción valida ");
            continue;
        
    }
}