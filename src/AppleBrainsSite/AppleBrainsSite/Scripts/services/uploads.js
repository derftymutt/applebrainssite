(function () {
    "use strict"

    angular.module('app').factory('uploadsService', UploadsService);

    UploadsService.$inject = ['$http'];

    function UploadsService($http) {

        var service = this;

        service.create = function (data) {

            var eventConfig = {
                headers: {
                    'Content-Type': undefined
                }
            }

            return $http.post('/api/uploads', data, eventConfig);
        }



        return service;


    }


}());