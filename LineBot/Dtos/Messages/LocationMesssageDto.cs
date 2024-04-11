using LineBot.Enum;
namespace LineBot.Dtos
{
    public class LocationMessageDto : BaseMessageDto
    {
        public LocationMessageDto()
        {
            Type = MessageTypeEnum.Location;
        }

        public string Title { get; set; }
        public string Address { get; set; }

        public double Latitude { get; set; } // 緯度
        public double Longitude { get; set; } // 經度
    }
}