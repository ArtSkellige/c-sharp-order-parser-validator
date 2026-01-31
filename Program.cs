/*
Order ID Parser and Validator
Parses a comma-separated string of order IDs, sorts them alphabetically,
and validates that each ID is exactly 4 characters in length.
Tags invalid orders with "- Error!".
 */

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (string order in orderIDs)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order} - Error!");
    }
    else
    {
        Console.WriteLine($"{order}");
    }
}