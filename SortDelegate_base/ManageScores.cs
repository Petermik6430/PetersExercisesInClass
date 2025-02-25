using Microsoft.VisualBasic.FileIO;
using SortDelegate_Base;

int[] scores = new int[] { 4, 2, 7, 4, 9, 13, 2, 1, 4, 0, 5 };

// Display scores as entered in collection
Console.WriteLine("Unsorted scores");
Console.WriteLine(StringHelper.GetDisplayString(scores));


Console.WriteLine("DelegateBubleSort greater then");
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.GreaterThan);
Console.WriteLine(StringHelper.GetDisplayString(scores));

Console.WriteLine("DelegateBubleSort aplhabetic");
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.GreaterThanAlphabetically);
Console.WriteLine(StringHelper.GetDisplayString(scores));

Console.WriteLine("DelegateBubleSort Even or Odd");
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenBeforeOdd);
Console.WriteLine(StringHelper.GetDisplayString(scores));


Console.WriteLine("DelegateBubleSort ?!?!");
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenBeforeOddAscending);
Console.WriteLine(StringHelper.GetDisplayString(scores));
// Display scores sorted by some order
// Use BubleSort method - member og DelegateBubleSort class 
// Console.WriteLine("Sorted scores");

//Console.WriteLine(GetDisplayString(scores));


Console.Read();


