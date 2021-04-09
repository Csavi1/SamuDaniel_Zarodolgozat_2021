<?php
    require_once("../php/addons.php");
    Utils::StartSession();
    Utils::DestroySession();
    Utils::Redirect("main.php");
?>