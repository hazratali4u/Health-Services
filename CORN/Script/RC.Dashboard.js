var RC = RC || {};

RC.Dashboard = {
    HandlerURL: RC.Common.RootURL + "Handler/DashboardHandler.ashx",
    FWBEChart: null,
    FWEChart: null,
    SWBEAChart: null,
    SWBEChart: null,
    SWEChart: null,
    SWBENOChart: null,
    SWENOChart: null,
    SSWRBEAChart: null,
    SSWRBEChart: null,
    SSWREChart: null,
    OWRBEAChart: null,
    OWRBEChart: null,
    OWREChart: null,
    FWRBEAChart: null,
    FWRBEChart: null,
    FWREChart: null,
    ADPSSChart: null,
    SSSSChart: null,
    CWRBEAChart: null,
    SetDatePicker: function () {
        $('#dtToDate').datepicker('destroy');
        $("#dtToDate").datepicker({
            dateFormat: 'yy-mm-dd',
            minDate: new Date(ddlCTSchemeFY.GetSelectedItem().texts[1]),
            maxDate: new Date(ddlCTSchemeFY.GetSelectedItem().texts[2]),
            onSelect: function (date) {
                RC.Dashboard.GenerateGraph();
            }
        }).datepicker("setDate", new Date(ddlCTSchemeFY.GetSelectedItem().texts[2]));
    },
    GenerateGraph: function () {
        $('#dvSGFundWise').hide();
        $('#dvSGStatusWise').hide();
        $('#dvSGSubSectorWise').hide();
        $('#dvSGObjectWise').hide();
        $('#dvSGFunctionWise').hide();
        $('#dvSGADPSummary').hide();
        $('#dvSGSubSectorSummary').hide();
        $('#dvSGConstituencyWise').hide();
        $('#dvDistrict').hide();
        $('#dvConstituency').hide();

        ddlCTSchemeFY.SetEnabled(false);
        ddlCTShowGraph.SetEnabled(false);

        $('#dvSRA .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSEA .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSRFG .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSEFG .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        if (ddlCTShowGraph.GetSelectedItem().value == "1") {
            RC.Dashboard.GenerateFundWiseChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "2") {
            RC.Dashboard.GenerateStatusWiseChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "3") {
            RC.Dashboard.GenerateSubSectorWiseChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "4") {
            RC.Dashboard.GenerateObjectWiseChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "5") {
            RC.Dashboard.GenerateFunctionWiseChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "6") {
            RC.Dashboard.GenerateADPSummaryChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "7") {
            RC.Dashboard.GenerateSubSectorSummaryChart();
        }
        else if (ddlCTShowGraph.GetSelectedItem().value == "8") {
            $('#dvDistrict').show();
            $('#dvConstituency').show();

            ddlDistrict.SetEnabled(false);
            ddlConstituency.SetEnabled(false);

            RC.Dashboard.GenerateConstituencyWiseChart();
        }
    },
    GenerateFundWiseChart: function () {
        $('#dvSGFundWise').show();

        if (RC.Dashboard.FWBEChart != null) {
            RC.Dashboard.FWBEChart.destroy();
        }
        if (RC.Dashboard.FWEChart != null) {
            RC.Dashboard.FWEChart.destroy();
        }

        $('#dvFWBudgetEstimate').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvFWExpenditure').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateFundWiseChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.FWBEChart = Highcharts.chart('dvFWBudgetEstimate', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition (Including ODP) - ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate',
                                colorByPoint: true,
                                data: response.Data.dataBE
                            }]
                        });

                        RC.Dashboard.FWEChart = Highcharts.chart('dvFWExpenditure', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure Composition (Including ODP) - ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure',
                                colorByPoint: true,
                                data: response.Data.dataE
                            }]
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateStatusWiseChart: function () {
        $('#dvSGStatusWise').show();

        if (RC.Dashboard.SWBEAChart != null) {
            RC.Dashboard.SWBEAChart.destroy();
        }
        if (RC.Dashboard.SWBEChart != null) {
            RC.Dashboard.SWBEChart.destroy();
        }
        if (RC.Dashboard.SWEChart != null) {
            RC.Dashboard.SWEChart.destroy();
        }
        if (RC.Dashboard.SWBENOChart != null) {
            RC.Dashboard.SWBENOChart.destroy();
        }
        if (RC.Dashboard.SWENOChart != null) {
            RC.Dashboard.SWENOChart.destroy();
        }

        $('#dvSWBudgetExpenditureAnalysis').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSWBudgetEstimate').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSWExpenditure').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSWBudgetEstimateNO').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSWExpenditureNO').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateStatusWiseChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.SWBEAChart = Highcharts.chart('dvSWBudgetExpenditureAnalysis', {
                            title: {
                                text: 'Budget Expenditure Analysis'
                            },
                            xAxis: {
                                categories: response.Data.categories
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        RC.Dashboard.SWBEChart = Highcharts.chart('dvSWBudgetEstimate', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate',
                                colorByPoint: true,
                                data: response.Data.dataBE
                            }]
                        });

                        RC.Dashboard.SWEChart = Highcharts.chart('dvSWExpenditure', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure',
                                colorByPoint: true,
                                data: response.Data.dataE
                            }]
                        });

                        RC.Dashboard.SWBEChart = Highcharts.chart('dvSWBudgetEstimateNO', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition ' + response.Data.fyTitle + ' (Based on ADP)'
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate NO',
                                colorByPoint: true,
                                data: response.Data.dataBENO
                            }]
                        });

                        RC.Dashboard.SWEChart = Highcharts.chart('dvSWExpenditureNO', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure ' + response.Data.fyTitle + ' (Based on ADP)'
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure NO',
                                colorByPoint: true,
                                data: response.Data.dataENO
                            }]
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateSubSectorWiseChart: function () {
        $('#dvSGSubSectorWise').show();

        if (RC.Dashboard.SSWRBEAChart != null) {
            RC.Dashboard.SSWRBEAChart.destroy();
        }
        if (RC.Dashboard.SSWRBEChart != null) {
            RC.Dashboard.SSWRBEChart.destroy();
        }
        if (RC.Dashboard.SSWREChart != null) {
            RC.Dashboard.SSWREChart.destroy();
        }

        $('#dvSSWRBudgetExpenditureAnalysis').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSSWRBudgetEstimate').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvSSWRExpenditure').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateSubSectorWiseChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.SSWRBEAChart = Highcharts.chart('dvSSWRBudgetExpenditureAnalysis', {
                            title: {
                                text: 'Budget Expenditure Analysis - ' + response.Data.fyTitle
                            },
                            xAxis: {
                                categories: response.Data.categories
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        RC.Dashboard.SSWRBEChart = Highcharts.chart('dvSSWRBudgetEstimate', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate',
                                colorByPoint: true,
                                data: response.Data.dataBE
                            }]
                        });

                        RC.Dashboard.SSWREChart = Highcharts.chart('dvSSWRExpenditure', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure Composition ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure',
                                colorByPoint: true,
                                data: response.Data.dataE
                            }]
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateObjectWiseChart: function () {
        $('#dvSGObjectWise').show();

        if (RC.Dashboard.OWRBEAChart != null) {
            RC.Dashboard.OWRBEAChart.destroy();
        }
        if (RC.Dashboard.OWRBEChart != null) {
            RC.Dashboard.OWRBEChart.destroy();
        }
        if (RC.Dashboard.OWREChart != null) {
            RC.Dashboard.OWREChart.destroy();
        }

        $('#dvOWRBudgetExpenditureAnalysis').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvOWRBudgetEstimate').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvOWRExpenditure').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateObjectWiseChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.OWRBEAChart = Highcharts.chart('dvOWRBudgetExpenditureAnalysis', {
                            title: {
                                text: 'Budget Expenditure Analysis - ' + response.Data.fyTitle
                            },
                            xAxis: {
                                categories: response.Data.categories
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        RC.Dashboard.OWRBEChart = Highcharts.chart('dvOWRBudgetEstimate', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition ' + response.Data.fyTitle + ' (Revenue)'
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate',
                                colorByPoint: true,
                                data: response.Data.dataBE
                            }]
                        });

                        RC.Dashboard.OWREChart = Highcharts.chart('dvOWRExpenditure', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure Composition ' + response.Data.fyTitle + ' (Revenue)'
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure',
                                colorByPoint: true,
                                data: response.Data.dataE
                            }]
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateFunctionWiseChart: function () {
        $('#dvSGFunctionWise').show();

        if (RC.Dashboard.FWRBEAChart != null) {
            RC.Dashboard.FWRBEAChart.destroy();
        }
        if (RC.Dashboard.FWRBEChart != null) {
            RC.Dashboard.FWRBEChart.destroy();
        }
        if (RC.Dashboard.FWREChart != null) {
            RC.Dashboard.FWREChart.destroy();
        }

        $('#dvFWRBudgetExpenditureAnalysis').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvFWRBudgetEstimate').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');
        $('#dvFWRExpenditure').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateFunctionWiseChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.FWRBEAChart = Highcharts.chart('dvFWRBudgetExpenditureAnalysis', {
                            title: {
                                text: 'Budget Expenditure Analysis - ' + response.Data.fyTitle
                            },
                            xAxis: {
                                categories: response.Data.categories,
                                min: 0,
                                max: 9,
                                scrollbar: {
                                    enabled: true
                                }
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        RC.Dashboard.FWRBEChart = Highcharts.chart('dvFWRBudgetEstimate', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Budget Composition ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Budget Estimate',
                                colorByPoint: true,
                                data: response.Data.dataBE
                            }]
                        });

                        RC.Dashboard.FWREChart = Highcharts.chart('dvFWRExpenditure', {
                            chart: {
                                plotBackgroundColor: null,
                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Expenditure Composition ' + response.Data.fyTitle
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                        style: {
                                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Expenditure',
                                colorByPoint: true,
                                data: response.Data.dataE
                            }]
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateADPSummaryChart: function () {
        $('#dvSGADPSummary').show();

        if (RC.Dashboard.ADPSSChart != null) {
            RC.Dashboard.ADPSSChart.destroy();
        }

        $('#dvADPSSummary').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateADPSummaryChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.ADPSSChart = Highcharts.chart('dvADPSSummary', {
                            title: {
                                text: 'ADP Summary (PKR in Million)'
                            },
                            xAxis: {
                                categories: response.Data.categories
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateSubSectorSummaryChart: function () {
        $('#dvSGSubSectorSummary').show();

        if (RC.Dashboard.SSSSChart != null) {
            RC.Dashboard.SSSSChart.destroy();
        }

        $('#dvSSSSummary').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateSubSectorSummaryChart',
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.SSSSChart = Highcharts.chart('dvSSSSummary', {
                            title: {
                                text: 'Sub-Sector Summary (PKR in Million)'
                            },
                            xAxis: {
                                categories: response.Data.categories
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    GenerateConstituencyWiseChart: function () {
        $('#dvSGConstituencyWise').show();

        if (RC.Dashboard.CWRBEAChart != null) {
            RC.Dashboard.CWRBEAChart.destroy();
        }

        $('#dvCWRBudgetExpenditureAnalysis').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.Dashboard.HandlerURL,
            {
                method: 'GenerateConstituencyWiseChart',
                DistrictId: ddlDistrict.GetSelectedItem().value,
                ConstituencyId: ddlConstituency.GetSelectedItem().value,
                FYId: ddlCTSchemeFY.GetSelectedItem().value,
                ToDate: $('#dtToDate').val()
            },
            function (response) {
                ddlCTSchemeFY.SetEnabled(true);
                ddlCTShowGraph.SetEnabled(true);
                ddlDistrict.SetEnabled(true);
                ddlConstituency.SetEnabled(true);

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.Dashboard.CWRBEAChart = Highcharts.chart('dvCWRBudgetExpenditureAnalysis', {
                            title: {
                                text: 'Constituency Wise (PKR in Million)'
                            },
                            xAxis: {
                                categories: response.Data.categories,
                                min: 0,
                                max: 4,
                                scrollbar: {
                                    enabled: true
                                }
                            },
                            yAxis: [{
                                labels: {
                                    format: '{value}',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: 'Millions',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                }
                            }, {
                                labels: {
                                    format: '{value}%',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                title: {
                                    text: '',
                                    style: {
                                        color: Highcharts.getOptions().colors[1]
                                    }
                                },
                                opposite: true
                            }],
                            tooltip: {
                                shared: true
                            },
                            labels: {
                                items: [{
                                    html: '',
                                    style: {
                                        left: '50px',
                                        top: '18px',
                                        color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                                    }
                                }]
                            },
                            series: response.Data.series
                        });

                        $('#dvSRA .number').html('<span>' + response.Data.perRA + '</span>%');
                        $('#dvSEA .number').html('<span>' + response.Data.perEA + '</span>%');
                        $('#dvSRFG .number').html('<span>' + response.Data.perRFG + '</span>%');
                        $('#dvSEFG .number').html('<span>' + response.Data.perEFG + '</span>%');

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    }
}

$(document).ready(function () {
    RC.Dashboard.SetDatePicker();
    RC.Dashboard.GenerateGraph();
});