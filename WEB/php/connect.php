<?php
    define("DB_SERVER", "localhost");
    define("DB_USERNAME", "user");
    define("DB_PASSWORD", "user_password");
    define("DB_NAME", "dinobazis");
    define("DB_PORT", "3306");


    define("TABLE_USERS", "felhasznalok");
    define("TABLE_DATA", "dinoszauruszok");


    require_once("addons.php");
    // mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
    $mysqli;
    try {
        @$mysqli = new mysqli(DB_SERVER, DB_USERNAME, DB_PASSWORD, DB_NAME, DB_PORT);
        if($mysqli->connect_errno != 0)
            throw new Exception("Error 404");
        $mysqli->set_charset("utf8");
    }
    catch(Exception $e) {
        // echo $e->getMessage();
        // mysqli_report(MYSQLI_REPORT_OFF);
        // exit;
        Utils::Redirect("index.php");
    }
    // var_dump($mysqli);
    // mysqli_report(MYSQLI_REPORT_OFF);