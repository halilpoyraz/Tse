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
            window.location.href = '/firma/firma-adres-ekle?firmaID='+firmaID;
        });
    };   
    var FirmaAdresEkleBtnKaydet = function () {
        var form = $('#formAdresEkle');
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
                'Adres.AdresTipiID': { required: true },
                'Adres.AdresSatiri': { minlength: 2, required: true },
                'Adres.IlceID': { required: true },
                'Adres.SehirID': { required: true },
                'Adres.UlkeID': { required: true },                
                'Adres.DurumID': { required: true }
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
    var FirmaAdresEkleBtnVazgec = function () {
        $("#btn-yeni-adres-vazgec").click(function () {
            var firmaID = $("#Adres_FirmaID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/firma-adres-listele?firmaID='+firmaID; else return false;
        });
    };

    //Telefon
    var FirmaTelefonDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableFirmaTelefon');
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
    var FirmaTelefonFiltrele = function () {
        $('#telefonBtnTumKayitlar').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("").trigger(e);
        });
        $('#telefonBtnAktif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Aktif").trigger(e);
        });
        $('#telefonBtnPasif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Pasif").trigger(e);
        });
        $('#telefonBtnTaslak').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Taslak").trigger(e);
        });
        $('#telefonBtnSilinmis').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Silinmiş").trigger(e);
        });
    };
    var FirmaTelefonBtnYeniTelefon = function () {
        $("#btn-yeni-telefon").click(function () {
            window.location.href = '/firma/firma-telefon-ekle?firmaID=' + firmaID;
        });
    };
    var FirmaTelefonEkleBtnKaydet = function () {
        var form = $('#formTelefonEkle');
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
                'Telefon.TelefonTipiID': { required: true },
                'Telefon.TelefonNo': { minlength: 7, required: true, number: true },
                'Telefon.DahiliNo': { minlength: 2, number: true },
                'Telefon.DurumID': { required: true }
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
    var FirmaTelefonEkleBtnVazgec = function () {
        $("#btn-yeni-telefon-vazgec").click(function () {
            var firmaID = $("#Telefon_FirmaID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/firma-telefon-listele?firmaID=' + firmaID; else return false;
        });
    };

    //Eposta
    var FirmaEpostaDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableFirmaEposta');
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
                'targets': [0, 1]
            }, {
                "searchable": true,
                "targets": [0, 1]
            }],
            "order": [
                [1, "asc"]
            ]
        });
    };
    var FirmaEpostaFiltrele = function () {
        $('#epostaBtnTumKayitlar').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("").trigger(e);
        });
        $('#epostaBtnAktif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Aktif").trigger(e);
        });
        $('#epostaBtnPasif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Pasif").trigger(e);
        });
        $('#epostaBtnTaslak').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Taslak").trigger(e);
        });
        $('#epostaBtnSilinmis').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Silinmiş").trigger(e);
        });
    };
    var FirmaEpostaBtnYeniEposta = function () {
        $("#btn-yeni-eposta").click(function () {
            window.location.href = '/firma/firma-eposta-ekle?firmaID=' + firmaID;
        });
    };
    var FirmaEpostaEkleBtnKaydet = function () {
        var form = $('#formEpostaEkle');
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
                'Eposta.EpostaAdresi': { minlength: 5, required: true, email: true },
                'Eposta.DurumID': { required: true }
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
    var FirmaEpostaEkleBtnVazgec = function () {
        $("#btn-yeni-eposta-vazgec").click(function () {
            var firmaID = $("#Eposta_FirmaID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/firma-eposta-listele?firmaID=' + firmaID; else return false;
        });
    };

    //FaturaBilgi
    var FirmaFaturaBilgiDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableFirmaFaturaBilgi');
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
    var FirmaFaturaBilgiFiltrele = function () {
        $('#faturabilgiBtnTumKayitlar').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("").trigger(e);
        });
        $('#faturabilgiBtnAktif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Aktif").trigger(e);
        });
        $('#faturabilgiBtnPasif').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Pasif").trigger(e);
        });
        $('#faturabilgiBtnTaslak').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Taslak").trigger(e);
        });
        $('#faturabilgiBtnSilinmis').click(function () {
            var e = jQuery.Event('keyup', { which: 13 });
            $("input.form-control.input-sm.input-small.input-inline").val("Silinmiş").trigger(e);
        });
    };
    var FirmaFaturaBilgiBtnYeniFaturaBilgi = function () {
        $("#btn-yeni-faturabilgi").click(function () {
            window.location.href = '/firma/firma-faturabilgi-ekle?firmaID=' + firmaID;
        });
    };
    var FirmaFaturaBilgiEkleBtnKaydet = function () {
        var form = $('#formFaturaBilgiEkle');
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
                'FaturaBilgi.VergiDairesi': { minlength: 2, required: true, number: false },
                'FaturaBilgi.VergiNo': { minlength: 10, maxlength: 10, required: true, number: true },
                'FaturaBilgi.AdresID': { required: true },
                'FaturaBilgi.DurumID': { required: true }
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
    var FirmaFaturaBilgiEkleBtnVazgec = function () {
        $("#btn-yeni-faturabilgi-vazgec").click(function () {
            var firmaID = $("#FaturaBilgi_FirmaID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/firma/firma-faturabilgi-listele?firmaID=' + firmaID; else return false;
        });
    };

    
    return {
        init: function () {
            BtnKaydet();
            BtnVazgec();
            FirmaAdresDataTable();
            FirmaAdresFiltrele();
            FirmaAdresBtnYeniAdres();
            FirmaAdresEkleBtnKaydet();
            FirmaAdresEkleBtnVazgec();
            FirmaTelefonDataTable();
            FirmaTelefonFiltrele();
            FirmaTelefonBtnYeniTelefon();
            FirmaTelefonEkleBtnKaydet();
            FirmaTelefonEkleBtnVazgec();
            FirmaEpostaDataTable();
            FirmaEpostaFiltrele();
            FirmaEpostaBtnYeniEposta();
            FirmaEpostaEkleBtnKaydet();
            FirmaEpostaEkleBtnVazgec();
            FirmaFaturaBilgiDataTable();
            FirmaFaturaBilgiFiltrele();
            FirmaFaturaBilgiBtnYeniFaturaBilgi();
            FirmaFaturaBilgiEkleBtnKaydet();
            FirmaFaturaBilgiEkleBtnVazgec();
        }
    };
}();