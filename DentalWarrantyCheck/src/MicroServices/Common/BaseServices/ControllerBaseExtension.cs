using Core.Model.Query;
using Microsoft.AspNetCore.Mvc;

namespace BaseServices
{
    public static class ControllerBaseExtension
    {
        public async static Task<BaseResponse<T>> Run<T>(this ControllerBase controller, Func<Task<T>> method)
        {
            try
            {
                var data = await method.Invoke();
                return GenerateReponse(data);
            }
            catch (Exception ex)
            {
                return new BaseResponse<T>()
                {
                    State = ResponseState.ERROR,
                    Messsage = ex.Message
                };
            }
        }
        public static BaseResponse<T> GenerateReponse<T>(T Data)
        {
            return new BaseResponse<T>()
            {
                Data = Data,
                State = ResponseState.Ok,
                Messsage = "Success"
            };
        }
    }
}
