using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Dtos
{
    public class UserForDetailedDto
    {
                public int Id { get; set; }
        public string Username { get; set; }
        public string Sexo { get; set; }
        public int Age { get; set; }
        public string Apelido { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime UltimoLogin { get; set; }
        public string Introducao { get; set; }
        public string ProcurandoPor { get; set; }
        public string Interesses { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}