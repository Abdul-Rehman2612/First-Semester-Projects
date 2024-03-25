using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using SpaceX.BL;

namespace SpaceX
{
    internal class Program
    {
        static void Main()
        {
            List<Ships> ships = new List<Ships>(); // list of ships data that contains Passengers data and Details for each ship
            // menus arrays
            string[] menu = new string[]{ "Manage Ships", "Manage Passengers", "View Stats", "Exit" };
            string[] ManagePassengerMenu = new string[] { "Add Passenger", "Remove Passenger", "Update Passenger", "Search Passenger", "View All Passengers","Exit" };
            string[] ManageShipsMenu = new string[] { "Add Ship", "Remove Ship", "Update Ship", "Search Ship", "View All Ships", "Exit" };
            string[] ViewStats = new string[] {"View Ship Passengers","View All Ships Stats"};
            string[] MenuHeader = new string[] { "Add Ship","Remove Ship","Update Ship","Search Ship","View Ships","Add Passenger","Remove Passenger","Update Passenger","Search Passenger","View All Passengers","View Ship Passengers","View All Ships Data"};
            while (true) // loops continues till user wants to exit
            {
                Header();
                StartMenuHeader();
                string option = PrintMenu(menu);
                if (option =="1")
                {
                    while (true) // loops continues till user wants to exit
                    {
                        Header();
                        string Choice = PrintMenu(ManageShipsMenu); // user choice for managing ships
                        if (Choice=="1") // user enters 1 to add ship
                        {
                            Header();
                            PrintSubHeader(MenuHeader[0]);
                            AddShips(ships);
                        }
                        else if (Choice=="2") // user enters 2 to remove ship
                        {
                            Header();
                            PrintSubHeader(MenuHeader[1]);
                            RemoveShip(ships);
                        }
                        else if (Choice=="3") // user enters 3 to update ship
                        {
                            Header();
                            PrintSubHeader(MenuHeader[2]);
                            UpdateShip(ships);
                        }
                        else if (Choice=="4") // user enters 4 to search ship
                        {
                            Header();
                            PrintSubHeader(MenuHeader[3]);
                            SearchShip(ships);
                        }
                        else if (Choice=="5") // user enters 5 to view all ships
                        {
                            Header();
                            PrintSubHeader(MenuHeader[4]);
                            ViewAllShips(ships);
                        }
                        else if (Choice=="6") // user enters 6 to return to main menu
                        {
                            break;
                        }
                        else // if user enters wrong choice
                        {
                            PressAnyKey("Wrong UserChoice!", 50, 30);
                        }
                    }
                }
                else if (option=="2")
                {
                    while (true) // loops continues till user wants to exit
                    {
                        Header();
                        string Choice = PrintMenu(ManagePassengerMenu); // user choice for managing passengers
                        if (Choice=="1") // user enters 1 to add passenger
                        {
                            Header();
                            PrintSubHeader(MenuHeader[5]);
                            
                        }
                        else if (Choice=="2") // user enters 2 to remove passenger
                        {
                            Header();
                            PrintSubHeader(MenuHeader[6]);
                        }
                        else if (Choice=="3") // user enters 3 to update passenger
                        {
                            Header();
                            PrintSubHeader(MenuHeader[7]);
                        }
                        else if (Choice=="4") // user enters 4 to search passenger
                        {
                            Header();
                            PrintSubHeader(MenuHeader[8]);
                        }
                        else if (Choice=="5") // user enters 5 to view all passengers
                        {
                            Header();
                            PrintSubHeader(MenuHeader[9]);
                        }
                        else if (Choice=="6") // user enters 6 to return to main menu
                        {
                            break;
                        }
                        else // if user enters wrong choice
                        {
                            PressAnyKey("Wrong UserChoice!", 50, 30);
                        }
                    }
                }
                else if(option == "3")
                {
                    while (true) // loops continues till user wants to exit
                    {
                        Header();
                        string Choice = PrintMenu(ViewStats); // user choice for viewing ships stats
                        if (Choice=="1") // user enters 1 to view specific ship passengers
                        {

                        }
                        else if(Choice=="2") // user enters 2 to view all ships stats
                        {

                        }
                        else if(Choice=="3") // user enters 3 to return to main menu
                        {

                        }
                        else // if user enters wrong choice
                        {
                            PressAnyKey("Wrong userChoice!", 50, 26);
                        }
                    }
                }
                else if(option =="4") // user enters 4 to exit application
                {
                    Environment.Exit(0);
                }
                else // if user enters wrong choice
                {
                    PressAnyKey("Wrong UserChoice!", 50, 28);
                }
            }
        }
        // functions
        // prints menus
        static string PrintMenu(string[] menu)
        {
            int y = 23;
            for (int i = 0; i < menu.Length; i++) // loops continue till attributes printed
            {
                PrintStatementAtXY($"{i+1}-{menu[i]}",50,y);
                y++;
            }
            y++;
            PrintStatementAtXY("Enter option...", 50, y);
            string option = Inputs(); // user choice input
            return option;

        }
        // prints statement at a specific position
        static void PrintStatementAtXY(string statement,int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(statement);
        }
        // asks user to press any key to continue
        static void PressAnyKey(string statement,int x,int y)
        {
            PrintStatementAtXY(statement,x,y);
            PrintStatementAtXY("Press any key to continue...",x,y+1);
            Console.ReadKey();
        }
        // prints start menu header
        static void StartMenuHeader()
        {
            PrintStatementAtXY("*************************", 50, 19);
            PrintStatementAtXY("*       Main Menu       *", 50, 20);
            PrintStatementAtXY("*************************", 50, 21);
        }
        // prints sub menus headers
        static void PrintSubHeader(string menuHeader)
        {
            PrintStatementAtXY("*      " + menuHeader + "      *", 50, 21);
        }
        // prints headers
        static void Header()
        {
            Console.Clear();
            PrintStatementAtXY("    ______       _     _       _                 ______        _  _", 10, 2);
            PrintStatementAtXY("    | ___ \\     | |   (_)     | |                | ___ \\      (_)| |", 10, 3);
            PrintStatementAtXY("    | |_/ /__ _ | | __ _  ___ | |_  __ _  _ __   | |_/ / __ _  _ | |__      __ __ _  _   _  ___", 10, 4);
            PrintStatementAtXY("    |  __// _` || |/ /| |/ __|| __|/ _` || '_ \\  |    / / _` || || |\\ \\ /\\ / // _` || | | |/ __|", 10, 5);
            PrintStatementAtXY("    | |  | (_| ||   < | |\\__ \\| |_| (_| || | | | | |\\ \\| (_| || || | \\ V  V /| (_| || |_| |\\__ \\", 10, 6);
            PrintStatementAtXY("    \\_|   \\__,_||_|\\_\\|_||___/ \\__|\\__,_||_| |_| \\_| \\_|\\__,_||_||_|  \\_/\\_/  \\__,_| \\__, ||___/", 10, 7);
            PrintStatementAtXY("___  ___                                                           _     _____       __/  | _", 10, 8);
            PrintStatementAtXY("|  \\/  |                                                          | |   /  ___|     |____/ | |", 10, 9);
            PrintStatementAtXY("| .  . |  __ _  _ __    __ _   __ _   ___  _ __ ___    ___  _ __  | |_  \\ `--.  _   _  ___ | |_  ___  _ __ ___", 10, 10);
            PrintStatementAtXY("| |\\/| | / _` || '_ \\  / _` | / _` | / _ \\| '_ ` _ \\  / _ \\| '_ \\ | __|  `--. \\| | | |/ __|| __|/ _ \\| '_ ` _ \\", 10, 11);
            PrintStatementAtXY("| |  | || (_| || | | || (_| || (_| ||  __/| | | | | ||  __/| | | || |_  /\\__/ /| |_| |\\__ \\| |_|  __/| | | | | |", 10, 12);
            PrintStatementAtXY("\\_|  |_/ \\__,_||_| |_| \\__,_| \\__, | \\___||_| |_| |_| \\___||_| |_| \\__| \\____/  \\__, ||___/ \\__|\\___||_| |_| |_|", 10, 13);
            PrintStatementAtXY("                               __/ |                                             __/ |", 10, 14);
            PrintStatementAtXY("                              |___/                                             |___/", 10, 15);
        }
        // adds ship data
        static void AddShips(List<Ships> ships)
        {
            string shipID = ShipsIDInput(ships);
            if(CheckShip(shipID,ships))
            {
                PressAnyKey("Ship already exists! Ship not added!", 50, 24);
            }
            else
            {
                string shipName = ShipsNameInput(50,24);
                string shipDriver = NameInput(50,25);
                if(NameValidationCheck(shipDriver)==true)
                {
                    string shipDepartureCity = CityInput("departure",72,26);
                    string shipDestinationCity = Destination(shipDepartureCity,75,27);
                    Ships s=new Ships(shipID,shipName,shipDriver,shipDepartureCity,shipDestinationCity);
                    ships.Add(s);
                    PressAnyKey("Ship added successfully!",50,28);
                }
                else
                {
                    PressAnyKey("Wrong Name Format! Ship not added!", 50, 26);
                }
            }

        }
        static void RemoveShip(List<Ships> ships)
        {
            bool shipRemoval=false;
            PrintStatementAtXY("Enter shipID: ",50,23);
            string shipID = Inputs();
            for(int i=0;i<ships.Count;i++)
            {
                if (ships[i].ShipID==shipID)
                {
                    ships.RemoveAt(i);
                    shipRemoval = true;
                }
            }
            if(shipRemoval==true)
            {
                PressAnyKey("Ship removed successfully!", 50, 24);
            }
            else
            {
                PressAnyKey("Ship not found!", 50, 24);
            }
        }
        static void UpdateShip(List<Ships> ships)
        {
            PrintStatementAtXY("Enter shipID: ", 50, 23);
            string shipID = Inputs();
            int i=ShipIndex(ships,shipID);
            if(i>0)
            {
                PrintStatementAtXY("Enter the option for data to update!", 50, 25);
                PrintStatementAtXY("1.Ship Name  2.Driver Name  3.Departure City  4.Destination 5.Exit", 50, 25);
                PrintStatementAtXY("Enter option...", 50, 26);
                while(true)
                {
                    PrintStatementAtXY("       ", 66, 26);
                    string option = Inputs();
                    if (option == "1")
                    {
                        string shipName = ShipsNameInput(50,27);
                        ships[i].UpdateShipName(shipName);
                        PressAnyKey("Ship Name updated successfully!",50,28);
                        break;
                    }
                    else if (option == "2")
                    {
                        string DriverName = NameInput(50, 27);
                        ships[i].UpdateDriverName(DriverName);
                        PressAnyKey("Driver Name updated successfully!", 50, 28);
                        break;
                    }
                    else if (option == "3")
                    {
                        string departure = CityInput("departure",50, 27);
                        ships[i].UpdateShipDeparture(departure);
                        PressAnyKey("Departure city updated successfully!", 50, 28);
                        break;
                    }
                    else if (option == "4")
                    {
                        string destination = Destination("departure", 50, 27);
                        ships[i].UpdateShipDestination(destination);
                        PressAnyKey("Destination city updated successfully!", 50, 28);
                        break;
                    }
                    else if (option == "5")
                    {
                        PressAnyKey("Data not updated!", 50, 28);
                        break;
                    }
                }
            }
            else
            {
                PrintStatementAtXY("Ship not found!",50,24);
            }
        }
        static void SearchShip(List<Ships> ships)
        {
            PrintStatementAtXY("Enter shipID: ",50,23);
            string ShipID = Inputs();
            int idx=ShipIndex(ships,ShipID);
            if(idx==-1)
            {
                PressAnyKey("Ship not found!",50,24);
            }
            else
            {
                PrintStatementAtXY($"{"Ship Name",-20}{"Driver Name",-20}{"Departure",-20}{"Destination",-20}", 30, 25);
                PrintStatementAtXY($"{ships[idx].ShipName,-20}{ships[idx].ShipDriver,-20}{ships[idx].ShipDepartureSite,-20}{ships[idx].ShipDestination,-20}", 30, 26);
                PressAnyKey("", 50, 27);
            }
        }
        static void ViewAllShips(List<Ships> ships)
        {
            if (ships.Count>0)
            {
                PrintStatementAtXY($"{"Ship Name",-20}{"Driver Name",-20}{"Departure",-20}{"Destination",-20}", 30, 24);
                for (int idx = 0; idx<ships.Count; idx++)
                {
                    PrintStatementAtXY($"{ships[idx].ShipName,-20}{ships[idx].ShipDriver,-20}{ships[idx].ShipDepartureSite,-20}{ships[idx].ShipDestination,-20}", 30, 26);
                }
                PressAnyKey("", 50, 27);
            }
            else
            {
                PressAnyKey("No ships data available!",50,24);
            }
        }
        static int ShipIndex(List<Ships> ships,string shipID)
        {
            int j = -1;
            for (int i = 0; i<ships.Count; i++)
            {
                if (ships[i].ShipID==shipID)
                {
                    j=i;
                }
            }
            return j;
        }
        static string ShipsIDInput(List<Ships> ships)
        {
            string ID="";
            for(int i=0;i<3;i++)
            {
                if (i==0)
                {
                    PrintStatementAtXY("Enter ShipID: ", 50, 23);
                    ID=Inputs();
                }
                else
                {
                    PrintStatementAtXY("Ship already exists! Enter again: ",50,23);
                    ID=Inputs();
                }
                if(CheckShip(ID,ships)==false)
                {
                    break;
                }
            }
            return ID;
        }
        static string ShipsNameInput(int x,int y)
        {
            PrintStatementAtXY("Enter ShipName: ", x, y);
            string shipName=Inputs();
            return shipName;
        }
        static bool CheckShip(string ID,List<Ships> ships)
        {
            for(int i=0;i<ships.Count;i++)
            {
                if (ID==ships[i].ShipID)
                {
                    return true;
                }
            }
            return false;
        }
        static string Inputs()
        {
            string input="";
            while(string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }
            return input;
        }
        static string NameInput(int x,int y)
        {
            string name="";
            for (int i = 0; i < 3; i++)
            {
                if (i == 0) // if user enters name for the first time
                {
                    PrintStatementAtXY("Enter Driver Name: ", x, y);
                    name = Inputs();
                }
                else // if user enters name in wrong format
                {
                    PrintStatementAtXY("Invalid Name format! Enter again: ", x, y);
                    name = Inputs();
                }
                if (NameValidationCheck(name) == true) // checks the validation of the user Name
                {
                    break;
                }
            }
            return name;
        }
        static bool NameValidationCheck(string name)
        {
            int i = 0;
            if(string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                while (i<name.Length) // loop continues till all characters are checked
                {
                    if ((name[i] < 'A' || name[i] > 'Z') && (name[i] < 'a' || name[i] > 'z') && name[i] != ' ') // checks if user has alphabets only and no number
                    {
                        return false;
                    }
                    i++;
                }
                return true;
            }
        }
        static string CityInput(string location,int x,int y)
        {
            string City="";
            while (NameValidationCheck(City)==false)
            {
                PrintStatementAtXY("            ", x, y);
                PrintStatementAtXY("Enter "+location+" City: ", 50, y);
                City = Inputs();
            }
            return City;
        }
        static string Destination(string Departure,int x,int y)
        {
            string destination=Departure;
            while(destination==Departure)
            {
                destination=CityInput("destination",x,y);
            }
            return destination;
        }
    }
}
