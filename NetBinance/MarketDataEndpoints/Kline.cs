﻿using NetBinance.Converters;
using Newtonsoft.Json;
using System;

namespace NetBinance.MarketDataEndpoints
{    
    /* Kline/candlesticks Binance API JSON Response example
    [
      [
        1499040000000,      // Open time
        "0.01634790",       // Open
        "0.80000000",       // High
        "0.01575800",       // Low
        "0.01577100",       // Close
        "148976.11427815",  // Volume
        1499644799999,      // Close time
        "2434.19055334",    // Quote asset volume
        308,                // Number of trades
        "1756.87402397",    // Taker buy base asset volume
        "28.46694368",      // Taker buy quote asset volume
        "17928899.62484339" // Can be ignored
      ]
    ]
    */
    [JsonConverter(typeof(KlineJsonConverter))]
    public class Kline
    {
        public DateTime OpenTime { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public DateTime CloseTime { get; set; }
        public int NumberOfTrandes { get; set; }
        public double BaseAssetVolume { get; set; }
        public double QuoteAssetVolume { get; set; }
    }
}
