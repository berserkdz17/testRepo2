using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace RPG_Simulator
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtStr.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtStr.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtDex.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtDex.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtCon.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtCon.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtInt.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtInt.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtWis.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtWis.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtCha.Text);
            if (x < 14)
            {
                points = points - 1;
            }
            if (x >= 14 && x < 16)
            {
                points = points - 2;
            }
            if (x >= 16 && x < 18)
            {
                points = points - 3;
            }
            if (points >= 0)
            {
                x++;
                txtCha.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
            else
            {
                lblPoints.Visible = true;
            }
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtStr.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtStr.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtDex.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtDex.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtCon.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtCon.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtInt.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtInt.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtWis.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtWis.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtPoints.Text);
            int x = Convert.ToInt32(txtCha.Text);
            if (x <= 14)
            {
                points = points + 1;
            }
            if (x > 14 && x <= 16)
            {
                points = points + 2;
            }
            if (x > 16 && x <= 18)
            {
                points = points + 3;
            }
            if (points <= 30)
            {
                x--;
                txtCha.Text = x.ToString();
                txtPoints.Text = points.ToString();
            }
        }

        private void txtStr_TextChanged(object sender, EventArgs e)
        {
            txtStrM.Text = ((int)Math.Floor((Convert.ToDouble(txtStr.Text) - 10) / 2)).ToString();

            if (lblRace.Text == "Gnome")
            {
                if (Convert.ToInt32(txtStr.Text) == 6)
                {
                    btnStrDec.Enabled = false;
                }
                else btnStrDec.Enabled = true;
            }
            else
            {
                if (Convert.ToInt32(txtStr.Text) == 8)
                {
                    btnStrDec.Enabled = false;
                }
                else
                    btnStrDec.Enabled = true;
            }


            if (Convert.ToInt32(txtStr.Text) == 18)
            {
                btnStrInc.Enabled = false;
            }
            else
                btnStrInc.Enabled = true;
        }

        private void txtDex_TextChanged(object sender, EventArgs e)
        {
            //code for modifier
            txtDexM.Text = ((int)Math.Floor((Convert.ToDouble(txtDex.Text) - 10) / 2)).ToString();
            if (lblRace.Text == "Elf")
            {
                if (Convert.ToInt32(txtDex.Text) == 10)
                {
                    btnDexDec.Enabled = false;
                }
                else btnDexDec.Enabled = true;
            }
            else
            {
                if (Convert.ToInt32(txtDex.Text) == 8)
                {
                    btnDexDec.Enabled = false;
                }
                else
                    btnDexDec.Enabled = true;
            }


            if (Convert.ToInt32(txtDex.Text) == 18)
            {
                btnDexInc.Enabled = false;
            }
            else btnDexInc.Enabled = true;
            //code for AC
            int ac;
            int dexM = Int32.Parse(txtDexM.Text);
            ac = 10 + dexM;
            txtAC.Text = ac.ToString();
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {
            txtConM.Text = ((int)Math.Floor((Convert.ToDouble(txtCon.Text) - 10) / 2)).ToString();
            if (lblRace.Text == "Elf")
            {
                if (Convert.ToInt32(txtCon.Text) == 6)
                {
                    btnConDec.Enabled = false;
                }
                else btnConDec.Enabled = true;
            }
            else if (lblRace.Text == "Dwarf" || lblRace.Text == "Gnome")
            {
                if (Convert.ToInt32(txtCon.Text) == 10)
                {
                    btnConDec.Enabled = false;
                }
                else btnConDec.Enabled = true;
            }
            else
            {
                if (Convert.ToInt32(txtCon.Text) == 8)
                {
                    btnConDec.Enabled = false;
                }
                else
                    btnConDec.Enabled = true;
            }


            if (Convert.ToInt32(txtCon.Text) == 18)
            {
                btnConInc.Enabled = false;
            }
            else btnConInc.Enabled = true;

            //HP
            int hitDie;
            if (lblClass.Text == "Fighter") hitDie = 10;
            else if (lblClass.Text == "Rogue") hitDie = 6;
            else hitDie = 4;
            int conM = Int32.Parse(txtConM.Text);
            int hp = hitDie + conM;
            txtHP.Text = hp.ToString();
        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {
            txtIntM.Text = ((int)Math.Floor((Convert.ToDouble(txtInt.Text) - 10) / 2)).ToString();

            if (Convert.ToInt32(txtInt.Text) == 8)
            {
                btnIntDec.Enabled = false;
            }
            else
                btnIntDec.Enabled = true;
            if (Convert.ToInt32(txtInt.Text) == 18)
            {
                btnIntInc.Enabled = false;
            }
            else btnIntInc.Enabled = true;
        }

        private void txtWis_TextChanged(object sender, EventArgs e)
        {
            txtWisM.Text = ((int)Math.Floor((Convert.ToDouble(txtWis.Text) - 10) / 2)).ToString();

            if (Convert.ToInt32(txtWis.Text) == 8)
            {
                btnWisDec.Enabled = false;
            }
            else
                btnWisDec.Enabled = true;
            if (Convert.ToInt32(txtWis.Text) == 18)
            {
                btnWisInc.Enabled = false;
            }
            else btnWisInc.Enabled = true;
        }

        private void txtCha_TextChanged(object sender, EventArgs e)
        {
            txtChaM.Text = ((int)Math.Floor((Convert.ToDouble(txtCha.Text) - 10) / 2)).ToString();
            if (lblRace.Text == "Dwarf")
            {
                if (Convert.ToInt32(txtCha.Text) == 6)
                {
                    btnChaDec.Enabled = false;
                }
                else btnChaDec.Enabled = true;
            }
            else
            {
                if (Convert.ToInt32(txtCha.Text) == 8)
                {
                    btnChaDec.Enabled = false;
                }
                else
                    btnChaDec.Enabled = true;
            }

            if (Convert.ToInt32(txtCha.Text) == 18)
            {
                btnChaInc.Enabled = false;
            }
            else btnChaInc.Enabled = true;
        }

        private void btnStrInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblStr.Visible = false;
        }

        private void btnDexInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblDex.Visible = false;
        }

        private void btnConInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblCon.Visible = false;
        }

        private void btnIntInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblInt.Visible = false;
        }

        private void btnWisInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblWis.Visible = false;
        }

        private void btnChaInc_MouseLeave(object sender, EventArgs e)
        {
            txtPointM.Text = "";
            lblPoints.Visible = false;
            lblCha.Visible = false;
        }
        private void btnStrInc_MouseHover(object sender, EventArgs e)
        {
            lblStr.Visible = true;
            int x = Convert.ToInt32(txtStr.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnDexInc_MouseHover(object sender, EventArgs e)
        {
            lblDex.Visible = true;
            int x = Convert.ToInt32(txtDex.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnConInc_MouseHover(object sender, EventArgs e)
        {
            lblCon.Visible = true;
            int x = Convert.ToInt32(txtCon.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnIntInc_MouseHover(object sender, EventArgs e)
        {
            lblInt.Visible = true;
            int x = Convert.ToInt32(txtInt.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnWisInc_MouseHover(object sender, EventArgs e)
        {
            lblWis.Visible = true;
            int x = Convert.ToInt32(txtWis.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnChaInc_MouseHover(object sender, EventArgs e)
        {
            lblCha.Visible = true;
            int x = Convert.ToInt32(txtCha.Text);
            if (x < 14)
            {
                txtPointM.Text = "1";
            }
            if (x >= 14 && x < 16)
            {
                txtPointM.Text = "2";
            }
            if (x >= 16 && x < 18)
            {
                txtPointM.Text = "3";
            }
        }

        private void btnStrDec_MouseHover(object sender, EventArgs e)
        {
            lblStr.Visible = true;
        }

        private void btnStrDec_MouseLeave(object sender, EventArgs e)
        {
            lblStr.Visible = false;
        }

        private void btnDexDec_MouseHover(object sender, EventArgs e)
        {
            lblDex.Visible = true;
        }

        private void btnDexDec_MouseLeave(object sender, EventArgs e)
        {
            lblDex.Visible = false;
        }

        private void btnConDec_MouseLeave(object sender, EventArgs e)
        {
            lblCon.Visible = false;
        }

        private void btnConDec_MouseHover(object sender, EventArgs e)
        {
            lblCon.Visible = true;

        }

        private void btnIntDec_MouseLeave(object sender, EventArgs e)
        {
            lblInt.Visible = false;

        }

        private void btnIntDec_MouseHover(object sender, EventArgs e)
        {
            lblInt.Visible = true;
        }

        private void btnWisDec_MouseLeave(object sender, EventArgs e)
        {
            lblWis.Visible = false;
        }

        private void btnWisDec_MouseHover(object sender, EventArgs e)
        {
            lblWis.Visible = true;

        }
        private void btnChaDec_MouseLeave(object sender, EventArgs e)
        {
            lblCha.Visible = false;

        }

        private void btnChaDec_MouseHover(object sender, EventArgs e)
        {
            lblCha.Visible = true;
        }

        private void txtStrM_TextChanged(object sender, EventArgs e)
        {
            int ab;
            int ba = Int32.Parse(txtBA.Text);
            int strM = Int32.Parse(txtStrM.Text);
            if (strM > 0)
            {
                txtDmg.Text = "+" + strM.ToString();
            }
            else txtDmg.Text = strM.ToString();
            ab = ba + strM;
            txtAB.Text = ab.ToString();
        }

        private void txtConM_TextChanged(object sender, EventArgs e)
        {
            int conM = Int32.Parse(txtConM.Text);
            int fortitude;
            fortitude = conM;
            txtFortitude.Text = fortitude.ToString();
        }

        private void txtDexM_TextChanged(object sender, EventArgs e)
        {
            int dexM = Int32.Parse(txtDexM.Text);
            txtReflex.Text = dexM.ToString();
        }

        private void txtWisM_TextChanged(object sender, EventArgs e)
        {
            int wisM = Int32.Parse(txtWisM.Text);
            txtWill.Text = wisM.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Button[] decButtons = { btnStrDec, btnDexDec, btnConDec, btnIntDec, btnWisDec, btnChaDec };
            foreach (Button buttons in decButtons)
            {
                for (int i = 0; i < 30; i++)
                {
                    while (buttons.Enabled == true)
                    {
                        buttons.PerformClick();
                    }
                }
            }

        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            btnReset.PerformClick();

            lblGender.Text = "";
            lblRace.Text = "";
            lblClass.Text = "";

            gbxGender.Visible = false;
            gbxRace.Visible = false;
            gbxClass.Visible = false;
            gbxPortraits.Visible = false;
            gbxAbilities.Visible = false;
            gbxPackage.Visible = false;
            gbxCustomize.Visible = false;
            gbxPlayerSheet.Visible = false;

            lblGRC.Visible = true;


            gbxNewCharacter.Visible = true;
            foreach (Button ctrl in gbxNewCharacter.Controls)
            {
                if (ctrl.Name != "btnGender")
                {
                    ctrl.Visible = false;
                    ctrl.Enabled = true;
                }
                else btnGender.Enabled = true;
            }

            foreach (PictureBox pic in panelPortraits.Controls)//sklanja slike
            {
                pic.Image = null;
            }

            //Fight stuff
            btnRemoveMonster.Enabled = true;
            btnRemoveMonster.PerformClick();
            btnRemoveMonster.Enabled = false;

            gbxMonsters.Visible = false;
            gbxFight.Visible = false;

            //potions
            gbxPotions.Visible = false;

            //Reset, inventory and shop
            btnResetHero.Visible = false;
            btnInventory.Visible = false;
            btnShop.Visible = false;
            gbxInventory.Visible = false;
            

            txtHeal2.Text = "3";
            txtHeal10.Text = "1";
            txtHeal50.Text = "0";
            txtInvGold.Text = "0";

            lbxAC.Items.Clear();
            lbxInvWeapon.Items.Clear();
            lbxInvWeapon.Items.Add("Shortsword");
            lblInvWeapon.Text = "Shortsword";
            lbxArmor.Items.Clear();
            lbxArmor.Items.Add("Invisible Shirt");
            lblInvArmor.Text = "Invisible Shirt";
            lbxHelmet.Items.Clear();
            lbxHelmet.Items.Add("Sombrero");
            lblInvHelmet.Text = "Sombrero";
            lbxBoots.Items.Clear();
            lbxBoots.Items.Add("Slippers");
            lblInvBoots.Text = "Slippers";
            lbxNecklace.Items.Clear();
            lbxNecklace.Items.Add("Shoelace");
            lblInvNecklace.Text = "Shoelace";

            lblInvName.Text = "";
            txtInv.Text = "0";
            txtInvBonusAc.Text = "0";

            picBoxInv.Visible = false;

            foreach (Control pic in panelShop.Controls)
            {
                if(pic is PictureBox) pic.Enabled = true;
            }
            gbxShop.Visible = false;

            txtBeetleCounter.Text = "0";
            txtWolfCounter.Text = "0";
            txtBearCounter.Text = "0";
            txtDragonCounter.Text = "0";

            //some other buttons
            btnGoldPlus.Visible = false;
            btnXPPlus.Visible = false;

        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            gbxGender.Visible = true;
            btnGender.Enabled = false;
        }

        private bool maleWasClicked;
        private bool femaleWasClicked;
        private void btnMale_Click(object sender, EventArgs e)
        {
            btnRace.Visible = true;
            gbxGender.Visible = false;
            btnGender.Enabled = false;
            maleWasClicked = true;
            femaleWasClicked = false;
            lblGender.Text = "Male";
            lblGender.Visible = true;
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            btnRace.Visible = true;
            gbxGender.Visible = false;
            btnGender.Enabled = false;
            maleWasClicked = false;
            femaleWasClicked = true;
            lblGender.Text = "Female";
            lblGender.Visible = true;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            gbxRace.Visible = true;
            btnRace.Enabled = false;
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            btnRace.Enabled = false;
            btnClass.Visible = true;
            gbxRace.Visible = false;
            lblRace.Text = "Human";
            lblRace.Visible = true;
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            btnRace.Enabled = false;
            btnClass.Visible = true;
            gbxRace.Visible = false;
            lblRace.Text = "Elf";
            lblRace.Visible = true;
        }

        private void btnGnome_Click(object sender, EventArgs e)
        {
            btnRace.Enabled = false;
            btnClass.Visible = true;
            gbxRace.Visible = false;
            lblRace.Text = "Gnome";
            lblRace.Visible = true;
        }

        private void btnDwarf_Click(object sender, EventArgs e)
        {
            btnRace.Enabled = false;
            btnClass.Visible = true;
            gbxRace.Visible = false;
            lblRace.Text = "Dwarf";
            lblRace.Visible = true;
        }

        private void btnHuman_MouseEnter(object sender, EventArgs e)
        {
            lblRaceHuman.Visible = true;
            lblRaceElf.Visible = false;
            lblRaceDwarf.Visible = false;
            lblRaceGnome.Visible = false;
        }
        private void btnElf_MouseEnter(object sender, EventArgs e)
        {
            lblRaceElf.Visible = true;
            lblRaceHuman.Visible = false;
            lblRaceDwarf.Visible = false;
            lblRaceGnome.Visible = false;
        }
        private void btnGnome_MouseEnter(object sender, EventArgs e)
        {
            lblRaceGnome.Visible = true;
            lblRaceHuman.Visible = false;
            lblRaceElf.Visible = false;
            lblRaceDwarf.Visible = false;
        }
        private void btnDwarf_MouseEnter(object sender, EventArgs e)
        {
            lblRaceDwarf.Visible = true;
            lblRaceHuman.Visible = false;
            lblRaceElf.Visible = false;
            lblRaceGnome.Visible = false;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            gbxClass.Visible = true;
            btnClass.Enabled = false;
        }

        private void btnFighter_Click(object sender, EventArgs e)
        {
            gbxClass.Visible = false;
            btnClass.Enabled = false;
            btnPortrait.Visible = true;
            lblClass.Text = "Fighter";
            lblClass.Visible = true;
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            gbxClass.Visible = false;
            btnClass.Enabled = false;
            btnPortrait.Visible = true;
            lblClass.Text = "Rogue";
            lblClass.Visible = true;
        }

        private void btnWizard_Click(object sender, EventArgs e)
        {
            gbxClass.Visible = false;
            btnClass.Enabled = false;
            btnPortrait.Visible = true;
            lblClass.Text = "Wizard";
            lblClass.Visible = true;
        }

        private void btnFighter_MouseEnter(object sender, EventArgs e)
        {
            lblClassFighter.Visible = true;
            lblClassRogue.Visible = false;
            lblClassWizard.Visible = false;
        }

        private void btnRogue_MouseEnter(object sender, EventArgs e)
        {
            lblClassFighter.Visible = false;
            lblClassRogue.Visible = true; ;
            lblClassWizard.Visible = false;
        }

        private void btnWizard_MouseEnter(object sender, EventArgs e)
        {
            lblClassFighter.Visible = false;
            lblClassRogue.Visible = false;
            lblClassWizard.Visible = true;
        }

        private void btnPortrait_Click(object sender, EventArgs e)
        {
            btnPortrait.Enabled = false;
            gbxPortraits.Visible = true;

            PictureBox[] picBox = new PictureBox[panelPortraits.Controls.Count];
            panelPortraits.Controls.CopyTo(picBox, 0);

            Image[] females = new Image[imageListPortraitsFemale.Images.Count];
            for (int i = 0; i < females.Length; i++)
            {
                females[i] = imageListPortraitsFemale.Images[i];
            }
            Image[] males = new Image[imageListPortraitsMale.Images.Count];
            for (int i = 0; i < males.Length; i++)
            {
                males[i] = imageListPortraitsMale.Images[i];
            }

            int a = 0;

            if (femaleWasClicked)
            {
                for (int i = picBox.Length - 1; i > -1; i--)
                {
                    if (a < females.Length)
                    {
                        picBox[i].Image = females[a];
                        a++;
                    }
                }
            }
            if (maleWasClicked)
            {
                for (int i = picBox.Length - 1; i > -1; i--)
                {
                    if (a < males.Length)
                    {
                        picBox[i].Image = males[a];
                        a++;
                    }
                }
            }
                    
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox1.Image;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox5.Image;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox10.Image;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox9.Image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox8.Image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox7.Image;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox6.Image;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox15.Image;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox14.Image;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            btnAbilities.Visible = true;
            gbxPortraits.Visible = false;
            pbxPlayerPortrait.Image = pictureBox13.Image;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                btnAbilities.Visible = true;
                gbxPortraits.Visible = false;
                pbxPlayerPortrait.Image = pictureBox12.Image;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image != null)
            {
                btnAbilities.Visible = true;
                gbxPortraits.Visible = false;
                pbxPlayerPortrait.Image = pictureBox11.Image;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image != null)
            {
                btnAbilities.Visible = true;
                gbxPortraits.Visible = false;
                pbxPlayerPortrait.Image = pictureBox20.Image;
            }
        }

        private void btnAbilities_Click(object sender, EventArgs e)
        {

            gbxAbilities.Visible = true;
            btnReset.PerformClick();
            btnAbilities.Enabled = false;

            TextBox[] boxes = { txtStr, txtDex, txtCon, txtInt, txtWis, txtCha };

            foreach (TextBox box in boxes)
            {
                box.Text = "8";
            }

            if (lblRace.Text == "Elf")
            {
                txtDex.Text = "10";
                txtCon.Text = "6";
            }
            else if (lblRace.Text == "Gnome")
            {
                txtStr.Text = "6";
                txtCon.Text = "10";
            }
            else if (lblRace.Text == "Dwarf")
            {
                txtCon.Text = "10";
                txtCha.Text = "6";
            }
            txtAC.Text = (Int32.Parse(txtDexM.Text) + 10).ToString();

            if (lblClass.Text == "Fighter")
            {
                txtHP.Text = (Int32.Parse(txtConM.Text) + 10).ToString();
                txtBA.Text = "1";
            }
            else if (lblClass.Text == "Rogue")
            {
                txtHP.Text = (Int32.Parse(txtConM.Text) + 6).ToString();
                txtBA.Text = "0";
            }
            else
            {
                txtHP.Text = (Int32.Parse(txtConM.Text) + 4).ToString();
                txtBA.Text = "0";
            }

            txtAB.Text = (Int32.Parse(txtBA.Text) + Int32.Parse(txtStrM.Text)).ToString();
        }

        private void btnAbilitiesNext_Click(object sender, EventArgs e)
        {
            if (txtPoints.Text == "0")
            {
                gbxAbilities.Visible = false;
                btnPackage.Visible = true;
            }
            else
            {
                lblStillPoints.Visible = true;
            }
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            btnPackage.Enabled = false;
            gbxPackage.Visible = true;
        }

        private void btnAbilitiesNext_MouseLeave(object sender, EventArgs e)
        {
            lblStillPoints.Visible = false;
        }

        private void btnPackageNext_Click(object sender, EventArgs e)
        {
            gbxPackage.Visible = false;
            btnCustomize.Visible = true;
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            btnCustomize.Enabled = false;
            gbxCustomize.Visible = true;
            btnGenerateFirstName.PerformClick();
            btnGenerateLastName.PerformClick();
        }

        private void btnConfirmCharacter_Click(object sender, EventArgs e)
        {
            lblGender.Visible = false;
            lblRace.Visible = false;
            lblClass.Visible = false;
            lblGRC.Visible = false;
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                gbxCustomize.Visible = false;
                gbxPlayerSheet.Visible = true;

                //Creating Hero
                hero.Gender = lblGender.Text;
                hero.Race = lblRace.Text;
                hero.ClassType = lblClass.Text;
                hero.Name = txtFirstName.Text + "   " + txtLastName.Text;

                hero.Strength = Convert.ToDouble(txtStr.Text);
                hero.Dexterity = Double.Parse(txtDex.Text);
                hero.Constitution = Double.Parse(txtCon.Text);
                hero.Intelligence = Double.Parse(txtInt.Text);
                hero.Wisdom = Double.Parse(txtWis.Text);
                hero.Charisma = Double.Parse(txtCha.Text);

                hero.StrengthM = hero.Modify(hero.Strength);
                hero.DexterityM = hero.Modify(hero.Dexterity);
                hero.ConstitutionM = hero.Modify(hero.Constitution);
                hero.IntelligenceM = hero.Modify(hero.Intelligence);
                hero.WisdomM = hero.Modify(hero.Wisdom);
                hero.CharismaM = hero.Modify(hero.Charisma);
                //For some reason this doesn't work
                //double[] attributes ={hero.Strength, hero.Dexterity, hero.Constitution, 
                //                         hero.Intelligence,hero.Wisdom, hero.Charisma};
                //int[] attributeM ={hero.StrengthM, hero.DexterityM, hero.ConstitutionM, 
                //                      hero.IntelligenceM, hero.WisdomM, hero.CharismaM};
                //for (int i = 0; i < 6; i++)
                //{
                //    attributeM[i] = hero.Modify(attributes[i]);
                //}
                hero.currentXp = 0;
                hero.weaponType = "Shortsword";
                hero.CalculateHitDie();
                hero.CalculateBaseAttackRate();
                hero.CalculateDmg();
                hero.gold = 0;
                hero.Armor = 0;
                hero.BonusAC = 0;
                hero.DodgeAC = 0;
                hero.NaturalAC = 0;



                //Player Sheet
                lblFullName.Text = hero.Name;
                lblPlayerRace.Text = hero.Race;
                lblPlayerClass.Text = hero.ClassType;

                lblPlayerStr.Text = hero.Strength.ToString();
                lblPlayerDex.Text = hero.Dexterity.ToString();
                lblPlayerCon.Text = hero.Constitution.ToString();
                lblPlayerInt.Text = hero.Intelligence.ToString();
                lblPlayerWis.Text = hero.Wisdom.ToString();
                lblPlayerCha.Text = hero.Charisma.ToString();

                lblPlayerStrM.Text = hero.StrengthM.ToString();
                lblPlayerDexM.Text = hero.DexterityM.ToString();
                lblPlayerConM.Text = hero.ConstitutionM.ToString();
                lblPlayerIntM.Text = hero.IntelligenceM.ToString();
                lblPlayerWisM.Text = hero.WisdomM.ToString();
                lblPlayerChaM.Text = hero.CharismaM.ToString();

                lblPlayerAC.Text = hero.CalculateAC().ToString();
                lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                lblPlayerHP.Text = hero.CalculateHP().ToString();
                lblPlayerMaxHp.Text = hero.CalculateHP().ToString();
                lblPlayerBaseAttack.Text = hero.CalculateBaseAttack().ToString();
                lblPlayerFortitude.Text = hero.CalculateFortitude().ToString();
                lblPlayerReflex.Text = hero.CalculateReflex().ToString();
                lblPlayerWill.Text = hero.CalculateWill().ToString();
                lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                if (hero.CalculateAttackBonus() > 0)
                    lblPlayerAttackBonus.Text = "+" + hero.CalculateAttackBonus().ToString();
                else
                    lblPlayerAttackBonus.Text = hero.CalculateAttackBonus().ToString();
                lblWeaponDmg.Text = hero.WeaponDmgDisplay();


                //Fighting stuff
                gbxMonsters.Visible = true;
                txtFight1.Text = null;
                gbxFight.Visible = true;

                //Potions
                gbxPotions.Visible = true;

                //Inventory and shop
                btnInventory.Visible = true;
                btnShop.Visible = true;
                btnShop.Enabled = true;

                //gold and xp buttons
                btnGoldPlus.Visible = true;
                btnXPPlus.Visible = true;



                gbxAbilities.Visible = true;
                btnReset.PerformClick();
                gbxAbilities.Visible = false;



            }
            else if (txtFirstName.Text == "")
                MessageBox.Show("You need a first name");
            else
                MessageBox.Show("You need a last name");

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            btnReset.PerformClick();
            #region Recommended Figher
            if (lblClass.Text == "Fighter")
            {
                for (int i = 0; i < 2; i++)
                {
                    btnIntInc.PerformClick();
                    btnWisInc.PerformClick();
                }
                for (int i = 0; i < 10; i++)
                {
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Dwarf")
                    {
                        if (i > 1)
                        {
                            btnStrInc.PerformClick();
                        }
                    }
                    else btnStrInc.PerformClick();
                }
                for (int i = 0; i < 5; i++)
                {
                    if (lblRace.Text == "Human" || lblRace.Text == "Gnome" || lblRace.Text == "Dwarf")
                    {
                        btnDexInc.PerformClick();
                    }
                    else
                    {
                        if (i > 1)
                            btnDexInc.PerformClick();
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    if (lblRace.Text == "Gnome" || lblRace.Text == "Dwarf")
                    {
                        if (i > 3)
                        {
                            btnConInc.PerformClick();
                        }
                    }
                    else if (lblRace.Text == "Human")
                    {
                        if (i > 1)
                        {
                            btnConInc.PerformClick();
                        }
                    }
                    else btnConInc.PerformClick();
                }
                for (int i = 0; i < 3; i++)
                {
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Gnome")
                    {
                        if (i > 1)
                        {
                            btnChaInc.PerformClick();
                        }
                    }
                    else btnChaInc.PerformClick();
                }

            }
            #endregion
            #region Recommended Rogue
            if (lblClass.Text == "Rogue")
            {
                for (int i = 0; i < 6; i++)
                {
                    btnWisInc.PerformClick();
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Gnome")
                    {
                        if (i > 1) btnChaInc.PerformClick();
                    }
                    else btnChaInc.PerformClick();
                }
                for (int i = 0; i < 6; i++)
                {
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Dwarf")
                    {
                        if (i > 1) btnStrInc.PerformClick();
                    }
                    else btnStrInc.PerformClick();
                }
                for (int i = 0; i < 8; i++)
                {
                    if (lblRace.Text == "Elf")
                    {
                        if (i > 1) btnDexInc.PerformClick();
                    }
                    else btnDexInc.PerformClick();
                    if (lblRace.Text == "Gnome" || lblRace.Text == "Dwarf")
                    {
                        if (i > 3) btnConInc.PerformClick();
                    }
                    else if (lblRace.Text == "Human")
                    {
                        if (i > 1) btnConInc.PerformClick();
                    }
                    else btnConInc.PerformClick();
                }

            }
            #endregion
            #region Recommended Wizard
            if (lblClass.Text == "Wizard")
            {
                for (int i = 0; i < 8; i++)
                {
                    btnWisInc.PerformClick();
                    if (i > 3) btnIntInc.PerformClick();
                    if (lblRace.Text == "Human")
                    {
                        if (i > 1) btnConInc.PerformClick();
                    }
                    else if (lblRace.Text == "Gnome" || lblRace.Text == "Dwarf")
                    {
                        if (i > 3) btnConInc.PerformClick();
                    }
                    else btnConInc.PerformClick();
                }
                for (int i = 0; i < 4; i++)
                {
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Dwarf")
                    {
                        if (i > 1) btnStrInc.PerformClick();
                    }
                    else btnStrInc.PerformClick();
                    if (lblRace.Text == "Human" || lblRace.Text == "Elf" || lblRace.Text == "Gnome")
                    {
                        if (i > 1) btnChaInc.PerformClick();
                    }
                    else btnChaInc.PerformClick();
                }
                for (int i = 0; i < 6; i++)
                {
                    if (lblRace.Text == "Elf")
                    {
                        if (i > 1) btnDexInc.PerformClick();
                    }
                    else btnDexInc.PerformClick();
                }
            }
            #endregion
        }

        private void lblPlayerStr_TextChanged(object sender, EventArgs e)
        {
            lblPlayerStrM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerStr.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerDex_TextChanged(object sender, EventArgs e)
        {
            lblPlayerDexM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerDex.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerCon_TextChanged(object sender, EventArgs e)
        {
            lblPlayerConM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerCon.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerInt_TextChanged(object sender, EventArgs e)
        {
            lblPlayerIntM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerInt.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerWis_TextChanged(object sender, EventArgs e)
        {
            lblPlayerWisM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerWis.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerCha_TextChanged(object sender, EventArgs e)
        {
            lblPlayerChaM.Text =
                ((int)Math.Floor((Convert.ToDouble(lblPlayerCha.Text) - 10) / 2)).ToString();
        }

        private void lblPlayerConM_TextChanged(object sender, EventArgs e)
        {
            lblPlayerFortitude.Text = lblPlayerConM.Text;
            //if (lblClass.Text=="Fighter")
            //    lblPlayerHP.Text = (Int32.Parse(lblPlayerConM.Text)+10).ToString();
            //else if(lblClass.Text=="Rogue")
            //    lblPlayerHP.Text = (Int32.Parse(lblPlayerConM.Text) + 6).ToString();
            //else lblPlayerHP.Text = (Int32.Parse(lblPlayerConM.Text) + 4).ToString();

        }

        private void lblPlayerDexM_TextChanged(object sender, EventArgs e)
        {
            ////Code for AC
            //int dexM = Int32.Parse(lblPlayerDexM.Text);
            //lblPlayerAC.Text = (dexM+10).ToString();

            //Code for Reflex
            lblPlayerReflex.Text = lblPlayerDexM.Text;
            lblPlayerAC.Text = hero.CalculateAC().ToString();
        }

        private void lblPlayerWisM_TextChanged(object sender, EventArgs e)
        {
            lblPlayerWill.Text = lblPlayerWisM.Text;
        }

        private void lblPlayerStrM_TextChanged(object sender, EventArgs e)
        {
            int strM = Int32.Parse(lblPlayerStrM.Text);
            if (strM < 0)
            {
                lblModifierDmg.Text = lblPlayerStrM.Text;
            }
            else if (strM == 0)
            {
                lblModifierDmg.Text = "";
            }
            else
            {
                lblModifierDmg.Text = "+ " + lblPlayerStrM.Text;
            }

            //attack bonus
            int ba = Int32.Parse(lblPlayerBaseAttack.Text);
            int ab = hero.CalculateAttackBonus();

            if (hero.CalculateAttackBonus() > 0)
            {
                lblPlayerAttackBonus.Text = "+" + hero.CalculateAttackBonus().ToString();

                if (ba > 5 && ba < 11) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString();
                else if (ba > 10 && ba < 16) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString() + "/+" + (ab - 10).ToString();
                else if (ba > 15) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString() + "/+" + (ab - 10).ToString() + "/+" + (ab - 15).ToString();
            }
            else
            {
                lblPlayerAttackBonus.Text = hero.CalculateAttackBonus().ToString();
            }
        }

        private void btnGenerateFirstName_Click(object sender, EventArgs e)
        {
            #region Random number generator for different race and gender
            Random random = new Random();
            int hmi = random.Next(0, 7);
            int emi = random.Next(14, 20);
            int dmi = random.Next(26, 32);
            int gmi = random.Next(39, 44);
            int hfi = random.Next(50, 55);
            int efi = random.Next(62, 67);
            int gfi = random.Next(74, 78);
            int dfi = random.Next(84, 89);
            #endregion

            #region Random Name
            if (lblGender.Text == "Male" && lblRace.Text == "Human")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[hmi])
                    txtFirstName.Text = (string)listBoxNames.Items[hmi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblRace.Text == "Elf" && lblGender.Text == "Male")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[emi])
                    txtFirstName.Text = (string)listBoxNames.Items[emi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblRace.Text == "Gnome" && lblGender.Text == "Male")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[gmi])
                    txtFirstName.Text = (string)listBoxNames.Items[gmi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblRace.Text == "Dwarf" && lblGender.Text == "Male")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[dmi])
                    txtFirstName.Text = (string)listBoxNames.Items[dmi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Human")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[hfi])
                    txtFirstName.Text = (string)listBoxNames.Items[hfi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Elf")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[efi])
                    txtFirstName.Text = (string)listBoxNames.Items[efi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Gnome")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[gfi])
                    txtFirstName.Text = (string)listBoxNames.Items[gfi];
                else btnGenerateFirstName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Dwarf")
            {
                if (txtFirstName.Text != (string)listBoxNames.Items[dfi])
                    txtFirstName.Text = (string)listBoxNames.Items[dfi];
                else btnGenerateFirstName.PerformClick();
            }
            #endregion

        }

        private void btnGenerateLastName_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int hmp = random.Next(8, 13);
            int emp = random.Next(21, 25);
            int dmp = random.Next(33, 38);
            int gmp = random.Next(45, 49);
            int hfp = random.Next(56, 61);
            int efp = random.Next(68, 73);
            int gfp = random.Next(79, 83);
            int dfp = random.Next(90, 95);
            #region Random Name
            if (lblGender.Text == "Male" && lblRace.Text == "Human")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[hmp])
                    txtLastName.Text = (string)listBoxNames.Items[hmp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblRace.Text == "Elf" && lblGender.Text == "Male")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[emp])
                    txtLastName.Text = (string)listBoxNames.Items[emp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblRace.Text == "Gnome" && lblGender.Text == "Male")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[gmp])
                    txtLastName.Text = (string)listBoxNames.Items[gmp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblRace.Text == "Dwarf" && lblGender.Text == "Male")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[dmp])
                    txtLastName.Text = (string)listBoxNames.Items[dmp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Human")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[hfp])
                    txtLastName.Text = (string)listBoxNames.Items[hfp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Elf")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[efp])
                    txtLastName.Text = (string)listBoxNames.Items[efp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Gnome")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[gfp])
                    txtLastName.Text = (string)listBoxNames.Items[gfp];
                else btnGenerateLastName.PerformClick();
            }
            if (lblGender.Text == "Female" && lblRace.Text == "Dwarf")
            {
                if (txtLastName.Text != (string)listBoxNames.Items[dfp])
                    txtLastName.Text = (string)listBoxNames.Items[dfp];
                else btnGenerateLastName.PerformClick();
            }
            #endregion
        }

        bool BeetleSpawned = false;
        bool WolfSpawned = false;
        bool BearSpawned = false;
        bool DragonSpawned = false;
        private void btnSpawn_Click(object sender, EventArgs e)
        {
            btnRemoveMonster.PerformClick();
            btnFight.Enabled = true;

            rbtnFireBeetle.Enabled = false;
            rbtnWolf.Enabled = false;
            rbtnDireBear.Enabled = false;
            rbtnDragon.Enabled = false;


            if (rbtnFireBeetle.Checked)
            {
                gbxFireBeelte.Visible = true;
                lblFBHp.Text = "4";

                //creating new monster:fire beetle
                beetle.DexterityM = 0;
                beetle.StrengthM = 0;
                beetle.CalculateDmg();
                beetle.hp = 4;
                beetle.AttackBonus = 0;
                beetle.AC = 10;
                beetle.MonsterLvl = 1;
                beetle.MonsterRank = 1;

                BeetleSpawned = true;
                WolfSpawned = false;
                BearSpawned = false;
                DragonSpawned = false;
            }
            if (rbtnWolf.Checked)
            {
                gbxWolf.Visible = true;
                lblWolfHp.Text = "15";

                //creating new monster:wolf
                wolf.DexterityM = 0;
                wolf.StrengthM = 1;
                wolf.CalculateDmg();
                wolf.hp = 15;
                wolf.AttackBonus = 2;
                wolf.AC = 10;
                wolf.MonsterLvl = 2;
                wolf.MonsterRank = 3;

                BeetleSpawned = false;
                WolfSpawned = true;
                BearSpawned = false;
                DragonSpawned = false;
            }
            if (rbtnDireBear.Checked)
            {
                gbxDireBear.Visible = true;
                lblBearHp.Text = "102";

                //creating new monster:dire bear
                bear.DexterityM = 1;
                bear.StrengthM = 10;
                bear.CalculateDmg();
                bear.hp = 102;
                bear.AttackBonus = 18;
                bear.AC = 17;
                bear.MonsterLvl = 12;
                bear.MonsterRank = 16;
                bear.baseAttack = 8;

                BeetleSpawned = false;
                WolfSpawned = false;
                BearSpawned = true;
                DragonSpawned = false;
            }
            if (rbtnDragon.Checked)
            {
                gbxDragon.Visible = true;
                lblDragonHp.Text = "287";

                //creating new monster:dragon
                dragon.DexterityM = 1;
                dragon.StrengthM = 13;
                dragon.CalculateDmg();
                dragon.hp = 287;
                dragon.AttackBonus = 32;
                dragon.AC = 31;
                dragon.MonsterLvl = 23;
                dragon.MonsterRank = 60;
                dragon.baseAttack = 19;

                BeetleSpawned = false;
                WolfSpawned = false;
                BearSpawned = false;
                DragonSpawned = true;
            }

            btnSpawn.Enabled = false;
            btnRemoveMonster.Enabled = true;
        }

        private void btnRemoveMonster_Click(object sender, EventArgs e)
        {
            btnFight.Enabled = false;

            rbtnFireBeetle.Enabled = true;
            rbtnWolf.Enabled = true;
            rbtnDireBear.Enabled = true;
            rbtnDragon.Enabled = true;

            GroupBox[] gbx = { gbxFireBeelte, gbxWolf, gbxDireBear,gbxDragon };
            foreach (GroupBox gbla in gbx) gbla.Visible = false;
            btnRemoveMonster.Enabled = false;
            btnSpawn.Enabled = true;
        }

        //
        ////
        //////
        ////////
        //////////   F I G H T ! ! ! 
        ////////
        //////
        ////
        //        
        private async void btnFight_Click(object sender, EventArgs e)
        {
            btnFight.Enabled = false;
            btnRemoveMonster.Enabled = false;

            gbxShop.Visible = false;
            btnShop.Enabled = false;



            //Initiative rolls
            hero.InitiativeRolld20();
            await Task.Delay(1);
            beetle.InitiativeRolld20();
            await Task.Delay(1);
            wolf.InitiativeRolld20();
            await Task.Delay(1);
            bear.InitiativeRolld20();
            await Task.Delay(2);
            dragon.InitiativeRolld20();

            hero.Initiative();
            beetle.Initiative();
            wolf.Initiative();
            bear.Initiative();
            dragon.Initiative();

            #region FireBeetle fight
            if (BeetleSpawned)
            {
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(hero.InitiativeMessage());
                txtFight1.AppendText("\n");
                await Task.Delay(200);
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(beetle.InitiativeMessage());
                await Task.Delay(600);


                #region Hero attacks first
                if (hero.Initiative() >= beetle.Initiative())//if hero attacks first
                {
                    for (int i = 0; i < 20; i++)//20 rounds max
                    {
                        hero.CalculateDmg();
                        beetle.CalculateDmg();

                        //Hero attack sequence
                        if (beetle.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.CalculateDmg();
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(beetle.AC, ref beetle.hp, beetle.Name));
                            lblFBHp.Text = beetle.hp.ToString();
                            await Task.Delay(100);
                            if (beetle.hp < 1) goto BeetleDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 5));
                                lblFBHp.Text = beetle.hp.ToString();
                                await Task.Delay(100);
                                if (beetle.hp < 1) goto BeetleDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 10));
                                    lblFBHp.Text = beetle.hp.ToString();
                                    await Task.Delay(100);
                                    if (beetle.hp < 1) goto BeetleDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 15));
                                        lblFBHp.Text = beetle.hp.ToString();
                                        await Task.Delay(100);
                                        if (beetle.hp < 1) goto BeetleDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(100);

                        }
                    BeetleDead:
                        if (beetle.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + beetle.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + beetle.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += beetle.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += beetle.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                        //Beetle attack sequence
                        if (hero.hp > 0)
                        {
                            beetle.AttackRolld20();
                            beetle.AttackRoll();
                            await Task.Delay(1);
                            beetle.ThreatRolld20();
                            beetle.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(beetle.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(1400);
                        }
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                    }
                }
                #endregion

                #region Beetle attacks first
                else//Beetle had highter initiative
                {
                    for (int i = 0; i < 20; i++)
                    {
                        hero.CalculateDmg();
                        beetle.CalculateDmg();

                        //Beetle attack sequence
                        if (hero.hp > 0)
                        {
                            await Task.Delay(2);
                            beetle.AttackRolld20();
                            beetle.AttackRoll();
                            await Task.Delay(1);
                            beetle.ThreatRolld20();
                            beetle.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(beetle.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(600);
                        }
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                        //Hero attack sequence
                        if (beetle.hp > 0)
                        {
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(beetle.AC, ref beetle.hp, beetle.Name));
                            lblFBHp.Text = beetle.hp.ToString();
                            await Task.Delay(100);
                            if (beetle.hp < 1) goto BeetleDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 5));
                                lblFBHp.Text = beetle.hp.ToString();
                                await Task.Delay(100);
                                if (beetle.hp < 1) goto BeetleDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 10));
                                    lblFBHp.Text = beetle.hp.ToString();
                                    await Task.Delay(100);
                                    if (beetle.hp < 1) goto BeetleDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(beetle.AC, ref beetle.hp, beetle.Name, 15));
                                        lblFBHp.Text = beetle.hp.ToString();
                                        await Task.Delay(100);
                                        if (beetle.hp < 1) goto BeetleDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(1000);


                        }
                    BeetleDead:
                        if (beetle.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + beetle.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + beetle.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += beetle.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += beetle.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region Wolf fight
            if (WolfSpawned)
            {
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(hero.InitiativeMessage());
                txtFight1.AppendText("\n");
                await Task.Delay(200);
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(wolf.InitiativeMessage());
                await Task.Delay(600);

                #region Hero attacks first
                if (hero.Initiative() >= wolf.Initiative())//if hero attacks first
                {
                    for (int i = 0; i < 30; i++)//30 rounds max
                    {
                        hero.CalculateDmg();
                        wolf.CalculateDmg();

                        //Hero attack sequence
                        if (wolf.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.CalculateDmg();
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(wolf.AC, ref wolf.hp, wolf.Name));
                            lblWolfHp.Text = wolf.hp.ToString();
                            await Task.Delay(100);
                            if (wolf.hp < 1) goto WolfDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 5));
                                lblWolfHp.Text = wolf.hp.ToString();
                                await Task.Delay(100);
                                if (wolf.hp < 1) goto WolfDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 10));
                                    lblWolfHp.Text = wolf.hp.ToString();
                                    await Task.Delay(100);
                                    if (wolf.hp < 1) goto WolfDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 15));
                                        lblWolfHp.Text = wolf.hp.ToString();
                                        await Task.Delay(100);
                                        if (wolf.hp < 1) goto WolfDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(100);
                        }
                    WolfDead:
                        if (wolf.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + wolf.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + wolf.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += wolf.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += wolf.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                        //Wolf attack sequence
                        if (hero.hp > 0)
                        {
                            wolf.AttackRolld20();
                            wolf.AttackRoll();
                            await Task.Delay(1);
                            wolf.ThreatRolld20();
                            wolf.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(wolf.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(1500);
                        }
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                    }
                }
                #endregion
                #region Wolf attacks first

                else//Wolf had highter initiative
                {
                    for (int i = 0; i < 30; i++)
                    {
                        hero.CalculateDmg();
                        wolf.CalculateDmg();

                        //Wolf attack sequence
                        if (hero.hp > 0)
                        {
                            await Task.Delay(2);
                            wolf.AttackRolld20();
                            wolf.AttackRoll();
                            await Task.Delay(1);
                            wolf.ThreatRolld20();
                            wolf.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(wolf.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(600);
                        }
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                        //Hero attack sequence
                        if (wolf.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(wolf.AC, ref wolf.hp, wolf.Name));
                            lblWolfHp.Text = wolf.hp.ToString();
                            await Task.Delay(100);
                            if (wolf.hp < 1) goto WolfDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 5));
                                lblWolfHp.Text = wolf.hp.ToString();
                                await Task.Delay(100);
                                if (wolf.hp < 1) goto WolfDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 10));
                                    lblWolfHp.Text = wolf.hp.ToString();
                                    await Task.Delay(100);
                                    if (wolf.hp < 1) goto WolfDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(wolf.AC, ref wolf.hp, wolf.Name, 15));
                                        lblWolfHp.Text = wolf.hp.ToString();
                                        await Task.Delay(100);
                                        if (wolf.hp < 1) goto WolfDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(1000);
                        }
                    WolfDead:
                        if (wolf.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + wolf.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + wolf.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += wolf.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += wolf.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region Bear fight
            if (BearSpawned)
            {
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(hero.InitiativeMessage());
                txtFight1.AppendText("\n");
                await Task.Delay(200);
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(bear.InitiativeMessage());
                await Task.Delay(600);

                #region Hero attacks first
                if (hero.Initiative() >= bear.Initiative())//if hero attacks first
                {
                    for (int i = 0; i < 60; i++)//60 rounds max
                    {
                        hero.CalculateDmg();
                        bear.CalculateDmg();

                        //Hero attack sequence
                        if (bear.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.CalculateDmg();
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(bear.AC, ref bear.hp, bear.Name));
                            lblBearHp.Text = bear.hp.ToString();
                            await Task.Delay(100);
                            if (bear.hp < 1) goto BearDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 5));
                                lblBearHp.Text = bear.hp.ToString();
                                await Task.Delay(100);
                                if (bear.hp < 1) goto BearDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 10));
                                    lblBearHp.Text = bear.hp.ToString();
                                    await Task.Delay(100);
                                    if (bear.hp < 1) goto BearDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 15));
                                        lblBearHp.Text = bear.hp.ToString();
                                        await Task.Delay(100);
                                        if (bear.hp < 1) goto BearDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(100);
                        }
                    BearDead:
                        if (bear.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + bear.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + bear.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += bear.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += bear.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                        //Bear attack sequence
                        if (hero.hp > 0)
                        {
                            bear.AttackRolld20();
                            bear.AttackRoll();
                            await Task.Delay(1);
                            bear.ThreatRolld20();
                            bear.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(bear.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(100);
                            if (hero.hp < 1) goto HeroDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (bear.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                bear.CalculateDmg();
                                bear.AttackRolld20();
                                bear.AttackRoll();
                                await Task.Delay(1);
                                bear.ThreatRolld20();
                                bear.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.MidnightBlue;
                                txtFight1.AppendText(bear.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 5));
                                lblPlayerHP.Text = hero.hp.ToString();
                                await Task.Delay(100);
                                if (hero.hp < 1) goto HeroDead;
                                await Task.Delay(400);
                            }
                            #endregion

                            await Task.Delay(1000);
                        }
                    HeroDead:
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                    }
                }
                #endregion
                #region Bear attacks first

                else//Bear had highter initiative
                {
                    for (int i = 0; i < 60; i++)
                    {
                        hero.CalculateDmg();
                        bear.CalculateDmg();

                        //Bear attack sequence
                        if (hero.hp > 0)
                        {
                            await Task.Delay(2);
                            bear.AttackRolld20();
                            bear.AttackRoll();
                            await Task.Delay(1);
                            bear.ThreatRolld20();
                            bear.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(bear.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();

                            await Task.Delay(100);
                            if (hero.hp < 1) goto HeroDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (bear.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                bear.CalculateDmg();
                                bear.AttackRolld20();
                                bear.AttackRoll();
                                await Task.Delay(1);
                                bear.ThreatRolld20();
                                bear.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.MidnightBlue;
                                txtFight1.AppendText(bear.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 5));
                                lblPlayerHP.Text = hero.hp.ToString();
                                await Task.Delay(100);
                                if (hero.hp < 1) goto HeroDead;
                                await Task.Delay(400);
                            }
                            #endregion
                        }
                    HeroDead:
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                        //Hero attack sequence
                        if (bear.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(bear.AC, ref bear.hp, bear.Name));
                            lblBearHp.Text = bear.hp.ToString();
                            await Task.Delay(100);
                            if (bear.hp < 1) goto BearDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 5));
                                lblBearHp.Text = bear.hp.ToString();
                                await Task.Delay(100);
                                if (bear.hp < 1) goto BearDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(1);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 10));
                                    lblBearHp.Text = bear.hp.ToString();
                                    await Task.Delay(100);
                                    if (bear.hp < 1) goto BearDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(bear.AC, ref bear.hp, bear.Name, 15));
                                        lblBearHp.Text = bear.hp.ToString();
                                        await Task.Delay(100);
                                        if (bear.hp < 1) goto BearDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(1000);
                        }
                    BearDead:
                        if (bear.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + bear.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + bear.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += bear.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += bear.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region Dragon fight
            if (DragonSpawned)
            {
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(hero.InitiativeMessage());
                txtFight1.AppendText("\n");
                await Task.Delay(200);
                txtFight1.SelectionColor = Color.DarkMagenta;
                txtFight1.AppendText(dragon.InitiativeMessage());
                await Task.Delay(600);

                #region Hero attacks first
                if (hero.Initiative() >= dragon.Initiative())//if hero attacks first
                {
                    for (int i = 0; i < 120; i++)//120 rounds max
                    {
                        hero.CalculateDmg();
                        dragon.CalculateDmg();

                        //Hero attack sequence
                        if (dragon.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.CalculateDmg();
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(dragon.AC, ref dragon.hp, dragon.Name));
                            lblDragonHp.Text = dragon.hp.ToString();
                            await Task.Delay(100);
                            if (dragon.hp < 1) goto DragonDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 5));
                                lblDragonHp.Text = dragon.hp.ToString();
                                await Task.Delay(100);
                                if (dragon.hp < 1) goto DragonDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(3);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 10));
                                    lblDragonHp.Text = dragon.hp.ToString();
                                    await Task.Delay(100);
                                    if (dragon.hp < 1) goto DragonDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 15));
                                        lblDragonHp.Text = dragon.hp.ToString();
                                        await Task.Delay(100);
                                        if (dragon.hp < 1) goto DragonDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(100);
                        }
                    DragonDead:
                        if (dragon.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + dragon.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + dragon.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += dragon.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += dragon.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                        //Dragon attack sequence
                        if (hero.hp > 0)
                        {
                            dragon.AttackRolld20();
                            dragon.AttackRoll();
                            await Task.Delay(1);
                            dragon.ThreatRolld20();
                            dragon.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(dragon.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();
                            await Task.Delay(100);
                            if (hero.hp < 1) goto HeroDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (dragon.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                dragon.CalculateDmg();
                                dragon.AttackRolld20();
                                dragon.AttackRoll();
                                await Task.Delay(1);
                                dragon.ThreatRolld20();
                                dragon.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.MidnightBlue;
                                txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 5));
                                lblPlayerHP.Text = hero.hp.ToString();
                                await Task.Delay(100);
                                if (hero.hp < 1) goto HeroDead;
                                await Task.Delay(400);

                                if (dragon.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    dragon.CalculateDmg();
                                    dragon.AttackRolld20();
                                    dragon.AttackRoll();
                                    await Task.Delay(1);
                                    dragon.ThreatRolld20();
                                    dragon.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.MidnightBlue;
                                    txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 10));
                                    lblPlayerHP.Text = hero.hp.ToString();
                                    await Task.Delay(100);
                                    if (hero.hp < 1) goto HeroDead;
                                    await Task.Delay(400);

                                    if (dragon.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        dragon.CalculateDmg();
                                        dragon.AttackRolld20();
                                        dragon.AttackRoll();
                                        await Task.Delay(1);
                                        dragon.ThreatRolld20();
                                        dragon.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.MidnightBlue;
                                        txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 15));
                                        lblPlayerHP.Text = hero.hp.ToString();
                                        await Task.Delay(100);
                                        if (hero.hp < 1) goto HeroDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(1000);
                        }
                    HeroDead:
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                    }
                }
                #endregion
                #region Dragon attacks first

                else//Dragon had highter initiative
                {
                    for (int i = 0; i < 120; i++)
                    {
                        hero.CalculateDmg();
                        dragon.CalculateDmg();

                        //Dragon attack sequence
                        if (hero.hp > 0)
                        {
                            await Task.Delay(2);
                            dragon.AttackRolld20();
                            dragon.AttackRoll();
                            await Task.Delay(1);
                            dragon.ThreatRolld20();
                            dragon.ThreatRoll();
                            await Task.Delay(2);

                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkSlateBlue;
                            txtFight1.AppendText(dragon.Attack(hero.CalculateAC(), ref hero.hp, hero.Name));
                            lblPlayerHP.Text = hero.hp.ToString();

                            await Task.Delay(100);
                            if (hero.hp < 1) goto HeroDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (dragon.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                dragon.CalculateDmg();
                                dragon.AttackRolld20();
                                dragon.AttackRoll();
                                await Task.Delay(1);
                                dragon.ThreatRolld20();
                                dragon.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.MidnightBlue;
                                txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 5));
                                lblPlayerHP.Text = hero.hp.ToString();
                                await Task.Delay(100);
                                if (hero.hp < 1) goto HeroDead;
                                await Task.Delay(400);

                                if (dragon.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    dragon.CalculateDmg();
                                    dragon.AttackRolld20();
                                    dragon.AttackRoll();
                                    await Task.Delay(1);
                                    dragon.ThreatRolld20();
                                    dragon.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.MidnightBlue;
                                    txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 10));
                                    lblPlayerHP.Text = hero.hp.ToString();
                                    await Task.Delay(100);
                                    if (hero.hp < 1) goto HeroDead;
                                    await Task.Delay(400);

                                    if (dragon.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        dragon.CalculateDmg();
                                        dragon.AttackRolld20();
                                        dragon.AttackRoll();
                                        await Task.Delay(1);
                                        dragon.ThreatRolld20();
                                        dragon.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.MidnightBlue;
                                        txtFight1.AppendText(dragon.Attack2(hero.CalculateAC(), ref hero.hp, hero.Name, 15));
                                        lblPlayerHP.Text = hero.hp.ToString();
                                        await Task.Delay(100);
                                        if (hero.hp < 1) goto HeroDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion
                        }
                    HeroDead:
                        if (hero.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.Red;
                            txtFight1.AppendText("You have died!");
                            txtFight1.AppendText("\n");
                            break;
                        }
                        //Hero attack sequence
                    if (dragon.hp > 0)
                        {
                            await Task.Delay(2);
                            hero.AttackRolld20();
                            hero.AttackRoll();
                            await Task.Delay(1);
                            hero.ThreatRolld20();
                            hero.ThreatRoll();

                            txtFight1.AppendText("\n");
                            txtFight1.AppendText(hero.Attack(dragon.AC, ref dragon.hp, dragon.Name));
                            lblDragonHp.Text = dragon.hp.ToString();
                            await Task.Delay(100);
                            if (dragon.hp < 1) goto DragonDead;
                            await Task.Delay(400);

                            #region Second Attack(and 3rd and 4th)
                            if (hero.baseAttack > 5)//second attack with -5 attack bonus
                            {
                                //rolls
                                hero.CalculateDmg();
                                hero.AttackRolld20();
                                hero.AttackRoll();
                                await Task.Delay(1);
                                hero.ThreatRolld20();
                                hero.ThreatRoll();

                                txtFight1.AppendText("\n ");
                                txtFight1.SelectionColor = Color.DarkGreen;
                                txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 5));
                                lblDragonHp.Text = dragon.hp.ToString();
                                await Task.Delay(100);
                                if (dragon.hp < 1) goto DragonDead;
                                await Task.Delay(400);

                                if (hero.baseAttack > 10)//third attack with -10 attack bonus
                                {
                                    //rolls
                                    hero.CalculateDmg();
                                    hero.AttackRolld20();
                                    hero.AttackRoll();
                                    await Task.Delay(4);
                                    hero.ThreatRolld20();
                                    hero.ThreatRoll();

                                    txtFight1.AppendText("\n ");
                                    txtFight1.SelectionColor = Color.DarkOliveGreen;
                                    txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 10));
                                    lblDragonHp.Text = dragon.hp.ToString();
                                    await Task.Delay(100);
                                    if (dragon.hp < 1) goto DragonDead;
                                    await Task.Delay(400);

                                    if (hero.baseAttack > 15)//forth attack with -15 attack bonus
                                    {
                                        //rolls
                                        hero.CalculateDmg();
                                        hero.AttackRolld20();
                                        hero.AttackRoll();
                                        await Task.Delay(1);
                                        hero.ThreatRolld20();
                                        hero.ThreatRoll();

                                        txtFight1.AppendText("\n ");
                                        txtFight1.SelectionColor = Color.DeepSkyBlue;
                                        txtFight1.AppendText(hero.Attack2(dragon.AC, ref dragon.hp, dragon.Name, 15));
                                        lblDragonHp.Text = dragon.hp.ToString();
                                        await Task.Delay(100);
                                        if (dragon.hp < 1) goto DragonDead;
                                        await Task.Delay(400);
                                    }
                                }
                            }
                            #endregion

                            await Task.Delay(1000);
                        }
                    DragonDead:
                    if (dragon.hp < 1)
                        {
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText(hero.Name + " has killed " + dragon.Name + "!");
                            txtFight1.AppendText("\n");
                            txtFight1.SelectionColor = Color.DarkOrange;
                            txtFight1.AppendText("Experience Points Gained: " + dragon.XPGained(hero.CalculateLvl(), hero.currentXp).ToString());
                            hero.currentXp += dragon.XPGained(hero.CalculateLvl(), hero.currentXp);//xp gain
                            hero.gold += dragon.GoldGained();//gold gain
                            txtInvGold.Text = hero.gold.ToString();
                            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
                            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
                            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
                            txtFight1.AppendText("\n");

                            btnSpawn.Enabled = true;
                            rbtnFireBeetle.Enabled = true;
                            rbtnWolf.Enabled = true;
                            rbtnDireBear.Enabled = true;
                            rbtnDragon.Enabled = true;
                            btnRemoveMonster.Enabled = true;
                            break;
                        }
                    }
                }
                #endregion
            }
            #endregion
        }

        private void lblPlayerHP_TextChanged(object sender, EventArgs e)
        {
            if (hero.hp < 1)
            {
                btnRemoveMonster.Enabled = false;
                btnResetHero.Visible = true;
                gbxPotions.Visible = false;
                btnGoldPlus.Enabled = false;
                btnXPPlus.Enabled = false;
            }
            else btnResetHero.Visible = false;
        }

        private void lblPlayerLvl_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(lblPlayerLvl.Text) > 1)
            {
                if (lblPlayerLvl.Text == "4" || lblPlayerLvl.Text == "8" || lblPlayerLvl.Text == "12" ||
                    lblPlayerLvl.Text == "16" || lblPlayerLvl.Text == "20" || lblPlayerLvl.Text == "24" ||
                    lblPlayerLvl.Text == "28" || lblPlayerLvl.Text == "32" || lblPlayerLvl.Text == "36" ||
                    lblPlayerLvl.Text == "40")
                {
                    MessageBox.Show("Congratulations!!! You have gained enough experience to advance in your level!!!\r\nYou can now choose which attribute you want to raise by 1", "Level Gained");
                    gbxLvlUp.Visible = true;
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You have gained enough experience to advance in your level!!!\r\n" +
                                    "Unfortunately, right now, there are no options for lvl up, but your hp, base attack and attack bonus will go up\nEvery 4 levels you can upgrade an atttribute", "Level Gained");
                }

                hero.currentXp = Int32.Parse(lblPlayerCurrentXp.Text);
                hero.CalculateLvl();
                lblPlayerHP.Text = (hero.CalculateHP()).ToString();
                lblPlayerMaxHp.Text = (hero.CalculateHP()).ToString();
                lblPlayerBaseAttack.Text = (hero.CalculateBaseAttack()).ToString();

                if (hero.CalculateAttackBonus() > 0)
                    lblPlayerAttackBonus.Text = "+" + (hero.CalculateAttackBonus()).ToString();
                else lblPlayerAttackBonus.Text = (hero.CalculateAttackBonus()).ToString();

                int ba = Int32.Parse(lblPlayerBaseAttack.Text);
                int ab = hero.CalculateAttackBonus();


                if (ba > 5 && ba < 11) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString();
                if (ba > 10 && ba < 16) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString() + "/+" + (ab - 10).ToString();
                if (ba > 15) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString() + "/+" + (ab - 10).ToString() + "/+" + (ab - 15).ToString();
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            gbxInventory.Visible = true;
        }

        private async void btnLightHeal_Click(object sender, EventArgs e)
        {
            txtHeal2.Text = (Int32.Parse(txtHeal2.Text) - 1).ToString();//minus 1 heal

            if (txtHeal2.Enabled == true)
            {

                int startingHp = Int32.Parse(txtHP.Text);//takes first value of HP, from gbxAbilities!!!!!

                int heroLvl = Int32.Parse(lblPlayerLvl.Text);

                if (hero.hp == (startingHp * heroLvl) - 1)
                {
                    hero.hp++;
                    lblPlayerHP.Text = (hero.hp).ToString();
                }
                else if (hero.hp < ((startingHp * heroLvl) - 1))
                {
                    hero.hp += 2;
                    lblPlayerHP.Text = hero.hp.ToString();
                }
            }
            lblMinusHeal2.Visible = true;
            await Task.Delay(3500);
            lblMinusHeal2.Visible = false;
            
        }

        private void rbtnStrUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of strength your strength modifier goes up by 1 point." +
                "\r\nThis raises your attack bonus and damage by 1.";
        }

        private void lblPlayerBaseAttack_TextChanged(object sender, EventArgs e)
        {
            //int ba=Int32.Parse(lblPlayerBaseAttack.Text);
            //int ab = Int32.Parse(lblPlayerAttackBonus.Text);

            ////if (ba == 6) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString();
            ////if (ba == 11) lblPlayerAttackBonus.Text += "/+" + (ab - 10).ToString();
            ////if (ba == 16) lblPlayerAttackBonus.Text += "/+" + (ab - 15).ToString();

            //if (ba > 5 && ba < 11) lblPlayerAttackBonus.Text += "/+" + (ab - 5).ToString();
            //else if (ba > 10 && ba < 16) lblPlayerAttackBonus.Text += "/+" + (ab - 10).ToString();
            //else if (ba > 15) lblPlayerAttackBonus.Text += "/+" + (ab - 15).ToString();
        }

        private void rbtnDexUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of dexterity your dexterity modifier goes up by 1 point." +
                "\r\nThis raises your ac and reflex save by 1.";
        }

        private void rbtnConUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of constitution your constitution modifier goes up by 1 point." +
                "\r\nThis raises your foritude save and the max hp you get on lvl up.";
        }

        private void rbtnIntUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of intelligence  your int modifier goes up by 1 point." +
                "\r\nThis has absolutely no effect at all in this \"game\".";
        }

        private void rbtnWisUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of wisdom your wisdom modifier goes up by 1 point." +
                "\r\nThis raises your will save by 1 and that has absolutely no effect in this \"game\".";
        }

        private void rbtnChaUp_Click(object sender, EventArgs e)
        {
            txtLvlUp.Text = "For every 2 levels of charisma your charisma modifier goes up by 1 point." +
                "\r\nThis has absolutelyl no effect at all in this \"game\".";
        }

        private void btnLvlUpConfirm_Click(object sender, EventArgs e)
        {
            gbxLvlUp.Visible = false;
            //Strength chosen
            if (rbtnStrUp.Checked)
            {
                hero.Strength++;
                hero.StrengthM = hero.Modify(hero.Strength);
                hero.CalculateDmg();
                hero.CalculateAttackBonus();

                lblPlayerStr.Text = hero.Strength.ToString();
            }
            //Dexterity chosen
            if (rbtnDexUp.Checked)
            {
                hero.Dexterity++;
                hero.DexterityM = hero.Modify(hero.Dexterity);
                hero.CalculateAC();

                lblPlayerDex.Text = hero.Dexterity.ToString();
            }
            //Constitution chosen
            if (rbtnConUp.Checked)
            {
                hero.Constitution++;
                hero.ConstitutionM = hero.Modify(hero.Constitution);
                hero.CalculateHP();

                lblPlayerCon.Text = hero.Constitution.ToString();
                lblPlayerHP.Text = hero.CalculateHP().ToString();
                lblPlayerMaxHp.Text = lblPlayerHP.Text;
            }
            //Intelligence chosen
            if (rbtnIntUp.Checked)
            {
                hero.Intelligence++;
                hero.IntelligenceM = hero.Modify(hero.Intelligence);

                lblPlayerInt.Text = hero.Intelligence.ToString();
            }
            //Wisdom chosen
            if (rbtnWisUp.Checked)
            {
                hero.Wisdom++;
                hero.WisdomM = hero.Modify(hero.Wisdom);

                lblPlayerWis.Text = hero.Wisdom.ToString();
            }
            //Charisma chosen
            if (rbtnChaUp.Checked)
            {
                hero.Charisma++;
                hero.CharismaM = hero.Modify(hero.Charisma);

                lblPlayerCha.Text = hero.Charisma.ToString();
            }

        }

        private async void lblBearHp_TextChanged(object sender, EventArgs e)
        {
            int first = Int32.Parse(txtBearCounter.Text);
            int second;
            if (Int32.Parse(lblBearHp.Text) < 1)
            {
                second = first + 1;
                txtBearCounter.Text = second.ToString();

                //reward
                txtHeal10.Text = (Int32.Parse(txtHeal10.Text) + 1).ToString();
                
                Random random = new Random();
                int d10 = random.Next(1, 11);
                txtHeal10.Text = (Int32.Parse(txtHeal10.Text) + 1).ToString();

                if (d10 <8 )
                {
                    txtHeal50.Text = (Int32.Parse(txtHeal50.Text) + 1).ToString();
                }

                //gold message
                await Task.Delay(150);
                lblGoldMessage.Visible = true;
                await Task.Delay(2500);
                lblGoldMessage.Visible = false;

            }

        }

        private async void lblWolfHp_TextChanged(object sender, EventArgs e)
        {
            int first = Int32.Parse(txtWolfCounter.Text);
            int second;
            if (Int32.Parse(lblWolfHp.Text) < 1)
            {
                second = first + 1;
                txtWolfCounter.Text = second.ToString();
                

                //reward
                Random random = new Random();
                int d10 = random.Next(1, 11);
                await Task.Delay(1);
                int dOther = random.Next(1, 11);
                
                if (d10 < 7)
                {
                    txtHeal10.Text = (Int32.Parse(txtHeal10.Text) + 1).ToString();
                }
                await Task.Delay(3);
                if (dOther < 3)
                {
                    txtHeal50.Text = (Int32.Parse(txtHeal50.Text) + 1).ToString();
                }
                //gold message
                await Task.Delay(150);
                lblGoldMessage.Visible = true;
                await Task.Delay(2500);
                lblGoldMessage.Visible = false;
            }
        }

        private async void lblFBHp_TextChanged(object sender, EventArgs e)
        {
            int first = Int32.Parse(txtBeetleCounter.Text);
            int second;
            if (Int32.Parse(lblFBHp.Text) < 1)
            {
                second = first + 1;
                txtBeetleCounter.Text = second.ToString();

                //reward
                Random random = new Random();
                int d10 = random.Next(1, 11);
                int dOther = random.Next(1, 11);

                if (d10 < 10)
                {
                    txtHeal2.Text = (Int32.Parse(txtHeal2.Text) + 1).ToString();
                }
                await Task.Delay(3);
                if (dOther < 3)
                {
                    txtHeal10.Text = (Int32.Parse(txtHeal10.Text) + 1).ToString();
                }

                //gold message
                await Task.Delay(150);
                lblGoldMessage.Visible = true;
                await Task.Delay(2500);
                lblGoldMessage.Visible = false;
               

            }
        }

        private void txtBeetleCounter_TextChanged(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtBeetleCounter.Text);
            if (count % 10 == 0)
            {
                if (3000 + hero.currentXp > hero.NextLvlXp())
                {
                    hero.currentXp = hero.NextLvlXp();
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
                else
                {
                    hero.currentXp += 3000;
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
            }
        }

        private void txtWolfCounter_TextChanged(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtWolfCounter.Text);
            if (count % 10 == 0)
            {
                if (10000 + hero.currentXp > hero.NextLvlXp())
                {
                    hero.currentXp = hero.NextLvlXp();
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
                else
                {
                    hero.currentXp += 10000;
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
            }
        }

        private void txtBearCounter_TextChanged(object sender, EventArgs e)
        {
            int count = Int32.Parse(txtBearCounter.Text);
            if (count % 10 == 0)
            {
                if (45000 + hero.currentXp > hero.NextLvlXp())
                {
                    hero.currentXp = hero.NextLvlXp();
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
                else
                {
                    hero.currentXp += 45000;
                    hero.CalculateLvl();
                    hero.NextLvlXp();
                }
            }
        }

       
        private void lblInvW_Click(object sender, EventArgs e)
        {
            gbxInvProperties.Visible = true;
            lbxAC.Visible = false;
            lbxInvWeapon.Visible = true;
            picBoxInv.Visible = false;

            lblInvDmgOrArm.Text = "Damage";
            txtInv.Text = "";
            lblInvBonusAc.Visible = false;
            txtInvBonusAc.Visible = false;
            lblInvName.Text = "";
        }

        private void lbxWeapon_Click(object sender, EventArgs e)
        {
            if (lbxInvWeapon.SelectedItem != null)
            {
                lblInvName.Text = lbxInvWeapon.SelectedItem.ToString();
                picBoxInv.Visible = false;

                if (lblInvName.Text == "Shortsword")
                {
                    txtInv.Text = "1-6";
                    picBoxInv.Visible = true;
                    picBoxInv.Image = picBoxShortsword.Image;
                }
                if (lblInvName.Text == "Longsword")
                {
                    txtInv.Text = "1-8";
                    picBoxInv.Visible = true;
                    picBoxInv.Image=picBoxLongsword.Image;
                }
                if (lblInvName.Text == "Greatsword")
                {
                    txtInv.Text = "2-12";
                    picBoxInv.Visible = true;
                    picBoxInv.Image = picBoxGreatsword.Image;
                }
                if (lblInvName.Text == "Bastard Sword")
                {
                    txtInv.Text = "1-10";
                    picBoxInv.Visible = true;
                    picBoxInv.Image = picBoxBastardsword.Image;
                }
            }
        }

        private void lblInvA_Click(object sender, EventArgs e)
        {
            gbxInvProperties.Visible = true;
            picBoxInv.Image = picBoxInv.BackgroundImage;
            picBoxInv.Visible = false;
            picBoxShortsword.Visible = false; picBoxLongsword.Visible = false;
            picBoxBastardsword.Visible = false; picBoxGreatsword.Visible = false;

            lbxAC.Items.Clear();
            lbxAC.Items.AddRange(lbxArmor.Items);
            lbxAC.Visible = true;
            lbxInvWeapon.Visible = false;

            lblInvDmgOrArm.Text = "Armor";
            txtInv.Text = "";
            lblInvBonusAc.Visible = true;
            txtInvBonusAc.Visible = true;
            txtInvBonusAc.Text = "";
            lblInvName.Text = "";
        }


        private void lblInvH_Click(object sender, EventArgs e)
        {
            gbxInvProperties.Visible = true;
            picBoxInv.Visible = false;
            picBoxShortsword.Visible = false;
            picBoxLongsword.Visible = false;
            picBoxGreatsword.Visible = false;
            picBoxBastardsword.Visible = false;

            lbxAC.Items.Clear();
            lbxAC.Items.AddRange(lbxHelmet.Items);
            lbxAC.Visible = true;
            lbxInvWeapon.Visible = false;

            lblInvDmgOrArm.Text = "Armor";
            txtInv.Text = "";
            lblInvBonusAc.Visible = true;
            txtInvBonusAc.Visible = true;
            txtInvBonusAc.Text = "";
            lblInvName.Text = "";
        }

        private void lblInvB_Click(object sender, EventArgs e)
        {
            gbxInvProperties.Visible = true;
            picBoxInv.Visible = false;
            picBoxShortsword.Visible = false;
            picBoxLongsword.Visible = false;
            picBoxGreatsword.Visible = false;
            picBoxBastardsword.Visible = false;

            lbxAC.Items.Clear();
            lbxAC.Items.AddRange(lbxBoots.Items);
            lbxAC.Visible = true;
            lbxInvWeapon.Visible = false;

            lblInvDmgOrArm.Text = "Armor";
            txtInv.Text = "";
            lblInvBonusAc.Visible = true;
            txtInvBonusAc.Visible = true;
            txtInvBonusAc.Text = "";
            lblInvName.Text = "";
        }

        private void lblInvN_Click(object sender, EventArgs e)
        {
            gbxInvProperties.Visible = true;
            picBoxInv.Visible = false;
            picBoxShortsword.Visible = false;
            picBoxLongsword.Visible = false;
            picBoxGreatsword.Visible = false;
            picBoxBastardsword.Visible = false;

            lbxAC.Items.Clear();
            lbxAC.Items.AddRange(lbxNecklace.Items);
            lbxAC.Visible = true;
            lbxInvWeapon.Visible = false;

            lblInvDmgOrArm.Text = "Armor";
            txtInv.Text = "";
            lblInvBonusAc.Visible = true;
            txtInvBonusAc.Visible = true;
            txtInvBonusAc.Text = "";
            lblInvName.Text = "";
        }

        private void lbxInvWeapon_DoubleClick(object sender, EventArgs e)
        {
            hero.weaponType = lbxInvWeapon.SelectedItem.ToString();
            hero.CalculateDmg();
            lblWeaponDmg.Text = hero.WeaponDmgDisplay();
            lblInvWeapon.Text = lblInvName.Text;
            lblWeaponName.Text = lbxInvWeapon.SelectedItem.ToString();
        }

        private void lbxAC_Click(object sender, EventArgs e)
        {
            if (lbxAC.SelectedItem != null)
            {
                lblInvName.Text = lbxAC.SelectedItem.ToString();
                string n = lblInvName.Text;
                picBoxInv.Visible = true;
                picBoxInv.Image = null;

                //Armors
                if (n == "Invisible Shirt")
                {
                    picBoxInv.Size=new Size (64,96);
                    picBoxInv.Image = picBoxInv.BackgroundImage;
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Chain Shirt")
                {
                    picBoxInv.Image = imageListArmors.Images[0];
                    txtInv.Text = "4";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Chainmail")
                {
                    picBoxInv.Image = imageListArmors.Images[1];
                    txtInv.Text = "5";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Half Plate")
                {
                    picBoxInv.Image = imageListArmors.Images[2];
                    txtInv.Text = "7";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Full Plate")
                {
                    picBoxInv.Image = imageListArmors.Images[3];
                    txtInv.Text = "8";
                    txtInvBonusAc.Text = "0";
                }
                
                //Helmets
                if (n == "Sombrero")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[4];
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Stag Helmet")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[5];
                    txtInv.Text = "2";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Winged Helmet")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[6];
                    txtInv.Text = "4";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Spike Helmet")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[7];
                    txtInv.Text = "6";
                    txtInvBonusAc.Text = "0";
                }

                //Boots
                if (n == "Slippers")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[0];
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Cool Leather Boots")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[1];
                    txtInv.Text = "3";
                    txtInvBonusAc.Text = "0";
                    lblInvName.Text = "Cool Leather\r\nBoots";
                }
                if (n == "Mountain Boots")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[2];
                    txtInv.Text = "5";
                    txtInvBonusAc.Text = "0";
                    lblInvName.Text = "Mountain\r\nBoots";
                }
                //Necklace
                if (n == "Shoelace")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[8];
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "0";
                }
                if (n == "Necklace of Natural Armor+5")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[9];
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "5";
                    lblInvName.Text = "Necklace of\r\nNatural Armor\n+5";
                }
                if (n == "Necklace of Natural Armor+8")
                {
                    picBoxInv.Image = imageListBootsAndHelmetsAndNecklaces.Images[10];
                    txtInv.Text = "0";
                    txtInvBonusAc.Text = "8";
                    lblInvName.Text = "Necklace of\r\nNatural Armor\n+8";
                }
            }
        }

        private void btnRespawn_Click(object sender, EventArgs e)
        {
            int maxhp = Int32.Parse(lblPlayerMaxHp.Text);
            hero.hp = maxhp;
            lblPlayerHP.Text = hero.hp.ToString();
            btnRemoveMonster.Enabled = true;
            gbxPotions.Visible = true;
            btnShop.Enabled = true;
            btnGoldPlus.Enabled = true;
            btnXPPlus.Enabled = true;
        }

        private void lblDragonHp_TextChanged(object sender, EventArgs e)
        {
            int first = Int32.Parse(txtDragonCounter.Text);
            int second;
            if (Int32.Parse(lblDragonHp.Text) < 1)
            {
                second = first + 1;
                txtDragonCounter.Text = second.ToString();
            }
        }


        private async void txtHeal2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txtHeal2.Text) != 0)
            {
                btnLightHeal.Enabled = true;
                string sonja = "Sonja";
            }
            else btnLightHeal.Enabled = false;

            await Task.Delay(100);
            lblHeal2.Visible = true;
            await Task.Delay(3200);
            lblHeal2.Visible = false;
        }

        private async void txtHeal10_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txtHeal10.Text) != 0)
            {
                btnHeal10.Enabled = true;
            }
            else btnHeal10.Enabled = false;

            await Task.Delay(100);
            lblHeal10.Visible = true;
            await Task.Delay(3200);
            lblHeal10.Visible = false;
        }

        private async void txtHeal50_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txtHeal50.Text) != 0)
            {
                btnHeal50.Enabled = true;
            }
            else btnHeal50.Enabled = false;

            await Task.Delay(100);
            lblHeal50.Visible = true;
            await Task.Delay(3200);
            lblHeal50.Visible = false;
        }

        private async void btnHeal10_Click(object sender, EventArgs e)
        {
            txtHeal10.Text = (Int32.Parse(txtHeal10.Text) - 1).ToString();//minus 1 heal

            if (txtHeal10.Enabled == true)
            {

                int startingHp = Int32.Parse(txtHP.Text);//takes first value of HP, from gbxAbilities!!!!!

                int heroLvl = Int32.Parse(lblPlayerLvl.Text);

                if (hero.hp> Int32.Parse(lblPlayerMaxHp.Text) - 10)
                {
                    hero.hp=Int32.Parse(lblPlayerMaxHp.Text);
                    lblPlayerHP.Text=hero.hp.ToString();
                }
                else
                {
                    hero.hp += 10;
                    lblPlayerHP.Text = hero.hp.ToString();
                }               
            }
            
            lblMinusHeal10.Visible = true;
            await Task.Delay(3500);
            lblMinusHeal10.Visible = false;
        }

        private async void btnHeal50_Click(object sender, EventArgs e)
        {
            txtHeal50.Text = (Int32.Parse(txtHeal50.Text) - 1).ToString();//minus 1 heal

            if (txtHeal50.Enabled == true)
            {
                if (hero.hp > Int32.Parse(lblPlayerMaxHp.Text) - 50)
                {
                    hero.hp = Int32.Parse(lblPlayerMaxHp.Text);
                    lblPlayerHP.Text = hero.hp.ToString();
                }
                else
                {
                    hero.hp += 50;
                    lblPlayerHP.Text = hero.hp.ToString();
                }
            }
           
            lblMinusHeal50.Visible = true;
            await Task.Delay(3500);
            lblMinusHeal50.Visible = false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (gbxInventory.Visible == false) gbxInventory.Visible = true;
            else gbxInventory.Visible = false;
        }

        private void picBoxShopLongsword_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 1000)
            {
                lbxInvWeapon.Items.Add("Longsword");
                hero.gold -= 1000;
                txtInvGold.Text = hero.gold.ToString();
                picBoxShopLongsword.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!","!!!");            
        }

        private void picBoxShopBastardSword_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 3000)
            {
            lbxInvWeapon.Items.Add("Bastard Sword");
            hero.gold -= 3000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopBastardSword.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopChainShirt_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 500)
            {
            lbxArmor.Items.Add("Chain Shirt");
             hero.gold -= 500;
                txtInvGold.Text = hero.gold.ToString();
                picBoxShopChainShirt.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!","!!!");
        }

        private void picBoxShopChainmail_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 1000)
            {
            lbxArmor.Items.Add("Chainmail");
            hero.gold -= 1000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopChainmail.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopHalfPlate_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 3000)
            {
            lbxArmor.Items.Add("Half Plate");
            hero.gold -= 3000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopHalfPlate.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopBoots3_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 1000)
            {
            lbxBoots.Items.Add("Cool Leather Boots");
            hero.gold -= 1000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopBoots3.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopBoots5_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 2000)
            {
            lbxBoots.Items.Add("Mountain Boots");
            hero.gold -= 2000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopBoots5.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopStagHelm_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 500)
            {
            lbxHelmet.Items.Add("Stag Helmet");
             hero.gold -= 500;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopStagHelm.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopWingHelm_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 1000)
            {
            lbxHelmet.Items.Add("Winged Helmet");
            hero.gold -= 1000;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopWingHelm.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopNecklace5_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 2500)
            {
            lbxNecklace.Items.Add("Necklace of Natural Armor+5");
            hero.gold -= 2500;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopNecklace5.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void picBoxShopNecklace8_DoubleClick(object sender, EventArgs e)
        {
            if (hero.gold >= 6000)
            {
            lbxNecklace.Items.Add("Necklace of Natural Armor+8");
            hero.gold -= 600;
            txtInvGold.Text = hero.gold.ToString();
            picBoxShopNecklace8.Enabled = false;
            }
            else MessageBox.Show("You don't have enough gold to buy this!", "!!!");
        }

        private void lbxAC_DoubleClick(object sender, EventArgs e)
        {
            string n=lbxAC.SelectedItem.ToString();
            
            //Armor
            if (n == "Invisible Shirt")
            {
                lblInvArmor.Text = n;
                hero.Armor = 0;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Chain Shirt")
            {
                lblInvArmor.Text = n;
                hero.Armor = 4;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Chainmail")
            {
                lblInvArmor.Text = n;
                hero.Armor = 5;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Half Plate")
            {
                lblInvArmor.Text = n;
                hero.Armor = 7;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            //Boots
            if (n == "Slippers")
            {
                lblInvBoots.Text = n;
                hero.DodgeAC = 0;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Cool Leather Boots")
            {
                lblInvBoots.Text = n;
                hero.DodgeAC =3 ;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Mountain Boots")
            {
                lblInvBoots.Text = n;
                hero.DodgeAC = 5;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            //Helmets
            if (n == "Sombrero")
            {
                lblInvHelmet.Text = n;
                hero.HelmAC = 0;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Stag Helmet")
            {
                lblInvHelmet.Text = n;
                hero.HelmAC = 2;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Winged Helmet")
            {
                lblInvHelmet.Text = n;
                hero.HelmAC = 4;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            //Necklaces
            if (n == "Shoelace")
            {
                lblInvNecklace.Text = "Shoelace";
                hero.NaturalAC = 0;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Necklace of Natural Armor+5")
            {
                lblInvNecklace.Text = "Natural Armor +5";
                hero.NaturalAC = 5;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }
            if (n == "Necklace of Natural Armor+8")
            {
                lblInvNecklace.Text = "Natural Armor +8";
                hero.NaturalAC = 8;
                lblPlayerAC.Text = hero.CalculateAC().ToString();
            }


        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            hero.gold += 1000;
            txtInvGold.Text = hero.gold.ToString();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            if (gbxShop.Visible == true) gbxShop.Visible = false;
            else gbxShop.Visible = true;
        }

        private void lblPlayerCurrentXp_TextChanged(object sender, EventArgs e)
        {
            btnShop.Enabled = true;
        }

        private void btnXPPlus_Click(object sender, EventArgs e)
        {
            hero.currentXp += 1000;
            lblPlayerCurrentXp.Text = hero.currentXp.ToString();
            hero.CalculateLvl();
            lblPlayerLvl.Text = hero.CalculateLvl().ToString();
            hero.NextLvlXp();
            lblPlayerNextLvlXp.Text = hero.NextLvlXp().ToString();
            
        }
        


    }
}
