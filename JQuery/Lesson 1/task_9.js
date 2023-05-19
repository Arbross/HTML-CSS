let count = +prompt("Enter count of nums : ");

function fibonacci(max) {
  let a = 1;
  let b = 0;
  for (let i = 1; i <= max; i++) {
    let c = a + b;
    a = b;
    b = c;

    console.log(b);
  }
}

fibonacci(count);
