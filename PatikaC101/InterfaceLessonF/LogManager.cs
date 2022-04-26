﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonF
{
    public class LogManager : Ilogger
    {
        public Ilogger _logger;
        public LogManager(Ilogger logger)
        {
            _logger = logger;
        }


        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
