namespace Castle.Test.AOP
{
    public interface IPersonLogin
    {
        void Save();
    }

    public class PersonLogin:IPersonLogin
    {
        public virtual void Save()
        {
            
        }
    }
}