namespace _01_CarAnalysisQuery.Contracts.Car
{
    public interface ICarQuery
    {
        CarQueryModel GetCarDetails(int id);
        CarQueryModel GetCar(int id);

    }
}
