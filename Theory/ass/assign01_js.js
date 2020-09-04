// JavaScript Document

function validate(){
    var rname = /^[a-zA-Z\s]{3,}$/;
    var name1 = document.getElementById("name").value;
    var uid1=/^\d{5,12}$/;
    var uid2 = document.getElementById("uid").value;
    var pass1=/^.{7,12}$/;
    var pass2 = document.getElementById("pass").value;
    var zip1=/^\d{5}$/;
    var zip2 = document.getElementById("zip").value;
    var mail1=/^\w+@\w+(\.\w+)+$/;
    var mail2 = document.getElementById("mail").value;
    
    if(!uid1.test(uid2)){
        alert ("Incorrect user id");
        return false;
    }
    if(!pass1.test(pass2)){
        alert ("Incorrect password");
        return false;
    }
    if(!rname.test(name1)){
        alert ("Incorrect name");
        return false;
    }
    if(document.f1.prov.value == "-1"){
        document.f1.prov.focus();
        alert("please choose your country");
        return false;
    }
    if(!zip1.test(zip2)){
        alert ("Incorrect zip code");
        return false;
    }
    if(!mail1.test(mail2)){
        alert ("Incorrect email");
        return false;
    }
    return true;
}