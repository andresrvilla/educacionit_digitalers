var total = 0
var cantAnuncios = 0
var contadoruno =  0
var precioUno = 0
var btnUno = document.getElementById("btnuno")

function quitar(){
    if (btnUno && 0<contadoruno && 0<precioUno) {
            contadoruno --
            precioUno -= 50000
            total -= 50000 
            cantAnuncios --                      
            var fila = "<td>"
            fila += contadoruno
            fila += "</td><td>CELULAR SAMSUNG</td><td>"
            fila += precioUno
            fila += "</td><td>"
            fila += "<button onclick = quitar()>quitar</button></td>"
            var cantProducto = document.getElementById("cantProducto")
            cantProducto.innerHTML=fila                     
                    
            var fila = "<th>";
            fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
            fila += "</th>";
                
            var cantidad = document.getElementById("sumar");
            cantidad.innerHTML = fila;
                
            var fila = "<th>";
                fila += "costo total: " + total;
                fila += "</th>";
            var totall = document.getElementById("total");

            totall.innerHTML = fila;
                        }
                        }

function sumar(){
    if (btnUno) {
        contadoruno ++
        precioUno += 50000
        total += 50000
        cantAnuncios ++
        var fila = "<td>"
            fila += contadoruno
            fila += "</td><td>CELULAR SAMSUNG</td><td>"
            fila += precioUno
            fila += "</td><td>"
            fila += "<button onclick = quitar()>quitar</button></td>"                   
            var cantProducto = document.getElementById("cantProducto")
            cantProducto.innerHTML=fila
                    
        var fila = "<th>";
        fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
        fila += "</th>";
            
        var cantidad = document.getElementById("sumar");
        cantidad.innerHTML = fila;
            
        var fila = "<th>";
            fila += "costo total: " + total;
            fila += "</th>";
        var totall = document.getElementById("total");

        totall.innerHTML = fila;
            }            
        }
        
btnUno.onclick= sumar
    
var contadorDos =  0
var precioDos = 0
var btnDos = document.getElementById("btndos")
function quitarDos(){
    if (btnDos && 0<contadorDos && 0<precioDos) {
            contadorDos --
            precioDos -= 80000
            total -= 80000 
            cantAnuncios --                      
            var fila = "<td>"
            fila += contadorDos
            fila += "</td><td>PLAY 5</td><td>"
            fila += precioDos
            fila += "</td><td>"
            fila += "<button onclick = quitarDos()>quitar</button></td>"
            var cantProductoDos = document.getElementById("cantProductoDos")
            cantProductoDos.innerHTML=fila            
    
            var fila = "<th>";
            fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
            fila += "</th>";
                
            var cantidad = document.getElementById("sumar");
            cantidad.innerHTML = fila;
                
            var fila = "<th>";
                fila += "costo total: " + total;
                fila += "</th>";
            var totall = document.getElementById("total");

            totall.innerHTML = fila;
                }
                }

function sumarDos(){
    if (btnDos) {
        contadorDos ++
        precioDos += 80000
        total += 80000 
        cantAnuncios ++
        var fila = "<td>"
            fila += contadorDos
            fila += "</td><td>PLAY 5</td><td>"
            fila += precioDos
            fila += "</td><td>"
            fila += "<button onclick = quitarDos()>quitar</button></td>"                   
            var cantProductoDos = document.getElementById("cantProductoDos")
            cantProductoDos.innerHTML=fila             
            
        var fila = "<th>";
        fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
        fila += "</th>";
            
        var cantidad = document.getElementById("sumar");
        cantidad.innerHTML = fila;
            
        var fila = "<th>";
            fila += "costo total: " + total;
            fila += "</th>";
        var totall = document.getElementById("total");

        totall.innerHTML = fila;
        }            
    }

btnDos.onclick= sumarDos

var contadorTres =  0
var precioTres = 0
var btnTres = document.getElementById("btntres")
function quitarTres(){
    if (btnTres && 0<contadorTres && 0<precioTres) {
            contadorTres --
            precioTres -= 150000
            total -= 150000 
            cantAnuncios --                      
            var fila = "<td>"
            fila += contadorTres
            fila += "</td><td>NOTEBOOK 9 PRO</td><td>"
            fila += precioTres
            fila += "</td><td>"
            fila += "<button onclick = quitarTres()>quitar</button></td>"
            var cantProductoTres = document.getElementById("cantProductoTres")
            cantProductoTres.innerHTML=fila            
    
            var fila = "<th>";
            fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
            fila += "</th>";
                
            var cantidad = document.getElementById("sumar");
            cantidad.innerHTML = fila;
                
            var fila = "<th>";
                fila += "costo total: " + total;
                fila += "</th>";
            var totall = document.getElementById("total");

            totall.innerHTML = fila;
                }
                }

function sumarTres(){
    if (btnTres) {
        contadorTres ++
        precioTres += 150000
        total += 150000 
        cantAnuncios ++
        var fila = "<td>"
            fila += contadorTres
            fila += "</td><td>NOTEBOOK 9 PRO</td><td>"
            fila += precioTres
            fila += "</td><td>"
            fila += "<button onclick = quitarTres()>quitar</button></td>"                   
            var cantProductoTres = document.getElementById("cantProductoTres")
            cantProductoTres.innerHTML=fila             
            
        var fila = "<th>";
        fila += "Cantidad de anuncios seleccionados: " + cantAnuncios;
        fila += "</th>";
            
        var cantidad = document.getElementById("sumar");
        cantidad.innerHTML = fila;
            
        var fila = "<th>";
            fila += "costo total: " + total;
            fila += "</th>";
        var totall = document.getElementById("total");

        totall.innerHTML = fila;
        }            
    }

btnTres.onclick= sumarTres