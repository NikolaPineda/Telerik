/*Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.*/
document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('btn').addEventListener('click', function(){
        var digit = document.getElementById('digit').value,
            result = document.getElementById('result');

        switch (+digit){
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
            default:
                result.innerHTML = 'Invalid Input';
                break;

        }
    })
});
