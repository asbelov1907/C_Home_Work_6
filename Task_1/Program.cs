// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] InputNumbers()
{
    Console.WriteLine("Сколько планируете ввести чисел?");
    int SizeNumbers = int.Parse(Console.ReadLine());

    int[] Array = new int[SizeNumbers];
    Console.WriteLine("Введите " + SizeNumbers + " чисел/ла. После каждого введенного числа нажимайте Enter.");
    for (int i = 0; i < SizeNumbers; i++)
    {
        Array[i] = int.Parse(Console.ReadLine());

    }
    return Array;

}

void result(int[] arr)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            res++;
    }
    Console.WriteLine("Чисел больше 0: " + res);
}

int[] arr = InputNumbers();
result(arr);

