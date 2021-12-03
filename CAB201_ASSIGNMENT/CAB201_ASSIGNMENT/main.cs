using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search16s
{
    /// <summary>
    ///
    /// //command line input based program which provides the option of 3 levels with unique outputs based on
    /// user input.
    /// 
    /// All three levels preform different actions relating to searching and outputting a fasta file 
    /// 
    ///Program will tell user when invalid inputs are given and close. 
    /// 
    ///Author James Norman september 2019
    ///
    /// </summary>

    class main
    {
        /// <summary>
        ///The class main contains the main function to run the other functions made in this code.
        /// </summary>

        static void Main(string[] args)
        {
            /// <summary>
            /// The main function contains all the input arguments and dishes them out to the specific functions when called 
            /// the main also checks what function is called using the 2nd input to match the level
            /// The main also checks that the correct number of arguments is provided through an exception and gives out the error when wrong
            /// </summary>
            /// <param name="args[]">This array contains all of the user input arguments</param>
            /// <returns>The main returns void</returns>

            try
            {
                Checks.CheckProgram(args[1]);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Please enter a valid filename");
                Environment.Exit(0);
            }

            int length = args.Length;

            if (args[0] == "-level1")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }


            }

            else if (args[0] == "-level2")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }
            }

            else if (args[0] == "-level3")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }

            }

            else if (args[0] == "-level4")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }

            }

            else if (args[0] == "-level5")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }

            }

            else if (args[0] == "-level6")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }

            }

            else if (args[0] == "-level7")
            {
                try
                {
                    Checks.CheckArgs(args);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }

            }


            else
            {

                Console.WriteLine("please enter a valid level");
                Console.ReadLine();
            }
        }
    }
}
