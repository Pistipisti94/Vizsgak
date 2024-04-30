<?php
$SQL = '';
$SQL = 'SELECT * FROM levesek where 1';
require_once "./database.php";
$result = $connection->query($SQL);
if ($result->num_rows > 0) {
    $etelek = array();
    while ($row = $result->fetch_assoc()) {
        $etelek[] = $row;
    }
    http_response_code(200);
    echo json_encode($etelek);
} else {
    http_response_code(404);
}