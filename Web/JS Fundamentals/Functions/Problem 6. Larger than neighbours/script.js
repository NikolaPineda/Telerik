/*Write a function that checks if the element at given position
 in given array of integers is bigger than its two neighbours (when such exist).*/

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var arrayOfNumbers = [15, 45, 98, 78, 32, 15, 45, 78, 65, 5, 1, 4, 78, 65, 32, 95, 85, 2, 4, 5, 22],
           result = document.getElementById('result'),
           number = document.getElementById('number').value,
           isBigger = false;

       if(isNaN(number) || number < 0 || number > 20){
           throw new Error('Invalid Input!')
       }else {
           if(+number === 0){
               if(arrayOfNumbers[number] > arrayOfNumbers[number + 1]){
                   isBigger = true;
               }
           }else if(+number === arrayOfNumbers.length){
               if(arrayOfNumbers[number] > arrayOfNumbers[number - 1]){
                   isBigger = true;
               }
           }else {
               if(arrayOfNumbers[+number] > arrayOfNumbers[+number + 1] && arrayOfNumbers[+number] > arrayOfNumbers[+number -1]){
                   isBigger = true;
               }
           }
           result.innerHTML = 'The number in position ' + number + 'is bigger then his neighbours: ' + isBigger
       }

   })
});