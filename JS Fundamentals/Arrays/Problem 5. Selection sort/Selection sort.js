/*Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position,
  find the smallest from the rest, move it at the second position, etc.*/
function sortArray(){
    var array = [1,8,9,4,5,6,7,2,3,15,48,36];
    var i;
    var j;
    var tmp
    for ( i = 0; i < array.length - 1; i++)
    {
        for ( j = i + 1; j < array.length; j++)
        {
            if (array[i] > array[j]) // swap items
            {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    for ( i = 0; i < array.length; i++) // print sorted array
    {
        console.log(array[i] + " ");
    }
}

sortArray();