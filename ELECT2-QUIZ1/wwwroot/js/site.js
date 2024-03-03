// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function scrollToNextSection() {
    const sections = document.querySelectorAll('section'); // Get all sections
    let currentSectionIndex = 0;

    // Find index of currently visible section
    for (let i = 0; i < sections.length; i++) {
        const rect = sections[i].getBoundingClientRect();
        if (rect.top >= 0 && rect.bottom <= window.innerHeight) {
            currentSectionIndex = i;
            break;
        }
    }

    const nextSectionIndex = (currentSectionIndex + 1) % sections.length; // Wrap around
    sections[nextSectionIndex].scrollIntoView({ behavior: 'smooth' });
}

const blogSearch = document.getElementById('blogSearch');
const blogCards = document.querySelectorAll('.card');

blogSearch.addEventListener('input', () => {
    const searchTerm = blogSearch.value.toLowerCase();

    blogCards.forEach(card => {
        const title = card.querySelector('.card-title').textContent.toLowerCase();
        if (title.includes(searchTerm)) {
            card.style.display = 'block'; // Show matching blog
        } else {
            card.style.display = 'none'; // Hide non-matching blogs
        }
        // Check if any cards are visible
        const visibleCards = Array.from(blogCards).some(card => card.style.display !== 'none');

        // Show or hide message
        const noContentMessage = document.getElementById('noContentMessage');
        if (visibleCards) {
            noContentMessage.style.display = 'none';
        } else {
            noContentMessage.style.display = 'block';
        }
    });
});