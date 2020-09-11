using OOExamples.Cmd.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Models
{
    public class Counter
    {
        private int count = 0;
        private int goal = 10;
        public event EventHandler<CounterEvent> GoalReached;

        public void Add(int toAdd)
        {
            count += toAdd;
            if(count == goal)
            {
                // Fire event.
                var args = new CounterEvent();
                args.Message = "Counter has reached 10!";
                OnGoalReached(args);
            }
        }

        protected virtual void OnGoalReached(CounterEvent e)
        {
            GoalReached?.Invoke(this, e);
        }
    }
}
