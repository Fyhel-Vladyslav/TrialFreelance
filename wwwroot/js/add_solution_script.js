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