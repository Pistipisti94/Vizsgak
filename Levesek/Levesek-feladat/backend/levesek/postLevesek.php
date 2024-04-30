<?php
$megnevezes = $_POST["megnevezes"];
$kaloria = $_POST["kaloria"];
$feherje = $_POST["feherje"];
$zsir = $_POST["zsir"];
$szenhidrat = $_POST["szenhidrat"];
$hamu = $_POST["hamu"];
$rost = $_POST["rost"];

require_once './database.php';
$SQL = "Insert into `levesek`(`megnevezes`, `kaloria`, `feherje`, `zsir`, `szenhidrat`, `hamu`, `rost`) VALUES (?,?,?,?,?,?,?)";
$stmt = $connection->prepare($SQL);
$stmt->bind_param("siddddd",$megnevezes,$kaloria,$feherje,$zsir,$szenhidrat,$hamu,$rost);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
}