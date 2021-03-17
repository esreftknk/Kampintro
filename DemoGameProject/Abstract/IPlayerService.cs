using DemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Abstract
{
   public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
