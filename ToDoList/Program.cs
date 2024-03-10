void drawTriangle()
{
    var stars = "";

    for(int i = 1; i <= 5; i++)
    {
        stars += "*";
        Console.WriteLine(stars);
    }
}

drawTriangle();


//Student student = new Student("Lucky");
//Console.WriteLine(student.Name);
//Console.WriteLine(student.Age);

//class Student
//{
//    public string Name;
//    public int Age;

//    public Student()
//    {

//    }

//    public Student(string name)
//    {
//        Name = name;
//    }

//    public Student(string name, int age) : this(name)
//    {
//        Age = age;
//    }
//}



//#region TODOAPP

//bool isExit = false;

//Console.WriteLine("Hello!");

//List<string> todoList = new List<string>();

//do
//{
//    Console.WriteLine("What do you want to do?");
//    Console.WriteLine("[S]ee all TODOs");
//    Console.WriteLine("[A]dd a TODO");
//    Console.WriteLine("[R]emove a TODO");
//    Console.WriteLine("[E]xit");

//    var userChoice = Console.ReadLine();

//    if (!string.IsNullOrEmpty(userChoice) && "SARE".Contains(userChoice.ToUpper()))
//    {
//        var convertedUserChoice = userChoice.ToUpper();

//        switch (convertedUserChoice)
//        {
//            case "S":
//                seeAllTODOS();
//                break;
//            case "A":
//                addTODO();
//                break;
//            case "R":
//                removeTODO();
//                break;
//            case "E":
//                isExit = true;
//                break;
//            default:
//                Console.WriteLine("Incorrect input");
//                break;
//        }
//    }
//} while (!isExit);

//void seeAllTODOS()
//{
//    if(todoList.Count == 0)
//    {
//        Console.WriteLine("No TODOs have been added yet.");
//        return;
//    }

//    for(int i = 0; i <  todoList.Count; i++)
//    {
//        Console.WriteLine($"{i+1}. {todoList[i]}");
//    }
//}

//void addTODO()
//{
//    bool isCorrectDescriptionGiven = false;
//    do
//    {
//        Console.WriteLine("Enter the TODO description:");
//        var newTodo = Console.ReadLine();
//        if(string.IsNullOrEmpty(newTodo))
//        {
//            Console.WriteLine("The description cannot be empty.");
//        }
//        else if(todoList.Contains(newTodo))
//        {
//            Console.WriteLine("The description must be unique.");
//        }
//        else
//        {
//            todoList.Add(newTodo);
//            isCorrectDescriptionGiven = true;
//            Console.WriteLine($"TODO successfully added: “{newTodo}” is printed to the console.");
//        }
//    } while (!isCorrectDescriptionGiven);
//}

//void removeTODO()
//{
//    bool isValidScenario = false;

//    do
//    {
//        Console.WriteLine("Select the index of the TODO you want to remove:");
//        seeAllTODOS();

//        var userIndexChoice = Console.ReadLine();

//        if (todoList.Count == 0)
//        {
//            Console.WriteLine("No TODOs have been added yet.");
//            isValidScenario = true;
//        }
//        else if (string.IsNullOrEmpty(userIndexChoice))
//        {
//            Console.WriteLine("Selected index cannot be empty.");
//        }
//        else if (!int.TryParse(userIndexChoice, out int index) || index < 0 || index >= todoList.Count)
//        {
//            Console.WriteLine("The given index is not valid.");
//        }
//        else
//        {
//            int.TryParse(userIndexChoice, out int num);
//            var removedTODO = todoList[num];
//            todoList.RemoveAt(num);
//            Console.WriteLine($"TODO removed: ${removedTODO}");
//            isValidScenario = true;
//        }
//    } while (!isValidScenario);
//}

//#endregion


