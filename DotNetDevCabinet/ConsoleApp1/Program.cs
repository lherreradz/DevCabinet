using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
        //    WebResponse response = request.GetResponse();

        //    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
        //    {
        //        string responseText = reader.ReadToEnd();
        //        Console.WriteLine(responseText.ToString());
        //        Console.WriteLine(CleanEmptyField(responseText.ToString()));
        //    }

        //    response.Close();

        //}

        //public static string CleanEmptyField(string json)
        //{
        //    Regex rx = new Regex("(,)*\"([a-zA-Z]*)\":\"(N/A)*(-)*()*(N\\\\\\/A)*\"(,)*");
        //    var matches = rx.Matches(json);
        //    foreach (var match in matches)
        //    {
        //        var replacement = (match.ToString().Substring(0, 1) == "," && match.ToString().Substring(match.ToString().Length - 1) == ",") ? "," : "";
        //        json = json.Replace(match.ToString(), replacement);
        //    }
        //    return json;
        //}
        public static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(ArrayChallenge(new int[] {8,1,8}));
        }


        public static int ArrayChallenge(int[] arr)
        {
            int deskCount = arr[0];
            
            arr[0] = 0;

            var occupiedList = new List<int>(arr);

            int connections = 0;

            for(int i = 1; i < deskCount; i++)
            {
                if ((i % 2 == 1) && !occupiedList.Contains(i) && !occupiedList.Contains(i + 1)) connections += 1;
                if ((i <= deskCount - 2) && !occupiedList.Contains(i) && !occupiedList.Contains(i + 2)) connections += 1;
            }

            // code goes here  
            return connections;
        }


    }
}
