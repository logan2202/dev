let image1 = document.getElementById('image1');
image1.addEventListener('mouseover',() => {
    image1.style.border = 'solid 3px red';
});

image1.addEventListener('mouseout',() => {
    image1.style.border = 'none';
});