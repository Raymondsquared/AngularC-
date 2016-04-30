/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};

/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {

/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;

/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};

/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;

/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}


/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;

/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;

/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";

/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ function(module, exports, __webpack_require__) {

	__webpack_require__(1);

	__webpack_require__(4);

	console.log('app has been loaded');

/***/ },
/* 1 */
/***/ function(module, exports, __webpack_require__) {

	(function() {
	    'use strict';

	    angular.module('AngularCSharp',[]);

	})();

	__webpack_require__(2);

	__webpack_require__(3);

/***/ },
/* 2 */
/***/ function(module, exports) {

	(function() 
	{
	    'use strict';

	    angular
	    	.module('AngularCSharp')
	    	.factory('petsFactory', petsFactory);

	    petsFactory.$inject = ['$http'];

	    function petsFactory($http)
		{
			var vm = this;

			activate();

			var Functions = 
			{
			    getAllCatsGroupByGender: getAllCatsGroupByGender
			};

			return Functions;

			function activate()
			{
				console.log("petsFactory is activated");	
			}

			function getAllCatsGroupByGender() {
			    return $http.get('http://localhost:58195/api/v1/cats?groupBy=0')
					.then(getAllCatsGroupByGenderCompleted)
					.catch(getAllCatsGroupByGenderFailed);

				function getAllCatsGroupByGenderCompleted(response) {			    
					if(response)
					{
					    console.log("getAllCatsGroupByGenderCompleted");
						console.log(response);
						
						return response.data;
					}
				}

				function getAllCatsGroupByGenderFailed(error)
				{
				    console.log("getAllCatsGroupByGenderFailed ");
				    console.log(error);
				}
			}
		}
	})();

/***/ },
/* 3 */
/***/ function(module, exports) {

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

/***/ },
/* 4 */
/***/ function(module, exports) {

	/*
	$(function()
	{
	});
	*/

/***/ }
/******/ ]);