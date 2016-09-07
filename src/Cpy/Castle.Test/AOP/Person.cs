using System;

namespace Castle.Test.AOP
{
    public class Person
    {
        /// <summary>
        /// 必须声明为virtual类型，才能实现AOP
        /// </summary>
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}