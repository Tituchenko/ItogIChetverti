GetArray();

void GetArray ()
{
    Console.WriteLine("Введите исходный массив:");
    Console.WriteLine("1. Просто нажав Enter, пустой ввод - тогда массив буде сформирован случайным образом из тестовых к заданию.");
    Console.WriteLine("2. Введите числе элементов (цифра), тога далее будет поэлементно запрошен массив.");
    Console.WriteLine("3. Введите полностью массив в строке, используя ';' как разделитель элементов");
    string inputUser=Console.ReadLine()!;
    if (inputUser==string.Empty) Console.WriteLine("пустой ввод");
}
