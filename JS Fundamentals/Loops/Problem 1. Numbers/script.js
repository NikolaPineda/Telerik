//Write a script that prints all the numbers from 1 to N.
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var number = document.getElementById('number').value;

       if(isNaN(number)){
           throw new Error('Invalid Input!')
       }else {
           for(var i = 0; i < number; i += 1){
               console.log(i);
           }
       }
   })
});