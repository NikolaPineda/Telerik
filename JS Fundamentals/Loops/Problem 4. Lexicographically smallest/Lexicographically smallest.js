//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
function findMinAndMax(){
    [document, window, navigator].forEach(findMinAndMaxObject)
}
function findMinAndMaxObject(obj){
    var min = 'zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz' + 'zzzzzzzzzzzzzzzzzzzz';
    var max = '';
    var currentProperty;
    for(var prop in obj){
        currentProperty = prop.toString();
        if(currentProperty < min){
            min = currentProperty;
        }
        if(currentProperty > max){
            max = currentProperty;
        }
    }
    console.log('In the' + obj)
    console.log('The lexicographically largest property is: ' + max);
    console.log('The lexicographically smallest property is' + min);
}