//Fonction permettant d'afficher/cacher la catégorie sélectionner 
function HideAndShow(selectedIndex) {
    let menu = document.getElementsByTagName('Section');
    for (menuIndex = 0; menuIndex < menu.length; menuIndex++){
        if (menuIndex == selectedIndex){
            menu[menuIndex].style.display =  'block';
        } else {
            menu[menuIndex].style.display = 'none';
        }
    }
}
//evt onclick le produit dans le panier / récup valeur, quantité / rentre la quantité dans la modal du panier
function addBasket(monId, quantityValue, quantityTarget, resultTarget, unitPrice) {
    if (document.getElementById(monId).style.display == 'block'){
        alert('L\'article se trouve déjà dans le panier');
    }
    document.getElementById(monId).style.display = 'block';
    //Qtity Value = Quantité séléctionner via l'index
        let getQuantity = document.getElementById(quantityValue).value;
        //Qtity Target = Champ quantité dans la card
        document.getElementById(quantityTarget).value = getQuantity;
        //resultTarget = Balise contenant le prix dans la card
        //unitaryPrice = Prix unitaire du produit
        document.getElementById(resultTarget).innerHTML = (document.getElementById(quantityTarget).value * unitPrice).toFixed(2);
        //affiche le total des article selectioner dans le panier
var amount1 = Number(document.getElementById('OnePiece1Price').innerText),
amount2 = Number(document.getElementById('OnePiece2Price').innerText),
amount3 = Number(document.getElementById('OnePiece3Price').innerText),
amount4 = Number(document.getElementById('OnePiece4Price').innerText),
amount5 = Number(document.getElementById('OnePiece5Price').innerText),
amount6 = Number(document.getElementById('OnePiece6Price').innerText),
amount7 = Number(document.getElementById('TokyoGhoul1Price').innerText),
amount8 = Number(document.getElementById('TokyoGhoul2Price').innerText),
amount9 = Number(document.getElementById('TokyoGhoul3Price').innerText),
amount10 = Number(document.getElementById('TokyoGhoul4Price').innerText),
amount11 = Number(document.getElementById('TokyoGhoul5Price').innerText),
amount12 = Number(document.getElementById('TokyoGhoul6Price').innerText),
amount13 = Number(document.getElementById('Snk1Price').innerText),
amount14 = Number(document.getElementById('Snk2Price').innerText),
amount15 = Number(document.getElementById('Snk3Price').innerText),
amount16 = Number(document.getElementById('Snk4Price').innerText),
amount17 = Number(document.getElementById('Snk5Price').innerText),
amount18 = Number(document.getElementById('Snk6Price').innerText);
var balance = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8 + amount9 + amount10 + amount11 + amount12 + amount13 + amount14 + amount15 + amount16 + amount17 + amount18;
document.getElementById('amountTotal').innerHTML = balance.toFixed(2);
}

//onkeyUp recupere la quantitée et la multiplie par le prix unitaire avant de l'écrire dans la span priceID
function totalPrice(myId, priceID, oneItemPrice) {
var quantity = document.getElementById(myId).value; // myId = input quantity de la modal
var unitPrice = oneItemPrice; //oneItemPrice = prix unitaire d'un item
var result = quantity * unitPrice;
document.getElementById(priceID).innerHTML = result.toFixed(2);  //price ID = span prix dans la modal
//additioner tout les prix pour l'ecrire dans le prix total
var amount1 = Number(document.getElementById('OnePiece1Price').innerText),
amount2 = Number(document.getElementById('OnePiece2Price').innerText),  
amount3 = Number(document.getElementById('OnePiece3Price').innerText),
amount4 = Number(document.getElementById('OnePiece4Price').innerText),
amount5 = Number(document.getElementById('OnePiece5Price').innerText),
amount6 = Number(document.getElementById('OnePiece6Price').innerText),
amount7 = Number(document.getElementById('TokyoGhoul1Price').innerText),
amount8 = Number(document.getElementById('TokyoGhoul2Price').innerText),
amount9 = Number(document.getElementById('TokyoGhoul3Price').innerText),
amount10 = Number(document.getElementById('TokyoGhoul4Price').innerText),
amount11 = Number(document.getElementById('TokyoGhoul5Price').innerText),
amount12 = Number(document.getElementById('TokyoGhoul6Price').innerText),
amount13 = Number(document.getElementById('Snk1Price').innerText),
amount14 = Number(document.getElementById('Snk2Price').innerText),
amount15 = Number(document.getElementById('Snk3Price').innerText),
amount16 = Number(document.getElementById('Snk4Price').innerText),
amount17 = Number(document.getElementById('Snk5Price').innerText),
amount18 = Number(document.getElementById('Snk6Price').innerText);
var balance = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8 + amount9 + amount10 + amount11 + amount12 + amount13 + amount14 + amount15 + amount16 + amount17 + amount18;
document.getElementById('amountTotal').innerHTML = balance.toFixed(2);
}

// onclick supprime l'item selectionner
function deleteItem(myId, amountId) {
document.getElementById(myId).style.display = 'none';  //myId =  l'id de l'item
//soustrait le montant de l'aticle supprimer et affiche le total
var amount1 = Number(document.getElementById('OnePiece1Price').innerText),
amount2 = Number(document.getElementById('OnePiece2Price').innerText),
amount3 = Number(document.getElementById('OnePiece3Price').innerText),
amount4 = Number(document.getElementById('OnePiece4Price').innerText),
amount5 = Number(document.getElementById('OnePiece5Price').innerText),
amount6 = Number(document.getElementById('OnePiece6Price').innerText),
amount7 = Number(document.getElementById('TokyoGhoul1Price').innerText),
amount8 = Number(document.getElementById('TokyoGhoul2Price').innerText),
amount9 = Number(document.getElementById('TokyoGhoul3Price').innerText),
amount10 = Number(document.getElementById('TokyoGhoul4Price').innerText),
amount11 = Number(document.getElementById('TokyoGhoul5Price').innerText),
amount12 = Number(document.getElementById('TokyoGhoul6Price').innerText),
amount13 = Number(document.getElementById('Snk1Price').innerText),
amount14 = Number(document.getElementById('Snk2Price').innerText),
amount15 = Number(document.getElementById('Snk3Price').innerText),
amount16 = Number(document.getElementById('Snk4Price').innerText),
amount17 = Number(document.getElementById('Snk5Price').innerText),
amount18 = Number(document.getElementById('Snk6Price').innerText);
var balance = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8 + amount9 + amount10 + amount11 + amount12 + amount13 + amount14 + amount15 + amount16 + amount17 + amount18;
var numberSuppr = document.getElementById(amountId).innerText;
balance = balance - numberSuppr;
document.getElementById('amountTotal').innerHTML = balance.toFixed(2);
}

// onclick vide le panier
function deleteAll() {
var itemList = document.getElementsByClassName('modal-item');
for (item = 0; item < itemList.length; item++) {
  itemList[item].style.display = 'none';
}
balance = 0;
document.getElementById('amountTotal').innerHTML = balance;
}
//Ajout d'un border de couleur vert une fois que l'ajout produit est effectué
function changeBorder(element) {
element.style.border = 'solid green 3px';
}

/* Zoom Image */

$ (function(){
    //on definie une variable pour stocker la taille initiale de l'image
    let imageSize = $('.img').width();
        $('.img').mouseenter(function () {
        $(this).css({'transform': 'scale(1.38)'}); //this represente ce qui déclenche l'événement
    });
        $('.img').mouseleave(function () {
        $(this).css({'transform': 'initial'}); // pour reprendre la taille initiale
    });
}); 
