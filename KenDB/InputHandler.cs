using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenDB
{
    internal class InputHandler
    {
        private DatabaseManager databaseManager;
        public InputHandler()
        {
            databaseManager = new DatabaseManager();
        }

        internal void parseInput(string input)
        {
            switch (input)
            {
                case "create":
                    databaseManager.create("123");
                    break;
                case "load":
                    databaseManager.load("123"); 
                    break;
                case "query":
                    parseQuery("123");
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        internal void parseQuery(string query)
        {
            Console.WriteLine("parsing...");
        }
    }
}
