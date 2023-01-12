using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class ConvertToUnary
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        string binaryResult = string.Empty;
        string unaryResult = string.Empty;
        
        foreach (char m in message)
        {
            string lengthCheck = Convert.ToString((int)m, 2);
            if (lengthCheck.Length < 7)
            {
                lengthCheck = new string('0', 7- lengthCheck.Length) + lengthCheck;
            }
            binaryResult += lengthCheck;
        }
        char[] binaryArray = binaryResult.ToArray();
        
        string response = string.Empty;
        char lastChar = '\0';
        
        for (int i = 0; i<binaryArray.Length; i++)
        {
            char currentchar = binaryArray[i];
            if (lastChar != '1' && currentchar == '1')
            {
                response += " 0 0";
                lastChar = '1';
            }
            else if (lastChar == '1' && currentchar == '1')
            {
                response += "0";
            }
            else if (lastChar != '0' && currentchar == '0')
            {
                response += " 00 0";
                lastChar = '0';
            }
            else if (lastChar == '0' && currentchar == '0')
            {
                response += "0";
            }
            else
            {
                response += "error";
            }
            }
        
        Console.WriteLine(response.Trim());       

    }
}
