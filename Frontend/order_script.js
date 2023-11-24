function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); // The maximum is exclusive and the minimum is inclusive
}
class CardOrder {
    constructor(title, description, data, time, difficalty) {
        this.title = title;
        this.description = description;
        this.data = data;
        this.time = time;
        this.difficalty = difficalty;
    }
}

var cards = [];

function GetFakeDB(){
    for (var i = 0; i < 25; ++i) {
        var card = new CardOrder("Test Task " + (i + 1), 
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "01-11-2023", "12:14", "Hard");
        var rand = getRandomInt(1, 4);
        switch(rand) {
            case 1:
                card.difficalty = "Hard";
            break;

            case 2:
                card.difficalty = "Normal";
            break;

            case 3:
                card.difficalty = "Easy";
            break;
        }
        cards.push(card);
    }

}

function Clear(){
    document.getElementById("orderCards").innerHTML = "";
    SetOrders();
    document.getElementById("search_prop").value = "";
}

function SetOrders(){
    document.getElementById("orderCards").innerHTML = "";
    for(var i = 0; i < cards.length; ++i) {
        document.getElementById("orderCards").innerHTML += `<div class="order_card">
                                                                <div class="card_left">
                                                                    <h1 class="card_header">${cards[i].title}</h1>
                                                                    <div class="card_description">
                                                                        ${cards[i].description}
                                                                    </div>
                                                                    <div class="card_helper">
                                                                        ${cards[i].data}&emsp;${cards[i].time}
                                                                    </div>
                                                                </div>
                                                                <div class="card_right">
                                                                    <div class="text_difficalty_${cards[i].difficalty.toLowerCase()}">${cards[i].difficalty}</div>
                                                                    <button type="button" class="btn btn-primary card_btn">View</button>
                                                                </div>
                                                            </div>`;          
    }
}

window.onload = function() {
    GetFakeDB();
    SetOrders();
} 


function FindByTitle() {
    var filter = document.getElementById("search_prop").value;
    document.getElementById("orderCards").innerHTML = "";
    for(var i = 0; i < cards.length; ++i) {
        if(cards[i].title.includes(filter)) {
            document.getElementById("orderCards").innerHTML += `<div class="order_card">
                                                                <div class="card_left">
                                                                    <h1 class="card_header">${cards[i].title}</h1>
                                                                    <div class="card_description">
                                                                        ${cards[i].description}
                                                                    </div>
                                                                    <div class="card_helper">
                                                                        ${cards[i].data}&emsp;${cards[i].time}
                                                                    </div>
                                                                </div>
                                                                <div class="card_right">
                                                                    <div class="text_difficalty_${cards[i].difficalty.toLowerCase()}">${cards[i].difficalty}</div>
                                                                    <button type="button" class="btn btn-primary card_btn">View</button>
                                                                </div>
                                                            </div>`;  
        }
    }
}

function FilterByDifficalty() {
    var cb_hard = document.getElementById("cb_hard");
    var cb_normal = document.getElementById("cb_normal");
    var cb_easy = document.getElementById("cb_easy");

    var check = 0;
    if(cb_hard.checked) {
        check = 1;
    }
    if(cb_normal.checked) {
        check = 1;
    }
    if(cb_easy.checked) {
        check = 1;
    }
    if(check == 1){
        var filterCards = [];

        for(var i = 0; i < cards.length; ++i) {
            if(cb_hard.checked) {
                if(cards[i].difficalty == "Hard") {
                    filterCards.push(cards[i]);
                }
            }
            if(cb_normal.checked) {
                if(cards[i].difficalty == "Normal") {
                    filterCards.push(cards[i]);
                }
            }
            if(cb_easy.checked) {
                if(cards[i].difficalty == "Easy") {
                    filterCards.push(cards[i]);
                }
            }
        }

        document.getElementById("orderCards").innerHTML = "";
        for(var i = 0; i < filterCards.length; ++i) {
            document.getElementById("orderCards").innerHTML += `<div class="order_card">
                                                                <div class="card_left">
                                                                    <h1 class="card_header">${filterCards[i].title}</h1>
                                                                    <div class="card_description">
                                                                        ${filterCards[i].description}
                                                                    </div>
                                                                    <div class="card_helper">
                                                                        ${filterCards[i].data}&emsp;${filterCards[i].time}
                                                                    </div>
                                                                </div>
                                                                <div class="card_right">
                                                                    <div class="text_difficalty_${filterCards[i].difficalty.toLowerCase()}">${filterCards[i].difficalty}</div>
                                                                    <button type="button" class="btn btn-primary card_btn">View</button>
                                                                </div>
                                                            </div>`;
        }
    } else {
        SetOrders();
    }
}

