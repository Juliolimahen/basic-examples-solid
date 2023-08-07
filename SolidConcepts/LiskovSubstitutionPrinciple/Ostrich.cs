
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
public class Ostrich : IBird
{
    public void Fly()
    {
        // Ostriches can't fly, but implementing the method is not required by IBird
    }
}
