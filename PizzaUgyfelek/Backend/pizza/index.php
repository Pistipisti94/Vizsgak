<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'pizza/getPizza.php';
        break;
    case 'POST':
        require_once 'pizza/postPizza.php';
        break;
    case 'PUT':
        require_once 'pizza/putPizza.php';
        break;

    

    default:
        # code...
        break;
}