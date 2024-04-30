<?php
 

$putdata = fopen('php://input', 'r');
$raw_data = "";
while ($chunk = fread($putdata, 1024))
    $raw_data .= $chunk;

fclose($putdata);
$adatJSON = json_decode($raw_data);
$fazon = $adatJSON->fazon;
$fnev = $adatJSON->fnev;
$ftel = $adatJSON->ftel;

require_once './database.php';

$SQL = "UPDATE `futar` SET `fnev`=?,`ftel` = ? WHERE `fazon` =". $keresSzoveg[1];
$stmt = $connection->prepare($SQL);
$stmt->bind_param('ss',$fnev,$ftel);
if ($stmt->execute()) {    
    http_response_code(201);
   echo 'Sikeres módosítás';
} else {
    http_response_code(404);
    echo 'Nincs ilyen ügyfél';
}