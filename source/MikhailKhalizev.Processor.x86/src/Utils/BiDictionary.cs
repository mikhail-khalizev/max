using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.Utils
{
    [Serializable]
    [DebuggerDisplay("Count = {" + nameof(Count) + "}")]
    public sealed class BiDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;
        private readonly Dictionary<TValue, TKey> _inverseDictionary;

        public BiDictionary()
        {
            _dictionary = new Dictionary<TKey, TValue>();
            _inverseDictionary = new Dictionary<TValue, TKey>();
        }

        public BiDictionary(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
        {
            _dictionary = new Dictionary<TKey, TValue>(keyComparer ?? EqualityComparer<TKey>.Default);
            _inverseDictionary = new Dictionary<TValue, TKey>(valueComparer ?? EqualityComparer<TValue>.Default);
        }

        public BiDictionary(int capacity)
        {
            _dictionary = new Dictionary<TKey, TValue>(capacity);
            _inverseDictionary = new Dictionary<TValue, TKey>(capacity);
        }

        public BiDictionary(IDictionary<TKey, TValue> source)
        {
            _dictionary = new Dictionary<TKey, TValue>(source);
            _inverseDictionary = _dictionary.ToDictionary(entry => entry.Value, entry => entry.Key);
        }

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;

        public ICollection<TKey> Keys => _dictionary.Keys;

        public TValue this[TKey key]
        {
            get => _dictionary[key];
            set
            {
                _dictionary.TryGetValue(key, out var oldValue);

                _dictionary[key] = value;

                if (oldValue != null)
                    _inverseDictionary.Remove(oldValue);

                _inverseDictionary[value] = key;
            }
        }

        public ICollection<TValue> Values => _dictionary.Values;

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _dictionary.Clear();
            _inverseDictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item) => _dictionary.Contains(item);

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((IDictionary<TKey, TValue>) _dictionary).CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (!((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Remove(item))
                return false;

            _inverseDictionary.Remove(item.Value);
            return true;
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);

            try
            {
                _inverseDictionary.Add(value, key);
            }
            catch
            {
                _dictionary.Remove(key);
                throw;
            }
        }

        public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);

        public bool Remove(TKey key)
        {
            if (!_dictionary.TryGetValue(key, out var value))
                return false;

            _dictionary.Remove(key);
            _inverseDictionary.Remove(value);
            return true;
        }

        public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value);

        public IEnumerator GetEnumerator() => ((IEnumerable<KeyValuePair<TKey, TValue>>) this).GetEnumerator();

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() =>
            _dictionary.GetEnumerator();

        public bool ContainsValue(TValue value) => _inverseDictionary.ContainsKey(value);

        public TKey GetKey(TValue value) => _inverseDictionary[value];

        public TKey GetKeyOrDefault(TValue value, TKey defaultValue = default)
        {
            if (_inverseDictionary.TryGetValue(value, out var key))
                return key;
            return defaultValue;
        }

        public bool TryGetKey(TValue value, out TKey key) => _inverseDictionary.TryGetValue(value, out key);

        public TValue GetValueOrDefault(TKey key, TValue defaultValue = default)
        {
            if (_dictionary.TryGetValue(key, out var value))
                return value;
            return defaultValue;
        }
    }
}