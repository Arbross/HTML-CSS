var cardsChosen = [], cardsChosenId = [], cardsWon = [];

$("#finish").css({ "pointer-events": "none", "background-color": "gray" });

const cards = [
    { name: 'green', img: 'img/green.png' },
    { name: 'green', img: 'img/green.png' },
    { name: 'blue', img: 'img/blue.png' },
    { name: 'blue', img: 'img/blue.png' },
    { name: 'pink', img: 'img/pink.jpg' },
    { name: 'pink', img: 'img/pink.jpg' },
    { name: 'red', img: 'img/red.png' },
    { name: 'red', img: 'img/red.png' },
    { name: 'yellow', img: 'img/yellow.png' },
    { name: 'yellow', img: 'img/yellow.png' }
]

// Randomize array
function Random(array) {
    array.sort(() => 0.5 - Math.random());
}

// Create board
function CreateBoard() {
    for (let i = 0; i < cards.length; i++) {
        var card = document.createElement('img');

        card.setAttribute('src','img/black.jpg');
        card.setAttribute('data-id', i);
        card.addEventListener('click', Flip);

        $("#grid").append(card);
    }
}

// Checking
function Check () {
    var cards = document.querySelectorAll('img');
    const oneId = cardsChosenId[0];
    const twoId = cardsChosenId[1];

    if (cardsChosen[0] == cardsChosen[1])
    {
        cards[oneId].setAttribute('src','img/done.png');
        cards[twoId].setAttribute('src','img/done.png');
        cardsWon.push(cardsChosen);
    }
    else {
        cards[oneId].setAttribute('src','img/black.jpg');
        cards[twoId].setAttribute('src','img/black.jpg');
    }

    cardsChosen = [], cardsChosenId = []

    if (cardsWon.length == cards.length / 2)
    {
        $("#win-msg").css({ "visibility": "visible" });
    }
}

// Flip the card
function Flip() {
    var cardId = this.getAttribute('data-id');

    cardsChosen.push(cards[cardId].name);
    cardsChosenId.push(cardId);
    this.setAttribute('src', cards[cardId].img);

    if (cardsChosen.length === 2) {
        setTimeout(Check, 300);
    }
}

$("#start").click(function() {
    $("#start").css({ "pointer-events": "none", "background-color": "gray" });
    $("#finish").css({ "pointer-events": "auto", "background-color": "blue" });
    $("#win-msg").css({ "visibility": "hidden" });
    Random(cards);

    CreateBoard();
});

$("#finish").click(function() {
    location.reload();
});