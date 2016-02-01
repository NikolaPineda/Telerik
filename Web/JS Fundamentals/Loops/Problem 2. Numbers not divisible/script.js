//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var number = document.getElementById('number').value;

       if(isNaN(number)){
           throw new Error('Invalid Input!')
       }else {
           for (var i = 0; i < number; i++) {
               if(!(i % 3) && !(i % 7)){
                   console.log(i);
               }
           }
       }
   })
});
