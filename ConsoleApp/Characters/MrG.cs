using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Characters
{
    public class MrG : ICharacter
    {
        public string Name => "Mr G";
        public int Age => 37;
        public string MainCharacteristic()
        {
            return "Egomaniacal";
        }
        public string Quote()
        {
            return "I tend to do the 'wow' shows and every second year we do the traditionals.";
        }
    }
}
