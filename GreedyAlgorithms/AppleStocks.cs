
static public class AppleStocks
{
    public static int GetMaxProfit(int[] stockPrices)
    {
        if (stockPrices == null || stockPrices.Length < 2)
        {
            throw new ArgumentException("At least two stock prices are required to calculate the maximum profit.");
        }

        int minPrice = stockPrices[0];
        int maxProfit = stockPrices[1] - stockPrices[0];

        foreach (int currentPrice in stockPrices[1..])
        {
            // Ensure minPrice is the lowest price we've seen so far.
            // See what our profit would be if we bought at the min price and sold at the current price.
            int potentialProfit = currentPrice - minPrice;
            // Update maxProfit if we can do better.
            maxProfit = Math.Max(maxProfit, potentialProfit);
            minPrice = Math.Min(minPrice, currentPrice);
        }

        return maxProfit;
    }
}
