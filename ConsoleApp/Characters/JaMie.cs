using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Characters
{
    public class JaMie : ICharacter
    {
        public string Name => "Ja'Mie";
        public int Age => 16;
        public string MainCharacteristic()
        {
            return "Snobbish";
        }
        public string Quote()
        {
            return "I love your bins. They’re so random.";
        }
    }
}
