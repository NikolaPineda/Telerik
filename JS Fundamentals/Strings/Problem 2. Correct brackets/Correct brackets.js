//Write a JavaScript function to check if in a given expression the brackets are put correctly.
var correctExpression = '((a+b)/5-d)',
    incorrectExpression = ')(a+b))';

function showResult(){
    var expression = document.getElementById('expressionInput').value;
    var result = checkExpression(expression);
    document.getElementById('result').innerHTML = result ? 'Correct': 'Incorrect';
}
function checkExpression(expr){
    var openBracket = 0,
        closeBracket = 0,
        i;
    for(i = 0; i < expr.length;i+=1){
        if(expr[i] === '('){
            openBracket+=1;
        }
        if(expr[i] === ')'){
            closeBracket+=1;
        }

    }
    if(openBracket === closeBracket){
        return true;
    }else{
        return false;
    }
}

console.log(checkExpression(correctExpression) ? 'correct' : 'incorrect');
console.log(checkExpression(incorrectExpression) ? 'correct' : 'incorrect');