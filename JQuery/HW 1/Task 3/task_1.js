let lowest = +prompt("Enter lowest : ");
let highest = +prompt("Enter highest : ");

if (lowest > highest)
{
    let tmp = highest;
    highest = lowest;
    lowest = tmp;
}

let sum = 0;
for (let index = lowest; index < highest; index++) {
    sum += index;
}

alert(sum);