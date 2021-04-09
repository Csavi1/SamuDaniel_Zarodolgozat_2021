$(function(){
    $("#alldino").on("click", function(){
        $.post("../php/cards.php", function(result){
            // console.log(result);
            $("main > div").html(result);
        });
    });
    $("#ul-korok li a.dropdown-item").on("click", function(){
        // console.log($(this).text());
        let data = $(this).text();
        $.post("../php/cards.php", {mikorelt : data}, function(result){
            // console.log(result);
            $("main > div").html(result);
        });
    });
    $("#ul-taplalek li a.dropdown-item").on("click", function(){
        // console.log($(this).text());
        let data = $(this).text();
        $.post("../php/cards.php", {taplalkozasi_forma : data}, function(result){
            // console.log(result);
            $("main > div").html(result);
        });
    });

    
    $(document).on("click", ".card .btn", function(){
        // alert("Clicked!");
        let data = $(this).siblings(".card-title").text();
        // console.log(data);
        $.post("../php/modal.php", {title : data}, function(result){
            // alert("Success!");
            $(".modal-content").html(result);
        });
    });
});