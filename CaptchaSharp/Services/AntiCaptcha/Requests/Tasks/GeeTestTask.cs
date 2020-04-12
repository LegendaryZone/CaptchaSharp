﻿namespace CaptchaSharp.Services.AntiCaptcha.Requests.Tasks
{
    internal class GeeTestTask : AntiCaptchaTask
    {
        public string WebsiteURL { get; set; }
        public string Gt { get; set; }
        public string Challenge { get; set; }
        public string GeetestApiServerSubdomain { get; set; }

        public GeeTestTask()
        {
            Type = "GeeTestTask";
        }
    }
}
