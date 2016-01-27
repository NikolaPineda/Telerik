/*Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.*/
Array.prototype.remove = function(number){
    for (var i = 0; i < this.length; i += 1) {
        if(number === this[i]){
            this.splice(i, 1);
        }
    }
};

function testNewRemove (){
    var array = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"];
    console.log(array);
    console.log('Number to remove is: 1');
    array.remove(1);
    console.log(array);
}
testNewRemove();
