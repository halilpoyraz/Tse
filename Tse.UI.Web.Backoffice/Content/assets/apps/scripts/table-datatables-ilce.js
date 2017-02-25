var TableDatatablesIlce = function () {
    var handleTable = function () {
        function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }
            oTable.fnDraw();
        }
        var table = $('#ilce');
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
                [0, "asc"]
            ]
        });       
    }
    return {
        init: function () {
            handleTable();
        }
    };
}();
jQuery(document).ready(function() {
    TableDatatablesIlce.init();
});