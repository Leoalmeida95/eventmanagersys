using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.IO.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
    }
}
