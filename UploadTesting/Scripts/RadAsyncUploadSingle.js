//var MAX_TOTAL_BYTES = 2097152;
var MAX_TOTAL_BYTES  = 104857600;
var filesSize = new Array();

function OnFileSelected(sender, args) {

    var fileName = args.get_fileName();
    var temp = fileName.split(".");
    var ext = temp[temp.length - 1];
    
    if (!(ext == "pdf" || ext == "xls" || ext == "xlsx")) {

        alert(ext + " file type is invalid. System only allows PDF or EXCEL.");

        sender.deleteFileInputAt(0);
        sender.updateClientState();

        return;
    }

    if (fileName.indexOf("&") > 1) {

        alert(fileName + " is invalid file name, can't contain ampersand (&)");

        sender.deleteFileInputAt(0);
        sender.updateClientState();

        return;
    }

    if (fileName.indexOf("#") > 1) {

        alert(fileName + " is invalid file name, can't contain hash (#)");

        sender.deleteFileInputAt(0);
        sender.updateClientState();

        return;
    }
}

function OnProgressUpdating(sender, args) {

    filesSize = new Array();

    filesSize[args.get_data().fileName] = args.get_data().fileSize;
}

function OnFileUploaded(sender, args) {

    var totalBytes = 0;

    for (var index in filesSize) {
        totalBytes += filesSize[index];
    }

    //if (totalBytes > MAX_TOTAL_BYTES) {

    //    alert("File size is over the limit. System only allows 2MB per attach file size.");

    //    sender.deleteFileInputAt(0);
    //    sender.updateClientState();
    //}
}

