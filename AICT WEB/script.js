function selectMenuItem(sectionId) {
    // Remove 'selected' class from all menu items
    var menuItems = document.querySelectorAll('#Menu-container ul li');
    menuItems.forEach(function (item) {
        item.classList.remove('selected');
    });

    // Add 'selected' class to the clicked menu item
    var selectedMenuItem = document.querySelector('#Menu-container ul li[data-section="' + sectionId + '"]');
    if (selectedMenuItem) {
        selectedMenuItem.classList.add('selected');
    }

    // Scroll to the corresponding section
    var section = document.getElementById(sectionId);
    if (section) {
        section.scrollIntoView({ behavior: 'smooth' });
    }
}
