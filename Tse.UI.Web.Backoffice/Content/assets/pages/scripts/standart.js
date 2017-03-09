var Module = function () {

    //DataTables
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
                'targets': [0, 1, 2,3]
            }, {
                "searchable": true,
                "targets": [0, 1, 2,3]
            }],
            "order": [
                [1, "asc"],
                [2, "asc"],
                [3, "asc"]
            ]
        });
    }
    var DataTable2 = function () {
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
    }

    // Filtrele
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
    }

    //BtnEkle
    var BtnEkle = function () {
        $("#btnEkle").click(function () {
            window.location.href = '/standart/ekle';
        });
    }

    //BtnVazgeç
    var BtnVazgec = function () {
        $("#btnVazgec").click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?'))
            { window.location.href = '/standart/listele'; }
            else
            { e.preventDefault(); }
        });
    }

    //BtnKaydet
    var BtnKaydet = function () {
        var form1 = $('#form1'); //Form Adı
        var error1 = $('.alert-danger', form1);
        var success1 = $('.alert-success', form1);
        $('#kabulTarihi').datepicker({
            format: 'dd.mm.yyyy',
            language: 'tr'
        });
        $('#Standart_TsNo').keyup(function () {
            resultTitle = "Yeni Standart"
            if ($('#Standart_TsNo').val()==null) 
                resultTitle = "Yeni Standart"            
            else
            {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() != "")                 
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();                
            }
            $('#standart-title').text(resultTitle);
        });
        $('#Standart_BaslikTr').keyup(function () {
            resultTitle = "Yeni Standart"
            if ($('#Standart_TsNo').val() == null)
                resultTitle = "Yeni Standart"
            else {
                resultTitle = $('#Standart_TsNo').val();
                if ($('#Standart_BaslikTr').val() != "")
                    resultTitle = resultTitle + ' - ' + $('#Standart_BaslikTr').val();
            }
            $('#standart-title').text(resultTitle);
        });

        form1.validate({
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
                'Standart.TsNo': { minlength: 2, required: true },
                'Standart.KabulTarihi': { required: true },
                'Standart.YururlukDurumuID': { required: true },
                'Standart.BaslikTr': { required: true },                
                'Standart.HazirlikGrubuID': { required: true },
                'Standart.DokumanTipiID': { required: true },
                'Standart.StandartTurID': { required: true },
                'Standart.BaslikEn': { required: true },
                'Standart.ParaBirimiID': { required: true },
                'Standart.DurumID': { required: true },                
            },

            invalidHandler: function (event, validator) {
                success1.hide();
                error1.show();
                App.scrollTo(error1, -200);
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
    }
    
    //BtnIcerikKaydet
    var BtnIcerikKaydet = function () {
        var form3 = $('#form3'); //Form Adı
        var error1 = $('.alert-danger', form3);
        var success1 = $('.alert-success', form3);

        form3.validate({
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
                'StandartIcerik.DurumID': { required: true },               
            },

            invalidHandler: function (event, validator) {
                success1.hide();
                error1.show();
                App.scrollTo(error1, -200);
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
    }

    //BtnIcerikEkleMenuItem
    var BtnIcerikEkleMenuItem = function () {
        $('.btnIcerikEkleMenuItem').click(function () {
            $('#icerik-ekle').addClass("display-show");
            $('#icerik-listele').removeClass("display-show").addClass("display-hide");            
            $('#StandartIcerik_StandartIcerikTipiID').val($(this).attr("value"));            
            $('#StandartIcerik_Detay').summernote("code", "");
        });
    }

    //BtnIcerikEkleVazgec
    var BtnIcerikEkleVazgec = function () {
        $('#btn-icerik-ekle-vazgec').click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?'))
            {
            $('#icerik-ekle').removeClass("display-show").addClass("display-hide");
            $('#icerik-listele').removeClass("display-hide").addClass("display-show");            
            }
            else
                e.preventDefault();
        });
    }

    //BtnIcerikDuzeleVazgec
    var BtnIcerikDuzenleVazgec = function () {
        $('#btn-icerik-duzenle-vazgec').click(function () {
            if (confirm('Yaptığınız değişiklikler henüz kayıt edilmedi. Bu ekrandan ayrılmak istediğinize emin misiniz?'))                           
                window.location.href = '/standart/duzenle?standartID=' + $("#StandartIcerik_StandartID").attr("value");            
            else
                e.preventDefault();
        });
    }

  
    //Editors
    var handleSummernote = function () {      
        $('#StandartIcerik_Detay').summernote({
            lang: "tr-TR",
            height: 300
        });
        //API:
        //var sHTML = $('#summernote_1').code(); // get code
        //$('#summernote_1').destroy(); // destroy
    }

    return {
        init: function () {
            //Listeleme
              DataTable();              
              Filtrele();
              BtnEkle();
            //Ekleme - Düzeltme
              DataTable2();
              BtnVazgec();
              BtnKaydet();
              BtnIcerikEkleMenuItem();
              BtnIcerikEkleVazgec();
              BtnIcerikDuzenleVazgec();
              handleSummernote();
              BtnIcerikKaydet();
        }
    };   
}();

jQuery(document).ready(function () {
    Module.init();    
});