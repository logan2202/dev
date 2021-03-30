let number = 0;
let reponse = Math.floor(Math.random() * 49) + 1;

while (reponse != number){

    reponse = prompt("renseigner votre nombre", "<Entrez ici votre nombre>");
    if( reponse < number ){
    alert("Plus petit");
    } 
    else if(reponse > number) {
    alert("Plus grand");
    }
    else{
        alert("bravo vous avez trouver");
    }
}