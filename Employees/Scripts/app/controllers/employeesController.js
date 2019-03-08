(function () {
    var employeesController = function ($scope, employeesService) {
        $scope.searchId = '';

        $scope.getEmployees = function (e) {
            employeesService.getEmployees($scope.searchId)
                .then((data) => {
                    $scope.employees = data;
                }, (error) => console.log(error));
        };
    };

    let app = angular.module('employeesApp');
    app.controller('employeesController', employeesController);
}());
