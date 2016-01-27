/*Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.*/

var arrayOfPersons = [
    new Person('Georgi', 'Jeliaskov', 29),
    new Person('Stoqn', 'Canev', 28),
    new Person('Kamen', 'Georgiev', 31)
];

function Person(fName, lName, age){
    var that = this;

    this.firstName = fName;
    this.lastName = lName;
    this.Age = age;
    this.toString = function(){
        console.log(this.firstName + ' ' + this.lastName + ' ' + this.Age)
    };

    return that;
}

function searchForYoungestPerson(arrOfPersons){
    var youngestAge = 300,
        youngest;

    for (var i = 0; i < arrOfPersons.length; i += 1) {
        if(arrOfPersons[i].Age < youngestAge ){
            youngest = arrOfPersons[i];
            youngestAge = youngest.Age;
        }
    }
    console.log(youngest.firstName + ' ' + youngest.Age);
}

searchForYoungestPerson(arrayOfPersons);