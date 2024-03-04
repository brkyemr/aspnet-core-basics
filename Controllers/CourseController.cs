using Microsoft.AspNetCore.Mvc;
using basics.Models;


namespace basics.Controllers; 

public class CourseController: Controller{
    public IActionResult Index(){
        var kurs = new Course();
        kurs.Id = 11111;
        kurs.Title = "DOTNET CORE DERS1";
        kurs.Description = "Hizmet edecek ders";
        return View(kurs);
    }
    public IActionResult List(){

        var kurslar = new List<Course>(){
        new Course(){ Id = 1, Title = "Asp1 ders",Description = "Bismihisubhanehu",Image = "12.jpg"},
        new Course(){ Id = 2, Title = "Asp2 ders",Description = "Bismillah her hayrın başıdır.",Image = "13.jpg"},
        new Course(){ Id = 3, Title = "Asp3 ders",Description = "Biz dahi başta ona başlarız.",Image = "14.jpg"}
        };
        return View(kurslar);
    }
    public IActionResult ListViewq(){
        return View();
    }
        public IActionResult ListView(){
        return View("Background");
    }
    
}