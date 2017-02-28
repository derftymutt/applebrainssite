(function () {
    'use strict'

    angular.module('app').factory('fruitService', FruitService);

    FruitService.$inject = ['$http'];

    function FruitService($http) {

        var service = this;

        service.create = function (data) {
            return $http.post('/api/fruit/create', data);
        };


        return service;
    }




}());