<?php
    require_once("../php/addons.php");
    Utils::StartSession();
    if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true)
    {
        Utils::Redirect("main.php");
    }

    
    require_once("../php/connect.php");
    $email = $email_err = "";


    if ($_SERVER["REQUEST_METHOD"] == "POST")
    {
        if (!empty($_POST["email"]))
        {
            $email = strtolower(Utils::Clean($_POST["email"]));
            if (!Utils::ValidEmail($email))
            {
                $email_err = "Az email cím nem megfelelő formátumú.";
            }
        }
        else
        {
            $email_err = "Az email cím nem lehet üres.";
        }


        if (empty($email_err))
        {
            $sql = "select id from ".TABLE_USERS." where email = ?";


            if ($stmt = $mysqli->prepare($sql))
            {
                $stmt->bind_param("s", $email);


                if($stmt->execute())
                {
                    $_SESSION["email"] = $email;
                    $stmt->store_result();


                    if($stmt->num_rows == 1)
                    {
                        $stmt->bind_result($id);
                        if($stmt->fetch())
                        {
                            $_SESSION["uid"] = $id;
                            Utils::Redirect("challenge.php");
                        }
                    }
                    else
                    {
                        Utils::Redirect("signup.php");
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

<!-- Email check start -->
    <div class="container center">
        <div class="row justify-content-center">
            <div class="col-8 col-md-6 col-xl-4">
                <div class="container-main inverse">
                    <h3 class="greet mb-3">Üdv!</h1>
                    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" role="form">
                        <label for="email" class="form-label<?php echo empty($email_err) ? "" : " text-danger"; ?>">Email cím</label>
                        <input type="text" class="form-control<?php echo empty($email_err) ? "" : " is-invalid"; ?>" placeholder="Kérlek add meg az email címed" aria-describedby="emailHelp" name="email" id="email" autofocus value="<?php echo $email; ?>">
                        <span id="emailHelp" class="invalid-feedback"><?php echo $email_err; ?></span>
                        <button class="w-100 btn btn-lg btn-secondary mt-3 fw-bold border-dark bg-dark main-btn inverse" type="submit">Következő</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
<!-- Email check end -->
</body>
</html>