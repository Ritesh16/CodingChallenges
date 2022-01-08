using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignBrowserHistory
{
    public class BrowserHistory
    {

        Stack<string> forward;
        Stack<string> history;
        public BrowserHistory(string homepage)
        {
            history = new Stack<string>();
            forward = new Stack<string>();
            history.Push(homepage);
        }

        public void Visit(string url)
        {
            history.Push(url);
            forward.Clear();
        }

        public string Back(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (history.Count <= 1) break;

                forward.Push(history.Peek());
                history.Pop();
            }

            return history.Peek();
        }

        public string Forward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (forward.Count == 0) break;

                history.Push(forward.Peek());
                forward.Pop();
            }

            return history.Peek();
        }
    }

}
