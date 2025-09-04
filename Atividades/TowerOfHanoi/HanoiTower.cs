using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class HanoiTower
    //pode ser necessario remover todos os = null!
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int> From { get; private set; } = null!;
        public Stack<int> To { get; private set; } = null!;
        public Stack<int> Auxiliary { get; private set; } = null!;
        public event EventHandler<EventArgs> MoveCompleted  = null!;
    }
}