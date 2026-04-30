$(document).ready(function () {
    $(document).on("click", ".quick-view-btn", function (e) {
        e.preventDefault();
        let productId = $(this).data("id");
        let url = "/Product/ProductModal?id=" + productId;
        fetch(url)
            .then((response) => response.text())
            .then((data) => {
                if ($('.product-large-slider').hasClass('slick-initialized')) {
                    $('.product-large-slider').slick('unslick');
                }
                if ($('.pro-nav').hasClass('slick-initialized')) {
                    $('.pro-nav').slick('unslick');
                }

                $("#quick_view .modal-dialog").html(data);
                $("#quick_view").modal('show');
            })
            .catch((error) => console.error('Error:', error));
    });
});