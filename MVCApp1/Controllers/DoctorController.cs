using Microsoft.AspNetCore.Mvc;
using MVCApp1.Models;
using System.Diagnostics;

namespace MVCApp1.Controllers
{
	public class DoctorController : Controller
	{
		public static List<Doctor> doctors = new List<Doctor>();
		public IActionResult Index()
		{
			//doctors.Add(new Doctor() { Id = 1, Name = "ABCD", Qualification = "MBBS" });
			//doctors.Add(new Doctor() { Id = 2, Name = "XYZ", Qualification = "MCA" });
			//doctors.Add(new Doctor() { Id = 3, Name = "RST", Qualification = "MSC" });
			return View(doctors);
		}
		[HttpGet]
		public IActionResult Create()
		{	
			Doctor doctor = new Doctor();
			return View(doctor);
		}
		[HttpPost]
        public IActionResult Create(Doctor doctor)
        {
			doctors.Add(doctor);
           
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
			var doctor = doctors.FirstOrDefault(doctor=>doctor.Id==id);
			doctors.Remove(doctor);

            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var doctor = doctors.FirstOrDefault(doctor => doctor.Id == id);
			doctors.Remove(doctor);
			

            return RedirectToAction("Index");
        }

    }
}