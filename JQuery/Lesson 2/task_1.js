function showOnlyPairElements(array)
{
    let str = "Array : ";
    array.forEach(item => {
        if (!(item % 2))
        {
            str += item + ", ";
        }
    });

    alert(str);
}

function addElementToArrayPerIndex(array, index, value)
{
    array[index] = value;
}

function getRandomArbitrary(min, max) {
    return Math.floor(Math.random() * (max - min) + min);
}

let array = [];
for (let i = 0; i < 10; i++) {
    array[i] = getRandomArbitrary(0, 100);
}

showOnlyPairElements(array);

addElementToArrayPerIndex(array, 10, 94);

showOnlyPairElements(array);