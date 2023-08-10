//var numbers = new int[] { 1, 2, 3, 4 };


//try
//{

//    numbers[10] = 39;
//    Console.WriteLine(numbers[10]);
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine($"That was out of bounds, man. {e.Message}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine("Continue on..");


//try
//{
//    Console.WriteLine("Please give me a number: ");

//    var userNumber = int.Parse(Console.ReadLine());

//    Console.WriteLine($"I like the number {userNumber} too!");

//}
//catch(FormatException e)
//{
//    Console.WriteLine($"Failed to parse.\n{e.Message}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("This happens no matter what.");
//}

//Console.WriteLine("Continue on..");


var strNumbers = new string[] { "12", "2", "ten", "twelve", "88", "1000", "twenty", "345" };
var numbers = new List<int>();

foreach(var strNumber in strNumbers) 
{
    try
    {
        int number = int.Parse(strNumber);
        numbers.Add(number);
    }
    catch(FormatException e)
    {
        Console.WriteLine($"Could not parse: {strNumber}.\n{e.Message}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed numbers:");

foreach(var number in numbers)
{
    Console.WriteLine(number);
}