﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Entities
{
    public class GameProduct : IEntity
    {
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int GamePrice { get; set; }
    }
}
