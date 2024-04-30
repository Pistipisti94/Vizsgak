<?php
switch ($_SERVER['REQUEST_METHOD']) {
    case 'GET':
        require_once 'befizetes/getBefizetes.php';
        break;

    case 'POST':
        require_once 'befizetes/postBefizetes.php';

        break;
    default:
        # code...
        break;
}