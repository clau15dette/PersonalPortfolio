![Mammoth-interactive](images/mammoth.jpg)

* Start 
* Installing the template 
* CSS files 
* Changing the logo 
* Changing the header background image 
* Changing the background 
* Add/edit the carousel 
* Jquery plugins
* Adding social icons
* Credits



# CityStrap one page HTML5 template

Documentation by "Mammoth Interactive"
Created: 31 October 2013  
Latest update 17 March 2014

* v2.0 Ugrade to Bootstrap 3.1.1
* Update Jquery plugin for navigation fix in Google Chrome  

[www.mammoth-interactive.com](http://www.mammoth-interactive.com)

Thanks for purchasing this template and we hope you enjoy using it and creating something great. We'd love to see how you use this theme, so please send a link to your finished work to <info@mammoth-interactive.com>

## Installing the template
the basic structure of the HTML theme looks like the following:

	<!DOCTYPE html>
	<html lang="en">
	<head>
	<meta http-equiv="content-type" content="text/html; charset=UTF-8">
	<meta charset="utf-8">
	<title>CityStrap Theme</title>
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="description" content="">
	<meta name="author" content="">
	<!-- STYLESHEETS -->
 	</head>
	<body>
 	<!-- contents of website -->
	<!-- JAVASCRIPTS -->
	</body>
	</html>
	
	
Everything goes between the opening and closing `<body></body>` tags.

## CSS Files
The CSS theme file for CityStrap is in the folder *css > main.css*
It follows the following structure:

	/* Table of Contents
	==================================================

	#GENERAL
	#HEADER/NAVIGATION
	#MAIN
	#CAROUSEL SECTION
	#MAIN CONTENT
	#SWIPER
	#POSTS
	#SECONDRY SWIPER
	#MAIN RESPONSIVE STYLES
	#CONTACT SECTION
	#FOOTER
	#MEDIA QUERIES

	==================================================
	*/


## Changing the logo
To the change the logo go through the following steps:

1. Create your new logo at 200px x 40px with a transparent background
2. Save your logo as **logo.png**
3. Place it in the folder *CityStrap > images*

## Change the header background image
To change the background cover go through following steps:

1. Create your new background image at 1280px x 747px
2. Save it as **mainImage.jpg**
3. Place it in the folder *CityStrap > images*

##Change the background image
To the change the scrolling image, go through the following steps

1. Create a new image at 1680px x 900px and save it named **main-bg.jpg**
2. Drop it into the images folder: *CityStrap > images*

#Add/edit the sliding carousel slides
The basic html for the carousel slide looks like the below.

To add a new slide, copy and paste this snippet and edit the contents between the `<div>...</div>` tags

```
	<!-- item -->
		<div class="item">
		<!-- edit contents here -->
			<div class="container">
				<h1>Example headline.</h1>
				<div class="caption">
				<p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi 				porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
				</div>
				</div>
				<img src="images/responsiveShot.png" alt="responsiveShot" class="img-responsive" >
				<p class="btn-wrp"><a class="c2a-button">Call to action</a></p>
		<!-- stop editing here -->
			</div>
	<!-- end item -->

``` 

**also you will need to add a new indicator to the carousel as you add new slides:**

```
	<!-- Indicators -->
	<ol class="carousel-indicators">
		<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
		<li data-target="#myCarousel" data-slide-to="1"></li>
		<li data-target="#myCarousel" data-slide-to="2"></li>
	</ol>	
```    

Copy and paste the snippet below, under the last `<li>...</li>` tag to add a new indicator.

```
<li data-target="#myCarousel" data-slide-to="2"></li> 

```               

## Jquery plugins
Here is a list of all the Jquery plugins we have used:

	<script src="js/hoverIntent.js"></script>
	<script src="js/lightbox-2.6.min.js"></script>
	<script src="js/idangerous.swiper-2.1.min.js"></script>
	<script src="js/jquery.mixitup.min.js"></script>
	<script src="js/waypoints.min.js"></script>
	<script src="js/jquery.scrollTo.js"></script>
	<script src="js/jquery.nav.js"></script>

This template uses several javascript files, all of them are placed a folder called "js" and on googleapis servers. All javascript files are placed at the bottom of the page to speed up the loading time. If you want to add your google analytics code in the page, you should add it after the javascripts and before the `</body>` tag

##Adding social icons
Adding social icons of your choice is very easy. The theme uses Font Awesome icons. You can add your own with 

```
<i class="icon-twitter-sign icon-3x darkgray rm20 bm10"></i>

```
##Credits
Demo images (NOT included in the package)  
_http://www.flickr.com_  
_http://www.pixden.com_  
_http://www.unsplash.com_

**all Flickr images fall under the Creative Commons License:**  
[Creative Commons License](http://creativecommons.org/licenses/by/2.0/deed.en)

### Thanks to:

[**Jonathan Thomsen**](http://www.flickr.com/photos/jonathan_eos7d/6206510176)  
http://www.flickr.com/photos/jonathan_eos7d


[**Viktor Edholm**](http://www.flickr.com/photos/viktoredholm/8354049623/)  
http://www.flickr.com/photos/viktoredholm
 
[**Dee'lite**](http://www.flickr.com/photos/cdianne/3355461701)  
http://www.flickr.com/photos/cdianne

[**hilighters**](http://www.flickr.com/photos/hilighters/7276908608/)  
http://www.flickr.com/photos/hilighters/

[**kevin dooley**](http://www.flickr.com/photos/pagedooley/1042898105/)  
http://www.flickr.com/photos/pagedooley

[**Ron Henry**](http://www.flickr.com/photos/ronhenry/482016216/)  
http://www.flickr.com/photos/ronhenry

[**taiyofj**](http://www.flickr.com/photos/t_trace/2334158401)  
http://www.flickr.com/photos/t_trace/2334158401

[**Maciek Lulkoj**](http://www.flickr.com/photos/lulek/10324612954/)  
http://www.flickr.com/photos/lulek

[**flashcurd**](http://www.flickr.com/photos/flashcurd/8477569323/)  
http://www.flickr.com/photos/flashcurd

[**RFoto**](http://www.flickr.com/photos/frammfoto/3970995555/)  
http://www.flickr.com/photos/frammfoto

[**tommerton2010**](http://www.flickr.com/photos/58842866@N08/5388130101/)  
http://www.flickr.com/photos/58842866@N08

[**typexnick**](http://www.flickr.com/photos/ringkong/6486287611)   
http://www.flickr.com/photos/ringkong/ 

[**broma**](http://www.flickr.com/photos/pezz/1423827249/)  
http://www.flickr.com/photos/pezz

[**unsplash.com**](http://666a658c624a3c03a6b2-25cda059d975d2f318c03e90bcf17c40.r92.cf1.rackcdn.com/unsplash_5243a2eb2bc02_1.JPG)  
http://unsplash.com/

[**Portfolio imgages by Pixden**](http://www.pixeden.com/)  
http://www.pixeden.com/



