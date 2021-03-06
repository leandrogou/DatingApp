using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public string Apelido { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime UltimoLogin { get; set; }
        public string Introducao { get; set; }
        public string ProcurandoPor { get; set; }
        public string Interesses { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public ICollection<Photo> Photos { get; set; }

    }
}