<?php
$azon = $_POST["fazon"];
$nev = $_POST["fnev"];
$tel = $_POST["ftel"];

require_once './database.php';
$SQL = "INSERT INTO `futar`(`fazon`, `fnev`, `ftel`) VALUES (?,?,?)";
$stmt = $connection->prepare($SQL);
$stmt->bind_param("iss",$azon,$nev,$tel);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
echo'Nope';
}