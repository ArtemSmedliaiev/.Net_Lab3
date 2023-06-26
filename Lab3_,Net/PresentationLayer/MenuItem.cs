using System;

namespace Lab3__Net.PresentationLayer
{
    public class MenuItem
    {
        private readonly string _title;
        private readonly Action _selectedAction;

        public MenuItem(string title, Action selectedAction)
        {
            _title = title;
            _selectedAction = selectedAction;
        }

        /*public MenuItem(string title, Action selectedAction1, Action selectedAction2)
        {
            _title = title;
            _selectedAction = selectedAction1;
            _selectedAction += selectedAction2;
        }*/

        internal void ExecuteSelectedAction()
        {
            _selectedAction.Invoke();
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
