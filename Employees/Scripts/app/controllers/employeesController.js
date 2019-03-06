var EmployeesController = ((employeesService) => {
    let init = (container) => {
        $(container).on("click", ".js-get-employees", getEmployees);
    };

    let getEmployees = (e) => {
        e.preventDefault();
        let employeeId = $(".js-employ-id").val();
        employeesService.getEmployees(employeeId, done, fail);
    };

    let done = (data) => {
        $('#employeesTable tr').not(':first').remove();
        let html = '';
        if (!$.isArray(data)) {
            html = generateTableRecord(data);
        } else {
            for (var i = 0; i < data.length; i++) {
                html += generateTableRecord(data[i]);
            }
        }

        $('#employeesTable tr').first().after(html);
    };

    let fail = () => {
        alert("It wasn't possible to load the Employee's data.");
    };

    let generateTableRecord = (employee) => {
        return '<tr>' +
            '<td>' + employee.Id + '</td>' +
            '<td>' + employee.Name + '</td>' +
            '<td>' + employee.ContractTypeName + '</td>' +
            '<td>' + employee.RoleId + '</td>' +
            '<td>' + employee.RoleName + '</td>' +
            '<td>' + employee.RoleDescription + '</td>' +
            '<td>' + employee.HourlySalaryText + '</td>' +
            '<td>' + employee.MonthlySalaryText + '</td>' +
            '<td>' + employee.AnnualSalaryText + '</td>' +
            '</tr>';
    };


    return {
        init,
    };

})(EmployeesService);
