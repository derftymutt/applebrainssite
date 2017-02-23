(function () {

    angular.module('app').factory('$baseController', BaseController);


    BaseController.$inject = ['$document', '$log', '$route', '$routeparams', '$systemEventService', '$alertService'];

    function BaseController(
        $document
        , $log
        , $route
        , $routeparams
        , $systemEventService
        , $alertService) {

        var base = {
            $document : $document,
            $log : $log,
            $route: $route,
            $routeparams: $routeparams,
            $systemEventService : $systemEventService,
            $alertService: $alertService,
            merge : $.extend
        }

        return base;

        }

}());