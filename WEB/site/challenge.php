<?php
    require_once("../php/addons.php");
    Utils::StartSession();
    if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true)
        Utils::Redirect("main.php");
    if (empty($_SESSION["uid"]))
        Utils::Redirect("checkemail.php");

    
    require_once("../php/connect.php");
    $password = $password_err = "";


    if ($_SERVER["REQUEST_METHOD"] == "POST")
    {
        if (!empty($_POST["password"]))
        {
            $password = Utils::Clean($_POST["password"]);
        }
        else
        {
            $password_err = "Az jelszó nem lehet üres.";
        }


        if (empty($password_err))
        {
            $sql = "select nev, jelszo from ".TABLE_USERS." where id = ?;"; 


            if ($stmt = $mysqli->prepare($sql))
            {
                $stmt->bind_param("s", $_SESSION["uid"]);


                if($stmt->execute())
                {
                    $stmt->store_result();


                    if($stmt->num_rows == 1)
                    {
                        $stmt->bind_result($nev, $jelszohash);
                        if($stmt->fetch())
                        {
                            if (Utils::PasswordVerify($password, $jelszohash))
                            {
                                $_SESSION["username"] = $nev;
                                $_SESSION["loggedin"] = true;
                                Utils::Redirect("main.php");
                            }
                            else
                            {
                                $password_err = "Hibás jelszó.";
                            }
                        }
                    }
                }


                $stmt->close();
            }
        }


        $mysqli->close();
    }
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <?php Utils::LoadPage(head); ?>
    <title>Bejelentkezés - Dinók könyve</title>
</head>
<body class="bg-dark">
<!-- Navigation start -->
    <?php Utils::LoadPage(nav_out); ?>
<!-- Navigation end -->

<!-- Password check start -->
    <div class="container center">
        <div class="row justify-content-center">
            <div class="col-8 col-md-6 col-xl-4">
                <div class="container-main inverse">
                    <h3 class="greet mb-3">Üdv újra itt!</h1>
                    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" role="form">
                    <label for="password" class="form-label<?php echo empty($password_err) ? "" : " text-danger"; ?>">Jelszó</label>
                        <input type="password" class="form-control<?php echo empty($password_err) ? "" : " is-invalid"; ?>" placeholder="" aria-describedby="passwordHelp" name="password" id="password" autofocus value="<?php echo $password; ?>">
                        <span id="passwordHelp" class="invalid-feedback"><?php echo $password_err; ?></span>
                        <button class="w-100 btn btn-lg btn-secondary mt-3 fw-bold border-dark bg-dark main-btn inverse" type="submit">Bejelentkezés</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
<!-- Password check end -->
</body>
</html>