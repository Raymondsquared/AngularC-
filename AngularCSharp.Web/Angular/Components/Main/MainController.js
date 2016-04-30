(function() 
{
    'use strict';

    angular
    	.module('AngularCSharp')
    	.controller('MainController', MainController);

    MainController.$inject = ['$scope', 'petsFactory'];


    function MainController($scope, petsFactory)
	{		
    	var vm = this;

    	vm.genderAndCats = [];

    	vm.getAllCatsForGender = getAllCatsForGender;

    	activate();
		
	    function activate() 
	    {
	        console.log("activate main");

	        vm.getAllCatsForGender();
	    }

	    function getAllCatsForGender()
        {
	        return petsFactory.getAllCatsGroupByGender()
				.then(function (response) {
				    if (response) {
				        vm.genderAndCats = response;
				    }
				});
        }
	}
})();