let year = +prompt("Enter years : ");
let month = +prompt("Enter months : ");
let day = +prompt("Enter days : ");

while (true)
{
    if (month > 12) 
    {
        year++;
        month -= 12;
    }

    if (day > 30) 
    {
        month++;
        day -= 30;
    }

    if (month < 12 && day < 30) 
    {
        break;
    }
}

console.log(`Year : ${year} Month : ${month} Day : ${day}`);
