
//// Errado - Interface grande com métodos não utilizados
//public interface IWorker
//{
//    void Work();
//    void Eat();
//    void Sleep();
//}

//public class Programmer : IWorker
//{
//    public void Work() { }
//    public void Eat() { }
//    public void Sleep() { }
//}


// Correto - Interfaces segregadas para contextos diferentes
public class Programmer : IWorker, IEater, ISleeper
{
    public void Work() { }
    public void Eat() { }
    public void Sleep() { }
}
