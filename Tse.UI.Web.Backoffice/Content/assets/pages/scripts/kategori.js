var Module = function () {

    //DataTable
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
                'targets': [0, 1, 2, 3, 4]
            }, {
                "searchable": true,
                "targets": [0, 1, 2, 3, 4]
            }],
            "order": [
                [1, "asc"]                
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
            var kategoriID = $("#Deger_KategoriID").val();
            window.location.href = '/kategori/ekle?kategoriID='+kategoriID;
        });
    }

    //BtnVazgeç
    var BtnVazgec = function () {
        $("#btnVazgec").click(function () {
            var kategoriID = $("#Deger_KategoriID").val();
            if (kategoriID == null) {
                var kategoriID = $("#StandartAtifTipiSablon_KategoriID").val();
            }
            window.location.href = '/kategori/listele?kategoriID='+kategoriID;
        });
    }

    //BtnKaydet (değerler için olan)
    var BtnKaydet = function () {
        var form1 = $('#form1'); //Form Adı
        var error1 = $('.alert-danger', form1);
        var success1 = $('.alert-success', form1);
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
                "Deger.KategoriID": {                    
                    required: true
                },
                "Deger.DegerAdiTr": {
                    minlength:2,
                    required: true
                },
                "Deger.DegerAdiEn": {
                    minlength:2,                    
                    required: true                    
                },
                "Deger.SiraNo": {                    
                    number: false,
                    required: true
                },
                "Deger.DurumID": {
                    required: true
                }
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

    //BtnAtifYapilanStandartKaydet
    var BtnAtifYapilanStandartKaydet = function () {
        var kategoriID = $("#StandartAtifTipiSablon_KategoriID").val();
        var standartAtifTipiSablonID = $("#StandartAtifTipiSablon_StandartAtifTipiSablonID").val();
        
        if (kategoriID == 8) {
            $("#displayName1").text("EN, ISO, IEC vb. No");
            $("#displayName2").text("Adı (En)");
            $("#displayName3").text("TS No");
            $("#displayName4").text("Adı (Tr)");
        }
        
        if (kategoriID == 9) {
            $("#displayName1").text("Doküman Adı");
            $("#displayName2").text("Yayımlayan Kurum");
            $("#displayName3").text("Hukuki Dayanak");
        }

        var form1 = $('#form1'); //Form Adı
        var error1 = $('.alert-danger', form1);
        var success1 = $('.alert-success', form1);
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
                "StandartAtifTipiSablon.Deger1": {
                    minlength: 2,
                    required: true
                },
                "StandartAtifTipiSablon.Deger2": {
                    minlength: 2,
                    required: true
                },
                "StandartAtifTipiSablon.Deger3": {
                    minlength: 2,
                    required: true
                },
                "StandartAtifTipiSablon.Deger4": {                    
                    minlength: 2,
                    required: true
                },
                "StandartAtifTipiSablon.DurumID": {
                    required: true
                }
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

    return {
        init: function () {
            var kategoriID = $("#StandartAtifTipiSablon_KategoriID").val();
            DataTable();
            Filtrele();
            BtnEkle();
            BtnVazgec();
            if (kategoriID==8 || kategoriID==9)
                BtnAtifYapilanStandartKaydet(); // Atıf yapılan standart
            else
                BtnKaydet(); //Değer kaydetme                        
       }
    };
}();

jQuery(document).ready(function () {
    Module.init();
});