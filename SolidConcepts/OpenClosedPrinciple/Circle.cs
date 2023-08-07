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

public class Circle : IShape
{
public double Radius { get; set; }

public double CalculateArea()
{
    return Math.PI * Radius * Radius;
}
}
