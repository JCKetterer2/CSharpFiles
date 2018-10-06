using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using week1.Fundamentals;

namespace week1.Advanced
{
    public class CollectionExamples
    {
        public void MyArrayListExample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("World");
            arrayList.Add(45);

            Console.WriteLine("Count = " + arrayList.Count);

            arrayList.RemoveAt(1);  //remove World

            foreach (Object obj in arrayList)
            {
                Console.WriteLine("type = " + obj);
            }
        }

        public void MyListExample()
        {
            List<Dinosaur> myDinos = new List<Dinosaur>();
            myDinos.Add(new Dinosaur() { Size = 50, Teeth = "Serrated", Skin = true });
            myDinos.Add(new Pterodactyl() { Size = 25, Teeth = "Sharp" });
            myDinos.Add(new Dinosaur.Raptor() { Size = 10, Teeth = "Serrated", Skin = false });

            foreach (Dinosaur dinosaur in myDinos)
            {
                //Console.WriteLine(dinosaur);
                Console.WriteLine(dinosaur.Size);
            }
        }
    }
}