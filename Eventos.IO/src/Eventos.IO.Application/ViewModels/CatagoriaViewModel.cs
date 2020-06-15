using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.IO.Application.ViewModels
{
    public class CatagoriaViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public SelectList Categorias()
        {
            return new SelectList(ListarCategorias(), "Id", "Nome");
        }

        public List<CatagoriaViewModel> ListarCategorias()
        {
            return new List<CatagoriaViewModel>()
            {
                new CatagoriaViewModel() {Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), Nome = "Congresso"},
                new CatagoriaViewModel() {Id = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), Nome = "Meetup"},
                new CatagoriaViewModel() {Id = new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482"), Nome = "Workshop"},
            };
        }
    }
}
