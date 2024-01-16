namespace DirectoryExplorer
{
    public interface IDirectoryRepository
    {
        public bool UserWantsToContinue();

        public void InputDirectoryPath();
        public bool DirectoryIsValid(string path);
        public void ValidateCommand();
        public void ShowDirectoryFiles();

    }
}