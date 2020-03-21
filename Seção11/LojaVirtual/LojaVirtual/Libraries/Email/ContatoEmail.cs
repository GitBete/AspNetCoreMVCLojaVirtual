using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {

        public static void EnviarContatoPorEmail(Contato contato)
        {
            //SMTP: Servidor que vai enviar mensagem
            //smtp.live.com , porta 25 ou 465
            //smtp.gmail.com, porta 465 ou 587

            string usuario_email = "elizabete.silvestre@gmail.com";
            string usuario_senha = "gabi8035";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(usuario_email, usuario_senha);
            smtp.EnableSsl = true;

            //Criando a mensagem
            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
                "<b>Nome: </br> {0} <br />" +
                "<b>E-mail: </br> {1} <br />" +
                "<b>texto: </br> {2} <br />" +
                "<br />E-Mail enviado automaticamente do site LojaVirtual." ,
                contato.Nome, 
                contato.Email,  
                contato.Texto);

            corpoMsg = "teste bete";


            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(usuario_email);
            mensagem.To.Add(usuario_email);
            mensagem.Subject = "Contato - LojaVirtual - E-Mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //Enviar Mensagem
            smtp.Send(mensagem);
        }
    }
}
