$(function(){
    $('div').mouseover(function(){
        $(this).find('img').animate({
            width:1000,
            height:1000
        })
    })
})