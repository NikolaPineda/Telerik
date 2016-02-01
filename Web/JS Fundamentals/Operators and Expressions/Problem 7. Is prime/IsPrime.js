//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var number = document.getElementById('inputNumber').value,
           result = document.getElementById('result'),
           i;

       if(isNaN(number) && parseInt(number) > 100){
           result.innerHTML = 'Incorrect input!'
       }else if(parseInt(number) < 2){
           result.innerHTML = number + 'is not prime!'
       }else {
           for(i = 2; i<= Math.sqrt(parseInt(number)); i+=1){
               if(number % i === 0){
                   return  result.innerHTML = number + ' is not prime number!'
               }
           }
           return result.innerHTML = number + ' is prime number!';
       }
   })
});
