<?php
$azon = $_POST["pazon"];
$nev = $_POST["pnev"];
$tel = $_POST["par"];

require_once './database.php';
$SQL = "INSERT INTO `pizza`(`pazon`, `pnev`, `par`) VALUES (?,?,?)";
$stmt = $connection->prepare($SQL);
$stmt->bind_param("isi",$azon,$nev,$tel);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
echo'Nope';
}