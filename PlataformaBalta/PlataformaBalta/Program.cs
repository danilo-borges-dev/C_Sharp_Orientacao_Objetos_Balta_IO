using PlataformaBalta;
using PlataformaBalta.ContentContex;
using static System.Console;

List<Article> articles = new List<Article>();
articles.Add(new Article("Titulo", "WWW.SISCONTROLE.COM", "Comentário"));

Course courseOOP = new("Curso de OOP", "Curso de Orientação a Objetos");
Course courseCSarp = new("Courso de C#", "Curso completo de C# Fundamentos");
Course courseAspNet = new("Curso de Asp Net", "Curso de AspNet para Web"); 

List<Course> courses = new List<Course>();
courses.Add(courseOOP);
courses.Add(courseCSarp);
courses.Add(courseAspNet);

Carrer carrer = new("Especialista .Net", "Carreira que especializa o aluno em .Net");

CarrerItem carrerItem = new(1, "Comece por aqui", "", null);
 
List<Carrer> carrerList = new List<Carrer>();

carrerList.Add(carrer);

foreach (var article in articles)
{
    WriteLine(article.Id);
    WriteLine(article.Title);
    WriteLine(article.Content);
}