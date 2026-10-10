using System;

namespace PrototypePattern;

using System.Collections.Generic;

public class PrototypeManager
{
    private Dictionary<string, IPrototype> _prototypes = new();

    public void AddPrototype(string key, IPrototype prototype)
    {
        _prototypes[key] = prototype;
    }

    public IPrototype GetClone(string key)
    {
        if (_prototypes.ContainsKey(key))
        {
            return _prototypes[key].Clone();
        }
        return null;
    }
}

