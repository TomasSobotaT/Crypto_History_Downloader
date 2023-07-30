using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHistoryDownloader
{
    /// <summary>
    /// Třída stahující data z API Congecko
    /// </summary>
    public class CryptoDownloader
    {
        // pokud by se opakované volání do API opakovalo;
        private int possibleErrorCounter = 10;
        
        /// <summary>
        /// Metoda stahující data z coingecko API
        /// </summary>
        /// <param name="date">Datum od kterého začíná stahování</param>
        /// <param name="cryptoName">Jmnéno požadovaného crypta</param>
        /// <param name="amount">Počet požadovaných záznamů</param>
        /// <param name="waitingTime">Jak dlouho má program čekat mezi požadavky na API (ms). Free API má omezený počet požadavků za minutu</param>
        /// <returns>Kolekce dat typu Crypto obsahující stažená data</returns>
        public async Task<IEnumerable<Crypto>> DownloadDataFromApiAsync(DateTime date, string cryptoName = "bitcoin", int amount = 1, int waitingTime = 6100)
        {
            //Kolekce výsledků
            var cryptoList = new List<Crypto>();

            // toto použití Httpclienta je pro tuto aplikaci dostačující
            using (HttpClient client = new HttpClient()) 
            {

                for (double i = 0; i < amount; i++)
                {
                    //datum ve formátu požadovaným API
                    string dateToUrl = $"{date.ToString("dd")}-{date.ToString("MM")}-{date.Year}";
                    
                    //variabilní url příkaz do API
                    Uri jsonUrl = new Uri($"https://api.coingecko.com/api/v3/coins/{cryptoName.ToLower().Trim()}/history?date={dateToUrl}&localization=czk");
                    // získáme odpověd z API                  
                    var response = await client.GetAsync(jsonUrl);

                    // když vše ok, stahneme json a vytvoříme z něj objekt Crypto a uloží
                    if (response.IsSuccessStatusCode) 
                    {
                        var str = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<Crypto>(str);
                        result.date = date;

                        if (result.market_data is not null) //občas není v api daný záznam u menších kryptoměn
                        { 
                            cryptoList.Add(result);
                            await Console.Out.WriteLineAsync((i + 1).ToString() + ". Staženo: " + result.name + " - " + date.ToString("dd.MM.yyyy") + " - " + result.market_data.current_price.czk);
                        }
                        else
                        {
                            await Console.Out.WriteLineAsync((i + 1).ToString() +". "+result.name + " - " + date.ToString("dd.MM.yyyy") + " - NENALEZENO");

                        }

                        possibleErrorCounter = 10;
                    }
                    // když ne, počkáme minutu a zkusíme daný den znovu
                    else
                    {
                    
                        await Console.Out.WriteLineAsync("Chyba při stahování z API, čekání 60s a opakuji....");
                        Thread.Sleep(60000);
                        date = date.AddDays(-1);
                        i--;

                        //když se opakované volání opakuje moc často, vrátí to co se do té doby stáhlo
                        possibleErrorCounter--;
                        if (possibleErrorCounter == 0)
                            return cryptoList;
                    }


                    //čekání kvuli mezené free API
                    Thread.Sleep(waitingTime);
                    //přidán další (následující) den na stažení
                    date = date.AddDays(1);
                }

                return cryptoList;
            }
        }
    }
}
