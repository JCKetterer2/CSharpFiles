using System;

namespace week1.week3
{
    /*
        Access Modifiers allow a class, field or method to limit there accessibility.
        Private is the default if no identifier is used. For readability, it is recommended
        that you call it private.
     */
    public class AccessModifiers
    {
        /*
            Public - Full accessible, Implicit for members of an enum or interface.
            Static - Declares a member that belongs to the type itself instead of to a specific object.
         */
        public static int StaticMod = 10;

        /*
            Public - Full accessible, Implicit for members of an enum or interface.
         */
        public string TestString = "public normal string";

        /*
            Public - Full accessible, Implicit for members of an enum or interface.
            Readonly - Declares a field that can only be assigned values as part of the declaration or in a constructor in the same class.
         */
        public readonly string TestModifier = "read only used";

        /*
            Internal - Accessible in the containing or friend assemblies.
         */
        internal string _testStringInternal = "internal string";

        /*
            Protected - Only accessible within the containing type or subclass.
            Internal - Accessible in the containing or friend assemblies.
            Protected Internal - A union of accessibility where everything is private as possible with additional modifiers
            would add additional accessibility
         */
        protected internal string TestString4 = "protected internal string";

        /*
            Protected - Only accessible within the containing type or subclass.
         */
        protected string TestString3 = "protected normal string";

        /*
            Private - Accessible only within the containg type.
         */
        private string _testString2 = "private normal string";

        /*
            Private - Accessible only within the containg type.
            Const - Specifies that the value of the field or the local variable cannot be modified.
         */
        private const int _constantMod = 20;

        /*
            A readonly field can be initialized either at declaration or in a constructor
            Public - Full accessible, Implicit for members of an enum or interface.
         */
        public AccessModifiers(string type)
        {
            TestModifier = type;
            Console.WriteLine(TestModifier);
        }

        public AccessModifiers()
        {
            Console.WriteLine("Default Constructor");
            // Creating an instance of the inner class
            AdditionalModifiers modifiers = new AdditionalModifiers();
            // modifiers.MyAdditonMethod(); // Cannot call its private method.
            modifiers.MyPublicMethod();
        }

        public void IndexerExample()
        {
            string show = "hello world";
            Console.WriteLine(show[3]); // l
            // Shows l
            string noShow = null;
            Console.WriteLine(noShow?[0]);
            // Show nothing no error
        }

        /*
            Private method is only used within its class and is not accessible everywhere else.
         */
        private void SomeMethod(string type)
        {
            Console.WriteLine(type);
        }

        /*
            Protected method - Only accessible within the containing type or subclass.
         */
        protected void SomeOtherMethod(string type)
        {
            Console.WriteLine(type);
        }

        protected virtual void MyMethod()
        {
            Console.WriteLine("test");
        }

        protected virtual void MySecond()
        {
            Console.WriteLine("test second");
        }



        /*
            Nested or Inner class. 
            When a class is marked sealed, you can not inherit from it          
         */
        private sealed class AdditionalModifiers : AccessModifiers
        {

            public void MyPublicMethod()
            {
                MyAdditonMethod();
            }

            private void MyAdditonMethod()
            {
                // Because this is an inner class, you can access even private methods
                SomeMethod("Happy");
                // Because this is an inner class, you can access even protected methods
                SomeOtherMethod("Joy");
            }

            /*
                You can use the sealed modifier on a method or property that overrides
                a virtual method or property in a base class.
                When a method or property is marked sealed, you can not override it
             */
            sealed protected override void MyMethod()
            {
                Console.WriteLine("my test");
            }

            protected override void MySecond()
            {
                Console.WriteLine("my test second");
            }

        }

        private class SomeOtherModifiers
        {
            
        }

    }

}