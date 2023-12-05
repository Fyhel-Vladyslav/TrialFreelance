document.addEventListener("DOMContentLoaded", function () {
        var homeElement = document.getElementById("nav-link-orders");
        if (homeElement)
            homeElement.classList.add("active");

    });

    function redirect(id) {
        window.location.href = ("/Order/Order/" + id);
    }

    var elements = Array.from(document.querySelectorAll('.order_card'));
    var orders = document.getElementById("orderCards");
    var search_prop = document.getElementById("search_prop");
    var cb_unpossible = document.getElementById("cb_unpossible");
    var cb_hard = document.getElementById("cb_hard");
    var cb_middle = document.getElementById("cb_middle");
    var cb_normal = document.getElementById("cb_normal");
    var cb_easy = document.getElementById("cb_easy");
    let temp_options = [];

    function Clear() {
        orders.innerHTML = "";
        SetOrders();
        search_prop.value = "";
        cb_unpossible.checked = false;
        cb_hard.checked = false;
        cb_middle.checked = false;
        cb_normal.checked = false;
        cb_easy.checked = false;
    }
    function SetAll()
    {
        cb_unpossible.checked = true;
        cb_hard.checked = true;
        cb_middle.checked = true;
        cb_normal.checked = true;
        cb_easy.checked = true;
        ViewOrdersByDiff();
    }
    function ViewOrdersByDiff() {
        temp_options = [];
        if (cb_unpossible.checked) temp_options.push("Unpossible")
        if (cb_hard.checked) temp_options.push("Hard")
        if (cb_middle.checked) temp_options.push("Middle")
        if (cb_normal.checked) temp_options.push("Normal")
        if (cb_easy.checked) temp_options.push("Easy")
        for (let i = 0; i < elements.length; i++) {


            if (temp_options.includes(elements[i].querySelector(".diff").textContent))
                elements[i].classList.remove("unselected");


            else
                elements[i].classList.add("unselected");
        }
    }

    function ViewAllItemsByVolume() {
        var elements = document.querySelectorAll(".item");
        for (var i = 0; i < elements.length; i++) {
            let mismaches = elements[i].querySelector(".mismatches");
            if (mismaches.textContent % 3 == 0) {
                mismaches.textContent = (mismaches.textContent / 3);
                if (mismaches.textContent == "1")
                    elements[i].classList.remove("unselected");
            }
        }
    }