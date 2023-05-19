let maxPoint = +prompt("Set max of points to win : ");

function getRandomArbitrary(min, max) {
  return Math.random() * (max - min) + min;
}

let human = 0, bot = 0;

while (true) {
  let first_human = Math.floor(getRandomArbitrary(1, 6));
  let second_human = Math.floor(getRandomArbitrary(1, 6));

  if (first_human == second_human) human += 2;

  let first_bot = Math.floor(getRandomArbitrary(1, 6));
  let second_bot = Math.floor(getRandomArbitrary(1, 6));

  if (first_bot == second_bot) bot += 2;

  if (first_human + second_human > first_bot + second_bot) human++;
  if (first_human + second_human < first_bot + second_bot) bot++;

  if (human >= maxPoint) { console.log("Human is the winner."); break; }
  
  if (bot >= maxPoint) { console.log("Bot is the winner."); break; }

  console.log(`Human : ${human}`);
  console.log(`Bot : ${bot}`);
}
