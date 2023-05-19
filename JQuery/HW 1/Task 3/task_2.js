let number = +prompt("Enter the number : ");

// First
// alert("Count of numbers : " + number.toString().length);

// Second
let i = 0;
if (number == 1 && number == 0)
{
    i++;
}

while (number > 1)
{
    number /= 10;
    i++;
    console.log(number);
}

alert("Count of numbers : " + i);
