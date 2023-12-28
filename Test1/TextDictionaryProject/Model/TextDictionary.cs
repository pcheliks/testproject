using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDictionaryProject.Model
{
    public class TextDictionary
    {
        [Key]
        public int id { get; set; }

        public string Word { get; set; }
    }

}
