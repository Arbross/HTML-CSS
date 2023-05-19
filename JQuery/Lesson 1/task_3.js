let first = +prompt("Enter first mark(from 2 to 5) : ");
let second = +prompt("Enter second mark(from 2 to 5) : ");
let third = +prompt("Enter third mark(from 2 to 5) : ");

if (first > 5 || first < 2) first = 2;
if (second > 5 || second < 2) second = 2;
if (third > 5 || third < 2) third = 2;

let avgMark = (first + second + third) / 3;

Math.floor(avgMark);

switch (avgMark) {
  case 2:
    console.log("BAD");
    break;
  case 3:
    console.log("SO-SO");
    break;
  case 4:
    console.log("GOOD");
    break;
  case 5:
    console.log("EXCELLEND");
    break;
  default:
    console.log("Smth wrong");
    break;
}
