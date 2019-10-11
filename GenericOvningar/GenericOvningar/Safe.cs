namespace GenericOvningar
{
    public class Safe<T>
    {
        public T Object { get; set; }

        public Safe()
        {
        }

        public void Store(T value)
        {
            Object = value;
        }

        public T Retrieve()
        {
            return Object;
        }
    }
}