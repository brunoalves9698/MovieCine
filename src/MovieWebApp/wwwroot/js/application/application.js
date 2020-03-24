
$('.btn-details').mdl({
    type: 'modal',
    overlayClick: true
});

// preenche endereço com base no cep
$('#ZipCode').focusout(function () {
    let cep = $(this).val();

    cep = cep.replace(/\D/g, '');

    if (cep != "") {
        var validaCep = /^[0-9]{8}$/;

        if (validaCep.test(cep)) {
            $.getJSON(`//viacep.com.br/ws/${cep}/json`, cep, function (data) {
                if (!data.erro) {
                    $('#Street').val(data.logradouro);
                    $('#Neighborhood').val(data.bairro);
                    $('#City').val(data.localidade);
                    $('#State').val(data.uf);
                    $('#Country').val('Brasil');

                    $('#Number').focus();
                }
            });
        }
    }
});