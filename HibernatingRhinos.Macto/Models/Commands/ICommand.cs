namespace HibernatingRhinos.Macto.Models.Commands
{
    public interface ICommand
    {
        bool CanExecute();
        void Execute();
    }
}