/*Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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
    new Person('Ivan', 'Draganov', 22, true),
    new Person('Stoqn', 'Ivanov', 22, true),
    new Person('Kiril', 'Todorov', 22, true),
    new Person('Gerginka', 'Stoqnova', 22, false),
    new Person('Zoq', 'Petrova', 19, false),
    new Person('Stoicho', 'Stoev', 20, true),
    new Person('Zdravko', 'Zdravkov', 21, true),
    new Person('Stoimen', 'Petkanov', 22, true),
    new Person('Cveta', 'Mincheva', 23, false),
    new Person('Temenuga', 'Peshova', 24, false)
];

function testAge(array){
    var ageTest = array.every(function(person){
        return person.age >= 18;
    });
    console.log(ageTest ? 'Every persons are bigger than 17 years old!': 'Not every persons are bigger than 17 years old!')
}

testAge(arrayOfPersons);