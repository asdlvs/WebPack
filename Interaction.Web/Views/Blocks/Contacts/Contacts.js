app.controller('ContactsController', ['$scope', 'serverData', function($scope, serverData) {
    $scope.contacts = serverData.get('contacts');
    debug.pop('contacts');
}]);

app.config(function($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/contacts', { templateUrl: 'Contacts.jade' });
});