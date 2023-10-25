﻿
namespace Tcc.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string? NomeUs { get; set; }
        public string? Email { get; set; }
        public string? Assunto { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataEnvio { get; set;  } = DateTime.Now;  
    }
}
