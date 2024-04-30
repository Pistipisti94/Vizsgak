<?php
$osszeg = $_POST["osszeg"];
require_once './database.php';
$stmt = $connection->prepare("Insert into befiz (azon, osszeg) values (?, ?)");
$stmt->bind_param("ii",$keresSzoveg[1],$osszeg);
if ($stmt->execute()) {
http_response_code(201);
}else {
http_response_code(404);
}
