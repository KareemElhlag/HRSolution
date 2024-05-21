namespace HR.IBaseInterFace
{
    public interface IBase1<TEntity>
    {
        void Add(TEntity? entity);
        void Delete(int? Id);
        TEntity Find(int? Id);
        IList<TEntity> List();
        void Update(int id, TEntity model);
        List<TEntity> Search(String trem);

    }
}
