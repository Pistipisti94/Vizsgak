<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'vevo/getVevo.php';
        break;
    case 'POST':
        require_once 'vevo/postVevo.php';
        break;
    case 'PUT':
        require_once 'vevo/putVevo.php';
        break;

    

    default:
        # code...
        break;
}