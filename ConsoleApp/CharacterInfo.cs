using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class CharacterInfo
    {
        private readonly ICharacter _character;

        public CharacterInfo(ICharacter character)
        {
            _character = character;
        }
        public string[] ReturnCharacterInfo()
        {
            var age = "Age: " + _character.Age.ToString();
            var characteristic = "Main characteristic: " + _character.MainCharacteristic();
            var quote = "Favourite quote: " + "'" + _character.Quote() + "'";
            string[] all = { age, characteristic, quote };
            return all;
        }
    }
}
