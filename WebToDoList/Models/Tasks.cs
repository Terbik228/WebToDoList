﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebToDoList.DataTasks
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public enum Priotity
        {
            important = 1,
            usual,
            unimportant
        }
        public Priotity priotities { get; set; }
        
    }
}