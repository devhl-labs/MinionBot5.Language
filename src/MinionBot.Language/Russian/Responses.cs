namespace MinionBot.Languages.Russian
{
    public class Responses : AbstractLanguage, ILanguage
    {
        public string Name => "ru";
        public string Aliases { get; } = "русский,Russian,Rus";


        public IBot Bot { get; } = new Bot();


        public IManagementHelp ManagementHelp { get; } = new ManagementHelp();
        public IAboutHelp AboutHelp { get; } = new AboutHelp();
        public IDebugHelp DebugHelp { get; } = new DebugHelp();
        public ILeagueHelp LeagueHelp { get; } = new LeagueHelp();
        public IVillageHelp VillageHelp { get; } = new VillageHelp();
        public IPatreonHelp PatreonHelp { get; } = new PatreonHelp();
        public IWarHelp WarHelp { get; } = new WarHelp();
        public IStatsHelp StatsHelp { get; } = new StatsHelp();
        public IHelpMenu HelpMenu { get; } = new HelpMenu();


        public string ThisLeagueIsInactive
            => "Эта лига не активна или вне сезона. Если это не так, присоединитесь к серверу подержки и спросите там.";
        public string AllRolesCanBeManaged
            => "Всеми ролями можно управлять.";

        public string SomeRolesCantBeManaged
            => "Некоторыми ролями управлять нельзя.";

        public string ATimeoutOccured
            => "Вы не успели. Попробуй те еще раз.";

        public string ThisCommandIsNotForBots
            => "Эта команда не поддерживается ботом.";

        public string QuotedParametersAreTypedAsShown
            => "Цитируемые параметры набираются, как показано.";

        public string BracketedParametersAreOptional
            => "Параметры в квадратных скобках не являются обязательными.";

        public string MustBeRanInGuild
            => "Эта команда может быть выполнена только на сервере.";

        public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
            => "Эта команда не доступна для ЛВК или лиг.";

        public string MustClaimClan
            => "Сначала привяжите клан. Используйте команду `claimclan #clanTag`. If the clan is claimed in another channel in this server, go to that channel and run `defaultclan`.";

        public string NoStatsEnabled
            => "Статистика больше не учитывается. Атаки с этой войны не будут учтены для команд botleader, villageleader, и др.";

        public string NoStatsDisabled
            => "Статистика теперь будет считаться. Атаки в этой войне будут попадать в списки.";

        public string NewClanDefault(string clanTag, string clanName)
            => $"{clanTag} {clanName} теперь клан по умолчанию на этом сервере.";

        public string DefaultClanRemoved
            => "There is no longer a default clan.";

        public string ClanNotClaimed(string clanTag, string clanName)
            => $"{clanTag} {clanName} не привязан на этом сервере. Используйте команду `claimclan {clanTag}`.";

        public string ClanNotClaimed()
            => $"На этом сервере нет привязанных кланов.";

        public string NoClansToUnclaim
            => "Нет кланов доступных к отвязке.";

        public string ClanUnclaimed(string clanTag, string clanName)
            => $"Вы отвязали клан {clanTag} {clanName}.";

        public string DefaultClanUnclaimed(string clanTag, string clanName)
            => $"{ ClanUnclaimed(clanTag, clanName)} This server no longer has a default clan. You can `claimclan` or go to another channel with a clan claimed and run `defaultclan`.";

        public string ClanUnclaimedFromAllServers(string clanTag, string clanName)
            => $"Вы отвязали клан {clanTag} {clanName} со всех серверов.";

        public string RegistrantCantBeRemoved(string clanTag, string clanName)
            => $"{clanTag} {clanName} не может быть удален. Сначала надо удалить все войны с их участием, затем попробуйте снова.";

        public string ClaimClan
            => "Добавьте буквы mb в конец описаняи клана в игре.\nЖдите несколько минут, запустите команду claimclan #clanTag.\nmb нужна только для безопасности, после можно удалить.";

        public string ThisVillageIsClaimed
            => "Деревня привязана.  Попросите колидера чтобы он отвязал ее для вас.";

        public string NoVillagesClaimed
            => "У вас нет привязанных деревень. Используйте команду `claim #villageTag` для привязки деревни.";

        public string YouAlreadyHaveThisVillageClaimed
            => "Вы уже привязали эту деревню.";

        public string YouHaveClaimed(string villageTag, string villageName)
            => $"Вы привязали деревню {villageTag} {villageName}";

        public string AlreadyHasThisVillageClaimed(string userName)
            => $"{userName} уже привязал эту деревню.";

        public string InvalidTag => "Неверный тэг.";

        public string YouDontHaveAnyVillagesClaimed
            => "У вас нет привязанных деревень.";

        public string VillageNotFound()
            => "Деревня не привязана.";

        public string VillageNotFound(string tag, string clanName, string input)
            => $"Деревня не найдена в {tag} {clanName} с тэгом или именем {input}.";

        public string YourClanCouldNotBeDetermined
            => "Ваш клан не может быть определен.";

        public string YouMustBeACoLeaderToUnclaimAVillage
            => "Вы должны быть солидером или иметь права администрирования канала, чтобы отвязать деревню.";

        public string ThisVillageIsNotClaimedYet
            => "Эта деревня еще не привязана.";

        public string ThisAliasIsInUse(string clanTag, string clanName)
            => $"Этот псевдоним уже используется {clanTag} {clanName}.";

        public string YourAliasIsNow(string villageTag, string villageName, string alias)
            => $"{villageTag} {villageName} сейчас является `{alias}` псевдонимом. ВВедите команду `prefer {alias}` чтобы сделать этот псевдоним предпочтительным.";

        public string AliasNotFound(string alias, string villageTag, string villageName)
            => $"Alias `{alias}` не найден для {villageTag} {villageName}.";

        public string IsNowThePreferredAlias(string alias, string villageTag, string villageName)
            => $"{alias} теперь предпочтительный псевдоним для {villageTag} {villageName}.";

        public string AliasesMayNotContainSomeCharacters
            => "В псевдониме не должно быть символов @ или #.";

        public string ThereAreNoResults
            => "Нет результатов.";

        public string CallTimerMustBeBetween
            => "Время бронирования должно быть в пределах от 0 до 24 часов.";

        public string WarSizeMustBeDivisibleBy5AndLessThan50
            => "Размер войны должен быть кратен и не меньше 5 и не больше или равен 50.";

        public string DefenderPositionMustBeBetween1And50
            => "Позиция защищающегося должна быть от 1 до 50";

        public string StarsMustBeBetween1And3
            => "Звезды должны быть от -1 до 3.";

        public string ThereIsAlreadyACallOnThisBase
            => "Бронь этой базы уже существует, счетчик броней отключен.";

        public string ClanIsNotInWar(string clanTag, string clanName)
            => $"{clanTag} {clanName} не в войне.";

        public string ThisCommandMustBeRanInAServer
            => "Эта команда должна быть запущена на вашем сервере.";

        public string WarLogIsPrivate(string clanTag, string clanName)
            => $"Ход войны для клана {clanTag} {clanName} не общедоступен.";

        public string AnErrorOccuredLocatingYourWar(string clanTag, string clanName)
            => $"Произошла ошибка при определении войны для {clanTag} {clanName}.";

        public string MustUsePrivateWars
            => "В связи проблемами в игре в течение ЛВК вы должны использовать команду `privatewars`.";

        public string StartANewWar
            => "Используйте команду `start` для начала новой войны.";

        public string CallStackingIsDisabled
            => "Бронь на эту базу уже есть, в этом клане счетчик броней отключен.";

        public string ThisCommandIsOnlyForPrivateWars
            => "Эта команда только для приватных войн.";

        public string ThisChannelAlreadyHasAClanClaimed
            => "В этом канале уже есть привязанный клан. Используйте команду `claimclan` в другом канале или отвяжите здесь клан командой `unclaimclan`.";

        public string VillageIsNotInWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} не в этой войне.";

        public string VillageIsOutOfAttacks(string villageTag, string villageName)
            => $"{villageTag} {villageName} вне атак.";

        public string VillageIsNotInAnActiveWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} не в активной войне.";

        public string ThisCommandIsDisabledDuringCWL
            => "Эта команда не работает во время ЛВК.";

        public string YouAreNotInAnyActiveWarWar()
            => "У вас нет активных войн.";

        public string YouAreOutOfAttacks()
            => "Вы вне атак.";

        public string YouAreNotInAnyActiveWarWar(string userName)
            => $"{userName} не в активной войне.";

        public string YouAreOutOfAttacks(string cachedMemberDisplayName)
            => $"{cachedMemberDisplayName} вне атак.";

        public string NoAttacksFound
            => "Атаки не найдены.";

        public string ThisChannelMustBeInACategory
            => "Этот канал должен быть  категории.";

        public string OrgNotFound
            => "Организация не найдена.";

        public string LeagueNotFound
            => "Лига не найдена.";

        public string NoLeagueWarsFoundInLastSixDays(string leagueInitials) =>
            $"Эта лига не имеет войн последние 6 дней. Если это не так, вам нужно упомянуть представителя лиги на сервере поддержки. Если ваша война в лиге, используйте команду `requestLeague {leagueInitials}`.";

        public string SeeAWarThatIsMissing(string leagueInitials) =>
            $"```Видите, что ваша война пропущена? ?\n\nесли это ваша война используйте команду requestleague {leagueInitials}.\n\nВ любом случае вы можете обратится к представителю лиги на сервере поддержки.\n\nХотите помочь с обновлением лиги?\n\nПрисоединитесь к серверу поддержки для получения роли.```";

        public string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName)
            => $"Только член клана {clanTag} {clanName} может это видеть.";

        public string ThisWarIsAlreadyInALeague
            => "Эта война уже в лиге.";

        public string YourRequestIsPendingApproval
            => "Ваш запрос ожидает утверждения.";

        public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
            => $"Участник с именем {dbParticipantName} не найден в {leagueInitials} сезоне {season}.";

        public string NoParticipants(string leagueInitials, int season)
            => $"Нет кланов {leagueInitials} в сезоне {season}.";

        public string ThisLeagueHasNoDivisions
            => "В лиге нет дивизионов.";

        public string YouHaveClaimedXAttacks(int count, string tag, string name)
            => $"У вас есть забронированные {count} атаки на {tag} {name}.";

        public string YouAndThisBotMustHavePermissionToManageRoles
            => "Вы и бот должны иметь разрешения для управления ролями для запуска этой команды.";

        public string RolesWillNoLongerBeUpdated
            => "Роли больше не будут обновляться.";

        public string RolesWillBeUpdated(int roles)
            => $"{roles} роли будут раздаваться автоматически.";

        public string DeletedXRoles(int count)
            => $"Удаленыd {count} роли.";

        public string CreatedXRoles(int count)
            => $"Созданы {count} роли.";

        public string CreatedXRoles(string clanTag, string clanName, int count)
            => $"Созданы {count} роли для {clanTag} {clanName}.";

        public string CreatedXRoles(int count, int errors)
            => $"Созданы {count} роли. {errors} роли не могут быть созданы из-за лимита сервера или их количества.";

        public string ThisVillageHasNoBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} не забанен ни в одном клане.";
        public string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName)
            => $"{villageTag} {villageName} больше не забанен в {clanTag} {clanName}.";

        public string ThisClanHasNoBans(string clanTag, string clanName)
            => $"{clanTag} {clanName} нет банов.";

        public string ThisOrgHasNoBans
            => "В этой организации нет банов.";

        public string ThisVillageHasNoOrgBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} нигде в лигах не забанен.";

        public string PleaseTryAgainAndProvideAReasonForTheBan
            => "Попробуйте еще раз и укажите причину бана.";

        public string ClanDescriptionMustEndWithMB
            => "Для привязки клана в конце описания клана в игре пропишите `mb`. Это только для безопасности, позже можно удалить.";

        public string YourLanguageHasBeenChangedTo(string language)
            => $"Ваш язык изменен на {language}.";

        public string IDontKnowThatLanguage
            => "Я не знаю такой язык. Если хотите его добавить, пройдите на https://github.com/devhl-labs/MinionBot5.Language.";

        public string PrefixRules
            => "Префикс должен быть из 5 и менее символов и не должен включать символы # @ или пробел.";

        public string PrefixDefinition
            => "Префикс вставляется перед командами, например !, $, *, и тд. Он дает мне знать что вы говорите со мной. Для установки префикса используйте команду `setprefix !`. ! может быть другим знаком.";

        public string UseDeletePrefixToUndoThis(string userMention, string prefix)
            => $"{userMention} Вы создали префикс. Теперь все команды должны иметь в начале `{prefix}`. Команда `deleteprefix` удалит префикс.";

        public string YouMustHavePermissionToManageGuild
            => "Вы должны иметь разрешение для управления гильдией.";

        public string ThisChannelHasNoClanClaimed
            => "В этом канале нет привязанных кланов.";

        public string InvalidTownHallLevel
            => "Вы пишите не реальный уровень ратуши.";

        public string MustBeAGoldPatron
            => "Вы должны быть золотым патроном или круче.";

        public string MustBeACrystalPatron
            => "Вы должны быть кристальным патроном или круче.";

        public string MustBeAMasterPatron
            => "Вы должны быть мастер патроном или круче.";

        public string AlreadySponsored
            => "Вы уже спонсируете этот сервер.";

        public string SponsoringServer(ulong id, string name)
            => $"Вы сопнсируете {id} {name}.";

        public string NotSponsoringAnyServers
            => "Вы не спонсируете ни один сервер.";

        public string ServerMustBeSponsored
            => "Этот сервер должен быть спонсирован для этого. Если вы патрон, то используйте команду `sponsorserver`.";

        public string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName)
            => $"Первая атака на базу на 3 звезды теперь будет обозначена {attack} и для защит {defend} для клана {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
            => $"Первая атака на базу на 3 звезды теперь будет обозначена {emoji} для клана {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
            => $"Первая защита на базу на 3 звезды будет обозначена {emoji} для клана {clanTag} {clanName}";

        public string CommandMustBeRanInACategory
            => "Эта команда должна быть запущена в категории.";

        public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
            => $"Эта команда начнет переименование всех текстовых каналов в этой категории для клана {clanTag} {clanName}.  Продолжаю?";

        public string ChannelsWillBeRenamed
            => "Текстовые каналы в этой категории будут переименованы в новой войне или при новых атаках. У меня должны быть разрешения для управления каналами.";

        public string CommandCanceled => "Команда отменена";

        public string NowRenamingChannel(string clanTag, string clanName, int position)
            => $"Теперь переименую этот канал для клана {clanTag} {clanName}, номер соперника {position}.";

        public string NeedPermissionToManageChannels
            => "У меня нет разрешения для управления каналом.";

        public string NoAttacksLeft(string enemyClanTag, string enemyClanName)
            => $"Больше нет атак в этой воне против {enemyClanTag} {enemyClanName}.";

        public string UpdatedVillages(string clanTag, string clanName, int villageCount)
            => $"Обновлены {villageCount} деревни для {clanTag} {clanName}.";

        public string Restrict
            => "Теперь я буду игнорировать все команды в этом канале. Используте `restrict false` для отмены. Рекомендую использовать роли вместо этой команды.";

        public string NotRestricted
            => "Теперь я не игнорирую этот канал.";

        public string WarChannelFailed
            => "Запуск этой команды требует спонсорства на сервере. Если вы патрон, то используйте команду sponsorserver. Так же вы должны иметь разрешение на управление каналом и категориями, в зависимости от указанных параметров. If all these conditions are met, ensure you provided the correct parameters.";

        public string BecomeAPatronToDownloadThis
            => "Надо быть патроном для получения файла для скачки! Если вы уже патрон, убедитесь что у меня есть разрешение на прикрепление файлов на этом канале.";

        public string BecomeAPatronToUseThisCommand
            => "Для использования команды надо быть патроном";

        public string IncludeTheLeagueYouWouldLikeToSee
            => "Пожалуйста, укажите лигу которую хотите видеть. Команда scoreboard покажет полный список.";

        public string WarEndWarningsDisabled
            => "Роль hashits больше не будет упоминаться, когда будет объявлено о скором окончании войны.";

        public string WarEndWarningsEnabled
            => "Роль hashits теперь будет упоминаться, когда будет объявлено о скором окончании войны..";

        public string WarStartWarningsDisabled
            => "Роль hashits больше не будет упоминаться когда война вот-вот начнется.";

        public string WarStartWarningsEnabled
            => "Роль hashits теперь будет упоминаться когда война вот-вот начнется.";

        public string IncorrectParametersOrMissingPermission
            => "У вас ошибка с параметрами или вы пропустили какой-то.";

        public string CommandNameIsAPlaceHolder
            => "Имя команды - это заполнитель. Замените его названием команды.";
        public string YouHaveHiddenXAttacks(int count)
            => $"У вас скрытые {count} атаки.";

        public string YouHaveUnhiddenXAttacks(int count)
            => $"У вас все {count} атаки видны.";

        public string CommandNotFound
            => "Команда не найдена.";

        public string ClanNotFound => "Клан не найден.";
        public string SearchForClanReturnedNoResults(string clanTag) => $"Поиск клана { clanTag } не дал результата.";
        public string NotADiscordServer => "Не discord сервер.";
        public string ServerNotFoundInCache => "Discord сервер на найден в кэше.";
        public string NotAServerMember => "Не участник сервера.";
        public string MemberNotFound => "Участник не найден.";
        public string NotAMemberNorSelfTag => "Не участник сервера или это ваш тэг.";
        public string OrganizationNotFound => "Организация не найдена.";
        public string WarNotFound => "Война не найдена.";
        public string NotADate => "Не дата.";
        public string DivisionNotFound => "Дивизион не найден.";
        public string NotAUrl => "Не верная ссылка.";
        public string ValidWarTypes => "Правильный тип войны farm, arranged, или comp.";
        public string CommandMustBeRanInYourServer => "Эта команда должна быть запущена на вашем сервере.";
        public string CommandMustBeRanInSupportServer => "Эта команда должна быть запущена на сервере поддержки.";
        public string YouMustHavePermissionToManageChannels => "У вас должно быть разрешение на управление каналом.";
        public string MbGoesInGame => "Вы не верно используете команду. \"mb\" пишется не здесь, надо написать это в описании клана в игре.";
        public string YourClanTagDoesNotEndInAPeriod => "Тэг клана не может заканчиваться точкой. Попробуйте без нее.";
        public string RoleGranted => "Роль назначена.";
        public string RoleRevoked => "Роль снята.";
    }
}