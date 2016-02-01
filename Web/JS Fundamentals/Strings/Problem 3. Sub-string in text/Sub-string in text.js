//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var matchOptions = 'g';
var word = 'in';
function searchText(word, text){

    var resultArr = text.match(new RegExp(word, matchOptions));
    return resultArr ? resultArr.length : 0;
}
console.log(searchText(word, text));