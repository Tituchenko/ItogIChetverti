string[] firstArray=GetArray();
string[] resultArray=GetArratLessSymbol(firstArray,3);
PrintResult (firstArray,resultArray);


string [] GetArray ()
{
    int size=0;
    Console.WriteLine("Введите исходный массив:");
    Console.WriteLine("1. Просто нажав Enter, пустой ввод - тогда массив буде сформирован случайным образом из тестовых к заданию.");
    Console.WriteLine("2. Введите числе элементов (цифра), тога далее будет поэлементно запрошен массив.");
    Console.WriteLine("3. Введите полностью массив в строке, используя ';' как разделитель элементов");
    string inputUser=Console.ReadLine()!;
    if (inputUser==string.Empty) return GetRandomFromExamples ();
    else if (int.TryParse(inputUser, out size)) {
        string [] ret = new string [size];
        for (int i = 0; i < size; i++)
        {
           Console.Write($"Введите элемент {i}:");
           ret[i]= Console.ReadLine()!;
        }
        return ret;
    }
    else 
    {
        return inputUser.Split(";");
    }
}


string [] GetRandomFromExamples ()
{
    int i= new Random().Next(0,3);
    switch (i)
    {
        case 0:
            return new string [] {"hello","2","world",":-)"};
        case 1:
            return new string [] {"1234","1567","-2","computer science"};
        case 2:
            return new string [] {"Russia","Denmark","Kazan"};
    }
    return new string [] {}; 
}
string [] GetArratLessSymbol (string [] arr,int numSymb){
    string [] temp=new string [arr.Length];
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=numSymb) {
            temp[count]=arr[i];
            count++;
        }
        
    }
    string [] ret=new string [count];
    for (int i = 0; i < count; i++)
    {
        ret[i]=temp[i];
    }
    return ret;
}

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