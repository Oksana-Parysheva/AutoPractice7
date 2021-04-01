namespace AutoPractice7.CSV.Models
{
    public interface IDto<T>
    {
        T GetData(string line);
    }
}
