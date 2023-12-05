function CheckEmail()
{
    var email = document.getElementById("input_email_login").value;
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

function CheckPassword()
{
    var password = document.getElementById("input_password_login").value;
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