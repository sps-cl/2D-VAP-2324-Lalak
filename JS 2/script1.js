let platno = document.getElementById("platno");
let kontext = platno.getContext("2d");
let stredKruhuX = 100;
let stredKruhuY = 100;

platno.addEventListener("mousemove", (event) => {
     stredKruhuX = event.clientX;
     stredKruhuY = event.clientY;
});

function nakresli() {
    kontext.clearRect(0, 0, platno.width, platno.height);
    kontext.beginPath();
    kontext.arc(stredKruhuX, stredKruhuY, 50, 50); 
    kontext.fill();
    kontext.fillRect(50, 50, 100, 100);
}