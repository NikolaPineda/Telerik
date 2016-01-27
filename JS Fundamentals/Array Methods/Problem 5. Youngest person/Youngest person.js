/*Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find*/
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
    new Person('Stoicho', 'Stoev', 20, true),
    new Person('Zdravko', 'Zdravkov', 21, true),
    new Person('Stoimen', 'Petkanov', 22, true),
    new Person('Cveta', 'Mincheva', 23, false),
    new Person('Temenuga', 'Peshova', 24, false),
    new Person('Ivan', 'Draganov', 15, true),
    new Person('Stoqn', 'Ivanov', 16, true),
    new Person('Kiril', 'Todorov', 17, true),
    new Person('Gerginka', 'Stoqnova', 18, false),
    new Person('Zoq', 'Petrova', 19, false)
];

function findYoungestMalePerson(arr){
    if(!Array.prototype.find){
        Array.prototype.find = function(callback){
            var i, len = this.length;
            for(i = 0; i < len; i+=1){
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        }
    }

    var youngestMale = arr
        .filter(function(person){
        return person.gender === 'male';
        })
        .sort(function(x, y){
            return x.age - y.age;
        })
        .find(function(item){
            if(item !== undefined){
                return item;
            }
        });

    console.log(youngestMale.toString())
}

findYoungestMalePerson(arrayOfPersons);