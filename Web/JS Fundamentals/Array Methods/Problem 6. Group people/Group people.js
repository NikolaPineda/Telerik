/*Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
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

function groupPeople(arr){
    var sorted = arr.reduce(function (obj, item) {

        if (obj[item.firstName[0]]) {
            obj[item.firstName[0]].push(item);
        } else {
            obj[item.firstName[0]] = [item];
        }
        return obj;
    });

    console.log( JSON.stringify(sorted));
}

groupPeople(arrayOfPersons);