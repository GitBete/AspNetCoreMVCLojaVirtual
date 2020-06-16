using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class DadosDevolucao
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string  Motivo { get; set; }

        [Display(Name="Código Rastreamento")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string  CodigoRastreamento { get; set; }
    }
}
