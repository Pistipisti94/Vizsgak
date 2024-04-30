<?php
$nev = $_POST["nev"];
$szulev = $_POST["szulev"];
$irszam = $_POST["irszam"];
$orsz = $_POST["orsz"];

require_once './database.php';
$SQL = "Insert into ugyfel (azon, nev, szulev, irszam, orsz) values (NULL, ?, ?, ?, ?)";
$stmt = $connection->prepare($SQL);
$stmt->bind_param("siis",$nev,$szulev,$irszam,$orsz);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
echo'Nope';
}
