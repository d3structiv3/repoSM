function sumar(_valor) {
    var total = 0;
    var boton = document.getElementById('btn1');
    var boton2 = document.getElementById('btn2');

    valor = parseFloat(_valor);
    total = document.getElementById('suma').innerHTML;
    total = (total == null || total == undefined || total == "") ? 0 : total;
    total = (parseFloat(total) + parseFloat(valor));
    if (total == 1) {
        console.log("Cumple el total");

        boton.disabled = false;
        boton2.disabled = false;
    }
    document.getElementById('suma').innerHTML = total;
}
function calcular(color) {
    if(color=="verde"){
        document.getElementById('msj').innerHTML='=Pr(Ai/B)';
        document.getElementById('msj1').innerHTML='=Pr(Ai/B)';
        document.getElementById('msj2').innerHTML='=Pr(Ai/B)';
        document.getElementById('msj3').innerHTML='=Pr(Ai/B)';
    }else{
        document.getElementById('msj').innerHTML='=Pr(Ai/noB)';
        document.getElementById('msj1').innerHTML='=Pr(Ai/noB)';
        document.getElementById('msj2').innerHTML='=Pr(Ai/noB)';
        document.getElementById('msj3').innerHTML='=Pr(Ai/noB)';
    }
    var a1 = parseFloat(document.getElementById('A1').value);
    var a2 = parseFloat(document.getElementById('A2').value);
    var a3 = parseFloat(document.getElementById('A3').value);
    var a4 = parseFloat(document.getElementById('A4').value);
    var ba1=parseFloat(document.getElementById('DA1').value);
    var ba2=parseFloat(document.getElementById('DA2').value);
    var ba3=parseFloat(document.getElementById('DA3').value);
    var ba4=parseFloat(document.getElementById('DA4').value);
    var pd=(a1*ba1)+(a2*ba2)+(a3*ba3)+(a4*ba4);
    
    document.getElementById('R1').value=(a1*ba1)/pd;
    document.getElementById('R2').value=(a2*ba2)/pd;
    document.getElementById('R3').value=(a3*ba3)/pd;
    document.getElementById('R4').value=(a4*ba4)/pd;
    console.log(pd);

    
}