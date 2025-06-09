function kontrafagot(){
    window.open("kontrafagot.html", "" ,"width=350,height=250");
}
function harmonika(){
    window.open("harmonika.html", "" ,"width=350,height=250");
}
function bubnjevi(){
    window.open("bubnjevi.html", "" ,"width=350,height=250");
}
function klavir(){
    window.open("zicani.html", "" ,"width=350,height=250");
}  
function gitara(){
    window.open("zicani.html", "" ,"width=350,height=250");
}  
function violina(){
    window.open("zicani.html", "" ,"width=350,height=250");
}  

document.getElementById('s1').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Гитара");
});

document.getElementById('s2').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Виолина");
});

document.getElementById('s3').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Клавир");
});

document.getElementById('s4').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Бубњеви");
});

document.getElementById('s5').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Хармоника");
});

document.getElementById('s6').addEventListener('click', function() {
    window.open("https://sr.wikipedia.org/wiki/Контрафагот");
});

var audio1 = new Audio('./audio/gitara.mp3');
document.getElementById('z1').addEventListener('mouseenter', function() {
    audio1.play();
});
document.getElementById('z1').addEventListener('mouseleave', function() {
    audio1.pause();
});

var audio2 = new Audio('./audio/violina.mp3');
document.getElementById('z2').addEventListener('mouseenter', function() {
    audio2.play();
});
document.getElementById('z2').addEventListener('mouseleave', function() {
    audio2.pause();
});

var audio3 = new Audio('./audio/klavir.mp3');
document.getElementById('z3').addEventListener('mouseenter', function() {
    audio3.play();
});
document.getElementById('z3').addEventListener('mouseleave', function() {
    audio3.pause();
});

var audio4 = new Audio('./audio/bubnjevi.mp3');
document.getElementById('z4').addEventListener('mouseenter', function() {
    audio4.play();
});
document.getElementById('z4').addEventListener('mouseleave', function() {
    audio4.pause();
});

var audio5 = new Audio('./audio/harmonika.mp3');
document.getElementById('z5').addEventListener('mouseenter', function() {
    audio5.play();
});
document.getElementById('z5').addEventListener('mouseleave', function() {
    audio5.pause();
});

var audio6 = new Audio('./audio/kontrafagot.mp3');
document.getElementById('z6').addEventListener('mouseenter', function() {
    audio6.play();
});
document.getElementById('z6').addEventListener('mouseleave', function() {
    audio6.pause();
});
