using Extensions;

var simpleDate = "2023-03-24";
var simpleDateConverted = simpleDate.ToDateTime();

Console.WriteLine("The input date: " + simpleDate + ", of type: " + simpleDate.GetType());
Console.WriteLine("The output date: " +  simpleDateConverted + ", of type: " + simpleDateConverted.GetType());
