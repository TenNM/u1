using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace u1.DbModels
{
    public class AbstractEnt
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Boo { get; set; }
    }
}
