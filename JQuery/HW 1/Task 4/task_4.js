function checkFuncTime(hour = "00", min = "00", sec = "00")
{
    if (hour > 23)
    {
        hour = "00";
    }

    if (min > 59)
    {
        hour = "00";
    }

    if (sec > 59)
    {
        sec = "00";
    }

    return `${hour}:${min}:${sec}`;
}

alert(checkFuncTime(30, 23, 43));