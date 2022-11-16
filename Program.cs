string [] a={"1","4","dfdfdf"};
string [] b={"1","4"};
PrintResult (a,b);

void PrintResult (string [] arr, string [] res) {
    PrintArray (arr);
    Console.Write ("->");
    PrintArray (res);
}

void PrintArray (string [] array) {
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ('"');
        Console.Write ($"{array[i]}"); 
        Console.Write ('"');
        if (i<array.Length-1) Console.Write (","); 
    }
    Console.Write ("]");
}