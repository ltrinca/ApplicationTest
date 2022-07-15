using System.Globalization;
using TradeApp.Domain;


Portifolio portifolio = new Portifolio();

IFormatProvider culture = new CultureInfo("en-US", true);

Console.WriteLine("Enter a Trade Date");
DateTime referenceDate;
while (!DateTime.TryParse(Console.ReadLine(),culture,DateTimeStyles.None, out referenceDate))
{
    Console.Clear();
    Console.WriteLine("You entered an invalid date");
    Console.WriteLine("Enter a Trade Date ");
}

portifolio.ReferenceDate = referenceDate; 




Console.WriteLine("Enter a Number os Trades");
int numberOfTrade;

while (!int.TryParse(Console.ReadLine(), out numberOfTrade))
{
    Console.Clear();
    Console.WriteLine("You entered an invalid number");
    Console.WriteLine("Enter a Number os Trades ");
}

portifolio.NumberOfTrades = numberOfTrade;

portifolio.TradeList = new List<Trade>();

Console.WriteLine("Enter a Trade Information");
for (int i = 0; i < numberOfTrade; i++)
{
   
    string tradeInput = Console.ReadLine() ?? "";
    string[] tradeInputSplit = tradeInput.Split(' ');
    
    double value = Convert.ToDouble(tradeInputSplit[0]);   
    string sector = tradeInputSplit[1].ToUpper();

    DateTime date = Convert.ToDateTime(tradeInputSplit[2], culture);

    portifolio.TradeList.Add(new Trade(value, sector, date));
}

foreach (Trade item in portifolio.TradeList)
{
    Console.WriteLine(item.TradeCategoryVerification(item,portifolio.ReferenceDate));
}

