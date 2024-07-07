// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

void Main()
{
    Welcome();
    Todo();
    End();
}


void Welcome()
{
    Console.WriteLine("Welcome to my 'Simple ToDo'");
}


void Todo()
{
    bool isExit = true;
    List<string> userToDoList = ["hello", "goodbye"];    
    do
    {
        Console.WriteLine("What do you want to do?\n[S]ee all todos\n[A]dd a todo\n[R]emove a todo\n[E]xit");
        string userChoice = Console.ReadLine().ToLower();
        if(ChoiceIsCorrect(userChoice))
        TodoAction(userChoice, out isExit, ref userToDoList);
        else
        {
            Console.WriteLine("Incorrect Input");
        }
    }
    while (isExit);
}


bool ChoiceIsCorrect(string userChoice)
{
    if(userChoice == "s" || userChoice == "a" || userChoice == "r" || userChoice == "e")
    {
        return true;
    }
    else
    {
        return false;
    }
}


void TodoAction(string userChoice, out bool isExit, ref List<string> userToDoList)
{
    switch (userChoice)
    {
        case "s":
            if (userToDoList.Count > 0)
            {
                int index = 1;
                foreach (string element in userToDoList)
                {
                    Console.WriteLine($"{index}: {element}");
                    index++;
                }
            }
            else
            {
                Console.WriteLine("Todo list is empty");
            }
            isExit = true;
            break;
        case "a":
            bool isAdded = false;
            do
            {
                Console.WriteLine("Input your todo");
                string description = Console.ReadLine();
                if (!userToDoList.Contains(description))
                {
                    userToDoList.Add(description);
                    isAdded = true;
                    Console.WriteLine("Todo is added");
                }
                else
                {
                    Console.WriteLine("This todo already exist");
                }
            }
            while (!isAdded);
            isExit = true;
            break;
        case "r":
            bool isRemoved = false;
            if (userToDoList.Count < 1)
            {
                Console.WriteLine("Todo list is empty");
            }
            else
            {
                do
                {

                    Console.WriteLine("Input index of removing todo");
                    var removeIndexString = Console.ReadLine();
                    if (int.TryParse(removeIndexString, out int removeIndex) && removeIndex <= userToDoList.Count)
                    {
                        userToDoList.RemoveAt(removeIndex - 1);
                        isRemoved = true;
                        Console.WriteLine("Todo is removed");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input");
                    }
                }
                while (!isRemoved);
            }
            isExit = true;
            break;
        default:
            isExit = false;
            break;
    }
}


void End()
{
    Console.WriteLine("Thanks for using my 'Simple ToDo'");
}


Main();