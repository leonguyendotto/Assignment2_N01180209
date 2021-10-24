using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01180209.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// The program should return the  a number for each type of
        /// item then calculate and display the total calories.
        /// </summary>
        /// <param name="burger">1</param>
        /// <param name="drink">2</param>
        /// <param name="side">3</param>
        /// <param name="dessert">4</param>
        /// <returns>
        /// String "Your total calorie count is" + userChoice (total Calories)
        /// </returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories;

            // IF for burger
            if (burger == 1)
            {
                calories = 461;
            }
            else if (burger == 2)
            {
                calories = 431;
            }
            else if (burger == 3)
            {
                calories = 420;
            }
            else calories = 0;


            //IF for drink
            if (drink == 1)
            {
                calories += 130;
            }
            else if (drink == 2)
            {
                calories += 160;
            }
            else if (drink == 3)
            {
                calories += 118;
            }
            else calories += 0;


            // IF for side
            if (side == 1)
            {
                calories += 100;
            }
            else if (side == 2)
            {
                calories += 57;
            }
            else if (side == 3)
            {
                calories += 70;
            }
            else calories += 0;


            //IF for dessert
            if (dessert == 1)
            {
                calories += 167;
            }
            else if (dessert == 2)
            {
                calories += 266;
            }
            else if (dessert == 3)
            {
                calories += 75;
            }
            else calories += 0;

            //Return Message:
            string FinalMess = "Your total calorie count is " + calories + ".";
            return FinalMess;
        }
    }
}
