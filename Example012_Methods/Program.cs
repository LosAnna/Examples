//Вид 1
void Method1()
{
    Console.WriteLine("Автор . . . ");
}
//Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method5(10, "текст");
//Console.WriteLine(res);

//с использованием цикла for
string Method5(int count, string text)
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string result = Method5(10, "текст");
//Console.WriteLine(res);

//таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
//
//
//


//Упорядочить массив от наименьшего к большему
int[] arr = { 1, 5, 4, 3, 2, 6, 7 , 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
              minPosition = j;  
            }
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition = temporary];
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);