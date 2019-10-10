using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Controllers;
using Demo.Tasks;
using Demo.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class TasksController : DemoControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }

   
}