using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exception_random_stringcheck_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;
            Console.WriteLine("Enter {0} elements", size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    int result = 0;
                    string number = Console.ReadLine();
                    //bool value = int.TryParse(number, out result);
                    //Console.WriteLine("value is {0}", value);
                    if (!(int.TryParse(number, out result)))
                    {
                        arr[i] = 0;
                        continue;
                    }
                    else if (int.Parse(number) < 0)
                    {

                        Random r = new Random();
                        int num = r.Next(1000, 10000);
                        arr[i] = num;
                        int z = 0;
                        for (z = i + 1; z < size; z++)
                        {
                            arr[z] = r.Next(1000, 10000);

                        }
                        break;

                    }

                    arr[i] = int.Parse(number);

                }
            }
           
            catch (OverflowException e)
            {
                Console.WriteLine("Entered values should be betweeen {0} and {1}", int.MinValue, int.MaxValue);
            }
            catch (FormatException e)
            {
                Console.WriteLine("enter number only");

            }
                

            finally
            {
                for (int m = 0; m < size; m++)
                {
                    sum = sum + arr[m];
                    Console.WriteLine("a[{0}] = {1}\n", m, arr[m]);
                }
                Console.WriteLine("sum of elements in {0}", sum);
            }
        }
    }
}
                                                                                                                                                                        