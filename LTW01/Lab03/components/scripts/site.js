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
    var registerPassword = document.getElementById('inputRegisterPassword');
    var registerConfirmPassword = document.getElementById('inputRegisterConfirmPassword');

    var checkPasswordMatch = function(){
        if (registerPassword.value != registerConfirmPassword.value){
            registerConfirmPassword.setCustomValidity('Password must match !');
        }
        else{
            registerConfirmPassword.setCustomValidity('');
        }
    };

    registerPassword.onchange = checkPasswordMatch;
    registerConfirmPassword.onchange = checkPasswordMatch;

}());