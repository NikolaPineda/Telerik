/*Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.*/

function run(){
    var point1 = new Point(1,3),
        point2 = new Point(3, 10),
        a = new Line(new Point(1, 2), new Point(3, 4)),
        b = new Line(new Point(1, 4), new Point(3, 4)),
        c = new Line(new Point(1, 3), new Point(3, 4));

    console.log("The distance between " + point1 + " and " +
        point2 + " is: " + calculateLengthBetweenTwoPoints(point1, point2));
    console.log("The lines:");
    console.log(a);
    console.log(b);
    console.log(c);

    if (checkIfThreeLinesCanFormTriangle(a, b, c)) {
        console.log("Can form a triangle");
    }
    else {
        console.log("Cannot form a triangle");
    }
}

function calculateLengthBetweenTwoPoints(a, b){
    return new Line(a, b).getLength();
}

function checkIfThreeLinesCanFormTriangle(a, b, c){
    return (a.getLength() < b.getLength() + c.getLength()) &&
        (b.getLength() < a.getLength() + c.getLength()) &&
        (c.getLength() < a.getLength() + b.getLength());
}

function Point(x, y){
    var that = this;
    if(isNaN(x) || isNaN(y)){
        throw new Error('Invalid point coordinates!')
    }else {
        this.X = x;
        this.Y = y;
        this.toString = function(){
          return '[' + this.X + ',' + this.Y + ']';
        };

        return that;
    }
}

function Line(startPoint, endPoint){
    if(startPoint instanceof Point && endPoint instanceof Point){
        var that = this;

        this.startPoint = startPoint;
        this.endPoint = endPoint;
        this.toString = function(){
            return '{' + this.startPoint.toString() + ' ' + this.endPoint.toString() + '}';
        }
        this.getLength = function () {
            return Math.sqrt(Math.pow((endPoint.X - startPoint.X), 2) +
                Math.pow((endPoint.Y - startPoint.Y), 2));
        };

        return that;
    }
}

run();
