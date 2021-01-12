using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public interface ICharacter
    {
        string Name { get; }
        int Age { get; }
        string MainCharacteristic();
        string Quote();
    }
}

