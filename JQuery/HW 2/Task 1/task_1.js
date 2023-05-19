function Car(developer, model, year, speed)
{
    this.developer = developer;
    this.model = model;
    this.year = year;
    this.speed = speed;
}

function PrintCar(car)
{
    alert("Developer : " + car.developer + ", Model : " + car.model + ", Year : " + car.year + ", Speed : " + car.speed);
}

function countTime(car, distance)
{
    let time = distance / car.speed;
    let tmp = time / 4;
    time -= tmp;
    
    return time;
}

let car = new Car("Moto", "11KTR", 2005, 43);
PrintCar(car);

alert(countTime(car, 2000));