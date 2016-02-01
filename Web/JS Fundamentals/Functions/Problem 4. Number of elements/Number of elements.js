//Write a function to count the number of div elements on the web page

document.addEventListener('DOMContentLoaded', function(){
    function findNumberOfDivs(){
        var numberOfDivs = document.getElementsByTagName('div'),
            result = document.getElementById('result');

        result.innerHTML = numberOfDivs.length;
    }

    findNumberOfDivs();
});

