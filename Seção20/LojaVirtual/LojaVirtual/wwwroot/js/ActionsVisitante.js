$(document).ready(function () {
    MoverScrollOrdenacao();
    MudarOrdenacao();
    MudarImagemPrincipalProduto();
    MudarCamposNoCarrinhoCompras();

    MascaraCEP();
    AJAXBuscarCEP();
    AcaoCalcularFreteBTN();
    AJAXCalcularFrete(false);

    AJAXEnderecoEntregaCalcularFrete();
    
});

function AJAXEnderecoEntregaCalcularFrete() {
    $("input[name=endereco]").change(function () {

        $.cookie("Carrinho.Endereco", $(this).val(), { path: "/" });

        var cep = "";

        if ($(this).parent().find("input[name=cep]").val() != undefined) {           
            cep = RemoverMascara($(this).parent().find("input[name=cep]").val());
        }

        EnderecoEntregaCardsLimpar();
        EnderecoEntregaLimparValor();
        EnderecoEntregaCardsLoading();
        $(".btn-continuar").addClass("disabled");

        if (cep.length == 8) {

            //requisicao AJAX
            $.ajax({
                type: "GET",
                url: "/CarrinhoCompra/CalcularFrete?cepDestino=" + cep,
                error: function (data) {
                    MostrarMensagemErro("Ops!!! Obtemos um erro ao obter o Frete ..." + data.mensagem);

                    EnderecoEntregaCardsLimpar();
                }
                ,
                success: function (data) {

                    EnderecoEntregaCardsLimpar();

                    html = "";

                    for (var i = 0; i < data.listaValores.length; i++) {
                        var tipofrete = data.listaValores[i].tipoFrete;
                        var valor = data.listaValores[i].valor;
                        var prazo = data.listaValores[i].prazo;

                        $(".card-title")[i].innerHTML = "<label for='" + tipofrete + "'>" + tipofrete + "</label>";
                        $(".card-text")[i].innerHTML = "<label for='" + tipofrete + "'>Prazo de " + prazo + " dias.</label>";
                        $(".card-footer .text-muted")[i].innerHTML = "<input type=\"radio\" name=\"frete\" value=\"" + tipofrete + "\" id ='" + tipofrete + "' /> <strong><label for='" + tipofrete + "'>" + numberToReal(valor) + "</strong>";


                        if ($.cookie("Carrinho.TipoFrete") != undefined && $.cookie("Carrinho.TipoFrete")  == tipofrete) {
                            $(".card-footer .text-muted  input[name=frete]").eq(i).attr("checked", "checked");  

                            EnderecoEntregaCardsSelecionarStyle($(".card-footer .text-muted input[name=frete]").eq(i));  

                            $(".btn-continuar").removeClass("disabled");

                        }
                    }

                    $(".card-footer .text-muted").find("input[name=frete]").change(function () {
                        $.cookie("Carrinho.TipoFrete", $(this).val(), { path: "/" });
                                                                        
                        EnderecoEntregaCardsSelecionarStyle($(this));  
                        $(".btn-continuar").removeClass("disabled"); 
                    });

                }

            });
        } else {
            if (callByButton == true) {
                $(".container-frete").html("");
                MostrarMensagemErro("Digite o CEP para calcular o Frete!");
            }
        }



    });
}
       

function MascaraCEP() {
    $(".cep").mask("00.000-000");
}

function AJAXBuscarCEP() {
    $("#CEP").keyup(function () {
        OcutarMensagemErro();

        if ($(this).val().length == 10) {

            var cep = RemoverMascara($(this).val());

            $.ajax({
                type: "GET",
                url: "https://viacep.com.br/ws/" + cep + "/json/?callback=callback_name" ,
                dataType:"jsonp",
                error: function (data) {
                    MostrarMensagemErro("Ops!!! tivemos um erro ao obter o CEP !" + "Parece que os servidores estão offline");
                    
                }
                ,
                success: function (data) {
                    if (data.erro == undefined) {
                        $("#UF").val(data.uf);
                        $("#Cidade").val(data.localidade);
                        $("#Logradouro").val(data.logradouro);
                        $("#Bairro").val(data.bairro);
                        $("#Complemento").val(data.Complemento);
                    } else {
                        MostrarMensagemErro("O CEP informado não existe");
                    }

                    
                }
            });
        }
    });
}

function AcaoCalcularFreteBTN() {
    $(".btn-calcular-frete").click(function (e) {
        AJAXCalcularFrete(true);
        e.preventDefault();
    });
}

function AJAXCalcularFrete(callByButton) {
    $(".btn-continuar").addClass("disabled");

    if (callByButton == false) {
        if ($.cookie('Carrinho.CEP') != undefined){
            $(".cep").val($.cookie('Carrinho.CEP'));
        }
    }

    var cep = '';
    if ($(".cep").val() != undefined) {
        cep = RemoverMascara( $(".cep").val());
    }
       
    //$.removeCookie("Carrinho.TipoFrete")

    if (cep.length == 8) {

        $.cookie('Carrinho.CEP', $(".cep").val());

        html = "<img src='\\img\\loading4.gif'/>";
        $(".container-frete").html(html);
        $(".frete").text("R$ 0,00");
        $(".total").text("R$ 0,00");        
        
        //requisicao AJAX
        $.ajax({
            type: "GET",
            url: "/CarrinhoCompra/CalcularFrete?cepDestino=" + cep,
            error: function (data) {
                MostrarMensagemErro("Ops!!! Obtemos um erro ao obter o Frete ..." + data.mensagem);
                //console.info(data);
            }
            ,
            success: function (data) {
                
                html = "";

                for (var i = 0; i < data.listaValores.length; i++) {
                    var tipofrete = data.listaValores[i].tipoFrete;
                    var valor = data.listaValores[i].valor;
                    var prazo = data.listaValores[i].prazo;

                    html += "<dl class=\"dlist-align\"><dt><input type=\"radio\"name=\"frete\" value=\"" + tipofrete + "\" /><input type=\"hidden\" name=\"valor\" value=\"" + valor + "\" /></dt><dd>" + tipofrete + " - " + numberToReal(valor) + " (" + prazo + " dias úteis)</dd></dl>"
                }

                $(".container-frete").html(html);
                $(".container-frete").find("input[type=radio]").change(function () {

                    //$.cookie("Carrinho.TipoFrete", $(this).val());
                    $.cookie("Carrinho.TipoFrete", $(this).val(), { path: "/" }); 
                    $(".btn-continuar").removeClass("disabled");

                    //alert($(this).val());
                    var valorFrete = parseFloat($(this).parent().find("input[type=hidden]").val());
                    $(".frete").text(numberToReal(valorFrete));

                    var Subtotal = parseFloat($(".subtotal").text().replace("R$", "").replace(".", "").replace(",", "."))
                    var valorTotal = valorFrete + Subtotal;

                    $(".total").text(numberToReal(valorTotal));

                });
                //console.info(data);
            }

        });
    } else {
        if (callByButton == true) {
            $(".container-frete").html("");
            MostrarMensagemErro("Digite o CEP para calcular o Frete!");
        }
    }

}


function MudarCamposNoCarrinhoCompras() {
    $("#order .btn-primary").click(function () {
       //var pai = $(this).parent().parent()

        OcutarMensagemErro("");

        if ($(this).hasClass("diminuir")) {
            
            //var id = pai.find(".inputProdutoId").val();

            OrquestradorMudancasCarrinhoCompras("diminuir",$(this))
        }
        if ($(this).hasClass("aumentar")) {
            //var id = pai.find(".inputProdutoId").val();

            //alert("clicou botal + " + id);
            OrquestradorMudancasCarrinhoCompras("aumentar", $(this))
        }
    });
}


function OrquestradorMudancasCarrinhoCompras(operacao, botao) {
    /*
     * Carregamento dos valores
    */
    var pai = botao.parent().parent();

    var produtoId = pai.find(".inputProdutoId").val();
    var quantidadeEstoque = parseInt(pai.find(".inputProdutoQuantidadeEstoque").val());
    var valorUnitario = parseFloat(pai.find(".inputProdutoValorUnit").val().replace(",","."));

    var campoQuantidadeProdutoCarrinho = pai.find(".inputProdutoQuantidadeCarrinho");
    var quantidadeProdutoCarrinhoAntiga = parseInt(campoQuantidadeProdutoCarrinho.val());

    var campoValor = botao.parent().parent().parent().parent().parent().find(".price");

    var produto = new ProdutoQuantidadeEValor(produtoId, quantidadeEstoque, valorUnitario, quantidadeProdutoCarrinhoAntiga, 0, campoQuantidadeProdutoCarrinho, campoValor);

    /*
    * Chamada de Métodos
    */
    CarrinhoComprasAtualizacaoVisual(produto, operacao);
}

function CarrinhoComprasAtualizacaoVisual(produto, operacao) {
/*
 * Carregamento dos valores
*/

    if (operacao == "aumentar") {
        //if (produto.quantidadeProdutoCarrinhoAntiga == produto.QuantidadeEstoque) {
        //    alert("Ops! Não possuimos estoque suficiente para a quantidade que você deseja comprar!");
        //} else
        {
            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga + 1;  
            CarrinhoComprasAtualizacaoQtdeEValor(produto);

            AJAXEnviaAtualizacaoProdutoNoCarrinho(produto);
        }
    } else if (operacao == "diminuir") {

        //if (produto.quantidadeProdutoCarrinhoAntiga == 1) {
        //    alert("Ops! Caso não deseje este produto clique no botão Remover.");
        //} else
        {
            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga - 1;
            CarrinhoComprasAtualizacaoQtdeEValor(produto);

            AJAXEnviaAtualizacaoProdutoNoCarrinho(produto);
        }
    }   
}

function AJAXEnviaAtualizacaoProdutoNoCarrinho(produto){

    $.ajax({
        type: "GET",
        url: "/CarrinhoCompra/AlterarQuantidade?id=" + produto.produtoId + "&quantidade=" + produto.quantidadeProdutoCarrinhoNova,
        error: function (data) {
            //alert("Opps! Tivemos um erro!" + data.responseJSON.mensagem);
            //Console.info(data);

            MostrarMensagemErro(data.responseJSON.mensagem);

            //Rollback
            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga;
            CarrinhoComprasAtualizacaoQtdeEValor(produto);
        }
        ,
        success: function () {
            AJAXCalcularFrete(true);
        }

    });
}

function MostrarMensagemErro(mensagem) {
    $(".alert-danger").css("display", "block");
    $(".alert-danger").text(mensagem);
}
function OcutarMensagemErro(mensagem) {
    $(".alert-danger").css("display", "none");
}

function CarrinhoComprasAtualizacaoQtdeEValor(produto) {   
    produto.campoQuantidadeProdutoCarrinho.val(produto.quantidadeProdutoCarrinhoNova);

    var resultado = produto.valorUnitario * produto.quantidadeProdutoCarrinhoNova;
    produto.campoValor.text(numberToReal(resultado));

    AtualizarSubTotalCarrinho(); 
}

function AtualizarSubTotalCarrinho() {
    var Subtotal = 0;
    var TagsComPrice = $(".price");

    TagsComPrice.each(function () {
        var ValorReais = parseFloat($(this).text().replace("R$", "").replace(".", "").replace(" ", "").replace(",", "."));

        Subtotal += ValorReais;
    })

    $(".subtotal").text(numberToReal(Subtotal));
    
}

function numberToReal(numero) {
    var numero = numero.toFixed(2).split('.');
    numero[0] = "R$ " + numero[0].split(/(?=(?:...)*$)/).join('.');
    return numero.join(',');
}

function MudarImagemPrincipalProduto() {
    $(".img-small-wrap img").click(function () {
        var Caminho = $(this).attr("src");
        $(".img-big-wrap img").attr("src", Caminho);
        $(".img-big-wrap a").attr("href", Caminho);
    });
}

function MoverScrollOrdenacao() {
    if (window.location.hash.length > 0 ) {
        var hash = window.location.hash;
        if (hash == "#posicao-produto") {
            window.scrollBy(0, 500);
        }
    }
}

function MudarOrdenacao() {
    $("#ordenacao").change(function () {
        //Redirecionar para tela Index/passando as querysstring de ordenacao e mantendo a pagina e a pesquisa
        var Pagina = 1;
        var Pesquisa = "";
        var Ordenacao = $(this).val();
        var Fragmento = "#posicao-produto";

        var QueryString = new URLSearchParams(window.location.search);

        if (QueryString.has("pagina")) {
            Pagina = QueryString.get("pagina");
        }
        if (QueryString.has("pesquisa")) {
            Pagina = QueryString.get("pesquisa");
        }
        if ($("#breadcrumb").length > 0) {
            Fragmento = "";
        }

        //gerar link de pesquisa para qualquer pagina que tiver a ordenacao disponivel
        var URL = window.location.protocol + "//" + window.location.host   + window.location.pathname;
        var URLComParametros = URL + "?pagina=" + Pagina + "&pesquisa" + Pesquisa + "&ordenacao=" + Ordenacao + Fragmento;

       // alert(URLComParametros);

        // redirecionar a pagina
        window.location.href = URLComParametros;
    });
}

function RemoverMascara(valor) {
    return valor.replace(".", "").replace("-", "");
}

function EnderecoEntregaCardsSelecionarStyle(obj) {
    
    $(".card-body").css("background-color", "white");
    $(".card-footer").css("background-color", "rgba(0,0,0,.03)");

    obj.parent().parent().parent().find(".card-body").css("background-color", "#D7EAFF");
    obj.parent().parent().parent().find(".card-footer").css("background-color", "#D7EAFF");

    EnderecoEntregaAtualizarValor();
}

function EnderecoEntregaCardsLoading() {    
    for (var i = 0; i < 3; i++) {
        $(".card-text")[i].innerHTML  = "<br /><br /><img src='\\img\\loading4.gif' />";
    }
}

function EnderecoEntregaCardsLimpar() {
    for (var i = 0; i < 3; i++) {
        $(".card-title")[i].innerHTML = "-";
        $(".card-text")[i].innerHTML = "-";
        $(".card-footer .text-muted")[i].innerHTML = "-" ;
    }
}

function EnderecoEntregaAtualizarValor() {

    EnderecoEntregaLimparValor();
   
    var frete = parseFloat($(".card-footer input[name=frete]:checked").parent().find("label").text().replace("R$", "").replace(".", "").replace(" ", "").replace(",", "."));
    var tproduto = parseFloat($(".texto-produto").text().replace("R$", "").replace(".", "").replace(" ", "").replace(",", "."));

    var total = tproduto + frete;

    $(".texto-frete").text(numberToReal(frete));
    $(".texto-total").text(numberToReal(total));
}

function EnderecoEntregaLimparValor() {

    $(".texto-frete").text("-");
    $(".texto-total").text("-");
}


/*
* Classes
*/

/*
 * Class com dados do carrinho de compras
 */



class ProdutoQuantidadeEValor
{
    constructor(produtoId , quantidadeEstoque, valorUnitario, quantidadeProdutoCarrinhoAntiga, quantidadeProdutoCarrinhoNova, campoQuantidadeProdutoCarrinho, campoValor)
    {
        this.produtoId = produtoId;
        this.quantidadeEstoque = quantidadeEstoque;
        this.valorUnitario = valorUnitario;

        this.quantidadeProdutoCarrinhoAntiga = quantidadeProdutoCarrinhoAntiga;
        this.quantidadeProdutoCarrinhoNova = quantidadeProdutoCarrinhoNova;

        this.campoQuantidadeProdutoCarrinho = campoQuantidadeProdutoCarrinho;
        this.campoValor = campoValor;
    }
}




