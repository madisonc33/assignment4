using System;
using System.ComponentModel.DataAnnotations;
namespace assignment4.Models
{
    public class Top5
    {
        public Top5(int rank) //makes the rank read only because it can only be set when first created
        {
            Rank = rank;
        }
//added these in because before the nullable values (the question mark) was giving a warning and I found this online
#nullable enable
        [Required]
        public int Rank { get;}

        [Required]
        public string Name { get; set; }

        //Setting equals assigns the value if it is null
        public string? FavDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        public string? Phone { get; set; }

        public string? Website { get; set; } = "Coming Soon.";

        public string[] top5 = new string[5];
#nullable disable

        //creates new Top5 objects and returns a list of them to be used in the view
        public static Top5[] GetTop5s()
        {
            Top5 rest1 = new Top5(1)
            {
                Name = "Cubby's",
                FavDish = "Wild Race & Kale Salad",
                Phone = "801-919-3023",
                Address = "1258 N State St, Provo, UT",
                Website = "https://cubbys.co/"

            };
            Top5 rest2 = new Top5(2)
            {
                Name = "Cafe Rio",
                FavDish = "Sweet Pork Salad",
                Phone = "801-375-5133",
                Address = "2244 N University Pkwy, Provo, UT",
                Website = "https://www.caferio.com/"

            };
            Top5 rest3 = new Top5(3)
            {
                Name = "MOD",
                FavDish = "Dominic Pizza",
                Phone = "801-980-0741",
                Address = "599 Pacific Dr, American Fork, UT",
                Website = "https://modpizza.com/"

            };
            Top5 rest4 = new Top5(4)
            {
                Name = "Spicy Thai",
                FavDish = "Massaman Curry",
                Phone = "801-370-0707",
                Address = "3230 North University Ave, Provo, UT",
                Website = "https://www.spicythaiprovo.com"

            };
            Top5 rest5 = new Top5(5)
            {
                Name = "Cupbop",
                FavDish = "Hot Bop",
                Phone = "801-916-8968",
                Address = "815 700 E, Provo, UT",
                Website = "https://cupbop.com/"

            };

            return new Top5[] { rest1, rest2, rest3, rest4, rest5 };
        }
    }
}
