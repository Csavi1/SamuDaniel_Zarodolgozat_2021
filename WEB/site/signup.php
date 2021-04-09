<?php
    require_once("../php/addons.php");
    Utils::StartSession();
    if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true)
        Utils::Redirect("main.php");


    require_once("../php/connect.php");
    $email = $email_err = $username = $username_err = "";
    $password = $password_err = $confirm = $confirm_err = "";
    if (!empty($_SESSION["email"]))
        $email = $_SESSION["email"];


    if ($_SERVER["REQUEST_METHOD"] == "POST")
    {
        #region Email
        if (!empty($_POST["email"]))
        {
            $email = strtolower(Utils::Clean($_POST["email"]));
            if (!Utils::ValidEmail($email))
            {
                $email_err = "Az email cím nem megfelelő formátumú.";
            }
            else
            {
                $sql = "select id from ".TABLE_USERS." where email = ?";
                if ($stmt = $mysqli->prepare($sql))
                {
                    $stmt->bind_param("s", $email);
    
    
                    if($stmt->execute())
                    {
                        $stmt->store_result();
                        if($stmt->num_rows > 0)
                        {
                            $email_err = "Ez az email cím már foglalt.";
                        }
                    }
                    $stmt->close();
                }
            }
        }
        else
        {
            $email_err = "Az email cím nem lehet üres.";
        }
        #endregion

        #region Username
        if (!empty($_POST["username"]))
        {
            $username = Utils::Clean($_POST["username"]);
            if ($e = Utils::InvalidUsername($username))
            {
                switch ($e)
                {
                    case 1:
                        $username_err = "A felhasználónévnek minimum 3 karakter hosszúnak kell lennie.";
                        break;
                    case 2:
                        $username_err = "A felhasználónév nem tartalmazhat ékezetes vagy speciális karaktert.";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                $sql = "select id from ".TABLE_USERS." where nev = ?";
                if ($stmt = $mysqli->prepare($sql))
                {
                    $stmt->bind_param("s", $username);
    
    
                    if($stmt->execute())
                    {
                        $stmt->store_result();
                        if($stmt->num_rows > 0)
                        {
                            $username_err = "Ez a felhasználónév már foglalt.";
                        }
                    }
                    $stmt->close();
                }
            }
        }
        else
        {
            $username_err = "A felhasználónév nem lehet üres.";
        }
        #endregion

        #region Password
        if (!empty($_POST["password"]))
        {
            $password = Utils::Clean($_POST["password"]);
            switch (Utils::InvalidPassword($password))
            {
                case 1:
                    $password_err = "A jelszónak minimum 8 karakter hosszúnak kell lennie.";
                    break;

                case 2:
                    $password_err = "A jelszónak tartalmaznia kell legalább egy nagybetűt.";
                    break;
                
                case 3:
                    $password_err = "A jelszónak tartalmaznia kell legalább egy számot.";
                    break;

                default:
                    break;
            }
        }
        else
        {
            $password_err = "A jelszó mező nem lehet üres.";
        }
        #endregion

        #region Confirm
        if (!empty($_POST["confirm"]))
        {
            $confirm = Utils::Clean($_POST["confirm"]);
            if ($password != $confirm)
                $confirm_err = "A megadott jelszavak nem egyeznek meg.";
        }
        else
        {
            $confirm_err = "A jelszó újra mező nem lehet üres.";
        }
        #endregion

        #region Insert
        if (empty($email_err) && empty($username_err) && empty($password_err) && empty($confirm_err))
        {
            $sql = "insert into ".TABLE_USERS." (email, nev, jelszo) values (?, ?, ?)";
            if ($stmt = $mysqli->prepare($sql))
            {
                $stmt->bind_param("sss", $email, $username, Utils::PasswordHash($password));
                if($stmt->execute())
                {
                    $_SESSION["uid"] = $mysqli->insert_id;
                    $_SESSION["email"] = $email;
                    $_SESSION["username"] = $username;
                    $_SESSION["loggedin"] = true;
                    Utils::Redirect("main.php");
                }
                $stmt->close();
            }
        }
        #endregion
        $mysqli->close();
    }
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <?php Utils::LoadPage(head); ?>
    <title>Regisztráció - Dinók könyve</title>
</head>
<body class="bg-dark">
<!-- Navigation start -->
    <?php Utils::LoadPage(nav_out); ?>
<!-- Navigation end -->

<!-- Registration form start -->
    <div class="container center">
        <div class="row justify-content-center">
            <div class="col-8 col-md-6 col-xl-4">
                <div class="container-main inverse">
                    <h3 class="greet mb-3">Úgy tűnik új vagy itt!</h1>
                    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" role="form">
                        <label for="email" class="form-label<?php echo empty($email_err) ? "" : " text-danger"; ?>">Email cím</label>
                        <input type="text" class="form-control<?php echo empty($email_err) ? " mb-2" : " is-invalid"; ?>" placeholder="Kérlek add meg az email címed" aria-describedby="emailHelp" name="email" id="email" autofocus value="<?php echo $email; ?>">
                        <span id="emailHelp" class="invalid-feedback mb-3"><?php echo $email_err; ?></span>

                        <label for="username" class="form-label<?php echo empty($username_err) ? "" : " text-danger"; ?>">Felhasznalónév</label>
                        <input type="text" class="form-control<?php echo empty($username_err) ? " mb-2" : " is-invalid"; ?>" placeholder="Kérlek add meg a felhasználóneved" aria-describedby="usernameHelp" name="username" id="username" value="<?php echo $username; ?>">
                        <span id="usernameHelp" class="invalid-feedback mb-3"><?php echo $username_err; ?></span>

                        <label for="password" class="form-label<?php echo empty($password_err) ? "" : " text-danger"; ?>">Jelszó</label>
                        <input type="password" class="form-control<?php echo empty($password_err) ? " mb-2" : " is-invalid"; ?>" placeholder="" aria-describedby="passwordHelp" name="password" id="password" value="<?php echo $password; ?>">
                        <span id="passwordHelp" class="invalid-feedback mb-3"><?php echo $password_err; ?></span>

                        <label for="confirm" class="form-label<?php echo empty($confirm_err) ? "" : " text-danger"; ?>">Jelszó újra</label>
                        <input type="password" class="form-control<?php echo empty($confirm_err) ? " mb-2" : " is-invalid"; ?>" placeholder="" aria-describedby="confirmHelp" name="confirm" id="confirm" value="<?php echo $confirm; ?>">
                        <span id="confirmHelp" class="invalid-feedback mb-3"><?php echo $confirm_err; ?></span>

                        <button class="w-100 btn btn-lg btn-secondary mt-3 fw-bold border-dark bg-dark main-btn inverse" type="submit">Regisztráció</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
<!-- Registration form end -->
</body>
</html>