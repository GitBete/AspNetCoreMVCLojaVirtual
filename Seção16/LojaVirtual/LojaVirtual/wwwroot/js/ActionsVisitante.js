$(document).ready(function () {
    MoverScrollOrdenacao();
    MudarOrdenacao();
    MudarImagemPrincipalProduto();
    MudarQuantidadeProdutoCarrinho();
});

function MudarQuantidadeProdutoCarrinho() {
    $("#order .btn-primary").click(function () {
       //var pai = $(this).parent().parent()

        if ($(this).hasClass("diminuir")) {
            
            //var id = pai.find(".inputProdutoId").val();

            LoginaMudarQuantidadeProdutoUnitarioCarrinho("diminuir",$(this))
        }
        if ($(this).hasClass("aumentar")) {
            //var id = pai.find(".inputProdutoId").val();

            //alert("clicou botal + " + id);
            LoginaMudarQuantidadeProdutoUnitarioCarrinho("aumentar", $(this))
        }
    });
}

function LoginaMudarQuantidadeProdutoUnitarioCarrinho(operacao, botao) {
    var pai = botao.parent().parent();

    var produtoId = pai.find(".inputProdutoId").val();
    var QuantidadeEstoque = parseInt(pai.find(".inputProdutoQuantidadeEstoque").val());
    var ValorUnitario = parseFloat(pai.find(".inputProdutoValorUnit").val().replace(",","."));

    var CampoinputProdutoQuantidadeCarrinho = pai.find(".inputProdutoQuantidadeCarrinho");
    var QuantidadeCarrinho = parseInt(CampoinputProdutoQuantidadeCarrinho.val());

    var CampoTotal = botao.parent().parent().parent().parent().parent().find(".price");

    //Adicionar validacoes

    if (operacao == "aumentar") {
        if (QuantidadeCarrinho == QuantidadeEstoque) {
            alert("Ops! Não possuimos estoque suficiente para a quantidade que você deseja comprar!");
        } else {
            QuantidadeCarrinho++; 
        }
              
    } else if (operacao == "diminuir") {        

        if (QuantidadeCarrinho == 1) {
            alert("Ops! Caso não deseje este produto clique no botão Remover.");
        } else {
            QuantidadeCarrinho--;
        }
    }

    CampoinputProdutoQuantidadeCarrinho.val(QuantidadeCarrinho);
    var resultado = numberToReal(ValorUnitario * QuantidadeCarrinho);
    CampoTotal.text(resultado);

    //Atualizar depois o valor total
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