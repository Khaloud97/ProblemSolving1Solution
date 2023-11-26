using System.Threading.Channels;

namespace ProblemSolving1
{
    internal class Program
    {

        //-------------------------------function for Solving Sum Problem with nested loop(many loops)--------------------------------------
        static string SolvingSumProblem()
        {
            
            int n, x; //n ==> Array size , x ==> target

            //  read will reade char not string so will nead this:
            Console.WriteLine("Enter Array size and target: ");
            string s = Console.ReadLine();
            // " 3 4"
            //"3" "4" 
            string[] arr = s.Split(" ");
            n = int.Parse(arr[0]);
            x = int.Parse(arr[1]);

            int[] value = new int[n];


            // array values read it as string and split it
            //" 3 4 5 6 7 8"
            Console.WriteLine("Array value: ");
            s = Console.ReadLine();
            arr = s.Split(" ");

            for (int i = 0; i < n; i++)
            {
                value[i] = int.Parse(arr[i]);// to convert all string vale to int

            }

            string sol = "-1";
            bool flag = false;
            //
            for (int i = 0; i < value.Length -1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((value[i] + value[j]) == x)
                    {

                        sol = $"value number: {i + 1} value number: {j + 1}";

                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }

            }
            return sol;
        }


        //-------------------------------function for Solving Sum Problem with One loop--------------------------------------
        static string SolvingSumProblemOneLoop()
        {
            int n, x; //n ==> Array size , x ==> target

            //  read will reade char not string so will nead this:
            Console.WriteLine("Enter Array size and target: ");
            string s = Console.ReadLine();
            // " 3 4"
            //"3" "4" 
            string[] arr = s.Split(" ");
            n = int.Parse(arr[0]);
            x = int.Parse(arr[1]);

            int[] value = new int[n];


            // array values read it as string and split it
            //" 3 4 5 6 7 8"
            Console.WriteLine("Array value: ");
            s = Console.ReadLine();
            arr = s.Split(" ");

            for (int i = 0; i < n; i++)
            {
                value[i] = int.Parse(arr[i]);

            }

            //
            Array.Sort(value);//ascendig order
            int startPoint=0; int endPoint = n - 1;
            while (startPoint < endPoint)
            {
                if (value[startPoint] + value[endPoint] == x)
                {
                    return $"number: {value[startPoint]}  number: {value[endPoint]}";
                }
                else if (value[startPoint] + value[endPoint] < x)
                {
                    startPoint++;
                }
                else { 
                    endPoint--; 
                }
                 
            }return "-1";



        }


        //----------------------------function of multiplication table------------------

        static void MultiplicationTable(int n)
        {
            Console.WriteLine("------------multiplication table:-----------");

            

            string s = " ";

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"multiplication of {i}");
                
                for(int j = 0; j <=12; j++)
                {
                    Console.WriteLine($"{i} * {j} ={i *j}");
                }

            }

            Console.WriteLine("----------------------");


        }



        static void Main(string[] args)
        {
            //--------------------------------Problem Solving! using  function:----------------------------------
            Console.WriteLine("---------Problem Solving Using function for Solving Sum Problem with One loop!--------------");

            Console.WriteLine(SolvingSumProblemOneLoop());



            //----------------------------------------------------------------------------------------
            //function of Multiplication Table
            MultiplicationTable(3);



            //-------------------------------------------------------------------------------------
            Console.WriteLine("----------------Problem Solving!---------------");

            int n, x; //n ==> Array size , x ==> target

            //  read will reade char not string so will nead this:
            Console.WriteLine("Enter Array size and target: ");
            string s = Console.ReadLine();
            // " 3 4"
            //"3" "4" 
            string[] arr = s.Split(" ");
            n = int.Parse(arr[0]);
            x = int.Parse(arr[1]);

            int[] value= new int[n];


            // array values read it as string and split it
            //" 3 4 5 6 7 8"
            Console.WriteLine("Array value: ");
            s = Console.ReadLine();
            arr = s.Split(" ");

            for(int i=0; i<n; i++)
            {
                value[i] = int.Parse(arr[i]); 

            }

            //
            for(int i=0; i< value.Length; i++)
            {
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((value[i] + value[j]) == x)
                    {
                        
                        Console.WriteLine($"value number: {i+1} value number: {j+1}");
                        Console.WriteLine($" number: {value[i]}  number: {value[j]}");
                        break;
                    }
                }
            }

            //--------------------------------Problem Solving! using  function:----------------------------------
            Console.WriteLine("---------Problem Solving Using Function!--------------");

            Console.WriteLine(SolvingSumProblem()); 

        }
    }
}