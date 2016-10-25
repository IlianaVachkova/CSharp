namespace GenericBox
{
    public class Box<T>
    {
        public Box(T data)
        {
            this.Data = data;
        }

        public T Data { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Data.GetType().FullName, this.Data);
        }
    }
}