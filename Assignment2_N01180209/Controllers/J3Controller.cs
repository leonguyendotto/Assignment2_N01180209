using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01180209.Controllers
{
    public class J3Controller : ApiController
    {
		/// <summary>
		/// Enter a string and it will return a total int equal to how many seconds you need.
		/// </summary>
		/// <param name="str"></param>
		/// <returns>"a" = 1, "abba" = 12 , "dada" = 4</returns>
		[Route("api/J3/phoneGame/{str}")]
        [HttpGet]
        public int phoneGame(string str)
        {
			int totalTime = 0;
			int currChar = 0;
			int prevChar = 0;
			if (str == "halt")// if user input "halt" = exit the program (in other program) but still works with this (=0)
			{
				return totalTime;
			}
			for (int i = 0; i < str.Length; i++)
			{
				currChar = str[i]; // holds string value
				if (i > 0)
				{
					prevChar = str[i - 1];
				}
				if ('p' <= currChar && currChar <= 's') /// keys 7
				{
					int currDifference = currChar - 'p';
					totalTime += (currDifference + 1);
					/*Console.WriteLine("added currdiff: " + (currDifference + 1));*/
					if (i > 0 && 'p' <= prevChar && prevChar <= 's')
					{
						totalTime += 2;
						/*Console.WriteLine("added pause");*/

					}
				}
				else if ('w' <= currChar && currChar <= 'z')/// key 9
				{
					int currDifference = currChar - 'w';
					totalTime += (currDifference + 1);

					/*Console.WriteLine("added currdiff: " + (currDifference + 1));*/

					if (i > 0 && 'w' <= prevChar && prevChar <= 'z')
					{
						totalTime += 2;
						/*Console.WriteLine("added pause");*/
					}
				}
				else if ('t' <= currChar && currChar <= 'v') /// key 8
				{
					int currDifference = currChar - 't';
					totalTime += (currDifference + 1);
					/*Console.WriteLine("added currdiff: " + (currDifference + 1));*/
					if (i > 0 && 't' <= prevChar && prevChar <= 'v')
					{
						totalTime += 2;
						/*Console.WriteLine("added pause");*/
					}
				}
				else
				{
					int currDifference = currChar - 'a'; /// alphabet 
					int currQuotient = currDifference / 3;/// keys have 3 digits 
					int currRemainder = currDifference % 3;
					totalTime += (currRemainder + 1);
					/*Console.WriteLine("added currdiff: " + (currRemainder + 1));*/
					
					if (i > 0)
					{
						int prevDifference = prevChar - 'a';
						int prevQuotient = prevDifference / 3; //quotient 
						if (currQuotient == prevQuotient)
						{
							totalTime += 2;
							/*Console.WriteLine("added pause");*/
						}
					}
				}
			}
			return totalTime;
		}
	
    }
}
/* This J3 bases on the J3 CCC '06. 
 * How my program works?
 * Enter any string and it will return int values base on user input. 
 * I use the ASCII Table to convert the string value to decimal (int) 
 * There are 3 special input here: key 7 8 9 
 * Key 7 & 9 have 4 letters so they are in the 2 special condition (else if)
 * Key 8 behind key 7 so the value will be changed because the "s" letter
 * In the challenge they put the "halt" as an exit program when user input equal it. But in this program still runs and returns a 0 - This is I don't know why? 
 * I use the Console.WriteLine in C# to understand more how the codes work but It seems doesn't work here
 * Also, thank you for giving me extra time with this assignment. What you did means a lot to me! */