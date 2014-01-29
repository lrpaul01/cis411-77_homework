
var comm;
var mail;
function validateForm() {

console.log("TestStuff")

	mail=validateEmail();
    comm=validateComment();


    alert(mail);
    alert(comm);
}



    function validateEmail () {
		
		var email = document.getElementById('email').value;
		var atpos=email.indexOf("@");
        var dotpos=email.lastIndexOf(".");

		if(atpos<1 || dotpos<atpos+2 || dotpos+2>=email.length)
        {
           var invalid = "Please enter a valid email address."; 
            return invalid;
        }
        else{
            var valid = "Thanks for entering your email";
            return valid;
        } 
        

    }

    function validateComment () {
 	var comment = document.getElementById('comment').value;

    	if(comment =="" || comment==null) {
           var invalid  = 'Please enter a comment before submitting.'; 
            return invalid;
        }
        else{
            var valid = "Thanks for the comment!";
            return valid;
        }

    }
