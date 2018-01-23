app.service("MovieService", function ($http) {

    //display data
    this.getData = function () {
        return $http.get("/Home/GetData");
    }

    this.getByID = function () {
        return $http.get("Home/GetDataById");
    }

});