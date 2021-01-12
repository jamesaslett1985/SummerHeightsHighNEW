using Code.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    class SummerHeightsHighService
    {
        public static Dictionary<string, ICharacter> Characters = new Dictionary<string, ICharacter>
        {
            ["Ja'Mie"] = new JaMie(),
            ["Jonah"] = new Jonah(),
            ["Mr G"] = new MrG(),
        };

        public static string[] ReturnCharacter(ICharacter character)
        {
            var chosenCharacter = new CharacterInfo(character);
            return chosenCharacter.ReturnCharacterInfo();
        }
    }
}

