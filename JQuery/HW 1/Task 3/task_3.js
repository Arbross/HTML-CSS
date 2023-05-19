let positive = 0, negative = 0, pair = 0, unpair = 0;

for (let i = 0; i < 10; i++) {
    let number = +prompt("Enter the number : ");
    if (number > 0)
    {
        positive++;
    }

    if (number < 0)
    {
        negative++;
    }

    if (!(number % 2))
    {
        pair++;
    }

    if (number % 2)
    {
        unpair++;
    }
}

alert(`Positive : ${positive}, negative : ${negative}, pair : ${pair}, unpair : ${unpair}`);
