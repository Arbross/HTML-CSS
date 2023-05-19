let date = new Date().getDay();
const weekday = new Array(7);
weekday[0] = "Sunday";
weekday[1] = "Monday";
weekday[2] = "Tuesday";
weekday[3] = "Wednesday";
weekday[4] = "Thursday";
weekday[5] = "Friday";
weekday[6] = "Saturday";

while (true) {
    if (date == 6)
    {
        date = 0;
    }

    let isContinue = confirm(`${weekday[date]}. Do you want to see the next day?`);
    if (!isContinue)
    {
        break;
    }
    else {
        date++;
    }
}