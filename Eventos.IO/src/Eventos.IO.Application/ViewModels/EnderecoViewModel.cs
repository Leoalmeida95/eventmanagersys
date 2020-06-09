using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.IO.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        //não possui demais data annotations pois endereco não é obrigatório
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid EventoId { get; set; }

        public SelectList Estados()
        {
            return new SelectList(EstadosViewModel.ListarEstados(), "UF", "Nome");
        }

        public override string ToString()
        {
            return Logradouro + ", " + Numero + " - " + Bairro + ", " + Cidade + " - " + Estado;
        }
    }
}
