using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.DAL;
using Capstone.Models;
using Capstone.Classes;
using System.Globalization;

namespace Capstone
{
    public class CampgroundCLI
    {
        const string Command_ShowAllParks = "1";
        const string Command_ShowAllCampgrounds = "2"; //Can be made into sub menu in ALL PARKS
        const string Command_CampgroundSelect = "3";
        //Ask if they want to make a reservation at the end of CampgroundSelect. If yes, run MakeReservation method otherwise return to main menu.
        const string Command_SearchAvailableCampsites = "4";
        const string Command_SearchForUpcomingReservations = "5";
        const string Command_Quit = "q";
        //const string DatabaseConnection = @"Data Source=DESKTOP-6JSSBN8\SQLEXPRESS;Initial Catalog=Campgrounds;Integrated Security=True";
        const string DatabaseConnection = @"Data Source=DESKTOP-CTIJ0GB\SQLEXPRESS;Initial Catalog=ProjectOrganizer;Integrated Security=True";

        // This object calls on the Headers class >>
        Headers headers = new Headers();

        int selectedPark;
        int selectedCampground;
        int selectedSite;
        string reservationName = "";

        public void RunCLI()
        {
            while (true)
            {
                headers.PrintMainMenuHeader();
                PrintMainMenu();
                Console.Write($"Please make a selection: ");
                string command = Console.ReadLine();

                Console.Clear();

                switch (command.ToLower())
                {
                    case Command_ShowAllParks:
                        PrintParksInterfaceMenu();
                        break;

                    case Command_ShowAllCampgrounds:
                        ShowAllCampgrounds();
                        break;

                    case Command_CampgroundSelect:
                        //SearchForAvailableSite(selectedCampground);
                        break;

                    case Command_SearchAvailableCampsites:
                      //  SearchAvailableSites();
                        break;

                    case Command_SearchForUpcomingReservations:
                        GetUpcomingReservationMenu();
                        break;

                    case Command_Quit:
                        headers.PrintMainMenuHeader();
                        Console.WriteLine("Thank you for using the National Park Campsite Reservation System!\n");
                        return;

                    default:
                        Console.WriteLine("The command provided was not a valid command, please try again.");
                        break;
                }
            }
        }

        // Add a make reservation method.

        ///////////////////////////
        // METHODS ///////////
        ///////////////

        private void PrintMainMenu()
        {
            Console.WriteLine("\nMain Menu:\n");
            Console.WriteLine(" 1 - Show all national parks");
            Console.WriteLine(" 2 - Show all campgrounds");
            Console.WriteLine(" 3 - NOT FUNCTIONAL Select Campground / Make Reservation");
            Console.WriteLine(" 4 - NOT FUNCTIONAL Search available campground");
            Console.WriteLine(" 5 - Search for upcoming reservations\n");

            Console.WriteLine(" Q - Quit");
            Console.WriteLine();
        }
        private void ShowAllParksNamesOnly()
        {
            ParksSqlDAL dal = new ParksSqlDAL(DatabaseConnection);
            List<Parks> parks = dal.ShowAllParks();

            if (parks.Count > 0)
            {
                for (int i = 0; i < parks.Count(); i++)
                {
                    Console.Write($"#{i+1} - ");
                    Console.WriteLine($"{parks[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void GetUpcomingReservationMenu()
        {
            ParksSqlDAL dal = new ParksSqlDAL(DatabaseConnection);
            List<Parks> parks = dal.ShowAllParks();

            headers.PrintUpcomingReservationsHeader();
            Console.WriteLine();
            ShowAllParksNamesOnly();

            Console.Write($"\nPlease select a national park to check for upcoming reservations: ");
                string command = Console.ReadLine();
                int temp;
                Console.WriteLine();

                if (int.TryParse(command, out temp))
                {
                    selectedPark = int.Parse(command);

                for (int i = 0; i < parks.Count(); i++)
                {
                    if (selectedPark == parks[i].Id)
                    {
                        GetUpcomingReservations(selectedPark);
                        return;
                    }
                }
                Console.Clear();
                Console.WriteLine($"Invalid input. Please try again.\n");
                GetUpcomingReservationMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please try again.\n");
                GetUpcomingReservationMenu();
            }
        }
        private void GetUpcomingReservations(int selectedPark)
        {
            ReservationSqlDAL dal = new ReservationSqlDAL(DatabaseConnection);
            List<Reservation> res = dal.GetUpcomingReservations(selectedPark);

            if (res.Count > 0)
            {
                Console.Write($"ResID".PadRight(10));
                Console.Write($"SiteID".PadRight(10));
                Console.Write($"Name".PadRight(35));
                Console.Write($"Start Date".PadRight(15));
                Console.Write($"End Date".PadRight(15));
                Console.WriteLine($"Date Reservation Created\n");

                for (int i = 0; i < res.Count(); i++)
                {
                    Console.Write($"{res[i].Id.ToString().PadRight(10)}");
                    Console.Write($"{res[i].SiteId.ToString().PadRight(10)}");
                    Console.Write($"{res[i].Name.PadRight(35)}");
                    Console.Write($"{res[i].FromDate.ToShortDateString().PadRight(15)}");
                    Console.Write($"{res[i].ToDate.ToShortDateString().PadRight(15)}");
                    Console.WriteLine($"{res[i].CreateDate}");
                }

                Console.WriteLine($"\n\nPress any key to return to main menu.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                Console.WriteLine("**** NO UPCOMING RESERVATIONS ****");
                Console.WriteLine($"Press any key to return to main menu.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
        private void ShowAllCampgrounds()
        {
            headers.PrintMainMenuHeader();
            CampgroundSqlDAL dal = new CampgroundSqlDAL(DatabaseConnection);
            List<Campground> campgrounds = dal.ShowAllCampgrounds();

            Console.Write($"ID".PadRight(5));
            Console.Write("Name".PadRight(45));
            Console.Write("Start Month".PadRight(20));
            Console.Write("End Month".PadRight(20));
            Console.Write("Daily Fee\n\n");
            
            if (campgrounds.Count > 0)
            {
                campgrounds.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
            Console.WriteLine($"\n\nPress any key to return to main menu.");
            Console.ReadKey();
            Console.Clear();
        }

        ////////////////////
        // Menus //////
        ////////////// 
        private void PrintParksInterfaceMenu()
        {
            headers.PrintParkMenuHeader();
            Console.WriteLine();

            const string Command_Acadia = "1";
            const string Command_Arches = "2";
            const string Command_Cuyahoga_Valley = "3";
            const string Command_Quit = "q";

            Console.WriteLine(" 1 - Acadia");
            Console.WriteLine(" 2 - Arches");
            Console.WriteLine(" 3 - Cuyahoga Valley\n");
            Console.WriteLine(" Q - Return to Main Menu");

            Console.Write($"\nPlease make a selection: ");
            string command = Console.ReadLine();
            // selectedPark = int.Parse(command);


            if (int.TryParse(command, out selectedPark))
            {
                selectedPark = int.Parse(command);

                while (true)
                {
                    Console.Clear();

                    switch (command.ToLower())
                    {
                        case Command_Acadia:
                            ShowParkDescriptionInterface(int.Parse(command));
                            ParkCampgroundSelectionMenu();
                            return;

                        case Command_Arches:
                            ShowParkDescriptionInterface(int.Parse(command));
                            ParkCampgroundSelectionMenu();
                            return;

                        case Command_Cuyahoga_Valley:
                            ShowParkDescriptionInterface(int.Parse(command));
                            ParkCampgroundSelectionMenu();
                            return;

                        case Command_Quit:
                            RunCLI();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("The command provided was not a valid command, please try again.");
                            break;
                    }
                }
            }
            else if (command == "q")
            {
                Console.Clear();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please make a valid selection.");
                PrintParksInterfaceMenu();
            }
        }

        private void ParkCampgroundSelectionMenu()
        {
            const string Command_ShowAllCampgrounds = "1";
            const string Command_SearchForReservation = "2";
            const string Command_Previous_Screen = "3";
            Console.WriteLine(" 1 - View Campgrounds");
            Console.WriteLine(" 2 - Search for Park-wide Reservations");
            Console.WriteLine(" 3 - Return to Previous Screen");

            Console.Write($"\nPlease make a selection: ");
            string command = Console.ReadLine();


            if (int.TryParse(command, out selectedCampground))
            {
                selectedCampground = int.Parse(command);

                while (true)
                {
                    switch (command.ToLower())
                    {
                        case Command_ShowAllCampgrounds:
                            Console.WriteLine();
                            headers.PrintCampgroundHeader();
                            CampgroundSelectionMenu();
                            return;

                        case Command_SearchForReservation:
                            SearchForParkWideAvailability(selectedCampground);
                            MakeReservationGeneralMenu();
                            return;

                        case Command_Previous_Screen:
                            Console.Clear();
                            PrintParksInterfaceMenu();
                            return;
                        default:
                            Console.WriteLine("\nThe command provided was not a valid command, please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please make a valid selection.");
                ShowParkDescriptionInterface(selectedPark);
                ParkCampgroundSelectionMenu();
            }
        }
        private void ShowParkDescriptionInterface(int park_id)
        {
            headers.PrintParkInfoHeader();
            Console.WriteLine();

            ParksSqlDAL dal = new ParksSqlDAL(DatabaseConnection);
            List<Parks> parks = dal.ShowOnePark(park_id);

            for (int i = 0; i < parks.Count(); i++)
            {
                Console.WriteLine($"{parks[i].Name} National Park");
                Console.Write($"Location: ");
                Console.WriteLine($"{parks[i].Location}");
                Console.Write($"Established: ");
                Console.WriteLine($"{parks[i].EstablishmentDate.ToShortDateString()}");
                Console.Write($"Area: ");
                Console.WriteLine($"{parks[i].Area.ToString("##,#")} sq km");
                Console.Write($"Annual Visitors: ");
                Console.WriteLine($"{parks[i].Visitors.ToString("##,#")}\n");
                Console.Write($"Description: ");
                Console.WriteLine($"{parks[i].Description}\n\n");
            }
        }
        private void SearchForParkWideAvailability(int campground_id)
        {
            Console.Write("\nEnter the start date for your reservation (YYYY/MM/DD): ");
            DateTime fromDateString = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the end date for your reservation (YYYY/MM/DD): ");
            DateTime toDateString = DateTime.Parse(Console.ReadLine());

            SiteSqlDAL dal = new SiteSqlDAL(DatabaseConnection);
            List<Site> site = dal.SearchForAvailableSite(campground_id, fromDateString, toDateString);
            List<int> fee = dal.TotalFees;
            List<string> names = dal.CampNames;

            Site s = new Site();

            // Subtracts the dates to get a total days number. then multiples by daily_fee values

            System.TimeSpan diff1 = toDateString.Subtract(fromDateString);
            int daysStaying = int.Parse(diff1.Days.ToString());

            if (site.Count > 0)
            {
                Console.WriteLine();
                Console.Write("Campground".PadRight(15));
                Console.Write("Site No.".PadRight(15));
                Console.Write("Max Occup.".PadRight(15));
                Console.Write("Accessible?".PadRight(15));
                Console.Write("Max RV Length".PadRight(20));
                Console.Write("Utilities".PadRight(15));
                Console.WriteLine("Cost\n");

                for (int i = 0; i < site.Count(); i++)
                {
                    Console.Write($"{names[i].PadRight(15)}");
                    Console.Write($"{site[i].Id.ToString().PadRight(15)}");
                    Console.Write($"{site[i].MaxOccupancy.ToString().PadRight(15)}");

                    // Again this my attempt to change values as the program iterates through the for loop

                    int tempAccess = site[i].Accessible;
                    string acc = s.ChangeIntToYesOrNo(tempAccess);
                    Console.Write(acc.PadRight(15));

                    int tempMaxRV = site[i].MaxRvLength;
                    string rvl = s.ChangeToNA(tempMaxRV);
                    Console.Write(rvl.PadRight(20));

                    int tempUtil = site[i].Utilities;
                    string ut = s.ChangeIntToYesOrNo(tempUtil);
                    Console.Write(ut.PadRight(15));

                    Console.WriteLine($"{(daysStaying * fee[i]).ToString("C")}");
                }
            }
        }

        private void SearchForAvailableSite(int campground_id)
        {
            Console.Write("\nEnter the start date for your reservation (YYYY/MM/DD): ");
            DateTime fromDateString = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the end date for your reservation (YYYY/MM/DD): ");
            DateTime toDateString = DateTime.Parse(Console.ReadLine());

            SiteSqlDAL dal = new SiteSqlDAL(DatabaseConnection);
            List<Site> site = dal.SearchForAvailableSite(campground_id, fromDateString, toDateString);
            List<int> fee = dal.TotalFees;
            Site s = new Site();

            // Subtracts the dates to get a total days number. then multiples by daily_fee values

            System.TimeSpan diff1 = toDateString.Subtract(fromDateString);
            int daysStaying = int.Parse(diff1.Days.ToString());

            if (site.Count > 0)
            {
                Console.WriteLine();
                Console.Write("Site No.".PadRight(15));
                Console.Write("Max Occup.".PadRight(15));
                Console.Write("Accessible?".PadRight(15));
                Console.Write("Max RV Length".PadRight(20));
                Console.Write("Utilities".PadRight(15));
                Console.WriteLine("Cost\n");

                for (int i = 0; i < site.Count(); i++)
                {
                    Console.Write($"#");
                    Console.Write($"{site[i].Id.ToString().PadRight(14)}");
                    Console.Write($"{site[i].MaxOccupancy.ToString().PadRight(15)}");

                    // Again this my attempt to change values as the program iterates through the for loop

                    int tempAccess = site[i].Accessible;
                    string acc = s.ChangeIntToYesOrNo(tempAccess);
                    Console.Write(acc.PadRight(15));

                    int tempMaxRV = site[i].MaxRvLength;
                    string rvl = s.ChangeToNA(tempMaxRV);
                    Console.Write(rvl.PadRight(20));

                    int tempUtil = site[i].Utilities;
                    string ut = s.ChangeIntToYesOrNo(tempUtil);
                    Console.Write(ut.PadRight(15));

                    Console.WriteLine($"{(daysStaying * fee[i]).ToString("C")}");
                }
                Console.WriteLine();
                MakeReservationGeneralMenu();
            }
            else
            {
                Console.WriteLine("\nThere are no reservations available for the desired date range. Please try again.");
                SearchForAvailableSite(campground_id);
            }
            return;

        }

        //public void ShowAllCampgroundsInAPark(int park_id)
        //{
        //    CampgroundSqlDAL dal = new CampgroundSqlDAL(DatabaseConnection);
        //    List<Campground> campground = dal.ShowAllCampgroundsInAPark(park_id);

        //    if (campground.Count > 0)
        //    {
        //        Console.Write("Name".PadRight(15).PadLeft(30));
        //        Console.Write("Open".PadRight(15));
        //        Console.Write("Close".PadRight(15));
        //        Console.WriteLine("Daily Fee");

        //        for (int i = 1; i < campground.Count(); i++)
        //        {
        //            Console.Write($"#{i}".PadRight(15));
        //            Console.Write(campground[i].Name.PadRight(15));
        //            Console.Write(campground[i].OpenFromMM.ToString().PadRight(15));
        //            Console.Write(campground[i].OpenToMM.ToString().PadRight(15));
        //            Console.WriteLine(campground[i].DailyFee);
        //        }
        //        // sends user to reservation menu

        //        MakeReservationMenu();
        //    }
        //    else
        //    {
        //        Console.WriteLine("**** NO RESULTS ****");
        //    }


        //}
        public void CampgroundSelectionMenu()
        {
            CampgroundSqlDAL dal = new CampgroundSqlDAL(DatabaseConnection);
            List<Campground> campground = dal.ShowAllCampgroundsInAPark(selectedPark);
            Campground c = new Campground();

            if (campground.Count > 0)
            {
                Console.Write("Campground Id".PadRight(15));
                Console.Write("Name".PadRight(45));
                Console.Write("Start Month".PadRight(20));
                Console.Write("End Month".PadRight(20));
                Console.WriteLine("Daily Fee\n");
                
                for (int i = 0; i < campground.Count(); i++)
                {
                    // this is such a mess but I'm not sure else how to go about it
                    // this uses the GetMonth method (stored in Models/Campground) and changes ints to month names
                    Console.Write($"#{campground[i].Id}".PadRight(15));
                    Console.Write(campground[i].Name.PadRight(45));

                    int tempOpenFrom = campground[i].OpenFromMM;
                    string f = c.GetMonth(tempOpenFrom);
                    Console.Write(f.PadRight(20));

                    int tempOpenTo = campground[i].OpenToMM;
                    string t = c.GetMonth(tempOpenTo);
                    Console.Write(t.PadRight(20));

                    Console.WriteLine(campground[i].DailyFee.ToString("C"));
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }

            Console.Write($"\nPlease select a campground by campground id to view all sites and rates: ");
            string command = Console.ReadLine();
            int temp;

            if (int.TryParse(command, out temp))
            {
                selectedCampground = int.Parse(command);

                for (int i = 0; i < campground.Count(); i++)
                {
                    if (selectedCampground == campground[i].Id)
                    {
                        ShowAllSitesInACampground(selectedCampground);
                        MakeReservationMenu();
                        return;
                    }
                }
                Console.WriteLine($"Invalid input. Please select existing campground ID\n");
                CampgroundSelectionMenu();
            }
            else
            {
                Console.WriteLine($"Invalid input. Please select existing campground ID");
                CampgroundSelectionMenu();
            }
        }
        
        private void ShowAllSitesInACampground(int campground_id)
        {
            SiteSqlDAL dal = new SiteSqlDAL(DatabaseConnection);
            List<Site> site = dal.ShowAllSitesInACampground(campground_id);
            List<int> fee = dal.TotalFees;
            Site s = new Site();

            Console.WriteLine();
            headers.PrintAllCampgroundSitesHeader();

            if (site.Count > 0)
            {
                Console.Write("Site No.".PadRight(15));
                Console.Write("Max Occup.".PadRight(15));
                Console.Write("Accessible?".PadRight(15));
                Console.Write("Max RV Length".PadRight(20));
                Console.Write("Utilities".PadRight(15));
                Console.WriteLine("Cost\n");

                for (int i = 0; i < site.Count(); i++)
                {
                    Console.Write($"#");
                    Console.Write($"{site[i].Id.ToString().PadRight(14)}"); 
                    Console.Write($"{site[i].MaxOccupancy.ToString().PadRight(15)}");

                    // Again this my attempt to change values as the program iterates through the for loop

                    int tempAccess = site[i].Accessible;
                    string acc = s.ChangeIntToYesOrNo(tempAccess);
                    Console.Write(acc.PadRight(15));
          
                    int tempMaxRV = site[i].MaxRvLength;
                    string rvl = s.ChangeToNA(tempMaxRV);
                    Console.Write(rvl.PadRight(20));
       
                    int tempUtil = site[i].Utilities;
                    string ut = s.ChangeIntToYesOrNo(tempUtil);
                    Console.Write(ut.PadRight(15));

                    Console.WriteLine($"{fee[i].ToString("C")}");
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void MakeReservation()
        {
            Console.Write($"Please enter the site id for your reservation: ");
            int site_id = int.Parse(Console.ReadLine());
            Console.Write($"Please enter the name for your reservation: ");
            string resName = Console.ReadLine();
            Console.Write($"Please enter the start date (YYYY/MM/DD) for your reservation: ");
            DateTime from_date = DateTime.Parse(Console.ReadLine());
            Console.Write($"Please enter the end date (YYYY/MM/DD) for your reservation: ");
            DateTime to_date = DateTime.Parse(Console.ReadLine());

            ReservationSqlDAL dal = new ReservationSqlDAL(DatabaseConnection);
            Reservation reservation = new Reservation
            {
                SiteId = site_id,
                Name = resName,
                FromDate = from_date,
                ToDate = to_date
            };

            bool result = dal.MakeReservation(reservation);

            List<Reservation> lastReservation = dal.GetFullReservationInfo();

            if (result)
            {
                // reservations successfully added and you will be returned to the main menu after pressing any key
                Console.WriteLine($"\nSUCCESS! Your reservation has been saved as \"{lastReservation[0].Name}\" for the following dates:\n ");
                Console.WriteLine($"{lastReservation[0].FromDate.ToShortDateString().PadLeft(5)}");
                Console.WriteLine($"{lastReservation[0].ToDate.ToShortDateString().PadLeft(5)}");

                Console.WriteLine($"\nYour confirmation ID is {lastReservation[0].Id} \n");
                Console.WriteLine($"Press any key to return to main menu.\n");
                Console.ReadKey();
                Console.Clear();
                RunCLI();
            }
            else
            {
                Console.WriteLine($"****  Invalid request. Please try again.\n **** ");
                MakeReservation();
            }
        }
        private void MakeReservationMenu()
        {
            Console.WriteLine();

            const string Command_MakeReservation = "1";
            const string Command_Return_To_Park_Selection = "2";
            const string Command_Return_To_Main_Menu = "3";

            Console.WriteLine(" 1 - Search for Available Reservations");
            Console.WriteLine(" 2 - Return to Previous Screen");
            Console.WriteLine(" 3 - Return to Main Menu");
            Console.Write($"\nPlease make a selection: ");

            string command = Console.ReadLine();
            int temp;

            if (int.TryParse(command, out temp))
            {
                selectedCampground = int.Parse(command);

                while (true)
                {
                    switch (command.ToLower())
                    {
                        case Command_MakeReservation:
                            SearchForAvailableSite(selectedCampground);
                            return;

                        case Command_Return_To_Park_Selection:
                            Console.Clear();
                            ShowParkDescriptionInterface(selectedPark);
                            ParkCampgroundSelectionMenu();
                            break;

                        case Command_Return_To_Main_Menu:
                            Console.Clear();
                            RunCLI();
                            break;

                        default:
                            Console.WriteLine("\nThe command provided was not a valid command, please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Invalid input. Please select existing campground ID");
                MakeReservationMenu();
            }
        }
        private void MakeReservationGeneralMenu()
        {
            Console.WriteLine();

            const string Command_MakeReservation = "1";
            const string Command_Return_To_Park_Selection = "2";
            const string Command_Return_To_Main_Menu = "3";

            Console.WriteLine(" 1 - Make a Reservation");
            Console.WriteLine(" 2 - Return to Previous Screen");
            Console.WriteLine(" 3 - Return to Main Menu");
            Console.Write($"\nPlease make a selection: ");

            string command = Console.ReadLine();

            int temp;

            if (int.TryParse(command, out temp))
            {
                selectedCampground = int.Parse(command);

                while (true)
                {
                    switch (command.ToLower())
                    {
                        case Command_MakeReservation:
                            MakeReservation();
                            return;

                        case Command_Return_To_Park_Selection:
                            Console.Clear();
                            ShowParkDescriptionInterface(selectedPark);
                            ParkCampgroundSelectionMenu();
                            break;

                        case Command_Return_To_Main_Menu:
                            Console.Clear();
                            RunCLI();
                            break;

                        default:
                            Console.WriteLine("\nThe command provided was not a valid command, please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Invalid input. Please select existing campground ID");
                MakeReservationGeneralMenu();
            }
        }
    }
}
