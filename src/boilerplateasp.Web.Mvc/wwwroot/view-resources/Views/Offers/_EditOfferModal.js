(function ($) {

    var _offerService = abp.services.app.offer;
    var _$modal = $('#OfferEditModal');
    var _$form = $('form[name=OfferEditForm]');

    function save() {

        if (!_$form.valid()) {
            return;
        }

     

        abp.ui.setBusy(_$form);
        _offerService.update(offer).done(function () {
            _$modal.modal('hide');
            location.reload(true); //reload page to see edited role!
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function (e) {
        e.preventDefault();
        save();
    });

    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });

    $.AdminBSB.input.activate(_$form);

    _$modal.on('shown.bs.modal', function () {
        _$form.find('input[type=text]:first').focus();
    });
})(jQuery);