using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Characters
{
    public class Jonah : ICharacter
    {
        public string Name => "Jonah";

        public int Age => 13;
        public string MainCharacteristic()
        {
            return "Rebellious";
        }
        public string Quote()
        {
            return "I don’t even care if you send me back to Tonga. There’s mad break-dancers in Tonga.";
        }
    }
}
