using CryptoHistoryDownloader;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

// kryptoměny, jejichž ceny chci stáhnout
List<string> cryptoStrings = new List<string>() {"bitcoin","ethereum" };

//den od kterého se stahují data (z free api congecko max. rok zpět)  
DateTime date = new DateTime(2022, 5, 27);

// kolik záznamů chcete stáhnout
int amount = 300;

// pauza mezi volání API (ms), free api má omezený limit volání za min. (10-30 podle vytíženosti)
int waitingTime = 6100;

string connectionString = @"YOUR CONNECTION STRING";




var downloader = new CryptoDownloader();
var dbManager = new DatabaseManager(connectionString);


foreach (var cryptoName in cryptoStrings)
{
    try
    {
        // stáhne požadovaná data 
        var result = await downloader.DownloadDataFromApiAsync(date: date, cryptoName: cryptoName, amount: amount, waitingTime: waitingTime);
        //  a uloží do databáze
        dbManager.SaveData(result);
    }
    catch (Exception ex)
    {

        Console.WriteLine("Nastala chyba:" +ex.Message);
    }
   
}

Console.WriteLine("Hotovo");

