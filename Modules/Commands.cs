using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Kore4nBot.Modules
{
    // example command
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("jason")]
        public async Task Ping()
        {
            Random numberGenerator = new Random();
            int number = numberGenerator.Next(1, 3);
            if (number == 1) await ReplyAsync("alex is better than jason :(");
            else await ReplyAsync("jason is better than alex :D");
        }

        [Command("zak")]
        public async Task Zak()
        {
            await ReplyAsync("say nothing if gay");
        }

        [Command("vanxi")]
        public async Task Vanxi()
        {
            Random numberGenerator = new Random();
            int number = numberGenerator.Next(1, 3);
            if (number == 1) await ReplyAsync("https://steamuserimages-a.akamaihd.net/ugc/1009313988386078377/65316DB4E5251428CE65776669ACBE265D15E4F5/");
            else await ReplyAsync("https://drive.google.com/open?id=1OIbpRmVKT1yg_77QTRAA-vfVwC5yja_V");
        }

        [Command("5unny")]
        public async Task Sunny()
        {
            Random numberGenerator = new Random();
            int number = numberGenerator.Next(1, 5);
            if (number == 1) await ReplyAsync("https://cdn.discordapp.com/attachments/450439249729290253/709545092515495936/unknown.png");
            else if (number == 2) await ReplyAsync("https://cdn.discordapp.com/attachments/450439249729290253/709545150392565850/unknown.png");
            else if (number == 3) await ReplyAsync("https://cdn.discordapp.com/attachments/450439249729290253/709545187709419520/unknown.png");
            else await ReplyAsync("https://cdn.discordapp.com/attachments/450439249729290253/709545290713137232/unknown.png");
        }

        [Command("nursey")]
        public async Task Nursey()
        {
            await ReplyAsync("[REDACTED]");
        }

        [Command("leo 1")]
        public async Task Leo1()
        {
            var embed = new EmbedBuilder
            {
                Title = ("GUNSHOT BRIDE"),
                Url = ("https://www.youtube.com/watch?v=0lpozdSxqOw"),
            }.Build();

            await ReplyAsync(embed: embed);
        }

        [Command("leo 2")]
        public async Task Leo2()
        {
            var embed = new EmbedBuilder
            {
                Title = ("I WANT THE HATCH"),
                Url = ("https://drive.google.com/open?id=1SnyiB69W3L80ZI_DH-Q4deikm6L5bP0K"),
            }.Build();

            await ReplyAsync(embed: embed);
        }

        [Command("alex 1")]
        public async Task Alex1()
        {
            var embed = new EmbedBuilder
            {
                Title = ("ALEXS FRAGS"),
                Url = ("https://medal.tv/clips/23505637/JzjPcqfJuBNT"),
            }.Build();

            await ReplyAsync(embed: embed);
        }

        [Command("alex 2")]
        public async Task Alex2()
        {
            await ReplyAsync("https://www.faceit.com/en/tf2/room/c018b835-5499-4103-8010-63b9a739997b/scoreboard");
        }

        [Command("alex 3")]
        public async Task Alex3()
        {
            for (int i = 0; i < 30; i++)
            {
                await ReplyAsync("<@268108437844525056>");
            }
        }

        [Command("votejason")]
        public async Task VoteJason()
        {
            await ReplyAsync("/vote <@219516149736538113>");
        }

        [Command("vgayv")]
        public async Task VGayV()
        {
            await ReplyAsync("v gay v");
        }

        [Command("corona")]
        public async Task Corona()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=4f6-MDhygWc");
        }
    }
}
