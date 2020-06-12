﻿using System;
using Microsoft.AspNetCore.Mvc;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Eventos.IO.Site.Controllers
{
    public class EventosController : BaseController
    {
        private readonly IEventoAppService _eventoAppService;
        private readonly IUser _user;

        public EventosController(IEventoAppService eventoAppService,
                                IDomainNotificationHandler<DomainNotification> notifications,
                                IUser user) : base(notifications, user)
        {
            _eventoAppService = eventoAppService;
        }

        public IActionResult Index()
        {
            return View(_eventoAppService.ObterTodos());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null)
            {
                return NotFound();
            }

            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create(EventoViewModel eventoViewModel)
        {
            if (!ModelState.IsValid) return View(eventoViewModel);

            eventoViewModel.OrganizadorId = OrganizadorId;

            _eventoAppService.Register(eventoViewModel);

            ViewBag.RetornoPost  = OperacaoValida() ? "success,Evento registrado com sucesso!"
                                                    : "warning,Evento não registrado! Verifique as mensagens";


            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null) return NotFound();


            ViewBag.RetornoPost = OperacaoValida() ? "success,Evento atualizado com sucesso!"
                                        : "warning,Evento não atualizado! Verifique as mensagens";

            return View(eventoViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventoViewModel eventoViewModel)
        {
            if (!ModelState.IsValid) return View(eventoViewModel);

            _eventoAppService.Atualizar(eventoViewModel);

            //TODO: Validar se a operação ocorreu com sucesso

            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null)
            {
                return NotFound();
            }

            return View(eventoViewModel);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _eventoAppService.Excluir(id);
            return RedirectToAction("Index");
        }

        public IActionResult IncluirEndereco(Guid? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(Id.Value);

            return PartialView("_IncluirEndereco", eventoViewModel);

        }

        public IActionResult AtualizarEndereco(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(Id.Value);

            return PartialView("_AtualizarEndereco", eventoViewModel);

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult IncluirEndereco(EventoViewModel eventoViewModel)
        //{
        //    eventoViewModel.Endereco.EventoId = eventoViewModel.Id;

        //}
    }
}
