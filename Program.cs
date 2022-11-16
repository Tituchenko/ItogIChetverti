string[] firstArray=GetArray();

Console.WriteLine(string.Join(", ", firstArray));

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
    return new string [] {};
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