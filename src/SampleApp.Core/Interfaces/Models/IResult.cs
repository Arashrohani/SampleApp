namespace SampleApp.Core.Interfaces.Models
{
    public interface IResult : IBaseResult
    {
        IResult ReturnError(string message = "");
        IResult ReturnSuccess(string message = "", int id = -1);
    }

    public interface IResult<T> : IBaseResult
    {
        T Model { get; set; }
        T GetModel();
        IResult<T> ReturnError(string message = "");
        IResult ReturnErrorNoModel(string message = "");
        IResult<T> ReturnSuccess(string message = "");
        IResult ReturnSuccessNoModel(string message = "");
    }
}
