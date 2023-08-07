namespace OpenClosedPrinciple;

//// Errado - Modificando a classe existente
//public class Circle
//{
//    public double Radius { get; set; }
//}

//public class AreaCalculator
//{
//    public double CalculateArea(Circle circle)
//    {
//        return Math.PI * circle.Radius * circle.Radius;
//    }
//}

// Correto - Extensão sem modificar a classe existente

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
