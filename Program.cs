using Modules.arithmetic;

// The control of ours system
bool cycle = true;
Arithmetic viewResult = new Arithmetic();
Students toolS = new Students();
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
        case 6:
            Console.WriteLine("Nivel 6: Gestión de Tareas (List<string>)");
            Console.WriteLine("");
            // Declare a variable to manage another cycle
            bool subMenuTasks = true;
            // List of tasks created
            List<string> listTaks = new List<string>();
            
            // submenu to management tasks
            while (subMenuTasks)
            {
                Console.WriteLine(@"
                    --- Centro de Entrenamiento Técnico ---

                    Nivel 1: Agregar Tarea
                    Nivel 2: Ver Tareas
                    Nivel 3: Eliminar Tarea
                    Nivel 4: Salir
                ");
                bool subMenu = int.TryParse(Console.ReadLine(), out int choiceTask);
                if (subMenu == false)
                {
                    //Repeat the cycle
                    Console.WriteLine("Porfavor digite solo números validos para el menú");
                }
                //EN caso de que haya seleccionado un valor valido ingresa a la seleccion
                else
                {
                    switch (choiceTask)
                    {
                        case 1:
                            Console.Write("Nombre: ");
                            string nameTask = Console.ReadLine()!;
                            listTaks.Add(nameTask);
                            Console.WriteLine($"Tarea: {listTaks} creada exitosamente");
                            break;
                        case 2:
                            Console.WriteLine("Tareas: ");
                            Console.Write("Nombre: ");
                            foreach (var task in listTaks)
                            {
                                Console.WriteLine($"{task}");
                                Console.Write("");
                            }
                            break;
                        case 3:
                            Console.Write("Id de la tarea a eliminar: ");
                            bool trueResponse = int.TryParse(Console.ReadLine(), out int idTask);
                            if (trueResponse == false)
                            {
                                Console.WriteLine("Un id no puede ser letras solo indice (Números enteros)");
                            }
                            else
                            {
                                Console.WriteLine($"Tarea: {listTaks[idTask]} Siendo eliminado");
                                listTaks.RemoveAt(idTask);
                                Console.WriteLine($"Tarea Eliminado existosamente");
                            }
                            break;
                        case 4:
                            Console.Write("HASTA LUEGO!.... ");
                            subMenuTasks = false;
                            break;
                        default:
                            Console.WriteLine("Porfavor digite un valor del rango del menú");
                            break;
                    }
                }
            }
            break;
        case 7:
            // Array 5 citys
            string[] cities = { "Bogotá", "Medellín", "Cali", "Barranquilla", "Cartagena" };
            // Request city name to user
            Console.Write("Ingrese el nombre de una ciudad: ");
            string cityToSearch = Console.ReadLine()??"";
            bool hastCity = cities.Any(c => c == cityToSearch);
            if (hastCity == false)
            {
                Console.WriteLine($"La ciudad {cityToSearch} no ha sido ENCONTRADA!");
            }
            else
            {
                Console.WriteLine($"La ciudad {cityToSearch} ha sido ENCONTRADO!");
            }
            
            break;
        case 8:
            // Objects list
            List<Students> students = new List<Students>();
            // subCycleMenu
            bool cycleStudents = true;
            while (cycleStudents)
            {
                // show menu to user
                Console.WriteLine(@"
                    *** Gestion de estudiantes ***
                    1. Registrar Estudiante
                    2. Listar Estudiante
                    3. Eliminar Estudiante
                    4. Salir al menú
                ");
                bool optStudents = int.TryParse(Console.ReadLine(), out int choiceMenuStudent);
                if (optStudents == false)
                {
                    Console.Clear();
                    Console.WriteLine("Porfavor digite un valor númerico del menú");
                }
                else
                {
                    switch (choiceMenuStudent)
                    {
                        case 1:
                            // Form to create student
                            toolS.createStudent(students);
                            break;
                        case 2:
                            // Section to show values a list of students
                            toolS.listStudents(students);
                            break;
                        case 3:
                            // Delete student by index
                            Console.WriteLine("Porfavor ingrese el indice del estudiante: ");
                            bool indexStudent =  int.TryParse(Console.ReadLine(), out int idStudent);
                            if (indexStudent == false)
                            {
                                Console.WriteLine("Un indice no puede ser letras");
                            }
                            else
                            {
                                toolS.deleteStudent(idStudent, students);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Saliendo del sistema....");
                            cycleStudents = false;
                           
                            break;
                        default:
                            Console.WriteLine($"Porfavor elige un rango valido 1 al 4 para salir");
                            break;
                    }
                }
            }
            
            break;
        default:
            Console.WriteLine("Porfavor seleccione una opción valida ");
            continue;
        
    }
}