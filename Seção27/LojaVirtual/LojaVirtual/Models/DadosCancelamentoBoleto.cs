using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class DadosCancelamentoBoleto
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Motivo { get; set; }
        
        public string FormaPagamento { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(3, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string BancoCodigo { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(5, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Agencia { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(1, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(2, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string AgenciaDV { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Conta { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(1, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(2, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string ContaDV { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string CPF { get; set; }

        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }
        public string TipoConta { get; set; }


        //metadata
    }
}
