using System.Security.Cryptography.X509Certificates;

namespace DirectoryExplorer;

public class DirectoryExplorer
{
    private static IDirectoryRepository _repository;
    public DirectoryExplorer(IDirectoryRepository directoryRepository)
    {
        _repository = directoryRepository;
    }



    public static void Main()
    {
        IDirectoryRepository directoryRepository = new DirectoryRepository();
        DirectoryExplorer explorer = new DirectoryExplorer(directoryRepository);
        DirectoryRepository repository = new DirectoryRepository();
        _repository.InputDirectoryPath();



        while (_repository.UserWantsToContinue())
        {
            _repository.ValidateCommand();
            if (_repository.DirectoryIsValid(repository.directoryPath))
            {
                _repository.ShowDirectoryFiles();
                _repository.InputDirectoryPath();
            }
            else
            {
                _repository.InputDirectoryPath();
            }

        }
    }
}