// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    const d = new Date().toLocaleString();
    const datime_format = d.slice(0, -3).replace(/,/g, '');
    $("#datetime-local-mask").attr("placeholder", datime_format);
    $('#datetime-local-mask').mask('00/00/0000 00:00');
});


$(document).ready(() => {
    $("#btn-submit").click(() => {
        validarForm();
    })
})

function validarForm() {
    if (!$("#form-valid").valid()) {
        return false;
    }
}

$(document).ready(function () {
    var modal_delete = document.getElementById('modal-action');
    if (modal_delete) {
        var myModal = new bootstrap.Modal(modal_delete, {
            keyboard: false
        })
    }
    $(".btn-modal-open").click(function () {
        myModal.show()
    });
    $("#btn-modal-close").click(function () {
        myModal.hide()
    });
});


$(document).ready(() => {
    $("#btn-submit-saida").click(() => {
        const maxQuantidade = parseInt($('#form-saida-quantidade-referencia').val());
        const quantidade = parseInt($('#form-saida-quantidade').val());
        if (quantidade <= maxQuantidade) {
            validarForm();
        } else {
            $('#quantidade-error-max').html('A quantidade não pode ser maior que o estoque.');
            return false;
        }
    })
})