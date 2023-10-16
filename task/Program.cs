
Console.Write("Введите элементы массива, разделенные пробелами: ");
string input = Console.ReadLine();
string[] inputArray = input.Split(' ');

string[] resultArray = FilterShortStrings(inputArray);

Console.WriteLine("Результат:");
foreach (string str in resultArray)
{
    Console.WriteLine(str);
}

static string[] FilterShortStrings(string[] inputArray)
{
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;

    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            resultArray[index] = str;
            index++;
        }
    }

    return resultArray;
}
