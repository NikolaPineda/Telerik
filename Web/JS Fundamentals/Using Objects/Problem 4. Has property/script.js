//Write a function that checks if a given object contains a given property.
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var result = document.getElementById('result'),
           inputNumber = document.getElementById('inputNumber').value,
           obj = {
               1: 'one',
               2: 'two',
               3: 'tree',
               4: 'four',
               5: 'five',
               6: 'six',
               7: 'seven',
               8: 'eight',
               9: 'nine',
               0: 'zero'
           };

       function searchForValue (obj, number){
           for (var item in obj){
               if(item === number){
                   result.innerHTML = 'Object contains ' + obj[number] + '!';
                   break;
               }
           }
       }

       searchForValue(obj, inputNumber);
   })
});