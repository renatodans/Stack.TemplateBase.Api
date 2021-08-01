using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Stack.TemplateBase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class  StackController : ControllerBase
    {
        private static readonly string[] Stacks = new[]
        {
            "C#", "Visual Studio", "VSCode", "Azure", "DevOps", "React Native", "React", "JS", "Node"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Stacks.ToArray();
        }
    }
}
