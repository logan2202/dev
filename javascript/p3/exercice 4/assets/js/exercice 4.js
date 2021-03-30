let password = document.getElementById("password");
let confirmPassword = document.getElementById("confirmPassword");
let submit = document.getElementById("submit");

submit.addEventListener("click", () => {
    if (password.value == confirmPassword.value){
        password.style.border = 'solid 3px green';
        confirmPassword.style.border = 'solid 3px green';
    }
    else {
        password.style.border = 'solid 3px red';
        confirmPassword.style.border = 'solid 3px red';
    }
 
});
