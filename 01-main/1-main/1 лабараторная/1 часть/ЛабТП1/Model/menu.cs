using System;
using System.Collections.Generic;
using System.Text;

namespace ЛабТП1.Model
{
    public class menu
    {
        public List<interfacee> Menu = new List<interfacee>();
        public menu()
        {
            interfacee cake = new desert("пирог", 300, 200, 15, 250);
            interfacee icecream = new desert("ягодное мороженное", 300, 100, 5, 100);
            interfacee pie = new desert("чизкейк", 350, 250, 20, 250);
            interfacee chocolate = new desert("топленый шоколад", 100, 50, 5, 100);

            interfacee juice = new drink("сок", 150, 40, 10, 200);
            interfacee tea = new drink("чай", 100, 40, 10, 200);
            interfacee coffe = new drink("кофе", 200, 40, 10, 200);
            interfacee latte = new drink("латте", 200, 40, 10, 200);

            interfacee summer = new salat("летний", 360, 200, 15, 250);
            interfacee light = new salat("легкий", 300, 200, 15, 250);
            interfacee olivier = new salat("оливье", 300, 200, 15, 250);
            interfacee hot = new salat("теплый салат", 300, 200, 15, 250);

            interfacee pashtet = new coldsnack("паштет", 150, 40, 10, 200);
            interfacee karpacho = new coldsnack("карпаччо", 200, 40, 10, 200);
            interfacee balik = new coldsnack("балык", 90, 40, 10, 200);
            interfacee crackers = new coldsnack("сухарики", 300, 200, 10, 200);

            Menu.Add(cake);
            Menu.Add(icecream);
            Menu.Add(pie);
            Menu.Add(chocolate);
            Menu.Add(coffe);
            Menu.Add(tea);
            Menu.Add(juice);
            Menu.Add(latte);
            Menu.Add(summer);
            Menu.Add(light);
            Menu.Add(olivier);
            Menu.Add(hot);
            Menu.Add(pashtet);
            Menu.Add(karpacho);
            Menu.Add(balik);
            Menu.Add(crackers);
        }
    }
}
