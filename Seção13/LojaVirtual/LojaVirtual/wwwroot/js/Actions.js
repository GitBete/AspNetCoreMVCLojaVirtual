﻿$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?")

        if (resultado == false) {
            e.preventDefault();
        }
    });
    $('.maskdinheiro').mask('000.000.000.000.000,00', { reverse: true });
});