var Listele = function () {   
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
                'targets': [0, 4, 5, 6]
            }, {
                "searchable": true,
                "targets": [0, 4, 5, 6]
            }],
            "order": [
                [0, "asc"]              ]
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
    var BtnDenetimStandart = function () {
        $("#btn-yeni-denetim").click(function () {
            window.location.href = '/denetim/ekle';
        });
    };    
    return {
        init: function () {
            DataTable();
            Filtrele();
            BtnDenetimStandart();
        }
    };
}();

var Ekle = function () {
    var BtnStandartKaydet = function () {
        var form = $('#form-standart-ekle');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);
        $('#kabul-tarihi').datepicker({
            format: 'dd.mm.yyyy',
            language: 'tr'
        });
        $('#Standart_TsNo').keyup(function () {
            resultTitle = "Yeni Standart";
            if ($('#Standart_TsNo').val() === null)
                resultTitle = "Yeni Standart";
            else {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() !== "")
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();
            }
            $('#standart-title').text(resultTitle);
        });
        $('#Standart_BaslikTr').keyup(function () {
            resultTitle = "Yeni Standart";
            if ($('#Standart_TsNo').val() === null)
                resultTitle = "Yeni Standart";
            else {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() !== "")
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();
            }
            $('#standart-title').text(resultTitle);
        });
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
                'Standart.TsNo': { minlength: 2, required: true },
                'Standart.KabulTarihi': { required: true },
                'Standart.YururlukDurumuID': { required: true },
                'Standart.BaslikTr': { required: true },
                'Standart.HazirlikGrubuID': { required: true },
                'Standart.DokumanTipiID': { required: true },
                'Standart.StandartTurID': { required: true },
                'Standart.BaslikEn': { required: true },
                'Standart.ParaBirimiID': { required: true },
                'Standart.DurumID': { required: true }
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
    var BtnStandartVazgec = function () {
        $("#btn-standart-vazgec").click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/standart/listele'; else return false; 
        });
    };
    return {
        init: function () {
            BtnStandartKaydet();
            BtnStandartVazgec();            
        }
    };
}();

var Duzenle = function () {
    var DataTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#table2');
        var oTable = table.dataTable({
            "lengthMenu": [
                [10, 20, 100, -1],
                [10, 20, 100, "Hepsi"]
            ],
            "pageLength": -1,
            "language": {
                "lengthMenu": " _MENU_ Kayıt"
            },
            "columnDefs": [{
                'orderable': true,
                'targets': [0, 1, 2, 3, 4]
            }, {
                "searchable": true,
                "targets": [0, 1, 2, 3, 4]
            }],
            "order": [
                [3, "asc"]
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
    var BtnStandartDuzenle = function () {
        var form = $('#form-standart-duzenle');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);
        $('#kabul-tarihi').datepicker({
            format: 'dd.mm.yyyy',
            language: 'tr'
        });
        $('#Standart_TsNo').keyup(function () {
            resultTitle = "Yeni Standart";
            if ($('#Standart_TsNo').val() === null)
                resultTitle = "Yeni Standart";
            else {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() !== "")
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();
            }
            $('#standart-title').text(resultTitle);
        });
        $('#Standart_BaslikTr').keyup(function () {
            resultTitle = "Yeni Standart";
            if ($('#Standart_TsNo').val() === null)
                resultTitle = "Yeni Standart";
            else {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() !== "")
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();
            }
            $('#standart-title').text(resultTitle);
        });
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
                'Standart.TsNo': { minlength: 2, required: true },
                'Standart.KabulTarihi': { required: true },
                'Standart.YururlukDurumuID': { required: true },
                'Standart.BaslikTr': { required: true },
                'Standart.HazirlikGrubuID': { required: true },
                'Standart.DokumanTipiID': { required: true },
                'Standart.StandartTurID': { required: true },
                'Standart.BaslikEn': { required: true },
                'Standart.ParaBirimiID': { required: true },
                'Standart.DurumID': { required: true }
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
    var BtnStandartVazgec = function () {
        $("#btn-standart-vazgec").click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/standart/listele'; else return false;
        });
    };
    var BtnIcerikEkleMenuItem = function () {
        $('.btnIcerikEkleMenuItem').click(function () {            
            $('#sablon-tipi-row').removeClass('display-show').addClass('display-hide');
            $('#icerik-ekle').removeClass('display-hide').addClass('display-show');
            $('#icerik-listele').removeClass('display-show').addClass('display-hide');
            $('#icerik-tipi-row').removeClass('display-hide').addClass('display-show');            
            $('#StandartIcerik_StandartIcerikTipiID').val($(this).attr('value')).trigger('change');
            $('#StandartIcerik_SiraNo').val(parseInt($('#table2 tr:last td:nth-child(4)').text()) + 1);
            $('#StandartIcerik_Detay').summernote('code', '');                        
        });
        $('#StandartIcerik_StandartIcerikTipiID').change(function () {        
            //Atıf Yapılan Standart / Döküman
            $('#atif-yapilan-standartlar-row').removeClass('display-show').addClass('display-hide');
            $('#atif-yapilan-dokumanlar-row').removeClass('display-show').addClass('display-hide');

            //Denetim - Tablo - Madde
            $('#icerik-denetim-row').removeClass('display-show').addClass('display-hide');
            $('#StandartIcerik_StandartIcerikDenetim_StandartIcerikID').val(0);
            $('#StandartIcerik_StandartIcerikDenetim_StandartID').val(0);

            if ($(this).val() === '161') {
                $('#atif-yapilan-standartlar-row').removeClass('display-hide').addClass('display-show');
                $('#atif-yapilan-dokumanlar-row').removeClass('display-hide').addClass('display-show');              
            }
            else if ($(this).val() === '171') {
                $('#icerik-denetim-row').removeClass('display-hide').addClass('display-show');
                $('#StandartIcerik_StandartIcerikDenetim_StandartIcerikID').val($('#StandartIcerik_StandartIcerikID').val());
                $('#StandartIcerik_StandartIcerikDenetim_StandartID').val($('#StandartIcerik_StandartID').val());
            }            
        });
    };    
    var BtnIcerikEkleKaydet = function () {
        var form = $('#form-icerik-ekle');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);
        $('#StandartIcerik_Detay').summernote({
            lang: "tr-TR",
            height: 300
        });        
        //API:
        //var sHTML = $('#summernote_1').code(); // get code
        //$('#summernote_1').destroy(); // destroy       
        $("#StandartIcerik_StandartAtifTipiSablonlar").multiSelect();
        $("#StandartIcerik_DokumanAtifTipiSablonlar").multiSelect();
  

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
            rules: { //Kurallar
                'StandartIcerik.StandartIcerikTipiID': { required: true },
                'StandartIcerik.UstIcerikID': { required: true },
                'StandartIcerik.YururlukDurumuID': { required: true },
                'StandartIcerik.SiraNo': { required: true },
                'StandartIcerik.DurumID': { required: true }
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
    var BtnIcerikEkleVazgec = function () {
        $('#btn-icerik-ekle-vazgec').click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) {
                $('#icerik-ekle').removeClass("display-show").addClass("display-hide"); $('#icerik-listele').removeClass("display-hide").addClass("display-show"); } else return false;
        });
    };
    var BtnIcerikDuzenleKaydet = function () {
        var form = $('#form-icerik-duzenle');
        var error = $('.alert-danger', form);
        var success = $('.alert-success', form);
        $('#StandartIcerik_Detay').summernote({
            lang: "tr-TR",
            height: 300
        });
        //API:
        //var sHTML = $('#summernote_1').code(); // get code
        //$('#summernote_1').destroy(); // destroy
       
        //Atıf Yapılan Standart / Döküman
        $('#atif-yapilan-standartlar-row').removeClass('display-show').addClass('display-hide');
        $('#atif-yapilan-dokumanlar-row').removeClass('display-show').addClass('display-hide');

        //Denetim - Tablo - Madde
        $('#icerik-denetim-row').removeClass('display-show').addClass('display-hide');
        $('#StandartIcerik_StandartIcerikDenetim_StandartIcerikID').val(0);
        $('#StandartIcerik_StandartIcerikDenetim_StandartID').val(0);           

        if ($('#StandartIcerik_StandartIcerikTipiID').val() === '161') {
            $('#atif-yapilan-standartlar-row').removeClass('display-hide').addClass('display-show');
            $('#atif-yapilan-dokumanlar-row').removeClass('display-hide').addClass('display-show');
        }
        else if ($('#StandartIcerik_StandartIcerikTipiID').val() === '171') {
            $('#icerik-denetim-row').removeClass('display-hide').addClass('display-show');
            $('#StandartIcerik_StandartIcerikDenetim_StandartIcerikID').val($('#StandartIcerik_StandartIcerikID').val());
            $('#StandartIcerik_StandartIcerikDenetim_StandartID').val($('#StandartIcerik_StandartID').val());
        }

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
            rules: { //Kurallar
                'StandartIcerik.StandartIcerikTipiID': { required: true },
                'StandartIcerik.UstIcerikID': { required: true },
                'StandartIcerik.YururlukDurumuID': { required: true },
                'StandartIcerik.SiraNo': { required: true },
                'StandartIcerik.DurumID': { required: true }
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
    var BtnIcerikDuzenleVazgec = function () {
        $('#btn-icerik-duzenle-vazgec').click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?')) window.location.href = '/standart/duzenle?standartID=' + $("#StandartIcerik_StandartID").attr("value"); else return false;
        });
    };

    return {
        init: function () {
            DataTable();
            Filtrele();
            BtnStandartDuzenle();
            BtnStandartVazgec();
            BtnIcerikEkleMenuItem();
            BtnIcerikEkleKaydet();
            BtnIcerikEkleVazgec();
            BtnIcerikDuzenleKaydet();
            BtnIcerikDuzenleVazgec();
        }
    };
}();