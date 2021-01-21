using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Code;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Website.Models
{

    public class Characters
    {
        public int CharacterList { get; set; }
        public List<SelectListItem> SelectableCharacters { get; set; }
    }
}

