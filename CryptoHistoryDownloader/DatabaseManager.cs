using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHistoryDownloader
{
    /// <summary>
    /// Třída na ukládání dat do databáze
    /// </summary>
    public class DatabaseManager
    {

        private readonly string connectionString;
    

        public DatabaseManager(string connectionString) => this.connectionString = connectionString;
    

     /// <summary>
     /// metoda uloží požadovaná data do databáze pomocí ADO.NET
     /// </summary>
     /// <param name="cryptoList">Kolekce dat typu Crypto. Informace z ní se uloží do databáze</param>
        public void SaveData(IEnumerable<Crypto> cryptoList)
        {
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                Console.WriteLine("Přípojeno k databázi.");

                foreach (Crypto crypto in cryptoList)
                {


                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = pripojeni;
                    cmd.CommandText = "INSERT INTO [Table](Name, Date, PriceCZK, PriceUSD) VALUES (@Name, @Date, @PriceCZK, @PriceUSD)";

                    cmd.Parameters.AddWithValue("@Name", crypto.name);
                    cmd.Parameters.AddWithValue("@Date", crypto.date);
                    cmd.Parameters.AddWithValue("@PriceCZK", crypto.market_data.current_price.czk);
                    cmd.Parameters.AddWithValue("@PriceUSD", crypto.market_data.current_price.usd);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Zapsáno:" + crypto.name + " - " + crypto.date.ToString("dd.MM.yyy") + " - " + crypto.market_data.current_price.czk);
                    

                   
                }
                pripojeni.Close();
                Console.WriteLine();
            }

        }

    }
}
