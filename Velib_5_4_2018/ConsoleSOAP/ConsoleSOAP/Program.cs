using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOAP
{
    class Program
    {

        private static Stations.VelibClient client;

        public static void Main()
        {
            bool stop = false;
            String login;

            VelibCallback callback = new VelibCallback();
            InstanceContext context = new InstanceContext(callback);

            client = new Stations.VelibClient(context);


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
                    case "sub":
                        ExecSubscribe(login);
                        break;
                    case "unsub":
                        ExecUnsubscribe(login);
                        break;
                    default:
                        ExecHelp();
                        break;
                }
            }
        }

        private static void ExecSubscribe(string login)
        {
            Console.WriteLine("Enter contract name you want to subscribe");
            String input = Console.ReadLine();
            Console.WriteLine("Enter station name you want to subscribe");
            String station = Console.ReadLine();

            client.SubscribeDetails(input, station, login);
        }

        private static void ExecUnsubscribe(string login)
        {
            Console.WriteLine("Enter contract name you want to unsubscribe");
            String input = Console.ReadLine();
            Console.WriteLine("Enter station name you want to unsubscribe");
            String station = Console.ReadLine();

            client.UnsubscribeDetails(input, station, login);
        }

        private static void ExecSettings(string login)
        {
            Console.WriteLine("Enter the settings you want to change (cache or sub)");
            String wanted = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the wanted unit for your settings (h, m or s)");
            String unit = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the wanted time for your settings");
            int time = Int32.Parse(Console.ReadLine());

            switch (wanted)
            {
                case "cache":
                    client.ChangeCacheSettingsSlide(time, unit, login);
                    break;
                case "sub":
                    client.ChangeSubscribeSettings(time, unit, login);
                    break;
                default:
                    Console.WriteLine("Couldn't find the wanted settings");
                    break;
            }

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
            "sub\n" +
            "unsub\n" +
            "settings\n" +
            "exit\n");
        }
    }
}
