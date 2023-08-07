namespace DependencyInversionPrinciple;

//// Errado - Alta dependência em classes concretas
//public class LightBulb
//{
//    public void TurnOn() {  }
//    public void TurnOff() { }
//}

//public class Switch
//{
//    private LightBulb bulb = new LightBulb();

//    public void Toggle()
//    {
//        if (true)
//            bulb.TurnOn();
//        else
//            bulb.TurnOff();
//    }
//}

// Correto - Inversão de dependência com interfaces
public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}
