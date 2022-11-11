using System;
namespace u1.Models
{
    public class OneRecord
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool Boo { get; set; }

        public OneRecord(int id, string text, bool boo)
        {
            Id = id;
            Text = text;
            Boo = boo;
        }
    }
}

