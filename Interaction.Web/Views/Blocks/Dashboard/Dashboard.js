
require('../Schedule/Schedule.js');

app.config(function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/data/page', {
            templateUrl: 'Dashboard.jade'
        });
});

