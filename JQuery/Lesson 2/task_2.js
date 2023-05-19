let array = ["Orange", "Apple", "Banana"];

array.sort();

array.forEach(elem => {
    console.log(elem);
});

function findFruitPerName(name, array)
{
    let str = String(name).toLowerCase();
    
    for (let i = 0; i < array.length; i++) {
        if (str == array[i].toLowerCase())
        {
            return i;
        }
    }

    return -1;
}

console.log(findFruitPerName("Orange", array));