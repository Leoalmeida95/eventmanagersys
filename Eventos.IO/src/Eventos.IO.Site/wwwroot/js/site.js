﻿function ValidacoesEvento() {
    $.validator.methods.range = function (value, element, param) {
        var globalizedValue = value.replace(",", ".");
        return this.optional(element) || (globalizedValue >= param[0] && globalizedValue <= param[1])
    }

    $.validator.methods.number = function (value, element) {
        return this.optional(element) || /^-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
    }

    toastr.options = {
        "debug": false,
        "positionClass": "toast-top-right",
        "onclick": null,
        "fadeIn": 300,
        "fadeOut": 1000,
        "timeOut": 5000,
        "extendedTimeOut": 1000
    }

    $('#DataInicio').datepicker({
        format: "dd/mm/yyyy",
        startDate: "tomorrow",
        language: "pt-BR",
        orientation: "bottom right",
        autoclose: true
    });

    $('#DataFim').datepicker({
        format: "dd/mm/yyyy",
        startDate: "tomorrow",
        language: "pt-BR",
        orientation: "bottom right",
        autoclose: true
    });

    $(document).ready(function () {
        var $inputOnline = $("#Online");
        var $inputGratuito = $("#Gratuito");

        MostrarEndereco();
        MostrarValor();

        $inputOnline.click(function () {
            MostrarEndereco();
        });

        $inputGratuito.click(function () {
            MostrarValor();
        });

        function MostrarEndereco() {
            if ($inputOnline.is(":checked"))
                $("#EnderecoForm").hide();
            else
                $("#EnderecoForm").show();
        }

        function MostrarValor() {
            if ($inputGratuito.is(":checked")) {
                $("#Valor").val("0");
                $("#Valor").prop("disabled", true);
            }
            else {
                $("#Valor").prop("disabled", false);
            }
        }
    }
    );
}