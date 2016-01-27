/*Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.*/
function deepCopy(variable){

    if(typeof variable !== 'object'){
        return variable;
    }
    var obj = {};
    for(var item in variable){
        obj[item] = deepCopy(variable[item])
    }
    return obj;
}
function deepCopyTest(){
    var variableTest = {
        firstName: 'Simon',
        lastName: 'Jiles'
    }
    var newVariable = deepCopy(variableTest);
    newVariable.firstName = 'jizu';
    console.log(variableTest.firstName);
    console.log(newVariable.firstName);
}

deepCopyTest();