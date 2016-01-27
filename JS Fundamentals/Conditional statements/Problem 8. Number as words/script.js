/*Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.*/
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var input = document.getElementById("number").value,
           result = 'Is not a valid number!',
           dec = [ "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"],
           special = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
           "seventeen", "eighteen", "nineteen"],
           mainDigits = [ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
       if (!(isNaN(input) || input > 999 || input < 0)) {
           var digit = parseInt(input % 10);
           var tens = parseInt((input / 10) % 10);
           var hundred = parseInt((input / 100) % 10);
           var stringName = '';
           var space = ' ';
           if (hundred != 0) {
               stringName += (mainDigits[hundred] + " hundred ");
               if (tens != 0 && tens != 1 && input >= 20) {
                   stringName += (" and " + dec[tens] + space);
                   if (digit != 0) {
                       stringName += (mainDigits[digit]);
                   }
               }
               else if (tens === 1) {
                   stringName += ("and " + special[digit]);
               }
               else {
                   if (digit != 0) {
                       stringName += ("and " + mainDigits[digit] + space);
                   }
               }
           }
           else {
               if (tens != 0 && tens != 1 && input >= 20) {
                   stringName += (space + dec[tens]);
                   if (digit != 0) {
                       stringName += (mainDigits[digit]);
                   }
               }
               else if (tens === 1) {
                   stringName += (space + special[digit]);
               }
               else {
                   stringName += (space + mainDigits[digit]);
               }
           }
           console.log(stringName);
           document.getElementById("result").innerHTML = stringName;
       } else {
           document.getElementById("result").innerHTML = "The input is invalid!";
       }
   })
});