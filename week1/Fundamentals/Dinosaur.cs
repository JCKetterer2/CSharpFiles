using System;

namespace week1.Fundamentals
{
    public class Dinosaur
    {
        private string _teeth;
        private string _something;
        private int _size;

        protected string Color { set; get; } = "Green";  // set default color for Dinosaur, accessible to Dinosaur children

        public bool Skin { set; get; }

        public int Size 
        { 
            set
            {
                this._size = value;
            }

            get
            {
                if( _size > 200 )
                {
                    Console.WriteLine("Huge");
                }
                return _size;
            }
        } 

        public string Teeth
        {
            set
            {
                this._teeth = value;
            }

            get
            {
                return _teeth;
            }
        }

        //method is defined as virtual so it can be overridden in child class (polymorphism)
        public virtual void Eat()
        {
            Console.WriteLine("Eat");
        }

        //inner child class of Dinosaur (inheritance)
        public class Raptor : Dinosaur
        {
            public void Group()
            {
                Color = "Brown";
            }
        }        
    }


    //child class of Dinosaur (inheritance)
    public class TRex : Dinosaur
    {
        public void Stomp()
        {
            Color = "Blue";
        }

        public override void Eat()
        {
            Console.WriteLine("Rip");
        }
    }
}