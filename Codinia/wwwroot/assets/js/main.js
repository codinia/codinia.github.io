$(function() {
    "use strict";
    $(window).on('load', function(event) { $('.preloader').delay(500).fadeOut(500); });
    $(window).on('scroll', function (event) { var scroll = $(window).scrollTop(); if (scroll < 20) { $(".header_navbar").removeClass("sticky"); } else { $(".header_navbar").addClass("sticky"); } });
    
    var scrollLink = $('.page-scroll');
    $(window).scroll(function () {
        
        var scrollbarLocation = $(this).scrollTop();
        scrollLink.each(function () {
            try {
                var sectionOffset = $(this.hash).offset().top - 73;
                if (sectionOffset <= scrollbarLocation) {
                    $(this).parent().addClass('active');
                    $(this).parent().siblings().removeClass('active');
                }
            }
            catch (err) {
            }
        });
    });
    $(".navbar-nav a").on('click', function() { $(".navbar-collapse").removeClass("show"); });
    $(".navbar-toggler").on('click', function() { $(this).toggleClass("active"); });
    $(".navbar-nav a").on('click', function() { $(".navbar-toggler").removeClass('active'); });
    $('.work_active').slick({ dots: true, arrows: false, infinite: true, speed: 800, autoplay: true, autoplaySpeed: 5000, centerMode: true, centerPadding: '360px', slidesToShow: 3, slidesToScroll: 1, responsive: [{ breakpoint: 1600, settings: { slidesToShow: 3, centerPadding: '300px', } }, { breakpoint: 1400, settings: { slidesToShow: 3, centerPadding: '140px', } }, { breakpoint: 1200, settings: { slidesToShow: 3, centerPadding: '80px', } }, { breakpoint: 992, settings: { slidesToShow: 2, centerPadding: '0', centerMode: false, } }, { breakpoint: 768, settings: { slidesToShow: 2, centerPadding: '0', centerMode: false, } }, { breakpoint: 576, settings: { slidesToShow: 1, centerPadding: '0', centerMode: false, } }] });
    $('.team_active').slick({ dots: true, arrows: false, infinite: true, speed: 800, autoplay: true, autoplaySpeed: 5000, centerMode: true, centerPadding: '0', slidesToShow: 3, slidesToScroll: 4, responsive: [{ breakpoint: 1200, settings: { slidesToShow: 3, } }, { breakpoint: 992, settings: { slidesToShow: 2, } }, { breakpoint: 768, settings: { slidesToShow: 2, } }, { breakpoint: 576, settings: { slidesToShow: 1, } }] });
    $(window).on('scroll', function(event) { if ($(this).scrollTop() > 600) { $('.back-to-top').fadeIn(200) } else { $('.back-to-top').fadeOut(200) } });
    $('.back-to-top').on('click', function(event) {
        event.preventDefault();
        $('html, body').animate({ scrollTop: 0, }, 1500);
    });
    var wow = new WOW({ boxClass: 'wow', mobile: false, })
    wow.init();
    
});