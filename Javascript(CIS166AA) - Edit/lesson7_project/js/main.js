/*  
    Brendan Ellison - BRE2161115
    10/3/2022
*/

//Create an array of 5 arrays
//Each inner array should contain a name and a number grade

let students = [["David", 80],
                ["Victor", 77],
                ["Tracy", 55],
                ["Jason", 95],
                ["Raymond", 69]
]; // effectivly a 2D array
// I am using the examples because I am lazy

//Create a function called getGrade with a parameter of grade
//Inside the function, create an if/else statement that accounts for grades and values from A to F

function getGrade(grade) {
    let letterGrade = "";
    if (grade >= 90){
        letterGrade = "A";
    }
    else if (grade >= 80 && grade < 90) {
        letterGrade = "B";
    }
    else if (grade >= 70 && grade < 80) {
        letterGrade = "C";
    }
    else if (grade >= 60 && grade < 70) {
        letterGrade = "D";
    }
    else {
        letterGrade = "F";
    }
    return letterGrade;
} // I wasted a lot of time using a switch statment because it has been a while.
// scrapped it because I forgot how specific the cases like to be.

//Create a FOR loop that iterates through the length of the students array and increments by 1 with each loop
//Inside the for loop, use document.write to output a string of text that displays each student's name, their numerical grade, and their letter grade:

let message = "";
for (let i = 0; i < students.length; i++) {
    message += students[i][0] + "'s number grade is " + students[i][1] + " and their letter grade is " + getGrade(students[i][1]) + "<br>";
}
document.getElementById("output").innerHTML = message;
// wasted time here because I declaired the variable and wrote in the element within the loop...