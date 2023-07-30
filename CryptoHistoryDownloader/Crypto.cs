using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHistoryDownloader
{
    /// <summary>
    /// kryptoaset do kterého se budou serializovat  data z api
    /// </summary>
    public class Crypto
    {
        public string? id { get; set; }
        public string? symbol { get; set; }
        public string? name { get; set; }

        public DateTime date { get; set; } //přidáno aby každý objekt měl příslušné datum
        public Localization? localization { get; set; }
        public Image? image { get; set; }
        public Market_Data? market_data { get; set; }
        public Community_Data? community_data { get; set; }
        public Developer_Data? developer_data { get; set; }
        public Public_Interest_Stats? public_interest_stats { get; set; }
    }

    public class Localization
    {
        public string? en { get; set; }
        public string? de { get; set; }
        public string? es { get; set; }
        public string? fr { get; set; }
        public string? it { get; set; }
        public string? pl { get; set; }
        public string? ro { get; set; }
        public string? hu { get; set; }
        public string? nl { get; set; }
        public string? pt { get; set; }
        public string? sv { get; set; }
        public string? vi { get; set; }
        public string? tr { get; set; }
        public string? ru { get; set; }
        public string? ja { get; set; }
        public string? zh { get; set; }
        public string? zhtw { get; set; }
        public string? ko { get; set; }
        public string? ar { get; set; }
        public string? th { get; set; }
        public string? id { get; set; }
        public string? cs { get; set; }
        public string? da { get; set; }
        public string? el { get; set; }
        public string? hi { get; set; }
        public string? no { get; set; }
        public string? sk { get; set; }
        public string? uk { get; set; }
        public string? he { get; set; }
        public string? fi { get; set; }
        public string? bg { get; set; }
        public string? hr { get; set; }
        public string? lt { get; set; }
        public string? sl { get; set; }
    }

    public class Image
    {
        public string? thumb { get; set; }
        public string? small { get; set; }
    }

    public class Market_Data
    {
        public Current_Price? current_price { get; set; }
        public Market_Cap? market_cap { get; set; }
        public Total_Volume? total_volume { get; set; }
    }

    public class Current_Price
    {
        public decimal? aed { get; set; }
        public decimal? ars { get; set; }
        public decimal? aud { get; set; }
        public decimal? bch { get; set; }
        public decimal? bdt { get; set; }
        public decimal? bhd { get; set; }
        public decimal? bmd { get; set; }
        public decimal? bnb { get; set; }
        public decimal? brl { get; set; }
        public decimal? btc { get; set; }
        public decimal? cad { get; set; }
        public decimal? chf { get; set; }
        public decimal? clp { get; set; }
        public decimal? cny { get; set; }
        public decimal? czk { get; set; }
        public decimal? dkk { get; set; }
        public decimal? dot { get; set; }
        public decimal? eos { get; set; }
        public decimal? eth { get; set; }
        public decimal? eur { get; set; }
        public decimal? gbp { get; set; }
        public decimal? hkd { get; set; }
        public decimal? huf { get; set; }
        public decimal? idr { get; set; }
        public decimal? ils { get; set; }
        public decimal? inr { get; set; }
        public decimal? jpy { get; set; }
        public decimal? krw { get; set; }
        public decimal? kwd { get; set; }
        public decimal? lkr { get; set; }
        public decimal? ltc { get; set; }
        public decimal? mmk { get; set; }
        public decimal? mxn { get; set; }
        public decimal? myr { get; set; }
        public decimal? ngn { get; set; }
        public decimal? nok { get; set; }
        public decimal? nzd { get; set; }
        public decimal? php { get; set; }
        public decimal? pkr { get; set; }
        public decimal? pln { get; set; }
        public decimal? rub { get; set; }
        public decimal? sar { get; set; }
        public decimal? sek { get; set; }
        public decimal? sgd { get; set; }
        public decimal? thb { get; set; }
        public decimal? _try { get; set; }
        public decimal? twd { get; set; }
        public decimal? uah { get; set; }
        public decimal? usd { get; set; }
        public decimal? vef { get; set; }
        public decimal? vnd { get; set; }
        public decimal? xag { get; set; }
        public decimal? xau { get; set; }
        public decimal? xdr { get; set; }
        public decimal? xlm { get; set; }
        public decimal? xrp { get; set; }
        public decimal? yfi { get; set; }
        public decimal? zar { get; set; }
        public decimal? bits { get; set; }
        public decimal? link { get; set; }
        public decimal? sats { get; set; }
    }

    public class Market_Cap
    {
        public decimal? aed { get; set; }
        public decimal? ars { get; set; }
        public decimal? aud { get; set; }
        public decimal? bch { get; set; }
        public decimal? bdt { get; set; }
        public decimal? bhd { get; set; }
        public decimal? bmd { get; set; }
        public decimal? bnb { get; set; }
        public decimal? brl { get; set; }
        public decimal? btc { get; set; }
        public decimal? cad { get; set; }
        public decimal? chf { get; set; }
        public decimal? clp { get; set; }
        public decimal? cny { get; set; }
        public decimal? czk { get; set; }
        public decimal? dkk { get; set; }
        public decimal? dot { get; set; }
        public decimal? eos { get; set; }
        public decimal? eth { get; set; }
        public decimal? eur { get; set; }
        public decimal? gbp { get; set; }
        public decimal? hkd { get; set; }
        public decimal? huf { get; set; }
        public decimal? idr { get; set; }
        public decimal? ils { get; set; }
        public decimal? inr { get; set; }
        public decimal? jpy { get; set; }
        public decimal? krw { get; set; }
        public decimal? kwd { get; set; }
        public decimal? lkr { get; set; }
        public decimal? ltc { get; set; }
        public decimal? mmk { get; set; }
        public decimal? mxn { get; set; }
        public decimal? myr { get; set; }
        public decimal? ngn { get; set; }
        public decimal? nok { get; set; }
        public decimal? nzd { get; set; }
        public decimal? php { get; set; }
        public decimal? pkr { get; set; }
        public decimal? pln { get; set; }
        public decimal? rub { get; set; }
        public decimal? sar { get; set; }
        public decimal? sek { get; set; }
        public decimal? sgd { get; set; }
        public decimal? thb { get; set; }
        public decimal? _try { get; set; }
        public decimal? twd { get; set; }
        public decimal? uah { get; set; }
        public decimal? usd { get; set; }
        public decimal? vef { get; set; }
        public decimal? vnd { get; set; }
        public decimal? xag { get; set; }
        public decimal? xau { get; set; }
        public decimal? xdr { get; set; }
        public decimal? xlm { get; set; }
        public decimal? xrp { get; set; }
        public decimal? yfi { get; set; }
        public decimal? zar { get; set; }
        public decimal? bits { get; set; }
        public decimal? link { get; set; }
        public decimal? sats { get; set; }
    }

    public class Total_Volume
    {
        public decimal? aed { get; set; }
        public decimal? ars { get; set; }
        public decimal? aud { get; set; }
        public decimal? bch { get; set; }
        public decimal? bdt { get; set; }
        public decimal? bhd { get; set; }
        public decimal? bmd { get; set; }
        public decimal? bnb { get; set; }
        public decimal? brl { get; set; }
        public decimal? btc { get; set; }
        public decimal? cad { get; set; }
        public decimal? chf { get; set; }
        public decimal? clp { get; set; }
        public decimal? cny { get; set; }
        public decimal? czk { get; set; }
        public decimal? dkk { get; set; }
        public decimal? dot { get; set; }
        public decimal? eos { get; set; }
        public decimal? eth { get; set; }
        public decimal? eur { get; set; }
        public decimal? gbp { get; set; }
        public decimal? hkd { get; set; }
        public decimal? huf { get; set; }
        public decimal? idr { get; set; }
        public decimal? ils { get; set; }
        public decimal? inr { get; set; }
        public decimal? jpy { get; set; }
        public decimal? krw { get; set; }
        public decimal? kwd { get; set; }
        public decimal? lkr { get; set; }
        public decimal? ltc { get; set; }
        public decimal? mmk { get; set; }
        public decimal? mxn { get; set; }
        public decimal? myr { get; set; }
        public decimal? ngn { get; set; }
        public decimal? nok { get; set; }
        public decimal? nzd { get; set; }
        public decimal? php { get; set; }
        public decimal? pkr { get; set; }
        public decimal? pln { get; set; }
        public decimal? rub { get; set; }
        public decimal? sar { get; set; }
        public decimal? sek { get; set; }
        public decimal? sgd { get; set; }
        public decimal? thb { get; set; }
        public decimal? _try { get; set; }
        public decimal? twd { get; set; }
        public decimal? uah { get; set; }
        public decimal? usd { get; set; }
        public decimal? vef { get; set; }
        public decimal? vnd { get; set; }
        public decimal? xag { get; set; }
        public decimal? xau { get; set; }
        public decimal? xdr { get; set; }
        public decimal? xlm { get; set; }
        public decimal? xrp { get; set; }
        public decimal? yfi { get; set; }
        public decimal? zar { get; set; }
        public decimal? bits { get; set; }
        public decimal? link { get; set; }
        public decimal? sats { get; set; }
    }

    public class Community_Data
    {
        public object? facebook_likes { get; set; }
        public object? twitter_followers { get; set; }
        public decimal? reddit_average_posts_48h { get; set; }
        public decimal? reddit_average_comments_48h { get; set; }
        public decimal? reddit_subscribers { get; set; }
        public string? reddit_accounts_active_48h { get; set; }
    }

    public class Developer_Data
    {
        public object? forks { get; set; }
        public object? stars { get; set; }
        public object? subscribers { get; set; }
        public object? total_issues { get; set; }
        public object? closed_issues { get; set; }
        public object? pull_requests_merged { get; set; }
        public object? pull_request_contributors { get; set; }
        public Code_Additions_Deletions_4_Weeks? code_additions_deletions_4_weeks { get; set; }
        public object? commit_count_4_weeks { get; set; }
    }

    public class Code_Additions_Deletions_4_Weeks
    {
        public object? additions { get; set; }
        public object? deletions { get; set; }
    }

    public class Public_Interest_Stats
    {
        public object? alexa_rank { get; set; }
        public object? bing_matches { get; set; }
    }


}

