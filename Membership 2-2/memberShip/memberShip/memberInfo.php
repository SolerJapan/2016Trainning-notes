
<?php
	if(isset($_POST['email']))
	{
      //Edit the 2 lines ebleow as requried
	  $email_to="minervali2002@yahoo.com";
	  $email_subject="MSF Member Contact Form Info";

      function died($error)
	  {
		//your error code can go here
		echo " We are very sorry. but there were error(s) found with the form you submitted";  
		echo "There errors appear below. <br/><br/>";
		echo $error."<br/><br/>";
		echo "Please go back and fix these errors.<br/><br/>";
		die();		  
	  }

      //validation expected data exists
	  if(!isset($_POST['fname'])||
	  	 !isset($_POST['lname'])||
	     !isset($_POST['email'])||
	     !isset($_POST['phone'])||
		 !isset($_POST['message']))
		 {
		   died('We are very sorry. but there appears to be a problem with the form you submitted'); 
		 }
	//required
	$first_name=$_POST['fname'];
	$last_name=$_POST['lname'];
	$email_from=$_POST['email'];
	$phone=$_POST['phone'];
	$message=$_POST['message'];	 
	
	$email_message="Form details below.\n\n";
	
	function clean_string($string)
	{
		$bad=array("content-type","bcc:","to:","cc:","href");
		return str_replace($bad," ",$string);
		
	}
	
	$email_message.="First Name :".clean_string($first_name)."\n";
	$email_message.="Last Name :".clean_string($last_name)."\n";
	$email_message.="Email :".clean_string($email_from)."\n";
	$email_message.="Telephone :".clean_string($phone)."\n";
	$email_message.="Message :".clean_string($message)."\n";
	
	//create email headers
	$headers='From :'.$email_from."\n\n".
	'Rely-To :'.$email_from."\n\n".
	'X-Mailer : PHP'.phpversion();
	@mail($email_to,$email_subject,$email_message,$headers);
	?>
    <p>
    <h3>Thank you for contacting us! we will be in touch with you very soon.</h3>
    </p>
   <?php
	  
	}
   ?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>My Index Page</title>
<meta name="keywords" content="web design,asp.net,c sharp,sql server 2012,html5, CSS,data analysis, data report,mvc,customer services,training,project manager" />
<meta name="description" content="" />

<link href="tooplate_style.css" rel="stylesheet" type="text/css" />

<script language="javascript" type="text/javascript">
function clearText(field){

    if (field.defaultValue == field.value) field.value = '';
    else if (field.value == '') field.value = field.defaultValue;

}
</script>

</head>
<body>

<div id="tooplate_body_wrapper">
	<div id="tooplate_wrapper">
    	
        <div id="tooplate_top">
            <div id="search_box">
                <form action="#" method="get">
                    <input type="text" value="Enter keyword here..." name="q" size="10" id="searchfield" title="searchfield" onfocus="clearText(this)" onblur="clearText(this)" />
                    <input type="submit" name="Search" value="" id="searchbutton" title="Search" />
                </form>
            </div>
            <div class="cleaner"></div>
		</div> <!-- end of tooplate_top -->    
        
        <div id="tooplate_header">
            <div id="site_title">
                <h1><a href="#">Corporate Template</a></h1>
            </div>
            <div id="header_right">
                <div id="social_links">
                    <a href="#"><img src="images/mail.png" alt="Contact" /></a>
                    <a href="#"><img src="images/rss.png" alt="RSS" /></a>
                    <a href="#"><img src="images/twitter_01.png" alt="Twitter" /></a>            
                </div>
                <div id="tooplate_menu">
                    <ul>
                        <li><a href="index.html" class="current">Home</a></li>
                        <li><a href="About.aspx">About</a></li>
                        <!--<li><a href="gallery.html">Gallery</a></li>-->
                        <li><a href="Contact.aspx">Contact</a></li>
                    </ul>    	
                </div> <!-- end of tooplate_menu -->
            </div>
            <div class="cleaner"></div>
        </div> <!-- end of tooplate_header -->
        
        <div id="tooplate_main">
        	<div class="cleaner h20"></div>
            
            <div class="tooplate_sidebar float_l">
            	<div class="content_box">
                    <h3>Our Services</h3>
                    <ul class="tmo_list">
                        <li><a href="#">Lorem ipsum dolor sit amet</a></li>
                        <li><a href="#">Consectetur adipisicing elitUt enim</a></li>
                        <li><a href="#">Minim veniamquis exercit</a></li>
                        <li><a href="#">Commodo consequat</a></li>
                        <li><a href="#">Fuis aute irure dolorin repreh</a></li>
                        <li><a href="#">Excepteur sint occaecat cupida</a></li>
                        <li><a href="#">Officia deserunt mollit anim</a></li>
                    </ul>
                </div>
                <div class="content_box">                
                    <h3>Latest Projects</h3>
                    <ul class="tmo_list">
                        <li><a href="#">Nullam varius, turpis et commodo</a></li>
                        <li><a href="#">Fluctus magna felis sollici</a></li>
                        <li><a href="#">Integer in mauris eu nibh</a></li>
                        <li><a href="#">Duis ac tellus et risus vulputate</a></li>
                    </ul>
				</div>
                <div class="content_box lb">                
                    <h3>Our Location</h3>
                    200-400 Fuis aute irure, Nullam<br />
                    Lorem Ipsum 10550<br />
                	Tel: 010-020-0120<br />
                	Email: <a href="#">info@company.com</a></div>                
            	</div>
            
            <div id="tooplate_content">
            	
             <!--   <div class="content_box hr_divider">
                	<h2>Corporate Site</h2>
                	<p>Corporate is free HTML template that is fully compatible with Dreamweaver design view. So that you can easily edit this layout for your website. Please tell your friends about <a rel="nofollow" href="http://www.tooplate.com" target="_parent">Tooplate</a>.</p>
                	<p>Donec lobortis risus a elit. Etiam tempor. Ut ullamcorper, ligula eu tempor congue, eros est euismod tuid tincidunt.</p>
                    <a href="#" class="more float_r">Read More</a>
                  <div class="cleaner"></div>
                </div>-->
              <!--  <div class="content_box hr_divider">
                	<h3>New Project</h3>
                    <img src="images/icon.png" alt="Image" class="image_fl" />
                    <p>Lorem ipsum dolor sit amet, consectetur al adipisicing elit, sed do eiusmod temp ornati cididunt ut labore et dolore magna aliqua fominim veniamquis.</p>
					<a href="#" class="more float_r">Read More</a>
                    <div class="cleaner"></div>
                </div>-->
              <!--  <div class="content_box lb">
                	<h3>Our Company</h3>
                   	<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim venia quis Duis aute irure dolor.</p>
                    <a href="#" class="more float_r">Read More</a>
                    <div class="cleaner"></div>
                </div>-->
                <p><strong>Please fill out the form below and we will get back to you as soon as we can : </strong> </p>
                <!--<form id="form1" name="forma1" method="post" action="memberinfo.php">
                <table width="67%" height="186" border="0">
                	<tr>
                    	<td width="35%">First Name :</td>
                        <td width="65%">-->
                       <!-- <span id="sprytextfield1">-->
                      <!--  <label for "fname"></label>
                        <input name="fname" type="text" id="fname" size="35"/>-->
                       <!-- <span class="textfieldRequiredMsg">Please enter your first name.</span>
                        </span>-->
                     <!--   </td>
                     </tr>
                    <tr>
                    	<td width="35%">Last Name :</td>
                        <td width="65%">-->
                      <!--  <span id="sprytextfield1">-->
                     <!--   <label for "lname"></label>
                        <input name="lname" type="text" id="lname" size="35"/>-->
                       <!-- <span class="textfieldRequiredMsg">Please enter your last name.</span>
                        </span>-->
                     <!--   </td>
                     </tr>
                    <tr>
                    	<td width="35%">Email :</td>
                        <td width="65%">-->
                       <!-- <span id="sprytextfield1">-->
                      <!--  <label for "email"></label>
                        <input name="email" type="text" id="email" size="35"/>-->
                       <!-- <span class="textfieldRequiredMsg">Please enter your email address.</span>
                        </span>-->
                     <!--   </td>
                     </tr>
                     <tr>
                    	<td width="35%">Phone :</td>
                        <td width="65%">-->
                       <!-- <span id="sprytextfield1">-->
                    <!--    <label for "phone"></label>
                        <input name="phone" type="text" id="phone" size="35"/>-->
                       <!-- <span class="textfieldRequiredMsg">Please enter your phone number.</span>
                    <!--    </span>-->
                  <!--      </td>
                     </tr>
                     <tr>
                    	<td width="35%">Questions/Comments :</td>
                        <td width="65%">-->
                      <!--  <span id="sprytextfield1">-->
                       <!-- <label for "message"></label>
                        <textarea name="message" type="text" id="message" cols="40" rows="10">Please enter your questions or comments here
                        </textarea>-->
                       <!-- <span class="textfieldRequiredMsg">Please enter your questions or comments.</span>
                        </span>-->
                  <!--      </td>
                     </tr>
                     <tr>
                     <td>&nbsp;</td>
                     <td>
                     <input type="submit" name="submit" id="submit" value="Submit"/>
                     <input type="reset" name="reset" id="reset" value="Clear"/>
                     </td>                     
                     
                     </tr>
                    
                    
                </table>
                          
                </form>-->
                               
                
            	<div class="cleaner">
                               
                </div>
            </div>
            
         <!--   <div class="tooplate_sidebar float_r">
				<div class="content_box lb">
                	<h3 class="gallery_title">Our Gallery</h3>
                    <div class="box01"><span class="top"></span><span class="bottom"></span>
                    	<div class="box01_content">
                        	<div class="image_wrapper"><span></span><img alt="Image" src="images/tooplate_image_01.jpg" /></div>
                            Duis ac tellus et risus vulputate am lobortis risus a elit.
                        </div>
                        <div class="box01_content">
                        	<div class="image_wrapper"><span></span><img alt="Image" src="images/tooplate_image_02.jpg" /></div>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        </div>
                        <div class="box01_content lb">
                        	<div class="image_wrapper"><span></span><img alt="Image" src="images/tooplate_image_03.jpg" /></div>
                            Ut enim ad minim venia quis Duis aute irure dolor in reprehenderit.
                        </div>
                    </div>
                </div>
            </div>-->
            
            <div class="cleaner h20"></div>
            
            
            <div class="col_half">
                <h2>Our Expertise</h2>
                <img class="image_gallery" src="images/tooplate_image_31.jpg" alt="Image 31" />
                <p>Cras ut urna maximus, ullamcorper metus vitae, tincidunt turpis. Donec lobortis orci ante, eget posuere velit scelerisque at. In pellentesque sem luctus tincidunt varius.</p>
                <div class="cleaner"></div>
            </div>
            
            <div class="col_half rmb">
                <h2>Our Process</h2>
                <img class="image_gallery" src="images/tooplate_image_32.jpg" alt="Image 32" />
                <p>Pellentesque quis lectus sed tellus pellentesque egestas et non neque. Nullam luctus, eros sed pellentesque dictum, sem ex aliquet libero, nec viverra est ligula ornare eros. Quisque in nibh in dui.</p>
                <div class="cleaner"></div>
            </div>

        	<div class="cleaner"></div>
            
        </div>
        
        <div id="tooplate_main_bottom"></div>
        
        <div id="tooplate_bottom">
        	<div class="col_w280">
            	<h4 class="twitter">Twitter</h4>
                <p>Duis aute irure dolor in reprehes nerit in voluptate velit esse cillum dolo rsee.</p>
                <p>In risus sapien, pretium et hendrerit quis, facilisis nec massa. Quisque eros sem, consequat.</p>
                <p>Nullam luctus, eros sed pellentesque dictum, sem ex aliquet libero, nec viverra est ligula.</p>
                <a href="#" class="float_r follow_us">Follow</a>
            </div>
            <div class="col_w280">
            	<h4>Recent Work</h4>
                <img class="imger_box" src="images/tooplate_image_10.jpg" alt="Image 10" />
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
            </div>
            <div class="col_w280 rmb">
            	<h4>Company Address</h4>
                <strong>Corporate Co. Ltd.</strong><br />
                110-220 Consectetur adipisicing, <br />
                Tempor incididunt 10550<br />
                Tel: 010-020-0330<br /><br />
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elise tempor incididunt ut labore et dolore magna aliqua. Utnis ad minim veniaquis.</p>
			</div>
            <div class="cleaner"></div>
        </div>
               
    </div> <!-- end of tooplate_wrapper -->
    
    <div id="tooplate_footer_wrapper">
        <div id="tooplate_footer">
            
        Copyright © 2016 Millennium Solution Focus Web Master Team</div> <!-- end of tooplate_footer -->
    </div> <!-- end of tooplate_footer_wrapper -->
</div> <!-- end of tooplate_body_wrapper -->

</body>
</html>