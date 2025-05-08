// Written by Swornashabi
// 2/17/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Test
{
    public enum ChestState
    {
        Locked,
        Unlocked,
        Open
    }
    public class Chest
    {
        private ChestState state;

        public ChestState GetState()
        {
            return state;
        }

        public Chest()
        {
            state = ChestState.Locked;
        }

        public void Lock()
        {
            if (state == ChestState.Locked)
            {
                state = ChestState.Locked;
            }
        }

        public void Unlock()
        {
            if (state == ChestState.Locked)
            {
                state = ChestState.Unlocked;
            }
        }

        public void Open()
        {
            if (state == ChestState.Unlocked)
            {
                state = ChestState.Open;
            }
        }

        public void Close()
        {
            if (state == ChestState.Open)
            {
                state = ChestState.Unlocked;
            }
        }
    }
}
