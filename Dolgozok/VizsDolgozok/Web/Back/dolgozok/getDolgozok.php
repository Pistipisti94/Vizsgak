<?php
$SQL = '';
//Összes ügyfél adatai JSON-ben
    $SQL = 'SELECT * FROM dolgozok where 1';
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