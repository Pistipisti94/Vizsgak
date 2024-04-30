<?php
$connection = new mysqli("localhost", "root", "", "etelek");
if ($connection->connect_error)
    die("Connection failed: " . $connection->connect_error);
$connection->set_charset('utf8');