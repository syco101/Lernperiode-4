using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeBot_9000
{
    public class Class1
    {
        public DiscordSocketClient SeBot9000;
        public CommandService Commans;
        public IServiceProvider ServiceProvider;

        public DiscordSocketClientClient BotClient { get; private set; }

        public async Task RunBot()

        {
            BotClient = new DiscordSocketClientClient();
            Botclient.LoginAsync();



        }


    }
}
