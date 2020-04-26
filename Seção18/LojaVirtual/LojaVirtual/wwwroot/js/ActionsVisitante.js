$(document).ready(function () {
    MoverScrollOrdenacao();
    MudarOrdenacao();
    MudarImagemPrincipalProduto();
    MudarCamposNoCarrinhoCompras();

    MascaraCEP();
    AcaoCalcularFreteBTN();
    AJAXCalcularFrete(false);
    
});

function MascaraCEP() {
    $(".cep").mask("00.000-000");
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

    var cep = $(".cep").val().replace(".", "").replace("-", "");
    $.removeCookie("Carrinho.TipoFrete")


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
                MostrarMensagemErroCarrinho("Ops!!! Obtemos um erro ao obter o Frete ..." + data.mensagem);
                //console.info(data);
            }
            ,
            success: function (data) {
                html = "";

                for (var i = 0; i < data.length; i++) {
                    var tipofrete = data[i].tipoFrete;
                    var valor = data[i].valor;
                    var prazo = data[i].prazo;

                    html += "<dl class=\"dlist-align\"><dt><input type=\"radio\"name=\"frete\" value=\"" + tipofrete + "\" /><input type=\"hidden\" name=\"valor\" value=\"" + valor + "\" /></dt><dd>" + tipofrete + " - " + numberToReal(valor) + " (" + prazo + " dias úteis)</dd></dl>"
                }

                $(".container-frete").html(html);
                $(".container-frete").find("input[type=radio]").change(function () {

                    $.cookie("Carrinho.TipoFrete", $(this).val());
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
            MostrarMensagemErroCarrinho("Digite o CEP para calcular o Frete!");
        }
    }

}


function MudarCamposNoCarrinhoCompras() {
    $("#order .btn-primary").click(function () {
       //var pai = $(this).parent().parent()

        OcutarMensagemErroCarrinho("");

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

            MostrarMensagemErroCarrinho(data.responseJSON.mensagem);

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

function MostrarMensagemErroCarrinho(mensagem) {
    $(".alert-danger").css("display", "block");
    $(".alert-danger").text(mensagem);
}
function OcutarMensagemErroCarrinho(mensagem) {
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


/*
* Classes
*/


/*
 * Class com dados do carrinho de compras
 */
class ProdutoQuantidadeEValor {
    constructor(produtoId, quantidadeEstoque, valorUnitario, quantidadeProdutoCarrinhoAntiga, quantidadeProdutoCarrinhoNova, campoQuantidadeProdutoCarrinho, campoValor) {
        //receve valores
        this.produtoId = produtoId;
        this.quantidadeEstoque = quantidadeEstoque;
        this.valorUnitario = valorUnitario;

        this.quantidadeProdutoCarrinhoAntiga = quantidadeProdutoCarrinhoAntiga;
        this.quantidadeProdutoCarrinhoNova = quantidadeProdutoCarrinhoNova;

        //recebe objetos
        this.campoQuantidadeProdutoCarrinho = campoQuantidadeProdutoCarrinho;
        this.campoValor = campoValor;
    }
}


