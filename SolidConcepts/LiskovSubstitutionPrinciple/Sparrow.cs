
//// Errado - Violação do LSP
//public class Bird
//{
//    public virtual void Fly() { /* ... */ }
//}

//public class Ostrich : Bird
//{
//    public override void Fly()
//    {
//        // Ostriches can't fly, violating LSP
//    }
//}

// Correto - Respeita o LSP

public class Sparrow : IBird
{
    public void Fly() { /* ... */ }
}
