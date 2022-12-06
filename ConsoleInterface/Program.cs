var shapes = new List<IShape>()
{
    new Circle() { Radius = 10.5 },
    new Triangle() { SideA = 3, SideB = 4, SideC = 5 }, //прямоугольный треугольник
    new Circle() { Radius = 4 },
    new Triangle() { SideA = 5, SideB = 4, SideC = 8 }
};

foreach (var shape in shapes)
{
    Console.WriteLine($"Фигура {shape.GetType()}. Площадь {shape.GetSquare()}");
}



Console.ReadLine();


//
//Тестовое задание 2 лежит в отдельном файлике в этом проекте Task2.txt
//