'use strict';

jQuery(window).on('elementor/frontend/init', function () {
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_blog_listing.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 300);
            setTimeout(fix_responsive_iframe, 600);
            setTimeout(custom_video_play_button, 800);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_case_study_listing.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
            setTimeout(isotope_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_portfolio_listing.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
            setTimeout(isotope_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_projects_listing.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
            setTimeout(isotope_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_testimonial_carousel.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_image_carousel.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/technum_content_slider.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            setTimeout(elements_slider_init, 500);
        }
    });
    elementorFrontend.hooks.addAction('frontend/element_ready/section.default', function () {
        if ( jQuery('body').hasClass('elementor-editor-active') ) {
            background_image_parallax(jQuery('[data-parallax="scroll"]'), 0.7);
        }
    });
    elementorFrontend.hooks.addAction("frontend/element_ready/technum_video.default", function (e) {
        let i,o,r=e.find(".video-trigger-button"),n=e.find(".video-container"),t=e.find(".video-wrapper"),a=e.find(".close-popup-layer"),u=jQuery(t).attr("data-src");jQuery(r).on("click",function(){jQuery(n).addClass("active"),setTimeout(function(){i=jQuery(t).height(),o=i*(16/9),jQuery(t).width(o),jQuery(t).append('<iframe allowfullscreen="1" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" title="YouTube video player" width="100%" height="100%" src="'+u+'?playlist=ZdXao5XqeqM&amp;iv_load_policy=3&amp;enablejsapi=1&amp;disablekb=1&amp;autoplay=1&amp;controls=1&amp;showinfo=0&amp;rel=0&amp;loop=0&amp;wmode=transparent"></iframe>');},100),setTimeout(function(){jQuery(n).addClass("visible");},500);}),jQuery(a).on("click",function(){jQuery(n).removeClass("visible"),setTimeout(function(){jQuery(t).html(""),jQuery(n).removeClass("active");},500);}),jQuery(window).on("resize",function(){i=jQuery(t).height(),o=i*(16/9),jQuery(t).width(o);});
    });

});