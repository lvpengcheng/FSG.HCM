<template>
    <a-card :style="{ height: '100%' }">
        <div class="sample-tutorial" style="width: 1800px;">
            <gc-spread-sheets hostClass="sample-spreadsheets" @workbookInitialized="initSpread">
            </gc-spread-sheets>
            <div class="options-container">
                <div class="option-row">
                    <p>Click this button to export the Spread component to a PDF file.</p>
                    <input type='button' id="savePDF" value="Export PDF" v-on:click='exportExcel()' />
                </div>
            </div>
        </div>
    </a-card>
</template>

<style>
.spread-host {
    width: 100%;
    height: 400px;
    border: 1px solid black;
}

.sample-tutorial {
    position: relative;
    height: 100%;
    overflow: hidden;
}

.sample-spreadsheets {
    width: 1800px;
    height: 800px;
    overflow: hidden;
    float: left;
}

.options-container {
    float: right;
    width: 280px;
    padding: 12px;
    height: 100%;
    box-sizing: border-box;
    background: #fbfbfb;
    overflow: auto;
}

.option-row {
    font-size: 14px;
    padding: 5px;
    margin-top: 10px;
}

input {
    padding: 8px 14px;
    display: block;
}

body {
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
}
</style>
<script>
/* eslint-disable */
// import '@/spreadjs/styles/gc.spread.sheets.excel2016colorful.css'
// //import '@grapecity/spread-sheets/styles/gc.spread.sheets.excel2016colorful.css'
// import GC from '@/spreadjs/gc.spread.sheets.all.min.js'
// import '@grapecity/spread-sheets-vue'
// import '@grapecity/spread-sheets-resources-zh'
// import ExcelIO from '@/spreadjs/gc.spread.excelio.min.js'
// import FaverSaver from 'file-saver'

import '@grapecity/spread-sheets/styles/gc.spread.sheets.excel2016colorful.css'
import GC from '@grapecity/spread-sheets'
import '@grapecity/spread-sheets-vue'
import ExcelIO from '@grapecity/spread-excelio'
import FaverSaver from 'file-saver'
//import '@grapecity/spread-sheets-print'
// GC.Spread.Sheets.LicenseKey = 'XXXXX-XXXXX-XXXXX-XXXXX'
//GC.Spread.Sheets.LicenseKey = ExcelIO.LicenseKey = "your key"
export default {
    data () {
        return {
            source: [
                { Course: "Calculus", Term: 1, Credit: 5, Score: 80, Teacher: "Nancy.Feehafer" },
                { Course: "P.E.", Term: 1, Credit: 3.5, Score: 85, Teacher: "Andrew.Cencini" },
                { Course: "Political Economics", Term: 1, Credit: 3.5, Score: 95, Teacher: "Jan.Kotas" },
                { Course: "Basic of Computer", Term: 1, Credit: 2, Score: 85, Teacher: "Steven.Thorpe" },
                { Course: "Micro-Economics", Term: 1, Credit: 4, Score: 62, Teacher: "Jan.Kotas" },
                { Course: "Linear Algebra", Term: 2, Credit: 5, Score: 73, Teacher: "Nancy.Feehafer" },
                { Course: "Accounting", Term: 2, Credit: 3.5, Score: 86, Teacher: "Nancy.Feehafer" },
                { Course: "Statistics", Term: 2, Credit: 5, Score: 85, Teacher: "Robert.Zare" },
                { Course: "Marketing", Term: 2, Credit: 4, Score: 70, Teacher: "Laura.Giussani" }
            ]
        }
    },
    methods: {
        initSpread: function (spread) {
            this.spread = spread;
            spread.suspendPaint();
            let spreadNS = GC.Spread.Sheets;
            let sheet = spread.getActiveSheet();
            let table = sheet.tables.addFromDataSource("Table1", 2, 1, this.source, spreadNS.Tables.TableThemes.medium2);
            table.showFooter(true);
            table.showHeader(true);
            table.highlightFirstColumn(true);
            table.highlightLastColumn(false);
            table.setColumnFormula(2, "=SUBTOTAL(109,[Credit])");
            table.setColumnFormula(3, "=SUBTOTAL(109,[Score])");
            table.setColumnValue(0, "Total");
            sheet.setColumnWidth(0, 20);
            sheet.setColumnWidth(1, 130);
            sheet.setColumnWidth(2, 70);
            sheet.setColumnWidth(3, 70);
            sheet.setColumnWidth(4, 70);
            sheet.setColumnWidth(5, 100);
            spread.resumePaint();
        },
        processFile (event) {
            this.excelFile = event.target.files[0]
        },
        importExcel () {
            var excelIO = new ExcelIO.IO()
            console.log(excelIO)
            var self = this
            excelIO.open(this.excelFile, function (json) {
                self.spread.fromJSON(json)
                console.log(json)
            })
        },
        exportExcel () {
            var excelIO = new ExcelIO.IO()
            var json = this.spread.toJSON()
            excelIO.save(
                json,
                function (blob) {
                    FaverSaver.saveAs(blob, 'export.xlsx')
                },
                function (e) {
                    console.log(e)
                }
            )
        },
        printWorkbook () {
            this.spread.print()
        },
        workbookInitialized (spread) {
            this.spread = spread
            spread.refresh()
        }
    }
}
</script>
