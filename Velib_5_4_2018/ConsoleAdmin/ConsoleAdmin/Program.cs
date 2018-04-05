using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdmin
{
    class Program
    {

        private static AdminService.AdminClient client = new AdminService.AdminClient();

        static void Main(string[] args)
        {
            bool stop = false;

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
                    case "general":
                        ExecGeneral();
                        break;
                    case "details":
                        ExecDetails();
                        break;
                    default:
                        ExecHelp();
                        break;
                }
            }
        }

        private static void ExecDetails()
        {
            Console.WriteLine("Enter the name of the user you want to see the datas");
            String input = Console.ReadLine();

            Console.WriteLine(client.GetDetailsUser(input));
        }

        private static void ExecGeneral()
        {
            Console.WriteLine(client.GetGeneralMonitoring());
        }

        private static void ExecHelp()
        {
            Console.WriteLine("Available commands are : \n" +
            "help\n" +
            "general\n" +
            "details\n" +
            "exit\n");
        }
    }
}
