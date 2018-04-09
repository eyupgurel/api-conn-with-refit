using Newtonsoft.Json;


namespace Api_Connection_With_Refit.Model
{
   public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string userName { get; set; }

        public override string ToString()
        {
            return userName;
        }
    }
}