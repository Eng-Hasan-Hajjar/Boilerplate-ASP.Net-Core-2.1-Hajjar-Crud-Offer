(function () {
	$(function () {

		var _offerService = abp.services.app.offer;
		var _$modal = $('#OfferCreateModal');
		var _$form = _$modal.find('form');

		_$form.validate({
		});

		$('#RefreshButton').click(function () {
			refreshRoleList();
		});

		$('.delete-offer').click(function () {
			var offerId = $(this).attr("data-offer-id");
			var offerName = $(this).attr('data-offer-name');

			deleteOffer(offerId, offerName);
		});

		$('.edit-offer').click(function (e) {
			var offerId = $(this).attr("data-offer-id");

			e.preventDefault();
			abp.ajax({
				url: abp.appPath + 'Offers/EditOfferModal?offerId=' + offerId,
				type: 'POST',
				contentType: 'application/html',
				success: function (content) {
					$('#OfferEditModal div.modal-content').html(content);
				},
				error: function (e) { }
			});
		});

		_$form.find('button[type="submit"]').click(function (e) {
			e.preventDefault();

			if (!_$form.valid()) {
				return;
			}

			

			abp.ui.setBusy(_$modal);
			_offerService.create(offer).done(function () {
				_$modal.modal('hide');
				location.reload(true); //reload page to see new role!
			}).always(function () {
				abp.ui.clearBusy(_$modal);
			});
		});

		_$modal.on('shown.bs.modal', function () {
			_$modal.find('input:not([type=hidden]):first').focus();
		});

		function refreshOfferList() {
			location.reload(true); //reload page to see new role!
		}

		function deleteOffer(offerId, offerName) {
			abp.message.confirm(
				abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'boilerplateasp'), offerName),
				function (isConfirmed) {
					if (isConfirmed) {
						_offerService.delete({
							id: offerId
						}).done(function () {
							refreshOfferList();
						});
					}
				}
			);
		}
	});
})();
