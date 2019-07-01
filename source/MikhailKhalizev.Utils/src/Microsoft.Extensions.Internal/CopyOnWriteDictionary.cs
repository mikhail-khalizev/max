// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace MikhailKhalizev.Utils.Microsoft.Extensions.Internal
{
    public class CopyOnWriteDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly IEqualityComparer<TKey> _comparer;
        private readonly IDictionary<TKey, TValue> _sourceDictionary;
        private IDictionary<TKey, TValue> _innerDictionary;

        public CopyOnWriteDictionary(
            IDictionary<TKey, TValue> sourceDictionary,
            IEqualityComparer<TKey> comparer)
        {
            if (sourceDictionary == null)
                throw new ArgumentNullException(nameof(sourceDictionary));

            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            _sourceDictionary = sourceDictionary;
            _comparer = comparer;
        }

        public virtual int Count => ReadDictionary.Count;

        public virtual bool IsReadOnly => false;

        public virtual ICollection<TKey> Keys => ReadDictionary.Keys;

        public virtual ICollection<TValue> Values => ReadDictionary.Values;

        public virtual TValue this[TKey key]
        {
            get => ReadDictionary[key];
            set => WriteDictionary[key] = value;
        }

        private IDictionary<TKey, TValue> ReadDictionary => _innerDictionary ?? _sourceDictionary;

        private IDictionary<TKey, TValue> WriteDictionary
        {
            get
            {
                if (_innerDictionary == null)
                    _innerDictionary = new Dictionary<TKey, TValue>(_sourceDictionary,
                        _comparer);

                return _innerDictionary;
            }
        }

        public virtual void Add(KeyValuePair<TKey, TValue> item)
        {
            WriteDictionary.Add(item);
        }

        public virtual void Clear()
        {
            WriteDictionary.Clear();
        }

        public virtual bool Contains(KeyValuePair<TKey, TValue> item) => ReadDictionary.Contains(item);

        public virtual void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ReadDictionary.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item) => WriteDictionary.Remove(item);

        public virtual bool ContainsKey(TKey key) => ReadDictionary.ContainsKey(key);

        public virtual void Add(TKey key, TValue value)
        {
            WriteDictionary.Add(key, value);
        }

        public virtual bool Remove(TKey key) => WriteDictionary.Remove(key);

        public virtual bool TryGetValue(TKey key, out TValue value) => ReadDictionary.TryGetValue(key, out value);

        public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => ReadDictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}