<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Practica</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
<style>
        .album{clear: left; width: 100%;}
        .portada{clear: left; float: left;}
        .datos{float: left; padding-left: 20px;}
        .descuento{clear:left;}
    </style>
</head>
<body>
    <div class="container mt-3">
        <?php 
            $articulos=[];
            $articulos[0]="Libros";
            $articulos[1]="CDs";
            $articulos[2]="Revistas";
            $articulos[3]="DVDs";
            function test_alter(&$elemento1, $clave, $prefijo)
            {
                $elemento1 = "$prefijo: $elemento1";
            }

            function test_print($elemento2, $clave)
            {
                echo $clave."-".$elemento2." ";
            }
            
            $array = $articulos;
            $separado_por_comas = implode(",", $array);
            $art = array('Libro' => 'Historias', 'Revista' => 'Articulos');
            $propiedades = array('Novela' => $art, 'Publicidad' => 'Revista');

            function prueba_imprimir($item, $clave)
            {
                echo "$clave contiene $item ";
            }
        ?>
        <h2 class="text-center mb-4">Manipulacion de arreglos en PHP</h2>

            <div class="row-3">
                <div class="d-flex">
                    <div class="col text-right">
                        <h4><b>Instrucción PHP</b></h4>
                        <p>print_r($articulos);</p>
                        <hr>
                        <p>unset($articulos[2]);</p>
                        <hr>
                        <p>array_key_exists('DVD', $articulos);</p>
                        <hr>
                        <p>in_array("DVDs", $articulos);</p>
                        <hr>
                        <p>array_search("CDs", $articulos);</p>
                        <hr>
                        <p>array_push($articulos, "Periodico");</p>
                        <hr>
                        <p>array_pop($articulos);</p>
                        <hr>
                        <p>array_shift($articulos);</p>
                        <hr>
                        <p>array_unshift($articulos, "Audifonos","USB");</p>
                        <hr>
                        <p>array_rand($articulos,2);</p>
                        <hr>
                        <p>array_walk($articulos,'prueba');</p>
                        <hr>
                        <p>implode('hola', array())</p>
                        <hr>
                        <p>print_r(explode('|', $str, 2));</p>
                        <hr>
                        <p>array_walk_recursive($propiedades, 'prueba_imprimir'); </p>
                        <br>
                        <hr>
                        <p>array_merge($articulos, $array))</p>
                        <hr>

                    </div>
                    <div class="col">
                    <h4><b>Resultado</b></h4>
                        <p><?php print_r($articulos);?></p>
                        <hr>
                        <p><?php unset($articulos[2]); print_r($articulos);?></p>
                        <hr>
                        <p><?php var_dump(array_key_exists('DVD', $articulos));?></p>
                        <hr>
                        <p><?php var_dump(in_array("DVDs", $articulos));?></p>
                        <hr>
                        <p><?php var_dump(array_search("CDs", $articulos));?></p>
                        <hr>
                        <p><?php array_push($articulos, "Periodico"); print_r($articulos);?></p>
                        <hr>
                        <p><?php array_pop($articulos); print_r($articulos);?></p>
                        <hr>
                        <p><?php array_shift($articulos); print_r($articulos);?></p>
                        <hr>
                        <p><?php array_unshift($articulos, "Audifonos","USB"); print_r($articulos);?></p>
                        <hr>
                        <p><?php var_dump(array_rand($articulos,2));?></p>
                        <hr>
                        <p><?php array_walk($articulos, 'test_print');?></p>
                        <hr>
                        <p><?php var_dump(implode('hola', array()));?></p>
                        <hr>
                        <p><?php $str = 'Libros|Cds|Revistas|Dvds'; print_r(explode('|', $str, 2)); ?></p>
                        <hr>
                        <p><?php array_walk_recursive($propiedades, 'prueba_imprimir'); ?></p>
                        <hr>
                        <p><?php var_dump(array_merge($articulos, $array));  ?></p>
                        <hr>
                        
                    </div>
                </div>
            </div>
            
            <h2 class="text-center mb-4">Segunda parte</h2>
            <h3>Mi canasta</h3>
    <form name="albunes" action="" method="POST">
    <div class="album">
        <div class="portada">
            <img src="https://img.favpng.com/12/20/1/computer-icons-user-profile-login-avatar-png-favpng-EphX5rTBCrk1QLtEWPmS9h1M9.jpg" width="50px" alt="X">
        </div>
        <div class="datos">
            Cesaria Evora "En un concierto" Precio: $99
            <input type="hidden" name="codigo[0]" value="001">
            <input type="hidden" name="artista[0]" value="Cesaria Evora">
            <input type="hidden" name="album[0]" value="En un concierto">
            <input type="hidden" name="precio[0]" value="99">
            <input type="hidden" name="genero[0]" value="World"><br>
            Cantidad a ordenar:
            <input type="text" size="2" maxlength="3" name="cantidad[0]" value="0" style="background-color: #f8ce6c;">
        </div>
    </div>    
    <div class="descuento">
        <br>
        <hr>
        Descuento: <br>
        <input type="checkbox" name="estudiante" value="15">
        Estudiante: 15% <br>
        <input type="checkbox" name="cliente" value="10">
        Cliente: 10% <br>
        <input type="submit" class="btn btn-dark mt-2" name="enviar" value="Ordenar">
    </div>
</form>
        </div>

<br>
<br>
<br>
<br>

</body>
</html>