<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'dolgozok/getDolgozok.php';
        break;

    

    default:
        # code...
        break;
}