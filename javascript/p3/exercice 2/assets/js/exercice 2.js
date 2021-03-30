let togg1 = document.getElementById("togg1");
let togg2 = document.getElementById("togg2");
let d1 = document.getElementById("text");
togg1.addEventListener("click", () => {
 
    d1.style.display = "block";
  
});

togg2.addEventListener("click", () => {
   
      d1.style.display = "none";
   
  });