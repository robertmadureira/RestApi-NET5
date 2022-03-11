using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestASPNET.Model
{
    [Table("person")] // serve para achar a tabela no banco 
    public class Person
    {
        [Column("id")] // serve para achar a coluna no banco 
        public long Id { get; set; }

        [Column("fist_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("adress")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

    }
}
