<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'futar/getFutarok.php';
        break;
    case 'POST':
        require_once 'futar/postFutarok.php';
        break;
    case 'PUT':
        require_once 'futar/putFutarok.php';
        break;

    

    default:
        # code...
        break;
}