﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCache.Abstractions
{
    public interface IAdvancedCache: IEnumerable, IDisposable
    {
        void AddEntry(string key, object value, TimeSpan? validUntil);
        void RemoveEntry(string key);
        void ClearEntries();
        bool TryGetValue<T>(string key, out T value);
        int Count();
        T GetValue<T>(string key, T defaultValue);
    }
}
