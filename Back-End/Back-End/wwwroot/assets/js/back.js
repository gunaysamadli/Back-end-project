﻿
$(document).ready(function () {



    $(document).on("click", ".add-fav", function (e) {
        e.preventDefault();

        var id = $(this).attr("data-id");


        fetch('https://localhost:44386/product/addtofav/' + id)
            .then(response => response.text())
            .then(data => {
                $(this).removeClass('add-fav').addClass('delete');

                $("#ltn__utilize-cart-menu").html(data)
                var count = $("#favorite").data("favorite-count")
                $("#favorite-count").text(count)
                $(this).css('background', '#FF5A3C')   

            });
    });

    $(document).on("click", ".delete", function (e) {
        e.preventDefault();
        var id = $(this).attr("data-id");

        fetch('https://localhost:44386/product/deletefromfav/' + id)
            .then(response => response.text())
            .then(data => {

                $('.fav').each(function () {
                    if ($(this).attr('data-id') == id) {
                        $(this).removeClass('delete').addClass('add-fav');
                        $(this).css('background', 'none');
                    }
                })

                $("#ltn__utilize-cart-menu").html(data)
                var count = $("#favorite").data("favorite-count")
                $("#favorite-count").text(count)

            });
    })

    $(document).on("click", ".show-product-modal", function (e) {
        e.preventDefault();

        var id = $(this).attr("data-id");


        fetch('https://localhost:44386/home/getproduct/' + id)
            .then(response => response.text())
            .then(data => {


                $(".modal-product-item").html(data)
            });
        // get data from controller

        //set data 

        $("#quick_view_modal").modal("show")
    });

   
})