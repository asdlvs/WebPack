app.controller('ContactsController', ['$scope', 'serverData', function($scope, serverData) {
    $scope.contacts = serverData.get('contacts');
    debug.splice(debug.indexOf('contacts'), 1);
}]);

app.config(function($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/contacts', { templateUrl: 'Contacts.jade' });
});