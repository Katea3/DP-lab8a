int[] array = new int[3]; // Создаём массив из 3 элементов
int sum = 0;              // Переменная для подсчёта суммы

// Цикл ввода чисел пользователем
for (int i = 0; i < array.Length; i++)
{
    while (true) // Защищённый ввод — повторяем, пока пользователь не введёт число >= 2
    {
        Console.WriteLine($"Введите число №{i + 1}");
        string number = Console.ReadLine()!; // Читаем строку

        // Проверяем, что введено число и оно >= 2
        if (int.TryParse(number, out int num) && num >= 2)
        {
            array[i] = num; // Записываем число в массив
            break;          // Выходим из внутреннего while
        }
        else
        {
            // Сообщение об ошибке при некорректном вводе
            Console.WriteLine("Введите число которое больше 2");
        }
    }
}

// Подсчёт суммы всех чисел массива
foreach (int num in array)
{
    sum += num;
}

// Вывод результата
Console.WriteLine($"Сумма чисел равна: {sum}");
