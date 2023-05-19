function getRandomArbitrary(min, max) {
    return Math.floor(Math.random() * (max - min) + min);
}

function mixArray(array)
{
    for (let i = 0; i < array.length - 1; i++) {
        let j = Math.floor(Math.random() * (i + 1));

        let temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
}

function countNumberOfWords(line) 
{
    let lineArray = line.split(' ');
    return lineArray.length;
}

function getInfoAboutSpam(line)
{
    line = String(line).toLowerCase();
    let lineArray = line.split(' ');
    for (let i = 0; i < lineArray.length; i++) {
        let item = lineArray[i] + " " + lineArray[i + 1];
        if (item == "100% бесплатно" || item == "увеличение продаж" || item == "только сегодня" || item == "не удаляйте" || item == "ххх")
        {
            return true;
        }
    }

    return false;
}

function truncate(line, symbols)
{
    let result = "";
    for (let i = 0; i < line.length; i++) {
        if (i == symbols + 1)
        {
            break;
        }
        result += line[i];
    }

    if (line != result)
    {
        result += "...";
    }

    return result;
}

let str = "A sentence is the largest grammatical unit in language 100% бесплатно";
let str1 = "A sentence is the largest grammatical unit in language";
let array = str.split(" ");

array.forEach(elem => {
    console.log(elem);
});

console.log("");

mixArray(array);

array.forEach(elem => {
    console.log(elem);
});

console.log(countNumberOfWords(str));
console.log(str);
console.log(getInfoAboutSpam(str));
console.log(getInfoAboutSpam(str1));


console.log(truncate("Hello World!", 4));
