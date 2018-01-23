app.controller("MovieController", function ($scope, MovieService) {
    getTableData();
    $scope.MoviesHeader = "welcome";

    function getTableData() {
        MovieService.getData().then(function (d) {
            $scope.search = {};
            $scope.searchBy = '$';
            $scope.MovieList = JSON.parse(d.data)
                
        });
    }
});