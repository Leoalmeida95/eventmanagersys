using Evento.IO.Domain.Organizadores;
using Eventos.IO.Domain.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Eventos
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

        private Evento()
        {

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
        public bool Excluido { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Guid? CategoriaId { get; private set; }
        public Guid? EnderecoId { get; private set; }
        public Guid OrganizadorId { get; private set; }

        // EF propriedades de nagevagação
        public virtual Categoria Categoria { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public virtual Organizador Organizador { get; private set; }

        #region Setters
        public void AtribuirEndereco(Endereco endereco)
        {
            if (!endereco.EhValido()) return;

            Endereco = endereco;
        }

        public void AtribuirCategoria(Categoria categoria)
        {
            //if (!categoria.EhValido()) return;

            //Categoria = categoria;
        }
        #endregion

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

            //Validacoes adicioanis ao modelo de Evento
            ValidarEndereco();
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
                    .Equal(0).When(b => b.Gratuito)
                    .WithMessage("O valor deve ser 0 se o evento for gratuito.");
        }

        private void ValidarData()
        {
            RuleFor(a => a.DataFim)
                .GreaterThan(b => b.DataInicio)
                .WithMessage("A data de início deve ser posterior a data fim do evento.");

            RuleFor(a => a.DataInicio)
                .GreaterThan(DateTime.Now)
                .WithMessage("A data de início deve ser posterior a data atual.");
        }

        private void ValidarLocal()
        {
            if (Online)
                RuleFor(a => a.Endereco)
                    .Null().When(b => b.Online)
                    .WithMessage("O evento não deve possuir endereço se for online.");
            if (!Online)
                RuleFor(a => a.Endereco)
                    .NotNull().When(b => !b.Online)
                .WithMessage("O evento deve possuir endereço se não for online.");
        }

        private void ValidarNomeEmpresa()
        {
            RuleFor(a => a.NomeEmpresa)
                .NotEmpty().WithMessage("O nome do organizador precisa ser fornecido.")
                .Length(2, 150).WithMessage("O nome do organizador precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarEndereco()
        {
            if (Online) return;
            if (Endereco.EhValido()) return;

            foreach (var erro in Endereco.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(erro);
            }
        }
        #endregion

        public static class EventoFactory
        {
            public static Evento NovoEventoCompleto(Guid id, string nome, string descCurta, string descLonga, DateTime dataInicio, DateTime dataFim,
                                                    bool gratuito, decimal valor, bool online, string nomeEmpresa, Guid? organizadorId, Endereco endereco, Categoria categoria)
            {
                var evento = new Evento()
                {
                    Id = id,
                    Nome = nome,
                    DescricaoCurta = descCurta,
                    DescricaoLonga = descLonga,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    Gratuito = gratuito,
                    Valor = valor,
                    Online = online,
                    NomeEmpresa = nomeEmpresa,
                    Endereco = endereco,
                    Categoria = categoria
                };

                if (organizadorId != null)
                    evento.Organizador = new Organizador(organizadorId.Value);

                if (online)
                    evento.Endereco = null;

                return evento;
            }
        }
    }
}
