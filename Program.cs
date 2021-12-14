using System;
using System.IO;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  declaring variables
            double score;
            double total = 0;
            double minimumScore = 100;
            double maximumScore = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int count8 = 0;
            int count9 = 0;
            int count10 = 0;
            int count11 = 0;
            int count12 = 0;
            int finalCount = 0;
            double average = 0;

            //testing if file is valid
            try
            {
                //reading data from text file
                StreamReader inputFile;
                inputFile = File.OpenText("Exam_scores.txt");

                //while loop that runs until data has ended
                while (!inputFile.EndOfStream)
                {
                    //read and validate data from file
                    if (double.TryParse(inputFile.ReadLine(), out score))
                    {
                        //number of students for each grade being calculated
                        if (score >= 94)
                        {
                            count1++;
                        }
                        else if (score >= 90 || score >= 93.9)
                        {
                            count2++;
                        }
                        else if (score >= 87 || score >= 89.9)
                        {
                            count3++;
                        }
                        else if (score >= 83 || score >= 86.9)
                        {
                            count4++;
                        }
                        else if (score >= 80 || score >= 82.9)
                        {
                            count5++;
                        }
                        else if (score >= 77 || score >= 79.9)
                        {
                            count6++;
                        }
                        else if (score >= 73 || score >= 76.9)
                        {
                            count7++;
                        }
                        else if (score >= 70 || score >= 72.9)
                        {
                            count8++;
                        }
                        else if (score >= 67 || score >= 69.9)
                        {
                            count9++;
                        }
                        else if (score >= 63 || score >= 66.9)
                        {
                            count10++;
                        }
                        else if (score >= 60 || score >= 62.9)
                        {
                            count11++;
                        }
                        else if (score < 60)
                        {
                            count12++;
                        }

                        //calculate total
                        total = total + score;

                        //minimum score
                        if (minimumScore > score)
                        {
                            minimumScore = score;
                        }

                        //maximum score
                        if (maximumScore < score)
                        {
                            maximumScore = score;
                        }

                        //calculating class average

                        finalCount = count1 + count2 + count3 + count4 + count5 + count6 + count7 + count8 + count9 + count10 + count11 + count12;
                        average = total / finalCount;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
                // displays how many students were scoring for each letter grade

                Console.WriteLine(count1 + " Students got an A");
                Console.WriteLine(count2 + " Students got an A-");
                Console.WriteLine(count3 + " Students got a B+");
                Console.WriteLine(count4 + " Students got a B");
                Console.WriteLine(count5 + " Students got a B-");
                Console.WriteLine(count6 + " Students got a C+");
                Console.WriteLine(count7 + " Students got a C");
                Console.WriteLine(count8 + " Students got a C-");
                Console.WriteLine(count9 + " Students got a D+");
                Console.WriteLine(count10 + " Students got a D");
                Console.WriteLine(count11 + " Students got a D-");
                Console.WriteLine(count12 + " Students got a F");
                Console.WriteLine("");
                Console.WriteLine("total = " + total);
                Console.WriteLine("");
                Console.WriteLine("Minimum score = " + minimumScore);
                Console.WriteLine("");
                Console.WriteLine("Maximum score = " + maximumScore);
                Console.WriteLine("");
                Console.WriteLine("Class average = " + average);
            }
            catch
            {
                Console.WriteLine("File doesn't exist");
            }

        }
    }
}
