namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer Q1
            // Generic means writing a class, method, or interface that can work with different data types without rewriting the code for each type.
            // Why?
            // Type save, Reusable, Better performance, Cleaner Code
            #endregion

            #region answer Q3
            // multiple type parameters ==> generic class can have more than one type parameter. 
            #endregion

            #region constraint

            #region answer Q7
            /*
            Struct constraint ==> means that the generic type T must be a value type
            ex:
            class Container<T> where T : struct
            {
                public T Value { get; set; }
            }
            */
            #endregion

            #region answer Q8
            /*
            Class constraint ==> means that the generic type T must be a ref type
            ex:
            class Container<T> where T : class
            {
                public T Value { get; set; }
            }
            */
            #endregion

            #endregion


        }

        #region answer Q4
        public static void Swap<T>(ref T a, ref T b)
        {
            T Temp = a;
            a = b;
            b = Temp;
        }
        #endregion

        #region answer Q5
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b; return a;
    
        }
        #endregion

        #region answer Q6
        // A generic interface ==> interface that uses a type parameter T,
        // allowing it to define methods or properties that work with different data types
        interface IRepository<T>
        {
            void Add(T item);
            T Get(int id);
            void Delete(int id);
        }
        #endregion

    }
}
