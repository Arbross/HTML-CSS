let symbol = +prompt("Enter the number from 0-9 : ");

if (symbol > 9 || symbol < 0) symbol = 0;

switch (symbol) {
  case 0:
      console.log(")");
    break;
  case 1:
    console.log("!");
    break;
  case 2:
    console.log("@");
    break;
  case 3:
    console.log("#");
    break;
  case 4:
    console.log("$");
    break;
  case 5:
    console.log("%");
    break;
  case 6:
    console.log("^");
    break;
  case 7:
    console.log("&");
    break;
  case 8:
    console.log("*");
    break;
  case 9:
    console.log("(");
    break;
  default:
    console.log("Smth wrong");
    break;
}
