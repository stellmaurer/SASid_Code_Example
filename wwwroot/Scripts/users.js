
function getErrorString(response, userID){
    var text = "An error occurred while searching for this user ID.";
    if((response == null) || userID == null){
        return text;
    }
    if(response.status == 404){
        var text = "UserID " + userID + " not found.";
    }
    return text;
}

function getSuccessString(user){
    if(user == null){
        return "There was an error: the user object in the response was null.";
    }
    var text = getNameString(user) + " has " + getDaysString(user) + " until " +
               getGenderString(user) + " birthday!";
    if(user.daysUntilBirthday == 0){
        text = "It is " + getNameInPossessiveString(user) + " birthday!";
    }
    if(user.daysUntilBirthday == -1){
        text = "We don't know when " + getNameInPossessiveString(user) + " birthday is.";
    }
    return text;
}

function getNameString(user){
    if(user == null){
        return "";
    }
    var name = user.firstName;
    if(user.lastName != null){
        name += " " + user.lastName;
    }
    return name;
}

function getDaysString(user){
    if(user == null){
        return "";
    }
    var text = user.daysUntilBirthday;
    if(user.daysUntilBirthday == 1){
        text += " day";
    }else{
        text += " days";
    }
    return text;
}

function getGenderString(user){
    if(user == null){
        return "";
    }
    var text = "";
    if(user.gender == "Male"){
        text += "his";
    }else if(user.gender == "Female"){
        text += "her";
    }else{
        text += "their";
    }
    return text;
}

function getNameInPossessiveString(user){
    if(user == null){
        return "";
    }
    var name = getNameString(user);
    var text = name;
    if(name.endsWith("s")){
        text += "'";
    }else{
        text += "'s";
    }
    return text;
}