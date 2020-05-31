using Eventos.IO.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Models
{
    public class Evento : Entity
    {
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Gratuito { get; set; }
        public decimal Valor { get; set; }
        public bool Online { get; set; }
        public string NomeEmpresa { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public Endereco Endereco { get; set; }
        public Organizador Organizador { get; set; }
    }
}
