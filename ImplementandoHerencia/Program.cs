Shape s1 = new Shape();
Circle c1 = new Circle();
Rectangle r1 = new Rectangle();
Square sq1 = new Square(5.0);

Console.Clear();
Console.WriteLine(s1.ToString());
Console.WriteLine(c1.ToString());
Console.WriteLine(r1.ToString());
Console.WriteLine(sq1.ToString());

Console.WriteLine("Área del Cuadrado: " + sq1.GetArea());
Console.WriteLine("Perímetro del Cuadrado: " +  sq1.GetPerimeter());