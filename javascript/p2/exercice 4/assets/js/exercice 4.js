function changeImage() {
    this.src='assets/img/'+this.id + '_2.jpg';
}


let image1 = document.getElementById('image1').onmouseover = changeImage;
let image2 = document.getElementById('image2').onmouseover = changeImage;
let image3 = document.getElementById('image3').onmouseover = changeImage;
let image4 = document.getElementById('image4').onmouseover = changeImage;
let image5 = document.getElementById('image5').onmouseover = changeImage;