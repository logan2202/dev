let elem = document.getElementById("lastname");

function afficherMessage() {
	alert("Merci de votre participation");
}

elem.onblur = afficherMessage;