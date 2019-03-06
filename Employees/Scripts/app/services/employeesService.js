var EmployeesService = (() => {
    var getEmployees = (employeeId, done, fail) => {
        $.get("/api/employees/ " + employeeId)
            .done(done)
            .fail(fail);
    };

    return {
        getEmployees,
    };
})();
