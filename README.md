# NetBinance
Binance REST API .Net Wrapper 

It is unofficial .Net wrapper of [Binance API](https://www.binance.com/restapipub.html)

## How-to use.
```
var client = new BinanceAPIClient(key, secret);
var accountInfo = await client.AccountEndpoints.AccountInfo(new AccountInfoRequest
{
    RecvWindow = 600000,
    Timestamp = DateTime.Now
});
var ethBalance = accountInfo.Balances.FirstOrDefault(b => b.Asset == "ETH");
var totalEthAmount = ethBalance.Free+ethBalance.Locked;
```
