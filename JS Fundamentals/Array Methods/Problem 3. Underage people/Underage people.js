/*Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)*/

function Person(fName, lName, age, gender){
    var that = this;
    this.firstName = fName;
    this.lastName = lName;
    this.age = age;
    this.gender = gender ? 'male' : 'female';
    this.toString = function(){
        return this.firstName + ' ' + this.lastName + ' ' +  this.age + ' ' + this.gender;
    };

    return that;
}

var arrayOfPersons = [
    new Person('Ivan', 'Draganov', 15, true),
    new Person('Stoqn', 'Ivanov', 16, true),
    new Person('Kiril', 'Todorov', 17, true),
    new Person('Gerginka', 'Stoqnova', 18, false),
    new Person('Zoq', 'Petrova', 19, false),
    new Person('Stoicho', 'Stoev', 20, true),
    new Person('Zdravko', 'Zdravkov', 21, true),
    new Person('Stoimen', 'Petkanov', 22, true),
    new Person('Cveta', 'Mincheva', 23, false),
    new Person('Temenuga', 'Peshova', 24, false)
];

function printUnderagePersons(arr){
    var filteredPersons = arr.filter(function(person){
        return person.age < 22;
    });

    filteredPersons.forEach(function(person){
        console.log(person.toString());
    })
}

printUnderagePersons(arrayOfPersons);