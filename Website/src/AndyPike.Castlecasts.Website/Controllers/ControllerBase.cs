using AndyPike.Castlecasts.Website.Filters;
using AndyPike.Castlecasts.Website.Helpers;
using AndyPike.Castlecasts.Website.Models;
using Castle.MonoRail.ActiveRecordSupport;
using Castle.MonoRail.Framework;

namespace AndyPike.Castlecasts.Website.Controllers
{
    [Layout("Default"), Rescue("500")]
    [Helper(typeof(AntiXssHelper), "x")]
    [Helper(typeof(GravatarHelper), "gravatar")]
    [Filter(ExecuteWhen.BeforeAction, typeof(PopulatePropertyBagFilter))]
    public abstract class ControllerBase : ARSmartDispatcherController
    {
        public User CurrentUser { get; set; }
    }
}