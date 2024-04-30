<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'ugyfel/getUgyfel.php';
        break;

    case 'POST':
        require_once 'ugyfel/postUgyfel.php';

        break;
    case 'PUT':
        require_once 'ugyfel/putUgyfel.php';
        break;
    case 'DELETE':
        require_once 'ugyfel/deleteUgyfel.php';
        break;

    default:
        # code...
        break;
}
