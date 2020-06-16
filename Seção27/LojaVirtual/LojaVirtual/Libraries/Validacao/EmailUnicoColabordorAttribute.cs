using LojaVirtual.Models;
using LojaVirtual.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Validacao
{
    public class EmailUnicoColabordorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Pegar o valor do campo e-mail, Obter repository Colaborador, fazer verificacao
            //Campo da verificacao no modelo de dados
           string Email = (value as string).Trim();

            //Pega de Servico, configuracoes
           IColaboradorRepository _colaboradorRepository = (IColaboradorRepository)validationContext.GetService(typeof(IColaboradorRepository));
            //consulta colaborador por email
           List<Colaborador> colaboradores = _colaboradorRepository.ObterColaboradorPorEmail(Email);

           //pegar o objeto como todo
           Colaborador objColaborador = (Colaborador) validationContext.ObjectInstance;

           //Colaborador > 1 = REJEITA
           if (colaboradores.Count > 1)
           {
                return new ValidationResult("E-Mail já existente!");
           }

            //Colaborador = 1 verificar se o Id for diferente = REJEITAR
            if (colaboradores.Count == 1 && objColaborador.Id != colaboradores[0].Id)
            {
                return new ValidationResult("E-Mail já existente!");
            }

            return ValidationResult.Success;

           // return base.IsValid(value, validationContext);
        }
    }
}
