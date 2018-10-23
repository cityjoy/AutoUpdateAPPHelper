using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightsWarriorAutoupdater
{
    public interface IAutoUpdater
    {
        void Update();

        void RollBack();
    }
}
