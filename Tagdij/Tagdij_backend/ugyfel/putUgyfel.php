<?php
$putdata = fopen('php://input', 'r');
$raw_data = "";
while ($chunk = fread($putdata, 1024))
    $raw_data .= $chunk;

fclose($putdata);
$adatJSON = json_decode($raw_data);
$azon = $adatJSON->azon;
$nev = $adatJSON->nev;
$szulev = $adatJSON->szulev;
$irszam = $adatJSON->irszam;
$orsz = $adatJSON->orsz;

require_once './database.php';

$SQL = "UPDATE ugyfel SET nev = ?, szulev = ?, irszam = ?, orsz = ? WHERE azon = ?";
$stmt = $connection->prepare($SQL);
$stmt->bind_param('siisi',$nev,$szulev,$irszam,$orsz,$azon);
if ($stmt->execute()) {    
    http_response_code(201);
   echo 'Sikeres módosítás';
} else {
    http_response_code(404);
    echo 'Nincs ilyen ügyfél';
}