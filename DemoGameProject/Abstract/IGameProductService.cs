using DemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Abstract
{
    public interface IGameProductService
    {
        void Add(GameProduct gameProduct);
        void Update(GameProduct gameProduct);
        void Delete(GameProduct gameProduct);
    }
}
