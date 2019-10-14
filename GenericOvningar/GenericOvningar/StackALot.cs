using System.Collections.Generic;

namespace GenericOvningar
{
    internal class StackALot<T>
    {

        List<T> list = new List<T>();

        public void Push(T t)
        {
            list.Add(t);
        }
        public T Pop()
        {
            var objectReturn = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return objectReturn;
        }
    }
}