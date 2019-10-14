namespace GenericOvningar
{
    public class Trio<T> where T : Animal
    {
        public Fordon PRI { get; set; }
        public Fordon DUO { get; set; }
        public Fordon TRI { get; set; }
    }
}