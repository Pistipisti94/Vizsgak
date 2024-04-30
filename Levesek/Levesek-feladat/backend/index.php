<?php 
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Headers: Content-Type, Authorization");
header('Content-Type: application/json; charset=utf-8');

    //var_dump($_SERVER['REQUEST_METHOD']);
    //var_dump($_SERVER['QUERY_STRING']);
    $keresSzoveg = explode('/',$_SERVER['QUERY_STRING']);
    if ($keresSzoveg[0] ==='levesek') {
        require_once 'levesek/index.php';
    }
    else
    {
        http_response_code(404);
        $JSONerror = array("message" => "Nincs ilyen API");
        return json_encode($JSONerror); 
    }