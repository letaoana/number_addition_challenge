using System;

namespace NumberAddition
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(NumberAddition("Hello123World4")); 
        }

        public static string NumberAddition(string str)
        {
            var sum = 0;
            var numToAdd = "";
            var strArray = str.ToCharArray();

            for (var i = 0; i < strArray.Length; i++)
            {
                if (char.IsDigit(strArray[i]))
                {
                    if (numToAdd.Length.Equals(0))
                    {
                        if (i.Equals(strArray.Length - 1))
                            sum += int.Parse(strArray[i].ToString());
                        else
                            numToAdd += strArray[i].ToString();
                    }
                    else
                        numToAdd += strArray[i].ToString();
                }
                else
                {
                    if (!numToAdd.Length.Equals(0))
                    {
                        sum += int.Parse(numToAdd);
                        numToAdd = string.Empty;
                    }
                }
            }
            return sum.ToString();
        }
    }
}