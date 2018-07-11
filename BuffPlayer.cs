using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffAF
{
    public class ThisPlayaSwoleAsFug : ModPlayer
    {
        public override void OnRespawn(Player player)
        {
            BuffPlayer(player);
        }

        public override void OnEnterWorld(Player player)
        {
            BuffPlayer(player);
        }

        public void BuffPlayer(Player player)
        {
            int x = Main.spawnTileX;
            int y = Main.spawnTileY;
            for(int i = x - 5; i < x + 5; i++)
            {
                for(int v = y - 5; v < y + 5; v++)
                {
                    if(Main.tile[i, v] != null)
                    {
                        switch(Main.tile[i, v].type)
                        {
                            case TileID.AmmoBox:
                                player.AddBuff(BuffID.AmmoBox, 36000);
                                Main.PlaySound(SoundID.Item);
                                break;
                            case TileID.BewitchingTable:
                                player.AddBuff(BuffID.Bewitched, 36000);
                                Main.PlaySound(SoundID.Item4);
                                break;
                            case TileID.CrystalBall:
                                player.AddBuff(BuffID.Clairvoyance, 36000);
                                Main.PlaySound(SoundID.Item4);
                                break;
                            case TileID.SharpeningStation:
                                player.AddBuff(BuffID.Sharpened, 36000);
                                Main.PlaySound(SoundID.Item37);
                                break;
                        }
                    }
                }
            }
        }
    }
}
