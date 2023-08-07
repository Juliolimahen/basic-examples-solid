using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

public class Switch
{
    private ISwitchable device;

    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Toggle()
    {
        if (true)
            device.TurnOn();
        else
            device.TurnOff();
    }
}
