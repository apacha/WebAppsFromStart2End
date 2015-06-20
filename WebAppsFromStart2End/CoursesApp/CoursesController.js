angular.module('CoursesApp').controller('coursesController',
    function ($scope, coursesFactory) {
    $scope.courseList = coursesFactory.query();
    $scope.save = function (vm) {
        coursesFactory.save(vm);
        $("#newCourseForm")[0].reset();
        // This pushes the item directly to the list, but does not clear the data from the form and creates a linked connection.
        //$scope.courseList.push(vm);        
    };

    var rproxy = $.connection.coursesHub;
    rproxy.on('addCourse', function (c) {        
        $scope.courseList.push(c);
        $scope.$apply();
    });

    $.connection.hub.start();
});