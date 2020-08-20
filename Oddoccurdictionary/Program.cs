using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = {1,1,2,2,3 };
        Console.WriteLine(OddOccur(arr));
    }
    public static int OddOccur(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        if (arr.Length == 1)
        {
            return arr[0];
        }
        Dictionary<int, int> duplicates = new Dictionary<int, int>();
        duplicates.Add(arr[0], 1);
        for (int i = 1; i < arr.Length; i++)
        {
            if (!duplicates.ContainsKey(arr[i]))
 
                duplicates.Add(arr[i], 1);
          
            else
           
                duplicates[arr[i]] = duplicates[arr[i]] + 1;
           
        }
    
      foreach(KeyValuePair<int, int> item in duplicates)
    
      if(item.Value%2 !=0)
        return item.Key;
      
      return 0;
    

    }
}