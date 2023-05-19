function Product(name, count, isBought)
{
    this.name = name;
    this.count = count;
    this.isBought = isBought;
}

let list = [new Product("qwe", 534, false), new Product("fgd", 62, false), new Product("xcv", 123, true)];

function outByBuying(list)
{
    list.sort(x => x.isBought);

    let str = "";
    for (let i = 0; i < list.length; i++) {
        str += `Name : ${list[i].name}, Count : ${list[i].count}, Is bought : ${list[i].isBought}\n`; 
    }

    alert(str);
}

function addProduct(list, product)
{
    let isExist = 0;
    list.forEach(elem => {
        if (elem.name == product.name)
        {
            elem.count++;
            isExist = true;
            return;
        }
    });

    if (!isExist)
    {
        list.push(product);
    }
}

function buyProduct(list, product)
{
    list.forEach(elem => {
        if (product == elem.name)
        {
            elem.isBought = true;
            return;
        }
    });
}

outByBuying(list);
addProduct(list, new Product("fgd1", 62, false));
buyProduct(list, "qwe");

let str = "";
    for (let i = 0; i < list.length; i++) {
        str += `Name : ${list[i].name}, Count : ${list[i].count}, Is bought : ${list[i].isBought}\n`; 
    }
    alert(str);
