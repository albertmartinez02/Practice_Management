/*Goal for today: Go ahead and apply the singleton to the client and project service in order to clean up the menu code here. We'll keep Menu here, but basically update the
 * switch statement so that it hopefully has fewer lines of code. We'll move it over to the client and project service.
 * We're gonna have a main menu, a client menu, and a project menu */


/*using Practice_Management;
using Practice_Management.Library.Services;
using Practice_Management.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Menus
{

    public static void ClientMenu()
    {
        Console.WriteLine("Enter letter corresponding to preferred action:");
        Console.WriteLine("a) Add a Client");
        Console.WriteLine("b) Display Client Information");
        Console.WriteLine("c) Update Client Information");
        Console.WriteLine("   This includes adding a project, adding a Close Date to client interaction, marking client as inactive, or adding notes to record.");
        Console.WriteLine("d) Delete Client");
        Console.WriteLine("e) Return to main menu");
    }
    public static void ProjectMenu()
    {
        Console.WriteLine("Enter letter corresponding to preferred action:");
        Console.WriteLine("a) Add a Project");
        Console.WriteLine("b) Display Project Information");
        Console.WriteLine("c) Update Project Information");
        Console.WriteLine("   This includes adding a Close Date to the project, marking project as inactive, or changing the short and long name of the project.");
        Console.WriteLine("d) Delete Project");
        Console.WriteLine("e) Return to main menu");
    }

    public static void MainMenu()
    {
        Console.WriteLine("Practice Management");
        Console.WriteLine("1) Client Management");
        Console.WriteLine("2) Project Management");
        Console.WriteLine("3) Exit");
    }

    public static void ClientUpdateMenu()
    {
        Console.WriteLine("\nFirst enter client ID , then enter letter corresponding to preferred action: ");
        Console.WriteLine("a) Update close date for client transactions");
        Console.WriteLine("b) Update client name");
        Console.WriteLine("c) Update notes");
        Console.WriteLine("d) Mark as inactive");
        Console.WriteLine("e) Mark as active");
        Console.WriteLine("f) Add a project to project list");
    }

    public static void ProjectUpdateMenu()
    {
        Console.WriteLine("\nEnter letter corresponding to preferred action: ");
        Console.WriteLine("a) Update close date for project");
        Console.WriteLine("b) Update short name for project");
        Console.WriteLine("c) Update long name for project");
        Console.WriteLine("d) Mark as inactive");
        Console.WriteLine("e) Mark as active");
    }
    public void ClientCRUD() //CRUD Functionality of class Menu
    {
        var clientservice = ClientService.Current;
        ClientMenu();
        var c = Console.ReadLine() ?? string.Empty;
        while (c != "e")
        {
            switch (c)
            {
                case "a": //Create Client
                    Client cl = new Client();
                    clientservice.Add(cl);
                    break;
                case "b": //Display Client Information
                    clientservice.Read();
                    break;
                case "c": //Update Client Information
                    Console.WriteLine("Client ID: ");
                    var cid = int.Parse(Console.ReadLine() ?? "0");
                    clientservice.Update(cid);
                    break;
                case "d": //Delete Client Information
                    Console.WriteLine("Enter client ID of associated client: ");
                    var i = int.Parse(Console.ReadLine() ?? "0");
                    clientservice.Delete(i);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
            ClientMenu();
            c = Console.ReadLine() ?? string.Empty;
        }
        MainMenu(); 
    }

    public void ProjectCRUD()
    {
        var clientservice = ClientService.Current;
        ProjectMenu();
        var c = Console.ReadLine() ?? string.Empty; 
        while (c != "e")
        {
            switch (c)
            {
                case "a":
                    Console.WriteLine("First enter a Client ID to associate with the project: ");
                    var cid = int.Parse(Console.ReadLine() ?? "0");
                    //clientservice.addProject(cid);
                    break;
                case "b":
                    //clientservice.readProjects();
                    break;
                case "c":
                    Console.WriteLine("Enter the Client ID: ");
                    var Cid = int.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Enter the Project ID: ");
                    var pid = int.Parse(Console.ReadLine() ?? "0");

                    ProjectUpdateMenu();
                    //clientservice.updateProject(Cid, pid);
                    break;
                case "d":
                    //clientservice.removeProject();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            ProjectMenu();
            c = Console.ReadLine() ?? string.Empty;
        }
        MainMenu();
    }
}

class Client_Project_List
{
    public static void Main()
    {
        Menus m = new Menus();
        var clientservice = ClientService.Current;
        Menus.MainMenu();
        var choiceMenu = int.Parse(Console.ReadLine() ?? "0");
        while (choiceMenu != 3)
        {
            if (choiceMenu == 1)
            {
                m.ClientCRUD();
            }
            else if (choiceMenu == 2)
            {
                m.ProjectCRUD();
            }
            else { Console.WriteLine("Invalid Input"); }
            choiceMenu = int.Parse(Console.ReadLine() ?? "0");
        }


    }
}
  */