using System.Numerics;
using System.Reflection.Metadata;

namespace Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics ?
            //Answer: Generic class is a class that doesn't use a specifi data type, use it because it provide reusability not  duplicate the same code with defferent data types.
            #endregion

            #region Q2
            //Q2 : Write a generic class Container<T> with Add and Get methods.
            //Container<int> container = new Container<int>();
            //container.Add(1);
            //Console.WriteLine(container.Get());
            #endregion

            #region Q3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //Answer: Generic class can have more than one type paramter
            #endregion

            #region Q4
            //Q4: What is a generic method? Write Swap < T > method.
            //is a method take paramter of any type
            //int x = 3;
            //int y = 6;
            //container.Swap(ref x, ref y);
            //Console.WriteLine($"{x} , {y}");
            #endregion

            #region Q5
            //Q5: Write a generic method FindMax < T > that finds maximum value
            //Container<int> container = new Container<int>();
            //Console.WriteLine(container.FindMax(10, 12));
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.
            //Answer: is an inteface that uses a type paramter.
            #endregion

            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            //Answer: it means that T must be a value type of struct not class
            //class Test<T> where T: struct{}
            //Test<int> test = new Test<int>();
            #endregion

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            //Answer: it means that T must be a class
            //Class Test<T> wher T: class{}
            //Test<string> test = new Test<string>();
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            //Answer: it means the T must have a public paramterless constructor
            //class product<T> where T: new(){}
            //class customer
            //{
            //  public Customer(){}
            //}
            //product<customer> product = new product<customer>();

            #endregion

            #region Q10
            //Q10: What is the interface constraint? Write an example.
            //Answer: it mean that T must implement a specific interface
            //I create generic printer class, any type used as T must implement Iprintable
            #endregion

            #region Q11
            //Q11: What is the base class constraint? Write an example.
            //Answer: it means that T must inherit from a specific base class
            //AnimalContainer<Dog> animalContainer = new AnimalContainer<Dog>();
            #endregion

            #region Q12
            //Q12: How do you apply multiple constraints? Write an example.
            //Answer: by using comma
            //class Test<T> where T: Animal, Iprintable, new(){}
            #endregion

            #region Q13
            //Q13: What does the 'default' keyword do in generics?
            //Answer: return the default value of the type T
            #endregion

            #region Q14
            //Q14: Write a SafeList < T > that returns default when the index is invalid
            SafeList<int> safeList = new SafeList<int>();
            safeList.Add(1);
            safeList.Add(2);
            safeList.Add(3);
            safeList.Add(4);
            Console.WriteLine(safeList.Get(5)); // 0 default value of int

            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Answer: means the type paramter is used for output
            #endregion

            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Answer: means the type paramter is used for input
            #endregion

            //Q17: What is the difference between covariance and
            //contravariance?

            //Q18: How do static members work in generic types?
            //Q19: How can you inherit from a generic class?
            //Q20: Complete Exercise -Create a generic Cache < TKey,
            //TValue>with Add, Get, Remove, Contains, and expiration support.
        }
    }
}
