namespace GameMarketingProject.Business
{
    public interface IRegistryManager
    {
        void Create(IManagable managable);
        void Update(IManagable managable);
        void Delete(IManagable managable);
    }
}