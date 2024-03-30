using System;


namespace TestShadowing
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public enum MyEnum
    {
        A, B, C
    }

    public class C
    {
        public void M(MyEnum parameter)
        {
            // error CS0841: Cannot use local variable 'MyEnum' before it is declared
            if (parameter == MyEnum.A)
            {
                return;
            }

            // Change the variable to 'myEnum' to avoid shadowing the 'MyEnum' type.
            // This change also aligns with the C# coding conventions.
            var MyEnum = parameter;
            Console.WriteLine(MyEnum.ToString());
        }
    }
}




