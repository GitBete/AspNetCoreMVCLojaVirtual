$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?")

        if (resultado == false) {
            e.preventDefault();
        }
    });
    $('.maskdinheiro').mask('000.000.000.000.000,00', { reverse: true });

    AJAXUploadImagemProduto();
});

function AJAXUploadImagemProduto() {  
    $(".img-upload").click(function () {
        $(this).parent().parent().find(".input-file").click();
    });

    $(".btn-imagem-excluir").click(function () {
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        var btnExcluir = $(this).parent().find(".btn-imagem-excluir");
        var btninputfile = $(this).parent().find(".input-file");
       

        $.ajax({
            type: "GET",
            url: "/Colaborador/Imagem/Deletar?caminho=" + CampoHidden.val(),
            error: function (jqXHR, textStatus, errorThrown) {
                alert("Erro excluindo do arquivo: " + textStatus);
            }
            ,
            success: function () {
                Imagem.attr("src", "/img/imagem-padrao.png");    
                btnExcluir.addClass("btn-ocultar");
                CampoHidden.val("");
                btninputfile.val("");                
            }

        });
    });

    $(".input-file").change(function () {
        
        //Criacao do formulario via java scritp
        var Formulario = new FormData();
        var Binario = $(this)[0].files[0];
        Formulario.append("file", Binario);

        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        var btnExcluir = $(this).parent().find(".btn-imagem-excluir");

        // apresenta imagem loading
        Imagem.attr("src", "/img/loading.gif");
        Imagem.addClass("thumb");

        //fazzer requisicao ajax
        $.ajax({
            type: "POST",
            url: "/Colaborador/Imagem/Armazenar",
            data: Formulario,
            contentType: false,
            processData: false,
            error: function (jqXHR, textStatus, errorThrown) {                
                Imagem.attr("src", "/img/imagem-padrao.png");  
                Imagem.removeClass("thumb");
                alert("Erro no envio do arquivo: " + textStatus);
            }
            ,
            success: function (data) {
                var caminho = data.caminho;  
                Imagem.attr("src", caminho);
                Imagem.removeClass("thumb");
                CampoHidden.val(caminho);
                btnExcluir.removeClass("btn-ocultar")
            }          

        });
    });
}