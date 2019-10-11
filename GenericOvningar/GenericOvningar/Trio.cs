namespace GenericOvningar
{
    public class Trio<T> where T : Animal
    {
        public T PRI { get; set; }
        public T DUO { get; set; }
        public T TRI { get; set; }
    }
}