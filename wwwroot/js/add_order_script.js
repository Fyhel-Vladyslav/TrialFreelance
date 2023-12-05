function CheckTitle(){
    var title = document.getElementById("input_title").value;
    if(!title) {
        document.getElementById("titleHelp").style.opacity = "1"
        document.getElementById("titleHelp").innerText= "*Title required"
        return;
    }
}

function ClearTitle() 
{
    document.getElementById("titleHelp").innerText = ""
    document.getElementById("titleHelp").style.opacity = "0"
}

function CheckDescription(){
    var desc = document.getElementById("input_ta_description").value;
    if(!desc) {
        document.getElementById("descriptionHelp").style.opacity = "1"
        document.getElementById("descriptionHelp").innerText= "*Description required"
        return;
    }
}

function ClearDescription() 
{
    document.getElementById("descriptionHelp").innerText = ""
    document.getElementById("descriptionHelp").style.opacity = "0"
}

function CheckMainTask(){
    var main = document.getElementById("input_ta_main_task").value;
    if(!main) {
        document.getElementById("main_taskHelp").style.opacity = "1"
        document.getElementById("main_taskHelp").innerText= "*Main task required"
        return;
    }
}

function ClearMainTask() 
{
    document.getElementById("main_taskHelp").innerText = ""
    document.getElementById("main_taskHelp").style.opacity = "0"
}

function CheckSecondaryTask(){
    var main = document.getElementById("input_ta_secondary_task").value;
    if(!main) {
        document.getElementById("secondary_taskHelp").style.opacity = "1"
        document.getElementById("secondary_taskHelp").innerText= "*Secondary task required"
        return;
    }
}

function ClearSecondaryTask() 
{
    document.getElementById("secondary_taskHelp").innerText = ""
    document.getElementById("secondary_taskHelp").style.opacity = "0"
}

function CheckSecondaryTask(){
    var main = document.getElementById("input_ta_secondary_task").value;
    if(!main) {
        document.getElementById("secondary_taskHelp").style.opacity = "1"
        document.getElementById("secondary_taskHelp").innerText= "*Secondary task required"
        return;
    }
}

function ClearSecondaryTask() 
{
    document.getElementById("secondary_taskHelp").innerText = ""
    document.getElementById("secondary_taskHelp").style.opacity = "0"
}

function CheckGit()
{
    var git = document.getElementById("input_git_link_register").value;
    if (!git) {
        document.getElementById("gitHelp").style.opacity = "1"
        document.getElementById("gitHelp").innerText = "*Git Hub required"
        return;
    }
    if(!git.includes("github.com/")) {
        document.getElementById("gitHelp").style.opacity = "1"
        document.getElementById("gitHelp").innerText = "*Invalid Git Hub link"
        return;
    }

}

function ClearGit() 
{
    document.getElementById("gitHelp").innerText = ""
    document.getElementById("gitHelp").style.opacity = "0"
}

function CheckDifficalty() {
    var dif = document.getElementById("select_difficalty").value;
    console.log(dif);
}