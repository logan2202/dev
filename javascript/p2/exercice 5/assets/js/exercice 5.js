function changeImage() {
    this.src='assets/img/'+ this.id + '_2.jpg';
}
 function returnImage() {
    this.src='assets/img/'+ this.id + '.jpg';
 }

let image1 = document.getElementById('image1');
let image2 = document.getElementById('image2');
let image3 = document.getElementById('image3');
let image4 = document.getElementById('image4');
let image5 = document.getElementById('image5');

image1.onmouseover = changeImage;
image2.onmouseover = changeImage;
image3.onmouseover = changeImage;
image4.onmouseover = changeImage;
image5.onmouseover = changeImage;

image1.onmouseout = returnImage;
image2.onmouseout = returnImage;
image3.onmouseout = returnImage;
image4.onmouseout = returnImage;
image5.onmouseout = returnImage;