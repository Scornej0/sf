#!/bin/bash
rutaInicial=$(pwd)
# text=$rutaInicial/parametro.txt

#!/bin/bash
rutaInicial=$(pwd)
# text=$rutaInicial/parametro.txt
# el echo test2 es solo para generar espacio

echo $test2

cat parametro.txt | while read lin
do

rutaSinPWD=$lin

echo $rutaSinPWD
echo $test2
echo $test2
echo $test2
cd $rutaSinPWD/$rutaSinPWD/

#pensado para actualizar la rama antes de sacar los fuentes

#git pull
echo $test2

ruta=$(pwd)

cd ../
ruta2=$(pwd)

cat lista.txt | while read linea
do

rutaCopia="$ruta2/Fuentes-$rutaSinPWD$oc/$linea"
echo $rutaCopia


done

echo ***************** FIN de EJECUCION *******************

sleep 2

