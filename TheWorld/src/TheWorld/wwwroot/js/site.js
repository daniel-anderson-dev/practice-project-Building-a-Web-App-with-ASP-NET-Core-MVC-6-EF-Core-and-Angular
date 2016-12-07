
// site.js

var ele = document.getElementById('username');
ele.innerHTML = 'Text Here';

var main = document.getElementById('main');

main.onmouseenter = function () {
	//main.style.backgroundColor = '#888';
	main.style = 'background-color: #888';
};

main.onmouseleave = function () {
	//main.style.backgroundColor = '';
	main.style = '';
};