using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {

        string input = Console.ReadLine();

        long result = 0;

        while (input[0] != 'E')
        {
            //string codeArgs = opCode[0];
            string[] opCode = input.Split().ToArray();

            switch (opCode[0])
            {
                case "INC":
                    {
                        long operandOne = int.Parse(opCode[1]);
                        result = operandOne + 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = int.Parse(opCode[1]);
                        result = operandOne - 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = int.Parse(opCode[1]);
                        long operandTwo = int.Parse(opCode[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = int.Parse(opCode[1]);
                        long operandTwo = int.Parse(opCode[2]);
                        result = operandOne * operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
            }
            input = Console.ReadLine();
            //Console.WriteLine(result);
        }
    }
}