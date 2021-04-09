let togg1 = document.getElementById("ciseaux");
let togg2 = document.getElementById("feuilles");
let togg3 = document.getElementById("pierres");
let togg4 = document.getElementById("menu");
let togg5 = document.getElementById("jeux");
let togg7 = document.getElementById("oui1");
let togg6 = document.getElementById("non1");
document.getElementById('jeux').style.display = 'none';

togg6.addEventListener("click", () => {
   
    window.close()
    
  });

togg7.addEventListener("click", () => {
   
    togg5.style.display = "block";
    togg4.style.display = "none";
    
  });

togg1.addEventListener("click", () => {
 
    var min=1; 
    var max=3;  
    var random = Math.floor(Math.random() * (max - min)) + min;
    
    if(random == "1"){
        alert("egalité");
    }
    else if(random == "2"){
        alert("gagné");
    }
    else if(random == "3"){
        alert("perdu");
    }

});

togg2.addEventListener("click", () => {
   
    var min=1; 
    var max=3;  
    var random = Math.floor(Math.random() * (max - min)) + min;

    if(random == "2"){
        alert("egalité");
    }
    else if(random == "3"){
        alert("gagné");
    }
    else if(random == "1"){
        alert("perdu");
    }

  });
  togg3.addEventListener("click", () => {
   
    var min=1; 
    var max=3;  
    var random = Math.floor(Math.random() * (max - min)) + min;

    if(random == "3"){
        alert("egalité");
    }
    else if(random == "1"){
        alert("gagné");
    }
    else if(random == "2"){
        alert("perdu");
    }

  });