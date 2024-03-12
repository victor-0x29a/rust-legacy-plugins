# rust-legacy-plugins

[Repositório com plugins de referência](https://github.com/KichDM/RustLegacyPlugins)

[Retoolkit](https://github.com/mentebinaria/retoolkit)

## Como iniciar?

Adicione como referência todas as DLL's que contém na pasta `/rust_server_Data/Managed` a partir do diretório principal da sua oxide, tanto no VISUAL STUDIO quanto no JETBRAINS RIDER e logo após comece no `namespace` `Oxide.Plugins`...

## Ferramenta para engenharia reversa em aplicações .NET

[ILSPY](https://github.com/icsharpcode/ILSpy)

## Métodos interessantes herdados de RustLegacyPlugin

- **rust**
- **permission**
- **lang**
- **hooks**
- **cmd**
- **webrequest**
- **nestcount**
- **covalence**

## Hooks da Oxide:

- Init
- OnPluginLoaded (Plugin plugin)
- OnServerInitialized
- OnServerSave
- IOnServerShutdown
- IOnUserApprove
- OnPlayerConnected (NetUser User)
- OnPlayerDisconnected (uLink.NetworkPlayer netPlayer)
- OnPlayerSpawn (PlayerClient client)
- OnPlayerSpawned (PlayerClient client)
- IOnPlayerVoice (NetUser netUser)
- ConsolePlugins (ConsoleSystem.Arg arg)
- ConsoleLoad (ConsoleSystem.Arg arg)
- ConsoleUnload (ConsoleSystem.Arg arg)
- ConsoleReload (ConsoleSystem.Arg arg)
- ConsoleVersion (ConsoleSystem.Arg arg)
- ConsoleGroup (ConsoleSystem.Arg arg)
- ConsoleUserGroup (ConsoleSystem.Arg arg)
- ConsoleGrant (ConsoleSystem.Arg arg)
- ConsoleRevoke (ConsoleSystem.Arg arg)
- ConsoleShow (ConsoleSystem.Arg arg)
- OnRunCommand (ConsoleSystem.Arg arg, bool wantreply)
- IOnGetClientMove (NetUser netUser, Vector3 pos)
- IOnRecieveNetwork
- IOnRPCError (object obj)
- IOnAIMovement (BasicWildLifeAI ai, BaseAIMovement movement)
