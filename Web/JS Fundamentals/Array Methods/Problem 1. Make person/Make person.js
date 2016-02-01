/*Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders*/

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

arrayOfPersons.forEach(function(person){
    console.log(person.toString());
});