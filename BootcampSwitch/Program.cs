
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampSwitch
{
    class Program
    {
        private static BooleanSwitch boolSwitch = new BooleanSwitch("SpellCheckSwitch","Switch in configuration file");
        static void Main(string[] args)
        {
            //try
            {
                Console.WriteLine("Boolean switch {0} configured as {1}",
                    boolSwitch.DisplayName, boolSwitch.Enabled.ToString());
            }
            //catch (System.Configuration.ConfigurationException ex)
            //{
            //    Console.WriteLine("Error openeing App.config.  Please close it.");
            //}
            //catch
            //{
            //    Console.WriteLine("All other Errors!");
            //}

            Console.ReadKey();
        }
    }
}
