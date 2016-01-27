//Write an expression that calculates rectangle’s area by given width and height.

document.addEventListener('DOMContentLoaded', function () {
    document.getElementById('btn').addEventListener('click', function(){
        var width = document.getElementById('width').value,
            height = document.getElementById('height').value,
            result = document.getElementById('result');

        if(isNaN(width)){
            result.innerHTML = "With is not a number!";
        }else if(isNaN(height)){
            result.innerHTML = 'Height is not a number!'
        }else {
            result.innerHTML = parseFloat(width) * parseFloat(height);
        }
    });
});
