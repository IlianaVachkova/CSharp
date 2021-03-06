﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Executor
{
    public static class SessionData
    {
        public static string CurrentPath = Directory.GetCurrentDirectory();
        public static HashSet<Task> TaskPool = new HashSet<Task>();
    }
}