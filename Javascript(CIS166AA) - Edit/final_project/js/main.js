/*  
    Brendan Ellison - BRE2161115
    11/18/2022
*/
/*
    Most of what I want to say will be above the related functions.
*/

// Global Variables

// Used for Blackjack
let playerHand = 0;
let dealerHand = 0;

//Used for Simon
let pattern = []; // values assigned ad hoc
let playerPattern = [100]; // 
let patternLength = 2; // assigns length of array, default of 2
let pseudoLoop = 0; // used to incrament player input, kind of like a loop.





/*
    This method decides the outcome of Rock, Paper, Scissors
    Grabs a random number and creates a quick comparison based on the button pressed
*/
function getOpponent(input) {
    let opponent = Math.floor(Math.random() * 3); // random number 0 -> 2
    let txtBox = document.getElementById("result"); // <p> element value

    // Validates the storage is there
    if(!sessionStorage.win && !sessionStorage.lose) {
        sessionStorage.win = 0;
        sessionStorage.lose = 0;
    }

    switch(opponent) {
        case 0: // Rock
        if(input == 1) { // win
            txtBox.innerHTML = "I picked rock.<br><br>You win.";
            sessionStorage.win++;
        } else if (input == opponent){ // tie
            txtBox.innerHTML = "I picked rock.<br><br>We tied.";
        } else { // lose
            txtBox.innerHTML = "I picked rock.<br><br>You lose.";
            sessionStorage.lose++;
        }
            break;

        case 1: // Paper
        if(input == 2) { // win
            txtBox.innerHTML = "I picked paper.<br><br>You win.";
            sessionStorage.win++;
        } else if (input == opponent){ // tie
            txtBox.innerHTML = "I picked paper.<br><br>We tied.";
        } else { // lose
            txtBox.innerHTML = "I picked paper.<br><br>You lose.";
            sessionStorage.lose++;
        }
            break;

        case 2: // Scissors
        if(input == 0) { // win
            txtBox.innerHTML = "I picked scissors.<br><br>You win.";
            sessionStorage.win++;
        } else if (input == opponent){ // tie
            txtBox.innerHTML = "I picked scissors.<br><br>We tied.";
        } else { // lose
            txtBox.innerHTML = "I picked scissors.<br><br>You lose.";
            sessionStorage.lose++;
        }
            break;

        default: // Error -- should never happen...
            txtBox = "Something is wrong. <br><br> You should not be seeing this...";
    } // END OF SWITCH

    // Updates the ratio
    getRatio();

} // END OF FUNCTION

function getRatio() { // Use session storage to generate a W/L ratio then output the results
    let ratio = Math.round((sessionStorage.win / sessionStorage.lose) * 100) / 100;
    document.getElementById("ratio").innerHTML = "Win: " + sessionStorage.win +
                                                " Loss: " + sessionStorage.lose + 
                                                " ratio: " + ratio;
} // END OF FUNCTION





/*
    This runs the mole game.
    This changes its position, then updates the score.
*/
function spawnMole() {
    /*
        These values are kind of weird for a reason:
        They are pulling the height/width values from the class,
        then dividing them because these values are diameters and the values I need are relative to the center,
        then it subtracts 20px as padding so that the "mole" is never out of bounds,
        BUT I will need negative values because it is relative to the center...
        so further on I will have it random add a - after picking a random number,
        this will create a similar effect to having a random value range in the negatives as it will be negative 50% of the time.
    */
    let maxX = (($("td.empty-space").width() / 2) -20);  // grabs max width
    let maxY = (($("td.empty-space").height() / 2) -20); // grabs max height 

    // Validates the storage is there
    if(!sessionStorage.clicks) {
        sessionStorage.clicks = 0;
    }

    let x = Math.floor(Math.random() * maxX) + 1; // generates the random number
    x *= Math.round(Math.random()) ? 1: -1; // randomly decides if it is - or not
    $(".mole").css("left", x); // updates X position
    let y = (Math.floor(Math.random() * maxY) + 1) * (Math.round(Math.random()) ? 1: -1); // same thing as x value, condensed
    $(".mole").css("top", y); // updates Y position
    
    updateScore(); // Updats text on bottom tracking clicks

} // END OF FUNCTION

// incraments times mole is clicked then updates the text on screen
function updateScore() {
    sessionStorage.clicks++;
    document.getElementById("score").innerHTML = "Current Score: " + sessionStorage.clicks;
} // END OF FUNCTION





/*
    Runs when the Hit button is clicked, updates the players hand with a new "card."
    WARNING: I have a lot to say here because this is a case of something being more involved then expected.
    I do not blame you if this falls under "Too Long Didn't Read."

    For simplicity this will simply be done with random numbers (1 - 10, no Ace).
    I have considered things like things like how a deck of 52 can be "counted,"
    and that could be done by calling some kind of list/array to simulate a deck,
    but I think that is a little beyond the scope I'm aiming for.

    I also think adding an ace would not be too hard, 
    simply have a condition that if one is drawn and the total is > 21 than - 10 from the total.
    This would create a problem with player feedback as to why it is happening,
    and would work better with something more fleshed out and focused. Again, beyond the scope im aiming for.

    There is also and argument to be made about if the dealer should be involved.
    He simply always draws and has no mind of his own. I think he add something more than nothing.
    But is should be said that your odds of winning are probably just as good, if not better, by just spamming the "hit" button.
    It would be easy enough to give him a cut off of something like > 16 (most people consider 17+ risky),
    but I decided that if they player cant see his hand then they can just assume hes stupid (he is).
    Maybe that could be the hard difficulty.
*/
function updateHand() {
    // grabs the <p> elements for easy of use
    let txtPlayer = document.getElementById("player");
    let txtDealer = document.getElementById("dealer");

    // draws a cards (random number 1 - 10)
    playerHand += Math.floor(Math.random() * 10) + 1
    dealerHand += Math.floor(Math.random() * 10) + 1

    // Validates player and dealer are not going over 21
    if(playerHand >= 21 || dealerHand >= 21) {
        getWinner();
    } else { // if not over 21, update text
        txtPlayer.innerHTML = "Your Hand: " + playerHand;
        txtDealer.innerHTML = "\"We have both drawn a card\"";
    }
    
} // END OF FUNCTION

/*
    Runs when fold button is hit, decides the winner
*/
function getWinner() {
    // grabs the <p> elements for easy of use
    let txtPlayer = document.getElementById("player");
    let txtDealer = document.getElementById("dealer");

    // Validates the storage is there
    if(!sessionStorage.playerWin && !sessionStorage.dealerWin) {
        sessionStorage.playerWin = 0;
        sessionStorage.dealerWin = 0;
    }

    // Check for losers
    if(playerHand > 21 && dealerHand > 21) { // both are losers
        txtPlayer.innerHTML = "It was a draw. <br>Your Hand: " + playerHand;
        txtDealer.innerHTML = "\"We both went over 21.\" <br>Dealers Hand: " + dealerHand;
    } else if (dealerHand > 21) { // dealer is a loser
        txtPlayer.innerHTML = "You Win! <br>Your Hand: " + playerHand;
        txtDealer.innerHTML = "\"Whoops.\" <br>Dealers Hand: " + dealerHand;
        sessionStorage.playerWin++;
    } else if (playerHand > 21) { // player is a loser
        txtPlayer.innerHTML = "You lost. <br>Your Hand: " + playerHand;
        txtDealer.innerHTML = "\"I Win!\" <br>Dealers Hand: " + dealerHand;
        sessionStorage.dealerWin++;
    } else {
        // decide a winner if neither is over 21
        if (playerHand > dealerHand) { // player wins
            sessionStorage.playerWin++;
            txtPlayer.innerHTML = "You Win! <br>Your Hand: " + playerHand;
            txtDealer.innerHTML = "\"I lost\" <br>Dealers Hand: " + dealerHand;
        } else { // dealer wins
            sessionStorage.dealerWin++;
            txtPlayer.innerHTML = "You lost. <br>Your Hand: " + playerHand;
            txtDealer.innerHTML = "\"I Win!\" <br>Dealers Hand: " + dealerHand;
        }
    } // END OF IF/ELSE

    getScore(); // updates the scores
    //update the hands for the next game
    playerHand = 0;
    dealerHand = 0;

} // END OF FUNCTION

/*
    I wanted to reused the ratio method, but I did a quick test
    and saw that the session storage is not per page.
    So, that meant it is simply easer to create another function that does something similar.
    obviously, this is not the best practice.
*/
function getScore() {
    let ratio = Math.round((sessionStorage.playerWin / sessionStorage.dealerWin) * 100) / 100;
        document.getElementById("ratio").innerHTML = "Player Win: " + sessionStorage.playerWin +
                                                    " Dealer Loss: " + sessionStorage.dealerWin + 
                                                    " ratio: " + ratio;
} // END OF FUNCTION





/*
    This is required as a learned jquery will override :hover in CSS
    This tells jquery to add these effects and should override the override...

    Yes, this was annoying.
*/
$(document).ready(function(){
    $(".btnGreen").hover(function(){
      $(this).css("background-color", "green");
      }, function(){
      $(this).css("background-color", "darkgreen");
    });
});
$(document).ready(function(){
    $(".btnRed").hover(function(){
      $(this).css("background-color", "red");
      }, function(){
      $(this).css("background-color", "darkred");
    });
});
$(document).ready(function(){
    $(".btnYellow").hover(function(){
      $(this).css("background-color", "yellow");
      }, function(){
      $(this).css("background-color", "gold");
    });
});
$(document).ready(function(){
    $(".btnBlue").hover(function(){
      $(this).css("background-color", "blue");
      }, function(){
      $(this).css("background-color", "darkblue");
    });
});

/*
    Called when starting Simon
    Serves as a way to start the process.

    ONCE AGAIN, I put too much trust in a switch to work properly...
    I have no idea why, but I could not pass an array through a switch.
    They should have been simple, patter[i] = 1 => case 1:
    but it just didn't... I am a little annoyed because this wasted a lot of time.
    I do not know if it was getting confused on value types,
    or it simply can not read a specified value from an array.
    This is what I got for trying to optimize.
*/
function simonStart() {
    // makes sure values are reset
    pattern = [];
    patternLength = 2;
    pseudoLoop = 0;

    document.getElementById("topText").innerHTML = "You must hit the buttons in the order they light up in." +
                                                " Every time you do it right, the pattern will get longer." +
                                                " This will continue untill you do the pattern wrong." +
                                                " Your highest streak will be saved, Good Luck.";

    // generates the pattern that the buttons will light up
    for(let i = 0; i < patternLength; i++) {
        // randomly picks a color (1 - 4) green = 1, red = 2, yellow = 3, blue = 4
        pattern[i] = Math.floor(Math.random() * 4) + 1;
    }

    // displays the correcto order to the player
    for(let i = 0; i < patternLength; i++) {
        
        // creates a way to emulate an async function
        // apperently sleep() in not a thing in JS and requires way more effort
        let interval = 1000 * i;
        
        // displays to player
        setTimeout(function(){
            if(pattern[i] === 1) {
                $(".btnGreen").css("background-color", "grey");
            } else if(pattern[i] === 2) {
                $(".btnRed").css("background-color", "grey");
            } else if(pattern[i] === 3) {
                $(".btnYellow").css("background-color", "grey");
            } else if(pattern[i] === 4) {
                $(".btnBlue").css("background-color", "grey");
            } else {
                alert("Something is wrong with the pattern...");
            }
        }, interval);

        // hides from player
        setTimeout(function(){
            if(pattern[i] === 1) {
                $(".btnGreen").css("background-color", "darkgreen");
            } else if(pattern[i] === 2) {
                $(".btnRed").css("background-color", "darkred");
            } else if(pattern[i] === 3) {
                $(".btnYellow").css("background-color", "gold");
            } else if(pattern[i] === 4) {
                $(".btnBlue").css("background-color", "darkblue");
            } else {
                alert("Something is wrong with the pattern...");
            }
        }, interval + 1000);
    }

} // END OF FUNCTION

/*
    Called when clicking on colored button for Simon
*/
function playerInput(color) {

    // adds players input to their array
    playerPattern[pseudoLoop] = color;
    // incraments array
    pseudoLoop++; // NOTE: this is here because .length does not start at 0

    // Validates if player is at end of the pattern
    if(pseudoLoop == pattern.length) {
        playerCompare();
    }

} // END OF FUNCTION

/*
    For Simon, called on loss
*/
function playerCompare() {

    // simple bool for out of loop
    let goodJob = true;
    
    // validates the patterns are the same
    for(let i = 0; i < patternLength; i++) {

        if(playerPattern[i] != pattern[i]) {
            
            // checks for new high score, - 1 because it starts at 2
            if(pattern.length - 1 > sessionStorage.highScore) {
                sessionStorage.highScore = pattern.length - 1;
            }
            // tells player they lost
            document.getElementById("topText").innerHTML = "You survived " + (pattern.length - 1) + " rounds," +
                                                            " Your current Highest is: " + sessionStorage.highScore + 
                                                            "<br>To try again, just hit start.";

            // Updates high score text
            getHighScore();

            goodJob = false;
            break;
        } 
    }

    // if nothing wrong, continue
    if(goodJob) {
        playerContinue();
    }

} // END OF FUNCTION

/*

*/
function playerContinue() {

    // resets player/pattern and increases pattern length
    pseudoLoop = 0;
    pattern = [];
    patternLength++;

    for(let i = 0; i < patternLength; i++) {
        // randomly picks a color (1 - 4) green = 1, red = 2, yellow = 3, blue = 4
        pattern[i] = Math.floor(Math.random() * 4) + 1;
    }

    // displays the correcto order to the player
    for(let i = 0; i < patternLength; i++) {
        
        // creates a way to emulate an async function
        // apperently sleep() in not a thing in JS and requires way more effort
        let interval = 1000 * i;
        
        // displays to player
        setTimeout(function(){
            if(pattern[i] == 1) {
                $(".btnGreen").css("background-color", "grey")
            } else if(pattern[i] == 2) {
                $(".btnRed").css("background-color", "grey")
            } else if(pattern[i] == 3) {
                $(".btnYellow").css("background-color", "grey")
            } else if(pattern[i] == 4) {
                $(".btnBlue").css("background-color", "grey")
            } else {
                alert("Something is wrong with the pattern...")
            }
        }, interval);

        // hides from player
        setTimeout(function(){
            if(pattern[i] == 1) {
                $(".btnGreen").css("background-color", "darkgreen")
            } else if(pattern[i] == 2) {
                $(".btnRed").css("background-color", "darkred")
            } else if(pattern[i] == 3) {
                $(".btnYellow").css("background-color", "gold")
            } else if(pattern[i] == 4) {
                $(".btnBlue").css("background-color", "darkblue")
            } else {
                alert("Something is wrong with the pattern...")
            }
        }, interval + 1000);
    }

}

/*
    Updates Highest Round for Simon
    called on load and or on loss
*/
function getHighScore() {
    // Validates storage is there
    if(!sessionStorage.highScore) {
        sessionStorage.highScore = 0;
    }

    // updates <p> element with highest round
    document.getElementById("highScore").innerHTML = "Highest Round: " + sessionStorage.highScore;

} // END OF FUNCTION