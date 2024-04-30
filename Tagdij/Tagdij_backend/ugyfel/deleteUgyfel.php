<?php
$SQL = "";
$azon = $_POST["azon"];
if (count($keresSzoveg) > 1) {
    if (is_int(intval($keresSzoveg[1]))) {
        echo 'Ügyfél: ' . $keresSzoveg[1];
        $SQL = "DELETE FROM `ugyfel` WHERE azon =" . $keresSzoveg[1];
    } else {
        echo 'Ügyfél: ' . $keresSzoveg[1];
        echo '<br>';
        http_response_code(404);
        echo 'Nem létező ügyfél';
    }
}
require_once './database.php';


if ($result = $connection->query($SQL)) {
    http_response_code(201);
    echo 'Sikeresen törölve';
} else {
    http_response_code(404);
    echo 'Nope';
}
