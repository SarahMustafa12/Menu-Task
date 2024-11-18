using System.Security.Cryptography.X509Certificates;

namespace Menu_Task
{
    internal class Program
    {
        static void isEmpty(List<int> list)
        {
            if (list.Count == 0)
                Console.WriteLine("The list is Empty.");
            Console.WriteLine("\t ------------------------------- \t");


        }
        public static void AddNumber(List<int> list)
        {
            Console.WriteLine("Enter the number you want to add ");
            {
                int AddedNum = int.Parse(Console.ReadLine());
                list.Add(AddedNum);
                Console.WriteLine("\t ------------------------------- \t");
                Console.WriteLine($"{AddedNum} added succesfully");
                Console.WriteLine("\t ------------------------------- \t");

            }

        }
        static void ListWithoutDuplicatation(List<int> list)
        {
            if (list.Count == 0)
                AddNumber(list);
            else if (list.Count > 0)
            {
                Console.WriteLine("Enter the number you want to add ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("\t ------------------------------- \t");
                bool isExisit = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == num)
                    {
                        isExisit = true;
                        Console.WriteLine("Sorry, Duplicate is Not Allowed");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    }
                }
                if (isExisit == false)
                {
                    list.Add(num);
                    Console.WriteLine($"{num} added succesfully");
                    Console.WriteLine("\t ------------------------------- \t");

                }

            }

        }

        static double CalcAvg(List<int> list)
        {
            isEmpty(list);
            double sum = 0;
            int totalNumbers = list.Count;
            foreach (int number in list)
            {
                sum += number;
            }
            double mean = sum / totalNumbers;
            return mean;
        }
        static int FindSmallestNmuber(List<int> list)
        {
            isEmpty(list);
            int theSmallestNum = list[0];
            foreach (int number in list)
            {
                if (theSmallestNum > number)
                {
                    theSmallestNum = number;
                }
            }
            return theSmallestNum;
        }
        static int FindLargestNmuber(List<int> list)
        {
            isEmpty(list);
            int theLargestNum = list[0];
            foreach (int number in list)
            {
                if (theLargestNum < number)
                    theLargestNum = number;
            }
            return theLargestNum;
        }


        static int Search(List<int> list, int value)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == value)
                        return i;
                }
            }
            return -1;
        }
        static void DisplayList(List<int> list)
        {
            Console.Write("[");
            foreach (int number in list)
            {
                Console.Write($" {number} ");
            }
            Console.WriteLine("]");
            Console.WriteLine("\t ------------------------------- \t");
        }


        static void Main(string[] args)
        {

            List<int> listOfNumbers = new List<int>();
            Console.WriteLine("Do you want to Duplicate the numbers ? answer with yes or no only ");
            string answer = Console.ReadLine();
            char option = '\0';
            do
            {
                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("A - Add number ");
                Console.WriteLine("M - Display mean of numbers ");
                Console.WriteLine("S - Display the smallest number ");
                Console.WriteLine("L - Display the largest number ");
                Console.WriteLine("R - Search a number ");
                Console.WriteLine("Q - Quit ");
                Console.WriteLine("\t ------------------------------- \t");
                Console.WriteLine("Enter your Option: ");

                option = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.WriteLine("\t ------------------------------- \t");


                switch (option)
                {
                    case 'P':
                        isEmpty(listOfNumbers);
                        DisplayList(listOfNumbers);

                        break;
                    case 'A':
                        if (answer == "yes")
                            AddNumber(listOfNumbers);
                        else if (answer == "no")
                            ListWithoutDuplicatation(listOfNumbers);
                        break;
                    case 'M':
                        Console.WriteLine($"the average = {CalcAvg(listOfNumbers)}");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    case 'S':
                        Console.WriteLine($"the smallest number = {FindSmallestNmuber(listOfNumbers)}");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    case 'L':
                        Console.WriteLine($"the largest number= {FindLargestNmuber(listOfNumbers)}");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    case 'R':
                        Console.WriteLine("Enter the number you want to search for");
                        Console.WriteLine($" the index = {Search(listOfNumbers, int.Parse(Console.ReadLine()))}");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("\t ------------------------------- \t");

                        break;
                }


            }
            while (option != 'Q');
        }
    }
}
