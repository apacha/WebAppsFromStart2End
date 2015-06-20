using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebAppsFromStart2End
{
    public class CoursesHub : Hub
    {
        public static void AddCourse(Course course)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<CoursesHub>();
            context.Clients.All.addCourse(course);
        }
    }
}