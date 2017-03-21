var FirmaListele = function () {
    var DataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#table1');
        var oTable = table.dataTable({
            "lengthMenu": [
                [10, 20, 100, -1],
                [10, 20, 100, "Hepsi"]
            ],
            "pageLength": 10,
            "language": {
                "lengthMenu": " _MENU_ Kayıt"
            },
            "columnDefs": [{
                'orderable': true,
                'targets': [0, 1, 2]
            }, {
                "searchable": true,
                "targets": [0, 1, 2]
            }],
            "order": [
                [1, "asc"]
            ]
        });
    };
    var Filtrele = function () {
        $('#btnTumKayitlar').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("").trigger(e);
        });
        $('#btnAktif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Aktif").trigger(e);
        });
        $('#btnPasif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Pasif").trigger(e);
        });
        $('#btnTaslak').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Taslak").trigger(e);
        });
        $('#btnSilinmis').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Silinmiş").trigger(e);
        });
    };
    var BtnYeniFirma = function () {
        $("#btn-yeni-firma").click(function () {
            window.location.href = '/firma/firma-ekle';
        });
    };
    return {
        init: function () {
            DataTable();
            Filtrele();
            BtnYeniFirma();
        }
    };
}();

var FirmaEkle = function () {
    var BtnKaydet = function () {
        var form = $('#form1');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);
       
        form.validate({
            errorElement: 'span',
            errorClass: 'help-block help-block-error',
            focusInvalid: false,
            ignore: "",
            messages: {
                select_multi: {
                    maxlength: jQuery.validator.format("Max {0} items allowed for selection"),
                    minlength: jQuery.validator.format("At least {0} items must be selected")
                }
            },
            rules: {
                'Firma.TicaretUnvani': { minlength: 2, required: true },
                'Firma.WebAdresi': { required: true, url: true },
                'Firma.DurumID': { required: true }
            },
            invalidHandler: function (event, validator) {
                success.hide();
                error.show();
                App.scrollTo(error, -200);
            },
            errorPlacement: function (error, element) {
                var cont = $(element).parent('.input-group');
                if (cont) {
                    cont.after(error);
                } else {
                    element.after(error);
                }
            },
            highlight: function (element) {

                $(element)
                    .closest('.form-group').addClass('has-error');
            },
            unhighlight: function (element) {
                $(element)
                    .closest('.form-group').removeClass('has-error');
            },
            success: function (label) {
                label
                    .closest('.form-group').removeClass('has-error');
            },
            submitHandler: function (form) {
                this.submit();
            }
        });
    };
    var BtnVazgec = function () {
        $("#btn-vazgec").click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/listele'; else return false;
        });
    };
    return {
        init: function () {
            BtnKaydet();
            BtnVazgec();
        }
    };
}();

var FirmaDuzenle = function () {
    //Firma 
    var firmaID = $("#Firma_FirmaID").val();
    var BtnKaydet = function () {
        var form = $('#form1');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);

        form.validate({
            errorElement: 'span',
            errorClass: 'help-block help-block-error',
            focusInvalid: false,
            ignore: "",
            messages: {
                select_multi: {
                    maxlength: jQuery.validator.format("Max {0} items allowed for selection"),
                    minlength: jQuery.validator.format("At least {0} items must be selected")
                }
            },
            rules: {
                'Firma.TicaretUnvani': { minlength: 2, required: true },
                'Firma.WebAdresi': { required: true, url: true },
                'Firma.DurumID': { required: true }
            },
            invalidHandler: function (event, validator) {
                success.hide();
                error.show();
                App.scrollTo(error, -200);
            },
            errorPlacement: function (error, element) {
                var cont = $(element).parent('.input-group');
                if (cont) {
                    cont.after(error);
                } else {
                    element.after(error);
                }
            },
            highlight: function (element) {

                $(element)
                    .closest('.form-group').addClass('has-error');
            },
            unhighlight: function (element) {
                $(element)
                    .closest('.form-group').removeClass('has-error');
            },
            success: function (label) {
                label
                    .closest('.form-group').removeClass('has-error');
            },
            submitHandler: function (form) {
                this.submit();
            }
        });
    };
    var BtnVazgec = function () {
        $("#btn-vazgec").click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/listele'; else return false;
        });
    };

    //Adres
    var FirmaAdresDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableFirmaAdres');
        var oTable = table.dataTable({
            "lengthMenu": [
                [10, 20, 100, -1],
                [10, 20, 100, "Hepsi"]
            ],
            "pageLength": 10,
            "language": {
                "lengthMenu": " _MENU_ Kayıt"
            },
            "columnDefs": [{
                'orderable': true,
                'targets': [0, 1, 2, 3]
            }, {
                "searchable": true,
                "targets": [0, 1, 2, 3]
            }],
            "order": [
                [1, "asc"]
            ]
        });
    };
    var FirmaAdresFiltrele = function () {
        $('#adresBtnTumKayitlar').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });            
            $("input.form-control.input-sm.input-small.input-inline").val("").trigger(e);
        });
        $('#adresBtnAktif').click(function () {            
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Aktif").trigger(e);
        });
        $('#adresBtnPasif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Pasif").trigger(e);
        });
        $('#adresBtnTaslak').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Taslak").trigger(e);
        });
        $('#adresBtnSilinmis').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Silinmiş").trigger(e);
        });
    };
    var FirmaAdresBtnYeniAdres = function () {
        $("#btn-yeni-adres").click(function () {            
            window.location.href = '/firma/adres-ekle?firmaID='+firmaID;
        });
    };

    return {
        init: function () {
            BtnKaydet();
            BtnVazgec();
            FirmaAdresDataTable();
            FirmaAdresFiltrele();
            FirmaAdresBtnYeniAdres();
        }
    };
}();