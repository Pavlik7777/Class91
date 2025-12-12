//Лабораторная работа №9
//Классы и объекты
//Средний уровень, Вариант 22
//1
//Console.Write("Введите высоту:");
//Console.Write("Введите высоту:");
//double h = double.Parse(Console.ReadLine()!);
//Console.Write("Введите длину:");
//double w = double.Parse(Console.ReadLine()!);
//Console.Write("Введите ширину:");
//double s = double.Parse(Console.ReadLine()!);
//Parallelepiped par = new Parallelepiped(h, w, s);
//par.Print();
//class Parallelepiped
//{
//    private double height;
//    private double width;
//    private double shirina;
//    public Parallelepiped(double height, double width, double shirina)
//    {
//        this.height = height;
//        this.width = width;
//        this.shirina = shirina;
//    }
//    public double getHeight() { return height; }
//    public double getWidth() { return width; }
//    public double getShirina() { return shirina; }
//    public double getArea()
//    {
//        return 2 * (width * shirina + shirina * height + width * height);
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Площадь поверхности:{getArea()}");
//    }
//}

//2
Console.Write("Введите длину:");
double w = double.Parse(Console.ReadLine()!);
Console.Write("Введите ширину:");
double s = double.Parse(Console.ReadLine()!);
Console.Write("Введите высоту:");
double h = double.Parse(Console.ReadLine()!);
Parallelepiped lell = new Parallelepiped(w, h, s);
lell.Print();
class Parallelepiped
{
    private double width;
    private double height;
    private double shirina;
    public Parallelepiped(double width, double height, double shirina)
    {
        this.width = width;
        this.height = height;
        this.shirina = shirina;
    }
    public double getWidth() { return width; }
    public double getHeight() { return height; }
    public double getShirina() { return shirina; }
    public double getArea()
    {
        return 4 * (width + shirina + height);
    }
    public void Print()
    {
        Console.WriteLine($"Сумма длин всех ребер параллелепипеда:{getArea()}");
    }
}
