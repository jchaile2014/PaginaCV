'use strict';

// ── Typed effect for hero title ──────────────────────────────────────────────
const titles = [
    'Desarrollador C# .NET',
    'Estudiante UTN · Último año',
    'AI-Assisted Developer',
    'WinForms · SQL Server · ADO.NET',
];
let titleIndex = 0, charIndex = 0, deleting = false;
const typedEl = document.getElementById('typedTitle');

function typeLoop() {
    if (!typedEl) return;
    const current = titles[titleIndex];
    typedEl.textContent = deleting
        ? current.slice(0, charIndex--)
        : current.slice(0, charIndex++);

    if (!deleting && charIndex > current.length) {
        setTimeout(() => { deleting = true; typeLoop(); }, 2000);
        return;
    }
    if (deleting && charIndex < 0) {
        deleting = false;
        titleIndex = (titleIndex + 1) % titles.length;
    }
    setTimeout(typeLoop, deleting ? 40 : 80);
}
typeLoop();

// ── Navbar scroll effect ─────────────────────────────────────────────────────
const navbar = document.getElementById('navbar');
window.addEventListener('scroll', () => {
    navbar.classList.toggle('scrolled', window.scrollY > 30);
}, { passive: true });

// ── Mobile nav toggle ────────────────────────────────────────────────────────
const navToggle = document.getElementById('navToggle');
const navLinks  = document.querySelector('.nav-links');
navToggle?.addEventListener('click', () => {
    navLinks.classList.toggle('open');
    navToggle.querySelector('i').className =
        navLinks.classList.contains('open') ? 'fa-solid fa-xmark' : 'fa-solid fa-bars';
});
navLinks?.querySelectorAll('a').forEach(a => {
    a.addEventListener('click', () => {
        navLinks.classList.remove('open');
        navToggle.querySelector('i').className = 'fa-solid fa-bars';
    });
});

// ── Scroll-triggered fade-up ─────────────────────────────────────────────────
const observer = new IntersectionObserver(
    (entries) => entries.forEach(e => { if (e.isIntersecting) e.target.classList.add('visible'); }),
    { threshold: 0.12 }
);
document.querySelectorAll('.fade-up').forEach(el => observer.observe(el));

// ── Active nav link highlight ─────────────────────────────────────────────────
const sections = document.querySelectorAll('section[id]');
const navAnchors = document.querySelectorAll('.nav-links a');
window.addEventListener('scroll', () => {
    let current = '';
    sections.forEach(s => {
        if (window.scrollY >= s.offsetTop - 100) current = s.id;
    });
    navAnchors.forEach(a => {
        a.style.color = a.getAttribute('href') === `#${current}` ? 'var(--text)' : '';
    });
}, { passive: true });
