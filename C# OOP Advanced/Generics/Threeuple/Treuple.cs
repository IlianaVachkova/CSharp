namespace ThreeupleImplementation
{
    public class Treuple<K, V1, V2>
    {
        public Treuple(K key, V1 value1, V2 value2)
        {
            this.Key = key;
            this.Value1 = value1;
            this.Value2 = value2;
        }
        public K Key { get; private set; }

        public V1 Value1 { get; private set; }

        public V2 Value2 { get; private set; }

        public override string ToString()
        {
            return this.Key + " -> " + this.Value1 + " -> " + this.Value2;
        }
    }
}
