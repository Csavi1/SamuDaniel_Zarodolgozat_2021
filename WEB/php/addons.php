<?php


// Constants
define("head", "../common/head.html");
define("land", "../common/land.html");
define("nav_out", "../common/nav_out.html");
define("nav_in", "../common/nav_in.html");


// Utilities class
class Utils
{
    #region Basic functions
    public static function Clean($data)
    {
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
    }
    public static function Redirect($url)
    {
        header("location: {$url}");
        exit;
    }
    public static function StartSession()
    {
        session_start();
    }
    public static function DestroySession()
    {
        session_unset();
        session_destroy();
    }
    public static function ValidFormat($var, $pattern)
    {
        if (strlen(preg_replace($pattern, "", $var)) != 0)
        {
            return false;
        }
        return true;
    }
    public static function LoadPage($path)
    {
        echo file_get_contents($path);
    }
    #endregion

    #region Form validation, Hashing
    public static function ValidEmail($email)
    {
        return Utils::ValidFormat($email, "/^[\w\d\-\.\/]+@[a-z\d\-]+(?:\.[a-z\d\-]{2,})+$/i");
    }
    public static function InvalidPassword($password, $minlength = 8, $containupper = true, $containdigit = true)
    {
        // Checks length
        if (strlen($password) < $minlength)
            return 1;

        
        // Checks for uppercase characters
        if ($containupper && !preg_match("/[A-Z]/", $password))
            return 2;
        

        // Checks for digits
        if ($containdigit && !preg_match("/[\d]/", $password))
            return 3;
        
        
        // If there were no exceptions
        return 0;
    }
    public static function InvalidUsername($username, $minlength = 3)
    {
        // Checks length
        if (strlen($username) < $minlength)
            return 1;

        
        // Checks for special characters
        if (!Utils::ValidFormat($username, "/^[\w\d\-\.]+$/"))
            return 2;
            
        
        // If there were no exceptions
        return 0;
    }
    private static function Encrypt($password)
    {
        $mysalt = ">^˛^<";
        return hash("sha512", $password.$mysalt);
    }
    public static function PasswordHash($password)
    {
        return password_hash(Utils::Encrypt($password), PASSWORD_DEFAULT);
    }
    public static function PasswordVerify($password, $hashedpassword)
    {
        return password_verify(Utils::Encrypt($password), $hashedpassword);
    }
    #endregion
}