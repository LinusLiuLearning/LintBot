using LineBot.Dtos;
using LineBot.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LineBot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LineBotController : ControllerBase
    {
        // 貼上 messaging api channel 中的 accessToken & secret
        private readonly string channelAccessToken = "dD+A2XF6iANaI8TAvoKVfxnEiWlyIKJjg2m1x0SRWaGLFo648Yd/dNyXbMBegcE4ZTFgKqolc6CUUdPseC1ybQHKEL9f9d1R40NgimhiOYivsJf2/dnfgMrdXbqMKhEgVjuXhYOA80WwJ2lEhWq4dAdB04t89/1O/w1cDnyilFU=";
        private readonly string channelSecret = "5f4eb0a7891123a3dbffa6c6b9488abc";

        // 宣告 service
        private readonly LineBotService _lineBotService;
        // constructor
        public LineBotController()
        {
            _lineBotService = new LineBotService();
        }

        [HttpPost("Webhook")]
        public IActionResult Webhook(WebhookRequestBodyDto body)
        {
            _lineBotService.ReceiveWebhook(body); // 呼叫 Service
            return Ok();
        }

        [HttpPost("SendMessage/Broadcast")]
        public IActionResult Broadcast([Required] string messageType, object body)
        {
            _lineBotService.BroadcastMessageHandler(messageType, body);
            return Ok();
        }
    }
}
