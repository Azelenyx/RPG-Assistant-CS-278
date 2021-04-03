using System.Windows.Input;

namespace RPG_Assistant.Database
{
    internal interface ISearchable
    {
        ICommand SearchCommand { get; }
        ICommand DefaultSortCommand { get; }

        void DefaultSort();
        void Search(string searchText);
    }
}