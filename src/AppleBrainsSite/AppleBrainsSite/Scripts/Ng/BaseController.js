(function () {

    angular.module('app').factory('$baseController', BaseController);


    BaseController.$inject = ['$document', '$log'];

    function BaseController(
        $document
        , $log
        ) {

        var base = {
            $document : $document,
            $log : $log,
            merge : $.extend
        }

        return base;

        }

}());