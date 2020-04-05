using LojaVirtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
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

            return Path.Combine("/uploads/temp", NomeArquivo).Replace("\\","/");
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

        public static List<Imagem> MoverImagensProduto(List<string> ListaCaminhoTemp, int ProdutoId)
        {
            //Mover arquivo temporário para pasta com o id da imagem

            //Caminho da pasta a ser criada
            var CaminhoDefinitivoPastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ProdutoId.ToString());
            //Verificar se a pasta exite =, senao criar
            if (!Directory.Exists(CaminhoDefinitivoPastaProduto))
            {
                Directory.CreateDirectory(CaminhoDefinitivoPastaProduto);
            }
                     

            List<Imagem> ListaCaminhoDef = new List<Imagem>();

            //Loop movendo a imgem da pasta temporaria para pasta com id do produto
            foreach (var CaminhoTemp in ListaCaminhoTemp)
            {
                //uploads/temp/mouse-cosair.jpg
                var NomeArquivo = Path.GetFileName(CaminhoTemp);
                var CaminhoAbsolutoTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp", NomeArquivo);
                var CaminhoAbsolutoDef = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ProdutoId.ToString(), NomeArquivo);
                
                //So fazer se foi escolhida a foto
                if (!string.IsNullOrEmpty(CaminhoTemp))
                {
                   
                    //Verificar se a a imagem estiver move, senao erro
                    if (File.Exists(CaminhoAbsolutoTemp))
                    {
                        //Mover
                        File.Copy(CaminhoAbsolutoTemp, CaminhoAbsolutoDef);
                        if (File.Exists(CaminhoAbsolutoDef))
                        {
                            File.Delete(CaminhoAbsolutoTemp);
                        }

                        var imagem = new Imagem() { Caminho = Path.Combine("/uploads", ProdutoId.ToString(),  NomeArquivo).Replace("\\", "/"), ProdutoId = ProdutoId };
                        ListaCaminhoDef.Add(imagem);
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return ListaCaminhoDef;
        }
    }
}
