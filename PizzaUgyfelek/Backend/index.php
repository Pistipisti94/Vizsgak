<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET, POST, DELETE, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type, Authorization");
header('Content-Type: application/json; charset=utf-8');

$keresSzoveg = explode('/', $_SERVER['QUERY_STRING']);
if ($keresSzoveg[0] === 'futar') {
    require_once 'futar/index.php';
} elseif ($keresSzoveg[0] === 'pizza') {
    require_once 'pizza/index.php';
} elseif ($keresSzoveg[0] === 'vevo') {
    require_once 'vevo/index.php';
} else {
    http_response_code(404);
    $JSONerror = array("message" => "Nincs ilyen API");
    return json_encode($JSONerror);
}
