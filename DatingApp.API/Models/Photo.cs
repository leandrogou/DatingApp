using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public DateTime DatadeAdicao { get; set; }
        public bool Principal { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}