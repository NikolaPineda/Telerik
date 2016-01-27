//Write a function that returns the last digit of given integer as an English word.
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var number = document.getElementById('number').value,
           lastDigit = number[number.length - 1],
           result = document.getElementById('result');

       if(isNaN(number)){
           throw new Error('Invalid Input!');
       }else{
           switch (+lastDigit){
               case 0:
                   result.innerHTML = 'Zero';
                   break;
               case 1:
                   result.innerHTML = 'One';
                   break;
               case 2:
                   result.innerHTML = 'Two';
                   break;
               case 3:
                   result.innerHTML = 'Three';
                   break;
               case 4:
                   result.innerHTML = 'Four';
                   break;
               case 5:
                   result.innerHTML = 'Five';
                   break;
               case 6:
                   result.innerHTML = 'Six';
                   break;
               case 7:
                   result.innerHTML = 'Seven';
                   break;
               case 8:
                   result.innerHTML = 'Eight';
                   break;
               case 9:
                   result.innerHTML = 'Nine';
                   break;
           }
       }
   })
});