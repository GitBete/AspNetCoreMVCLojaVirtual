using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Arquivos
{
    public class GerenciadorArquivo
    {
     
        public static string  CadastrarImagemProduto(IFormFile file)
        {
            //Armazenar imagem
          var NomeArquivo = Path.GetFileName(file.FileName);
          var Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp",  NomeArquivo);

            //Depois do comnando using ... vai ser chamado automaticamente o Dispose
          using (var stream = new FileStream(Caminho, FileMode.Create))
          {
                file.CopyTo(stream);
          }

            return Path.Combine("/uploads/temp", NomeArquivo);
        }

        public static bool ExcluirImagemProduto(string caminho)
        {
            //Excluir imagem do arquivo e da pasta
            var Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", caminho.TrimStart('/'));

            if (File.Exists(Caminho))
            {
                File.Delete(Caminho);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
