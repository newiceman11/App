// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
//Show-Hide the menu
$(document).ready(function () {
    $('#nav-icon').click(function () {
        $(this).toggleClass('open');
        $(".overlay").toggleClass("open");
        $(".overlay a").toggleClass("open");
        $(".overlay p").toggleClass("open");
    });
});
