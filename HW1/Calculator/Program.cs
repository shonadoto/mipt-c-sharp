Console.WriteLine("=== Калькулятор ===");
Console.WriteLine("Введите 'q' для выхода.\n");

while (true)
{
    Console.Write("Введите первое число: ");
    string? input1 = Console.ReadLine();
    if (input1?.Trim().ToLower() == "q") break;

    if (!decimal.TryParse(input1, out decimal a))
    {
        Console.WriteLine("Ошибка: некорректное число. Попробуйте снова.\n");
        continue;
    }

    Console.Write("Введите второе число: ");
    string? input2 = Console.ReadLine();
    if (input2?.Trim().ToLower() == "q") break;

    if (!decimal.TryParse(input2, out decimal b))
    {
        Console.WriteLine("Ошибка: некорректное число. Попробуйте снова.\n");
        continue;
    }

    Console.Write("Выберите операцию (+, -, *, /): ");
    string? op = Console.ReadLine()?.Trim();
    if (op?.ToLower() == "q") break;

    decimal result = 0;
    switch (op)
    {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "*":
            result = a * b;
            break;
        case "/":
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.\n");
            }
            else
            {
                result = a / b;
            }
            break;
        default:
            Console.WriteLine("Ошибка: неизвестная операция. Используйте +, -, *, /.\n");
            break;
    }

    Console.WriteLine($"Результат: {a} {op} {b} = {result}\n");
}

Console.WriteLine("До свидания!");
