<?php
$SQL = '';
//Összes ügyfél adatai JSON-ben
if (count($keresSzoveg) > 1) {
    if (is_int(intval($keresSzoveg[1]))) {
        //http://localhost/pizzaUgyfelek/Backend/index.php?futar
        $SQL = 'SELECT * FROM futar WHERE fazon = ' .  $keresSzoveg[1];
    } 
} else {
    //http://localhost/pizzaUgyfelek/Backend/index.php?futar/1
    $SQL = 'SELECT * FROM futar where 1';
}
require_once './database.php';
$result = $connection->query($SQL);
if ($result->num_rows > 0) {
    $ugyfelek = array();
    while ($row = $result->fetch_assoc()) {
        $ugyfelek[] = $row;
    }
    http_response_code(200);
    echo json_encode($ugyfelek);
} else {
    http_response_code(404);
    echo 'Nincs egy ügyfél sem';
}
