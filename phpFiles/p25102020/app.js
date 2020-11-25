

function calcular(){


    var valP = document.getElementById('valorP').value; 
    var valQ = document.getElementById('valorQ').value; 
    var valOpe = document.getElementById('valorOpe').value; 
    var res="";
    console.log(valOpe);

    switch (valOpe){
        case "1":
            if(valP=="V"&&valQ=="V"){
                res = "La conjuncon "+valP+" ^ "+ valQ  +" = V";
            }else{
                res = "La conjuncon "+valP+" ^ "+ valQ  +" = F";
            }
        break;
        case "2":
            if(valP=="F"&&valQ=="F"){
                res = "La disyuncion "+valP+" v "+ valQ  +" = F";
            }else{
                res = "La disyuncion "+valP+" v "+ valQ  +" = V";
            }
        break;
        case "3":
            if(valP=="V"&&valQ=="F"){
                res = "El condicional "+valP+" ↦ "+ valQ  +" = F";
            }else{
                res = "El condicional "+valP+" ↦ "+ valQ  +" = V";
            }
        break;
        case "4":
            if(valP=="V"&&valQ=="V" || valP=="F"&&valQ=="F"){
                res = "El bicondicional "+valP+" ↔ "+ valQ  +" = V";
            }else{
                res = "El bicondicional "+valP+" ↔ "+ valQ  +" = F";
            }
        break;

    }

    document.getElementById('resultado').innerHTML='<div class="alert alert-success">'+res+'</div>';
}