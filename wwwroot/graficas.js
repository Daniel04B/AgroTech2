window.inicializarGraficas = function () {

    var ctx =
        document.getElementById(
            'canvasHumedad');

    if (!ctx) return;

    var chartExistente =
        Chart.getChart(ctx);

    if (chartExistente) {
        chartExistente.destroy();
    }

    new Chart(ctx, {

        type: 'line',

        data: {

            labels: [
                '08:00 AM',
                '10:00 AM',
                '12:00 PM',
                '02:00 PM',
                '04:00 PM',
                '06:00 PM'
            ],

            datasets: [{

                label:
                    'Humedad del Suelo (%)',

                data: [45, 52, 61, 58, 70, 66],

                borderColor: '#198754',

                backgroundColor:
                    'rgba(25, 135, 84, 0.1)',

                borderWidth: 3,

                fill: true,

                tension: 0.4
            }]
        },

        options: {

            responsive: true,

            maintainAspectRatio: false,

            scales: {
                y: {
                    min: 0,
                    max: 100
                }
            }
        }
    });
};