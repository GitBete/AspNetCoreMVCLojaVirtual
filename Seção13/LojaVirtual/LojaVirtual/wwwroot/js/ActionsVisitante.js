$(document).ready(function () {
    MoverScrollOrdenacao();
    MudarOrdenacao();
});

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

        var QueryString = new URLSearchParams(window.location.search);

        if (QueryString.has("pagina")) {
            Pagina = QueryString.get("pagina");
        }
        if (QueryString.has("pesquisa")) {
            Pagina = QueryString.get("pesquisa");
        }

        //gerar link de pesquisa para qualquer pagina que tiver a ordenacao disponivel
        var URL = window.location.protocol + "//" + window.location.host   + window.location.pathname;
        var URLComParametros = URL + "?pagina=" + Pagina + "&pesquisa" + Pesquisa + "&ordenacao=" + Ordenacao + "#posicao-produto";

       // alert(URLComParametros);

        // redirecionar a pagina
        window.location.href = URLComParametros;
    });
}