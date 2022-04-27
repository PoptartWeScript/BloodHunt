using System;
namespace BloodHunt
{

public class Offsets

{
   public static Int64 UWorld = 0x5741680;
   public static Int64 GNames = 0x55F9FC0;

public class UE
{

   public class UWorld
{
       public static Int64 ULevel = 0x30;
       public static Int64 OwningGameInstance = 0x180;
}

   public class ULevel
{
       public static Int64 AActors = 0x98;
       public static Int64 AActorsCount = 0xA0;
}

   public class UGameInstance
{
       public static Int64 LocalPlayers = 0x38;
}

   public class UPlayer
{
       public static Int64 PlayerController = 0x30;
}

   public class APlayerController
{
       public static Int64 AcknowledgedPawn = 0x2A0;
       public static Int64 PlayerCameraManager = 0x2C0;
}

   public class APawn
{
       public static Int64 PlayerState = 0x248;
}
   public class AActor
{
       public static Int64 USceneComponent = 0x138;
       public static Int64 tempVec= 0x11C;
       public static Int64 Health = 0x698;
       public static Int64 CurrentActorHPMax = 0x58c;
       public static Int64 actor_pawn = 0x120;
       public static Int64 bKickbackEnableds = 0xB18;
       public static Int64 LAKSTeamState = 0x3A8;
       public static Int64 LTeamNum = 0x220;
       public static Int64 AKSTeamState = 0x3A8;
       public static Int64 TeamNum = 0x220;
}

   public class APlayerCameraManager
{
       public static Int64 CameraCachePrivate = 0x1AC0;
}

}
}
}
