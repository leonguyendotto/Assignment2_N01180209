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
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
        [Route("api/J3/phoneGame/{str}")]
        [HttpGet]
        public int phoneGame(string str)
        {
			int totalTime = 0;
			int currChar = 0;
			int prevChar = 0;
			if (str == "halt")// if user input halt = exit the program 
			{
				return totalTime;
			}
			for (int i = 0; i < str.Length; i++)
			{
				currChar = str[i];
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
