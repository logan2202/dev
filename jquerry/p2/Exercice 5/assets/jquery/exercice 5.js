$(function(){
    $('#green').mouseover(function(){
        $('#text').css('color', '#008000');
    });
    
    $('#red').mouseover(function(){
        $('#text').css('color', '#ff0000');
    });
    
    $("#blue").mouseover(function(){
        $('#text').css('color', '#0000ff');
    });

    $('.color').mouseout(function(){
        $('#text').css('color', '#00002f');
    });


});

