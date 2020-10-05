<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Practica</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <div class="container mt-3">
         <h4>Pracrtica 05-10-2020</h4>
   

    <?php
        $dolares = 999.99; 
        $tipoDeCambio = 1.2;
    ?>
    <div class="form-group">
        <h6 for="from-control"><?php echo "Valor del dolar ".$dolares;?></h6>
        <h6 for="from-control"><?php echo "Valor actual del cambio ".$tipoDeCambio;?></h6>
        <h6><?php echo "Total: ".($dolares*$tipoDeCambio); ?></h6>
    </div>

    <h4 class="text-center">Lista de calificación del alumno <b>destructive</b></h4>
        <?php
            $materias = array(
                "Programacion"=>8.5, 
                "Base de datos"=>9.4,
                "Software a la medida"=>10.0,
                "Inteligencia artificial"=>9.0
            );
            $total=sizeof($materias);
            $acum=0;
        ?> 
        <table class="table">
            <thead class="thead-dark">
                <tr>
                <th scope="col"></th>                
                <th scope="col">Asignatura</th>
                <th scope="col">Calificación</th>
                </tr>
            </thead>

              <tbody>
                <?php
                $i=1; 
                    foreach($materias as $materia => $materia_calificacion){?>
                        <tr>
                            <th scope="col"><?php echo$i;?></th>
                            <th scope="col"><?php echo$materia;?></th>
                            <th scope="col"><?php echo$materia_calificacion;?></th>
                            <?php $acum += $materia_calificacion; $i+=1;?>
                        </tr>
               <?php } ?>
               <th></th>
               <th class="text-right">Promedio</th>
               <th><?php echo $acum/$total;?></th>
              </tbody>
        </table>
    </div>
</body>
</html>