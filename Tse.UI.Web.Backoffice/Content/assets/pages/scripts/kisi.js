var KisiListele = function () {
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
                'targets': [0, 1, 2, 4]
            }, {
                "searchable": true,
                "targets": [0, 1, 2, 4]
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
    var BtnYeniKisi = function () {
        $("#btn-yeni-kisi").click(function () {
            window.location.href = '/kisi/kisi-ekle';
        });
    };
    return {
        init: function () {
            DataTable();
            Filtrele();
            BtnYeniKisi();
        }
    };
}();

var KisiEkle = function () {
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
                'Kisi.Adi': { minlength: 2, required: true },
                'Kisi.Soyadi': { minlength: 2, required: true },
                'Kisi.TcKimlikNo': { required: true, number: true, minlength: 11, maxlength: 11 },
                'Kisi.Unvan': { minlength: 2, required: true },
                'Kisi.FirmaID': { required: true },
                'Kisi.DurumID': { required: true }

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
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/listele'; else return false;
        });
    };
    return {
        init: function () {
            BtnKaydet();
            BtnVazgec();
        }
    };
}();

var KisiDuzenle = function () {
    //Kisi 
    var kisiID = $("#Kisi_KisiID").val();
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
                'Kisi.Adi': { minlength: 2, required: true },
                'Kisi.Soyadi': { minlength: 2, required: true },
                'Kisi.TcKimlikNo': { required: true, number: true, minlength: 11, maxlength: 11 },
                'Kisi.Unvan': { minlength: 2, required: true },
                'Kisi.FirmaID': { required: true },
                'Kisi.DurumID': { required: true }
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
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/listele'; else return false;
        });
    };

    //Adres
    var KisiAdresDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableKisiAdres');
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
    var KisiAdresFiltrele = function () {
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
    var KisiAdresBtnYeniAdres = function () {
        $("#btn-yeni-adres").click(function () {
            window.location.href = '/kisi/kisi-adres-ekle?kisiID=' + kisiID;
        });
    };
    var KisiAdresEkleBtnKaydet = function () {
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
    var KisiAdresEkleBtnVazgec = function () {
        $("#btn-yeni-adres-vazgec").click(function () {
            var kisiID = $("#Adres_KisiID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/kisi-adres-listele?kisiID=' + kisiID; else return false;
        });
    };

    //Telefon
    var KisiTelefonDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableKisiTelefon');
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
                "targets": [0, 1, 2]
            }],
            "order": [
                [1, "asc"]
            ]
        });
    };
    var KisiTelefonFiltrele = function () {
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
    var KisiTelefonBtnYeniTelefon = function () {
        $("#btn-yeni-telefon").click(function () {
            window.location.href = '/kisi/kisi-telefon-ekle?kisiID=' + kisiID;
        });
    };
    var KisiTelefonEkleBtnKaydet = function () {
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
    var KisiTelefonEkleBtnVazgec = function () {
        $("#btn-yeni-telefon-vazgec").click(function () {
            var kisiID = $("#Telefon_KisiID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/kisi-telefon-listele?kisiID=' + kisiID; else return false;
        });
    };

    //Eposta
    var KisiEpostaDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableKisiEposta');
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
                "targets": [0, 1]
            }],
            "order": [
                [1, "asc"]
            ]
        });
    };
    var KisiEpostaFiltrele = function () {
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
    var KisiEpostaBtnYeniEposta = function () {
        $("#btn-yeni-eposta").click(function () {
            window.location.href = '/kisi/kisi-eposta-ekle?kisiID=' + kisiID;
        });
    };
    var KisiEpostaEkleBtnKaydet = function () {
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
    var KisiEpostaEkleBtnVazgec = function () {
        $("#btn-yeni-eposta-vazgec").click(function () {
            var kisiID = $("#Eposta_KisiID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/kisi-eposta-listele?kisiID=' + kisiID; else return false;
        });
    };

    //FaturaBilgi
    var KisiFaturaBilgiDataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#tableKisiFaturaBilgi');
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
    var KisiFaturaBilgiFiltrele = function () {
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
    var KisiFaturaBilgiBtnYeniFaturaBilgi = function () {
        $("#btn-yeni-faturabilgi").click(function () {
            window.location.href = '/kisi/kisi-faturabilgi-ekle?kisiID=' + kisiID;
        });
    };
    var KisiFaturaBilgiEkleBtnKaydet = function () {
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
    var KisiFaturaBilgiEkleBtnVazgec = function () {
        $("#btn-yeni-faturabilgi-vazgec").click(function () {
            var kisiID = $("#FaturaBilgi_KisiID").val();
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/kisi/kisi-faturabilgi-listele?kisiID=' + kisiID; else return false;
        });
    };

    return {
        init: function () {
            BtnKaydet();
            BtnVazgec();
            KisiAdresDataTable();
            KisiAdresFiltrele();
            KisiAdresBtnYeniAdres();
            KisiAdresEkleBtnKaydet();
            KisiAdresEkleBtnVazgec();
            KisiTelefonDataTable();
            KisiTelefonFiltrele();
            KisiTelefonBtnYeniTelefon();
            KisiTelefonEkleBtnKaydet();
            KisiTelefonEkleBtnVazgec();
            KisiEpostaDataTable();
            KisiEpostaFiltrele();
            KisiEpostaBtnYeniEposta();
            KisiEpostaEkleBtnKaydet();
            KisiEpostaEkleBtnVazgec();
            KisiFaturaBilgiDataTable();
            KisiFaturaBilgiFiltrele();
            KisiFaturaBilgiBtnYeniFaturaBilgi();
            KisiFaturaBilgiEkleBtnKaydet();
            KisiFaturaBilgiEkleBtnVazgec();
        }
    };
}();