
//Start RadTextBox

function BlockComma(sender, eventArgs) {

    var c = eventArgs.get_keyCode();

    if (c == 44) {
        eventArgs.set_cancel(true);
        alert("Comma (,) is system reserved character.");
    }

}


function BlockReservedCharacters(sender, eventArgs) {

    var c = eventArgs.get_keyCode();

    //43 is '+' character
    //45 is '-' character

    //if (c == 43 || c == 45) {

    //    eventArgs.set_cancel(true);

    //    alert("'-' and '+' are system reserved characters.");
    //}

}

//End RadTextBox