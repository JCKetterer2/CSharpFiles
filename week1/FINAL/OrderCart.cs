using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using week1.Fundamentals;

namespace week1.FINAL
{
    public class OrderCart
    {
        /*
        public void MyOrderCart()
        {
            ArrayList myOrder = new ArrayList();
            myOrder.Add(GadgetLarge);
            

            Console.WriteLine("Count = " + myOrder.Count);

            foreach (Object obj in myOrder)
            {
                Console.WriteLine("type = " + obj);
            }
        }
        */

        
       
        public void MyOrderCart()
        {
            List<Widget> myWidgets = new List<Widget>();
            myWidgets.Add(new WidgetSmall());
            myWidgets.Add(new WidgetMedium());

            foreach (Widget myStuff in myWidgets)
            {
                //Console.WriteLine(dinosaur);
                Console.WriteLine("My Order = " + myStuff);
            }

            /*
            List<Dinosaur> myDinos = new List<Dinosaur>();
            myDinos.Add(new Dinosaur() { Size = 50, Teeth = "Serrated", Skin = true });
            myDinos.Add(new Pterodactyl() { Size = 25, Teeth = "Sharp" });
            myDinos.Add(new Dinosaur.Raptor() { Size = 10, Teeth = "Serrated", Skin = false });

            foreach (Dinosaur dinosaur in myDinos)
            {
                //Console.WriteLine(dinosaur);
                Console.WriteLine(dinosaur.Size);
            } 
            */
        }
        
    }
}
