﻿
// site.js

(function () {

	//var ele = $('#username');
	//ele.text('Text Here');

	//var main = $('#main');
	//main.on('mouseenter', function () {
	//	//main.style.backgroundColor = '#888';

	//	// Not working.... moving on.
	//	main.style = 'background-color: 888;';
	//});

	//main.on('mouseleave', function () {
	//	//main.style.backgroundColor = '';
	//	main.style = '';
	//});

	//var menuItems = $('ul.menu li a');
	//menuItems.on('click', function () {
	//	var me = $(this);
		
	//	alert(me.text());
	//});

	var $sidebarAndWrapper = $('#sidebar,#wrapper');
	$('#sidebarToggle').on('click', function () {
		$sidebarAndWrapper.toggleClass('hide-sidebar');
		//if ($sidebarAndWrapper.hasClass('hide-sidebar')) {
		//	$(this).text('Show Sidebar');
		//}
		//else
		//{ $(this).text('Hide Sidebar'); }
	});
	
})();
