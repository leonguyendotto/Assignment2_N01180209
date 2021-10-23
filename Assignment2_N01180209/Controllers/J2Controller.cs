using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01180209.Controllers
{
    public class J2Controller : ApiController
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">1</param>
		/// <param name="n">2</param>
		/// <returns>"There are 5 total ways to make 10."</returns>
		[Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
			{
				int pairsDice = 0;
				int outerMax = 0;
				int innerMax = 0;
				if (m <= n)
				{
					outerMax = m;
					innerMax = n;
				}
				else
				{
					outerMax = n;
					innerMax = m;
				}
				for (int i = 1; i <= outerMax; i++)
				{
					for (int j = 1; j <= innerMax; j++)
					{
						if (i + j == 10)
						{
							pairsDice++;
						}
					}
				}
				if (pairsDice > 1)
				{
					return "There are " + pairsDice + " total ways to get the sum 10";
				}
				else
				{
					return "There is " + pairsDice + " way to get the sum 10";
				}
			}
		
        }
    }
}
