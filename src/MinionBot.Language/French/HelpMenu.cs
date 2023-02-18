namespace MinionBot.Languages.French
{
    public class HelpMenu : IHelpMenu
    {
        public string InviteBot => "Adding the bot to your server";
        public string InviteBotDescription =>
@"Don't see your server? You don't have manage server permission.
Vous ne voyez pas votre serveur? Vous n'avez pas la permission de gérer le serveur.
Si vous avez la permission, essayez de redémarrer Discord.";
        public string BotNotResponding => "Le bot ne répond pas?";
        public string BotNotRespondingDescription =>
@"Soyez sûr que le bot apparaît dans la liste des membres dans le dans lequel vous voulez que le bot soit.

S'il n'est pas là, ajoutez le rôle Minion Bot à votre salon et ajoutez lui la permission de lire les messages.

In the members list but still not responding?

Check the role in the server settings.
Give `Read Text Channels and See Voice Channels`, `Send Messages`, `Embed Links`, `Read Message History`, `Use External Emojis`, `Add Reactions`
Still not responding? Check the channel's category and ensure it has the required roles.

If it still is not responding, try running commands `deleteprefix` and `restrict false`.

Click the Get Help button below for more help.";

        public string IDontUnderstandTheCommands => "I don't understand the commands";
        public string IDontUnderstandTheCommandsDescription =>
"Pour obtenir plus d'information sur une commande, utilisez `help NomDeLaCommande` où NomDeLaCommande est le nom de la commande de la part de laquelle vous voulez obtenir de l'aide.";
        public string HowDoIClaimMyClan => "How do I claim my clan?";
        public string HowDoIClaimMyClanDescription =>
@"Editez votre description de clan de façon à ce que ça se termine avec `mb`.
Attendez deux minutes.
Utilisez `/clans claims create #TagClan` où #TagClan est VOTRE tag de clan.
Supprimez `mb` de votre description de façon à ce que votre clan ne puisse être lié à nouveau par quelqu'un d'autre.


Est-ce que mon journal de guerre doit être public? Si vous voulez que les attaques soient postées, OUI!


Puis-je lier plusieurs clans? OUI! Utilisez la commande `/clans claims create` dans différents salons.";

        public string WhatDoTheSymbolsMean => "Que veut dire ce symbole ?";
        public string HelpSettingUpMyServer => "J'ai besoin d'aide pour paramétrer mon serveur.";
        public string HelpSettingUpMyServerDescription => "[Essayez ce template](https://discord.new/mEgxbhkM55vW ou recherchez des tutoriels sur YouTube.";
        public string WhatAreTheCommands => "Donc quelles sont les commandes ?"; 
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
`Un alias est juste un surnom. Gardez-le simple et évitez les espaces.`
`Make nicknames for common misspellings.`


`Les tags des villages peuvent souvent être remplacés par un alias ou une @mentionDiscord.`";
        public string InviteMe => "Aidez-moi";
        public string GetHelp => "Obtenez de l'aide";
    }
}