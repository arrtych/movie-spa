app.controller("MovieController", function ($scope, MovieService) {
    getTableData();
    $scope.MoviesHeader = "welcome";

    function getTableData() {
        MovieService.getData().then(function (d) {
            $scope.MovieList = JSON.parse(d.data)
            //$scope.MovieList = d.data;
        });
    }
});