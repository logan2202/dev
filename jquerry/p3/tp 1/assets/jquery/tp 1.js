$(function () {

    let reponse = Math.round(Math.random() * 100);
    let tentative = 0;

    console.log(reponse);
    $("#submit").click(function () {
        let user = $('#number').val();
        if (user <= 100 && user >= 0) {
            tentative++;
            if (user < reponse) {
                alert("c'est plus grand");

            }
            else if (user > reponse) {
                alert("c'est plus petit");

            }
            else {

                alert('bravo vous avez trouver \n vous avez tenter ' + tentative + ' fois');

            }
        }

    });
});