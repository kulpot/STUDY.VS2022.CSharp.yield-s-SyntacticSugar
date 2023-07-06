using System;

// link ref:https://www.youtube.com/watch?v=-9YcKk5WqyQ&list=PL9B5E4C37F7B234A8&index=5
//

/*      .NET REFLECTOR TUTORIAL
 *      
 *      CMD Batch file
 *      
 *     C:\>type c.bat
 *     csc mainclass.cs
 *     reflector mainclass.exe
 *     
 *     C:\>csc mainclass.cs
 *     C:\>reflector mainclass.exe
 *
 */

class MainClass
{
    static Random rand = new Random(); // one static random required
    static IEnumerable<int> GetRandomNumbers(int count)
    {
        for (int i = 0; i < count; i++)
            yield return rand.Next();
    }
    static void Main()
    {
        foreach (int num in GetRandomNumbers(10)) // in(enumerator) requires knowledge in foreach
            Console.WriteLine(num);
    }
}