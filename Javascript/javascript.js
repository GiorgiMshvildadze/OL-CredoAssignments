let random = Math.floor((Math.random() * 100) + 1);
let guess = 0;
let userGuessInt = 0;
const maxTries = 5;
let tries = maxTries;
let gamesWon = 0;
let gamesLost = 0;
function inputNumber() {
    guess = prompt("Enter your guess: ");
    userGuessInt = parseInt(guess);
}

while ( tries != 0 ) {
    inputNumber();
    if (userGuessInt > random) {
        console.log("Too high");
    }
    else if (random > userGuessInt) {
        console.log("Too Low");
    }
    else if(userGuessInt === random){
        console.log("Correct");
        gamesWon++;
        break;
    }
    tries--;
}
if (tries === 0 && userGuessInt != random){
    gamesLost++;
}
console.log("Games Won: "+ gamesWon);
console.log("Games Lost: "+ gamesLost);