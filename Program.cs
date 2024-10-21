
class GeometricCalculator
{
    static void Main()
    {
        Console.WriteLine("Виберіть фігуру для обчислення:");
        Console.WriteLine("1. Круг");
        Console.WriteLine("2. Прямокутник");
        Console.WriteLine("3. Куб");
        Console.Write("Ваш вибір (1/2/3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateCircle();
                break;
            case 2:
                CalculateRectangle();
                break;
            case 3:
                CalculateCube();
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }
    }

    static void CalculateCircle()
    {
        Console.Write("Введіть радіус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        double volume = 0; // Об'єм не визначений для круга

        Console.WriteLine($"Площа круга: {area:F2}");
        Console.WriteLine($"Об'єм: {volume}");
    }

    static void CalculateRectangle()
    {
        Console.Write("Введіть ширину прямокутника: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть висоту прямокутника: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = width * height;
        double volume = 0; // Об'єм не визначений для прямокутника

        Console.WriteLine($"Площа прямокутника: {area:F2}");
        Console.WriteLine($"Об'єм: {volume}");
    }

    static void CalculateCube()
    {
        Console.Write("Введіть довжину сторони куба: ");
        double side = Convert.ToDouble(Console.ReadLine());

        double area = 6 * Math.Pow(side, 2);
        double volume = Math.Pow(side, 3);

        Console.WriteLine($"Площа поверхні куба: {area:F2}");
        Console.WriteLine($"Об'єм куба: {volume:F2}");
    }
}
