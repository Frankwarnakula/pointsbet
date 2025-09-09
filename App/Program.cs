// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// call StringFormatter.ToCommaSepatatedList with some test data
Console.WriteLine(
    PointsBet.Backend.Online.Code.StringFormatter.ToCommaSepatatedList(
        new[] { "apple", "banana", "cherry" }, "'"));
