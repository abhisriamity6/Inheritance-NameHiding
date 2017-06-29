using System;

namespace Inheritance_NameHiding
{
    class A
    {
        public int i = 0;
    }
    class B : A
    {
        new int i;
       public B(int val)
        {
            i = val;
        }
        public void Show()
        {
            Console.WriteLine("i in derived class: " + i);
        }
    }
    class Demo
    {
       static void Main()
        {
            B obj = new B(2);
            obj.Show();
            Console.Read();

        }


    }
}
