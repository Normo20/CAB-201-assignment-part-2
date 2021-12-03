using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Search16s
{
    class Checks
    {
        /// <summary>
        ///The class checks contains the functions that throws an exception to check whether a specific file exists or not and runs through main.
        ///This class also contains a function that checks and throws an exception when the wrong number of arguments is provided
        /// </summary>

        public static void CheckProgram(string file)
        {
            /// <summary>
            /// This function checks that the file name is valid and exists, if not it asks for a valid file and closes the terminal
            /// </summary>
            /// <param name="file">file is the 3rd user input of the program which should be the file name and type </param>
            /// <returns>This program returns void</returns>

            if (File.Exists(file))
            {

            }

            else
            {
                throw new FileNotFoundException();

            }


        }

        public static void CheckArgs(string[] Args)
        {
            /// <summary>
            /// This function checks that the correct number of arguments is provided and throws an exception and an error message when they aren't
            /// </summary>
            /// <param name="Args">Args contains all of the users input arguments </param>
            /// <returns>This program returns void</returns>

            int length = Args.Length;

            if (Args[0] == "-level1")
            {
                if (length > 4)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }

                else if (length < 4)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                else
                    Levels.Level1(Args[1], Args[2], Args[3]);

            }

            else if (Args[0] == "-level2")
            {
                if (length > 3)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }
                else if (length < 3)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                else


                    Levels.Level2(Args[1], Args[2]);


            }

            else if (Args[0] == "-level3")
            {

                if (length > 4)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }

                else if (length < 4)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                else

                    Levels.Level3(Args[1], Args[2], Args[3]);


            }

            else if (Args[0] == "-level4")
            {
                if (length > 5)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }
                else if (length < 5)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                Levels.Level4(Args[1], Args[2], Args[3], Args[4]);



            }

            else if (Args[0] == "-level5")
            {
                if (length > 3)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }
                else if (length < 3)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                Levels.Level5(Args[1], Args[2]);



            }

            else if (Args[0] == "-level6")
            {
                if (length > 3)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }
                else if (length < 3)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                Levels.Level6(Args[1], Args[2]);
            }


            else if (Args[0] == "-level7")
            {
                if (length > 3)
                {
                    Console.WriteLine("Please enter less arguments");
                    throw new ArgumentOutOfRangeException();
                }
                else if (length < 3)
                {
                    Console.WriteLine("Please enter more arguments");
                    throw new ArgumentOutOfRangeException();
                }

                Levels.level7(Args[1], Args[2]);
            }


        }

    }
}
