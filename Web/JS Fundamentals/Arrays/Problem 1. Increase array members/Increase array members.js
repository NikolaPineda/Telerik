/*Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.*/
var array  = new Array(20),
    i;

function printArray(arr){
    for (i = 0; i < arr.length; i += 1) {
        arr[i] = i * 5;
        console.log(arr[i]);
    }
}

printArray(array);