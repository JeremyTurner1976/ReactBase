﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCodeGenerator.Services;

namespace DapperCodeGenerator.Abstract
{
    public abstract class AbstractCodeGenerator
    {
        protected string StartMessage { get; set; }
        protected FileHandler FileHandler { get; set; }

        protected AbstractCodeGenerator()
        {
            //TODO Config Item
            StartMessage = "//This file is generated by Dapper Code Generator" + Environment.NewLine +
                           "//Please do not write any code in this file. as it will be overwritten";

            FileHandler = new FileHandler();
        }
    }
}
