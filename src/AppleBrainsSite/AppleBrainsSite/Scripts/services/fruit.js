(function () {
    'use strict'

    angular.module('app').factory('fruitService', FruitService);

    FruitService.$inject = ['$http'];

    function FruitService($http) {

        var service = this;

        service.create = function (data) {
            return $http.post('/api/fruit/create', data);
        };

        service.get = function () {
            return $http.get('/api/fruit');
        }


        return service;
    }




}());