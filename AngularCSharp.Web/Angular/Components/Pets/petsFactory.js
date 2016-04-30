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