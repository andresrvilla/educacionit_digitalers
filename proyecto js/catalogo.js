    var botonSeleccionar = document.getElementsByTagName("button")// variable para el onclick para la suma de cantidad de anuncios    
    var contadorAnuncios = 1 // contador para la cantidad de anuncios 
    costoTotal = 0
    //funcion para la cuenta de los anuncios
    function cantidadAnuncios(){
        var fila = "<th>";
            fila += "Cantidad de anuncios seleccionados: " + contadorAnuncios;
            fila += "</th>";
            
        var cantidad = document.getElementById("sumar");
        cantidad.innerHTML = fila;
        contadorAnuncios ++
        
        var precio = document.getElementsByClassName("precio");
             
        var fila = "<th>";
            fila += "costo total: " + costoTotal;
            fila += "</th>";
        var totall = document.getElementById("total");
        totall.innerHTML = fila;        
        }
    
    var botonUno=document.getElementById("botonUno") // variable para el onclik para la tabla precio,producto y cantidad del primer seleccionar(primer producto)
    var contadorproducto = 1
    var precio = parseFloat(50000) 
    //funcion agregar el producto uno
    function agregarProducto(){        
        var fila = "<tr><td>";
            fila += contadorproducto;
            fila += "</td><td>";
            fila += "play 5";
            fila += "</td><td>";
            fila += precio;
            fila += "</td><td><button id = 'quitar'>";
            fila += "quitar";
            fila += "</button></td></tr>";
        var cuerpo = document.getElementById("cuerpo");
        cuerpo.innerHTML = fila;
        contadorproducto ++
        precio += 50000
        costoTotal += 50000        
}

var botonDos = document.getElementById("botonDos") // variable para el onclik para la tabla precio,producto y cantidad del segundo seleccionar(segundo producto)
var contadorproductod = 1
var preciod = parseFloat(200000) 
    //funcion agregar el producto dos
        function agregarProductos(){        
        var fila = "<tr><td>";
            fila += contadorproductod;
            fila += "</td><td>";
            fila += "Notebook-9-pro";
            fila += "</td><td>";
            fila += preciod;
            fila += "</td><td><button onclick=quitardos() >";
            fila += "sacar";
            fila += "</button></td></tr>";
            cuerpo.innerHTML = fila;        
        
        contadorproductod ++
        preciod += 200000 
        costoTotal += 200000            
} 

    var botonTres = document.getElementById("botonTres")// variable para el onclik para la tabla precio,producto y cantidad del tercer seleccionar(tercer producto)
    var contadorproductot = 1
    var preciot = parseFloat(80000) 
    //funcion agregar el producto tres    
    function agregarProductoss(){        
        var fila = "<tr><td>";
            fila += contadorproductot;
            fila += "</td><td>";
            fila += "Celular Samsung";
            fila += "</td><td>";
            fila += preciot;
            fila += "</td><td><button onclick=quitartres() >";
            fila += "quitar";
            fila += "</button></td></tr>";
            cuerpo.innerHTML = fila;            
        
        contadorproductot ++
        preciot += 80000      
        costoTotal += 80000 
    }   
    
    botonUno.onclick= cantidadAnuncios,agregarProducto;           
    botonDos.onclick = agregarProductos;
    botonTres.onclick = agregarProductoss;
    
    var quitarprun= document.getElementById("quitar")// no se como hacer funcionar para que vaya descontando de a un producto
    function quitardos(){
        var fila = "<tr><td>";
        fila += contadorproductod - 1;
        fila += "</td><td>";
        fila += "Notebook-9-pro";
        fila += "</td><td>";
        fila += preciod - 200000;
        fila += "</td><td><button onclick=quitardos() >";
        fila += "sacar";
        fila += "</button></td></tr>";
        cuerpo.innerHTML = fila; 
       contadorproductod --
       preciod -= 200000
       costoTotal -= 200000

       } 
       
    quitarprun.onclick = quitardos   