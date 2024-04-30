<?php
$SQL = '';
//Összes ügyfél adatai JSON-ben
if (count($keresSzoveg) > 1) {
    if (is_int(intval($keresSzoveg[1]))) {
        //http://localhost/pizzaUgyfelek/Backend/index.php?vevo/1
        $SQL = 'SELECT * FROM vevo WHERE vazon = ' .  $keresSzoveg[1];
    } 
} else {
    //http://localhost/pizzaUgyfelek/Backend/index.php?vevo
    $SQL = 'SELECT * FROM vevo where 1';
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
