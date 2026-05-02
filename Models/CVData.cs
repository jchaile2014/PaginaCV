namespace MiPaginaCV.Models;

public class Skill
{
    public string Name { get; set; } = "";
    public string IconClass { get; set; } = "";
    public string Color { get; set; } = "#6c63ff";
}

public class SkillCategory
{
    public string Category { get; set; } = "";
    public List<Skill> Skills { get; set; } = new();
}

public class Project
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string GitHubUrl { get; set; } = "";
    public string[] Technologies { get; set; } = [];
    public string Icon { get; set; } = "fa-code";
}

public class Course
{
    public string Name { get; set; } = "";
    public string Platform { get; set; } = "";
    public string Icon { get; set; } = "fa-graduation-cap";
    public string? CertificateUrl { get; set; }
    public string? Date { get; set; }
    public string? Hours { get; set; }
}

public class CVData
{
    public string Name { get; set; } = "Jorge Ariel Chaile";
    public string Title { get; set; } = "Desarrollador C# .NET";
    public string Subtitle { get; set; } = "Estudiante Técnico en Programación · UTN";
    public string Email { get; set; } = "jchaile2014@gmail.com";
    public string Phone { get; set; } = "+54 3834 722027";
    public string LinkedInUrl { get; set; } = "https://www.linkedin.com/in/jorge-ariel-chaile-072294261";
    public string GitHubUrl { get; set; } = "https://github.com/jchaile2014";
    public string InstagramUrl { get; set; } = "https://www.instagram.com/jorgechaile";

    public string ProfileDescription { get; set; } =
        "Estudiante avanzado de Técnico Universitario en Programación (UTN), orientado al desarrollo con C# y .NET. " +
        "Cuento con sólidos conocimientos en programación orientada a objetos, desarrollo de interfaces de escritorio " +
        "con WinForms/WPF y manejo de bases de datos con MySQL y SQL Server. Incorporo herramientas de Inteligencia " +
        "Artificial en mi flujo de desarrollo para escribir, revisar y optimizar código de forma más eficiente. " +
        "Busco mi primera oportunidad formal en IT para aplicar y seguir desarrollando mis habilidades.";

    public List<SkillCategory> SkillCategories { get; set; } = new()
    {
        new SkillCategory
        {
            Category = "Lenguajes",
            Skills = new()
            {
                new Skill { Name = "C#",    IconClass = "devicon-csharp-plain",      Color = "#9b59b6" },
                new Skill { Name = "Java",  IconClass = "devicon-java-plain",         Color = "#e74c3c" },
                new Skill { Name = "C++",   IconClass = "devicon-cplusplus-plain",    Color = "#2980b9" },
            }
        },
        new SkillCategory
        {
            Category = "Frameworks & UI",
            Skills = new()
            {
                new Skill { Name = ".NET",      IconClass = "devicon-dotnetcore-plain",      Color = "#512bd4" },
                new Skill { Name = "WinForms",  IconClass = "devicon-windows8-original",     Color = "#00adef" },
                new Skill { Name = "WPF",       IconClass = "devicon-dotnetcore-plain",      Color = "#68217a" },
            }
        },
        new SkillCategory
        {
            Category = "Bases de Datos",
            Skills = new()
            {
                new Skill { Name = "SQL Server", IconClass = "devicon-microsoftsqlserver-plain", Color = "#cc2927" },
                new Skill { Name = "MySQL",      IconClass = "devicon-mysql-plain",              Color = "#00758f" },
            }
        },
        new SkillCategory
        {
            Category = "Herramientas",
            Skills = new()
            {
                new Skill { Name = "Git",           IconClass = "devicon-git-plain",           Color = "#f34f29" },
                new Skill { Name = "GitHub",        IconClass = "devicon-github-original",     Color = "#ffffff" },
                new Skill { Name = "Visual Studio", IconClass = "devicon-visualstudio-plain",  Color = "#5c2d91" },
            }
        },
        new SkillCategory
        {
            Category = "Inteligencia Artificial",
            Skills = new()
            {
                new Skill { Name = "AI-Assisted Dev",    IconClass = "fa-solid fa-brain",         Color = "#00d4ff" },
                new Skill { Name = "Prompt Engineering", IconClass = "fa-solid fa-wand-magic-sparkles", Color = "#a78bfa" },
                new Skill { Name = "Claude (Anthropic)", IconClass = "fa-solid fa-robot",          Color = "#f59e0b" },
            }
        },
        new SkillCategory
        {
            Category = "Idiomas",
            Skills = new()
            {
                new Skill { Name = "Español (nativo)", IconClass = "fa-solid fa-language", Color = "#10b981" },
                new Skill { Name = "Inglés (básico)",  IconClass = "fa-solid fa-globe",    Color = "#3b82f6" },
            }
        },
    };

    public string University { get; set; } = "Universidad Tecnológica Nacional – UTN Regional Pacheco";
    public string Degree { get; set; } = "Técnico Universitario en Programación";
    public string DegreeStatus { get; set; } = "Cursando último año";

    public List<Course> Courses { get; set; } = new()
    {
        new Course
        {
            Name           = "C# Nivel 1 – Programación desde Cero",
            Platform       = "Maxi Programa",
            Icon           = "devicon-csharp-plain",
            Date           = "Enero 2026",
            Hours          = "60 hs",
        },
        new Course
        {
            Name           = "C# Nivel 2 – POO + .NET + SQL",
            Platform       = "Maxi Programa",
            Icon           = "devicon-csharp-plain",
            Date           = "Abril 2026",
            Hours          = "60 hs",
        },
        new Course
        {
            Name           = "Introducción a los Algoritmos",
            Platform       = "TodoCode Academy",
            Icon           = "fa-solid fa-diagram-project",
            CertificateUrl = "https://todocodeacademy.com/certificate/introduccion-a-los-algoritmos-hnn/",
        },
        new Course
        {
            Name           = "Bases de Datos Relacionales con MySQL",
            Platform       = "TodoCode Academy",
            Icon           = "devicon-mysql-plain",
            CertificateUrl = "https://todocodeacademy.com/certificate/bd-relacionales-con-mysql-3cs/",
        },
        new Course
        {
            Name           = "Git y GitHub",
            Platform       = "TodoCode Academy",
            Icon           = "devicon-git-plain",
            CertificateUrl = "https://todocodeacademy.com/certificate/git-y-github-0ou/",
        },
        new Course
        {
            Name           = "Java para Principiantes",
            Platform       = "TodoCode Academy",
            Icon           = "devicon-java-plain",
            CertificateUrl = "https://todocodeacademy.com/certificate/java-para-principiantes-bpu/",
        },
        new Course
        {
            Name           = "Programación Orientada a Objetos con C#",
            Platform       = "UTN – Formación académica",
            Icon           = "devicon-dotnetcore-plain",
        },
    };

    public List<Project> Projects { get; set; } = new()
    {
        new Project
        {
            Name        = "Sistema de Gestión de Artículos",
            Description = "Aplicación WinForms en C# con arquitectura en 3 capas (Presentación, Negocio, Dominio) " +
                          "y base de datos SQL Server. Trabajo práctico grupal en el marco de UTN.",
            GitHubUrl   = "https://github.com/jchaile2014/tp-winform-equipo-22C",
            Technologies = ["C#", ".NET", "WinForms", "SQL Server", "ADO.NET"],
            Icon        = "fa-database"
        },
        new Project
        {
            Name        = "Calculadora de Consola con Historial",
            Description = "Aplicación de consola en C# / .NET 10 con operaciones matemáticas, " +
                          "validación de entradas y persistencia del historial con timestamp en archivo de texto.",
            GitHubUrl   = "https://github.com/jchaile2014/Calculadora_Basica",
            Technologies = ["C#", ".NET 10", "Consola", "File I/O"],
            Icon        = "fa-calculator"
        },
    };

    public List<string> PersonalSkills { get; set; } = new()
    {
        "Trabajo en equipo y colaboración",
        "Organización y gestión del tiempo",
        "Autonomía y toma de decisiones",
        "Aprendizaje continuo y adaptabilidad",
        "Integración de IA en el flujo de trabajo",
    };
}
