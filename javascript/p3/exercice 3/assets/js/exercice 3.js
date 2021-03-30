let togg1 = document.getElementById("red");
let togg2 = document.getElementById("blue");
let togg3 = document.getElementById("green");
let d1 = document.getElementById("text");
togg1.addEventListener("click", () => {
 
    d1.style.color = 'red';
  
});

togg2.addEventListener("click", () => {
 
    d1.style.color = 'blue';
  
});

togg3.addEventListener("click", () => {
 
    d1.style.color = 'green';
  
});