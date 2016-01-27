/*Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.*/
document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('btn').addEventListener('click', function(){
        var arrayOfNumbers = [15, 45, 98, 78, 32, 15, 45, 78, 65, 5, 1, 4, 78, 65, 32, 95, 85, 2, 4, 5, 22],
            result = document.getElementById('result'),
            number = document.getElementById('number').value,
            isBigger = false;

        function largerThanNeighbours(){
            switch (arguments.length){
                case 0: findFirstLarger(); break;
                case 1: checkIfBigger(arguments[0]); break;

            }

            function checkIfBigger(num){
                if(isNaN(num) || num < 0 || num > 20){
                    throw new Error('Invalid Input!')
                }else {
                    if(+num === 0){
                        if(arrayOfNumbers[num] > arrayOfNumbers[num + 1]){
                            isBigger = true;
                        }
                    }else if(+num === arrayOfNumbers.length){
                        if(arrayOfNumbers[num] > arrayOfNumbers[num - 1]){
                            isBigger = true;
                        }
                    }else {
                        if(arrayOfNumbers[+num] > arrayOfNumbers[+num + 1] && arrayOfNumbers[+num] > arrayOfNumbers[+num -1]){
                            isBigger = true;
                        }
                    }
                    result.innerHTML = 'The number in position ' + num + 'is bigger then his neighbours: ' + isBigger
                }
            }

            function findFirstLarger(){
                for (var i = 1; i < arrayOfNumbers.length -1; i++) {
                    if(arrayOfNumbers[i] > arrayOfNumbers[i -1] && arrayOfNumbers[i] > arrayOfNumbers[i + 1]){
                        result.innerHTML = arrayOfNumbers[i];
                        break;
                    }
                }
            }
        }
        largerThanNeighbours();

    })
});