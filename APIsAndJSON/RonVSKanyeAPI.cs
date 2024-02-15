using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        
        public void RonMethod()
        {

        //Ron
        HttpClient clientRon = new HttpClient();
        //endpoint
        string ronEnd = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        //Get
        var ronGet = clientRon.GetStringAsync(ronEnd).Result;
        //PARSE
        var ronParse = JArray.Parse(ronGet);

        //Write
        Console.WriteLine($"Ron: {ronParse[0]}");


        }

        public void KayneMethod()
        {

        
        //Kayne
        HttpClient clientKayne = new HttpClient();
        //endpoint
        string kayEnd = "https://api.kanye.rest/";
        //Get
        var kayGet = clientKayne.GetStringAsync(kayEnd).Result;
        //Parse
        var kayParse = JObject.Parse(kayGet).GetValue("quote").ToString();   
        //Kayne 
        Console.WriteLine($"Kayne: {kayParse}");
        }


    }
}
//Let’s create a console application that calls both the Ron Swanson API, 
//and the Kanye West API. Using both APIs, make Ron Swanson and Kanye West have a conversation that prints to the console.