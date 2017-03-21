(function() {
    var OwnersController = function ($scope, $http) {

        var getOwners = function() {
            $http.get('http://localhost:57113/api/Owner')
                .then(function(response) {
                    $scope.Owners = response.data;
                })
                .then(function () {
                    var begin = (($scope.currentPage - 1) * $scope.numPerPage)
                        , end = begin + $scope.numPerPage;
                    $scope.totalItems = $scope.Owners.length * 10 / $scope.numPerPage;
                    $scope.filteredTodos = $scope.Owners.slice(begin, end);
                });
        };

        $scope.pageChanged = function () {
            var begin = (($scope.currentPage - 1) * $scope.numPerPage)
                , end = begin + $scope.numPerPage;

            $scope.filteredTodos = $scope.Owners.slice(begin, end);
        };

        $scope.filteredTodos = []
            , $scope.currentPage = 1
            , $scope.numPerPage = 3
            , $scope.totalItems = 1;

        getOwners();

        $scope.createOwner = function() {
            var group = {
                Name: $scope.Name
            };

            $http.post('http://localhost:57113/api/Owner', group)
                .then(function() {
                    getOwners();
                });
        };

        $scope.deleteOwner = function(ownerId) {
            $http.delete('http://localhost:57113/api/Owner' + "/" + ownerId)
                .then(function() {
                    getOwners();
                });
        };
    };

    animalStoreApp.controller("OwnersController", ["$scope", "$http", OwnersController]);
}());