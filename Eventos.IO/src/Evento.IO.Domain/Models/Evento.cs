using Eventos.IO.Domain.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Evento.IO.Domain.Models
{
    public class Evento : Entity<Evento>
    {
        public Evento(
                    string nome,
                    DateTime dataInicio,
                    DateTime dataFim,
                    bool gratuito,
                    decimal valor,
                    bool online,
                    string nomeEmpresa)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;


        }

        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public Categoria Categoria { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Endereco Endereco { get; private set; }
        public Organizador Organizador { get; private set; }

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        #region Validacoes
        private void Validar()
        {
            ValidarNome();
            ValidarValor();
            ValidarData();
            ValidarLocal();
            ValidarNomeEmpresa();
            ValidationResult = Validate(this);
        }

        private void ValidarNome()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O nome do evento precisa ser fornecido.")
                .Length(2, 150).WithMessage("O nome do evento precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarValor()
        {
            if (!Gratuito)
                RuleFor(a => a.Valor)
                    .ExclusiveBetween(1, 50000)
                    .WithMessage("O valor precisa estar entre 1.00 e 50000.00.");

            if (Gratuito)
                RuleFor(a => a.Valor)
                    .ExclusiveBetween(0, 0)
                    .WithMessage("O valor não deve ser diferente de 0.00 se for gratuito.");
        }

        private void ValidarData()
        {
                RuleFor(a => a.DataInicio)
                    .GreaterThan(b=>b.DataFim)
                    .WithMessage("A data de início do evento deve ser maior que a data fim.");

                RuleFor(a => a.DataFim)
                    .LessThan(b=>b.DataInicio)
                    .WithMessage("A data fim do evento deve ser maior que a data início.");
        }

        private void ValidarLocal()
        {
            if(Online)
            RuleFor(a => a.Endereco)
                .Null().When(b=>b.Online)
                .WithMessage("O evento não deve possuir endereço se for online.");
            if (!Online)
                RuleFor(a => a.Endereco)
                    .NotNull().When(b=> !b.Online)
                .WithMessage("O evento deve possuir endereço se não for online.");
        }

        private void ValidarNomeEmpresa()
        {
            RuleFor(a => a.NomeEmpresa)
                .NotEmpty().WithMessage("O nome do organizador precisa ser fornecido.")
                .Length(2, 150).WithMessage("O nome do organizador precisa ter entre 2 e 150 caracteres.");
        }
        #endregion
    }
}
