var uploadsInProgress = 0;
var MAX_TOTAL_BYTES = 2000971520;
var filesSize = new Array();
var OVERSIZE_MESSAGE = "You are only allowed to add up to 20mb of files total";
var isDuplicateFile = false;

function OnFileSelected(sender, args) {

    var value = document.getElementById("ddl").value;
     var numberOfFiles = sender._uploadedFiles.length;
     if (value == " ") {      
         alert("You must select the Doc Type.");
         return;
     }

    for (var fileindex in sender._uploadedFiles) {
        if (sender._uploadedFiles[fileindex].fileInfo.FileName == args.get_fileName()) {
            isDuplicateFile = true;
        }
    }
    if (!uploadsInProgress) {
        $("input[id$=btnSave]").attr("disabled", "disabled");

    }
    uploadsInProgress++;

}


function OnFilesUploaded(sender, args) {
    if (sender._uploadedFiles.length == 0) {
        filesSize = new Array();
        uploadsInProgress = 0;
        $("input[id$=btnSave]").removeAttr("disabled");
    }
    if (uploadsInProgress > 0) {
        DecrementUploadsInProgress();
    }

}

function OnProgressUpdating(sender, args) {

    filesSize[args.get_data().fileName] = args.get_data().fileSize;

}

function OnFileUploadFailed(sender, args) {
    DecrementUploadsInProgress();
}

function OnFileUploaded(sender, args) {
    DecrementUploadsInProgress();
    var totalBytes = 0;
    var numberOfFiles = sender._uploadedFiles.length;

    if (isDuplicateFile) {
        sender.deleteFileInputAt(numberOfFiles - 1);
        isDuplicateFile = false;
        sender.updateClientState();
        alert("You can't add the same file twice");
        return;
    }

    for (var index in filesSize) {
        totalBytes += filesSize[index];
    }


    var value = document.getElementById("ddl").value;
    var row = args.get_row();
    var title = document.createElement("input");
    title.id = title.name = sender.getAdditionalFieldID("TextBox");

    title.readOnly = "readonly";
    title.value = value;
    row.insertBefore(title, row.firstChild);
 
}

function OnFileUploadRemoved(sender, args) {
    if (args.get_fileName() != null) {
        if (!isDuplicateFile) {
            delete filesSize[args.get_fileName()];
        }
    }
}

function DecrementUploadsInProgress() {
    uploadsInProgress--;
    if (!uploadsInProgress) {
        $("input[id$=btnSave]").removeAttr("disabled");

    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////
// End of Scripts\RadAsyncUpload.js
////////////////////////////////////////////////////////////////////////////////////////////////////

function addTitle(RadAsyncUpload, args) {
    var row = args.get_row();
    var title = document.createElement("input");
    title.id = title.name = RadAsyncUpload.getID("title");
    row.insertBefore(title, row.firstChild);
    
}

function createInput() {

    var input = document.createElement("select");


    var option = new Option();

    option.value = " ";

    option.text = " ";

    input.options.add(option);

    var option = new Option();

    option.value = "Invoice";

    option.text = "Invoice";

    input.options.add(option);

    var option1 = new Option();

    option1.value = "Permit";

    option1.text = "Permit";

    input.options.add(option1);

    var option2 = new Option();

    option2.value = "Quotation";

    option2.text = "Quotation";

    input.options.add(option2);

    return input;

}

function createLabel(forArrt, value) {

    var label = document.createElement("label");
    label.setAttribute("for", forArrt);
    label.innerHTML = value;
    return label;

}