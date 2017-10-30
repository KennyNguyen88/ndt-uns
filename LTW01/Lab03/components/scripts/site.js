(function(){

    /* DEMO VALIDATION
    var password = document.getElementById('txtPassword');

    var confirmPassword = document.getElementById('txtConfirmPassword');

    var checkPasswordMatch = function(){
        if (password.value != confirmPassword.value){
            confirmPassword.setCustomValidity('Password must match !');
        }
        else{
            confirmPassword.setCustomValidity('');
        }
    };

    password.onchange = checkPasswordMatch;
    confirmPassword.onchange = checkPasswordMatch;
     */

    /* REGISTER */
    // var registerPassword = document.getElementById('inputRegisterPassword');
    // var registerConfirmPassword = document.getElementById('inputRegisterConfirmPassword');
    //
    // var checkPasswordMatch = function(){
    //     if (registerPassword.value != registerConfirmPassword.value){
    //         registerConfirmPassword.setCustomValidity('Password must match !');
    //     }
    //     else{
    //         registerConfirmPassword.setCustomValidity('');
    //     }
    // };
    //
    // registerPassword.onchange = checkPasswordMatch;
    // registerConfirmPassword.onchange = checkPasswordMatch;

    $('.sp-wrap').smoothproducts();

}());

$(document).ready(function(){
    $(".owl-carousel").owlCarousel({
        loop:true,
        margin:10,
        responsiveClass:true,
        responsive:{
            0:{
                items:1,
                dots:true,
                dotsEach:true
            },
            600:{
                items:2,
                dots:true,
                dotsEach:true
            },
            1000:{
                items:4,
                loop:false,
                dots:true,
                dotsEach:true
            }
        }
    });

    $('#inputRegisterPassword').pwstrength();
});