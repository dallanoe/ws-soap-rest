using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOAP
{
    class Program
    {

        private static Stations.VelibClient client = new Stations.VelibClient();

        public static void Main()
        {
            bool stop = false;
            String login;

            Console.WriteLine("Enter your login.");
            login = Console.ReadLine();

            while (!stop)
            {
                Console.WriteLine("Enter the wanted command. Type \"help\" for help.");

                String cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "help":
                        ExecHelp();
                        break;
                    case "exit":
                        stop = true;
                        break;
                    case "settings":
                        ExecSettings(login);
                        break;
                    case "details":
                        ExecDetails(login);
                        break;
                    case "stations":
                        ExecStations(login);
                        break;
                    default:
                        ExecHelp();
                        break;
                }
            }
        }

        private static void ExecSettings(string login)
        {
            Console.WriteLine("Enter the wanted unit for your cache (h, m or s)");
            String unit = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the wanted time for your cache");
            int time = Int32.Parse(Console.ReadLine());

            client.ChangeCacheSettingsSlide(time, unit, login);
        }

        private static void ExecStations(string login)
        {
            int current = 1;

            Console.WriteLine("Enter the wanted city");
            String input = Console.ReadLine();

            Stations.Station[] res = client.GetStationsByCity(input, login);

            if (res.Length <= 1)
            {
                Console.WriteLine("Wrong city input or no stations available :(");
            }
            else
            {
                Console.WriteLine("List of all available stations");

                foreach (Stations.Station obj in res)
                {
                    Console.WriteLine(current++ + " - " + res[current - 2].Name);
                }
            }
        }

        private static void ExecDetails(string login)
        {
            Console.WriteLine("Enter contract name");
            String input = Console.ReadLine();
            Console.WriteLine("Enter station name");
            String station = Console.ReadLine();

            Console.WriteLine(client.GetStationDetails(input, station, login));
        }

        private static void ExecHelp()
        {
            Console.WriteLine("Available commands are : \n" +
            "help\n" +
            "stations\n" +
            "details\n" +
            "settings\n" +
            "exit\n");
        }
    }
}
