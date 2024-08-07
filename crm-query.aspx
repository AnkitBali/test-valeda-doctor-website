﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="crm-query.aspx.cs" Inherits="crmQuery" %>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="icon" href="images/favicon.png" type="image/x-icon" />
    <link rel="shortcut icon" type="image/x-icon" href="images/favicon.png" />
    <title>Valeda</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/fontawesome/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/flaticon.min.css">
    <link rel="stylesheet" type="text/css" href="css/animate.min.css">
    <link rel="stylesheet" type="text/css" href="css/owl.carousel.min.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap-select.min.css">
    <link rel="stylesheet" type="text/css" href="css/magnific-popup.min.css">
    <link rel="stylesheet" type="text/css" href="css/loader.min.css">    
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" class="skin" type="text/css" href="css/skin/skin-1.css">
    <link rel="stylesheet" type="text/css" href="css/custom.css">  
    <link rel="stylesheet" type="text/css" href="plugins/revolution/revolution/css/settings.css">
    <link rel="stylesheet" type="text/css" href="plugins/revolution/revolution/css/navigation.css">
      </head>
 <body id="bg">
 
	<div class="page-wraper"> 
       	
        <!-- HEADER START -->
        <header class="site-header header-style-1 ">
        
            <div class="top-bar">
                <div class="container">
                    <div class="row">
                    	<div class="wt-topbar-left clearfix">
                        	<ul class="list-unstyled e-p-bx pull-right">
                                <li> <a href="index.html">Home </a></li>
                                <li><strong> |</strong></li>
                                <li> <a href="about-us.html">About Us </a></li>
                                 <li><strong> |</strong></li>
                                <li> <a href="contact-us.html">Contact Us </a></li>
                                <li><strong> |</strong></li>
                                <li> <a href="download.html">Downloads </a></li>
                                 <li><strong> |</strong></li>
                                <li> <a href="https://www.valeda.in/" target="_blank">Valeda Products </a></li>
                            </ul>
                        </div>
                        <div class="wt-topbar-right clearfix">
                            <ul class="social-bx list-inline pull-right">
                                <li><a href="https://www.facebook.com/Valeda-The-World-of-Holistic-Wellness-103082664629129/?ref=pages_you_manage" target="_blank" class="fa fa-facebook"></a></li>
                                <li><a href="https://twitter.com/valedaclinic" target="_blank" class="fa fa-twitter"></a></li>
                                <li><a href="https://www.linkedin.com/groups/13542943" target="_blank" class="fa fa-linkedin"></a></li>
                                <li class="dropdown">
                                    <a href="https://www.youtube.com/channel/UCkJ2dy7qWrXKxbGBi4g-mHw" target="_blank" class="fa fa-youtube dropdown-toggle" onclick="toggleDropdown(event)"></a>
                                    
                                    <ul class="dropdown-menu">
                                        <li><a href="https://www.youtube.com/@valedaacnesolutions" target="_blank" class="fa fa-youtube"><text class="abc"> Acne Solutions </text></a></li>
                                        <li><a href="https://www.youtube.com/@valedaHairfall" target="_blank" class="fa fa-youtube"><text class="abc"> Hair fall </text> </a></li>
                                        <li><a href="https://www.youtube.com/@Electrolysisblendvaleda" target="_blank" class="fa fa-youtube"><text class="abc"> Electrolysis </text></a></li>
                                        <li><a href="https://www.youtube.com/@valedaskinallergy" target="_blank" class="fa fa-youtube"> <text class="abc"> Skin Allergy </text> </a></li>
                                        <li><a href="https://www.youtube.com/@valedaWhitepatches" target="_blank" class="fa fa-youtube"><text class="abc"> White Patches </text></a></li>

                                    </ul>
                                
                                </li>
                                <li><a href="https://www.instagram.com/valeda_world/" target="_blank" class="fa fa-instagram"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Search Link -->

<!-- Search Form -->

            <div class="sticky-header main-bar-wraper">
                <div class="main-bar bg-white">
                    <div class="container">
                        <div class="logo-header">
                            <a href="index.html">
                                <img src="images/logo4.jpg" width="216"  alt="Valeda" />
                            </a>
                        </div>
                        <!-- NAV Toggle Button -->
                        
                        <a href="https://valedalife.in/login.aspx" class="hidden-lg" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Login</button></a> 
                        <a href="https://crm.valedalife.in/" class="hidden-lg" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Patient Login</button></a> 
                         <a href="https://valedalife.in/UserRegistrationFree.aspx" class="hidden-lg" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Signup</button></a> 
                            
                        
                        <button data-target=".header-nav" data-toggle="collapse" type="button" class="navbar-toggle collapsed">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                       
                         <div class="header-nav navbar-collapse collapse ">
                            <ul class=" nav navbar-nav">
                               
                                
                                
                                <li class="has-mega-menu ">
                                    <a href="skin-diseases.html">Skin Diseases<i class="fa fa-chevron-down"></i></a>
                                    <ul class="mega-menu">
                                        <li>
                                           <ul>
                                <li><a href="acne_pimples.html"> <i class="fa fa-angle-double-right"></i> Acne/Pimples</a></li>
                                <li><a href="Psoriasis.html"> <i class="fa fa-angle-double-right"></i>Psoriasis</a></li>
                                <li><a href="skin_allergy.html"> <i class="fa fa-angle-double-right"></i>Skin Allergy</a></li>
                                <li><a href="age_miracle.html"> <i class="fa fa-angle-double-right"></i>Age Miracle/ Anti Wrinkle</a></li>
                                <li><a href="birth_marks.html"> <i class="fa fa-angle-double-right"></i>Birth Marks</a></li>
                                <li><a href="blemishes.html"> <i class="fa fa-angle-double-right"></i>Blemishes & Pigmentation</a></li>
                                            </ul>
                                        </li>
                                        
                                          <li>
                                            <ul>
                                <li><a href="corn.html">  <i class="fa fa-angle-double-right"></i> Corn</a></li>
                                <li><a href="eczema.html"> <i class="fa fa-angle-double-right"></i> Eczema or Dermatitis</a></li>
                                <li><a href="folliculitis.html"> <i class="fa fa-angle-double-right"></i> Folliculitis</a></li>
                                <li><a href="freckles.html"> <i class="fa fa-angle-double-right"></i> Freckles & Cholasma</a></li>
                                <li><a href="fungal.html"> <i class="fa fa-angle-double-right"></i> Fungal Infection</a></li>
                                <li><a href="leucoderma.html"> <i class="fa fa-angle-double-right"></i> Leucoderma</a></li>
                                                                         </ul>
                                        </li>
                            
                                        <li>
                                        <ul>
                                <li><a href="lichen.html"> <i class="fa fa-angle-double-right"></i> Lichen Planus</a></li>
                                <li><a href="lipoma.html"> <i class="fa fa-angle-double-right"></i> Lipoma</a></li>
                                <li><a href="moles.html"> <i class="fa fa-angle-double-right"></i> Moles</a></li>
                                <li><a href="pityriasis.html"> <i class="fa fa-angle-double-right"></i> Pityriasis Alba</a></li>
                                <li><a href="post_acne.html"> <i class="fa fa-angle-double-right"></i> Post Acne Scars</a></li>
                                <li><a href="skintags.html"> <i class="fa fa-angle-double-right"></i> Skin Tags</a></li>
                                                </ul>
                                        </li>
                                        
                                        <li>
                                        <ul>
                                <li><a href="skin_whitening.html"> <i class="fa fa-angle-double-right"></i>Skin Whitening</a></li>
                                <li><a href="stretch_marks.html"> <i class="fa fa-angle-double-right"></i>Stretch Marks</a></li>
                                <li><a href="sunburn.html"> <i class="fa fa-angle-double-right"></i>Sun Burn & Tanning</a></li>
                                <li><a href="under_eyecircles.html"> <i class="fa fa-angle-double-right"></i>Undereye Circle</a></li>
                                <li><a href="warts.html"> <i class="fa fa-angle-double-right"></i>Warts</a></li>
                                           </ul>
                                        </li>
                                    </ul>
                                </li>
                                
                                
                                <li>
                                    <a href="hair-diseases.html"> Hair Diseases<i class="fa fa-chevron-down"></i></a>
                                    <ul class="sub-menu">
                                        <li><a href="men_hairloss.html">Men's Hair Loss</a></li>
                                        <li><a href="dandruff.html">Dandruff</a></li>
                                        <li><a href="grey_hair.html">Grey Hair</a></li>
                                        <li><a href="damaged_hair.html">Damaged Hair</a></li>
                                        <li><a href="hair_thin.html">Hair Loss & Thinning</a></li>
                                        <li><a href="alopecia.html">Alopecia</a></li>
                                    </ul>
                                </li>
                                
                                <li >
                                    <a href="procedures.html"> Procedures<i class="fa fa-chevron-down"></i></a>
                                    <ul class="sub-menu">                                        <li><a href="ayur.html">Shirodhara/Ayurvedic Procedures</a></li>
                                        <li><a href="acupuncture.html">Acupuncture</a></li>
                                        <li><a href="firming.html">Breast Firming</a></li>
                                        <li><a href="height.html">Height Gain</a></li>
                                        <li><a href="weight.html">Weight Management</a></li>
</ul>
                                </li>
                                
                                <li >
                                    <a href="phr.html">Permanent Hair Removal<i class="fa fa-chevron-down"></i></a>
<ul class="sub-menu">
                                        <li><a href="lphr.html">Laser Permanent Hair Reduction</a></li>
                                        <li><a href="hphr.html">Holistic Combination Modes</a></li>
                                       <li><a href="electrolysis.html">Electrolysis</a></li>
                                        
                                        
                                    </ul>
                                 </li>
                                
                                 
                                                             
                                <li style="text-align:center" class="hidden-xs"><a href="https://valedalife.in/login.aspx" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Login</button></a> </li>
                                 <li style="text-align:center" class="hidden-xs"><a href="https://crm.valedalife.in/" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Patient Login</button></a> </li>
                                 <li style="text-align:center" class="hidden-xs"><a href="https://valedalife.in/UserRegistrationFree.aspx" target="_blank" style="padding:0px !important;"><button class="header-button graphical pink m-r10" type="button">Signup</button></a> </li>
                            </ul>
                            
                        </div>
                    </div>
                </div>
            </div>
            
        </header>
            
        <!-- CONTENT START -->
        <div class="page-content">
             <!-- INNER PAGE BANNER -->
           <div class="section-full">
                    <div class="container">
                        <div class="row">
                           <div class="section-head text-center" style="margin-bottom:10px;">
                                    <h2 style="color:#8CC540; margin-bottom:0px; font-size:55px; font-weight:bolder;"> </h2>
                                    
                           </div>
                           
                         </div>
                    </div>
                </div>
            <!-- INNER PAGE BANNER END --> 
                   <!-- SECTION CONTENT START -->                  
           <div class=" section-full">
             <div class="container woo-entry">
                <iframe src="https://crm.valedalife.in/crmQuery.aspx" frameborder="0" width="100%" height="801px"></iframe>
                
                    </div>       
                     </div>                                        
               
                    
        </div>
        <!-- CONTENT END -->
        
      <!-- FOOTER START -->
        <footer class="site-footer footer-light ">
            <!-- COLL-TO ACTION START -->
                     
                
           
            <!-- FOOTER BLOCKES START -->  
            <div class="footer-top overlay-wraper">
                <div class="overlay-main"></div>
                <div class="container">
                    <div class="row"> <!-- ABOUT COMPANY -->
                        <div class="col-md-4 col-sm-6">  
                            <div class="widget widget_about">
                                <h4 class="widget-title"></h4>
                                <div class="logo-footer clearfix p-b15">
                                    <a href="index.html"><img src="images/footerlogo.png"  alt="What is the dandruff treatment duration?"/></a>
                                </div>
                                <p style=" font-size:14px"></p>  
                            </div>
                        </div> 
                        <!-- RESENT POST -->
                             
                       
                        <div class="col-md-4 col-sm-6">
                            <div class="widget widget_newsletter">
                                <h4 class="widget-title">Newsletter</h4>
                                <div class="newsletter-bx">
                                    <form role="search" method="post">
                                        <div class="input-group">
                                        <input name="news-letter" class="form-control" placeholder="ENTER YOUR EMAIL" type="text">
                                        <span class="input-group-btn">
                                            <button type="submit" class="site-button"><i class="fa fa-paper-plane-o"></i></button>
                                        </span>

                                    </div>
                                     </form>
                                </div>
                            </div>
                            <!-- SOCIAL LINKS -->
                            <div class="widget widget_social_inks"><h4 class="widget-title"></h4>
                            <div class="row"> <div class="col-lg-6 col-xs-6" style="margin-top: 25px;">  <a href="crm-query.aspx"> <button class="btn btn-primary" type="button" style="border-radius:15px 0px 15px 0px;
box-shadow:0px 5px 10px #000;"><strong style=" font-size:15px; text-shadow: 5px 5px 7px #000;">For Telephonic Consultation<br> with Specialist Doctors<br> Please Pay <strong>Rs. 800/-</strong> <br>and Submit this Form</strong></button></a>
</div> <div class="col-lg-6 col-xs-6 " align="right">
<img src="images/qr.jpg" class="img-responsive img-thumbnail" width="151" >
</div></div>
                            </div>
                            
                            
                        </div>
                          <div class="col-md-4 col-sm-6">
                            <div class="widget widget_services">
                                <h4 class="widget-title">Contact Us!</h4>
                               
                                <div class="icon-content">
                                   
                                   <div class="col-lg-4 m-t10"> <p style="color:#5B3F4A"><i class="fa fa-home "></i> <strong> Address:</strong></p></div>
                                   <div class="col-lg-8  m-b15">
                                   <p><span style="color:#000"><strong> Valeda Skin and Hair Clinic,</strong><br>7H, Gopala Tower, Rajendra<br> Place, New Delhi-110008<br> <strong>Nearest Metro:</strong>  Rajendra Place</span></p></div>
                                    <div class="col-lg-4 m-t10">
                                   <p style="color:#5B3F4A"><i class="fa fa-phone "></i> <strong> Phone: </strong></p>
                                   </div>
                                    <div class="col-lg-8  m-b15">
                                   <p><span style="color:#000"> 
                                   <strong>Whatsapp No:</strong> 9313233341  <br>
                                  <strong> Phone No.:</strong> 011 40244119 </span></p></div> <div class="col-lg-4 m-t0">
                                   <p style="color:#5B3F4A"><i class="fa fa-envelope "></i> <strong> Email-Id:</strong></p>
                                   </div>
                                   <div class="col-lg-8">
                                   <span style="color:#000">
                                     doctor@valedalife.com</span></p></div>
                                </div>
                            </div>
                        </div>
                        
                    </div>
                   
                </div>
            </div>
        
            <!-- FOOTER COPYRIGHT -->
            <div class="footer-bottom overlay-wraper">
               <div class="container">
                    <div class="row">
                        <div class="wt-footer-bot-left">
                            <span class="copyrights-text">Copyright © Valeda Herbal Private Limited | All Rights Reserved.</span>
                        </div>
                        <div class="wt-footer-bot-right">
                            <ul class="copyrights-nav pull-right"> 
                                <li><a href="javascript:void(0);">Terms  & Condition</a></li>
                                <li><a href="javascript:void(0);">Privacy Policy</a></li>
                                 </ul>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!-- FOOTER END -->

        
      <!-- BUTTON TOP START -->
        <button class="scroltop"><span class=" iconmoon-house relative" id="btn-vibrate"></span>Top</button>

        
<!-- JAVASCRIPT  FILES ========================================= --> 
<script   src="js/jquery-1.12.4.min.js"></script><!-- JQUERY.MIN JS -->
<script   src="js/bootstrap.min.js"></script><!-- BOOTSTRAP.MIN JS -->

<script   src="js/bootstrap-select.min.js"></script><!-- FORM JS -->
<script   src="js/jquery.bootstrap-touchspin.min.js"></script><!-- FORM JS -->

<script   src="js/magnific-popup.min.js"></script><!-- MAGNIFIC-POPUP JS -->

<script   src="js/waypoints.min.js"></script><!-- WAYPOINTS JS -->
<script   src="js/counterup.min.js"></script><!-- COUNTERUP JS -->
<script   src="js/waypoints-sticky.min.js"></script><!-- COUNTERUP JS -->

<script  src="js/isotope.pkgd.min.js"></script><!-- MASONRY  -->

<script   src="js/owl.carousel.min.js"></script><!-- OWL  SLIDER  -->

<script   src="js/stellar.min.js"></script><!-- PARALLAX BG IMAGE   --> 
<script   src="js/scrolla.min.js"></script><!-- ON SCROLL CONTENT ANIMTE   --> 

<script   src="js/custom.js"></script><!-- CUSTOM FUCTIONS  -->
<script   src="js/shortcode.js"></script><!-- SHORTCODE FUCTIONS  -->
<script src="js/dropdown.js"></script> <!-- HEADER DROPDOWN FUCTIONS  -->

<script>
  window.va = window.va || function () { (window.vaq = window.vaq || []).push(arguments); };
</script>
<script defer src="/_vercel/insights/script.js"></script>

<script>
  window.si = window.si || function () { (window.siq = window.siq || []).push(arguments); };
</script>
<script defer src="/_vercel/speed-insights/script.js"></script>

</body>
</html>