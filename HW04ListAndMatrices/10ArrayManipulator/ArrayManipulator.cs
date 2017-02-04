using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();


            while (command[0] != "print")
            {
                if (command[0] == "print")
                {
                    break;
                }

                string directions = command[0];
                int index = 0;

                if (command.Count >= 2)
                {
                    index = int.Parse(command[1]);
                }

                int element = 0;

                if (command.Count >= 3)
                {
                    element = int.Parse(command[2]);
                }

                //int count = 0;

                if (directions == "add")
                {
                    input.Insert(index, element);
                }
                else if (directions == "addMany")
                {
                    List<int> com = new List<int>();

                    for (int l = 0; l < command.Count - 2; l++)
                    {
                        com.Add(int.Parse(command[l + 2]));
                    }

                    input.InsertRange(index, com);
                }
                else if (directions == "contains")
                {
                    if (input.Contains(index))
                    {
                        int element1 = 0;
                        for (int m = 0; m < input.Count; m++)
                        {
                            if (input.Contains(int.Parse(command[1])))
                            {
                                element1 = m;
                                break;
                            }
                        }
                        Console.WriteLine(element1);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (directions == "remove")
                {
                    input.RemoveAt(index);
                }
                else if (directions == "shift")
                {
                    input = Shift(input, index);

                    //List<int> copy = new List<int>();

                    //for (int m = 0; m < index; m++)
                    //{
                    //    copy.Add(input[m]);
                    //}

                    //for (int j = 0; j < input.Count; j++)
                    //{
                    //    if (j <= input.Count - index - 1)
                    //    {
                    //        input[j] = input[j + index];
                    //    }
                    //    else
                    //    {
                    //        input[j] = copy[count];
                    //        count++;
                    //    }
                    //}
                }
                else if (directions == "sumPairs")
                {
                    List<int> sum = new List<int>();

                    for (int k = 0; k < input.Count - 1; k += 2)
                    {
                        int k1 = input[k];
                        int k2 = input[k + 1];

                        sum.Add(k1 + k2);
                    }
                    input = sum.ConvertAll<int>(x => x);
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", input));
            Console.Write("]");
        }
        static List<int> Shift(List<int> input, int index)
        {
            List<int> tempList = new List<int>();

            for (int j = 0; j < input.Count; j++)
            {

                //modulno delene za da ne se izliza ot masiva i kato stigne v kraq da zapochne da varti otnachalo
                tempList.Add(input[(index + j) % input.Count]);
            }

            return tempList;
        }
    }
}
