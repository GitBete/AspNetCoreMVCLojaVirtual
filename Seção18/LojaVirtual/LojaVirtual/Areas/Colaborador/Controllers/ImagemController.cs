using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Arquivos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ImagemController : Controller
    {

        //2 Metodos , controlador faz a gestao das operacoes ... nao deve fazer a logica principal
        //em LIb criar pasta para armazenar imagens -  arquivos
        [HttpPost]
        public IActionResult Armazenar(IFormFile file)
        {
            var Caminho = GerenciadorArquivo.CadastrarImagemProduto(file);
            
            if (Caminho.Length > 0)
            {
                return Ok(new { caminho = Caminho }); //JSON -> javaScript - JavaScript Object Notation - Ler com facilidade
            }
            else
            {
                return new StatusCodeResult(500);
            }

        }
        public  IActionResult Deletar(string caminho)
        {
            if (GerenciadorArquivo.ExcluirImagemProduto(caminho))
            {
                return Ok();
            }
            else
            {
                return new BadRequestResult();
            }
                       
        }
    }
}