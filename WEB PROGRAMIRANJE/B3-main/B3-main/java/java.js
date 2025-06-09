function Bugarska(){
    window.open("Bugarska.html", "" ,"left=1050,top=750,width=350,height=250");
}
function Rumunija(){
    window.open("Rumunija.html", "" ,"left=950,top=250,width=350,height=250");
}
function Madjarska(){
    window.open("Madjarska.html", "" ,"left=650,top=90,width=350,height=250");
}
function Hrvatska(){
    window.open("Hrvatska.html", "" ,"left=550,top=250,width=350,height=250");
}  
function Bosna(){
    window.open("Bosna.html", "" ,"left=550,top=450,width=350,height=250");
}  
function CrnaGora(){
    window.open("CrnaGora.html", "" ,"left=600,top=650,width=350,height=250");
}  
function Albanija(){
    window.open("Albanija.html", "" ,"left=700,top=750,width=350,height=250");
}  
function Makedonija(){
    window.open("Makedonija.html", "" ,"left=900,top=750,width=350,height=250");
}  
function Srbija(){
    window.open("Srbija.html", "" ,"left=800,top=450,width=350,height=250");
}  
function stopAudio() {
    audio.pause();
    audio.currentTime = 0; 
}
document.addEventListener("DOMContentLoaded", function() {
let image1 = new Audio("./zvuci/bg.mp3")
let image2 = new Audio("./zvuci/ru.mp3")
let image3 = new Audio("./zvuci/hu.mp3")
let image4 = new Audio("./zvuci/cro.mp3")
let image5 = new Audio("./zvuci/bih.mp3")
let image6 = new Audio("./zvuci/cg.mp3")
let image7 = new Audio("./zvuci/al.mp3")
let image8 = new Audio("./zvuci/mkd.mp3")
let image9 = new Audio("./zvuci/rs.mp3")


function playAudio(audio) {
    audio.play();
}
function pauseAudio(audio) {
    audio.pause();
}
document.addEventListener("mouseover", function() {
    document.querySelector('.image1').addEventListener("mouseenter", () => {
        playAudio(image1);
    })
    document.querySelector('.image2').addEventListener("mouseenter", () => {
        playAudio(image2);
    });
    document.querySelector('.image3').addEventListener("mouseenter", () => {
        playAudio(image3);
    });
    document.querySelector('.image4').addEventListener("mouseenter", () => {
        playAudio(image4);
    });
    document.querySelector('.image5').addEventListener("mouseenter", () => {
        playAudio(image5);
    });
    document.querySelector('.image6').addEventListener("mouseenter", () => {
        playAudio(image6);
    });
    document.querySelector('.image7').addEventListener("mouseenter", () => {
        playAudio(image7);
    });
    document.querySelector('.image8').addEventListener("mouseenter", () => {
        playAudio(image8);
    });
    document.querySelector('.image9').addEventListener("mouseenter", () => {
        playAudio(image9);
    });
});

document.querySelector('.image1').addEventListener("mouseleave", () => {
    pauseAudio(image1);
});


document.querySelector('.image2').addEventListener("mouseleave", () => {
    pauseAudio(image2);
});


document.querySelector('.image3').addEventListener("mouseleave", () => {
    pauseAudio(image3);
});


document.querySelector('.image4').addEventListener("mouseleave", () => {
    pauseAudio(image4);
});


document.querySelector('.image5').addEventListener("mouseleave", () => {
    pauseAudio(image5);
});


document.querySelector('.image6').addEventListener("mouseleave", () => {
    pauseAudio(image6);
});

document.querySelector('.image7').addEventListener("mouseleave", () => {
    pauseAudio(image7);
});

document.querySelector('.image8').addEventListener("mouseleave", () => {
    pauseAudio(image8);
});

document.querySelector('.image9').addEventListener("mouseleave", () => {
    pauseAudio(image9);
});

});

