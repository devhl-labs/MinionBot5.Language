namespace MinionBot.Languages.English
{
    public class HelpMenu : IHelpMenu
    {
        public string InviteBot => "Adding the bot to your server";
        public string InviteBotDescription => 
@"Don't see your server? You don't have manage server permission.

If you do have permission, try restarting Discord.";
        public string BotNotResponding => "Bot not responding?";
        public string BotNotRespondingDescription =>
@"Ensure the bot appears in the members list in the channel you want it in.

If it's not there, add the Minion Bot role to your channel and give read permissions.

In the members list but still not responding?

Check the role in the server settings.
Give `Read Text Channels and See Voice Channels`, `Send  Messages`, `Embed Links`, `Read Message History`, `Use External Emojis`, `Add Reactions`
Still not responding?  Check the channel's category and ensure it has the required roles.

If it still is not responding, try running commands `deleteprefix` and `restrict false`.

Click the Get Help button below for more help.";

        public string IDontUnderstandTheCommands => "I don't understand the commands";
        public string IDontUnderstandTheCommandsDescription => 
"To get more information on a command, run `help commandName` where commandName is the command you want help with.";
        public string HowDoIClaimMyClan => "How do I claim my clan?";
        public string HowDoIClaimMyClanDescription =>
@"Edit your clan description so it ends with `mb`
Wait two minutes.
Run `/clans claims create #clanTag` where #clanTag is YOUR clan tag.
REMOVE `mb` from the description so no one else can claim your clan.

Does my war log have to be public?  If you want attacks posted, YES!

Can I claim multiple clans? YES! Just run `/clans claims create` in different channels.";

        public string WhatDoTheSymbolsMean => "What do the symbols mean?";
        public string HelpSettingUpMyServer => "I need help setting up my server.";
        public string HelpSettingUpMyServerDescription => "[Try this template](https://discord.new/mEgxbhkM55vW) or search YouTube for tutorials.";
        public string WhatAreTheCommands => "So what are the commands?";
        public string WhatAreTheCommandsDescription =>
@"Run `commands` to see a full list.

VIEW WAR
`▹  p       prints list of bases not 3 starred`
`▹  stats   shows stats for the current war`
`▹  gra     shows remaining attacks of our team`
`▹  gla     shows last 10 war attacks`

BASE CALLING
`▹  c 5               calls base #5 for you`
`▹  c 5 #villageTag   calls #5 base for given village`

DELETE CALL
`▹  d 5      deletes your call or the first call on base #5`
`▹  d 5 2    deletes the 2nd call on base #5`

CLAIM A VILLAGE
`▹  claim #villageTag`
`▹  claim #villageTag @discordMention`

ALIAS
`▹  alias #villageTag yourAliasHere`
`▹  prefer yourAliasHere`
`▹  deletealias yourAliasHere`
`An alias is just a nickname. Keep it simple and avoid spaces.`
`Make nicknames for common misspellings.`

`Village tags can often be replaced with an alias or @discordMention.`";

        public string InviteMe => "Invite Me";
        public string GetHelp => "Support Server";
    }
}
