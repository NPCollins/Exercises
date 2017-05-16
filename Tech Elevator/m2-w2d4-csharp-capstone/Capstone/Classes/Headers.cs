using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Headers
    {
        public void PrintMainMenuHeader()
        {
            Console.WriteLine();
            Console.WriteLine(@"  ███╗   ██╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗ █████╗ ██╗         ██████╗  █████╗ ██████╗ ██╗  ██╗");
            Console.WriteLine(@"  ████╗  ██║██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║██╔══██╗██║         ██╔══██╗██╔══██╗██╔══██╗██║ ██╔╝");
            Console.WriteLine(@"  ██╔██╗ ██║███████║   ██║   ██║██║   ██║██╔██╗ ██║███████║██║         ██████╔╝███████║██████╔╝█████╔╝ ");
            Console.WriteLine(@"  ██║╚██╗██║██╔══██║   ██║   ██║██║   ██║██║╚██╗██║██╔══██║██║         ██╔═══╝ ██╔══██║██╔══██╗██╔═██╗ ");
            Console.WriteLine(@"  ██║ ╚████║██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║██║  ██║███████╗    ██║     ██║  ██║██║  ██║██║  ██╗");
            Console.WriteLine(@"  ╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝");
            Console.WriteLine(@"             ╔═╗┌─┐┌┬┐┌─┐┌─┐┬┌┬┐┌─┐  ╦═╗┌─┐┌─┐┌─┐┬─┐┬  ┬┌─┐┌┬┐┬┌─┐┌┐┌  ╔═╗┬ ┬┌─┐┌┬┐┌─┐┌┬┐");
            Console.WriteLine(@"             ║  ├─┤│││├─┘└─┐│ │ ├┤   ╠╦╝├┤ └─┐├┤ ├┬┘└┐┌┘├─┤ │ ││ ││││  ╚═╗└┬┘└─┐ │ ├┤ │││");
            Console.WriteLine(@"             ╚═╝┴ ┴┴ ┴┴  └─┘┴ ┴ └─┘  ╩╚═└─┘└─┘└─┘┴└─ └┘ ┴ ┴ ┴ ┴└─┘┘└┘  ╚═╝ ┴ └─┘ ┴ └─┘┴ ┴");
            // ASCII Credit: http://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Park%20Selection

            Console.WriteLine();
        }
        public void PrintParkMenuHeader()
        {
            Console.WriteLine(@" ╔═╗┌─┐┬─┐┬┌─  ╔═╗┌─┐┬  ┌─┐┌─┐┌┬┐┬┌─┐┌┐┌");
            Console.WriteLine(@" ╠═╝├─┤├┬┘├┴┐  ╚═╗├┤ │  ├┤ │   │ ││ ││││");
            Console.WriteLine(@" ╩  ┴ ┴┴└─┴ ┴  ╚═╝└─┘┴─┘└─┘└─┘ ┴ ┴└─┘┘└┘");
        }
        public void PrintParkInfoHeader()
        {
            Console.WriteLine(@" ╔═╗┌─┐┬─┐┬┌─  ╦┌┐┌┌─┐┌─┐┬─┐┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌  ╔═╗┌─┐┬─┐┌─┐┌─┐┌┐┌");
            Console.WriteLine(@" ╠═╝├─┤├┬┘├┴┐  ║│││├┤ │ │├┬┘│││├─┤ │ ││ ││││  ╚═╗│  ├┬┘├┤ ├┤ │││");
            Console.WriteLine(@" ╩  ┴ ┴┴└─┴ ┴  ╩┘└┘└  └─┘┴└─┴ ┴┴ ┴ ┴ ┴└─┘┘└┘  ╚═╝└─┘┴└─└─┘└─┘┘└┘");
        }
        public void PrintMakeReservationHeader()
        {
            Console.WriteLine(@" ╔╦╗┌─┐┬┌─┌─┐  ╦═╗┌─┐┌─┐┌─┐┬─┐┬  ┬┌─┐┌┬┐┬┌─┐┌┐┌");
            Console.WriteLine(@" ║║║├─┤├┴┐├┤   ╠╦╝├┤ └─┐├┤ ├┬┘└┐┌┘├─┤ │ ││ ││││");
            Console.WriteLine(@" ╩ ╩┴ ┴┴ ┴└─┘  ╩╚═└─┘└─┘└─┘┴└─ └┘ ┴ ┴ ┴ ┴└─┘┘└┘");
        }
        public void PrintCampgroundHeader()
        {
            Console.WriteLine(@" ╔═╗┌─┐┌┬┐┌─┐┌─┐┬─┐┌─┐┬ ┬┌┐┌┌┬┐┌─┐");
            Console.WriteLine(@" ║  ├─┤│││├─┘│ ┬├┬┘│ ││ ││││ ││└─┐");
            Console.WriteLine(@" ╚═╝┴ ┴┴ ┴┴  └─┘┴└─└─┘└─┘┘└┘─┴┘└─┘");
        }

        public void PrintUpcomingReservationsHeader()
        {
            Console.WriteLine(@" ╦ ╦┌─┐┌─┐┌─┐┌┬┐┬┌┐┌┌─┐  ╦═╗┌─┐┌─┐┌─┐┬─┐┬  ┬┌─┐┌┬┐┬┌─┐┌┐┌┌─┐");
            Console.WriteLine(@" ║ ║├─┘│  │ │││││││││ ┬  ╠╦╝├┤ └─┐├┤ ├┬┘└┐┌┘├─┤ │ ││ ││││└─┐");
            Console.WriteLine(@" ╚═╝┴  └─┘└─┘┴ ┴┴┘└┘└─┘  ╩╚═└─┘└─┘└─┘┴└─ └┘ ┴ ┴ ┴ ┴└─┘┘└┘└─┘");
        }

        public void PrintAvailableSitesHeader()
        {
            Console.WriteLine(@" ╔═╗┬  ┬┌─┐┬┬  ┌─┐┌┐ ┬  ┌─┐  ╔═╗┬┌┬┐┌─┐┌─┐");
            Console.WriteLine(@" ╠═╣└┐┌┘├─┤││  ├─┤├┴┐│  ├┤   ╚═╗│ │ ├┤ └─┐");
            Console.WriteLine(@" ╩ ╩ └┘ ┴ ┴┴┴─┘┴ ┴└─┘┴─┘└─┘  ╚═╝┴ ┴ └─┘└─┘");
        }

        public void PrintAllCampgroundSitesHeader()
        {
            Console.WriteLine(@" ╔═╗┬  ┬    ╔═╗┌─┐┌┬┐┌─┐┌─┐┬─┐┌─┐┬ ┬┌┐┌┌┬┐  ╔═╗┬┌┬┐┌─┐┌─┐");
            Console.WriteLine(@" ╠═╣│  │    ║  ├─┤│││├─┘│ ┬├┬┘│ ││ ││││ ││  ╚═╗│ │ ├┤ └─┐");
            Console.WriteLine(@" ╩ ╩┴─┘┴─┘  ╚═╝┴ ┴┴ ┴┴  └─┘┴└─└─┘└─┘┘└┘─┴┘  ╚═╝┴ ┴ └─┘└─┘");
        }
    }
}
