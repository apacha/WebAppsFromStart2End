angular.module('CoursesApp').factory('coursesFactory', function ($resource) {
    return $resource('/api/Courses/:id');
});