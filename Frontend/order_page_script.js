window.onload = function(){
    var order =  JSON.parse(sessionStorage.getItem("order"));
    console.log(order)
    document.title = order.title;
}

