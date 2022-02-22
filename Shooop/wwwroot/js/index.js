const navMenu = document.getElementById('nav-menu')
const navToggle = document.getElementById('nav-toggle')

function showMenu(){
    navMenu.classList.toggle('show')
}



navToggle.addEventListener('click', showMenu)