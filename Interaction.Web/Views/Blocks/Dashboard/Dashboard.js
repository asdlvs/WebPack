
require('../Schedule/Schedule.js');

app.config(function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/index', {
            templateUrl: 'Dashboard.jade'
        })
        .otherwise({ redirectTo: '/index' });
});

