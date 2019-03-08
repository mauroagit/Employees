(function () {
    var employeesService = function ($http) {
        getEmployees = function (id) {
            return $http.get('/api/employees/' + id)
                .then((result) => {
                    let data = $.isArray(result.data) ? result.data : [result.data];
                    return data;
                });
        };

        return {
            getEmployees: getEmployees
        };
    };

    let app = angular.module('employeesApp');
    app.factory('employeesService', employeesService);
}());
