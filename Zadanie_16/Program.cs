Console.WriteLine("Выберите задание: ");
Console.WriteLine("Задание 1. Количество чётных чисел в массиве ");
Console.WriteLine("Задание 2. Cумма элементов, стоящих на нечётных позициях ");
Console.WriteLine("Задание 3. Разница между максимальным и минимальным элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
switch(n)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    case 3:
        Task3();
        break;
    default:
        break;
   
}



void Task1()
{
    Console.WriteLine("Введите длину массива: ");
    int lenght = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(EvenNumber(GetArray(lenght)));
}

void Task2()
{
    Console.WriteLine("Задайте длину массива: ");
    int lenght = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте левую границу массива: ");
    int Left_RANGER = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте правую границу массива: ");
    int Right_RANGER = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(oddIndex(GetRandomArray(lenght, Left_RANGER, Right_RANGER)));
}

void Task3()
{
    Console.WriteLine("Задайте длину массива: ");
    int lenght = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте левую границу массива: ");
    int Left_RANGER = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте правую границу массива: ");
    int Right_RANGER = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(realNumbers(GetRandomArray(lenght, Left_RANGER, Right_RANGER)));
}

int realNumbers (int[] array) // Разница между максимальным и минимальным элементов массива
{
    int max = array[0];
    int min = array[0];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]> max)
        {
            max = array[i];
        }
        else if (array[i]<min)
        {
            min = array[i];
        }
        array[i]++;
        // sum = min + max;
        sum = max - min;
    }
    return sum;
}

int[] GetRandomArray(int lenght, int Left_RANGER, int Right_RANGER) // Генерация случайных чисел в диапозоне, который задет пользователь по трем параметрам
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
        array[i] = new Random().Next(Left_RANGER, Right_RANGER + 1);
    Console.WriteLine(string.Join(",", array));
    return array;
}

int oddIndex (int[] array) // Сложение суммы чисел находящихся на нечетных позициях
{
    int OddNumberCount = 0;
    for (int i = 1; i < array.Length; i+=2)
        {
          OddNumberCount+=array[i];
        }
    return OddNumberCount;
}


int[] GetArray(int lenght) //Генерация случайного массива в диапозоне от 100 до 999
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
        array[i] = new Random().Next(100, 1000);
    Console.WriteLine(string.Join(",", array));
    return array;
}

int EvenNumber (int[] array) // Подсчет четных чисел в массиве
{
    int EvenNumberCount = 0;
        for (int i = 0; i < array.Length; i++)
            if(array[i]%2==0)
                {
                EvenNumberCount++;
                }
            else 
            array[i]++;
        return EvenNumberCount;
}


