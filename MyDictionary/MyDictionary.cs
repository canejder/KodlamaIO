namespace MyDictionary
{
    public class MyDictionary<Tkey,Tvalue>
    {
        private Tkey[] _keys;
        private Tvalue[] _values;
        
        public Tkey[] Keys
        {
            get { return _keys; }
        }
        public Tvalue[] Values
        {
            get { return _values; }
        }

        private Tkey[] _tempKeys;
        private Tvalue[] _tempValues;

        public int Count
        {
            get { return Keys.Length; }
        }
        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];
        }
        
        public void Add(Tkey key, Tvalue value)
        {
            _tempKeys = _keys;
            _tempValues = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tvalue[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }
    }
}