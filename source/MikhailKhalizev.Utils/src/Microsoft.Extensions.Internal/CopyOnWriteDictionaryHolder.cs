// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace MikhailKhalizev.Utils.Microsoft.Extensions.Internal
{
    public struct CopyOnWriteDictionaryHolder<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _source;
        private Dictionary<TKey, TValue> _copy;

        public CopyOnWriteDictionaryHolder(Dictionary<TKey, TValue> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            _source = source;
            _copy = null;
        }

        public CopyOnWriteDictionaryHolder(CopyOnWriteDictionaryHolder<TKey, TValue> source)
        {
            _source = source._copy ?? source._source;
            _copy = null;
        }

        public bool HasBeenCopied => _copy != null;

        public Dictionary<TKey, TValue> ReadDictionary
        {
            get
            {
                if (_copy != null)
                    return _copy;

                if (_source != null)
                    return _source;

                // Default-Constructor case
                _copy = new Dictionary<TKey, TValue>();
                return _copy;
            }
        }

        public Dictionary<TKey, TValue> WriteDictionary
        {
            get
            {
                if (_copy == null && _source == null)
                    _copy = new Dictionary<TKey, TValue>();
                else if (_copy == null)
                    _copy = new Dictionary<TKey, TValue>(_source, _source.Comparer);

                return _copy;
            }
        }

        public Dictionary<TKey, TValue>.KeyCollection Keys => ReadDictionary.Keys;

        public Dictionary<TKey, TValue>.ValueCollection Values => ReadDictionary.Values;

        public int Count => ReadDictionary.Count;

        public bool IsReadOnly => false;

        public TValue this[TKey key]
        {
            get => ReadDictionary[key];
            set => WriteDictionary[key] = value;
        }

        public bool ContainsKey(TKey key) => ReadDictionary.ContainsKey(key);

        public void Add(TKey key, TValue value)
        {
            WriteDictionary.Add(key, value);
        }

        public bool Remove(TKey key) => WriteDictionary.Remove(key);

        public bool TryGetValue(TKey key, out TValue value) => ReadDictionary.TryGetValue(key, out value);

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)WriteDictionary).Add(item);
        }

        public void Clear()
        {
            WriteDictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item) =>
            ((ICollection<KeyValuePair<TKey, TValue>>)ReadDictionary).Contains(item);

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)ReadDictionary).CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item) =>
            ((ICollection<KeyValuePair<TKey, TValue>>)WriteDictionary).Remove(item);

        public Dictionary<TKey, TValue>.Enumerator GetEnumerator() => ReadDictionary.GetEnumerator();
    }
}