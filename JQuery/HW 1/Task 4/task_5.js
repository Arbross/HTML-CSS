let num = +prompt("Enter number : ");

function reverseNumber(number)
{
    let result = "";
    let str = String(number);
    for (let i = str.length - 1; i >= 0; i--) {
        result += str[i];
    }

    return result;
}

alert("Result : " + reverseNumber(num));