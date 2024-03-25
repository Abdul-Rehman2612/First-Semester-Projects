using System;
using System.Data;
using System.IO;
using System.Threading;


namespace BussinessApp
{
    internal class Program
    {
        static void Main()
        {
            // Passengers data
            string[] passengerName = new string[1000];       // name of each user
            string[] passengerID = new string[1000];         // usernames for each passenger
            string[] passengerIDPassword = new string[1000]; // passwords for each passenger
            string[] passengerCnic = new string[1000];       // cnic of each passenger
            int passengerCountIdx = 0;                       // number of passengers who have signed up

            // Passengers Tickets Details
            string[] passengerTicketStatus = new string[1000];  // ticket status of the passenger
            string[] passengerTrainNo = new string[1000];       // train no on which passenger has the ticket
            string[] passengerTicketRoute = new string[1000];   // route for the ticket booked
            string[] passengerArrivalCity = new string[1000];   // the city to which train is going
            string[] passengerDepartureCity = new string[1000]; // the city from which train is leaving
            int[] passengerTicketPrice = new int[1000];         // price of the ticket booked by the passenger

            // Employees data
            string[] employeeName = new string[100];       // name of each employee
            string[] employeeID = new string[100];         // usernames for each emmployee
            string[] employeeIDPassword = new string[100]; // passwords for each employee
            string[] employeeCnic = new string[100];       // cnic for each employee
            int employeeCountIdx = 0;                      // number of employees who have been added

            // Train details
            string[] cities = new string[15] { "Lahore", "Peshawar", "Quetta", "Rawalpindi", "Faisalabad", "Hyderabad", "Sialkot", "Karachi", "Islamabad", "Multan", "Gujranwala", "Okara", "Sahiwal", "Jehlum", "D.G.K" };
            string[] trainNo = new string[100];            // code of the train
            string[] trainArrivalCity = new string[100];   // arrival city of the train
            string[] trainDepartureCity = new string[100]; // departure city of the train
            string[] trainRoute = new string[100];         // route of the train
            int[] trainTicketPrice = new int[100];         // ticket price of the train
            int trainCountIdx = 0;                         // no. of trains

            // Menus
            string[] startMenu = new string[3] { "Sign up", "Sign in", "Exit" };
            string[] adminMenu = new string[6] { "Manage employee data", "Manage passengers data", "Manage train routes", "Ticketing system", "Tickets details", "Log Out" };
            string[] manageEmployeeMenu = new string[6] { "Add employee data", "Delete employee data", "Update employee data", "View all employees data", "Search employee data", "Back" };
            string[] managePassengerMenu = new string[6] { "Add passenger data", "Delete passenger data", "Update passenger data", "View all passengers data", "Search passenger data", "Back" };
            string[] manageTrainMenu = new string[4] { "Add train route", "Delete train route", "View train routes", "Back" };
            string[] manageTicketSystemMenu = new string[4] { "Book ticket", "Cancel ticket", "View booked tickets", "Back" };
            string[] employeeMenu = new string[6] { "Manage passengers data", "Manage train routes", "Ticketing system", "View your data", "Change Password", "Log out" };
            string[] passengerMenu = new string[7] { "Book ticket", "Cancel ticket", "View trains available", "View your data", "View ticket Details", "Change Password", "Log out" };

            // load data files for passengers,employees and trains
            PassengersDataLoad(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice,ref passengerCountIdx);
            EmployeeDataLoad(employeeName, employeeID, employeeIDPassword, employeeCnic,ref employeeCountIdx);
            TrainsDataLoad(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, trainTicketPrice,ref trainCountIdx);

            // Headers
            string[] headerNames = new string[20]{"Add Employee", "Delete Employee", "Update Employee Data", "Employees Data", "Search Employee Data",
                                                  "Add Passenger", "Delete Passenger", "Update Passenger Data", "Passengers Data", "Search Passenger Data",
                                                  "Add Train Route", "Remove Train Route", "Train Routes Available", "Book Ticket", "Cancel Ticket",
                                                  "Booked Ticket Details", "User Information", "View Ticket Details", " Total Revenue Collected", "Change Password"};
            Console.Clear(); // clears screen
            StartHeader();   // animated header

            string option;

            // loop terminates if option entered by user is 3
            while (true)
            {
                // prints headers
                HeaderCls();
                StartMenuHeader();

                option = PrintMenu(startMenu, 3); // user choice

                if (option == "1") // if user want sign up enters 1
                {
                    HeaderCls();
                    SignUpHeader();

                    if (passengerCountIdx == 1000) // if username space not available
                    {
                        PrintStatement("Sorry you cannot sign up!", 50, 24, "W");
                    }
                    else // if username space is available
                    {
                        string passengerNameSU = UserNameSignUp(23);                        // name of user
                        bool passengerNameCheck = UserNameValidationCheck(passengerNameSU); // checks if Name enterd by the user is in correct format or not

                        if (passengerNameCheck == true)
                        {

                            string userIDSU = UserIDSignup(passengerID, passengerCountIdx);                   // username for signing up
                            bool userIDCheckSU = UserIDCheckSignup(userIDSU, passengerID, passengerCountIdx); // if userID already exists return true otherwise false

                            if (userIDCheckSU == true) // if username already exists or wrong input
                            {
                                PrintStatement("Invalid UserID. Sign up failed!", 50, 25, "W");
                            }
                            else // if username does not exist
                            {
                                string userPasswordSU = UserPasswordSignup(25);                  // password for signing up
                                bool validation = PasswordValidationCheckSignup(userPasswordSU); // if password is valid returns true

                                if (validation == true) // if passenger uses correct password format
                                {
                                    string userCnicSU = UserCnicSignup(passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx, 26);                // cnic for signing up
                                    bool cnicCheck = UserCnicValidationSignup(userCnicSU, passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx); // checks if cnic is valid

                                    if (cnicCheck == true) // if cnic is correct and is not already found
                                    {
                                        // saving info for sign up
                                        TicketStatusPassenger(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                        SaveSUInformation(passengerNameSU, passengerName, userIDSU, passengerID, userPasswordSU, passengerIDPassword, userCnicSU, passengerCnic, ref passengerCountIdx);

                                        //PassengersNewDataFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                        PrintStatement("Signed up successfully!", 50, 27, " ");
                                    }
                                    else // if cnic format is not correct or is already present
                                    {
                                        PrintStatement("Invalid Cnic. Sign up failed!", 50, 27, "W");
                                    }
                                }
                                else // if user uses wrong format for password
                                {
                                    PrintStatement("Invalid Password format. Sign up failed!", 50, 26, "W");
                                }
                            }
                        }
                        else // if user enters wrong name format
                        {
                            PrintStatement("Invalid Name format. Sign up failed!", 50, 24, "W");
                        }
                    }
                }
                else if (option == "2") // if user wants to sign in enters 2
                {
                    HeaderCls();
                    SignInHeader();

                    string userIDSI = UserIDSignIn(passengerID, employeeID, passengerCountIdx, employeeCountIdx); // userID for signing in

                    if (userIDSI == "admin") // if userID is admin
                    {
                        string adminPassword = AdminPasswordCheck(); // checks password for admin

                        if (adminPassword == "admin") // admin sign in successful
                        {
                            // loop terminates if admin enters 6
                            while (true)
                            {
                                HeaderCls();
                                AdminHeader();

                                string choice = PrintMenu(adminMenu, 6); // takes admin's choice as input for submenu

                                if (choice == "1") // if admin enters 1 employee management menu appears
                                {
                                    // loop terminates if user enters 5
                                    while (true)
                                    {
                                        HeaderCls();
                                        ManageEmployeeHeader();

                                        choice = PrintMenu(manageEmployeeMenu, 6); // takes user choice

                                        if (choice == "1") // if admin wants to add an employee enters 1
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[0]);

                                            // add an employee data
                                            AddEmployeeData(employeeName, employeeID, employeeIDPassword, employeeCnic, passengerCnic, ref employeeCountIdx, passengerCountIdx);
                                        }
                                        else if (choice == "2") // if admin wants to delete employee enters 2
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[1]);

                                            int x = employeeCountIdx; // saves employee count temporarily

                                            // delete an employee data
                                            DeleteUserData(employeeName, employeeID, employeeIDPassword, employeeCnic, "Employee", ref employeeCountIdx);

                                            if (x != employeeCountIdx) // if employee data is deleted
                                            {
                                                // employee file is updated
                                                EmployeesDataUpdateFile(employeeName, employeeID, employeeIDPassword, employeeCnic, employeeCountIdx);
                                            }
                                        }
                                        else if (choice == "3") // if admin wants to update employee enters 3
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[2]);

                                            // update an employee data
                                            UpdateUserData(employeeName, employeeID, employeeIDPassword, employeeCnic, passengerCnic, "Employee", employeeCountIdx, passengerCountIdx);

                                            // updates employee data file after the employee data is updated
                                            EmployeesDataUpdateFile(employeeName, employeeID, employeeIDPassword, employeeCnic, employeeCountIdx);
                                        }
                                        else if (choice == "4") // if admin wants to view employee enters 4
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[3]);

                                            // displays all employees data
                                            ViewUserDataList(employeeName, employeeID, employeeIDPassword, employeeCnic, "Employee", employeeCountIdx);
                                        }
                                        else if (choice == "5") // if admin wants to search an employee enters 5
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[4]);

                                            // searches employee data for employeeID entered by admin
                                            SearchUserData(employeeName, employeeID, employeeIDPassword, employeeCnic, "Employee", employeeCountIdx);
                                        }
                                        else if (choice == "6") // if admin wants to go back enters 6
                                        {
                                            break;
                                        }
                                        else // if admin enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 30, "W");
                                        }
                                    }
                                }
                                else if (choice == "2") // if admin enters 2 passenger management menu appears
                                {
                                    // loop terminates if user enters 5
                                    while (true)
                                    {
                                        HeaderCls();
                                        ManagePassengerHeader();

                                        choice = PrintMenu(managePassengerMenu, 6); // takes user choice

                                        if (choice == "1") // if admin wants to add passenger data
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[5]);

                                            // x is used furthur to check if user added successfully or not
                                            int x = passengerCountIdx;

                                            // adds a passenger
                                            AddPassengerData( passengerName, passengerID, passengerIDPassword, passengerCnic, employeeCnic, ref passengerCountIdx, employeeCountIdx);

                                            if (x != passengerCountIdx) // if passsenger added successfully the file is updated
                                            {
                                                // saves initial values of the ticket of a user
                                                TicketStatusPassenger(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx - 1);

                                                // saves data on the passenger file
                                                PassengersNewDataFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                            }
                                        }
                                        else if (choice == "2") // if admin wants to delete passenger data
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[6]);

                                            // delete a passenger data

                                            PrintLine("Enter passengerID: ", 50, 23);
                                            string ID = Inputs(); // takes passengerId as input

                                            if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                            {
                                                int idx = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                // displays the data of the passenger to be deleted
                                                ViewUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, idx, 50, 25);

                                                string option1 = YesNoChoice("Passenger"); // asks the admin for its choice to delete data or not

                                                if (option1 == "1" || option1 == "Yes") // if admin enters Yes or 1 passenger data is deleted
                                                {
                                                    int delIndex = passengerCountIdx;
                                                    // deletes the passenger data
                                                    DeleteData(passengerName, passengerID, passengerIDPassword, passengerCnic, ref passengerCountIdx, idx);

                                                    // deletes the passenger ticket details
                                                    DeleteTicketData(passengerTicketStatus, trainNo, passengerDepartureCity, passengerArrivalCity, passengerTicketRoute, passengerTicketPrice, idx, delIndex);

                                                    // updates the file after data deleted successfully
                                                    PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);

                                                    PrintStatement("Passenger data deleted successfully!", 50, 33, " ");
                                                }
                                                else if (option1 == "2" || option1 == "No") // if admin enters No or 2 passenger data is not deleted
                                                {
                                                    PrintStatement("Passenger data not deleted!", 50, 33, " ");
                                                }
                                            }
                                            else // if passengerID is not found
                                            {
                                                PrintStatement("Passenger data not found!", 50, 25, "W");
                                            }
                                        }
                                        else if (choice == "3") // if admin wants to update passenger data
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[7]);

                                            // update a passenger data
                                            UpdateUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, employeeCnic, "Passenger", passengerCountIdx, employeeCountIdx);

                                            // updates the passenger file after data is updated
                                            PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                        }
                                        else if (choice == "4") // if admin wants to view passenger data
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[8]);

                                            // displays all passengers data
                                            ViewUserDataList(passengerName, passengerID, passengerIDPassword, passengerCnic, "Passenger", passengerCountIdx);
                                        }
                                        else if (choice == "5") // if admin wants to search passenger data enters 5
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[9]);

                                            // searches the passenger data by using passenger ID entered by admin
                                            SearchUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, "Passenger", passengerCountIdx);
                                        }
                                        else if (choice == "6") // if admin wants to go back enters 6
                                        {
                                            break;
                                        }
                                        else // if admin enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 30, "W");
                                        }
                                    }
                                }
                                else if (choice == "3") // if admin enters 3 train routes management menu appears
                                {
                                    // loop terminates if admin enters 4
                                    while (true)
                                    {
                                        HeaderCls();
                                        ManageTrainsHeader();

                                        choice = PrintMenu(manageTrainMenu, 4); // takes admin's choice as input

                                        if (choice == "1") // if admin wants to add train route enters 1
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[10]);

                                            int x = trainCountIdx; // temporarily stores trains count

                                            // adds a train route data
                                            AddTrainRoute(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, ref trainCountIdx, cities);

                                            if (x != trainCountIdx)
                                            {
                                                // adds the train data to the file
                                                TrainsNewDataFile(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, trainTicketPrice, trainCountIdx);
                                            }
                                        }
                                        else if (choice == "2") // if admin wants to delete train route enters 2
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[11]);

                                            // deletes a train data
                                            string trainID = DeleteTrainRoute(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, ref trainCountIdx);

                                            if (trainID != " ") // if trainID is found
                                            {
                                                // if train data is deleted the ticket data corresponding to it also gets deleted and the passenger file is updated
                                                DeleteTrainTicketDetails(passengerTicketStatus, passengerTrainNo, passengerArrivalCity, passengerDepartureCity, passengerTicketRoute, passengerTicketPrice, passengerCountIdx, trainID);

                                                // the train data file is updated after deletion of the train data
                                                TrainsDataUpdateFile(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, trainTicketPrice, trainCountIdx);

                                                // passenger data file is updated as the tickets data parallel to that train is deleted
                                                PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                            }
                                        }
                                        else if (choice == "3") // if admin wants to view trains available enters 3
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[12]);

                                            // displays the trains available
                                            ViewTrainsAvailable(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, trainCountIdx);
                                        }
                                        else if (choice == "4") // if admin wants to go back enters 4
                                        {
                                            break;
                                        }
                                        else // if admin enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 28, "W");
                                        }
                                    }
                                }
                                else if (choice == "4") // if admin enters 4 ticketing system menu appears
                                {
                                    // loop termintaes if user enters 4
                                    while (true)
                                    {
                                        HeaderCls();
                                        ManageTicketetingHeader();

                                        choice = PrintMenu(manageTicketSystemMenu, 4); // takes admin's choice as input for submenu

                                        if (choice == "1") // if admin wants to book a ticket enters 1
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[13]);

                                            PrintLine("Enter passengerID: ", 50, 23);
                                            string ID = Inputs(); // takes passengerID as input

                                            if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                            {
                                                int index = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                if (trainCountIdx > 0) // if trains are available
                                                {

                                                    // books ticket for a user
                                                    BookTickets(passengerTicketStatus, passengerTrainNo, trainNo, passengerArrivalCity, trainArrivalCity, passengerDepartureCity, trainDepartureCity, passengerTicketRoute, trainRoute, passengerTicketPrice, trainTicketPrice, index, trainCountIdx);

                                                    // updates passengers data file after ticket is booked
                                                    PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                }
                                                else // if trains are not availabe
                                                {
                                                    PrintStatement("Train routes not available!", 50, 25, "W");
                                                }
                                            }
                                            else // if passnegerID not found
                                            {
                                                PrintStatement("PassengerID not found!", 50, 25, "W");
                                            }
                                        }
                                        else if (choice == "2") // if admin wants to cancel ticket enters 2
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[14]);

                                            PrintLine("Enter passengerID: ", 50, 23);
                                            string ID = Inputs(); // takes passengerID as input

                                            if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                            {
                                                int index = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                if (passengerTicketStatus[index] == "Y") // if passenger ticket data if found
                                                {
                                                    // deletes the tickets details of the user
                                                    CancelTicket(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, index);

                                                    // updates the passenger file after ticket data is deleted
                                                    PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                }
                                                else // if ticket data not found for the passnger
                                                {
                                                    PrintStatement("Ticket details not available!", 50, 25, "W");
                                                }
                                            }
                                            else // if passengerID not found
                                            {
                                                PrintStatement("PassengerID not found!", 50, 25, "W");
                                            }
                                        }
                                        else if (choice == "3") // if admin wants to view booked ticket details enters 3
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[15]);

                                            // displays the tickets booked
                                            ViewBookedTickets(passengerName, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                        }
                                        else if (choice == "4") // if admin wants to go back enters 4
                                        {
                                            break;
                                        }
                                        else // if admin enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 28, "W");
                                        }
                                    }
                                }
                                else if (choice == "5") // if admin wants to view collected revenue enters 5
                                {
                                    HeaderCls();
                                    PrintSubHeader(headerNames[18]);

                                    // displays the number of tickets in each train and their total collected revenue
                                    TicketsDetails(passengerTrainNo, trainNo, passengerTicketPrice, trainTicketPrice, passengerCountIdx, trainCountIdx);
                                }
                                else if (choice == "6") // if admin wants to log out
                                {
                                    break;
                                }
                                else // if admin enters wrong input
                                {
                                    PrintStatement("Wrong userChoice!...", 50, 30, "W");
                                }
                            }
                        }
                        else // admin sign in failed
                        {
                            PrintStatement("Wrong Credentials! Sign In failed!", 50, 25, "W");
                        }
                    }
                    else // if user is employee or a passenger
                    {
                        bool x = UserCheckSignIn(userIDSI, passengerID, employeeID, passengerCountIdx, employeeCountIdx); // checks if userID exists or not

                        if (x == true) // if userID is found in data
                        {
                            string role = RoleCheck(userIDSI); // checks role of the user

                            if (role == "Employee") // if role of user is Employee
                            {
                                int empIdx = IndexCheck(userIDSI, employeeID, employeeCountIdx);       // employee index for ID
                                string empPasswordSI = UserPasswordSignIn(employeeIDPassword[empIdx]); // taskes input for password

                                if (empPasswordSI == employeeIDPassword[empIdx]) // if employee enters correct password
                                {
                                    // loop terminates if employee enters 5
                                    while (true)
                                    {
                                        HeaderCls();
                                        EmployeeHeader();

                                        string choice = PrintMenu(employeeMenu, 6); // takes employee choice as input

                                        if (choice == "1") // if employee enters 1 manage passengermenu appears
                                        {
                                            // loop terminates if user enters 6
                                            while (true)
                                            {
                                                HeaderCls();
                                                ManagePassengerHeader();

                                                choice = PrintMenu(managePassengerMenu, 6); // takes employee's input for submenu

                                                if (choice == "1") // if employee wants to add passenger data
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[5]);

                                                    // m is used furthur to check if user added successfully or not
                                                    int m = passengerCountIdx;

                                                    // adds a passenger
                                                    AddPassengerData(passengerName, passengerID, passengerIDPassword, passengerCnic, employeeCnic, ref passengerCountIdx, employeeCountIdx);

                                                    if (m != passengerCountIdx) // if passsenger added successfully the file is updated
                                                    {
                                                        // saves initial values of the ticket of a user
                                                        TicketStatusPassenger(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx - 1);

                                                        // saves data on the passenger file
                                                        PassengersNewDataFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                    }
                                                }
                                                else if (choice == "2") // if employee wants to delete passenger data
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[6]);

                                                    // delete a passenger data

                                                    PrintLine("Enter passengerID: ", 50, 23);
                                                    string ID = Inputs(); // takes passengerId as input

                                                    if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                                    {
                                                        int idx = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                        // displays the data of the passenger to be deleted
                                                        ViewUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, idx, 50, 25);

                                                        string option1 = YesNoChoice("Passenger"); // asks the employee for its choice to delete data or not

                                                        if (option1 == "1" || option1 == "Yes") // if employee enters Yes or 1 passenger data is deleted
                                                        {
                                                            int delIndex = passengerCountIdx;
                                                            // deletes the passenger data
                                                            DeleteData(passengerName, passengerID, passengerIDPassword, passengerCnic, ref passengerCountIdx, idx);

                                                            // deletes the passenger ticket details
                                                            DeleteTicketData(passengerTicketStatus, trainNo, passengerDepartureCity, passengerArrivalCity, passengerTicketRoute, passengerTicketPrice, idx, delIndex);

                                                            // updates the file after data deleted successfully
                                                            PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);

                                                            PrintStatement("Passenger data deleted successfully!", 50, 33, " ");
                                                        }
                                                        else if (option1 == "2" || option1 == "No") // if employee enters No or 2 passenger data is not deleted
                                                        {
                                                            PrintStatement("Passenger data not deleted!", 50, 33, " ");
                                                        }
                                                    }
                                                    else // if passengerID is not found
                                                    {
                                                        PrintStatement("Passenger data not found!", 50, 25, "W");
                                                    }
                                                }
                                                else if (choice == "3") // if employee wants to update passenger data
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[7]);

                                                    // update a passenger data
                                                    UpdateUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, employeeCnic, "Passenger", passengerCountIdx, employeeCountIdx);

                                                    // updates the passneger file after its data is updated
                                                    PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                }
                                                else if (choice == "4") // if employee wants to view passenger data
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[8]);

                                                    // displays all passengers data
                                                    ViewUserDataList(passengerName, passengerID, passengerIDPassword, passengerCnic, "Passenger", passengerCountIdx);
                                                }
                                                else if (choice == "5") // if employee wants to search passenger data enters 5
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[9]);

                                                    // searches the passenger data by using passenger ID entered by employee
                                                    SearchUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, "Passenger", passengerCountIdx);
                                                }
                                                else if (choice == "6") // if employee wants to go back enters 6
                                                {
                                                    break;
                                                }
                                                else // if employee enters wrong choice
                                                {
                                                    PrintStatement("Wrong userChoice!...", 50, 30, "W");
                                                }
                                            }
                                        }
                                        else if (choice == "2") // if employee enters 2 manage trainmenu appears
                                        {
                                            // loop termintaes if user enters 4
                                            while (true)
                                            {
                                                HeaderCls();
                                                ManageTrainsHeader();

                                                choice = PrintMenu(manageTrainMenu, 4); // takes employee's choice as input

                                                if (choice == "1") // if employee wants to add train route enters 1
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[10]);

                                                    int m = trainCountIdx; // temporarily stores trains count

                                                    // adds a train route data
                                                    AddTrainRoute(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, ref trainCountIdx, cities);

                                                    if (m != trainCountIdx)
                                                    {
                                                        // adds the train data to the file
                                                        TrainsNewDataFile(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, trainTicketPrice, trainCountIdx);
                                                    }
                                                }
                                                else if (choice == "2") // if employee wants to delete train route enters 2
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[11]);

                                                    // deletes a train data
                                                    string trainID = DeleteTrainRoute(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, ref trainCountIdx);

                                                    if (trainID != " ") // if trainID is found
                                                    {
                                                        // if train data is deleted the ticket data corresponding to it also gets deleted and the passenger file is updated
                                                        DeleteTrainTicketDetails(passengerTicketStatus, passengerTrainNo, passengerArrivalCity, passengerDepartureCity, passengerTicketRoute, passengerTicketPrice, passengerCountIdx, trainID);

                                                        // the train data file is updated after deletion of the train data
                                                        TrainsDataUpdateFile(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, trainTicketPrice, trainCountIdx);

                                                        // passenger data file is updated as the tickets data parallel to that train is deleted
                                                        PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                    }
                                                }
                                                else if (choice == "3") // if employee wants to view trains available enters 3
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[12]);

                                                    // displays the trains available
                                                    ViewTrainsAvailable(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, trainCountIdx);
                                                }
                                                else if (choice == "4") // if employee wants to go back enters 4
                                                {
                                                    break;
                                                }
                                                else // if employee enters wrong input
                                                {
                                                    PrintStatement("Wrong userChoice!...", 50, 28, "W");
                                                }
                                            }
                                        }
                                        else if (choice == "3") // if employee enters 3 ticketing system menu appears
                                        {
                                            while (true)
                                            {
                                                HeaderCls();
                                                ManageTicketetingHeader();

                                                choice = PrintMenu(manageTicketSystemMenu, 4); // takes employee's choice as input for submenu

                                                if (choice == "1") // if employee wants to book a ticket for a user enters 1
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[13]);

                                                    PrintLine("Enter passengerID: ", 50, 23);
                                                    string ID = Inputs(); // takes passengerID as input

                                                    if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                                    {
                                                        int index = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                        if (trainCountIdx > 0) // if trains are available
                                                        {
                                                             // saves passenger ticket status temporarily

                                                            // books ticket for a user
                                                            BookTickets(passengerTicketStatus, passengerTrainNo, trainNo, passengerArrivalCity, trainArrivalCity, passengerDepartureCity, trainDepartureCity, passengerTicketRoute, trainRoute, passengerTicketPrice, trainTicketPrice, index, trainCountIdx);

                                                            // updates passengers data file after ticket is booked
                                                            PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                        }
                                                        else // if trains are not availabe
                                                        {
                                                            PrintStatement("Train routes not available!", 50, 25, "W");
                                                        }
                                                    }
                                                    else // if passnegerID not found
                                                    {
                                                        PrintStatement("PassengerID not found!", 50, 25, "W");
                                                    }
                                                }
                                                else if (choice == "2") // if employee wants to cancel ticket enters 2
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[14]);

                                                    PrintLine("Enter passengerID: ", 50, 23);
                                                    string ID = Inputs(); // takes passengerID as input

                                                    if (UserCheck(ID, passengerID, passengerCountIdx) == true) // if passengerID is found
                                                    {
                                                        int index = IndexCheck(ID, passengerID, passengerCountIdx); // checks the index of passengerID

                                                        if (passengerTicketStatus[index] == "Y") // if passenger ticket data if found
                                                        {
                                                            // deletes the tickets details of the user
                                                            CancelTicket(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, index);

                                                            // updates the passenger file after ticket data is deleted
                                                            PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                        }
                                                        else // if ticket data not found for the passnger
                                                        {
                                                            PrintStatement("Ticket details not available!", 50, 25, "W");
                                                        }
                                                    }
                                                    else // if passengerID not found
                                                    {
                                                        PrintStatement("PassengerID not found!", 50, 25, "W");
                                                    }
                                                }
                                                else if (choice == "3") // if employee wants to view tickets booked enters 3
                                                {
                                                    HeaderCls();
                                                    PrintSubHeader(headerNames[15]);

                                                    // displays the tickets booked
                                                    ViewBookedTickets(passengerName, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                                }
                                                else if (choice == "4") // if employee wants to go back enters 4
                                                {
                                                    break;
                                                }
                                                else // if employee enters wrong input
                                                {
                                                    PrintStatement("Wrong userChoice!...", 50, 28, "W");
                                                }
                                            }
                                        }
                                        else if (choice == "4") // if employee enters 4 employee data appears
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[16]);

                                            // displays the data of the employee signed in
                                            ViewUserData(employeeName, employeeID, employeeIDPassword, employeeCnic, empIdx, 50, 24);
                                            PressAnyKey(50, 29);
                                        }
                                        else if (choice == "5") // if employee wants to change password enters 5
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[19]);

                                            // changes the password
                                            string newPassword = ChangePassword(employeeIDPassword, empIdx);

                                            if (newPassword != " ")
                                            {
                                                // employee file is updated
                                                EmployeesDataUpdateFile(employeeName, employeeID, employeeIDPassword, employeeCnic, employeeCountIdx);
                                            }
                                        }
                                        else if (choice == "6") // if employee wants to log out enters 6
                                        {
                                            break;
                                        }
                                        else // if employee enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 30, "W");
                                        }
                                    }
                                }
                                else // if user enters wrong credentials
                                {
                                    PrintStatement("Wrong Credentials! Sign In failed!", 50, 25, "W");
                                }
                            }
                            else if (role == "Passenger") // if role of user is Passenger
                            {
                                int pasgIdx = IndexCheck(userIDSI, passengerID, passengerCountIdx);       // user index check
                                string pasgPasswordSI = UserPasswordSignIn(passengerIDPassword[pasgIdx]); // taskes input for password

                                if (pasgPasswordSI == passengerIDPassword[pasgIdx]) // if user enters correct password
                                {
                                    while (true)
                                    {
                                        HeaderCls();
                                        PassengerHeader();

                                        string choice = PrintMenu(passengerMenu, 7); // takes user choice as input

                                        if (choice == "1") // if user wants to book ticket enters 1
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[13]);

                                            if (trainCountIdx > 0) // if train routes available
                                            {
                                                // allows user to book ticket
                                                BookTickets(passengerTicketStatus, passengerTrainNo, trainNo, passengerArrivalCity, trainArrivalCity, passengerDepartureCity, trainDepartureCity, passengerTicketRoute, trainRoute, passengerTicketPrice, trainTicketPrice, pasgIdx, trainCountIdx);

                                                // updates user file after booking ticket
                                                PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                            }
                                            else // if train routes not available
                                            {
                                                PrintStatement("Train routes not available!", 50, 25, "W");
                                            }
                                        }
                                        else if (choice == "2") // if user wants to cancel ticket enters 2
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[14]);

                                            if (passengerTicketStatus[pasgIdx] == "Y") // if ticket details are available allows user to cancel ticket
                                            {
                                                // deletes user ticket details
                                                CancelTicket(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, pasgIdx);

                                                // updates user data file
                                                PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                            }
                                            else // if ticket details not available
                                            {
                                                PrintStatement("Ticket details not available!", 50, 25, "W");
                                            }
                                        }
                                        else if (choice == "3") // if user wants to view timetable of the trains enters 3
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[12]);

                                            // displays the trains available
                                            ViewTrainsAvailable(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, trainTicketPrice, trainCountIdx);
                                        }
                                        else if (choice == "4") // if user wants to view its own data enters 4
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[16]);

                                            // displays user data
                                            ViewUserData(passengerName, passengerID, passengerIDPassword, passengerCnic, pasgIdx, 50, 24);
                                            PressAnyKey(50, 29);
                                        }
                                        else if (choice == "5") // if user wants to view his bokked ticket details enters 5
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[17]);

                                            // displays the ticket details of the passenger
                                            ViewTicketDetails(passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, pasgIdx);
                                            PressAnyKey(50, 28);
                                        }
                                        else if (choice == "6") // if user wants to change password enters 6
                                        {
                                            HeaderCls();
                                            PrintSubHeader(headerNames[19]);

                                            // changes the password
                                            string newPassword = ChangePassword(passengerIDPassword, pasgIdx);

                                            if (newPassword != " ")
                                            {
                                                // updates the passenger file after its data is updated
                                                PassengersDataUpdateFile(passengerName, passengerID, passengerIDPassword, passengerCnic, passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, passengerCountIdx);
                                            }
                                        }
                                        else if (choice == "7") // if user wants to log out enters 7
                                        {
                                            break;
                                        }
                                        else // if user enters wrong input
                                        {
                                            PrintStatement("Wrong userChoice!...", 50, 31, "W");
                                        }
                                    }
                                }
                                else // if passenger enters wrong password
                                {
                                    PrintStatement("Wrong Credentials! Sign In failed!", 50, 25, "W");
                                }
                            }
                        }
                        else // if user enters wrong userID
                        {
                            PrintStatement("UserID not found! Sign in failed!", 50, 24, "W");
                        }
                    }
                }
                else if (option == "3") // if user enters 3 exits the program
                {
                    Environment.Exit(0);
                }
                else // if user enter wrong input
                {
                    PrintStatement("Wrong userChoice!...", 50, 27, "W");
                }
            }
        }
        static void Header()
        {
            PrintLine("    ______       _     _       _                 ______        _  _", 10, 2);
            PrintLine("    | ___ \\     | |   (_)     | |                | ___ \\      (_)| |", 10, 3);
            PrintLine("    | |_/ /__ _ | | __ _  ___ | |_  __ _  _ __   | |_/ / __ _  _ | |__      __ __ _  _   _  ___", 10, 4);
            PrintLine("    |  __// _` || |/ /| |/ __|| __|/ _` || '_ \\  |    / / _` || || |\\ \\ /\\ / // _` || | | |/ __|", 10, 5);
            PrintLine("    | |  | (_| ||   < | |\\__ \\| |_| (_| || | | | | |\\ \\| (_| || || | \\ V  V /| (_| || |_| |\\__ \\", 10, 6);
            PrintLine("    \\_|   \\__,_||_|\\_\\|_||___/ \\__|\\__,_||_| |_| \\_| \\_|\\__,_||_||_|  \\_/\\_/  \\__,_| \\__, ||___/", 10, 7);
            PrintLine("___  ___                                                           _     _____       __/  | _", 10, 8);
            PrintLine("|  \\/  |                                                          | |   /  ___|     |____/ | |", 10, 9);
            PrintLine("| .  . |  __ _  _ __    __ _   __ _   ___  _ __ ___    ___  _ __  | |_  \\ `--.  _   _  ___ | |_  ___  _ __ ___", 10, 10);
            PrintLine("| |\\/| | / _` || '_ \\  / _` | / _` | / _ \\| '_ ` _ \\  / _ \\| '_ \\ | __|  `--. \\| | | |/ __|| __|/ _ \\| '_ ` _ \\", 10, 11);
            PrintLine("| |  | || (_| || | | || (_| || (_| ||  __/| | | | | ||  __/| | | || |_  /\\__/ /| |_| |\\__ \\| |_|  __/| | | | | |", 10, 12);
            PrintLine("\\_|  |_/ \\__,_||_| |_| \\__,_| \\__, | \\___||_| |_| |_| \\___||_| |_| \\__| \\____/  \\__, ||___/ \\__|\\___||_| |_| |_|", 10, 13);
            PrintLine("                               __/ |                                             __/ |", 10, 14);
            PrintLine("                              |___/                                             |___/", 10, 15);
        }
        static void StartHeader()
        {
            PrintLineSH("    ______       _     _       _                 ______        _  _", 10, 2);
            PrintLineSH("    | ___ \\     | |   (_)     | |                | ___ \\      (_)| |", 10, 3);
            PrintLineSH("    | |_/ /__ _ | | __ _  ___ | |_  __ _  _ __   | |_/ / __ _  _ | |__      __ __ _  _   _  ___", 10, 4);
            PrintLineSH("    |  __// _` || |/ /| |/ __|| __|/ _` || '_ \\  |    / / _` || || |\\ \\ /\\ / // _` || | | |/ __|", 10, 5);
            PrintLineSH("    | |  | (_| ||   < | |\\__ \\| |_| (_| || | | | | |\\ \\| (_| || || | \\ V  V /| (_| || |_| |\\__ \\", 10, 6);
            PrintLineSH("    \\_|   \\__,_||_|\\_\\|_||___/ \\__|\\__,_||_| |_| \\_| \\_|\\__,_||_||_|  \\_/\\_/  \\__,_| \\__, ||___/", 10, 7);
            PrintLineSH("___  ___                                                           _     _____       __/  | _", 10, 8);
            PrintLineSH("|  \\/  |                                                          | |   /  ___|     |____/ | |", 10, 9);
            PrintLineSH("| .  . |  __ _  _ __    __ _   __ _   ___  _ __ ___    ___  _ __  | |_  \\ `--.  _   _  ___ | |_  ___  _ __ ___", 10, 10);
            PrintLineSH("| |\\/| | / _` || '_ \\  / _` | / _` | / _ \\| '_ ` _ \\  / _ \\| '_ \\ | __|  `--. \\| | | |/ __|| __|/ _ \\| '_ ` _ \\", 10, 11);
            PrintLineSH("| |  | || (_| || | | || (_| || (_| ||  __/| | | | | ||  __/| | | || |_  /\\__/ /| |_| |\\__ \\| |_|  __/| | | | | |", 10, 12);
            PrintLineSH("\\_|  |_/ \\__,_||_| |_| \\__,_| \\__, | \\___||_| |_| |_| \\___||_| |_| \\__| \\____/  \\__, ||___/ \\__|\\___||_| |_| |_|", 10, 13);
            PrintLineSH("                               __/ |                                             __/ |", 10, 14);
            PrintLineSH("                              |___/                                             |___/", 10, 15);
        }
        static void StartMenuHeader()
        {
            PrintLine("*************************", 50, 19);
            PrintLine("*       Main Menu       *", 50, 20);
            PrintLine("*************************", 50, 21);
        }
        static void SignUpHeader()
        {

            PrintLine("*********************", 50, 19);
            PrintLine("*      Sign Up      *", 50, 20);
            PrintLine("*********************", 50, 21);
        }
        static void SignInHeader()
        {
            PrintLine("*********************", 50, 19);
            PrintLine("*      Sign In      *", 50, 20);
            PrintLine("*********************", 50, 21);
        }
        static void AdminHeader()
        {
            PrintLine("************************", 50, 19);
            PrintLine("*      Admin Menu      *", 50, 20);
            PrintLine("************************", 50, 21);
        }
        static void ManageEmployeeHeader()
        {
            PrintLine("**********************************", 50, 19);
            PrintLine("*      Manage Employee Data      *", 50, 20);
            PrintLine("**********************************", 50, 21);
        }
        static void ManagePassengerHeader()
        {

            PrintLine("***********************************", 50, 19);
            PrintLine("*      Manage Passenger Data      *", 50, 20);
            PrintLine("***********************************", 50, 21);
        }
        static void ManageTrainsHeader()
        {
            PrintLine("*********************************", 50, 19);
            PrintLine("*      Manage Train Routes      *", 50, 20);
            PrintLine("*********************************", 50, 21);
        }
        static void ManageTicketetingHeader()
        {
            PrintLine("******************************", 50, 19);
            PrintLine("*      Ticketing System      *", 50, 20);
            PrintLine("******************************", 50, 21);
        }
        static void EmployeeHeader()
        {
            PrintLine("***************************", 50, 19);
            PrintLine("*      Employee Menu      *", 50, 20);
            PrintLine("***************************", 50, 21);
        }
        static void PassengerHeader()
        {
            PrintLine("****************************", 50, 19);
            PrintLine("*      Passenger Menu      *", 50, 20);
            PrintLine("****************************", 50, 21);
        }
        static void PrintSubHeader(string menuHeader)
        {
            PrintLine("*      " + menuHeader + "      *", 50, 21);
        }

        // instructions for users
        static void NoteUserName()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->First letter must be capital.", 10, 21);
            PrintLine("-->Numbers and special characters are", 10, 22);
            PrintLine("   not allowed to enter.  ", 10, 23);
        }
        static void NoteuserIDpassenger()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Spaces not allowed.", 10, 21);
            PrintLine("-->\"emp\". should not be the first", 10, 22);
            PrintLine("   part of userID.", 10, 23);
            PrintLine("-->UserID cannot be \"admin\".", 10, 24);
            PrintLine("-->UserID must consist of 6-12", 10, 25);
            PrintLine("   characters!", 10, 26);
            PrintLine("-->Already existing userID cannot", 10, 27);
            PrintLine("   be used", 10, 28);
        }
        static void NoteSUpassword()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Spaces not allowed.", 10, 21);
            PrintLine("-->Must consist of 6-12 characters.", 10, 22);
            PrintLine("-->Atleast 1 letter and 1 number", 10, 23);
            PrintLine("   should be entered.", 10, 24);
            PrintLine("--mSpecial Characters can be used. ", 10, 25);
        }
        static void NoteSUcnic()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Spaces not allowed.", 10, 21);
            PrintLine("-->CNIC must consist of 13 numbers.", 10, 22);
            PrintLine("-->Enter your own CNIC number.", 10, 23);
        }
        static void EraseInstruction()
        {
            PrintLine("                                       ", 10, 19);
            PrintLine("                                       ", 10, 21);
            PrintLine("                                       ", 10, 22);
            PrintLine("                                       ", 10, 23);
            PrintLine("                                       ", 10, 24);
            PrintLine("                                       ", 10, 25);
            PrintLine("                                       ", 10, 26);
            PrintLine("                                       ", 10, 27);
            PrintLine("                                       ", 10, 28);
        }
        static void NoteAddEmployee()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Spaces not allowed.", 10, 21);
            PrintLine("-->\"emp\". should be the first", 10, 22);
            PrintLine("   part of employeeID.", 10, 23);
            PrintLine("-->EmployeeID cannot be \"admin\".", 10, 24);
            PrintLine("-->EmployeeID must consist of minimum", 10, 25);
            PrintLine("   of 6 characters!", 10, 26);
        }
        static void NoteAddTrain()
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Spaces not allowed.", 10, 21);
            PrintLine("-->Only '-' can be used in trainID.", 10, 22);
            PrintLine("-->Already existing trainID cannot be", 10, 23);
            PrintLine("-->added again!", 10, 24);
        }
        static void NoteDepartureCity(string[] cities)
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Enter one of the following:", 10, 21);
            int y = 22;
            for (int i = 0; i < 15; i++)
            {
                PrintLine("   " + cities[i] + "          ", 10, y);
                y++;
            }
        }
        static void NoteArrivalCity(string departurecity, string[] cities)
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Arrival and departure city ", 10, 21);
            PrintLine("   cannot be same.Enter 1 of the ", 10, 22);
            PrintLine("   following: ", 10, 23);
            int y = 24;
            for (int i = 0; i < 15; i++)
            {
                if (departurecity == cities[i])
                {
                    continue;
                }
                PrintLine("   " + cities[i] + "          ", 10, y);
                y++;
            }
        }
        static void NoteRoutesavail(string[] trainNo, string[] trainRoute, int trainCountIdx)
        {
            PrintLine("             Instructions", 10, 19);
            PrintLine("-->Choose one of the following:", 10, 21);
            PrintLine($"{" Sr.No ",-7} {" TrainNo ",-10} {" Route ",-20}", 10, 23);
            if (trainCountIdx > 0)
            {
                int y = 24;

                for (int idx = 0; idx < trainCountIdx; idx++)
                {
                    PrintLine($"{idx + 1,-7} {trainNo[idx],-10} {trainRoute[idx],-20}", 10, y);
                    y++;
                }

                PrintLine("Enter \"esc\" to exit!", 10, y + 1);
            }
        }
        // printing menu function
        static string PrintMenu(string[] menu, int size)
        {
            int y = 23;
            for (int i = 0; i < size; i++)
            {
                PrintLine(i + 1 + "." + menu[i], 50, y);
                y++;
            }
            PrintLine("Enter option...", 50, y + 1);
            string option;
            option = Inputs();
            return option;
        }

        // user signup functions
        static string UserNameSignUp(int y)
        {
            NoteUserName(); // prints the instructions for user name

            string userName = " ";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) // if user enters name for the first time
                {
                    Space(62, y);
                    PrintLine("Enter Name: ", 50, y);
                    userName = Inputs();
                }
                else // if user enters name in wrong format
                {
                    Space(84, y);
                    PrintLine("Invalid Name format! Enter again: ", 50, y);
                    userName = Inputs();
                }
                if (UserNameValidationCheck(userName) == true) // checks the validation of the user Name
                {
                    break;
                }
            }

            EraseInstruction(); // erases the instructions

            return userName;
        }
        static bool UserNameValidationCheck(string userName)
        {
            bool check = true;

            if (userName[0] >= 'A' && userName[0] <= 'Z') // checks if user has entered first letter capital
            {
                int i = 0;
                while (userName.Length>i)
                {
                    if ((userName[i] < 'A' || userName[i] > 'Z') && (userName[i] < 'a' || userName[i] > 'z') && userName[i] != ' ') // checks if user has alphabets only and no number
                    {
                        check = false;
                    }
                    i++;
                }
            }
            else // if any other character found returns false
            {
                check = false;
            }

            return check;
        }
        static string UserIDSignup(string[] passengerID, int passengerCountIdx)
        {
            NoteuserIDpassenger(); // prints the instructions for userID

            string ID = "";

            for (int i = 0; i < 3; i++)
            {
                ID = UserIDInput(i, 24);                                            // takes userID input
                if (UserIDCheckSignup(ID, passengerID, passengerCountIdx) == false) // if userID valid loop terminates
                {
                    break;
                }
            }

            EraseInstruction();

            return ID;
        }
        static bool UserIDCheckSignup(string ID, string[] passengerID, int passengerCountIdx)
        {
            bool check = false;
            // checks userID whether it already exists or not and its characters
            if (ID.Length >= 6 && ID.Length <= 12)
            {
                int i = 0;
                while (ID.Length>i)
                {
                    if (ID[i] == ' ' || ID[i] == ';')
                    {
                        check = true;
                    }
                    i++;
                }
                if (check == false)
                {
                    if ((ID[0] != 'e' || ID[1] != 'm' || ID[2] != 'p') && ID != "admin")
                    {
                        check = UserCheck(ID, passengerID, passengerCountIdx);
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            else
            {
                check = true;
            }

            return check;
        }
        static string UserPasswordSignup(int y)
        {
            NoteSUpassword(); // prints the instructions for user password

            string password="";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    PrintLine("Enter password(6 to 12 characters): ",50,y);
                    password = Inputs();
                }
                else
                {
                    Space(86, y);
                    PrintLine("Invalid Pasword format! Enter again: ",50,y);
                    password = Inputs();
                }
                if (PasswordValidationCheckSignup(password) == true)
                {
                    break;
                }
            }

            EraseInstruction(); // erases the instructions

            return password;
        }
        static bool PasswordValidationCheckSignup(string password)
        {
            int charCount = 0; // counts number of characters in the password
            int numCount = 0;  // counts number of numbers in the password

            // checks the length of password and other conditions
            if (password.Length >= 6 && password.Length <= 12)
            {
                int a = 0;
                while (password.Length>a)
                {
                    if (password[a] >= '0' && password[a] <= '9')
                    {
                        numCount++;
                    }
                    else if ((password[a] >= 'a' && password[a] <= 'z') || (password[a] >= 'A' && password[a] <= 'Z'))
                    {
                        charCount++;
                    }
                    else if (password[a] == ' ' || password[a] == ';')
                    {
                        numCount = 0;
                        break;
                    }

                    a++;
                }
                if (numCount > 0 && charCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static string UserCnicSignup(string[] passengerCnic, string[] employeeCnic, int passengerCountIdx, int employeeCountIdx, int y)
        {
            NoteSUcnic(); // prints the instructions for user cnic

            string cnic="";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    PrintLine("Enter Cnic: ",50,y);
                    cnic = Inputs();
                }
                else
                {
                    Space(77, y);
                    PrintLine("Invalid Cnic! Enter again: ",50,y);
                    cnic = Inputs();
                }
                if (UserCnicValidationSignup(cnic, passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx) == true)
                {
                    break;
                }
            }

            EraseInstruction(); // erases the instructions

            return cnic;
        }
        static bool UserCnicValidationSignup(string cnic, string[] passengerCnic, string[] employeeCnic, int passengerCountIdx, int employeeCountIdx)
        {
            bool cnicCheck = true;
            //  checks if user cnic consists of only 13 numbers else returns false
            if (cnic.Length != 13)
            {
                cnicCheck = false;
            }
            else
            {
                int b = 0;
                while (cnic.Length>b)
                {
                    if (cnic[b] < '0' || cnic[b] > '9')
                    {
                        cnicCheck = false;
                        break;
                    }
                    b++;
                }
                if (cnicCheck == true)
                {
                    for (int c = 0; c < passengerCountIdx; c++)
                    {
                        if (cnic == passengerCnic[c])
                        {
                            cnicCheck = false;
                        }
                    }
                    if (cnicCheck == true)
                    {
                        for (int c = 0; c < employeeCountIdx; c++)
                        {
                            if (cnic == employeeCnic[c])
                            {
                                cnicCheck = false;
                                break;
                            }
                        }
                    }
                }
            }

            return cnicCheck;
        }
        static void SaveSUInformation(string name, string[] userName, string ID, string[] userID, string password, string[] idPassword, string cnic, string[] userCnic,ref int userCountIdx)
        {
            // saves user information in arrays
            int idxSU = userCountIdx;
            userName[idxSU] = name;
            userID[idxSU] = ID;
            idPassword[idxSU] = password;
            userCnic[idxSU] = cnic;
            userCountIdx++;
        }
        static void TicketStatusPassenger(string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice, int index)
        {
            // saves user ticket info in start
            passengerTicketStatus[index] = "N.A";
            passengerTrainNo[index] = "N.A";
            passengerTicketRoute[index] = "N.A";
            passengerArrivalCity[index] = "N.A";
            passengerDepartureCity[index] = "N.A";
            passengerTicketPrice[index] = 0;
        }

        // user sign in functions
        static string UserIDSignIn(string[] passengerID, string[] employeeID, int passengerCountIdx, int employeeCountIDx)
        {
            string ID="";

            for (int i = 0; i < 3; i++)
            {
                ID = UserIDInput(i, 23);
                if (UserCheckSignIn(ID, passengerID, employeeID, passengerCountIdx, employeeCountIDx) == true || ID == "admin")
                {
                    break;
                }
            }

            return ID;
        }
        static bool UserCheckSignIn(string ID, string[] passengerID, string[] employeeID, int passengerCountIdx, int employeeCountIdx)
        {
            bool check;

            if (ID[0] == 'e' && ID[1] == 'm' && ID[2] == 'p')
            {
                check = UserCheck(ID, employeeID, employeeCountIdx);
            }
            else
            {
                check = UserCheck(ID, passengerID, passengerCountIdx);
            }

            return check;
        }
        static string AdminPasswordCheck()
        {
            string password="";
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    PrintLine("Enter password: ",50,24);
                    password = Inputs();
                }
                else
                {
                    Space(76, 24);
                    PrintLine("Invalid Password! Enter again: ",50,24);
                    password = Inputs();
                }
                if (password == "admin")
                {
                    break;
                }
            }
            return password;
        }
        static bool UserCheck(string ID, string[] userID, int userCountIdx)
        {
            bool x = false;

            for (int idx = 0; idx < userCountIdx; idx++)
            {
                if (ID == userID[idx])
                {
                    x = true;
                    break;
                }
            }

            return x;
        }
        static string RoleCheck(string ID)
        {
            if (ID[0] == 'e' && ID[1] == 'm' || ID[2] == 'p')
            {
                return "Employee";
            }
            else
            {
                return "Passenger";
            }
        }
        static int IndexCheck(string ID, string[] userID, int userCountIdx)
        {
            int index=-1;
            for (int idx = 0; idx < userCountIdx; idx++)
            {
                if (ID == userID[idx])
                {
                    index = idx;
                    break;
                }
            }
            return index;
        }
        static string UserPasswordSignIn(string idPassword)
        {
            string password="";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    PrintLine("Enter Password: ",50,24);
                    password = Inputs();
                }
                else
                {
                    Space(80, 24);
                    PrintLine("Invalid Password! Enter again: ",50,24);
                    password = Inputs();
                }
                if (password == idPassword)
                {
                    break;
                }
            }

            return password;
        }

        // add employee functions
        static void AddEmployeeData(string[] employeeName, string[] employeeID, string[] employeeIDPassword, string[] employeeCnic, string[] passengerCnic,ref int employeeCountIdx, int passengerCountIdx)
        {
            if (employeeCountIdx == 100)
            {
                PrintStatement("Sorry Employee cannot be added!", 50, 24, "W");
            }
            else
            {
                string empNamein = UserNameSignUp(23);                  // name of employee
                bool empNameCheck = UserNameValidationCheck(empNamein); // checks if name entered is valid

                if (empNameCheck == true)
                {
                    string empIdin = EmpUserIDInput(employeeID, employeeCountIdx);            // username of employee ID
                    bool empIDCheck = EmployeeIDCheck(empIdin, employeeID, employeeCountIdx); // if employee ID already exists return true otherwise false

                    if (empIDCheck == true) // if employee ID already exists or wrong input
                    {
                        PrintStatement("Invalid employee IDs. Failed to add employee!", 50, 25, "W");
                    }
                    else // if employee ID does not exist
                    {
                        string empPasswordin = UserPasswordSignup(25);                      // password for employee ID
                        bool passValidation = PasswordValidationCheckSignup(empPasswordin); // if password is valid returns true

                        if (passValidation == true) // if admin uses correct password format for employee ID
                        {
                            string empCnicin = UserCnicSignup(passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx, 26);                // cnic of employee
                            bool cnicCheck = UserCnicValidationSignup(empCnicin, passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx); // checks if employee cnic is valid

                            if (cnicCheck == true) // if employee cnic is correct
                            {
                                // saving info of the emoloyee
                                SaveSUInformation(empNamein, employeeName, empIdin, employeeID, empPasswordin, employeeIDPassword, empCnicin, employeeCnic,ref employeeCountIdx);

                                PrintStatement("Employee added successfully!", 50, 27, " ");
                                // saving data in file
                                EmployeesNewDataFile(employeeName, employeeID, employeeIDPassword, employeeCnic, employeeCountIdx);
                            }
                            else // if employee cnic was not correct
                            {
                                PrintStatement("Invalid employee Cnic. Failed to add employee!", 50, 27, "W");
                            }
                        }
                        else // if admin enters wrong format for password for employee ids
                        {
                            PrintStatement("Invalid Passwords. Failed to add employee!", 50, 26, "W");
                        }
                    }
                }
                else
                {
                    PrintStatement("Invalid Name format. Failed to add employee!", 50, 24, "W");
                }
            }
        }
        static string EmpUserIDInput(string[] employeeID, int employeeCountIdx)
        {
            NoteAddEmployee();

            string userName="";

            for (int i = 0; i < 3; i++)
            {
                userName = UserIDInput(i, 24);
                if (EmployeeIDCheck(userName, employeeID, employeeCountIdx) == false)
                {
                    break;
                }
            }

            EraseInstruction();

            return userName;
        }
        static bool EmployeeIDCheck(string empIDin, string[] employeeID, int employeeCountIdx)
        {
            bool check = false;

            if (empIDin.Length >= 6)
            {
                int i = 0;
                while (empIDin.Length > i)
                {
                    if (empIDin[i] == ' ' || empIDin[i] == ';')
                    {
                        check = true;
                    }
                    i++;
                }
                if (check == false)
                {
                    if ((empIDin[0] == 'e' && empIDin[1] == 'm' && empIDin[2] == 'p') && empIDin != "admin")
                    {
                        check = UserCheck(empIDin, employeeID, employeeCountIdx);
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            else
            {
                check = true;
            }

            return check;
        }

        // add passenger ID functions
        static void AddPassengerData(string[] passengerName, string[] passengerID, string[] passengerIDPassword, string[] passengerCnic, string[] employeeCnic,ref int passengerCountIdx, int employeeCountIdx)
        {
            if (passengerCountIdx == 1000) // if username space not available
            {
                PrintStatement("Sorry, PassengerID cannot be added up!", 50, 24, "W");
            }
            else // if username space is available
            {
                string passengerNameSU = UserNameSignUp(23);                        // name of user
                bool passengerNameCheck = UserNameValidationCheck(passengerNameSU); // checks if Name enterd by the user is in correct format or not

                if (passengerNameCheck == true)
                {
                    string userIDSU = UserIDSignup(passengerID, passengerCountIdx);                     // username for signing up
                    bool userNameCheckSU = UserIDCheckSignup(userIDSU, passengerID, passengerCountIdx); // if username already exists return true otherwise false

                    if (userNameCheckSU == true) // if username already exists or wrong input
                    {
                        PrintStatement("Invalid UserID. Failed adding PassengerID!", 50, 25, "W");
                    }
                    else // if username does not exist
                    {
                        string userPasswordSU = UserPasswordSignup(25);                  // password for signing up
                        bool validation = PasswordValidationCheckSignup(userPasswordSU); // if password is valid returns true

                        if (validation == true) // if passenger uses correct password format
                        {
                            string userCnicSU = UserCnicSignup(passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx, 26);                // cnic for signing up
                            bool cnicCheck = UserCnicValidationSignup(userCnicSU, passengerCnic, employeeCnic, passengerCountIdx, employeeCountIdx); // checks if cnic is valid

                            if (cnicCheck == true) // if cnic is correct
                            {
                                // saving info for sign up
                                SaveSUInformation(passengerNameSU, passengerName, userIDSU, passengerID, userPasswordSU, passengerIDPassword, userCnicSU, passengerCnic,ref passengerCountIdx);

                                PrintStatement("PassengerID added successfully!", 50, 27, " ");
                            }
                            else // if cnic format is not correct
                            {
                               PrintStatement("Invalid Cnic. Failed adding PassengerID!", 50, 27, "W");
                            }
                        }
                        else // if user uses wrong format for password
                        {
                            PrintStatement("Invalid Password format. Failed adding PassengerID!", 50, 26, "W");
                        }
                    }
                }
                else
                {
                    PrintStatement("Invalid Name format. Failed adding PassengerID!", 50, 24, "W");
                }
            }
        }

        // user data functions
        static void DeleteUserData(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic, string uCode,ref int userCountIdx)
        {
            PrintLine("Enter " + uCode + "ID: ",50,23);
            string ID = Inputs();

            if (UserCheck(ID, userID, userCountIdx) == true)
            {
                int idx = IndexCheck(ID, userID, userCountIdx);

                ViewUserData(userName, userID, userIDPassword, userCnic, idx, 50, 25);
                string option = YesNoChoice(uCode);

                if (option == "1" || option == "Yes")
                {
                    DeleteData(userName, userID, userIDPassword, userCnic,ref userCountIdx, idx);
                    PrintStatement(uCode + " data deleted successfully!", 50, 33, " ");
                }
                else if (option == "2" || option == "No")
                {
                    PrintStatement(uCode + " data not deleted!", 50, 33, " ");
                }
            }
            else
            {
                PrintLine(uCode + " data not found!",50,25);
                PressAnyKey(50, 26);
            }
        }
        static string YesNoChoice(string uCode)
        {
            PrintLine("Are you sure you want to delete " + uCode + " data?",50,30);
            PrintLine("       1.Yes            2.No",50,31);
            string option;
            while (true)
            {
                Space(64, 32);
                PrintLine("Enter option: ", 50, 32);
                option = Inputs();
                if (option == "Yes" || option == "No" || option == "1" || option == "2")
                {
                    break;
                }
            }

            return option;
        }
        static void DeleteData(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic,ref int userCountIdx, int index)
        {
            for (int j = index; j < userCountIdx; j++)
            {
                userName[j] = userName[j + 1];
                userID[j] = userID[j + 1];
                userIDPassword[j] = userIDPassword[j + 1];
                userCnic[j] = userCnic[j + 1];
            }

            userCountIdx--;
        }
        static void DeleteTicketData(string[] passengerTicketStatus, string[] trainNO, string[] passengerArrivalCity, string[] passengerDepartureCity, string[] passengerTrainroute, int[] ticketPrice, int idx, int delidx)
        {
            for (int i = idx; i < delidx; i++)
            {
                passengerTicketStatus[i] = passengerTicketStatus[i + 1];
                trainNO[i] = trainNO[i + 1];
                passengerArrivalCity[i] = passengerArrivalCity[i + 1];
                passengerDepartureCity[i] = passengerDepartureCity[i + 1];
                passengerTrainroute[i] = passengerTrainroute[i + 1];
                ticketPrice[i] = ticketPrice[i + 1];
            }
        }
        static void UpdateUserData(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic, string[] user2Cnic, string uCode, int userCountIdx, int user2CountIdx)
        {
            PrintLine("Enter " + uCode + "ID: ",50,23);
            string ID = Inputs();

            if (UserCheck(ID, userID, userCountIdx) == true)
            {
                int idx = IndexCheck(ID, userID, userCountIdx);

                PrintLine("User Information",50,23);
                ViewUserData(userName, userID, userIDPassword, userCnic, idx, 15, 25);

                string option;
                option = UpdateDataChoice();
                string ind;
                ind = UpdateData(userName, userCnic, user2Cnic, userCountIdx, user2CountIdx, idx, option);

                if (ind == "Y")
                {
                    PrintStatement(uCode + " data updated successfully!", 50, 29, " ");
                }
                else
                {
                    PrintStatement(uCode + " data not updated!", 50, 29, "W");
                }
            }
            else
            {
                PrintStatement(uCode + "ID not found!", 50, 25, "W");
            }
        }
        static string UpdateDataChoice()
        {
            string option;
            PrintLine("Which attribute do you want to change?",50,25);
            PrintLine("1.Name        2.CNIC       3.Exit",50,26);
            while (true)
            {
                Space(63, 27);
                PrintLine("Enter option: ",50,27);
                option = Inputs();
                if (option == "1" || option == "2" || option == "3")
                {
                    break;
                }
            }
            return option;
        }
        static string UpdateData(string[] userName, string[] userCnic, string[] user2Cnic, int userCountIdx, int user2countIdx, int index, string option)
        {
            if (option == "1")
            {
                string newName = UserNameSignUp(28);
                if (UserNameValidationCheck(newName) == true)
                {
                    userName[index] = newName;
                    return "Y";
                }
            }
            else if (option == "2")
            {
                string newCnic = UserCnicSignup(userCnic, user2Cnic, userCountIdx, user2countIdx, 28);
                if (UserCnicValidationSignup(newCnic, userCnic, user2Cnic, userCountIdx, user2countIdx) == true)
                {
                    userCnic[index] = newCnic;
                    return "Y";
                }
            }
            else if (option == "3")
            {
                return " ";
            }
            return " ";
        }
        static void ViewUserDataList(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic, string uCode, int userCountIdx)
        {
            PrintLine($"{"Name", -20}{"Cnic", -20}{"UserID", -20}{"Password", -20}",36,23);
            if (userCountIdx > 0)
            {
                int y = 25;

                for (int idx = 0; idx < userCountIdx; idx++)
                {
                    PrintLine($"{userName[idx],-20}{userCnic[idx],-20}{userID[idx],-20}{userIDPassword[idx],-20}", 36, y);
                    y++;
                }

                PressAnyKey(50, y + 1);
            }
            else
            {
                PrintLine("No " + uCode + "ID exists.",36,25);
                PrintLine("Add " + uCode + "s to view data!",36,26);

                PressAnyKey(50, 28);
            }
        }
        static void ViewUserData(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic, int index, int x, int y)
        {
            PrintLine("Name: " + userName[index],x,y);
            PrintLine("UserID: " + userID[index],x,y+1);
            PrintLine("Password: " + userIDPassword[index],x,y+2);
            PrintLine("Cnic: " + userCnic[index],x,y+3);
        }
        static void SearchUserData(string[] userName, string[] userID, string[] userIDPassword, string[] userCnic, string uCode, int userCountIdx)
        {
            PrintLine("Enter " + uCode + "ID: ",50,23);
            string ID;
            ID=Inputs();

            if (UserCheck(ID, userID, userCountIdx) == true)
            {
                int idx = IndexCheck(ID, userID, userCountIdx);

                ViewUserData(userName, userID, userIDPassword, userCnic, idx, 50, 25);
                PressAnyKey(50, 30);
            }
            else
            {
                PrintStatement(uCode + " data not found!", 50, 25, "W");
            }
        }
        static string ChangePassword(string[] idPassword, int index)
        {
            string password;
            PrintLine("Enter current password: ",50,23);
            password = Inputs();
            string newPassword;
            if (password == idPassword[index])
            {
                newPassword = UserPasswordSignup(25);
                bool validation = PasswordValidationCheckSignup(newPassword);

                if (validation == true && newPassword != password)
                {
                    idPassword[index] = newPassword;
                    PrintStatement("Password changed successfully!", 50, 26, " ");
                    return newPassword;
                }
                else if (newPassword == password)
                {
                    PrintStatement("Existing password cannot be used! Password not changed!", 50, 26, "W");
                    return " ";
                }
                else
                {
                    PrintStatement("Invalid Password format! Password not changed!", 50, 26, "W");
                    return " ";
                }
            }
            else
            {
                PrintStatement("Wrong credentials! Password not changed!", 50, 24, "W");
                return " ";
            }
        }

        // train addition removal functions
        static void AddTrainRoute(string[] trainNo, string[] trainArrivalCity, string[] trainDepartureCity, string[] trainRoute, int[] ticketPrice,ref int trainCountIdx, string[] cities)
        {
            string trainID = TrainNoInput(trainNo, trainCountIdx);
            bool validation = TrainNoValidation(trainID, trainNo, trainCountIdx);

            if (validation)
            {
                trainDepartureCity[trainCountIdx] = TrainDepartureCityInput(cities);
                trainArrivalCity[trainCountIdx] = TrainArrivalCityInput(trainDepartureCity[trainCountIdx], cities);
                trainRoute[trainCountIdx] = trainDepartureCity[trainCountIdx] + "-to-" + trainArrivalCity[trainCountIdx];
                trainNo[trainCountIdx] = trainID;

                PrintLine("Route of train " + trainNo[trainCountIdx] + " " + trainRoute[trainCountIdx],50,26);
                ticketPrice[trainCountIdx] = TrainTicketPriceIn();
                trainCountIdx++;

                PrintStatement("Train data added successfully!", 50, 28, " ");
            }
            else
            {
                PrintStatement("Invalid trainNO! Train route not added!", 50, 24, "W");
            }
        }
        static string TrainNoInput(string[] trainNo, int trainCountIdx)
        {
            NoteAddTrain();
            string trainNoIn="";

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Space(64, 23);
                    PrintLine("Enter trainNo: ",50,23);
                    trainNoIn = Inputs();
                }
                else
                {
                    Space(80, 23);
                    PrintLine("Invalid trainNo! Enter again: ",50,23);
                    trainNoIn = Inputs();
                }
                if (TrainNoValidation(trainNoIn, trainNo, trainCountIdx) == true)
                {
                    break;
                }
            }

            EraseInstruction();

            return trainNoIn;
        }
        static bool TrainNoValidation(string trainNoIn, string[] trainNo, int trainCountIdx)
        {
            bool check = true;

            if (trainNoIn.Length >= 4 && trainNoIn.Length <= 12)
            {
                int i = 0;
                while (trainNoIn.Length > i)
                {
                    if (!((trainNoIn[i] >= 'a' && trainNoIn[i] <= 'z') || (trainNoIn[i] >= 'A' && trainNoIn[i] <= 'Z') || (trainNoIn[i] >= '0' && trainNoIn[i] <= '9') || trainNoIn[i] == '-'))
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check == true)
                {
                    check = TrainCheck(trainNoIn, trainNo, trainCountIdx);
                }
            }
            else
            {
                check = false;
            }

            return check;
        }
        static string TrainDepartureCityInput(string[] cities)
        {
            NoteDepartureCity(cities);

            string departureCity;

            while (true)
            {
                Space(72, 24);
                PrintLine("Enter Departure City: ",50, 24);
                departureCity = Inputs();
                if (CityNameValidation(departureCity, cities) == true)
                {
                    break;
                }
            }

            return departureCity;
        }
        static bool TrainCheck(string trainNoIn, string[] trainNo, int trainCountIdx)
        {
            bool check = true;
            if (trainCountIdx > 0)
            {
                for (int idx = 0; idx < trainCountIdx; idx++)
                {
                    if (trainNoIn == trainNo[idx])
                    {
                        check = false;
                        break;
                    }
                }
            }
            else
            {
                check = true;
            }
            return check;
        }
        static string TrainArrivalCityInput(string departureCity, string[] cities)
        {
            NoteArrivalCity(departureCity, cities);
            string arrivalCity;

            while (true)
            {
                Space(70, 25);
                PrintLine("Enter Arrival City: ", 50, 25);
                arrivalCity = Inputs();
                if (CityNameValidation(arrivalCity, cities) == true && arrivalCity != departureCity)
                {
                    break;
                }
            }

            return arrivalCity;
        }
        static bool CityNameValidation(string city, string[] cities)
        {
            bool check = false;

            for (int i = 0; i < 15; i++)
            {
                if (city == cities[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        static int TrainTicketPriceIn()
        {
            string price;
            while (true)
            {
                Space(70, 27);
                PrintLine("Enter ticket price: ", 50, 27);
                price = Inputs();

                if (TicketPriceValidation(price) == true)
                {
                    break;
                }
            }

            int trainTicketprice = StringToIntConversion(price);

            return trainTicketprice;
        }
        static bool TicketPriceValidation(string price)
        {
            bool check = true;

            int i = 0;
            while (price.Length > i)
            {
                if (price[i] < '0' || price[i] > '9')
                {
                    check = false;
                    break;
                }
                i++;
            }

            return check;
        }
        static int StringToIntConversion(string price)
        {
            double tPrice = 0;
            int i = 0;
            int j = price.Length - 1;
            while (i < price.Length)
            {
                tPrice += (price[i] - '0') * Math.Pow(10, j);
                i++;
                j--;
            }

            int ticketPrice = (int)Math.Ceiling(tPrice);
            return ticketPrice;
        }
        static void DeleteTrainTicketDetails(string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerArrivalCity, string[] passengerDepartureCity, string[] passengerTicketRoute, int[] passengerticketPrice, int passengerCountIdx, string trainID)
        {
            for (int idx = 0; idx < passengerCountIdx; idx++)
            {
                if (passengerTrainNo[idx] == trainID)
                {
                    passengerTicketRoute[idx] = "N.A";
                    passengerDepartureCity[idx] = "N.A";
                    passengerArrivalCity[idx] = "N.A";
                    passengerTrainNo[idx] = "N.A";
                    passengerTicketStatus[idx] = "N.A";
                    passengerticketPrice[idx] = 0;
                }
            }
        }
        static string DeleteTrainRoute(string[] trainNo, string[] trainArrivalCity, string[] trainDepartureCity, string[] trainRoute, int[] ticketPrice,ref int trainCountIdx)
        {
            PrintLine("Enter trainNo: ", 50, 23);
            string trainCode = Inputs();

            if (trainCountIdx > 0)
            {
                if (TrainCheck(trainCode, trainNo, trainCountIdx) == false)
                {
                    int idx = IndexCheck(trainCode, trainNo, trainCountIdx);
                    ViewTicketDetails(trainNo, trainRoute, trainArrivalCity, trainDepartureCity, ticketPrice, idx);
                    PrintLine("Do you want to delete train data?", 50, 28);
                    PrintLine("     1.Yes       2.No", 50, 29);
                    string option;
                    while (true)
                    {
                        Space(64, 30);
                        PrintLine("Enter option: ", 50, 30);
                        option = Inputs();
                        if (option == "Yes" || option == "No" || option == "1" || option == "2")
                        {
                            break;
                        }
                    }
                    if (option == "1" || option == "Yes")
                    {
                        DeleteData(trainNo, trainArrivalCity, trainDepartureCity, trainRoute, ticketPrice, idx,ref trainCountIdx);
                        PrintStatement("Train data deleted successfully!", 50, 31, " ");
                    }
                    else
                    {
                        trainCode = " ";
                        PrintStatement("Train data not deleted!", 50, 31, " ");
                    }
                }
                else
                {
                    trainCode = " ";
                    PrintStatement("Train data not found!", 50, 25, "W");
                }
            }
            else
            {
                trainCode = " ";
                PrintStatement("Train data not found!", 50, 25, "W");
            }

            return trainCode;
        }
        static void DeleteData(string[] trainNo, string[] trainArrivalCity, string[] trainDepartureCity, string[] trainRoute, int[] ticketPrice, int index,ref int trainCountIdx)
        {
            for (int i = index; i < trainCountIdx; i++)
            {
                trainNo[i] = trainNo[i + 1];
                trainArrivalCity[i] = trainArrivalCity[i + 1];
                trainDepartureCity[i] = trainDepartureCity[i + 1];
                trainRoute[i] = trainRoute[i + 1];
                ticketPrice[i] = ticketPrice[i + 1];
            }
            trainCountIdx--;
        }
        static void ViewTrainsAvailable(string[] trainNo, string[] trainArrivalCity, string[] trainDepartureCity, string[] trainRoute, int[] trainTicketPrice, int trainCountIdx)
        {
            PrintLine($"{"TrainNo",-20}{"DepartureCity",-20}{"Arrival City",-20}{"Route",-30}{"TicketPrice",-20}", 30, 23);
            if (trainCountIdx > 0)
            {
                int y = 25;

                for (int idx = 0; idx < trainCountIdx; idx++)
                {
                    PrintLine($"{trainNo[idx],-20}{trainDepartureCity[idx],-20}{trainArrivalCity[idx],-20}{trainRoute[idx],-30}{trainTicketPrice[idx],-20}", 30, y);
                    y++;
                }

                PressAnyKey(50, y + 1);
            }
            else
            {
                PrintLine("No train data available.", 50, 25);
                PressAnyKey(50, 26);
            }
        }

        // ticket related functions
        static void BookTickets(string[] passengerTicketStatus, string[] passengerTrainNo, string[] trainNo, string[] passengerArrivalCity, string[] trainArrivalCity, string[] passengerDepartureCity, string[] trainDepartureCity, string[] passengerTicketRoute, string[] trainRoute, int[] passengerTicketPrice, int[] trainTicketPrice, int index, int tCount)
        {
            if (passengerTicketStatus[index] == "Y")
            {
                PrintStatement("Ticket is already booked! Cancel ticket to book new one!", 50, 24, "W");
            }
            else
            {
                NoteRoutesavail(trainNo, trainRoute, tCount);
                string routeNo;
                int indexTrain;
                while (true)
                {
                    Space(96, 24);
                    PrintLine("Enter the Sr.No. for the train to book ticket: ", 50, 24);
                    routeNo = Inputs();
                    if (TicketPriceValidation(routeNo) == true && StringToIntConversion(routeNo) <= tCount && StringToIntConversion(routeNo) > 0)
                    {
                        break;
                    }
                    else if (routeNo == "esc")
                    {
                        break;
                    }
                }
                if (routeNo == "esc")
                {
                    PrintStatement("Ticket not booked!", 50, 25, "W");
                }
                else
                {
                    indexTrain = StringToIntConversion(routeNo) - 1;
                    SaveTicketData(passengerTicketStatus, passengerTrainNo, trainNo, passengerArrivalCity, trainArrivalCity, passengerDepartureCity, trainDepartureCity, passengerTicketRoute, trainRoute, passengerTicketPrice, trainTicketPrice, index, indexTrain);

                    PrintStatement("Ticket booked successfully!", 50, 25, " ");
                }
            }
        }
        static void SaveTicketData(string[] passengerTicketStatus, string[] passengerTrainNo, string[] trainNo, string[] passengerArrivalCity, string[] trainArrivalCity, string[] passengerDepartureCity, string[] trainDepartureCity, string[] passengerTicketRoute, string[] trainRoute, int[] passengerTicketPrice, int[] trainTicketPrice, int index, int indexTrain)
        {
            passengerTicketStatus[index] = "Y";
            passengerTrainNo[index] = trainNo[indexTrain];
            passengerTicketRoute[index] = trainRoute[indexTrain];
            passengerArrivalCity[index] = trainArrivalCity[indexTrain];
            passengerDepartureCity[index] = trainDepartureCity[indexTrain];
            passengerTicketPrice[index] = trainTicketPrice[indexTrain];
        }
        static void CancelTicket(string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice, int index)
        {
            ViewTicketDetails(passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, index);

            PrintLine("Are you sure you want to cancel ticket?", 50, 28);
            PrintLine("       1.Yes            2.No", 50, 29);
            string option;
            while (true)
            {
                Space(64, 30);
                PrintLine("Enter option: ", 50, 30);
                option = Inputs();
                if (option == "Yes" || option == "No" || option == "1" || option == "2")
                {
                    break;
                }
            }
            if (option == "Yes" || option == "1")
            {
                TicketStatusPassenger(passengerTicketStatus, passengerTrainNo, passengerTicketRoute, passengerArrivalCity, passengerDepartureCity, passengerTicketPrice, index);
                PrintStatement("Ticket cancelled successfully!", 50, 31, " ");
            }
            else
            {
                PrintStatement("Ticket not cancelled!", 50, 31, " ");
            }
        }
        static void ViewTicketDetails(string[] trainNo, string[] ticketRoute, string[] arrivalCity, string[] departureCity, int[] ticketPrice, int idx)
        {
            PrintLine($"{"TrainNo",-20}{"Train Route",-30}{"DepartureCity",-20}{"Arrival City",-20}{"TicketPrice",-20}", 25, 25);
            PrintLine($"{trainNo[idx],-20}{ticketRoute[idx],-30}{departureCity[idx],-20}{arrivalCity[idx],-20}{ticketPrice[idx],-20}", 25, 26);
        }
        static void ViewBookedTickets(string[] passengerName, string[] passengerCnic, string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice, int index)
        {
            if (index > 0)
            {
                PrintLine($"{"Name",-20}{"Passenger Cnic",-20}{"TicketRoute",-30}{"TrainNo",-20}{"DepartureCity",-20}{"ArrivalCity",-20}{"TicketPrice",-20}", 12, 23);
                int y = 25;
                int j = 0;
                for (int i = 0; i < index; i++)
                {
                    if (passengerTicketStatus[i] == "Y")
                    {
                        PrintLine($"{passengerName[i],-20}{passengerCnic[i],-20}{passengerTicketRoute[i],-30}{passengerTrainNo[i],-20}{passengerDepartureCity[i],-20}{passengerArrivalCity[i],-20}{passengerTicketPrice[i],-20}", 12, y);
                        y++;
                        j++;
                    }
                }
                if (j == 0)
                {
                    PrintStatement("No tickets data available!", 50, 25, "W");
                }
                else
                {
                    PressAnyKey(50, y + 1);
                }
            }
            else
            {
                PrintStatement("No tickets data available!", 50, 25, "W");
            }
        }
        static void TicketsDetails(string[] passengerTrainNo, string[] trainNo, int[] passengerTicketPrice, int[] trainTicketPrice, int passengerCountIdx, int trainCountIdx)
        {
            int totalRevenue = 0;
            int totalTicketsSold = 0;
            int[] numOfBookedTickets = new int[trainCountIdx];
            int[] revenueOfEachTrain = new int[trainCountIdx];
            if (trainCountIdx > 0 && passengerCountIdx > 0)
            {
                for (int i = 0; i < trainCountIdx; i++)
                {
                    numOfBookedTickets[i] = 0;
                    revenueOfEachTrain[i] = 0;

                    for (int j = 0; j < passengerCountIdx; j++)
                    {
                        if (passengerTrainNo[j] == trainNo[i])
                        {
                            numOfBookedTickets[i]++;
                            totalRevenue += passengerTicketPrice[j];
                            totalTicketsSold++;
                        }
                    }
                    revenueOfEachTrain[i] = trainTicketPrice[i] * numOfBookedTickets[i];
                }
                PrintLine($"{"TrainNo",-20}{"No. of tickets booked",-25}{"Revenue Collected"}", 45, 24);
                int y = 25;
                for (int i = 0; i < trainCountIdx; i++)
                {
                    PrintLine($"{trainNo[i],-20}{numOfBookedTickets[i],-25}{"Rs."+revenueOfEachTrain[i]}", 45, y);
                    y++;
                }
                PrintLine("Total Booked Tickets: " + totalTicketsSold, 50, y + 1);
                PrintLine("Total Revenue Collected: " + totalRevenue, 50, y + 2);
                PressAnyKey(50, y + 3);
            }
            else
            {
                PrintStatement("Data not available", 50, 24, "W");
            }
        }

        // employee file handeling functions
        static void EmployeesNewDataFile(string[] employeeName, string[] employeeId, string[] employeeIDPassword, string[] employeeCnic, int employeeCountIdx)
        {
            StreamWriter employeeFile = new StreamWriter("employeeData.txt", true); // append mode

            employeeFile.WriteLine($"{employeeName[employeeCountIdx - 1]};{employeeId[employeeCountIdx - 1]};{employeeIDPassword[employeeCountIdx - 1]};{employeeCnic[employeeCountIdx - 1]};;");

            employeeFile.Close();
        }
        static void EmployeesDataUpdateFile(string[] employeeName, string[] employeeId, string[] employeeIDPassword, string[] employeeCnic, int employeeCountIdx)
        {
            StreamWriter employeeFile = new StreamWriter("employeeData.txt");

            for (int i = 0; i < employeeCountIdx; i++)
            {
                employeeFile.WriteLine($"{employeeName[i]};{employeeId[i]};{employeeIDPassword[i]};{employeeCnic[i]};;");
            }

            employeeFile.Close();
        }
        static void EmployeeDataLoad(string[] employeeName, string[] employeeId, string[] employeeIDPassword, string[] employeeCnic,ref int employeeCountIdx)
        {

            string line;
            StreamReader employeeFile = new StreamReader("employeeData.txt");
            int i = 0;
            while ((line = employeeFile.ReadLine()) != null)
            {
                int j = 0;
                if (line[line.Length - 1] == ';' && line[line.Length - 2] == ';' && line[line.Length - 16] == ';' && line[0] != ';')
                {
                    employeeName[i] = LoadUserAttribute(line, ref j);
                    j++;
                    employeeId[i] = LoadUserAttribute(line, ref j);
                    j++;
                    employeeIDPassword[i] = LoadUserAttribute(line, ref j);
                    j++;
                    employeeCnic[i] = LoadUserAttribute(line, ref j);
                    i++;
                }
            }
            employeeCountIdx = i;
            employeeFile.Close();
        }
        
        // passenger file handeling functions
        static void PassengersNewDataFile(string[] passengerName, string[] passengerID, string[] passengerIDPassword, string[] passengerCnic, string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice, int passengerCountIdx)
        {
            StreamWriter passengerFile = new StreamWriter("passengerData.txt", true); // append mode

            passengerFile.WriteLine($"{passengerName[passengerCountIdx - 1]};{passengerID[passengerCountIdx - 1]};{passengerIDPassword[passengerCountIdx - 1]};{passengerCnic[passengerCountIdx - 1]};{passengerTicketStatus[passengerCountIdx - 1]};{passengerTrainNo[passengerCountIdx - 1]};{passengerTicketRoute[passengerCountIdx - 1]};{passengerArrivalCity[passengerCountIdx - 1]};{passengerDepartureCity[passengerCountIdx - 1]};{passengerTicketPrice[passengerCountIdx - 1]};;");

            passengerFile.Close();
        }
        static void PassengersDataUpdateFile(string[] passengerName, string[] passengerID, string[] passengerIDPassword, string[] passengerCnic, string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice, int passengerCountIdx)
        {
            StreamWriter passengerFile = new StreamWriter("passengerData.txt");

            for (int i = 0; i < passengerCountIdx; i++)
            {
                passengerFile.WriteLine($"{passengerName[i]};{passengerID[i]};{passengerIDPassword[i]};{passengerCnic[i]};{passengerTicketStatus[i]};{passengerTrainNo[i]};{passengerTicketRoute[i]};{passengerArrivalCity[i]};{passengerDepartureCity[i]};{passengerTicketPrice[i]};;");
            }

            passengerFile.Close();
        }
        static void PassengersDataLoad(string[] passengerName, string[] passengerID, string[] passengerIDPassword, string[] passengerCnic, string[] passengerTicketStatus, string[] passengerTrainNo, string[] passengerTicketRoute, string[] passengerArrivalCity, string[] passengerDepartureCity, int[] passengerTicketPrice,ref int passengerCountIdx)
        {
            string line;
            StreamReader passengerFile = new StreamReader("passengerData.txt");
            int i = 0;
            while ((line = passengerFile.ReadLine()) != null)
            {
                int j = 0;
                if (line[line.Length - 1] == ';' && line[line.Length - 2] == ';' && line[0] != ';')
                {
                    passengerName[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerID[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerIDPassword[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerCnic[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerTicketStatus[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerTrainNo[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerTicketRoute[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerArrivalCity[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerDepartureCity[i] = LoadUserAttribute(line, ref j);
                    j++;
                    passengerTicketPrice[i] = StringToIntConversion(LoadUserAttribute(line, ref j));
                    i++;
                }
            }
            passengerCountIdx = i;
            passengerFile.Close();
        }
        
        // train file handeling functions
        static void TrainsNewDataFile(string[] trainNo, string[] trainRoute, string[] trainArrivalCity, string[] trainDepartureCity, int[] ticketPrice, int trainCountIdx)
        {
            StreamWriter trainFile = new StreamWriter("trainData.txt", true); // append mode

            trainFile.WriteLine($"{trainNo[trainCountIdx - 1]};{trainRoute[trainCountIdx - 1]};{trainArrivalCity[trainCountIdx - 1]};{trainDepartureCity[trainCountIdx - 1]};{ticketPrice[trainCountIdx - 1]};;");

            trainFile.Close();
        }
        static void TrainsDataUpdateFile(string[] trainNo, string[] trainRoute, string[] trainArrivalCity, string[] trainDepartureCity, int[] ticketPrice, int trainCountIdx)
        {

            StreamWriter trainFile = new StreamWriter("trainData.txt");

            for (int i = 0; i < trainCountIdx; i++) // stores all the
            {
                trainFile.WriteLine($"{trainNo[i]};{trainRoute[i]};{trainArrivalCity[i]};{trainDepartureCity[i]};{ticketPrice[i]};;");
            }

            trainFile.Close();
        }
        static void TrainsDataLoad(string[] trainNo, string[] trainRoute, string[] trainArrivalCity, string[] trainDepartureCity, int[] ticketPrice,ref int trainCountIdx)
        {
            string line;
            StreamReader trainFile = new StreamReader("trainData.txt");
            int i = 0;
            while ((line = trainFile.ReadLine()) != null) // loop terminates if file ends
            {
                int j = 0;
                if (line[line.Length - 1] == ';' && line[line.Length - 2] == ';' && line[0] != ';')
                {
                    trainNo[i] = LoadUserAttribute(line, ref j);
                    j++;
                    trainRoute[i] = LoadUserAttribute(line, ref j);
                    j++;
                    trainArrivalCity[i] = LoadUserAttribute(line, ref j);
                    j++;
                    trainDepartureCity[i] = LoadUserAttribute(line, ref j);
                    j++;
                    ticketPrice[i] = StringToIntConversion(LoadUserAttribute(line, ref j));
                    i++;
                }
            }
            trainCountIdx = i;
            trainFile.Close();
        }

        // loads each attribute of a user
        static string LoadUserAttribute(string line, ref int idx)
        {
            string n="";
            while (line.Length > idx) // stores the word character by character till semicolon is found
            {
                n = string.Concat(n, line[idx]);
                idx++;
                if (line[idx]==';')
                {
                    break;
                }
            }
            return n;
        }

        // redudant functions
        static void Space(int x, int y)
        {
            PrintLine("                                                  ", x, y);
        }
        static string Inputs()
        {
            string input;
            input = Console.ReadLine();
            return input;
        }
        static string UserIDInput(int i, int y)
        {
            string userName;

            if (i == 0) // if user enters wrong userID
            {
                PrintLine("Enter userID: ", 50, y);
                userName = Inputs();
            }
            else // if user enters wrong userId
            {
                Space(76, y);
                PrintLine("Invalid userID! Enter again: ", 50, y);
                userName = Inputs();
            }

            return userName;
        }
        static void PrintLineSH(string line, int x, int y)
        {
            Thread.Sleep(70);
            PrintLine(line, x, y);
        }
        static void HeaderCls()
        {
            Console.Clear();
            Header();
        }
        static void PressAnyKey(int x, int y)
        {
            PrintLine("Press any key to continue...", x, y);
            Console.ReadKey();
        }
        static void PrintStatement(string statement, int x, int y, string ind)
        {
            if (ind == "W")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            PrintLine(statement, x, y);
            PressAnyKey(50, y + 1);
        }
        static void PrintLine(string line, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(line);
        }
    }
}