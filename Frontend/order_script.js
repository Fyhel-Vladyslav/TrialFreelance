function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); // The maximum is exclusive and the minimum is inclusive
}
class CardOrder {
    constructor(title, description, date, difficalty, db, ref) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.difficalty = difficalty;
        this.db = db;
        this.ref = ref;
    }
}

var cards = [];

function GetFakeDB(){
    for (var i = 0; i < 25; ++i) {
        var card = new CardOrder("Test Task " + (i + 1), 
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "01-11-2023", "Hard" , 1, 1);
        var rand1 = getRandomInt(1, 4);
        switch(rand1) {
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
        var rand2 = getRandomInt(1, 3);
        switch(rand2) {
            case 1:
                card.db = 1;
            break;

            case 2:
                card.db = 2;
            break;
        }
        var rand3 = getRandomInt(1, 3);
        switch(rand3) {
            case 1:
                card.ref = 1;
            break;

            case 2:
                card.ref = 2;
            break;
        }
        cards.push(card);
    }

}

function Clear(){
    document.getElementById("orderCards").innerHTML = "";
    SetOrders(cards);
    document.getElementById("search_prop").value = "";
    document.getElementById("cb_hard").checked = false;
    document.getElementById("cb_normal").checked = false;
    document.getElementById("cb_easy").checked = false;
}


function SetOrders(prop_cards){
    document.getElementById("orderCards").innerHTML = "";

    var status_db = "";
    var status_ref = "";
 
    for(var i = 0; i < prop_cards.length; ++i) {
        if (prop_cards[i].db == 1) {
            status_db = `<div style="display: flex; flex-direction: row; margin-left: 50px;">
                                                                                    <svg xmlns="http://www.w3.org/2000/svg" style="margin-top: 3px" width="18" height="18" fill="forestgreen" class="bi bi-plus-square-fill" viewBox="0 0 16 16">
                                                                                        <path d="M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0"/>
                                                                                    </svg>
                                                                                    <p style="font-weight: bold; margin-left: 5px;">Data Base</p>
                                                                                </div>`;
        } else {
            status_db = `<div style="display: flex; flex-direction: row; margin-left: 50px;">
                                                                                    <svg xmlns="http://www.w3.org/2000/svg" style="margin-top: 3px" width="18" height="18" fill="darkred" class="bi bi-dash-square-fill" viewBox="0 0 16 16">
                                                                                        <path d="M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm2.5 7.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1 0-1"/>
                                                                                    </svg>
                                                                                    <p style="font-weight: bold; margin-left: 5px;">Data Base</p>
                                                                                </div>`
        }

        if(prop_cards[i].ref == 1) {
            status_ref =             `<div style="display: flex; flex-direction: row; margin-left: 20px;">
                                                                                <svg xmlns="http://www.w3.org/2000/svg" style="margin-top: 3px" width="18" height="18" fill="forestgreen" class="bi bi-plus-square-fill" viewBox="0 0 16 16">
                                                                                    <path d="M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0"/>
                                                                                </svg>
                                                                                <p style="font-weight: bold; margin-left: 5px;">Reference</p>
                                                                            </div>`;
        } else {
            status_ref =              `<div style="display: flex; flex-direction: row; margin-left: 20px;">
                                                                                <svg xmlns="http://www.w3.org/2000/svg" style="margin-top: 3px" width="18" height="18" fill="darkred" class="bi bi-dash-square-fill" viewBox="0 0 16 16">
                                                                                    <path d="M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm2.5 7.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1 0-1"/>
                                                                                </svg>
                                                                                <p style="font-weight: bold; margin-left: 5px;">Reference</p>
                                                                            </div>`;
        }

        document.getElementById("orderCards").innerHTML += 
        `<div class="order_card">
            <div class="card_left">
                <h1 class="card_header">${prop_cards[i].title}</h1>
                <div class="card_description">
                        ${prop_cards[i].description}
                </div>
                <div class="card_helper">
                    <p>Posted ${prop_cards[i].date}</p>
                    ${ status_db }
                    ${ status_ref }
                </div>
            </div>
            <div class="card_right">
                <div class="text_difficalty_${prop_cards[i].difficalty.toLowerCase()}">${prop_cards[i].difficalty}</div>
                    <button type="button" class="btn btn-primary card_btn">View</button>
                </div>
            </div>`; 
    }
}

window.onload = function() {
    GetFakeDB();
    SetOrders(cards);
} 


function FindByTitle() {
    var filter = document.getElementById("search_prop").value;
    document.getElementById("orderCards").innerHTML = "";
    var filterCards = [];
    for(var i = 0; i < cards.length; ++i) {
        if(cards[i].title.includes(filter)) {
            filterCards.push(cards[i]);
        }   
    }
    SetOrders(filterCards)
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
        SetOrders(filterCards)
    } else {
        SetOrders(cards);
    }
}

