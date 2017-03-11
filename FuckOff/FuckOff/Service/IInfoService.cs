namespace FuckOff
{
    public interface IInfoService
    {
        
        string PackageName { get; }
        string AppVersionName { get; }
        int AppVersionCode { get; }
        
    }
}
