using System;
using Castle.DynamicProxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Castle.Test.AOP
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Main()
        {
            
        }


        /// <summary>
        /// 简单代理
        /// </summary>
        public void SampleProxy()
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】 
            SimpleInterceptor interceptor = new SimpleInterceptor();//实例化【拦截器】

            var person = generator.CreateClassProxy<Person>(interceptor);

            Console.WriteLine("当前类型:{0},父类型:{1}", person.GetType(), person.GetType().BaseType);

            person.SayHello();
            person.SayHi();

        }

        /// <summary>
        /// 使用接口代理
        /// </summary>
        public void InterfaceProxy()
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】 
            SimpleInterceptor interceptor = new SimpleInterceptor();//实例化【拦截器】

            var login = new PersonLogin();
            login=generator.CreateInterfaceProxyWithTarget(login, interceptor);
            login.Save();
        }

        /// <summary>
        /// 多重代理
        /// 输出结果为：张三李三李四张四，
        /// Pre Post正好相反
        /// </summary>
        public void MutleProxy()
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】 
            SimpleInterceptor interceptor = new SimpleInterceptor();//实例化【拦截器】
            MyInerceptor myi = new MyInerceptor();

            var login = new PersonLogin();
            login = generator.CreateInterfaceProxyWithTarget(login, interceptor,myi);
            login.Save();
        }
    }
}