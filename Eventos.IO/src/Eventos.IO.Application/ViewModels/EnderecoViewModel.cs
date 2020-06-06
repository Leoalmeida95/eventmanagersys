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
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

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
