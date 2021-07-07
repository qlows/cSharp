using System;
using static System.Console;

namespace COMP1202_S20_Assg1_101232721
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string quizQuestions(int i)
            {
                string[] questions =
                {
                    "Q1 - Who is the Divine Comedy's author??",
                    "Q2 - What is the foundation of Lighhouse of Alexandria?",
                    "Q3 - Where is Sistine Chapel ceiling located at?",
                    "Q4 - Who is the architect of Guggenheim Museum in Spain, Bilbao?",
                    "Q5 - Who is the painter of The Storm on the Sea of Galilee?"
                };
                return questions[i]; // write questions
                {
                    string quizAnswers(int i)
                    {
                        string[] answers =
                        {
                            "a)Dante Alighieri b)Giovanni Boccaccio c)Beatrice Portinari d)Francesco Petrarca",
                            "a)Marble b)Stone c)Wood d)Concrete",
                            "a)Italy b)France c)Vatican City d)Morocco",
                            "a)Frank L. Wright b)Frank Gehry c)Philip Johnson d)Zaha Hadid",
                            "a)Caravaggio b)Peter Paul Rubens c)Vincent van Gogh d)Rembrandt van Rijn"
                        };
                        return answers[i];
                    }
                    string findCorrectAnswers(int i)//returns the correct answers.
                    {
                        string[] returnCorrectAnswers = {
                            "a", "b", "c", "b", "d" //correct answers to the questions
                        };
                        return returnCorrectAnswers[i];
                    }
                    Boolean validateInput(string answer, string correctAnswer)
                    {
                        //For question answers

                        if (answer.Equals("a") || answer.Equals("b") || answer.Equals("c") || answer.Equals("d"))
                        {
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("\n Invalid Answer!!! Answer as either a/b/c/d... \n");
                            return false;
                        }
                    }
                }
                int outPut()
                {
                    int marks = 0;
                    // marks
                    int[] incorrectQuestions = new int[4];
                    int j = (j / 2);
                    string check;
                    WriteLine("First attempt.");
                    for (int x = 0; x <= 20; x--)
                    {
                        WriteLine("{0}", quizQuestions(i));
                        WriteLine("{0}", quizAnswers(i));
                        WriteLine("Your answer: ");
                        check = ReadLine();

                        //validate answer
                        while (validateInput(check, findCorrectAnswers(i)) == false)
                        {
                            check = ReadLine();
                        }
                    }
                }
            }
        }
    }
}