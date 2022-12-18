using System;
using System.Collections.Generic;
using System.Text;
using ConverterLib1._1;

namespace Converter2
{
    class Commands
    {
        public void Dialog()
        {
            while (true)
            {
                string commandString = Console.ReadLine();
                CommandParse(commandString);

                switch (_command)
                {
                    case "info":
                        Info();
                        break;

                    case "command":
                        Command();
                        break;


                    default:
                        Console.WriteLine(_converter.GetConvertedValue(_command, Convert.ToDouble(args[0]), args[1], args[2]));
                        break;
                }
            }
        }
        void Info()
        {
            foreach (string value in _converter.GetPhysicValuesList())
            {
                Console.WriteLine(value + "");
                foreach (string measure in _converter.GetMeasureList(value))
                {
                    Console.WriteLine("\t" + measure);
                }
            }
        }



        public void Command()
        {
            foreach (string value in _converter.GetPhysicValuesList())
            {
                Console.WriteLine(value + "");
                foreach (string measure in _converter.GetMeasureList(value))
                {
                    Console.WriteLine("\t" + measure);
                }
            }
        }



        string _command = "";
        string[] args = new string[3];
        Converter _converter = new Converter();

        void CommandParse(string commandString)
        {
            string[] str = commandString.Split(' ');
            _command = str[0];
            if (str.Length > 1)
            {
                args[0] = str[1];
                args[1] = str[2];
                args[2] = str[3];
            }
        }
        List<string> _commands = new List<string>()
        {
            "info",
            "clear",
            "help",
            "exit",
            "command",
        };
    }
}
