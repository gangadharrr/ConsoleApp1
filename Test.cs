﻿using System;

namespace ConsoleApp1
{
    
    public class Class1
    {
        private class PrivateClass
        {
             internal PrivateClass()
            {
                Console.WriteLine("Private Class");
            }
        }
        private protected class PrivateProtectedClass
        {
            internal PrivateProtectedClass()
            {
                Console.WriteLine("Private Protected Class");
            }
        }
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }
        public void method2()
        {
            Console.WriteLine("Test1");
            Class1 cls = new Class1();
            PrivateClass obj=new PrivateClass();
            cls.PrivateMethod();

        }
        protected class ProtectedClass
        {
            public ProtectedClass() 
            {
                Console.WriteLine("Protected Class");
            }

        }  
        protected internal class ProtectedInternalClass
        {
            public ProtectedInternalClass() 
            {
                Console.WriteLine("Protected Internal Class");
            }

        }
    }
    
    public class Class2:Class1
    {
        public Class2(){
        //PrivateClass obj = new PrivateClass(); //error
            PrivateProtectedClass privateProtectedClass = new PrivateProtectedClass();
            ProtectedClass pc=new ProtectedClass();
            
        }
    }
}
