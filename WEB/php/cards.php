<?php
require_once("../php/addons.php");
require_once("../php/connect.php");
Utils::StartSession();

if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true)
{
    $input = $param = "";
    $sql = "select * from ".TABLE_DATA." limit 0, 10";

    #region Szűrési feltétel
    if (!empty($_POST["mikorelt"]) && empty($_POST["taplalkozasi_forma"])) {
        $input = Utils::Clean($_POST["mikorelt"]);
        $param = "%".substr($input, 0, -3)."%";
        $sql = "select * from ".TABLE_DATA." where mikorelt like ? limit 0, 10";
    }
    if(!empty($_POST["taplalkozasi_forma"]) && empty($_POST["mikorelt"])) {
        $input = Utils::Clean($_POST["taplalkozasi_forma"]);
        $param = $input;
        $sql = "select * from ".TABLE_DATA." where taplalkozasi_forma = ? limit 0, 10";
    }
    #endregion

    #region Query
    if ($stmt = $mysqli->prepare($sql))
    {
        if (!empty($param))
            $stmt->bind_param("s", $param);
        if($stmt->execute())
        {
            $result = $stmt->get_result();
            if($result->num_rows > 0)
                while($row = $result->fetch_assoc())
                    CreateCard($row["nev"], $row["kep"], $row["leiras"]);
            else
                NotFound(strtolower($input));
        }
        $stmt->close();
    }
    #endregion
}
else
    echo "";

function CreateCard($title, $image, $text, $count = 10)
{
    $words = explode(" ", $text);
    $text = "";
    for ($i=0; $i < $count; $i++)
    {
        if ($i < $count-1)
            $text .= $words[$i]." ";
        else
        {
            $str = substr($words[$i], 0, -1);
            $lastchar = substr($words[$i], -1);
            if (Utils::ValidFormat($lastchar, "/[^\.,;]/"))
                $str .= $lastchar;
            $text .= $str."...";
        }
    }
    echo '<div class="bg-alpha-white card col-12 col-sm-6 col-md-4 col-lg-3">';
        echo '<img src="data:image/png;base64,'.base64_encode($image).'" class="card-img-top mt-3" title="'.$title.'">';
        echo '<div class="card-body d-flex flex-column">';
            echo '<h5 class="card-title">'.$title.'</h5>';
            echo '<p class="card-text">'.$text.'</p>';
            echo '<button type="button" class="btn btn-success btn-lg mt-auto align-self-end" data-bs-toggle="modal" data-bs-target="#modalId">Tovább</button>';
        echo '</div>';
    echo '</div>';
}
function NotFound($search)
{
    echo '<h3 class="text-center text-dark bg-alpha-white w-initial">';
    echo 'Sajnos nem található a keresési feltételnek ('.$search.') megfelelő dinoszaurusz!';
    echo '</h3>';
}