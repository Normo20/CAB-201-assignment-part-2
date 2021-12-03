using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Search16s
{
    class Levels
    {

        /// <summary>
        ///The class levels contains all of the functions relating to levels 1-3 and runs them through main.
        /// </summary>

        public static void Level1(string file, string lineNum, string sequence)
        {

            /// <summary>
            /// This function "Level1" takes three user inputs The file, The line number and the number of sequences wanted
            /// It then goes and finds the desired line number and produces the number of sequences wanted and outputs to the console
            /// providing relevant error messages when invalid input numbers are given
            ///
            /// </summary>
            /// <param name="file">This parameter is the 3rd user input which provides the name of the file to be read</param>
            /// <param name="lineNum">This parameter is the 4th user input which provides the line number which wants to be displayed</param>
            /// <param name="sequence">This parameter is the 5th user input which provides the number of sequences that want to be displayed</param>
            /// <returns>This function returns void</returns>

            string[] inputLines = File.ReadAllLines(file);
            int length = inputLines.Length;
            int lineNum1;

            if (int.TryParse(lineNum, out lineNum1))
            {

            }

            else
            {
                Console.WriteLine("Please enter an integer value for line number");
                Environment.Exit(0);

            }

            int sequence1;

            if (int.TryParse(sequence, out sequence1))
            {

            }

            else
            {
                Console.WriteLine("Please enter an integer value for seuqence length");
                Environment.Exit(0);

            }

            if (lineNum1 <= 0 || lineNum1 > length)
            {
                Console.WriteLine("Please Enter a line number greater then 0 and less then the total length of the file");
                Environment.Exit(0);


            }

            if ((lineNum1 + (sequence1 * 2)) > length)
            {
                Console.WriteLine("Please enter a number of outputs that does not exceed file length");
                Environment.Exit(0);
            }

            if (lineNum1 % 2 == 0)
            {
                Console.WriteLine("You must enter an odd number");

            }

            else if (sequence1 < 0)
            {
                Console.WriteLine("Please enter a positive sequence number");


            }

            else
            {
                for (int i = 0; i < sequence1 * 2; i++, i++)

                    Console.WriteLine("{0}\n{1})", inputLines[i + lineNum1 - 1], inputLines[i + lineNum1]);

            }


        }


        public static void Level2(string file1, string id)
        {

            /// <summary>
            /// This function "level2" takes 2 user inputs file 1 and id and then proceeds to find the id in the file
            /// and print the id and it's matching sequence out to the console.
            /// This program provides relevant error messages when invalid input id is given.
            /// </summary>
            /// <param name="file1">This parameter is the 3rd user input which provides the name of the file to be read</param>
            /// <param name="id">This parameter is the 4th user input which provides the sequence id that is wanted to be found and output</param>
            /// <returns>This program returns void</returns>

            int counter = 0;
            string line;
            int length = file1.Length;
            string[] inputLines = File.ReadAllLines(file1);
            string result = string.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(file1);

            //This method iterates through the file incrementing a line counter until the line matches the input id
            //Then it prints the line contianing the id and the line below it containing the sequence.
            // The loop also stores the result of the search in the variabe result so it can tell if result has been found.

            while ((line = file.ReadLine()) != null)
            {

                if (line.Contains(id))
                {
                    line = null;
                    var text = line;
                    result = text;

                    Console.WriteLine("{0}\n{1})", inputLines[counter], inputLines[counter + 1]);
                }

                else
                    counter++;
            }

            if (result == (""))
            {
                Console.WriteLine("Error sequence {0} not found", id);

            }

            // Closes the file and Suspends the screen.  

            file.Close();
            System.Console.ReadLine();

        }


        public static void Level3(string inputFile, string queryFile, string resultFile)
        {

            /// <summary>
            /// This function level 3 takes 3 user inputs a filename, a querfyile and the name for an ouput file
            /// it then reads the query file for sequence id's and finds them in the inputfile
            ///proceeding to create an output file and print to it the designated id's and sequences 
            /// providing relevant error messages to the console when id's aren't found
            /// </summary>
            /// <param name="inputFile">This parameter is the 3rd user input which provides the name of the file to be read</param>
            /// <param name="queryFile">This parameter is the 4th user input which provides the name of the query file to be read</param>
            /// <param name="resultFile">This parameter is the 5th user input which provides the name of the file to be created</param>
            /// <returns>This function returns void </returns>

            if (File.Exists(queryFile))
            {

            }

            else
            {
                Console.WriteLine("Please enter a valid file name");
                Environment.Exit(0);
            }

            var lineCount = File.ReadLines(queryFile).Count();

            for (int i = 0; i < lineCount; i++)
            {
                string[] inputLines = File.ReadAllLines(inputFile);
                string[] queryLines = File.ReadAllLines(queryFile);
                string query1 = queryLines[i];
                string result1 = string.Empty;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string line;
                string result = string.Empty;
                int counter = 0;
                System.IO.StreamReader file =
               new System.IO.StreamReader(inputFile);

                while ((line = file.ReadLine()) != null)
                {

                    if (line.Contains(query1))
                    {
                        line = null;
                        var text = line;
                        result = text;

                        //This function creates the output file in the users documents.
                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, resultFile), true))
                        {
                            outputFile.WriteLine("{0}\n{1}", inputLines[counter], inputLines[counter + 1]);
                        }

                    }

                    else
                        counter++;

                }

                if (result == (""))
                {
                    Console.WriteLine("Error sequence {0} not found", query1);
                }


            }

        }


        public static void Level4(string inputFile, string indexFile, string queryFile, string resultFile)
        {
            /// <summary>
            /// This function level 4 takes 4 user inputs a filename, a indexfile name, a querfyile and the name for an ouput file
            /// it then reads the query file for sequence id's and finds the index, then to create an output file
            /// and print the queries to it with the designated id's and sequences, using the input file 
            /// providing relevant error messages to the console when id's aren't found
            /// </summary>
            /// <param name="inputFile">This parameter is the 2nd user input which provides the name of the file to be read</param>
            /// /// <param name="indexFile">This parameter is the 3rd user input which provides the name of the index file to be read</param>
            /// <param name="queryFile">This parameter is the 4th user input which provides the name of the query file to be read</param>
            /// <param name="resultFile">This parameter is the 5th user input which provides the name of the file to be created</param>
            /// <returns>This function returns void </returns>

            if (File.Exists(queryFile))
            {

            }

            else
            {
                Console.WriteLine("Please enter a valid query file name");
                Environment.Exit(0);
            }

            if (File.Exists(indexFile))
            {

            }

            else
            {
                Console.WriteLine("Please enter a valid index file name");
                Environment.Exit(0);
            }

           

            if (File.Exists(Path.Combine(resultFile)))
            {
                File.Delete(Path.Combine(resultFile));
            }

            var lineCount = File.ReadLines(queryFile).Count();

            for (int i = 0; i < lineCount; i++)
            {
                
                string[] queryLines = File.ReadAllLines(queryFile);
                string[] indexedLines = File.ReadAllLines(indexFile);
                string query1 = queryLines[i];
                string result1 = string.Empty;
                string line;
                string result = string.Empty;
                int counter = 0;
                System.IO.FileStream file =
               new System.IO.FileStream(inputFile, FileMode.Open, FileAccess.Read);

                System.IO.StreamReader file1 =
               new System.IO.StreamReader(indexFile);

                while ((line = file1.ReadLine()) != null)
                {

                    if (line.Contains(query1))
                    {
                        result1 = String.Concat(indexedLines[counter]);
                        string[] words = result1.Split(' ');


                        if (int.TryParse(words[1], out int byteOffset))
                        {

                        }

                        else
                        {
                            Console.WriteLine("Byte offset is not valid ");
                            Environment.Exit(0);

                        }

                        file.Seek(byteOffset, SeekOrigin.Begin);
                        //This function creates the output file in the users documents.
                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultFile), true)) 
                        {
                            int n_counter = 0;
                            while (n_counter < 2)
                            {

                                char c = (char)file.ReadByte();

                                if (c == '\n')
                                {
                                    n_counter++;
                                    outputFile.Write("\r\n");
                                }
                                else
                                {
                                    outputFile.Write(c);
                                }


                            }
                        }



                    }

                    else
                        counter++;

                }


                if (result1 == (""))
                {
                    Console.WriteLine("Error sequence {0} not found", query1);
                }


            }

        }

        public static void Level5(string inputFile, string sequence)
        {

            /// <summary>
            /// This function level 5 takes 2 user inputs a filename, a dna sequence
            /// it then reads the input file for the specified sequence and finds them in the inputfile
            ///proceeding to output the sequence id's that they were found in and print to it the designated id's to the console 
            /// providing relevant error messages to the console when sequences aren't found
            /// </summary>
            /// <param name="inputFile">This parameter is the 2nd user input which provides the name of the file to be read from</param>
            /// <param name="sequence">This parameter is the 3rd user input which provides the name sequence wanting to be read</param>
            /// <returns>This function returns void </returns>

            string line;
            string counterLine;
            bool found = false;
            System.IO.StreamReader file =
                new System.IO.StreamReader(inputFile);

            //This method iterates through the file incrementing a line counter until the line matches the input id
            //Then it prints the line contianing the id and the line below it containing the sequence.
            // The loop also stores the result of the search in the variabe result so it can tell if result has been found.
            while ((line = file.ReadLine()) != null)
            {
                counterLine = file.ReadLine();

                if (counterLine.Contains(sequence))
                {


                    string[] words = line.Split(' ');
                    Console.WriteLine($"{ words[0].Replace(">", "")}");
                    found = true;

                }

            }

            if (found == false)
            {
                Console.WriteLine("Error sequence {0} not found", sequence);

            }

            // Closes the file and Suspends the screen.  
            file.Close();
            System.Console.ReadLine();

        }


        public static void Level6(string inputFile, string sequence)
        {
            /// <summary>
            /// This function level 6 takes 2 user inputs a filename and a specific word
            /// it then reads the input file for that word and finds them in the inputfile
            ///proceeding to output sequence id that contain that word 
            /// providing relevant error messages to the console when word isn't found
            /// </summary>
            /// <param name="sequence">This parameter is the 2nd user input which provides the name of the file to be read</param>
            /// <param name="inputFile">This parameter is the 3rd user input which specifies which word to search for</param>
            /// <returns>This function returns void </returns>
            /// 
            string line;

            bool found = false;
            System.IO.StreamReader file =
                new System.IO.StreamReader(inputFile);

            //This method iterates through the file incrementing a line counter until the line matches the input id
            //Then it prints the line contianing the id and the line below it containing the sequence.
            // The loop also stores the result of the search in the variabe result so it can tell if result has been found.
            while ((line = file.ReadLine()) != null)
            {


                if (line.Contains(sequence))
                {


                    string[] words = line.Split(' ');
                    Console.WriteLine($"{ words[0].Replace(">", "")}");
                    found = true;

                }

            }

            if (found == false)
            {
                Console.WriteLine("Error sequence {0} not found", sequence);

            }

            // Closes the file and Suspends the screen.  
            file.Close();
            System.Console.ReadLine();



        }

        public static void level7(string inputFile, string sequence)
        {
            bool sequenceFound = false;
            string line;
            string sequence2 = sequence.Replace("*", "[ACTG]*");

            using (StreamReader file = new StreamReader(inputFile))
            {
                while((line = file.ReadLine())!=null)
                {
                    var matching = Regex.Match(line, sequence2);

                    if(matching.Success)
                    {
                        Console.WriteLine(matching.Value);
                        sequenceFound = true;
                    }


                }

            }
            if (sequenceFound==false)
            {
                Console.WriteLine("Error no sequences contain{0} were found", sequence);

            }


        }


    }

}



