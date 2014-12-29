
app.controller('ScheduleController', ['$scope', 'serverData', function($scope, serverData) {
    $scope.schedule = serverData.get('schedule');
}]);