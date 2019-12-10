using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p)
    {
        var listP = new List<int>();
        listP = p.ToList();
        listP.Sort();
        var finalList = new List<int>();
        var x = 0;
        var y = 0;
        for( int i = 0; i < listP.Count; i++)
        {
            x = listP[i];
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] == x)
                {
                    y = j + 1;
                    for (int k = 0; k < p.Length; k++)
                    {
                        if (p[k] == y)
                        {
                            finalList.Add(k + 1);
                        }
                    }
                    
                }
            }
        }
        var finalArray = finalList.ToArray();
        return finalArray;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p);

        Console.WriteLine(string.Join("\n", result));
        Console.ReadKey();

    }
}
