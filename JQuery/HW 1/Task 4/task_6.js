function sumNumbers(value)
{
    let str = String(value);
    let result = 0;
    for (let i = 0; i < str.length; i++) {
        result += parseInt(str[i]);
    }

    return result;
}

alert(sumNumbers(123123123312));