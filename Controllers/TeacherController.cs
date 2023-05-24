using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class TeacherController : ControllerBase
{
private TeachersService _teacherService;
public TeacherController()
{
    _teacherService = new TeachersService();
}

[HttpGet("teachers")]
public List<teachersDTO> GetTeachers()
{
    return _teacherService.GetTeachers(null,null);
}

[HttpPost("AddTeachers")]
public teachersDTO AddTeachers(teachersDTO teachers)
{
    return _teacherService.AddTeacher(teachers);
}

}