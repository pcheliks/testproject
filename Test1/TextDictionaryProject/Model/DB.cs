using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDictionaryProject.Model
{
    public class DB : DbContext
    {
        public DB()
            : base("DbConnection")
        {
            Database.CreateIfNotExists();

            if (!Words.Any())
            {
                Words.AddRange(new List<TextDictionary>() { new TextDictionary { Word = "Пока" }, new TextDictionary { Word = "Покараю" }, new TextDictionary { Word = "Никита" }, new TextDictionary { Word = "Никровил" } });

                SaveChanges();
            }
        }

        public DbSet<TextDictionary> Words { get; set; }
    }

}
