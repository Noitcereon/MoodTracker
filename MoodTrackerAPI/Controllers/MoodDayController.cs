using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MoodTrackerAPI.Managers;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public class MoodDayController : ControllerBase
    {
        private readonly MoodDayManager _manager = new MoodDayManager();

        [HttpGet]
        public IActionResult GetAll()
        {
            if (_manager.GetAll() == null) return NotFound();
           
            List<IDay> moodDays = new List<IDay>(_manager.GetAll());

            if (moodDays.Count <= 0)
            {
                return NoContent();
            }

            return Ok(moodDays);
        }

        [HttpPost]
        public IActionResult AddDay(Day day)
        {
            return Ok(_manager.AddDay(day));
        }
        [HttpDelete]
        public IActionResult RemoveLastEntry()
        {
            _manager.RemoveLastEntry();
            return Ok("Last entry was removed.");
        }
    }
}
