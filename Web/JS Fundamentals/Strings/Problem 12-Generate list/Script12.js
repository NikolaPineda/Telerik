/**
 * Created by Pineda on 6/5/2015.
 */
function testULGen() {
    var people =
        [
            { name: 'Georgi', age: 24 },
            { name: 'Pesho', age: 18 } ,
            { name: 'Chorban', age: 34 },
            { name: 'Fostata', age: 25 }
        ];
    var template = document.getElementById("list-item").innerHTML;
    document.getElementById("list-item").outerHTML = generateList(people, template);
}
function generateList(people, template) {
    var result = '';
    var addListItem = function (listItem) {
        var itemReplacer = function (match, p1) {
            return '<li>' + listItem[p1] + '</li>';
        };
        result += template.replace(/-\{(.*?)\}-/g, itemReplacer);
    };
    people.forEach(addListItem);
    return '<ul>' + result + '</ul>';
}
function stringFormat(str) {
    var strFormatArgs = arguments;

    var formatReplacer = function(match, p1) {
        return strFormatArgs[parseInt(p1) + 1] || match;
    };

    return str.replace(/{(\d+)\}/g, formatReplacer);
}