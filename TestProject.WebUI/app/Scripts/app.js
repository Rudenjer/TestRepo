var animalStoreApp = angular.module("animalStoreApp", ["ngRoute", "ui.bootstrap", "ngAnimate", "ngSanitize"]);

animalStoreApp.config(["$locationProvider", function ($locationProvider) {
    $locationProvider.hashPrefix("");
}]);

animalStoreApp.config(function ($routeProvider) {
    $routeProvider
        .when("/",{
            templateUrl: "app/Views/Owners/Index.html",
            controller: "OwnersController"
        })
        .when("/Owner/Details/:id",{
            templateUrl: "app/Views/Pets/PetsDetails.html",
            controller: "PetsController"
        })
        .otherwise({
            templateUrl: "/",
            controller: "OwnersController"
        });
});