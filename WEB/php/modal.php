<?php
require_once("../php/addons.php");
require_once("../php/connect.php");
Utils::StartSession();


if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] == true) {
    if(isset($_POST["title"])) {

        $title = Utils::Clean($_POST["title"]);
        $sql = "select * from ".TABLE_DATA." where nev = ?";
        if ($stmt = $mysqli->prepare($sql)) {

            $stmt->bind_param("s", $title);
            if($stmt->execute()) {

                $result = $stmt->get_result();
                if($result->num_rows > 0)
                    if($row = $result->fetch_assoc())
                        LoadModal($row);
            }
            $stmt->close();
        }
    }

}
else 
    echo "";

function NotNull($prop, $text) {
    if(!empty($prop)) {
        return '
        <tr>
            <th>'.$text.':</th>
            <td>'.$prop.'</td>
        </tr>
        ';
    }
}
function LoadModal($fields) {
    echo '
    <div class="modal-header">
        <h5 class="modal-title" id="modalLabelId">'.$fields["nev"].'</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
    </div>
    <div class="modal-body">
        <div class="container-fluid">
            <div class="row justify-content-center align-items-start">
                <div class="col-12 col-lg-4 col-xl-3">
                    <img class="img-fluid border border-3 rounded-3" src="data:image/png;base64,'.base64_encode($fields["kep"]).'">
                </div>
                <div class="col-12 col-lg-8 col-xl-9">
                    <table class="table table-success table-hover table-borderless">
                        <tr>
                            <th>Felfedező:</th>
                            <td>'.$fields['felfedezo'].' ('.$fields['felfedezes_datuma'].')'.'</td>
                        </tr>
                        <tr>
                            <th>Mikor élt?</th>
                            <td>'.$fields["mikorelt"].'</td>
                        </tr>
                        <tr>
                            <th>Lelőhelyek:</th>
                            <td>'.$fields["lelohelyek"].'</td>
                        </tr>
                        <tr>
                            <th>Élőhelye:</th>
                            <td>'.$fields["elohelyek"].'</td>
                        </tr>
                        <tr>
                            <th>Táplálék:</th>
                            <td>'.$fields["taplalek"].'</td>
                        </tr>
                        <tr>
                            <th>Táplákozási forma:</th>
                            <td>'.$fields["taplalkozasi_forma"].' ('.$fields["tud_elnevezes"].')'.'</td>
                        </tr>'
                        .NotNull($fields["testmeret"], "Testméret")
                        .NotNull($fields["testtomeg"], "Testtömeg")
                    .'</table>
                </div>
                <div class="col-12">
                    <p class="text-justify">'.$fields["leiras"].'</p>
                </div>
            </div>
        </div>
    </div>
    ';
}