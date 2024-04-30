<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'getLevesek.php';
        break;
    case 'POST':
        require_once 'postLevesek.php';
        break;
    default:
        # code...
        break;
}