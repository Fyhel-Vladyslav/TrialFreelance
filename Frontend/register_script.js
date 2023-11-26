
function CheckEmail()
{
    var email = document.getElementById("input_email_register").value;
    if(!email) {
        document.getElementById("emailHelp").style.opacity = "1"
        document.getElementById("emailHelp").innerText= "*Email required"
        return;
    }
    if(!email.includes("@") || !email.includes(".")) {
        document.getElementById("emailHelp").style.opacity = "1"
        document.getElementById("emailHelp").innerText= "*Invalid email"
        return;
    }
}

function ClearEmail() 
{
    document.getElementById("emailHelp").innerText = ""
    document.getElementById("emailHelp").style.opacity = "0"
}

function CheckName()
{
    var name = document.getElementById("input_name_register").value;
    if(!name) {
        document.getElementById("nameHelp").style.opacity = "1"
        document.getElementById("nameHelp").innerText= "*Name required"
        return;
    }
}

function ClearName() 
{
    document.getElementById("nameHelp").innerText = ""
    document.getElementById("nameHelp").style.opacity = "0"
}

function CheckGit()
{
    var git = document.getElementById("input_git_name_register").value;
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

function CheckPhone()
{
    var phone = document.getElementById("input_phone_register").value;
    var phoneLen = phone.length;
    if (!phone) {
        document.getElementById("phoneHelp").style.opacity = "1"
        document.getElementById("phoneHelp").innerText = "*Phone number required"
        return;
    }
    if(/[A-Z]/.test(phone) || /[a-z]/.test(phone)){
        document.getElementById("phoneHelp").style.opacity = "1"
        document.getElementById("phoneHelp").innerText = "*Can't contain letters"
        return;
    }
    if(phoneLen != 13){
        document.getElementById("phoneHelp").style.opacity = "1"
        document.getElementById("phoneHelp").innerText = "*Must contain 10 numbers"
        return;
    }
}

function ClearPhone() 
{
    document.getElementById("phoneHelp").innerText = ""
    document.getElementById("phoneHelp").style.opacity = "0"

    var phone = document.getElementById("input_phone_register").value;
    if(!phone){
        console.log(1);
        document.getElementById("input_phone_register").value = "+380"
    }
}

function CheckPassword()
{
    var password = document.getElementById("input_password_register").value;
    var passwordLen = password.length;
    if(!password) {
        document.getElementById("passwordHelp").style.opacity = "1"
        document.getElementById("passwordHelp").innerText = "*Password required"
        return;
    }
    if(passwordLen < 8) {
        document.getElementById("passwordHelp").style.opacity = "1"
        document.getElementById("passwordHelp").innerText = "*Must contain at least 8 characters"
        return;
    }
    if(!/[A-Z]/.test(password)) {
        document.getElementById("passwordHelp").style.opacity = "1"
        document.getElementById("passwordHelp").innerText = "*Must contain capital letter"
        return;
    }

}

function ClearPassword() 
{
    document.getElementById("passwordHelp").innerText = ""
    document.getElementById("passwordHelp").style.opacity = "0"
}