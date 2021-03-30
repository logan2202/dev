


$(function(){
    $("#submit").click(function(){
        let reponse1 = parseInt($("#number1").val());
        let reponse2 = parseInt($("#number2").val());
        let reponse3 = parseInt($("#number3").val());
        let reponse4 = parseInt($("#number4").val());
        let reponse5 = parseInt($("#number5").val());
        let result1 = reponse1 + reponse2 + reponse3 + reponse4 + reponse5;
        let result2 = result1/5;

       if(result2 >= 0 && result2 < 10){
           alert('appréciation : En dessous de la moyenne. \n votre moyenne est de ' + result2);
       };
       if(result2 >= 10 && result2 < 13){
           alert('appréciation : Moyen. \n votre moyenne est de ' + result2);
       };
       if(result2 >= 13 && result2 < 16){
           alert('appréciation : Bien. \n votre moyenne est de ' + result2);
       };
       if(result2 >= 16 && result2 < 20){
           alert('appréciation : Très bien. \n votre moyenne est de ' + result2)
       }
       if(result2 == 20)[
           alert('appréciation : Excellent. \n votre moyenne est de ' + result2)
       ]
    });
});