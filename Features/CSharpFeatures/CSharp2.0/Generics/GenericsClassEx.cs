using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp2._0.Generics
{
    public class GenericsList<T>
    {
        public void Add(T input) { }

    }


    public class TestGenericList
    {
        public class SampleClass { }
        static void Main()
        {
         
            GenericsList<String> list1=new GenericsList<String>();

            list1.Add("Hii, man");
            list1.Add("Hello");

            
            GenericsList<int> list2=new GenericsList<int>();

            list2.Add(1);
            list2.Add(2);


            GenericsList<SampleClass> list3 = new GenericsList<SampleClass>();

            list3.Add(new SampleClass());



        }
    }


}
