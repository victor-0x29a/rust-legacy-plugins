namespace Oxide.Plugins
{
    [Info("TutorialYoutube", "0x29a", "1.0.0", ResourceId = 924)]
    class TutorialYoutube : RustLegacyPlugin
    {
        private readonly string _permissionName = "is-god";

        void Init()
        {
            permission.RegisterPermission(_permissionName, this);
        }
        
        [ChatCommand("god")]
        void OnGodCommand(NetUser player, string commandName, string[] args)
        {
            string playerId = player.userID.ToString();
            
            if (permission.UserHasPermission(playerId, _permissionName))
            {
                player.playerClient.rootControllable.takeDamage.SetGodMode(false);
                permission.RevokeUserPermission(playerId, _permissionName);
                rust.SendChatMessage(player, "TutorialYoutube", "O modo god nao ta mais ativado.");
                return;
            }
            
            player.playerClient.rootControllable.takeDamage.SetGodMode(true);
            permission.GrantUserPermission(playerId, _permissionName, this);
            rust.SendChatMessage(player, "TutorialYoutube", "O modo god ta ativado.");
        }
    }
}