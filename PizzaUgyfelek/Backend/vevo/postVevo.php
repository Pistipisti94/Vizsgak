<?php
$azon = $_POST["vazon"];
$nev = $_POST["vnev"];
$tel = $_POST["vcim"];

require_once './database.php';
$SQL = "INSERT INTO `vevo`(`vazon`, `vnev`, `vcim`) VALUES (?,?,?)";
$stmt = $connection->prepare($SQL);
$stmt->bind_param("iss",$azon,$nev,$tel);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
echo'Nope';
}