<?php
    require_once("../php/addons.php");
    Utils::StartSession();
    $loggedin = isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true;
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <?php Utils::LoadPage(head); ?>
    <script src="../js/getter.js" async></script>
    <title>Dinók könyve</title>
</head>
<body class="bg-dark body-main vh-100">
<!-- Navigation start -->
    <?php echo $loggedin ? Utils::LoadPage(nav_in) : Utils::LoadPage(nav_out); ?>
<!-- Navigation end -->

<!-- Main section start -->
    <?php
    if (!$loggedin)
        Utils::LoadPage(land);
    else
        echo '
        <main class="container">
            <div class="mt-5 row alignt-items-center justify-content-around">
            </div>
        </main>
        ';
    
    ?>
<!-- Main section end -->

<!-- Modal section start -->
<div class="modal fade" id="modalId" tabindex="-1" aria-labelledby="modalLabelId" aria-hidden="true">
    <div class="modal-dialog modal-xl">
        <div class="modal-content"></div>
    </div>
</div>
<!-- Modal section end -->
</body>
</html>