namespace RPG_Simulator
{
    partial class MainPageForm
    {
        Player hero = new Player();
        Monster wolf = new Monster("Wolf", "Wolf");
        Monster beetle = new Monster("Fire Beetle", "Fire Beetle");
        Monster bear = new Monster("Dire Bear", "Dire Bear");
        Monster dragon = new Monster("Dragon", "Dragon");
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      
        
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {            
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.gbxAbilities = new System.Windows.Forms.GroupBox();
            this.lblStillPoints = new System.Windows.Forms.Label();
            this.btnAbilitiesNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWill = new System.Windows.Forms.TextBox();
            this.txtReflex = new System.Windows.Forms.TextBox();
            this.txtFortitude = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDmg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPointM = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChaDec = new System.Windows.Forms.Button();
            this.btnWisDec = new System.Windows.Forms.Button();
            this.btnIntDec = new System.Windows.Forms.Button();
            this.btnConDec = new System.Windows.Forms.Button();
            this.btnDexDec = new System.Windows.Forms.Button();
            this.btnStrDec = new System.Windows.Forms.Button();
            this.btnChaInc = new System.Windows.Forms.Button();
            this.btnWisInc = new System.Windows.Forms.Button();
            this.btnIntInc = new System.Windows.Forms.Button();
            this.btnConInc = new System.Windows.Forms.Button();
            this.btnDexInc = new System.Windows.Forms.Button();
            this.btnStrInc = new System.Windows.Forms.Button();
            this.txtChaM = new System.Windows.Forms.TextBox();
            this.txtWisM = new System.Windows.Forms.TextBox();
            this.txtIntM = new System.Windows.Forms.TextBox();
            this.txtConM = new System.Windows.Forms.TextBox();
            this.txtDexM = new System.Windows.Forms.TextBox();
            this.txtStrM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.gbxNewCharacter = new System.Windows.Forms.GroupBox();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnAbilities = new System.Windows.Forms.Button();
            this.btnPortrait = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnGender = new System.Windows.Forms.Button();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.Button();
            this.gbxRace = new System.Windows.Forms.GroupBox();
            this.lblRaceHuman = new System.Windows.Forms.Label();
            this.lblRaceGnome = new System.Windows.Forms.Label();
            this.lblRaceDwarf = new System.Windows.Forms.Label();
            this.btnDwarf = new System.Windows.Forms.Button();
            this.btnGnome = new System.Windows.Forms.Button();
            this.btnElf = new System.Windows.Forms.Button();
            this.btnHuman = new System.Windows.Forms.Button();
            this.lblRaceElf = new System.Windows.Forms.Label();
            this.gbxClass = new System.Windows.Forms.GroupBox();
            this.lblClassFighter = new System.Windows.Forms.Label();
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.btnFighter = new System.Windows.Forms.Button();
            this.lblClassWizard = new System.Windows.Forms.Label();
            this.lblClassRogue = new System.Windows.Forms.Label();
            this.imageListPortraitsMale = new System.Windows.Forms.ImageList(this.components);
            this.gbxPortraits = new System.Windows.Forms.GroupBox();
            this.panelPortraits = new System.Windows.Forms.Panel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.imageListPortraitsFemale = new System.Windows.Forms.ImageList(this.components);
            this.gbxPackage = new System.Windows.Forms.GroupBox();
            this.btnPackageNext = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblGRC = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.gbxCustomize = new System.Windows.Forms.GroupBox();
            this.btnGenerateLastName = new System.Windows.Forms.Button();
            this.btnGenerateFirstName = new System.Windows.Forms.Button();
            this.btnConfirmCharacter = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pbxPlayerPortrait = new System.Windows.Forms.PictureBox();
            this.gbxPlayerSheet = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModifierDmg = new System.Windows.Forms.Label();
            this.lblPlayerBaseAttack = new System.Windows.Forms.Label();
            this.lblWeaponDmg = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lblWeaponCritical = new System.Windows.Forms.Label();
            this.lblPlayerAttackBonus = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lblPlayerWill = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblPlayerReflex = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblPlayerFortitude = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lblPlayerNextLvlXp = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblPlayerCurrentXp = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblPlayerLvl = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblPlayerMaxHp = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblPlayerAC = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblPlayerClass = new System.Windows.Forms.Label();
            this.lblPlayerRace = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblPlayerChaM = new System.Windows.Forms.Label();
            this.lblPlayerCha = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblPlayerIntM = new System.Windows.Forms.Label();
            this.lblPlayerInt = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblPlayerWisM = new System.Windows.Forms.Label();
            this.lblPlayerWis = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPlayerDexM = new System.Windows.Forms.Label();
            this.lblPlayerDex = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblPlayerConM = new System.Windows.Forms.Label();
            this.lblPlayerCon = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPlayerStrM = new System.Windows.Forms.Label();
            this.lblPlayerStr = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.gbxWolf = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.lblWolfHp = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.gbxFireBeelte = new System.Windows.Forms.GroupBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label98 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.lblFBHp = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.lblFBInt = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.label109 = new System.Windows.Forms.Label();
            this.lblFBWis = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.lblFBDexM = new System.Windows.Forms.Label();
            this.lblFBDex = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.lblFBConM = new System.Windows.Forms.Label();
            this.lblFBCon = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.lblFBStrM = new System.Windows.Forms.Label();
            this.lblFBStr = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.gbxMonsters = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label163 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.txtDragonCounter = new System.Windows.Forms.TextBox();
            this.txtBearCounter = new System.Windows.Forms.TextBox();
            this.txtWolfCounter = new System.Windows.Forms.TextBox();
            this.txtBeetleCounter = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.btnRemoveMonster = new System.Windows.Forms.Button();
            this.btnSpawn = new System.Windows.Forms.Button();
            this.label122 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.rbtnDragon = new System.Windows.Forms.RadioButton();
            this.rbtnDireBear = new System.Windows.Forms.RadioButton();
            this.rbtnWolf = new System.Windows.Forms.RadioButton();
            this.rbtnFireBeetle = new System.Windows.Forms.RadioButton();
            this.gbxFight = new System.Windows.Forms.GroupBox();
            this.label225 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.txtFight1 = new System.Windows.Forms.RichTextBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnLightHeal = new System.Windows.Forms.Button();
            this.gbxLvlUp = new System.Windows.Forms.GroupBox();
            this.label212 = new System.Windows.Forms.Label();
            this.btnLvlUpConfirm = new System.Windows.Forms.Button();
            this.txtLvlUp = new System.Windows.Forms.TextBox();
            this.rbtnChaUp = new System.Windows.Forms.RadioButton();
            this.rbtnWisUp = new System.Windows.Forms.RadioButton();
            this.rbtnIntUp = new System.Windows.Forms.RadioButton();
            this.rbtnConUp = new System.Windows.Forms.RadioButton();
            this.rbtnDexUp = new System.Windows.Forms.RadioButton();
            this.rbtnStrUp = new System.Windows.Forms.RadioButton();
            this.label107 = new System.Windows.Forms.Label();
            this.gbxDireBear = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label156 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.lblBearHp = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.gbxInventory = new System.Windows.Forms.GroupBox();
            this.gbxInvProperties = new System.Windows.Forms.GroupBox();
            this.label165 = new System.Windows.Forms.Label();
            this.picBoxInv = new System.Windows.Forms.PictureBox();
            this.picBoxGreatsword = new System.Windows.Forms.PictureBox();
            this.picBoxBastardsword = new System.Windows.Forms.PictureBox();
            this.picBoxLongsword = new System.Windows.Forms.PictureBox();
            this.picBoxShortsword = new System.Windows.Forms.PictureBox();
            this.txtInvBonusAc = new System.Windows.Forms.TextBox();
            this.lblInvBonusAc = new System.Windows.Forms.Label();
            this.lblInvName = new System.Windows.Forms.Label();
            this.lblInvDmgOrArm = new System.Windows.Forms.Label();
            this.txtInv = new System.Windows.Forms.TextBox();
            this.rtxtInv = new System.Windows.Forms.RichTextBox();
            this.groupBox50 = new System.Windows.Forms.GroupBox();
            this.label173 = new System.Windows.Forms.Label();
            this.lbxAC = new System.Windows.Forms.ListBox();
            this.lbxInvWeapon = new System.Windows.Forms.ListBox();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.lblInvNecklace = new System.Windows.Forms.Label();
            this.lblInvBoots = new System.Windows.Forms.Label();
            this.lblInvHelmet = new System.Windows.Forms.Label();
            this.lblInvArmor = new System.Windows.Forms.Label();
            this.lblInvWeapon = new System.Windows.Forms.Label();
            this.txtInvGold = new System.Windows.Forms.TextBox();
            this.label172 = new System.Windows.Forms.Label();
            this.lblInvN = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.lblInvB = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.lblInvH = new System.Windows.Forms.Label();
            this.lblInvA = new System.Windows.Forms.Label();
            this.lblInvW = new System.Windows.Forms.Label();
            this.lbxArmor = new System.Windows.Forms.ListBox();
            this.lbxHelmet = new System.Windows.Forms.ListBox();
            this.lbxBoots = new System.Windows.Forms.ListBox();
            this.lbxNecklace = new System.Windows.Forms.ListBox();
            this.imageListArmors = new System.Windows.Forms.ImageList(this.components);
            this.imageListBootsAndHelmetsAndNecklaces = new System.Windows.Forms.ImageList(this.components);
            this.btnResetHero = new System.Windows.Forms.Button();
            this.gbxDragon = new System.Windows.Forms.GroupBox();
            this.groupBox52 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label210 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.groupBox53 = new System.Windows.Forms.GroupBox();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.groupBox54 = new System.Windows.Forms.GroupBox();
            this.lblDragonHp = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.groupBox55 = new System.Windows.Forms.GroupBox();
            this.label192 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.groupBox56 = new System.Windows.Forms.GroupBox();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.groupBox57 = new System.Windows.Forms.GroupBox();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.groupBox58 = new System.Windows.Forms.GroupBox();
            this.label201 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.groupBox59 = new System.Windows.Forms.GroupBox();
            this.label204 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.groupBox60 = new System.Windows.Forms.GroupBox();
            this.label207 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.groupBox61 = new System.Windows.Forms.GroupBox();
            this.groupBox62 = new System.Windows.Forms.GroupBox();
            this.lblGoldMessage = new System.Windows.Forms.Label();
            this.gbxPotions = new System.Windows.Forms.GroupBox();
            this.label211 = new System.Windows.Forms.Label();
            this.txtHeal50 = new System.Windows.Forms.TextBox();
            this.btnHeal50 = new System.Windows.Forms.Button();
            this.label187 = new System.Windows.Forms.Label();
            this.txtHeal10 = new System.Windows.Forms.TextBox();
            this.btnHeal10 = new System.Windows.Forms.Button();
            this.label164 = new System.Windows.Forms.Label();
            this.txtHeal2 = new System.Windows.Forms.TextBox();
            this.lblMinusHeal2 = new System.Windows.Forms.Label();
            this.lblHeal2 = new System.Windows.Forms.Label();
            this.lblMinusHeal10 = new System.Windows.Forms.Label();
            this.lblHeal10 = new System.Windows.Forms.Label();
            this.lblMinusHeal50 = new System.Windows.Forms.Label();
            this.lblHeal50 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.gbxShop = new System.Windows.Forms.GroupBox();
            this.panelShop = new System.Windows.Forms.Panel();
            this.label224 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.picBoxShopNecklace8 = new System.Windows.Forms.PictureBox();
            this.label222 = new System.Windows.Forms.Label();
            this.picBoxShopNecklace5 = new System.Windows.Forms.PictureBox();
            this.label221 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.picBoxShopWingHelm = new System.Windows.Forms.PictureBox();
            this.picBoxShopStagHelm = new System.Windows.Forms.PictureBox();
            this.picBoxShopBoots5 = new System.Windows.Forms.PictureBox();
            this.picBoxShopBoots3 = new System.Windows.Forms.PictureBox();
            this.picBoxShopHalfPlate = new System.Windows.Forms.PictureBox();
            this.picBoxShopChainmail = new System.Windows.Forms.PictureBox();
            this.picBoxShopChainShirt = new System.Windows.Forms.PictureBox();
            this.label214 = new System.Windows.Forms.Label();
            this.picBoxShopBastardSword = new System.Windows.Forms.PictureBox();
            this.label213 = new System.Windows.Forms.Label();
            this.picBoxShopLongsword = new System.Windows.Forms.PictureBox();
            this.btnGoldPlus = new System.Windows.Forms.Button();
            this.btnXPPlus = new System.Windows.Forms.Button();
            this.gbxAbilities.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxNewCharacter.SuspendLayout();
            this.gbxGender.SuspendLayout();
            this.gbxRace.SuspendLayout();
            this.gbxClass.SuspendLayout();
            this.gbxPortraits.SuspendLayout();
            this.panelPortraits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxPackage.SuspendLayout();
            this.gbxCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerPortrait)).BeginInit();
            this.gbxPlayerSheet.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxWolf.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            this.gbxFireBeelte.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.gbxMonsters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxFight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbxLvlUp.SuspendLayout();
            this.gbxDireBear.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox41.SuspendLayout();
            this.groupBox42.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox45.SuspendLayout();
            this.groupBox46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.gbxInventory.SuspendLayout();
            this.gbxInvProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreatsword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBastardsword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLongsword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShortsword)).BeginInit();
            this.groupBox50.SuspendLayout();
            this.groupBox49.SuspendLayout();
            this.gbxDragon.SuspendLayout();
            this.groupBox52.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox53.SuspendLayout();
            this.groupBox54.SuspendLayout();
            this.groupBox55.SuspendLayout();
            this.groupBox56.SuspendLayout();
            this.groupBox57.SuspendLayout();
            this.groupBox58.SuspendLayout();
            this.groupBox59.SuspendLayout();
            this.groupBox60.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.gbxPotions.SuspendLayout();
            this.gbxShop.SuspendLayout();
            this.panelShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopNecklace8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopNecklace5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopWingHelm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopStagHelm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBoots5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBoots3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopHalfPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopChainmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopChainShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBastardSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopLongsword)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAbilities
            // 
            this.gbxAbilities.Controls.Add(this.lblStillPoints);
            this.gbxAbilities.Controls.Add(this.btnAbilitiesNext);
            this.gbxAbilities.Controls.Add(this.button1);
            this.gbxAbilities.Controls.Add(this.btnReset);
            this.gbxAbilities.Controls.Add(this.groupBox4);
            this.gbxAbilities.Controls.Add(this.lblCha);
            this.gbxAbilities.Controls.Add(this.lblWis);
            this.gbxAbilities.Controls.Add(this.lblInt);
            this.gbxAbilities.Controls.Add(this.lblPoints);
            this.gbxAbilities.Controls.Add(this.label10);
            this.gbxAbilities.Controls.Add(this.txtPointM);
            this.gbxAbilities.Controls.Add(this.txtPoints);
            this.gbxAbilities.Controls.Add(this.label9);
            this.gbxAbilities.Controls.Add(this.btnChaDec);
            this.gbxAbilities.Controls.Add(this.btnWisDec);
            this.gbxAbilities.Controls.Add(this.btnIntDec);
            this.gbxAbilities.Controls.Add(this.btnConDec);
            this.gbxAbilities.Controls.Add(this.btnDexDec);
            this.gbxAbilities.Controls.Add(this.btnStrDec);
            this.gbxAbilities.Controls.Add(this.btnChaInc);
            this.gbxAbilities.Controls.Add(this.btnWisInc);
            this.gbxAbilities.Controls.Add(this.btnIntInc);
            this.gbxAbilities.Controls.Add(this.btnConInc);
            this.gbxAbilities.Controls.Add(this.btnDexInc);
            this.gbxAbilities.Controls.Add(this.btnStrInc);
            this.gbxAbilities.Controls.Add(this.txtChaM);
            this.gbxAbilities.Controls.Add(this.txtWisM);
            this.gbxAbilities.Controls.Add(this.txtIntM);
            this.gbxAbilities.Controls.Add(this.txtConM);
            this.gbxAbilities.Controls.Add(this.txtDexM);
            this.gbxAbilities.Controls.Add(this.txtStrM);
            this.gbxAbilities.Controls.Add(this.label8);
            this.gbxAbilities.Controls.Add(this.label7);
            this.gbxAbilities.Controls.Add(this.txtCha);
            this.gbxAbilities.Controls.Add(this.txtWis);
            this.gbxAbilities.Controls.Add(this.txtInt);
            this.gbxAbilities.Controls.Add(this.txtCon);
            this.gbxAbilities.Controls.Add(this.txtDex);
            this.gbxAbilities.Controls.Add(this.txtStr);
            this.gbxAbilities.Controls.Add(this.label6);
            this.gbxAbilities.Controls.Add(this.label5);
            this.gbxAbilities.Controls.Add(this.label4);
            this.gbxAbilities.Controls.Add(this.label3);
            this.gbxAbilities.Controls.Add(this.label2);
            this.gbxAbilities.Controls.Add(this.label1);
            this.gbxAbilities.Controls.Add(this.lblCon);
            this.gbxAbilities.Controls.Add(this.lblDex);
            this.gbxAbilities.Controls.Add(this.lblStr);
            this.gbxAbilities.Location = new System.Drawing.Point(195, 59);
            this.gbxAbilities.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAbilities.Name = "gbxAbilities";
            this.gbxAbilities.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAbilities.Size = new System.Drawing.Size(583, 478);
            this.gbxAbilities.TabIndex = 5;
            this.gbxAbilities.TabStop = false;
            this.gbxAbilities.Visible = false;
            // 
            // lblStillPoints
            // 
            this.lblStillPoints.AutoSize = true;
            this.lblStillPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStillPoints.Location = new System.Drawing.Point(24, 406);
            this.lblStillPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStillPoints.Name = "lblStillPoints";
            this.lblStillPoints.Size = new System.Drawing.Size(263, 20);
            this.lblStillPoints.TabIndex = 47;
            this.lblStillPoints.Text = "You still have points to spend!";
            this.lblStillPoints.Visible = false;
            // 
            // btnAbilitiesNext
            // 
            this.btnAbilitiesNext.Location = new System.Drawing.Point(329, 358);
            this.btnAbilitiesNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbilitiesNext.Name = "btnAbilitiesNext";
            this.btnAbilitiesNext.Size = new System.Drawing.Size(55, 34);
            this.btnAbilitiesNext.TabIndex = 46;
            this.btnAbilitiesNext.Text = "Next";
            this.btnAbilitiesNext.UseVisualStyleBackColor = true;
            this.btnAbilitiesNext.Click += new System.EventHandler(this.btnAbilitiesNext_Click);
            this.btnAbilitiesNext.MouseLeave += new System.EventHandler(this.btnAbilitiesNext_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Recommended";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(511, 358);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 34);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWill);
            this.groupBox4.Controls.Add(this.txtReflex);
            this.groupBox4.Controls.Add(this.txtFortitude);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtDmg);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtAB);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtBA);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtHP);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtAC);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(324, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(248, 315);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "First Level Stats:";
            // 
            // txtWill
            // 
            this.txtWill.Location = new System.Drawing.Point(109, 279);
            this.txtWill.Margin = new System.Windows.Forms.Padding(4);
            this.txtWill.Name = "txtWill";
            this.txtWill.ReadOnly = true;
            this.txtWill.Size = new System.Drawing.Size(33, 22);
            this.txtWill.TabIndex = 29;
            this.txtWill.Text = "-1";
            // 
            // txtReflex
            // 
            this.txtReflex.Location = new System.Drawing.Point(109, 240);
            this.txtReflex.Margin = new System.Windows.Forms.Padding(4);
            this.txtReflex.Name = "txtReflex";
            this.txtReflex.ReadOnly = true;
            this.txtReflex.Size = new System.Drawing.Size(33, 22);
            this.txtReflex.TabIndex = 28;
            this.txtReflex.Text = "-1";
            // 
            // txtFortitude
            // 
            this.txtFortitude.Location = new System.Drawing.Point(109, 199);
            this.txtFortitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtFortitude.Name = "txtFortitude";
            this.txtFortitude.ReadOnly = true;
            this.txtFortitude.Size = new System.Drawing.Size(33, 22);
            this.txtFortitude.TabIndex = 27;
            this.txtFortitude.Text = "-1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 283);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Will:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 244);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Reflex:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 203);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Fortitude:";
            // 
            // txtDmg
            // 
            this.txtDmg.Location = new System.Drawing.Point(109, 158);
            this.txtDmg.Margin = new System.Windows.Forms.Padding(4);
            this.txtDmg.Name = "txtDmg";
            this.txtDmg.ReadOnly = true;
            this.txtDmg.Size = new System.Drawing.Size(64, 22);
            this.txtDmg.TabIndex = 23;
            this.txtDmg.Text = "-1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Damage:";
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(109, 112);
            this.txtAB.Margin = new System.Windows.Forms.Padding(4);
            this.txtAB.Name = "txtAB";
            this.txtAB.ReadOnly = true;
            this.txtAB.Size = new System.Drawing.Size(33, 22);
            this.txtAB.TabIndex = 21;
            this.txtAB.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Attack Bonus:";
            // 
            // txtBA
            // 
            this.txtBA.Location = new System.Drawing.Point(109, 70);
            this.txtBA.Margin = new System.Windows.Forms.Padding(4);
            this.txtBA.Name = "txtBA";
            this.txtBA.ReadOnly = true;
            this.txtBA.Size = new System.Drawing.Size(33, 22);
            this.txtBA.TabIndex = 19;
            this.txtBA.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Base Attack:";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(181, 32);
            this.txtHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP.Name = "txtHP";
            this.txtHP.ReadOnly = true;
            this.txtHP.Size = new System.Drawing.Size(33, 22);
            this.txtHP.TabIndex = 17;
            this.txtHP.Text = "9";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hit Points";
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(44, 32);
            this.txtAC.Margin = new System.Windows.Forms.Padding(4);
            this.txtAC.Name = "txtAC";
            this.txtAC.ReadOnly = true;
            this.txtAC.Size = new System.Drawing.Size(33, 22);
            this.txtAC.TabIndex = 15;
            this.txtAC.Text = "9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "AC";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(24, 406);
            this.lblCha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(546, 68);
            this.lblCha.TabIndex = 42;
            this.lblCha.Text = resources.GetString("lblCha.Text");
            this.lblCha.Visible = false;
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(24, 406);
            this.lblWis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(555, 68);
            this.lblWis.TabIndex = 41;
            this.lblWis.Text = resources.GetString("lblWis.Text");
            this.lblWis.Visible = false;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(24, 406);
            this.lblInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(551, 68);
            this.lblInt.TabIndex = 40;
            this.lblInt.Text = resources.GetString("lblInt.Text");
            this.lblInt.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(24, 362);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(261, 40);
            this.lblPoints.TabIndex = 36;
            this.lblPoints.Text = "You don\'t have enough points \r\nto spend!";
            this.lblPoints.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 34);
            this.label10.TabIndex = 35;
            this.label10.Text = "Cost to\r\nincrease";
            // 
            // txtPointM
            // 
            this.txtPointM.Location = new System.Drawing.Point(264, 326);
            this.txtPointM.Margin = new System.Windows.Forms.Padding(4);
            this.txtPointM.Name = "txtPointM";
            this.txtPointM.ReadOnly = true;
            this.txtPointM.Size = new System.Drawing.Size(33, 22);
            this.txtPointM.TabIndex = 34;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(28, 326);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(33, 22);
            this.txtPoints.TabIndex = 33;
            this.txtPoints.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 34);
            this.label9.TabIndex = 32;
            this.label9.Text = "Points to \r\nspend";
            // 
            // btnChaDec
            // 
            this.btnChaDec.Enabled = false;
            this.btnChaDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaDec.Location = new System.Drawing.Point(283, 277);
            this.btnChaDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnChaDec.Name = "btnChaDec";
            this.btnChaDec.Size = new System.Drawing.Size(24, 22);
            this.btnChaDec.TabIndex = 31;
            this.btnChaDec.Text = "-";
            this.btnChaDec.UseVisualStyleBackColor = true;
            this.btnChaDec.Click += new System.EventHandler(this.button1_Click_1);
            this.btnChaDec.MouseLeave += new System.EventHandler(this.btnChaDec_MouseLeave);
            this.btnChaDec.MouseHover += new System.EventHandler(this.btnChaDec_MouseHover);
            // 
            // btnWisDec
            // 
            this.btnWisDec.Enabled = false;
            this.btnWisDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWisDec.Location = new System.Drawing.Point(283, 235);
            this.btnWisDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnWisDec.Name = "btnWisDec";
            this.btnWisDec.Size = new System.Drawing.Size(24, 22);
            this.btnWisDec.TabIndex = 30;
            this.btnWisDec.Text = "-";
            this.btnWisDec.UseVisualStyleBackColor = true;
            this.btnWisDec.Click += new System.EventHandler(this.button2_Click_1);
            this.btnWisDec.MouseLeave += new System.EventHandler(this.btnWisDec_MouseLeave);
            this.btnWisDec.MouseHover += new System.EventHandler(this.btnWisDec_MouseHover);
            // 
            // btnIntDec
            // 
            this.btnIntDec.Enabled = false;
            this.btnIntDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntDec.Location = new System.Drawing.Point(283, 193);
            this.btnIntDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnIntDec.Name = "btnIntDec";
            this.btnIntDec.Size = new System.Drawing.Size(24, 22);
            this.btnIntDec.TabIndex = 29;
            this.btnIntDec.Text = "-";
            this.btnIntDec.UseVisualStyleBackColor = true;
            this.btnIntDec.Click += new System.EventHandler(this.button3_Click_1);
            this.btnIntDec.MouseLeave += new System.EventHandler(this.btnIntDec_MouseLeave);
            this.btnIntDec.MouseHover += new System.EventHandler(this.btnIntDec_MouseHover);
            // 
            // btnConDec
            // 
            this.btnConDec.Enabled = false;
            this.btnConDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConDec.Location = new System.Drawing.Point(283, 151);
            this.btnConDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnConDec.Name = "btnConDec";
            this.btnConDec.Size = new System.Drawing.Size(24, 22);
            this.btnConDec.TabIndex = 28;
            this.btnConDec.Text = "-";
            this.btnConDec.UseVisualStyleBackColor = true;
            this.btnConDec.Click += new System.EventHandler(this.button4_Click_1);
            this.btnConDec.MouseLeave += new System.EventHandler(this.btnConDec_MouseLeave);
            this.btnConDec.MouseHover += new System.EventHandler(this.btnConDec_MouseHover);
            // 
            // btnDexDec
            // 
            this.btnDexDec.Enabled = false;
            this.btnDexDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDexDec.Location = new System.Drawing.Point(283, 110);
            this.btnDexDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnDexDec.Name = "btnDexDec";
            this.btnDexDec.Size = new System.Drawing.Size(24, 22);
            this.btnDexDec.TabIndex = 27;
            this.btnDexDec.Text = "-";
            this.btnDexDec.UseVisualStyleBackColor = true;
            this.btnDexDec.Click += new System.EventHandler(this.button5_Click_1);
            this.btnDexDec.MouseLeave += new System.EventHandler(this.btnDexDec_MouseLeave);
            this.btnDexDec.MouseHover += new System.EventHandler(this.btnDexDec_MouseHover);
            // 
            // btnStrDec
            // 
            this.btnStrDec.Enabled = false;
            this.btnStrDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrDec.Location = new System.Drawing.Point(283, 68);
            this.btnStrDec.Margin = new System.Windows.Forms.Padding(0);
            this.btnStrDec.Name = "btnStrDec";
            this.btnStrDec.Size = new System.Drawing.Size(24, 22);
            this.btnStrDec.TabIndex = 26;
            this.btnStrDec.Text = "-";
            this.btnStrDec.UseVisualStyleBackColor = true;
            this.btnStrDec.Click += new System.EventHandler(this.button6_Click_1);
            this.btnStrDec.MouseLeave += new System.EventHandler(this.btnStrDec_MouseLeave);
            this.btnStrDec.MouseHover += new System.EventHandler(this.btnStrDec_MouseHover);
            // 
            // btnChaInc
            // 
            this.btnChaInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaInc.Location = new System.Drawing.Point(259, 277);
            this.btnChaInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnChaInc.Name = "btnChaInc";
            this.btnChaInc.Size = new System.Drawing.Size(24, 22);
            this.btnChaInc.TabIndex = 25;
            this.btnChaInc.Text = "+";
            this.btnChaInc.UseVisualStyleBackColor = true;
            this.btnChaInc.Click += new System.EventHandler(this.button6_Click);
            this.btnChaInc.MouseLeave += new System.EventHandler(this.btnChaInc_MouseLeave);
            this.btnChaInc.MouseHover += new System.EventHandler(this.btnChaInc_MouseHover);
            // 
            // btnWisInc
            // 
            this.btnWisInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWisInc.Location = new System.Drawing.Point(259, 235);
            this.btnWisInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnWisInc.Name = "btnWisInc";
            this.btnWisInc.Size = new System.Drawing.Size(24, 22);
            this.btnWisInc.TabIndex = 24;
            this.btnWisInc.Text = "+";
            this.btnWisInc.UseVisualStyleBackColor = true;
            this.btnWisInc.Click += new System.EventHandler(this.button5_Click);
            this.btnWisInc.MouseLeave += new System.EventHandler(this.btnWisInc_MouseLeave);
            this.btnWisInc.MouseHover += new System.EventHandler(this.btnWisInc_MouseHover);
            // 
            // btnIntInc
            // 
            this.btnIntInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntInc.Location = new System.Drawing.Point(259, 193);
            this.btnIntInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnIntInc.Name = "btnIntInc";
            this.btnIntInc.Size = new System.Drawing.Size(24, 22);
            this.btnIntInc.TabIndex = 23;
            this.btnIntInc.Text = "+";
            this.btnIntInc.UseVisualStyleBackColor = true;
            this.btnIntInc.Click += new System.EventHandler(this.button4_Click);
            this.btnIntInc.MouseLeave += new System.EventHandler(this.btnIntInc_MouseLeave);
            this.btnIntInc.MouseHover += new System.EventHandler(this.btnIntInc_MouseHover);
            // 
            // btnConInc
            // 
            this.btnConInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConInc.Location = new System.Drawing.Point(259, 151);
            this.btnConInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnConInc.Name = "btnConInc";
            this.btnConInc.Size = new System.Drawing.Size(24, 22);
            this.btnConInc.TabIndex = 22;
            this.btnConInc.Text = "+";
            this.btnConInc.UseVisualStyleBackColor = true;
            this.btnConInc.Click += new System.EventHandler(this.button3_Click);
            this.btnConInc.MouseLeave += new System.EventHandler(this.btnConInc_MouseLeave);
            this.btnConInc.MouseHover += new System.EventHandler(this.btnConInc_MouseHover);
            // 
            // btnDexInc
            // 
            this.btnDexInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDexInc.Location = new System.Drawing.Point(259, 110);
            this.btnDexInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnDexInc.Name = "btnDexInc";
            this.btnDexInc.Size = new System.Drawing.Size(24, 22);
            this.btnDexInc.TabIndex = 21;
            this.btnDexInc.Text = "+";
            this.btnDexInc.UseVisualStyleBackColor = true;
            this.btnDexInc.Click += new System.EventHandler(this.button2_Click);
            this.btnDexInc.MouseLeave += new System.EventHandler(this.btnDexInc_MouseLeave);
            this.btnDexInc.MouseHover += new System.EventHandler(this.btnDexInc_MouseHover);
            // 
            // btnStrInc
            // 
            this.btnStrInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrInc.Location = new System.Drawing.Point(259, 68);
            this.btnStrInc.Margin = new System.Windows.Forms.Padding(0);
            this.btnStrInc.Name = "btnStrInc";
            this.btnStrInc.Size = new System.Drawing.Size(24, 22);
            this.btnStrInc.TabIndex = 20;
            this.btnStrInc.Text = "+";
            this.btnStrInc.UseVisualStyleBackColor = true;
            this.btnStrInc.Click += new System.EventHandler(this.button1_Click);
            this.btnStrInc.MouseLeave += new System.EventHandler(this.btnStrInc_MouseLeave);
            this.btnStrInc.MouseHover += new System.EventHandler(this.btnStrInc_MouseHover);
            // 
            // txtChaM
            // 
            this.txtChaM.Location = new System.Drawing.Point(220, 277);
            this.txtChaM.Margin = new System.Windows.Forms.Padding(4);
            this.txtChaM.Name = "txtChaM";
            this.txtChaM.ReadOnly = true;
            this.txtChaM.Size = new System.Drawing.Size(33, 22);
            this.txtChaM.TabIndex = 19;
            this.txtChaM.Text = "-1";
            // 
            // txtWisM
            // 
            this.txtWisM.Location = new System.Drawing.Point(220, 235);
            this.txtWisM.Margin = new System.Windows.Forms.Padding(4);
            this.txtWisM.Name = "txtWisM";
            this.txtWisM.ReadOnly = true;
            this.txtWisM.Size = new System.Drawing.Size(33, 22);
            this.txtWisM.TabIndex = 18;
            this.txtWisM.Text = "-1";
            this.txtWisM.TextChanged += new System.EventHandler(this.txtWisM_TextChanged);
            // 
            // txtIntM
            // 
            this.txtIntM.Location = new System.Drawing.Point(220, 193);
            this.txtIntM.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntM.Name = "txtIntM";
            this.txtIntM.ReadOnly = true;
            this.txtIntM.Size = new System.Drawing.Size(33, 22);
            this.txtIntM.TabIndex = 17;
            this.txtIntM.Text = "-1";
            // 
            // txtConM
            // 
            this.txtConM.Location = new System.Drawing.Point(220, 151);
            this.txtConM.Margin = new System.Windows.Forms.Padding(4);
            this.txtConM.Name = "txtConM";
            this.txtConM.ReadOnly = true;
            this.txtConM.Size = new System.Drawing.Size(33, 22);
            this.txtConM.TabIndex = 16;
            this.txtConM.Text = "-1";
            this.txtConM.TextChanged += new System.EventHandler(this.txtConM_TextChanged);
            // 
            // txtDexM
            // 
            this.txtDexM.Location = new System.Drawing.Point(220, 110);
            this.txtDexM.Margin = new System.Windows.Forms.Padding(4);
            this.txtDexM.Name = "txtDexM";
            this.txtDexM.ReadOnly = true;
            this.txtDexM.Size = new System.Drawing.Size(33, 22);
            this.txtDexM.TabIndex = 15;
            this.txtDexM.Text = "-1";
            this.txtDexM.TextChanged += new System.EventHandler(this.txtDexM_TextChanged);
            // 
            // txtStrM
            // 
            this.txtStrM.Location = new System.Drawing.Point(220, 68);
            this.txtStrM.Margin = new System.Windows.Forms.Padding(4);
            this.txtStrM.Name = "txtStrM";
            this.txtStrM.ReadOnly = true;
            this.txtStrM.Size = new System.Drawing.Size(33, 22);
            this.txtStrM.TabIndex = 14;
            this.txtStrM.Text = "-1";
            this.txtStrM.TextChanged += new System.EventHandler(this.txtStrM_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attribute \r\nModifiers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Attributes";
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(135, 277);
            this.txtCha.Margin = new System.Windows.Forms.Padding(4);
            this.txtCha.Name = "txtCha";
            this.txtCha.ReadOnly = true;
            this.txtCha.Size = new System.Drawing.Size(33, 22);
            this.txtCha.TabIndex = 11;
            this.txtCha.Text = "8";
            this.txtCha.TextChanged += new System.EventHandler(this.txtCha_TextChanged);
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(135, 235);
            this.txtWis.Margin = new System.Windows.Forms.Padding(4);
            this.txtWis.Name = "txtWis";
            this.txtWis.ReadOnly = true;
            this.txtWis.Size = new System.Drawing.Size(33, 22);
            this.txtWis.TabIndex = 10;
            this.txtWis.Text = "8";
            this.txtWis.TextChanged += new System.EventHandler(this.txtWis_TextChanged);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(135, 193);
            this.txtInt.Margin = new System.Windows.Forms.Padding(4);
            this.txtInt.Name = "txtInt";
            this.txtInt.ReadOnly = true;
            this.txtInt.Size = new System.Drawing.Size(33, 22);
            this.txtInt.TabIndex = 9;
            this.txtInt.Text = "8";
            this.txtInt.TextChanged += new System.EventHandler(this.txtInt_TextChanged);
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(135, 151);
            this.txtCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(33, 22);
            this.txtCon.TabIndex = 8;
            this.txtCon.Text = "8";
            this.txtCon.TextChanged += new System.EventHandler(this.txtCon_TextChanged);
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(135, 110);
            this.txtDex.Margin = new System.Windows.Forms.Padding(4);
            this.txtDex.Name = "txtDex";
            this.txtDex.ReadOnly = true;
            this.txtDex.Size = new System.Drawing.Size(33, 22);
            this.txtDex.TabIndex = 7;
            this.txtDex.Text = "8";
            this.txtDex.TextChanged += new System.EventHandler(this.txtDex_TextChanged);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(135, 68);
            this.txtStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtStr.Name = "txtStr";
            this.txtStr.ReadOnly = true;
            this.txtStr.Size = new System.Drawing.Size(33, 22);
            this.txtStr.TabIndex = 6;
            this.txtStr.Text = "8";
            this.txtStr.TextChanged += new System.EventHandler(this.txtStr_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wisdom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelligence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Constitution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(24, 406);
            this.lblCon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(525, 68);
            this.lblCon.TabIndex = 39;
            this.lblCon.Text = resources.GetString("lblCon.Text");
            this.lblCon.Visible = false;
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(24, 406);
            this.lblDex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(523, 51);
            this.lblDex.TabIndex = 38;
            this.lblDex.Text = resources.GetString("lblDex.Text");
            this.lblDex.Visible = false;
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(24, 406);
            this.lblStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(526, 68);
            this.lblStr.TabIndex = 37;
            this.lblStr.Text = resources.GetString("lblStr.Text");
            this.lblStr.Visible = false;
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Location = new System.Drawing.Point(13, 16);
            this.btnNewCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(153, 37);
            this.btnNewCharacter.TabIndex = 1;
            this.btnNewCharacter.TabStop = false;
            this.btnNewCharacter.Text = "New character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // gbxNewCharacter
            // 
            this.gbxNewCharacter.Controls.Add(this.btnCustomize);
            this.gbxNewCharacter.Controls.Add(this.btnPackage);
            this.gbxNewCharacter.Controls.Add(this.btnAbilities);
            this.gbxNewCharacter.Controls.Add(this.btnPortrait);
            this.gbxNewCharacter.Controls.Add(this.btnClass);
            this.gbxNewCharacter.Controls.Add(this.btnRace);
            this.gbxNewCharacter.Controls.Add(this.btnGender);
            this.gbxNewCharacter.Location = new System.Drawing.Point(16, 59);
            this.gbxNewCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.gbxNewCharacter.Name = "gbxNewCharacter";
            this.gbxNewCharacter.Padding = new System.Windows.Forms.Padding(4);
            this.gbxNewCharacter.Size = new System.Drawing.Size(129, 325);
            this.gbxNewCharacter.TabIndex = 6;
            this.gbxNewCharacter.TabStop = false;
            this.gbxNewCharacter.Visible = false;
            // 
            // btnCustomize
            // 
            this.btnCustomize.Location = new System.Drawing.Point(17, 273);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(95, 36);
            this.btnCustomize.TabIndex = 13;
            this.btnCustomize.Text = "Customize";
            this.btnCustomize.UseVisualStyleBackColor = true;
            this.btnCustomize.Visible = false;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(17, 230);
            this.btnPackage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(95, 36);
            this.btnPackage.TabIndex = 12;
            this.btnPackage.Text = "Package";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Visible = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnAbilities
            // 
            this.btnAbilities.Location = new System.Drawing.Point(17, 187);
            this.btnAbilities.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbilities.Name = "btnAbilities";
            this.btnAbilities.Size = new System.Drawing.Size(95, 36);
            this.btnAbilities.TabIndex = 11;
            this.btnAbilities.Text = "Abilities";
            this.btnAbilities.UseVisualStyleBackColor = true;
            this.btnAbilities.Visible = false;
            this.btnAbilities.Click += new System.EventHandler(this.btnAbilities_Click);
            // 
            // btnPortrait
            // 
            this.btnPortrait.Location = new System.Drawing.Point(17, 144);
            this.btnPortrait.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortrait.Name = "btnPortrait";
            this.btnPortrait.Size = new System.Drawing.Size(95, 36);
            this.btnPortrait.TabIndex = 10;
            this.btnPortrait.Text = "Portrait";
            this.btnPortrait.UseVisualStyleBackColor = true;
            this.btnPortrait.Visible = false;
            this.btnPortrait.Click += new System.EventHandler(this.btnPortrait_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(17, 100);
            this.btnClass.Margin = new System.Windows.Forms.Padding(4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(95, 36);
            this.btnClass.TabIndex = 9;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Visible = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(17, 55);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(95, 36);
            this.btnRace.TabIndex = 8;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Visible = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnGender
            // 
            this.btnGender.Location = new System.Drawing.Point(17, 12);
            this.btnGender.Margin = new System.Windows.Forms.Padding(4);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(95, 36);
            this.btnGender.TabIndex = 7;
            this.btnGender.Text = "Gender";
            this.btnGender.UseVisualStyleBackColor = true;
            this.btnGender.Click += new System.EventHandler(this.btnGender_Click);
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.label19);
            this.gbxGender.Controls.Add(this.btnFemale);
            this.gbxGender.Controls.Add(this.btnMale);
            this.gbxGender.Location = new System.Drawing.Point(195, 59);
            this.gbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGender.Size = new System.Drawing.Size(233, 123);
            this.gbxGender.TabIndex = 7;
            this.gbxGender.TabStop = false;
            this.gbxGender.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(217, 51);
            this.label19.TabIndex = 10;
            this.label19.Text = "There is no difference in abilities \r\nor performance when choosing \r\nmale or fema" +
    "le character.";
            // 
            // btnFemale
            // 
            this.btnFemale.Location = new System.Drawing.Point(131, 23);
            this.btnFemale.Margin = new System.Windows.Forms.Padding(4);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(95, 36);
            this.btnFemale.TabIndex = 9;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnMale
            // 
            this.btnMale.Location = new System.Drawing.Point(8, 23);
            this.btnMale.Margin = new System.Windows.Forms.Padding(4);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(95, 36);
            this.btnMale.TabIndex = 8;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // gbxRace
            // 
            this.gbxRace.Controls.Add(this.lblRaceHuman);
            this.gbxRace.Controls.Add(this.lblRaceGnome);
            this.gbxRace.Controls.Add(this.lblRaceDwarf);
            this.gbxRace.Controls.Add(this.btnDwarf);
            this.gbxRace.Controls.Add(this.btnGnome);
            this.gbxRace.Controls.Add(this.btnElf);
            this.gbxRace.Controls.Add(this.btnHuman);
            this.gbxRace.Controls.Add(this.lblRaceElf);
            this.gbxRace.Location = new System.Drawing.Point(195, 59);
            this.gbxRace.Margin = new System.Windows.Forms.Padding(4);
            this.gbxRace.Name = "gbxRace";
            this.gbxRace.Padding = new System.Windows.Forms.Padding(4);
            this.gbxRace.Size = new System.Drawing.Size(529, 549);
            this.gbxRace.TabIndex = 8;
            this.gbxRace.TabStop = false;
            this.gbxRace.Visible = false;
            // 
            // lblRaceHuman
            // 
            this.lblRaceHuman.AutoSize = true;
            this.lblRaceHuman.Location = new System.Drawing.Point(11, 63);
            this.lblRaceHuman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaceHuman.Name = "lblRaceHuman";
            this.lblRaceHuman.Size = new System.Drawing.Size(511, 221);
            this.lblRaceHuman.TabIndex = 13;
            this.lblRaceHuman.Text = resources.GetString("lblRaceHuman.Text");
            this.lblRaceHuman.Visible = false;
            // 
            // lblRaceGnome
            // 
            this.lblRaceGnome.AutoSize = true;
            this.lblRaceGnome.Location = new System.Drawing.Point(12, 63);
            this.lblRaceGnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaceGnome.Name = "lblRaceGnome";
            this.lblRaceGnome.Size = new System.Drawing.Size(504, 510);
            this.lblRaceGnome.TabIndex = 13;
            this.lblRaceGnome.Text = resources.GetString("lblRaceGnome.Text");
            this.lblRaceGnome.Visible = false;
            // 
            // lblRaceDwarf
            // 
            this.lblRaceDwarf.AutoSize = true;
            this.lblRaceDwarf.Location = new System.Drawing.Point(7, 65);
            this.lblRaceDwarf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaceDwarf.Name = "lblRaceDwarf";
            this.lblRaceDwarf.Size = new System.Drawing.Size(520, 374);
            this.lblRaceDwarf.TabIndex = 13;
            this.lblRaceDwarf.Text = resources.GetString("lblRaceDwarf.Text");
            this.lblRaceDwarf.Visible = false;
            // 
            // btnDwarf
            // 
            this.btnDwarf.Location = new System.Drawing.Point(403, 23);
            this.btnDwarf.Margin = new System.Windows.Forms.Padding(4);
            this.btnDwarf.Name = "btnDwarf";
            this.btnDwarf.Size = new System.Drawing.Size(95, 36);
            this.btnDwarf.TabIndex = 12;
            this.btnDwarf.Text = "Dwarf";
            this.btnDwarf.UseVisualStyleBackColor = true;
            this.btnDwarf.Click += new System.EventHandler(this.btnDwarf_Click);
            this.btnDwarf.MouseEnter += new System.EventHandler(this.btnDwarf_MouseEnter);
            // 
            // btnGnome
            // 
            this.btnGnome.Location = new System.Drawing.Point(279, 23);
            this.btnGnome.Margin = new System.Windows.Forms.Padding(4);
            this.btnGnome.Name = "btnGnome";
            this.btnGnome.Size = new System.Drawing.Size(95, 36);
            this.btnGnome.TabIndex = 11;
            this.btnGnome.Text = "Gnome";
            this.btnGnome.UseVisualStyleBackColor = true;
            this.btnGnome.Click += new System.EventHandler(this.btnGnome_Click);
            this.btnGnome.MouseEnter += new System.EventHandler(this.btnGnome_MouseEnter);
            // 
            // btnElf
            // 
            this.btnElf.Location = new System.Drawing.Point(155, 22);
            this.btnElf.Margin = new System.Windows.Forms.Padding(4);
            this.btnElf.Name = "btnElf";
            this.btnElf.Size = new System.Drawing.Size(95, 36);
            this.btnElf.TabIndex = 10;
            this.btnElf.Text = "Elf";
            this.btnElf.UseVisualStyleBackColor = true;
            this.btnElf.Click += new System.EventHandler(this.btnElf_Click);
            this.btnElf.MouseEnter += new System.EventHandler(this.btnElf_MouseEnter);
            // 
            // btnHuman
            // 
            this.btnHuman.Location = new System.Drawing.Point(31, 23);
            this.btnHuman.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(95, 36);
            this.btnHuman.TabIndex = 9;
            this.btnHuman.Text = "Human";
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            this.btnHuman.MouseEnter += new System.EventHandler(this.btnHuman_MouseEnter);
            // 
            // lblRaceElf
            // 
            this.lblRaceElf.AutoSize = true;
            this.lblRaceElf.Location = new System.Drawing.Point(13, 63);
            this.lblRaceElf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaceElf.Name = "lblRaceElf";
            this.lblRaceElf.Size = new System.Drawing.Size(502, 408);
            this.lblRaceElf.TabIndex = 14;
            this.lblRaceElf.Text = resources.GetString("lblRaceElf.Text");
            this.lblRaceElf.Visible = false;
            // 
            // gbxClass
            // 
            this.gbxClass.Controls.Add(this.lblClassFighter);
            this.gbxClass.Controls.Add(this.btnWizard);
            this.gbxClass.Controls.Add(this.btnRogue);
            this.gbxClass.Controls.Add(this.btnFighter);
            this.gbxClass.Controls.Add(this.lblClassWizard);
            this.gbxClass.Controls.Add(this.lblClassRogue);
            this.gbxClass.Location = new System.Drawing.Point(195, 59);
            this.gbxClass.Margin = new System.Windows.Forms.Padding(4);
            this.gbxClass.Name = "gbxClass";
            this.gbxClass.Padding = new System.Windows.Forms.Padding(4);
            this.gbxClass.Size = new System.Drawing.Size(655, 551);
            this.gbxClass.TabIndex = 9;
            this.gbxClass.TabStop = false;
            this.gbxClass.Visible = false;
            // 
            // lblClassFighter
            // 
            this.lblClassFighter.Location = new System.Drawing.Point(16, 68);
            this.lblClassFighter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassFighter.Name = "lblClassFighter";
            this.lblClassFighter.Size = new System.Drawing.Size(621, 394);
            this.lblClassFighter.TabIndex = 13;
            this.lblClassFighter.Text = resources.GetString("lblClassFighter.Text");
            this.lblClassFighter.Visible = false;
            // 
            // btnWizard
            // 
            this.btnWizard.Location = new System.Drawing.Point(467, 23);
            this.btnWizard.Margin = new System.Windows.Forms.Padding(4);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(95, 36);
            this.btnWizard.TabIndex = 12;
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            this.btnWizard.MouseEnter += new System.EventHandler(this.btnWizard_MouseEnter);
            // 
            // btnRogue
            // 
            this.btnRogue.Location = new System.Drawing.Point(280, 23);
            this.btnRogue.Margin = new System.Windows.Forms.Padding(4);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(95, 36);
            this.btnRogue.TabIndex = 11;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);
            this.btnRogue.MouseEnter += new System.EventHandler(this.btnRogue_MouseEnter);
            // 
            // btnFighter
            // 
            this.btnFighter.Location = new System.Drawing.Point(93, 23);
            this.btnFighter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFighter.Name = "btnFighter";
            this.btnFighter.Size = new System.Drawing.Size(95, 36);
            this.btnFighter.TabIndex = 10;
            this.btnFighter.Text = "Fighter";
            this.btnFighter.UseVisualStyleBackColor = true;
            this.btnFighter.Click += new System.EventHandler(this.btnFighter_Click);
            this.btnFighter.MouseEnter += new System.EventHandler(this.btnFighter_MouseEnter);
            // 
            // lblClassWizard
            // 
            this.lblClassWizard.Location = new System.Drawing.Point(20, 68);
            this.lblClassWizard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassWizard.Name = "lblClassWizard";
            this.lblClassWizard.Size = new System.Drawing.Size(613, 431);
            this.lblClassWizard.TabIndex = 15;
            this.lblClassWizard.Text = resources.GetString("lblClassWizard.Text");
            this.lblClassWizard.Visible = false;
            // 
            // lblClassRogue
            // 
            this.lblClassRogue.Location = new System.Drawing.Point(20, 68);
            this.lblClassRogue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassRogue.Name = "lblClassRogue";
            this.lblClassRogue.Size = new System.Drawing.Size(613, 431);
            this.lblClassRogue.TabIndex = 14;
            this.lblClassRogue.Text = resources.GetString("lblClassRogue.Text");
            this.lblClassRogue.Visible = false;
            // 
            // imageListPortraitsMale
            // 
            this.imageListPortraitsMale.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPortraitsMale.ImageStream")));
            this.imageListPortraitsMale.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPortraitsMale.Images.SetKeyName(0, "male_arnie.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(1, "male_bale.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(2, "male_carrey.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(3, "male_connery.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(4, "male_devito.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(5, "male_jordan.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(6, "male_jude.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(7, "male_keanu.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(8, "male_nicholson.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(9, "male_norton.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(10, "male_orlando.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(11, "male_seth.jpg");
            this.imageListPortraitsMale.Images.SetKeyName(12, "male_stiller.jpg");
            // 
            // gbxPortraits
            // 
            this.gbxPortraits.Controls.Add(this.panelPortraits);
            this.gbxPortraits.Location = new System.Drawing.Point(195, 59);
            this.gbxPortraits.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPortraits.Name = "gbxPortraits";
            this.gbxPortraits.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPortraits.Size = new System.Drawing.Size(941, 642);
            this.gbxPortraits.TabIndex = 11;
            this.gbxPortraits.TabStop = false;
            this.gbxPortraits.Visible = false;
            // 
            // panelPortraits
            // 
            this.panelPortraits.AutoScroll = true;
            this.panelPortraits.Controls.Add(this.pictureBox16);
            this.panelPortraits.Controls.Add(this.pictureBox17);
            this.panelPortraits.Controls.Add(this.pictureBox18);
            this.panelPortraits.Controls.Add(this.pictureBox19);
            this.panelPortraits.Controls.Add(this.pictureBox20);
            this.panelPortraits.Controls.Add(this.pictureBox11);
            this.panelPortraits.Controls.Add(this.pictureBox12);
            this.panelPortraits.Controls.Add(this.pictureBox13);
            this.panelPortraits.Controls.Add(this.pictureBox14);
            this.panelPortraits.Controls.Add(this.pictureBox15);
            this.panelPortraits.Controls.Add(this.pictureBox6);
            this.panelPortraits.Controls.Add(this.pictureBox7);
            this.panelPortraits.Controls.Add(this.pictureBox8);
            this.panelPortraits.Controls.Add(this.pictureBox9);
            this.panelPortraits.Controls.Add(this.pictureBox10);
            this.panelPortraits.Controls.Add(this.pictureBox5);
            this.panelPortraits.Controls.Add(this.pictureBox4);
            this.panelPortraits.Controls.Add(this.pictureBox3);
            this.panelPortraits.Controls.Add(this.pictureBox2);
            this.panelPortraits.Controls.Add(this.pictureBox1);
            this.panelPortraits.Location = new System.Drawing.Point(23, 23);
            this.panelPortraits.Margin = new System.Windows.Forms.Padding(4);
            this.panelPortraits.Name = "panelPortraits";
            this.panelPortraits.Size = new System.Drawing.Size(911, 612);
            this.panelPortraits.TabIndex = 0;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(728, 700);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(155, 209);
            this.pictureBox16.TabIndex = 19;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(549, 700);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(155, 209);
            this.pictureBox17.TabIndex = 18;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(371, 700);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(155, 209);
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(192, 700);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(155, 209);
            this.pictureBox19.TabIndex = 16;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(13, 700);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(155, 209);
            this.pictureBox20.TabIndex = 15;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox20_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(728, 471);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(155, 209);
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(549, 471);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(155, 209);
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(371, 471);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(155, 209);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(192, 471);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(155, 209);
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(13, 471);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(155, 209);
            this.pictureBox15.TabIndex = 10;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(728, 242);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(155, 209);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(549, 242);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(155, 209);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(371, 242);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(155, 209);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(192, 242);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(155, 209);
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(13, 242);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(155, 209);
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(728, 14);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 209);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(549, 14);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 209);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(371, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 209);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(192, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 209);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 209);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 16;
            this.listBoxNames.Items.AddRange(new object[] {
            "Stephen",
            "Arnold",
            "Ben",
            "Jack",
            "George",
            "Tim",
            "Nasher",
            "Bill",
            "Colbert",
            "O\'Riley",
            "Jones",
            "Forman",
            "Alagondar",
            "Jenkins",
            "Deluril",
            "Nelithruldur",
            "Nebril",
            "Elrond",
            "Feynor",
            "Igdrasil",
            "Feiwalie",
            "Amolies",
            "Jr\'ein",
            "Le\'te\'lin",
            "Elothar",
            "Khal\'asar",
            "Oin",
            "Gloin",
            "Balin",
            "Dwalin",
            "Thorin",
            "Aghabast",
            "Tror",
            "son of Khal",
            "son of Durak",
            "son of Drain",
            "son of Tor",
            "son of Durin",
            "son of Bran",
            "Budock",
            "Buppi",
            "Frabo",
            "Friam",
            "Perugo",
            "Thinil",
            "Olaven",
            "Resien",
            "Askyrens",
            "Garrestol",
            "Ydonig",
            "Elisabeth",
            "Natalie",
            "Mirge",
            "Ann",
            "Angelina",
            "Michelle",
            "Obama",
            "Portman",
            "Jolie",
            "Simpson",
            "Alba",
            "Trouman",
            "Galadriel",
            "Eluvien",
            "Erynel",
            "Thyrande",
            "Gwaineth",
            "Naisha",
            "Thil\'morand",
            "Lady of the Night",
            "Sindarin",
            "Quenya",
            "Beleriad",
            "Tin\'suel",
            "Meriado",
            "Perin",
            "Soirry",
            "Meroppi",
            "Riam",
            "Hent",
            "Bilmfrin",
            "Reneagel",
            "Darreth",
            "Garrentien",
            "Boinus",
            "Furina",
            "Labur",
            "Glebor",
            "Gloili",
            "Kelin",
            "Chantoff",
            "Ungarks",
            "Hakera",
            "Kitt",
            "Holderthik",
            "Chanvil"});
            this.listBoxNames.Location = new System.Drawing.Point(16, 585);
            this.listBoxNames.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(243, 116);
            this.listBoxNames.TabIndex = 23;
            this.listBoxNames.Visible = false;
            // 
            // imageListPortraitsFemale
            // 
            this.imageListPortraitsFemale.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPortraitsFemale.ImageStream")));
            this.imageListPortraitsFemale.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPortraitsFemale.Images.SetKeyName(0, "femme_connelly.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(1, "femme_diaz.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(2, "femme_famke.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(3, "femme_geller.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(4, "femme_halle.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(5, "femme_hayek.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(6, "femme_heigl.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(7, "femme_henstridge.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(8, "femme_jolie.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(9, "femme_keira.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(10, "femme_leeloo.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(11, "femme_milano.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(12, "femme_milla.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(13, "femme_rose.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(14, "femme_shannon.jpg");
            this.imageListPortraitsFemale.Images.SetKeyName(15, "femme_victoria.jpg");
            // 
            // gbxPackage
            // 
            this.gbxPackage.Controls.Add(this.btnPackageNext);
            this.gbxPackage.Controls.Add(this.label20);
            this.gbxPackage.Location = new System.Drawing.Point(195, 59);
            this.gbxPackage.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPackage.Name = "gbxPackage";
            this.gbxPackage.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPackage.Size = new System.Drawing.Size(455, 123);
            this.gbxPackage.TabIndex = 12;
            this.gbxPackage.TabStop = false;
            this.gbxPackage.Visible = false;
            // 
            // btnPackageNext
            // 
            this.btnPackageNext.Location = new System.Drawing.Point(307, 78);
            this.btnPackageNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnPackageNext.Name = "btnPackageNext";
            this.btnPackageNext.Size = new System.Drawing.Size(140, 38);
            this.btnPackageNext.TabIndex = 1;
            this.btnPackageNext.Text = "Next";
            this.btnPackageNext.UseVisualStyleBackColor = true;
            this.btnPackageNext.Click += new System.EventHandler(this.btnPackageNext_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 18);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(391, 60);
            this.label20.TabIndex = 0;
            this.label20.Text = "Sorry, but it would be too complicated to put in this \r\noption right now. I might" +
    " be able to do that in a later\r\nversion of this aplication.";
            // 
            // lblGRC
            // 
            this.lblGRC.AutoSize = true;
            this.lblGRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRC.Location = new System.Drawing.Point(177, 23);
            this.lblGRC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGRC.Name = "lblGRC";
            this.lblGRC.Size = new System.Drawing.Size(624, 29);
            this.lblGRC.TabIndex = 13;
            this.lblGRC.Text = "Gender:                      Race:                      Class:                   " +
    "   \r\n";
            this.lblGRC.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(271, 23);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(95, 58);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Female\r\n\r\n";
            this.lblGender.Visible = false;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(472, 23);
            this.lblRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(89, 29);
            this.lblRace.TabIndex = 15;
            this.lblRace.Text = "Human";
            this.lblRace.Visible = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(680, 23);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(89, 29);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "Fighter";
            this.lblClass.Visible = false;
            // 
            // gbxCustomize
            // 
            this.gbxCustomize.Controls.Add(this.btnGenerateLastName);
            this.gbxCustomize.Controls.Add(this.btnGenerateFirstName);
            this.gbxCustomize.Controls.Add(this.btnConfirmCharacter);
            this.gbxCustomize.Controls.Add(this.txtLastName);
            this.gbxCustomize.Controls.Add(this.txtFirstName);
            this.gbxCustomize.Controls.Add(this.label24);
            this.gbxCustomize.Controls.Add(this.label23);
            this.gbxCustomize.Controls.Add(this.label22);
            this.gbxCustomize.Location = new System.Drawing.Point(195, 59);
            this.gbxCustomize.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCustomize.Name = "gbxCustomize";
            this.gbxCustomize.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCustomize.Size = new System.Drawing.Size(561, 170);
            this.gbxCustomize.TabIndex = 20;
            this.gbxCustomize.TabStop = false;
            this.gbxCustomize.Visible = false;
            // 
            // btnGenerateLastName
            // 
            this.btnGenerateLastName.Location = new System.Drawing.Point(393, 127);
            this.btnGenerateLastName.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateLastName.Name = "btnGenerateLastName";
            this.btnGenerateLastName.Size = new System.Drawing.Size(167, 26);
            this.btnGenerateLastName.TabIndex = 7;
            this.btnGenerateLastName.TabStop = false;
            this.btnGenerateLastName.Text = "Generate Last Name";
            this.btnGenerateLastName.UseVisualStyleBackColor = true;
            this.btnGenerateLastName.Click += new System.EventHandler(this.btnGenerateLastName_Click);
            // 
            // btnGenerateFirstName
            // 
            this.btnGenerateFirstName.Location = new System.Drawing.Point(393, 53);
            this.btnGenerateFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateFirstName.Name = "btnGenerateFirstName";
            this.btnGenerateFirstName.Size = new System.Drawing.Size(167, 26);
            this.btnGenerateFirstName.TabIndex = 6;
            this.btnGenerateFirstName.TabStop = false;
            this.btnGenerateFirstName.Text = "Generate First Name";
            this.btnGenerateFirstName.UseVisualStyleBackColor = true;
            this.btnGenerateFirstName.Click += new System.EventHandler(this.btnGenerateFirstName_Click);
            // 
            // btnConfirmCharacter
            // 
            this.btnConfirmCharacter.Location = new System.Drawing.Point(403, 89);
            this.btnConfirmCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmCharacter.Name = "btnConfirmCharacter";
            this.btnConfirmCharacter.Size = new System.Drawing.Size(136, 28);
            this.btnConfirmCharacter.TabIndex = 5;
            this.btnConfirmCharacter.TabStop = false;
            this.btnConfirmCharacter.Text = "Confirm Character";
            this.btnConfirmCharacter.UseVisualStyleBackColor = true;
            this.btnConfirmCharacter.Click += new System.EventHandler(this.btnConfirmCharacter_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 128);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 27;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(231, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(155, 54);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(229, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 20);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(402, 17);
            this.label24.TabIndex = 2;
            this.label24.Text = "Unfortunately this is the only customization available right now.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(25, 129);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 20);
            this.label23.TabIndex = 1;
            this.label23.Text = "Last Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(25, 55);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "First Name:";
            // 
            // pbxPlayerPortrait
            // 
            this.pbxPlayerPortrait.Location = new System.Drawing.Point(17, 107);
            this.pbxPlayerPortrait.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPlayerPortrait.Name = "pbxPlayerPortrait";
            this.pbxPlayerPortrait.Size = new System.Drawing.Size(155, 209);
            this.pbxPlayerPortrait.TabIndex = 21;
            this.pbxPlayerPortrait.TabStop = false;
            // 
            // gbxPlayerSheet
            // 
            this.gbxPlayerSheet.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPlayerSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxPlayerSheet.Controls.Add(this.groupBox16);
            this.gbxPlayerSheet.Controls.Add(this.groupBox15);
            this.gbxPlayerSheet.Controls.Add(this.groupBox14);
            this.gbxPlayerSheet.Controls.Add(this.label27);
            this.gbxPlayerSheet.Controls.Add(this.lblPlayerLvl);
            this.gbxPlayerSheet.Controls.Add(this.groupBox10);
            this.gbxPlayerSheet.Controls.Add(this.lblPlayerClass);
            this.gbxPlayerSheet.Controls.Add(this.lblPlayerRace);
            this.gbxPlayerSheet.Controls.Add(this.groupBox8);
            this.gbxPlayerSheet.Controls.Add(this.groupBox6);
            this.gbxPlayerSheet.Controls.Add(this.groupBox9);
            this.gbxPlayerSheet.Controls.Add(this.groupBox5);
            this.gbxPlayerSheet.Controls.Add(this.groupBox7);
            this.gbxPlayerSheet.Controls.Add(this.groupBox3);
            this.gbxPlayerSheet.Controls.Add(this.lblFullName);
            this.gbxPlayerSheet.Controls.Add(this.pbxPlayerPortrait);
            this.gbxPlayerSheet.Controls.Add(this.groupBox11);
            this.gbxPlayerSheet.Controls.Add(this.groupBox12);
            this.gbxPlayerSheet.Controls.Add(this.groupBox13);
            this.gbxPlayerSheet.Location = new System.Drawing.Point(5, 54);
            this.gbxPlayerSheet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPlayerSheet.Name = "gbxPlayerSheet";
            this.gbxPlayerSheet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPlayerSheet.Size = new System.Drawing.Size(468, 647);
            this.gbxPlayerSheet.TabIndex = 22;
            this.gbxPlayerSheet.TabStop = false;
            this.gbxPlayerSheet.Visible = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.panel1);
            this.groupBox16.Location = new System.Drawing.Point(20, 510);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(433, 130);
            this.groupBox16.TabIndex = 35;
            this.groupBox16.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblModifierDmg);
            this.panel1.Controls.Add(this.lblPlayerBaseAttack);
            this.panel1.Controls.Add(this.lblWeaponDmg);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.lblWeaponCritical);
            this.panel1.Controls.Add(this.lblPlayerAttackBonus);
            this.panel1.Controls.Add(this.lblWeaponName);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 110);
            this.panel1.TabIndex = 10;
            // 
            // lblModifierDmg
            // 
            this.lblModifierDmg.AutoSize = true;
            this.lblModifierDmg.Location = new System.Drawing.Point(155, 66);
            this.lblModifierDmg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifierDmg.Name = "lblModifierDmg";
            this.lblModifierDmg.Size = new System.Drawing.Size(24, 17);
            this.lblModifierDmg.TabIndex = 9;
            this.lblModifierDmg.Text = "99";
            // 
            // lblPlayerBaseAttack
            // 
            this.lblPlayerBaseAttack.AutoSize = true;
            this.lblPlayerBaseAttack.Location = new System.Drawing.Point(115, 128);
            this.lblPlayerBaseAttack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerBaseAttack.Name = "lblPlayerBaseAttack";
            this.lblPlayerBaseAttack.Size = new System.Drawing.Size(24, 17);
            this.lblPlayerBaseAttack.TabIndex = 7;
            this.lblPlayerBaseAttack.Text = "44";
            this.lblPlayerBaseAttack.TextChanged += new System.EventHandler(this.lblPlayerBaseAttack_TextChanged);
            // 
            // lblWeaponDmg
            // 
            this.lblWeaponDmg.AutoSize = true;
            this.lblWeaponDmg.Location = new System.Drawing.Point(113, 66);
            this.lblWeaponDmg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeaponDmg.Name = "lblWeaponDmg";
            this.lblWeaponDmg.Size = new System.Drawing.Size(32, 17);
            this.lblWeaponDmg.TabIndex = 8;
            this.lblWeaponDmg.Text = "1d6";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(4, 128);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(87, 17);
            this.label44.TabIndex = 2;
            this.label44.Text = "Base Attack:";
            // 
            // lblWeaponCritical
            // 
            this.lblWeaponCritical.AutoSize = true;
            this.lblWeaponCritical.Location = new System.Drawing.Point(188, 66);
            this.lblWeaponCritical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeaponCritical.Name = "lblWeaponCritical";
            this.lblWeaponCritical.Size = new System.Drawing.Size(121, 17);
            this.lblWeaponCritical.TabIndex = 6;
            this.lblWeaponCritical.Text = " (critical 19-20/x2)";
            // 
            // lblPlayerAttackBonus
            // 
            this.lblPlayerAttackBonus.AutoSize = true;
            this.lblPlayerAttackBonus.Location = new System.Drawing.Point(113, 34);
            this.lblPlayerAttackBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerAttackBonus.Name = "lblPlayerAttackBonus";
            this.lblPlayerAttackBonus.Size = new System.Drawing.Size(24, 17);
            this.lblPlayerAttackBonus.TabIndex = 5;
            this.lblPlayerAttackBonus.Text = "99";
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(113, 2);
            this.lblWeaponName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(79, 17);
            this.lblWeaponName.TabIndex = 4;
            this.lblWeaponName.Text = "Shortsword";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 66);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 17);
            this.label45.TabIndex = 3;
            this.label45.Text = "Damage:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 34);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 17);
            this.label43.TabIndex = 1;
            this.label43.Text = "Attack Bonus:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 2);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(99, 17);
            this.label41.TabIndex = 0;
            this.label41.Text = "Main Weapon:";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.lblPlayerWill);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Controls.Add(this.lblPlayerReflex);
            this.groupBox15.Controls.Add(this.label32);
            this.groupBox15.Controls.Add(this.lblPlayerFortitude);
            this.groupBox15.Controls.Add(this.label37);
            this.groupBox15.Location = new System.Drawing.Point(16, 407);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(141, 103);
            this.groupBox15.TabIndex = 31;
            this.groupBox15.TabStop = false;
            // 
            // lblPlayerWill
            // 
            this.lblPlayerWill.AutoSize = true;
            this.lblPlayerWill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWill.Location = new System.Drawing.Point(103, 80);
            this.lblPlayerWill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerWill.Name = "lblPlayerWill";
            this.lblPlayerWill.Size = new System.Drawing.Size(24, 20);
            this.lblPlayerWill.TabIndex = 5;
            this.lblPlayerWill.Text = "-1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(8, 78);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 26);
            this.label38.TabIndex = 4;
            this.label38.Text = "Will:";
            // 
            // lblPlayerReflex
            // 
            this.lblPlayerReflex.AutoSize = true;
            this.lblPlayerReflex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerReflex.Location = new System.Drawing.Point(103, 48);
            this.lblPlayerReflex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerReflex.Name = "lblPlayerReflex";
            this.lblPlayerReflex.Size = new System.Drawing.Size(24, 20);
            this.lblPlayerReflex.TabIndex = 3;
            this.lblPlayerReflex.Text = "-1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 46);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 26);
            this.label32.TabIndex = 2;
            this.label32.Text = "Reflex:";
            // 
            // lblPlayerFortitude
            // 
            this.lblPlayerFortitude.AutoSize = true;
            this.lblPlayerFortitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerFortitude.Location = new System.Drawing.Point(103, 16);
            this.lblPlayerFortitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerFortitude.Name = "lblPlayerFortitude";
            this.lblPlayerFortitude.Size = new System.Drawing.Size(24, 20);
            this.lblPlayerFortitude.TabIndex = 1;
            this.lblPlayerFortitude.Text = "-1";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(8, 14);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(103, 26);
            this.label37.TabIndex = 0;
            this.label37.Text = "Fortitude:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.lblPlayerNextLvlXp);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.lblPlayerCurrentXp);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Location = new System.Drawing.Point(184, 407);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(261, 103);
            this.groupBox14.TabIndex = 31;
            this.groupBox14.TabStop = false;
            // 
            // lblPlayerNextLvlXp
            // 
            this.lblPlayerNextLvlXp.AutoSize = true;
            this.lblPlayerNextLvlXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNextLvlXp.Location = new System.Drawing.Point(148, 66);
            this.lblPlayerNextLvlXp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNextLvlXp.Name = "lblPlayerNextLvlXp";
            this.lblPlayerNextLvlXp.Size = new System.Drawing.Size(45, 20);
            this.lblPlayerNextLvlXp.TabIndex = 3;
            this.lblPlayerNextLvlXp.Text = "1000";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(8, 62);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(132, 29);
            this.label31.TabIndex = 2;
            this.label31.Text = "Next Level:";
            // 
            // lblPlayerCurrentXp
            // 
            this.lblPlayerCurrentXp.AutoSize = true;
            this.lblPlayerCurrentXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCurrentXp.Location = new System.Drawing.Point(148, 26);
            this.lblPlayerCurrentXp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerCurrentXp.Name = "lblPlayerCurrentXp";
            this.lblPlayerCurrentXp.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerCurrentXp.TabIndex = 1;
            this.lblPlayerCurrentXp.Text = "0";
            this.lblPlayerCurrentXp.TextChanged += new System.EventHandler(this.lblPlayerCurrentXp_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 21);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(141, 29);
            this.label34.TabIndex = 0;
            this.label34.Text = "Experience:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(267, 60);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 31);
            this.label27.TabIndex = 33;
            this.label27.Text = "Level:";
            // 
            // lblPlayerLvl
            // 
            this.lblPlayerLvl.AutoSize = true;
            this.lblPlayerLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLvl.Location = new System.Drawing.Point(351, 60);
            this.lblPlayerLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerLvl.Name = "lblPlayerLvl";
            this.lblPlayerLvl.Size = new System.Drawing.Size(29, 31);
            this.lblPlayerLvl.TabIndex = 32;
            this.lblPlayerLvl.Text = "1";
            this.lblPlayerLvl.TextChanged += new System.EventHandler(this.lblPlayerLvl_TextChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblPlayerMaxHp);
            this.groupBox10.Controls.Add(this.label166);
            this.groupBox10.Controls.Add(this.lblPlayerHP);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.lblPlayerAC);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Location = new System.Drawing.Point(16, 316);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(141, 92);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            // 
            // lblPlayerMaxHp
            // 
            this.lblPlayerMaxHp.AutoSize = true;
            this.lblPlayerMaxHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMaxHp.Location = new System.Drawing.Point(89, 68);
            this.lblPlayerMaxHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerMaxHp.Name = "lblPlayerMaxHp";
            this.lblPlayerMaxHp.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerMaxHp.TabIndex = 5;
            this.lblPlayerMaxHp.Text = "9";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.Location = new System.Drawing.Point(7, 66);
            this.label166.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(84, 26);
            this.label166.TabIndex = 4;
            this.label166.Text = "MaxHP";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(88, 41);
            this.lblPlayerHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerHP.TabIndex = 3;
            this.lblPlayerHP.Text = "9";
            this.lblPlayerHP.TextChanged += new System.EventHandler(this.lblPlayerHP_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(7, 39);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 26);
            this.label28.TabIndex = 2;
            this.label28.Text = "HP";
            // 
            // lblPlayerAC
            // 
            this.lblPlayerAC.AutoSize = true;
            this.lblPlayerAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAC.Location = new System.Drawing.Point(88, 10);
            this.lblPlayerAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerAC.Name = "lblPlayerAC";
            this.lblPlayerAC.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerAC.TabIndex = 1;
            this.lblPlayerAC.Text = "9";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(7, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 26);
            this.label26.TabIndex = 0;
            this.label26.Text = "AC";
            // 
            // lblPlayerClass
            // 
            this.lblPlayerClass.AutoSize = true;
            this.lblPlayerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerClass.Location = new System.Drawing.Point(125, 60);
            this.lblPlayerClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerClass.Name = "lblPlayerClass";
            this.lblPlayerClass.Size = new System.Drawing.Size(83, 31);
            this.lblPlayerClass.TabIndex = 29;
            this.lblPlayerClass.Text = "Class";
            // 
            // lblPlayerRace
            // 
            this.lblPlayerRace.AutoSize = true;
            this.lblPlayerRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerRace.Location = new System.Drawing.Point(12, 60);
            this.lblPlayerRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerRace.Name = "lblPlayerRace";
            this.lblPlayerRace.Size = new System.Drawing.Size(78, 31);
            this.lblPlayerRace.TabIndex = 28;
            this.lblPlayerRace.Text = "Race";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblPlayerChaM);
            this.groupBox8.Controls.Add(this.lblPlayerCha);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Location = new System.Drawing.Point(184, 336);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(249, 41);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            // 
            // lblPlayerChaM
            // 
            this.lblPlayerChaM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerChaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChaM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerChaM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerChaM.Name = "lblPlayerChaM";
            this.lblPlayerChaM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerChaM.TabIndex = 2;
            this.lblPlayerChaM.Text = "5";
            this.lblPlayerChaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerCha
            // 
            this.lblPlayerCha.AutoSize = true;
            this.lblPlayerCha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCha.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerCha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerCha.Name = "lblPlayerCha";
            this.lblPlayerCha.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerCha.TabIndex = 1;
            this.lblPlayerCha.Text = "8";
            this.lblPlayerCha.TextChanged += new System.EventHandler(this.lblPlayerCha_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(20, 12);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(118, 26);
            this.label39.TabIndex = 0;
            this.label39.Text = "ChariSMA:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblPlayerIntM);
            this.groupBox6.Controls.Add(this.lblPlayerInt);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Location = new System.Drawing.Point(184, 242);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(249, 41);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            // 
            // lblPlayerIntM
            // 
            this.lblPlayerIntM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerIntM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerIntM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerIntM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerIntM.Name = "lblPlayerIntM";
            this.lblPlayerIntM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerIntM.TabIndex = 2;
            this.lblPlayerIntM.Text = "5";
            this.lblPlayerIntM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerInt
            // 
            this.lblPlayerInt.AutoSize = true;
            this.lblPlayerInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInt.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerInt.Name = "lblPlayerInt";
            this.lblPlayerInt.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerInt.TabIndex = 1;
            this.lblPlayerInt.Text = "8";
            this.lblPlayerInt.TextChanged += new System.EventHandler(this.lblPlayerInt_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(20, 12);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(128, 26);
            this.label33.TabIndex = 0;
            this.label33.Text = "Intelligence:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblPlayerWisM);
            this.groupBox9.Controls.Add(this.lblPlayerWis);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Location = new System.Drawing.Point(184, 292);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(249, 41);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            // 
            // lblPlayerWisM
            // 
            this.lblPlayerWisM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerWisM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWisM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerWisM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerWisM.Name = "lblPlayerWisM";
            this.lblPlayerWisM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerWisM.TabIndex = 2;
            this.lblPlayerWisM.Text = "5";
            this.lblPlayerWisM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerWisM.TextChanged += new System.EventHandler(this.lblPlayerWisM_TextChanged);
            // 
            // lblPlayerWis
            // 
            this.lblPlayerWis.AutoSize = true;
            this.lblPlayerWis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWis.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerWis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerWis.Name = "lblPlayerWis";
            this.lblPlayerWis.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerWis.TabIndex = 1;
            this.lblPlayerWis.Text = "8";
            this.lblPlayerWis.TextChanged += new System.EventHandler(this.lblPlayerWis_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(20, 12);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(98, 26);
            this.label42.TabIndex = 0;
            this.label42.Text = "Wisdom:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPlayerDexM);
            this.groupBox5.Controls.Add(this.lblPlayerDex);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Location = new System.Drawing.Point(184, 151);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(249, 41);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // lblPlayerDexM
            // 
            this.lblPlayerDexM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerDexM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDexM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerDexM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerDexM.Name = "lblPlayerDexM";
            this.lblPlayerDexM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerDexM.TabIndex = 2;
            this.lblPlayerDexM.Text = "5";
            this.lblPlayerDexM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerDexM.TextChanged += new System.EventHandler(this.lblPlayerDexM_TextChanged);
            // 
            // lblPlayerDex
            // 
            this.lblPlayerDex.AutoSize = true;
            this.lblPlayerDex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDex.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerDex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerDex.Name = "lblPlayerDex";
            this.lblPlayerDex.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerDex.TabIndex = 1;
            this.lblPlayerDex.Text = "8";
            this.lblPlayerDex.TextChanged += new System.EventHandler(this.lblPlayerDex_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(20, 12);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 26);
            this.label30.TabIndex = 0;
            this.label30.Text = "Dexterity:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblPlayerConM);
            this.groupBox7.Controls.Add(this.lblPlayerCon);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Location = new System.Drawing.Point(184, 198);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(249, 41);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            // 
            // lblPlayerConM
            // 
            this.lblPlayerConM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerConM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerConM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerConM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerConM.Name = "lblPlayerConM";
            this.lblPlayerConM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerConM.TabIndex = 2;
            this.lblPlayerConM.Text = "5";
            this.lblPlayerConM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerConM.TextChanged += new System.EventHandler(this.lblPlayerConM_TextChanged);
            // 
            // lblPlayerCon
            // 
            this.lblPlayerCon.AutoSize = true;
            this.lblPlayerCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCon.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerCon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerCon.Name = "lblPlayerCon";
            this.lblPlayerCon.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerCon.TabIndex = 1;
            this.lblPlayerCon.Text = "8";
            this.lblPlayerCon.TextChanged += new System.EventHandler(this.lblPlayerCon_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(20, 12);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(133, 26);
            this.label36.TabIndex = 0;
            this.label36.Text = "Constitution:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPlayerStrM);
            this.groupBox3.Controls.Add(this.lblPlayerStr);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Location = new System.Drawing.Point(184, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(249, 41);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // lblPlayerStrM
            // 
            this.lblPlayerStrM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerStrM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStrM.Location = new System.Drawing.Point(208, 11);
            this.lblPlayerStrM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerStrM.Name = "lblPlayerStrM";
            this.lblPlayerStrM.Size = new System.Drawing.Size(35, 23);
            this.lblPlayerStrM.TabIndex = 2;
            this.lblPlayerStrM.Text = "5";
            this.lblPlayerStrM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerStrM.TextChanged += new System.EventHandler(this.lblPlayerStrM_TextChanged);
            // 
            // lblPlayerStr
            // 
            this.lblPlayerStr.AutoSize = true;
            this.lblPlayerStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStr.Location = new System.Drawing.Point(160, 11);
            this.lblPlayerStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerStr.Name = "lblPlayerStr";
            this.lblPlayerStr.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerStr.TabIndex = 1;
            this.lblPlayerStr.Text = "8";
            this.lblPlayerStr.TextChanged += new System.EventHandler(this.lblPlayerStr_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(20, 12);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 26);
            this.label25.TabIndex = 0;
            this.label25.Text = "Strength:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 21);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(130, 31);
            this.lblFullName.TabIndex = 22;
            this.lblFullName.Text = "FullName";
            // 
            // groupBox11
            // 
            this.groupBox11.Location = new System.Drawing.Point(11, 52);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(95, 42);
            this.groupBox11.TabIndex = 31;
            this.groupBox11.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Location = new System.Drawing.Point(123, 52);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(103, 42);
            this.groupBox12.TabIndex = 32;
            this.groupBox12.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(263, 52);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(136, 42);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            // 
            // gbxWolf
            // 
            this.gbxWolf.BackColor = System.Drawing.Color.Transparent;
            this.gbxWolf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxWolf.Controls.Add(this.groupBox2);
            this.gbxWolf.Controls.Add(this.groupBox17);
            this.gbxWolf.Controls.Add(this.label63);
            this.gbxWolf.Controls.Add(this.label64);
            this.gbxWolf.Controls.Add(this.groupBox19);
            this.gbxWolf.Controls.Add(this.label70);
            this.gbxWolf.Controls.Add(this.groupBox20);
            this.gbxWolf.Controls.Add(this.groupBox21);
            this.gbxWolf.Controls.Add(this.groupBox22);
            this.gbxWolf.Controls.Add(this.groupBox23);
            this.gbxWolf.Controls.Add(this.groupBox24);
            this.gbxWolf.Controls.Add(this.groupBox25);
            this.gbxWolf.Controls.Add(this.pictureBox21);
            this.gbxWolf.Controls.Add(this.groupBox26);
            this.gbxWolf.Controls.Add(this.groupBox28);
            this.gbxWolf.Location = new System.Drawing.Point(1431, 54);
            this.gbxWolf.Margin = new System.Windows.Forms.Padding(4);
            this.gbxWolf.Name = "gbxWolf";
            this.gbxWolf.Padding = new System.Windows.Forms.Padding(4);
            this.gbxWolf.Size = new System.Drawing.Size(468, 578);
            this.gbxWolf.TabIndex = 36;
            this.gbxWolf.TabStop = false;
            this.gbxWolf.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(20, 453);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(433, 113);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.label47);
            this.panel2.Controls.Add(this.label48);
            this.panel2.Controls.Add(this.label50);
            this.panel2.Controls.Add(this.label51);
            this.panel2.Location = new System.Drawing.Point(5, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 86);
            this.panel2.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(155, 37);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "+1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(115, 68);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 17);
            this.label29.TabIndex = 7;
            this.label29.Text = "1";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(113, 37);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 17);
            this.label35.TabIndex = 8;
            this.label35.Text = "1-6";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(4, 68);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 17);
            this.label40.TabIndex = 2;
            this.label40.Text = "Base Attack:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(237, 37);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(22, 17);
            this.label47.TabIndex = 6;
            this.label47.Text = "x2";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(113, 9);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(24, 17);
            this.label48.TabIndex = 5;
            this.label48.Text = "+2";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 37);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(65, 17);
            this.label50.TabIndex = 3;
            this.label50.Text = "Damage:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(3, 9);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(95, 17);
            this.label51.TabIndex = 1;
            this.label51.Text = "Attack Bonus:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label53);
            this.groupBox17.Controls.Add(this.label54);
            this.groupBox17.Controls.Add(this.label55);
            this.groupBox17.Controls.Add(this.label56);
            this.groupBox17.Controls.Add(this.label57);
            this.groupBox17.Controls.Add(this.label58);
            this.groupBox17.Location = new System.Drawing.Point(16, 350);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox17.Size = new System.Drawing.Size(141, 103);
            this.groupBox17.TabIndex = 31;
            this.groupBox17.TabStop = false;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(103, 80);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(18, 20);
            this.label53.TabIndex = 5;
            this.label53.Text = "1";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(8, 78);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(54, 26);
            this.label54.TabIndex = 4;
            this.label54.Text = "Will:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(103, 48);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(18, 20);
            this.label55.TabIndex = 3;
            this.label55.Text = "3";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(8, 46);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 26);
            this.label56.TabIndex = 2;
            this.label56.Text = "Reflex:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(103, 16);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(18, 20);
            this.label57.TabIndex = 1;
            this.label57.Text = "5";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(8, 14);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(103, 26);
            this.label58.TabIndex = 0;
            this.label58.Text = "Fortitude:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(271, 21);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(87, 31);
            this.label63.TabIndex = 33;
            this.label63.Text = "Level:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(355, 21);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(26, 29);
            this.label64.TabIndex = 32;
            this.label64.Text = "2";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.lblWolfHp);
            this.groupBox19.Controls.Add(this.label66);
            this.groupBox19.Controls.Add(this.label67);
            this.groupBox19.Controls.Add(this.label68);
            this.groupBox19.Location = new System.Drawing.Point(16, 273);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox19.Size = new System.Drawing.Size(99, 76);
            this.groupBox19.TabIndex = 30;
            this.groupBox19.TabStop = false;
            // 
            // lblWolfHp
            // 
            this.lblWolfHp.AutoSize = true;
            this.lblWolfHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWolfHp.Location = new System.Drawing.Point(56, 47);
            this.lblWolfHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWolfHp.Name = "lblWolfHp";
            this.lblWolfHp.Size = new System.Drawing.Size(27, 20);
            this.lblWolfHp.TabIndex = 3;
            this.lblWolfHp.Text = "15";
            this.lblWolfHp.TextChanged += new System.EventHandler(this.lblWolfHp_TextChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(8, 44);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 29);
            this.label66.TabIndex = 2;
            this.label66.Text = "HP";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(56, 16);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(27, 20);
            this.label67.TabIndex = 1;
            this.label67.Text = "10";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(8, 14);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(45, 29);
            this.label68.TabIndex = 0;
            this.label68.Text = "AC";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(16, 21);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(68, 31);
            this.label70.TabIndex = 28;
            this.label70.Text = "Wolf";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label71);
            this.groupBox20.Controls.Add(this.label72);
            this.groupBox20.Controls.Add(this.label73);
            this.groupBox20.Location = new System.Drawing.Point(184, 289);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox20.Size = new System.Drawing.Size(249, 41);
            this.groupBox20.TabIndex = 27;
            this.groupBox20.TabStop = false;
            // 
            // label71
            // 
            this.label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(208, 11);
            this.label71.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 23);
            this.label71.TabIndex = 2;
            this.label71.Text = "-2";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(160, 11);
            this.label72.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(20, 22);
            this.label72.TabIndex = 1;
            this.label72.Text = "6";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(20, 12);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(112, 26);
            this.label73.TabIndex = 0;
            this.label73.Text = "Charisma:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label74);
            this.groupBox21.Controls.Add(this.label75);
            this.groupBox21.Controls.Add(this.label76);
            this.groupBox21.Location = new System.Drawing.Point(184, 196);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox21.Size = new System.Drawing.Size(249, 41);
            this.groupBox21.TabIndex = 27;
            this.groupBox21.TabStop = false;
            // 
            // label74
            // 
            this.label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(208, 11);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(35, 23);
            this.label74.TabIndex = 2;
            this.label74.Text = "-4";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(160, 11);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(20, 22);
            this.label75.TabIndex = 1;
            this.label75.Text = "3";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(20, 12);
            this.label76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(128, 26);
            this.label76.TabIndex = 0;
            this.label76.Text = "Intelligence:";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label77);
            this.groupBox22.Controls.Add(this.label78);
            this.groupBox22.Controls.Add(this.label79);
            this.groupBox22.Location = new System.Drawing.Point(184, 245);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox22.Size = new System.Drawing.Size(249, 41);
            this.groupBox22.TabIndex = 26;
            this.groupBox22.TabStop = false;
            // 
            // label77
            // 
            this.label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(208, 11);
            this.label77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(35, 23);
            this.label77.TabIndex = 2;
            this.label77.Text = "1";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(160, 11);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(29, 22);
            this.label78.TabIndex = 1;
            this.label78.Text = "12";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(20, 12);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(98, 26);
            this.label79.TabIndex = 0;
            this.label79.Text = "Wisdom:";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label80);
            this.groupBox23.Controls.Add(this.label81);
            this.groupBox23.Controls.Add(this.label82);
            this.groupBox23.Location = new System.Drawing.Point(184, 105);
            this.groupBox23.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox23.Size = new System.Drawing.Size(249, 41);
            this.groupBox23.TabIndex = 25;
            this.groupBox23.TabStop = false;
            // 
            // label80
            // 
            this.label80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(208, 11);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(35, 23);
            this.label80.TabIndex = 2;
            this.label80.Text = "0";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(160, 11);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(29, 22);
            this.label81.TabIndex = 1;
            this.label81.Text = "11";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(20, 12);
            this.label82.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(104, 26);
            this.label82.TabIndex = 0;
            this.label82.Text = "Dexterity:";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.label83);
            this.groupBox24.Controls.Add(this.label84);
            this.groupBox24.Controls.Add(this.label85);
            this.groupBox24.Location = new System.Drawing.Point(184, 151);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox24.Size = new System.Drawing.Size(249, 41);
            this.groupBox24.TabIndex = 26;
            this.groupBox24.TabStop = false;
            // 
            // label83
            // 
            this.label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(208, 11);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(35, 23);
            this.label83.TabIndex = 2;
            this.label83.Text = "2";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(160, 11);
            this.label84.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(29, 22);
            this.label84.TabIndex = 1;
            this.label84.Text = "15";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(20, 12);
            this.label85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(133, 26);
            this.label85.TabIndex = 0;
            this.label85.Text = "Constitution:";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label86);
            this.groupBox25.Controls.Add(this.label87);
            this.groupBox25.Controls.Add(this.label88);
            this.groupBox25.Location = new System.Drawing.Point(184, 59);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox25.Size = new System.Drawing.Size(249, 41);
            this.groupBox25.TabIndex = 24;
            this.groupBox25.TabStop = false;
            // 
            // label86
            // 
            this.label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(208, 11);
            this.label86.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(35, 23);
            this.label86.TabIndex = 2;
            this.label86.Text = "1";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(160, 11);
            this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(29, 22);
            this.label87.TabIndex = 1;
            this.label87.Text = "13";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(20, 12);
            this.label88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(100, 26);
            this.label88.TabIndex = 0;
            this.label88.Text = "Strength:";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.BackgroundImage")));
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.Location = new System.Drawing.Point(17, 60);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(155, 209);
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            // 
            // groupBox26
            // 
            this.groupBox26.Location = new System.Drawing.Point(15, 12);
            this.groupBox26.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox26.Size = new System.Drawing.Size(95, 42);
            this.groupBox26.TabIndex = 31;
            this.groupBox26.TabStop = false;
            // 
            // groupBox28
            // 
            this.groupBox28.Location = new System.Drawing.Point(267, 12);
            this.groupBox28.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox28.Size = new System.Drawing.Size(136, 42);
            this.groupBox28.TabIndex = 34;
            this.groupBox28.TabStop = false;
            // 
            // gbxFireBeelte
            // 
            this.gbxFireBeelte.BackColor = System.Drawing.Color.Transparent;
            this.gbxFireBeelte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxFireBeelte.Controls.Add(this.groupBox27);
            this.gbxFireBeelte.Controls.Add(this.groupBox29);
            this.gbxFireBeelte.Controls.Add(this.label96);
            this.gbxFireBeelte.Controls.Add(this.label97);
            this.gbxFireBeelte.Controls.Add(this.groupBox30);
            this.gbxFireBeelte.Controls.Add(this.label102);
            this.gbxFireBeelte.Controls.Add(this.groupBox31);
            this.gbxFireBeelte.Controls.Add(this.groupBox32);
            this.gbxFireBeelte.Controls.Add(this.groupBox33);
            this.gbxFireBeelte.Controls.Add(this.groupBox34);
            this.gbxFireBeelte.Controls.Add(this.groupBox35);
            this.gbxFireBeelte.Controls.Add(this.groupBox36);
            this.gbxFireBeelte.Controls.Add(this.pictureBox22);
            this.gbxFireBeelte.Controls.Add(this.groupBox37);
            this.gbxFireBeelte.Controls.Add(this.groupBox38);
            this.gbxFireBeelte.Location = new System.Drawing.Point(1431, 54);
            this.gbxFireBeelte.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFireBeelte.Name = "gbxFireBeelte";
            this.gbxFireBeelte.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFireBeelte.Size = new System.Drawing.Size(468, 578);
            this.gbxFireBeelte.TabIndex = 37;
            this.gbxFireBeelte.TabStop = false;
            this.gbxFireBeelte.Visible = false;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.panel3);
            this.groupBox27.Location = new System.Drawing.Point(20, 453);
            this.groupBox27.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox27.Size = new System.Drawing.Size(433, 113);
            this.groupBox27.TabIndex = 35;
            this.groupBox27.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label98);
            this.panel3.Controls.Add(this.label52);
            this.panel3.Controls.Add(this.label59);
            this.panel3.Controls.Add(this.label60);
            this.panel3.Controls.Add(this.label62);
            this.panel3.Controls.Add(this.label69);
            this.panel3.Controls.Add(this.label89);
            this.panel3.Location = new System.Drawing.Point(5, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 86);
            this.panel3.TabIndex = 10;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(237, 37);
            this.label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(22, 17);
            this.label98.TabIndex = 9;
            this.label98.Text = "x2";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(115, 68);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(16, 17);
            this.label52.TabIndex = 7;
            this.label52.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(113, 37);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(29, 17);
            this.label59.TabIndex = 8;
            this.label59.Text = "2-8";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(4, 68);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(87, 17);
            this.label60.TabIndex = 2;
            this.label60.Text = "Base Attack:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(113, 9);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(16, 17);
            this.label62.TabIndex = 5;
            this.label62.Text = "0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(3, 37);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(65, 17);
            this.label69.TabIndex = 3;
            this.label69.Text = "Damage:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(3, 9);
            this.label89.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(95, 17);
            this.label89.TabIndex = 1;
            this.label89.Text = "Attack Bonus:";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label90);
            this.groupBox29.Controls.Add(this.label91);
            this.groupBox29.Controls.Add(this.label92);
            this.groupBox29.Controls.Add(this.label93);
            this.groupBox29.Controls.Add(this.label94);
            this.groupBox29.Controls.Add(this.label95);
            this.groupBox29.Location = new System.Drawing.Point(16, 350);
            this.groupBox29.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox29.Size = new System.Drawing.Size(141, 103);
            this.groupBox29.TabIndex = 31;
            this.groupBox29.TabStop = false;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(107, 78);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(18, 20);
            this.label90.TabIndex = 5;
            this.label90.Text = "0";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(8, 78);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(54, 26);
            this.label91.TabIndex = 4;
            this.label91.Text = "Will:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(107, 46);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(18, 20);
            this.label92.TabIndex = 3;
            this.label92.Text = "0";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(8, 46);
            this.label93.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(80, 26);
            this.label93.TabIndex = 2;
            this.label93.Text = "Reflex:";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(107, 14);
            this.label94.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(18, 20);
            this.label94.TabIndex = 1;
            this.label94.Text = "2";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(8, 14);
            this.label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(103, 26);
            this.label95.TabIndex = 0;
            this.label95.Text = "Fortitude:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(271, 21);
            this.label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(87, 31);
            this.label96.TabIndex = 33;
            this.label96.Text = "Level:";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(355, 21);
            this.label97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(29, 31);
            this.label97.TabIndex = 32;
            this.label97.Text = "1";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.lblFBHp);
            this.groupBox30.Controls.Add(this.label99);
            this.groupBox30.Controls.Add(this.label100);
            this.groupBox30.Controls.Add(this.label101);
            this.groupBox30.Location = new System.Drawing.Point(16, 273);
            this.groupBox30.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox30.Size = new System.Drawing.Size(99, 76);
            this.groupBox30.TabIndex = 30;
            this.groupBox30.TabStop = false;
            // 
            // lblFBHp
            // 
            this.lblFBHp.AutoSize = true;
            this.lblFBHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBHp.Location = new System.Drawing.Point(67, 47);
            this.lblFBHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBHp.Name = "lblFBHp";
            this.lblFBHp.Size = new System.Drawing.Size(18, 20);
            this.lblFBHp.TabIndex = 3;
            this.lblFBHp.Text = "4";
            this.lblFBHp.TextChanged += new System.EventHandler(this.lblFBHp_TextChanged);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(8, 44);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(46, 29);
            this.label99.TabIndex = 2;
            this.label99.Text = "HP";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(59, 18);
            this.label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(27, 20);
            this.label100.TabIndex = 1;
            this.label100.Text = "10";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(8, 14);
            this.label101.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(45, 29);
            this.label101.TabIndex = 0;
            this.label101.Text = "AC";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(16, 21);
            this.label102.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(145, 31);
            this.label102.TabIndex = 28;
            this.label102.Text = "Fire Beetle";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label103);
            this.groupBox31.Controls.Add(this.label104);
            this.groupBox31.Controls.Add(this.label105);
            this.groupBox31.Location = new System.Drawing.Point(184, 289);
            this.groupBox31.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox31.Size = new System.Drawing.Size(249, 41);
            this.groupBox31.TabIndex = 27;
            this.groupBox31.TabStop = false;
            // 
            // label103
            // 
            this.label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(208, 11);
            this.label103.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(35, 23);
            this.label103.TabIndex = 2;
            this.label103.Text = "-2";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(160, 11);
            this.label104.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(20, 22);
            this.label104.TabIndex = 1;
            this.label104.Text = "7";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(20, 12);
            this.label105.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(112, 26);
            this.label105.TabIndex = 0;
            this.label105.Text = "Charisma:";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.label106);
            this.groupBox32.Controls.Add(this.lblFBInt);
            this.groupBox32.Controls.Add(this.label108);
            this.groupBox32.Location = new System.Drawing.Point(184, 196);
            this.groupBox32.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox32.Size = new System.Drawing.Size(249, 41);
            this.groupBox32.TabIndex = 27;
            this.groupBox32.TabStop = false;
            // 
            // label106
            // 
            this.label106.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(208, 11);
            this.label106.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(35, 23);
            this.label106.TabIndex = 2;
            this.label106.Text = "-4";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFBInt
            // 
            this.lblFBInt.AutoSize = true;
            this.lblFBInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFBInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBInt.Location = new System.Drawing.Point(160, 11);
            this.lblFBInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBInt.Name = "lblFBInt";
            this.lblFBInt.Size = new System.Drawing.Size(20, 22);
            this.lblFBInt.TabIndex = 1;
            this.lblFBInt.Text = "3";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(20, 12);
            this.label108.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(128, 26);
            this.label108.TabIndex = 0;
            this.label108.Text = "Intelligence:";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.label109);
            this.groupBox33.Controls.Add(this.lblFBWis);
            this.groupBox33.Controls.Add(this.label111);
            this.groupBox33.Location = new System.Drawing.Point(184, 245);
            this.groupBox33.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox33.Size = new System.Drawing.Size(249, 41);
            this.groupBox33.TabIndex = 26;
            this.groupBox33.TabStop = false;
            // 
            // label109
            // 
            this.label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(208, 11);
            this.label109.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(35, 23);
            this.label109.TabIndex = 2;
            this.label109.Text = "0";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFBWis
            // 
            this.lblFBWis.AutoSize = true;
            this.lblFBWis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFBWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBWis.Location = new System.Drawing.Point(160, 11);
            this.lblFBWis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBWis.Name = "lblFBWis";
            this.lblFBWis.Size = new System.Drawing.Size(29, 22);
            this.lblFBWis.TabIndex = 1;
            this.lblFBWis.Text = "10";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(20, 12);
            this.label111.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(98, 26);
            this.label111.TabIndex = 0;
            this.label111.Text = "Wisdom:";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.lblFBDexM);
            this.groupBox34.Controls.Add(this.lblFBDex);
            this.groupBox34.Controls.Add(this.label114);
            this.groupBox34.Location = new System.Drawing.Point(184, 105);
            this.groupBox34.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox34.Size = new System.Drawing.Size(249, 41);
            this.groupBox34.TabIndex = 25;
            this.groupBox34.TabStop = false;
            // 
            // lblFBDexM
            // 
            this.lblFBDexM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFBDexM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBDexM.Location = new System.Drawing.Point(208, 11);
            this.lblFBDexM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBDexM.Name = "lblFBDexM";
            this.lblFBDexM.Size = new System.Drawing.Size(35, 23);
            this.lblFBDexM.TabIndex = 2;
            this.lblFBDexM.Text = "0";
            this.lblFBDexM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFBDex
            // 
            this.lblFBDex.AutoSize = true;
            this.lblFBDex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFBDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBDex.Location = new System.Drawing.Point(160, 11);
            this.lblFBDex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBDex.Name = "lblFBDex";
            this.lblFBDex.Size = new System.Drawing.Size(29, 22);
            this.lblFBDex.TabIndex = 1;
            this.lblFBDex.Text = "11";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(20, 12);
            this.label114.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(104, 26);
            this.label114.TabIndex = 0;
            this.label114.Text = "Dexterity:";
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.lblFBConM);
            this.groupBox35.Controls.Add(this.lblFBCon);
            this.groupBox35.Controls.Add(this.label117);
            this.groupBox35.Location = new System.Drawing.Point(184, 151);
            this.groupBox35.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox35.Size = new System.Drawing.Size(249, 41);
            this.groupBox35.TabIndex = 26;
            this.groupBox35.TabStop = false;
            // 
            // lblFBConM
            // 
            this.lblFBConM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFBConM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBConM.Location = new System.Drawing.Point(208, 11);
            this.lblFBConM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBConM.Name = "lblFBConM";
            this.lblFBConM.Size = new System.Drawing.Size(35, 23);
            this.lblFBConM.TabIndex = 2;
            this.lblFBConM.Text = "0";
            this.lblFBConM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFBCon
            // 
            this.lblFBCon.AutoSize = true;
            this.lblFBCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFBCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBCon.Location = new System.Drawing.Point(160, 11);
            this.lblFBCon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBCon.Name = "lblFBCon";
            this.lblFBCon.Size = new System.Drawing.Size(29, 22);
            this.lblFBCon.TabIndex = 1;
            this.lblFBCon.Text = "11";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(20, 12);
            this.label117.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(133, 26);
            this.label117.TabIndex = 0;
            this.label117.Text = "Constitution:";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.lblFBStrM);
            this.groupBox36.Controls.Add(this.lblFBStr);
            this.groupBox36.Controls.Add(this.label120);
            this.groupBox36.Location = new System.Drawing.Point(184, 59);
            this.groupBox36.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox36.Size = new System.Drawing.Size(249, 41);
            this.groupBox36.TabIndex = 24;
            this.groupBox36.TabStop = false;
            // 
            // lblFBStrM
            // 
            this.lblFBStrM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFBStrM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBStrM.Location = new System.Drawing.Point(208, 11);
            this.lblFBStrM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBStrM.Name = "lblFBStrM";
            this.lblFBStrM.Size = new System.Drawing.Size(35, 23);
            this.lblFBStrM.TabIndex = 2;
            this.lblFBStrM.Text = "0";
            this.lblFBStrM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFBStr
            // 
            this.lblFBStr.AutoSize = true;
            this.lblFBStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFBStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBStr.Location = new System.Drawing.Point(160, 11);
            this.lblFBStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBStr.Name = "lblFBStr";
            this.lblFBStr.Size = new System.Drawing.Size(29, 22);
            this.lblFBStr.TabIndex = 1;
            this.lblFBStr.Text = "10";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.Location = new System.Drawing.Point(20, 12);
            this.label120.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(100, 26);
            this.label120.TabIndex = 0;
            this.label120.Text = "Strength:";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.BackgroundImage")));
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(17, 60);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(155, 209);
            this.pictureBox22.TabIndex = 21;
            this.pictureBox22.TabStop = false;
            // 
            // groupBox37
            // 
            this.groupBox37.Location = new System.Drawing.Point(15, 12);
            this.groupBox37.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox37.Size = new System.Drawing.Size(141, 42);
            this.groupBox37.TabIndex = 31;
            this.groupBox37.TabStop = false;
            // 
            // groupBox38
            // 
            this.groupBox38.Location = new System.Drawing.Point(267, 12);
            this.groupBox38.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox38.Size = new System.Drawing.Size(136, 42);
            this.groupBox38.TabIndex = 34;
            this.groupBox38.TabStop = false;
            // 
            // gbxMonsters
            // 
            this.gbxMonsters.BackColor = System.Drawing.SystemColors.Control;
            this.gbxMonsters.Controls.Add(this.groupBox1);
            this.gbxMonsters.Controls.Add(this.label124);
            this.gbxMonsters.Controls.Add(this.label123);
            this.gbxMonsters.Controls.Add(this.btnRemoveMonster);
            this.gbxMonsters.Controls.Add(this.btnSpawn);
            this.gbxMonsters.Controls.Add(this.label122);
            this.gbxMonsters.Controls.Add(this.label121);
            this.gbxMonsters.Controls.Add(this.label61);
            this.gbxMonsters.Controls.Add(this.label49);
            this.gbxMonsters.Controls.Add(this.rbtnDragon);
            this.gbxMonsters.Controls.Add(this.rbtnDireBear);
            this.gbxMonsters.Controls.Add(this.rbtnWolf);
            this.gbxMonsters.Controls.Add(this.rbtnFireBeetle);
            this.gbxMonsters.Location = new System.Drawing.Point(484, 11);
            this.gbxMonsters.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMonsters.Name = "gbxMonsters";
            this.gbxMonsters.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMonsters.Size = new System.Drawing.Size(935, 210);
            this.gbxMonsters.TabIndex = 38;
            this.gbxMonsters.TabStop = false;
            this.gbxMonsters.Text = "Choose a monster to fight:     ";
            this.gbxMonsters.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label163);
            this.groupBox1.Controls.Add(this.label162);
            this.groupBox1.Controls.Add(this.label161);
            this.groupBox1.Controls.Add(this.label160);
            this.groupBox1.Controls.Add(this.txtDragonCounter);
            this.groupBox1.Controls.Add(this.txtBearCounter);
            this.groupBox1.Controls.Add(this.txtWolfCounter);
            this.groupBox1.Controls.Add(this.txtBeetleCounter);
            this.groupBox1.Controls.Add(this.label159);
            this.groupBox1.Controls.Add(this.label158);
            this.groupBox1.Controls.Add(this.label157);
            this.groupBox1.Controls.Add(this.label133);
            this.groupBox1.Location = new System.Drawing.Point(475, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(452, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monsters killed:  ";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(221, 150);
            this.label163.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(190, 17);
            this.label163.TabIndex = 11;
            this.label163.Text = "You get a kit kat for killing 10";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(221, 106);
            this.label162.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(198, 17);
            this.label162.TabIndex = 10;
            this.label162.Text = "Bonus 45 000 XP for killing 10\r\n";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.Location = new System.Drawing.Point(221, 68);
            this.label161.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(198, 17);
            this.label161.TabIndex = 9;
            this.label161.Text = "Bonus 10 000 XP for killing 10";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(221, 30);
            this.label160.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(186, 17);
            this.label160.TabIndex = 8;
            this.label160.Text = "Bonus 3000 XP for killing 10";
            // 
            // txtDragonCounter
            // 
            this.txtDragonCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDragonCounter.Location = new System.Drawing.Point(153, 146);
            this.txtDragonCounter.Margin = new System.Windows.Forms.Padding(4);
            this.txtDragonCounter.Name = "txtDragonCounter";
            this.txtDragonCounter.ReadOnly = true;
            this.txtDragonCounter.Size = new System.Drawing.Size(47, 23);
            this.txtDragonCounter.TabIndex = 7;
            this.txtDragonCounter.TabStop = false;
            this.txtDragonCounter.Text = "0";
            this.txtDragonCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBearCounter
            // 
            this.txtBearCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBearCounter.Location = new System.Drawing.Point(153, 102);
            this.txtBearCounter.Margin = new System.Windows.Forms.Padding(4);
            this.txtBearCounter.Name = "txtBearCounter";
            this.txtBearCounter.ReadOnly = true;
            this.txtBearCounter.Size = new System.Drawing.Size(47, 23);
            this.txtBearCounter.TabIndex = 6;
            this.txtBearCounter.TabStop = false;
            this.txtBearCounter.Text = "0";
            this.txtBearCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBearCounter.TextChanged += new System.EventHandler(this.txtBearCounter_TextChanged);
            // 
            // txtWolfCounter
            // 
            this.txtWolfCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWolfCounter.Location = new System.Drawing.Point(153, 64);
            this.txtWolfCounter.Margin = new System.Windows.Forms.Padding(4);
            this.txtWolfCounter.Name = "txtWolfCounter";
            this.txtWolfCounter.ReadOnly = true;
            this.txtWolfCounter.Size = new System.Drawing.Size(47, 23);
            this.txtWolfCounter.TabIndex = 5;
            this.txtWolfCounter.TabStop = false;
            this.txtWolfCounter.Text = "0";
            this.txtWolfCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWolfCounter.TextChanged += new System.EventHandler(this.txtWolfCounter_TextChanged);
            // 
            // txtBeetleCounter
            // 
            this.txtBeetleCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeetleCounter.Location = new System.Drawing.Point(153, 26);
            this.txtBeetleCounter.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeetleCounter.Name = "txtBeetleCounter";
            this.txtBeetleCounter.ReadOnly = true;
            this.txtBeetleCounter.Size = new System.Drawing.Size(47, 23);
            this.txtBeetleCounter.TabIndex = 4;
            this.txtBeetleCounter.TabStop = false;
            this.txtBeetleCounter.Text = "0";
            this.txtBeetleCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBeetleCounter.TextChanged += new System.EventHandler(this.txtBeetleCounter_TextChanged);
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label159.Location = new System.Drawing.Point(12, 150);
            this.label159.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(104, 19);
            this.label159.TabIndex = 3;
            this.label159.Text = "Dragons killed:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label158.Location = new System.Drawing.Point(12, 106);
            this.label158.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(117, 19);
            this.label158.TabIndex = 2;
            this.label158.Text = "Dire Bears killed:";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label157.Location = new System.Drawing.Point(12, 68);
            this.label157.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(96, 19);
            this.label157.TabIndex = 1;
            this.label157.Text = "Wolves killed:";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label133.Location = new System.Drawing.Point(12, 30);
            this.label133.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(125, 19);
            this.label133.TabIndex = 0;
            this.label133.Text = "Fire Beetles killed:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(297, 150);
            this.label124.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(209, 50);
            this.label124.TabIndex = 11;
            this.label124.Text = "Use this button if the\r\nopponent is too strong.\r\n";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(275, 65);
            this.label123.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(224, 50);
            this.label123.TabIndex = 10;
            this.label123.Text = "Create opponent you \r\nwish to fight, or examine.";
            // 
            // btnRemoveMonster
            // 
            this.btnRemoveMonster.Enabled = false;
            this.btnRemoveMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMonster.Location = new System.Drawing.Point(299, 114);
            this.btnRemoveMonster.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMonster.Name = "btnRemoveMonster";
            this.btnRemoveMonster.Size = new System.Drawing.Size(139, 31);
            this.btnRemoveMonster.TabIndex = 9;
            this.btnRemoveMonster.TabStop = false;
            this.btnRemoveMonster.Text = "Remove opponent";
            this.btnRemoveMonster.UseVisualStyleBackColor = true;
            this.btnRemoveMonster.Click += new System.EventHandler(this.btnRemoveMonster_Click);
            // 
            // btnSpawn
            // 
            this.btnSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpawn.Location = new System.Drawing.Point(299, 31);
            this.btnSpawn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpawn.Name = "btnSpawn";
            this.btnSpawn.Size = new System.Drawing.Size(139, 31);
            this.btnSpawn.TabIndex = 8;
            this.btnSpawn.TabStop = false;
            this.btnSpawn.Text = "Spawn opponent";
            this.btnSpawn.UseVisualStyleBackColor = true;
            this.btnSpawn.Click += new System.EventHandler(this.btnSpawn_Click);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.Location = new System.Drawing.Point(136, 164);
            this.label122.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(174, 25);
            this.label122.TabIndex = 7;
            this.label122.Text = "Lvl 23. Very strong";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(136, 122);
            this.label121.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(132, 25);
            this.label121.TabIndex = 6;
            this.label121.Text = "Lvl 12. Strong";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(136, 80);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(115, 25);
            this.label61.TabIndex = 5;
            this.label61.Text = "Lvl 2. Weak";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(136, 38);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(155, 25);
            this.label49.TabIndex = 4;
            this.label49.Text = "Lvl 1. Very weak";
            // 
            // rbtnDragon
            // 
            this.rbtnDragon.AutoSize = true;
            this.rbtnDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDragon.Location = new System.Drawing.Point(15, 161);
            this.rbtnDragon.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDragon.Name = "rbtnDragon";
            this.rbtnDragon.Size = new System.Drawing.Size(97, 29);
            this.rbtnDragon.TabIndex = 3;
            this.rbtnDragon.TabStop = true;
            this.rbtnDragon.Text = "Dragon";
            this.rbtnDragon.UseVisualStyleBackColor = true;
            // 
            // rbtnDireBear
            // 
            this.rbtnDireBear.AutoSize = true;
            this.rbtnDireBear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDireBear.Location = new System.Drawing.Point(15, 119);
            this.rbtnDireBear.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDireBear.Name = "rbtnDireBear";
            this.rbtnDireBear.Size = new System.Drawing.Size(114, 29);
            this.rbtnDireBear.TabIndex = 2;
            this.rbtnDireBear.TabStop = true;
            this.rbtnDireBear.Text = "Dire Bear";
            this.rbtnDireBear.UseVisualStyleBackColor = true;
            // 
            // rbtnWolf
            // 
            this.rbtnWolf.AutoSize = true;
            this.rbtnWolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWolf.Location = new System.Drawing.Point(15, 78);
            this.rbtnWolf.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWolf.Name = "rbtnWolf";
            this.rbtnWolf.Size = new System.Drawing.Size(73, 29);
            this.rbtnWolf.TabIndex = 1;
            this.rbtnWolf.TabStop = true;
            this.rbtnWolf.Text = "Wolf";
            this.rbtnWolf.UseVisualStyleBackColor = true;
            // 
            // rbtnFireBeetle
            // 
            this.rbtnFireBeetle.AutoSize = true;
            this.rbtnFireBeetle.Checked = true;
            this.rbtnFireBeetle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFireBeetle.Location = new System.Drawing.Point(15, 36);
            this.rbtnFireBeetle.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFireBeetle.Name = "rbtnFireBeetle";
            this.rbtnFireBeetle.Size = new System.Drawing.Size(126, 29);
            this.rbtnFireBeetle.TabIndex = 0;
            this.rbtnFireBeetle.TabStop = true;
            this.rbtnFireBeetle.Text = "Fire Beetle";
            this.rbtnFireBeetle.UseVisualStyleBackColor = true;
            // 
            // gbxFight
            // 
            this.gbxFight.BackColor = System.Drawing.SystemColors.Control;
            this.gbxFight.Controls.Add(this.label225);
            this.gbxFight.Controls.Add(this.panel4);
            this.gbxFight.Controls.Add(this.txtFight1);
            this.gbxFight.Controls.Add(this.btnFight);
            this.gbxFight.Location = new System.Drawing.Point(632, 676);
            this.gbxFight.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFight.Name = "gbxFight";
            this.gbxFight.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFight.Size = new System.Drawing.Size(651, 332);
            this.gbxFight.TabIndex = 39;
            this.gbxFight.TabStop = false;
            this.gbxFight.Visible = false;
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label225.Location = new System.Drawing.Point(405, 225);
            this.label225.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(269, 20);
            this.label225.TabIndex = 45;
            this.label225.Text = "(you can just hit enter after spawn)";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label65);
            this.panel4.Location = new System.Drawing.Point(11, 255);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 71);
            this.panel4.TabIndex = 44;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(11, 5);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(590, 170);
            this.label65.TabIndex = 43;
            this.label65.Text = resources.GetString("label65.Text");
            // 
            // txtFight1
            // 
            this.txtFight1.HideSelection = false;
            this.txtFight1.Location = new System.Drawing.Point(8, 15);
            this.txtFight1.Margin = new System.Windows.Forms.Padding(4);
            this.txtFight1.Name = "txtFight1";
            this.txtFight1.ReadOnly = true;
            this.txtFight1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFight1.Size = new System.Drawing.Size(633, 191);
            this.txtFight1.TabIndex = 42;
            this.txtFight1.TabStop = false;
            this.txtFight1.Text = "";
            // 
            // btnFight
            // 
            this.btnFight.Enabled = false;
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(260, 213);
            this.btnFight.Margin = new System.Windows.Forms.Padding(4);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(137, 37);
            this.btnFight.TabIndex = 40;
            this.btnFight.Text = "Fight";
            this.btnFight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // btnLightHeal
            // 
            this.btnLightHeal.Image = ((System.Drawing.Image)(resources.GetObject("btnLightHeal.Image")));
            this.btnLightHeal.Location = new System.Drawing.Point(17, 63);
            this.btnLightHeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnLightHeal.Name = "btnLightHeal";
            this.btnLightHeal.Size = new System.Drawing.Size(41, 74);
            this.btnLightHeal.TabIndex = 43;
            this.btnLightHeal.TabStop = false;
            this.btnLightHeal.UseVisualStyleBackColor = true;
            this.btnLightHeal.Click += new System.EventHandler(this.btnLightHeal_Click);
            // 
            // gbxLvlUp
            // 
            this.gbxLvlUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxLvlUp.Controls.Add(this.label212);
            this.gbxLvlUp.Controls.Add(this.btnLvlUpConfirm);
            this.gbxLvlUp.Controls.Add(this.txtLvlUp);
            this.gbxLvlUp.Controls.Add(this.rbtnChaUp);
            this.gbxLvlUp.Controls.Add(this.rbtnWisUp);
            this.gbxLvlUp.Controls.Add(this.rbtnIntUp);
            this.gbxLvlUp.Controls.Add(this.rbtnConUp);
            this.gbxLvlUp.Controls.Add(this.rbtnDexUp);
            this.gbxLvlUp.Controls.Add(this.rbtnStrUp);
            this.gbxLvlUp.Controls.Add(this.label107);
            this.gbxLvlUp.Location = new System.Drawing.Point(484, 11);
            this.gbxLvlUp.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLvlUp.Name = "gbxLvlUp";
            this.gbxLvlUp.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLvlUp.Size = new System.Drawing.Size(939, 225);
            this.gbxLvlUp.TabIndex = 39;
            this.gbxLvlUp.TabStop = false;
            this.gbxLvlUp.Visible = false;
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label212.Location = new System.Drawing.Point(464, 16);
            this.label212.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(514, 225);
            this.label212.TabIndex = 9;
            this.label212.Text = resources.GetString("label212.Text");
            // 
            // btnLvlUpConfirm
            // 
            this.btnLvlUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvlUpConfirm.Location = new System.Drawing.Point(233, 166);
            this.btnLvlUpConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnLvlUpConfirm.Name = "btnLvlUpConfirm";
            this.btnLvlUpConfirm.Size = new System.Drawing.Size(115, 37);
            this.btnLvlUpConfirm.TabIndex = 8;
            this.btnLvlUpConfirm.Text = "Confirm";
            this.btnLvlUpConfirm.UseVisualStyleBackColor = true;
            this.btnLvlUpConfirm.Click += new System.EventHandler(this.btnLvlUpConfirm_Click);
            // 
            // txtLvlUp
            // 
            this.txtLvlUp.Location = new System.Drawing.Point(135, 55);
            this.txtLvlUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtLvlUp.Multiline = true;
            this.txtLvlUp.Name = "txtLvlUp";
            this.txtLvlUp.ReadOnly = true;
            this.txtLvlUp.Size = new System.Drawing.Size(321, 84);
            this.txtLvlUp.TabIndex = 7;
            // 
            // rbtnChaUp
            // 
            this.rbtnChaUp.AutoSize = true;
            this.rbtnChaUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChaUp.Location = new System.Drawing.Point(8, 194);
            this.rbtnChaUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChaUp.Name = "rbtnChaUp";
            this.rbtnChaUp.Size = new System.Drawing.Size(117, 29);
            this.rbtnChaUp.TabIndex = 6;
            this.rbtnChaUp.TabStop = true;
            this.rbtnChaUp.Text = "Charisma";
            this.rbtnChaUp.UseVisualStyleBackColor = true;
            this.rbtnChaUp.Click += new System.EventHandler(this.rbtnChaUp_Click);
            // 
            // rbtnWisUp
            // 
            this.rbtnWisUp.AutoSize = true;
            this.rbtnWisUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWisUp.Location = new System.Drawing.Point(8, 166);
            this.rbtnWisUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWisUp.Name = "rbtnWisUp";
            this.rbtnWisUp.Size = new System.Drawing.Size(105, 29);
            this.rbtnWisUp.TabIndex = 5;
            this.rbtnWisUp.TabStop = true;
            this.rbtnWisUp.Text = "Wisdom";
            this.rbtnWisUp.UseVisualStyleBackColor = true;
            this.rbtnWisUp.Click += new System.EventHandler(this.rbtnWisUp_Click);
            // 
            // rbtnIntUp
            // 
            this.rbtnIntUp.AutoSize = true;
            this.rbtnIntUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIntUp.Location = new System.Drawing.Point(8, 138);
            this.rbtnIntUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnIntUp.Name = "rbtnIntUp";
            this.rbtnIntUp.Size = new System.Drawing.Size(131, 29);
            this.rbtnIntUp.TabIndex = 4;
            this.rbtnIntUp.TabStop = true;
            this.rbtnIntUp.Text = "Intelligence";
            this.rbtnIntUp.UseVisualStyleBackColor = true;
            this.rbtnIntUp.Click += new System.EventHandler(this.rbtnIntUp_Click);
            // 
            // rbtnConUp
            // 
            this.rbtnConUp.AutoSize = true;
            this.rbtnConUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConUp.Location = new System.Drawing.Point(8, 110);
            this.rbtnConUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnConUp.Name = "rbtnConUp";
            this.rbtnConUp.Size = new System.Drawing.Size(136, 29);
            this.rbtnConUp.TabIndex = 3;
            this.rbtnConUp.TabStop = true;
            this.rbtnConUp.Text = "Constitution";
            this.rbtnConUp.UseVisualStyleBackColor = true;
            this.rbtnConUp.Click += new System.EventHandler(this.rbtnConUp_Click);
            // 
            // rbtnDexUp
            // 
            this.rbtnDexUp.AutoSize = true;
            this.rbtnDexUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDexUp.Location = new System.Drawing.Point(8, 81);
            this.rbtnDexUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDexUp.Name = "rbtnDexUp";
            this.rbtnDexUp.Size = new System.Drawing.Size(109, 29);
            this.rbtnDexUp.TabIndex = 2;
            this.rbtnDexUp.TabStop = true;
            this.rbtnDexUp.Text = "Dexterity";
            this.rbtnDexUp.UseVisualStyleBackColor = true;
            this.rbtnDexUp.Click += new System.EventHandler(this.rbtnDexUp_Click);
            // 
            // rbtnStrUp
            // 
            this.rbtnStrUp.AutoSize = true;
            this.rbtnStrUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStrUp.Location = new System.Drawing.Point(8, 53);
            this.rbtnStrUp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnStrUp.Name = "rbtnStrUp";
            this.rbtnStrUp.Size = new System.Drawing.Size(107, 29);
            this.rbtnStrUp.TabIndex = 1;
            this.rbtnStrUp.TabStop = true;
            this.rbtnStrUp.Text = "Strength";
            this.rbtnStrUp.UseVisualStyleBackColor = true;
            this.rbtnStrUp.Click += new System.EventHandler(this.rbtnStrUp_Click);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(8, 20);
            this.label107.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(426, 25);
            this.label107.TabIndex = 0;
            this.label107.Text = "Choose an attribute you wish to raise by 1 point:";
            // 
            // gbxDireBear
            // 
            this.gbxDireBear.BackColor = System.Drawing.Color.Transparent;
            this.gbxDireBear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDireBear.Controls.Add(this.groupBox18);
            this.gbxDireBear.Controls.Add(this.groupBox39);
            this.gbxDireBear.Controls.Add(this.label131);
            this.gbxDireBear.Controls.Add(this.label132);
            this.gbxDireBear.Controls.Add(this.groupBox40);
            this.gbxDireBear.Controls.Add(this.label137);
            this.gbxDireBear.Controls.Add(this.groupBox41);
            this.gbxDireBear.Controls.Add(this.groupBox42);
            this.gbxDireBear.Controls.Add(this.groupBox43);
            this.gbxDireBear.Controls.Add(this.groupBox44);
            this.gbxDireBear.Controls.Add(this.groupBox45);
            this.gbxDireBear.Controls.Add(this.groupBox46);
            this.gbxDireBear.Controls.Add(this.pictureBox23);
            this.gbxDireBear.Controls.Add(this.groupBox47);
            this.gbxDireBear.Controls.Add(this.groupBox48);
            this.gbxDireBear.Location = new System.Drawing.Point(1431, 54);
            this.gbxDireBear.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDireBear.Name = "gbxDireBear";
            this.gbxDireBear.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDireBear.Size = new System.Drawing.Size(468, 578);
            this.gbxDireBear.TabIndex = 38;
            this.gbxDireBear.TabStop = false;
            this.gbxDireBear.Visible = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.panel5);
            this.groupBox18.Location = new System.Drawing.Point(20, 453);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox18.Size = new System.Drawing.Size(433, 113);
            this.groupBox18.TabIndex = 35;
            this.groupBox18.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.label156);
            this.panel5.Controls.Add(this.label110);
            this.panel5.Controls.Add(this.label112);
            this.panel5.Controls.Add(this.label113);
            this.panel5.Controls.Add(this.label115);
            this.panel5.Controls.Add(this.label116);
            this.panel5.Controls.Add(this.label118);
            this.panel5.Controls.Add(this.label119);
            this.panel5.Location = new System.Drawing.Point(5, 16);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(417, 86);
            this.panel5.TabIndex = 10;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(173, 37);
            this.label156.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(32, 17);
            this.label156.TabIndex = 10;
            this.label156.Text = "+10";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(237, 37);
            this.label110.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(22, 17);
            this.label110.TabIndex = 9;
            this.label110.Text = "x2";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(115, 68);
            this.label112.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(16, 17);
            this.label112.TabIndex = 7;
            this.label112.Text = "8";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(113, 37);
            this.label113.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(37, 17);
            this.label113.TabIndex = 8;
            this.label113.Text = "2-16";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(4, 68);
            this.label115.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(87, 17);
            this.label115.TabIndex = 2;
            this.label115.Text = "Base Attack:";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(113, 9);
            this.label116.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(60, 17);
            this.label116.TabIndex = 5;
            this.label116.Text = "+18/+13";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(3, 37);
            this.label118.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(65, 17);
            this.label118.TabIndex = 3;
            this.label118.Text = "Damage:";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(3, 9);
            this.label119.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(95, 17);
            this.label119.TabIndex = 1;
            this.label119.Text = "Attack Bonus:";
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.label125);
            this.groupBox39.Controls.Add(this.label126);
            this.groupBox39.Controls.Add(this.label127);
            this.groupBox39.Controls.Add(this.label128);
            this.groupBox39.Controls.Add(this.label129);
            this.groupBox39.Controls.Add(this.label130);
            this.groupBox39.Location = new System.Drawing.Point(16, 350);
            this.groupBox39.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox39.Size = new System.Drawing.Size(141, 103);
            this.groupBox39.TabIndex = 31;
            this.groupBox39.TabStop = false;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.Location = new System.Drawing.Point(103, 80);
            this.label125.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(18, 20);
            this.label125.TabIndex = 5;
            this.label125.Text = "5";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(8, 78);
            this.label126.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(54, 26);
            this.label126.TabIndex = 4;
            this.label126.Text = "Will:";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.Location = new System.Drawing.Point(103, 48);
            this.label127.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(18, 20);
            this.label127.TabIndex = 3;
            this.label127.Text = "9";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.Location = new System.Drawing.Point(8, 46);
            this.label128.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(80, 26);
            this.label128.TabIndex = 2;
            this.label128.Text = "Reflex:";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.Location = new System.Drawing.Point(103, 16);
            this.label129.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(27, 20);
            this.label129.TabIndex = 1;
            this.label129.Text = "12";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(8, 14);
            this.label130.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(103, 26);
            this.label130.TabIndex = 0;
            this.label130.Text = "Fortitude:";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(271, 21);
            this.label131.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(87, 31);
            this.label131.TabIndex = 33;
            this.label131.Text = "Level:";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(355, 21);
            this.label132.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(39, 29);
            this.label132.TabIndex = 32;
            this.label132.Text = "12";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.lblBearHp);
            this.groupBox40.Controls.Add(this.label134);
            this.groupBox40.Controls.Add(this.label135);
            this.groupBox40.Controls.Add(this.label136);
            this.groupBox40.Location = new System.Drawing.Point(16, 273);
            this.groupBox40.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox40.Size = new System.Drawing.Size(99, 76);
            this.groupBox40.TabIndex = 30;
            this.groupBox40.TabStop = false;
            // 
            // lblBearHp
            // 
            this.lblBearHp.AutoSize = true;
            this.lblBearHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBearHp.Location = new System.Drawing.Point(56, 48);
            this.lblBearHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBearHp.Name = "lblBearHp";
            this.lblBearHp.Size = new System.Drawing.Size(36, 20);
            this.lblBearHp.TabIndex = 3;
            this.lblBearHp.Text = "102";
            this.lblBearHp.TextChanged += new System.EventHandler(this.lblBearHp_TextChanged);
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(8, 44);
            this.label134.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(46, 29);
            this.label134.TabIndex = 2;
            this.label134.Text = "HP";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(56, 17);
            this.label135.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(27, 20);
            this.label135.TabIndex = 1;
            this.label135.Text = "17";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(8, 14);
            this.label136.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(45, 29);
            this.label136.TabIndex = 0;
            this.label136.Text = "AC";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(16, 21);
            this.label137.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(128, 31);
            this.label137.TabIndex = 28;
            this.label137.Text = "Dire Bear";
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.label138);
            this.groupBox41.Controls.Add(this.label139);
            this.groupBox41.Controls.Add(this.label140);
            this.groupBox41.Location = new System.Drawing.Point(184, 289);
            this.groupBox41.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox41.Size = new System.Drawing.Size(249, 41);
            this.groupBox41.TabIndex = 27;
            this.groupBox41.TabStop = false;
            // 
            // label138
            // 
            this.label138.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label138.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.Location = new System.Drawing.Point(208, 11);
            this.label138.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(35, 23);
            this.label138.TabIndex = 2;
            this.label138.Text = "0";
            this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.Location = new System.Drawing.Point(160, 11);
            this.label139.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(29, 22);
            this.label139.TabIndex = 1;
            this.label139.Text = "10";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.Location = new System.Drawing.Point(20, 12);
            this.label140.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(112, 26);
            this.label140.TabIndex = 0;
            this.label140.Text = "Charisma:";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.label141);
            this.groupBox42.Controls.Add(this.label142);
            this.groupBox42.Controls.Add(this.label143);
            this.groupBox42.Location = new System.Drawing.Point(184, 196);
            this.groupBox42.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox42.Size = new System.Drawing.Size(249, 41);
            this.groupBox42.TabIndex = 27;
            this.groupBox42.TabStop = false;
            // 
            // label141
            // 
            this.label141.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(208, 11);
            this.label141.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(35, 23);
            this.label141.TabIndex = 2;
            this.label141.Text = "-4";
            this.label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(160, 11);
            this.label142.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(20, 22);
            this.label142.TabIndex = 1;
            this.label142.Text = "3";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.Location = new System.Drawing.Point(20, 12);
            this.label143.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(128, 26);
            this.label143.TabIndex = 0;
            this.label143.Text = "Intelligence:";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.label144);
            this.groupBox43.Controls.Add(this.label145);
            this.groupBox43.Controls.Add(this.label146);
            this.groupBox43.Location = new System.Drawing.Point(184, 245);
            this.groupBox43.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox43.Size = new System.Drawing.Size(249, 41);
            this.groupBox43.TabIndex = 26;
            this.groupBox43.TabStop = false;
            // 
            // label144
            // 
            this.label144.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.Location = new System.Drawing.Point(208, 11);
            this.label144.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(35, 23);
            this.label144.TabIndex = 2;
            this.label144.Text = "1";
            this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.Location = new System.Drawing.Point(160, 11);
            this.label145.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(29, 22);
            this.label145.TabIndex = 1;
            this.label145.Text = "12";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(20, 12);
            this.label146.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(98, 26);
            this.label146.TabIndex = 0;
            this.label146.Text = "Wisdom:";
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.label147);
            this.groupBox44.Controls.Add(this.label148);
            this.groupBox44.Controls.Add(this.label149);
            this.groupBox44.Location = new System.Drawing.Point(184, 105);
            this.groupBox44.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox44.Size = new System.Drawing.Size(249, 41);
            this.groupBox44.TabIndex = 25;
            this.groupBox44.TabStop = false;
            // 
            // label147
            // 
            this.label147.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(208, 11);
            this.label147.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(35, 23);
            this.label147.TabIndex = 2;
            this.label147.Text = "1";
            this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(160, 11);
            this.label148.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(29, 22);
            this.label148.TabIndex = 1;
            this.label148.Text = "13";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(20, 12);
            this.label149.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(104, 26);
            this.label149.TabIndex = 0;
            this.label149.Text = "Dexterity:";
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.label150);
            this.groupBox45.Controls.Add(this.label151);
            this.groupBox45.Controls.Add(this.label152);
            this.groupBox45.Location = new System.Drawing.Point(184, 151);
            this.groupBox45.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox45.Size = new System.Drawing.Size(249, 41);
            this.groupBox45.TabIndex = 26;
            this.groupBox45.TabStop = false;
            // 
            // label150
            // 
            this.label150.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(208, 11);
            this.label150.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(35, 23);
            this.label150.TabIndex = 2;
            this.label150.Text = "4";
            this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(160, 11);
            this.label151.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(29, 22);
            this.label151.TabIndex = 1;
            this.label151.Text = "19";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(20, 12);
            this.label152.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(133, 26);
            this.label152.TabIndex = 0;
            this.label152.Text = "Constitution:";
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.label153);
            this.groupBox46.Controls.Add(this.label154);
            this.groupBox46.Controls.Add(this.label155);
            this.groupBox46.Location = new System.Drawing.Point(184, 59);
            this.groupBox46.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox46.Size = new System.Drawing.Size(249, 41);
            this.groupBox46.TabIndex = 24;
            this.groupBox46.TabStop = false;
            // 
            // label153
            // 
            this.label153.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(208, 11);
            this.label153.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(35, 23);
            this.label153.TabIndex = 2;
            this.label153.Text = "10";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(160, 11);
            this.label154.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(29, 22);
            this.label154.TabIndex = 1;
            this.label154.Text = "31";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(20, 12);
            this.label155.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(100, 26);
            this.label155.TabIndex = 0;
            this.label155.Text = "Strength:";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox23.BackgroundImage")));
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.Location = new System.Drawing.Point(17, 60);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(155, 209);
            this.pictureBox23.TabIndex = 21;
            this.pictureBox23.TabStop = false;
            // 
            // groupBox47
            // 
            this.groupBox47.Location = new System.Drawing.Point(15, 12);
            this.groupBox47.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox47.Size = new System.Drawing.Size(129, 42);
            this.groupBox47.TabIndex = 31;
            this.groupBox47.TabStop = false;
            // 
            // groupBox48
            // 
            this.groupBox48.Location = new System.Drawing.Point(267, 12);
            this.groupBox48.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox48.Size = new System.Drawing.Size(136, 42);
            this.groupBox48.TabIndex = 34;
            this.groupBox48.TabStop = false;
            // 
            // gbxInventory
            // 
            this.gbxInventory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxInventory.Controls.Add(this.gbxInvProperties);
            this.gbxInventory.Controls.Add(this.groupBox50);
            this.gbxInventory.Controls.Add(this.groupBox49);
            this.gbxInventory.Location = new System.Drawing.Point(484, 234);
            this.gbxInventory.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInventory.Name = "gbxInventory";
            this.gbxInventory.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInventory.Size = new System.Drawing.Size(927, 414);
            this.gbxInventory.TabIndex = 44;
            this.gbxInventory.TabStop = false;
            this.gbxInventory.Visible = false;
            // 
            // gbxInvProperties
            // 
            this.gbxInvProperties.Controls.Add(this.label165);
            this.gbxInvProperties.Controls.Add(this.picBoxInv);
            this.gbxInvProperties.Controls.Add(this.picBoxGreatsword);
            this.gbxInvProperties.Controls.Add(this.picBoxBastardsword);
            this.gbxInvProperties.Controls.Add(this.picBoxLongsword);
            this.gbxInvProperties.Controls.Add(this.picBoxShortsword);
            this.gbxInvProperties.Controls.Add(this.txtInvBonusAc);
            this.gbxInvProperties.Controls.Add(this.lblInvBonusAc);
            this.gbxInvProperties.Controls.Add(this.lblInvName);
            this.gbxInvProperties.Controls.Add(this.lblInvDmgOrArm);
            this.gbxInvProperties.Controls.Add(this.txtInv);
            this.gbxInvProperties.Controls.Add(this.rtxtInv);
            this.gbxInvProperties.Location = new System.Drawing.Point(619, 0);
            this.gbxInvProperties.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInvProperties.Name = "gbxInvProperties";
            this.gbxInvProperties.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInvProperties.Size = new System.Drawing.Size(308, 414);
            this.gbxInvProperties.TabIndex = 1;
            this.gbxInvProperties.TabStop = false;
            this.gbxInvProperties.Visible = false;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(148, 114);
            this.label165.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(177, 29);
            this.label165.TabIndex = 47;
            this.label165.Text = "Other bonuses:";
            // 
            // picBoxInv
            // 
            this.picBoxInv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxInv.Location = new System.Drawing.Point(8, 20);
            this.picBoxInv.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxInv.Name = "picBoxInv";
            this.picBoxInv.Size = new System.Drawing.Size(99, 158);
            this.picBoxInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxInv.TabIndex = 0;
            this.picBoxInv.TabStop = false;
            this.picBoxInv.Visible = false;
            // 
            // picBoxGreatsword
            // 
            this.picBoxGreatsword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxGreatsword.Image")));
            this.picBoxGreatsword.Location = new System.Drawing.Point(9, 20);
            this.picBoxGreatsword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxGreatsword.Name = "picBoxGreatsword";
            this.picBoxGreatsword.Size = new System.Drawing.Size(64, 158);
            this.picBoxGreatsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxGreatsword.TabIndex = 46;
            this.picBoxGreatsword.TabStop = false;
            this.picBoxGreatsword.Visible = false;
            // 
            // picBoxBastardsword
            // 
            this.picBoxBastardsword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBastardsword.Image")));
            this.picBoxBastardsword.Location = new System.Drawing.Point(9, 58);
            this.picBoxBastardsword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxBastardsword.Name = "picBoxBastardsword";
            this.picBoxBastardsword.Size = new System.Drawing.Size(64, 128);
            this.picBoxBastardsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxBastardsword.TabIndex = 45;
            this.picBoxBastardsword.TabStop = false;
            this.picBoxBastardsword.Visible = false;
            // 
            // picBoxLongsword
            // 
            this.picBoxLongsword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLongsword.Image")));
            this.picBoxLongsword.Location = new System.Drawing.Point(9, 57);
            this.picBoxLongsword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxLongsword.Name = "picBoxLongsword";
            this.picBoxLongsword.Size = new System.Drawing.Size(32, 128);
            this.picBoxLongsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLongsword.TabIndex = 44;
            this.picBoxLongsword.TabStop = false;
            this.picBoxLongsword.Visible = false;
            // 
            // picBoxShortsword
            // 
            this.picBoxShortsword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShortsword.Image")));
            this.picBoxShortsword.Location = new System.Drawing.Point(9, 135);
            this.picBoxShortsword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShortsword.Name = "picBoxShortsword";
            this.picBoxShortsword.Size = new System.Drawing.Size(32, 64);
            this.picBoxShortsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShortsword.TabIndex = 18;
            this.picBoxShortsword.TabStop = false;
            this.picBoxShortsword.Visible = false;
            // 
            // txtInvBonusAc
            // 
            this.txtInvBonusAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvBonusAc.Location = new System.Drawing.Point(119, 262);
            this.txtInvBonusAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvBonusAc.Name = "txtInvBonusAc";
            this.txtInvBonusAc.ReadOnly = true;
            this.txtInvBonusAc.Size = new System.Drawing.Size(67, 34);
            this.txtInvBonusAc.TabIndex = 43;
            this.txtInvBonusAc.TabStop = false;
            this.txtInvBonusAc.Text = "0";
            this.txtInvBonusAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvBonusAc.Visible = false;
            // 
            // lblInvBonusAc
            // 
            this.lblInvBonusAc.AutoSize = true;
            this.lblInvBonusAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvBonusAc.Location = new System.Drawing.Point(8, 265);
            this.lblInvBonusAc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvBonusAc.Name = "lblInvBonusAc";
            this.lblInvBonusAc.Size = new System.Drawing.Size(125, 29);
            this.lblInvBonusAc.TabIndex = 42;
            this.lblInvBonusAc.Text = "Bonus AC:";
            this.lblInvBonusAc.Visible = false;
            // 
            // lblInvName
            // 
            this.lblInvName.AutoSize = true;
            this.lblInvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvName.Location = new System.Drawing.Point(147, 26);
            this.lblInvName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvName.Name = "lblInvName";
            this.lblInvName.Size = new System.Drawing.Size(125, 29);
            this.lblInvName.TabIndex = 41;
            this.lblInvName.Text = "Item name";
            // 
            // lblInvDmgOrArm
            // 
            this.lblInvDmgOrArm.AutoSize = true;
            this.lblInvDmgOrArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvDmgOrArm.Location = new System.Drawing.Point(8, 226);
            this.lblInvDmgOrArm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvDmgOrArm.Name = "lblInvDmgOrArm";
            this.lblInvDmgOrArm.Size = new System.Drawing.Size(110, 29);
            this.lblInvDmgOrArm.TabIndex = 3;
            this.lblInvDmgOrArm.Text = "Damage:";
            // 
            // txtInv
            // 
            this.txtInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInv.Location = new System.Drawing.Point(119, 223);
            this.txtInv.Margin = new System.Windows.Forms.Padding(4);
            this.txtInv.Name = "txtInv";
            this.txtInv.ReadOnly = true;
            this.txtInv.Size = new System.Drawing.Size(67, 34);
            this.txtInv.TabIndex = 2;
            this.txtInv.TabStop = false;
            this.txtInv.Text = "25";
            this.txtInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxtInv
            // 
            this.rtxtInv.Location = new System.Drawing.Point(1, 303);
            this.rtxtInv.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtInv.Name = "rtxtInv";
            this.rtxtInv.ReadOnly = true;
            this.rtxtInv.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtInv.Size = new System.Drawing.Size(301, 109);
            this.rtxtInv.TabIndex = 1;
            this.rtxtInv.TabStop = false;
            this.rtxtInv.Text = "Description box: this is a description box where items description is descriptive" +
    "ly descripted. I\'m too lasy to find and/or type the description for each individ" +
    "ual item...\n";
            // 
            // groupBox50
            // 
            this.groupBox50.Controls.Add(this.label173);
            this.groupBox50.Controls.Add(this.lbxAC);
            this.groupBox50.Controls.Add(this.lbxInvWeapon);
            this.groupBox50.Location = new System.Drawing.Point(309, 0);
            this.groupBox50.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox50.Name = "groupBox50";
            this.groupBox50.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox50.Size = new System.Drawing.Size(307, 414);
            this.groupBox50.TabIndex = 1;
            this.groupBox50.TabStop = false;
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.Location = new System.Drawing.Point(1, 278);
            this.label173.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(358, 144);
            this.label173.TabIndex = 15;
            this.label173.Text = resources.GetString("label173.Text");
            // 
            // lbxAC
            // 
            this.lbxAC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAC.FormattingEnabled = true;
            this.lbxAC.ItemHeight = 29;
            this.lbxAC.Items.AddRange(new object[] {
            "Armor, Boots, Helmet and Necklace"});
            this.lbxAC.Location = new System.Drawing.Point(12, 20);
            this.lbxAC.Margin = new System.Windows.Forms.Padding(4);
            this.lbxAC.Name = "lbxAC";
            this.lbxAC.Size = new System.Drawing.Size(281, 205);
            this.lbxAC.TabIndex = 17;
            this.lbxAC.TabStop = false;
            this.lbxAC.Visible = false;
            this.lbxAC.Click += new System.EventHandler(this.lbxAC_Click);
            this.lbxAC.DoubleClick += new System.EventHandler(this.lbxAC_DoubleClick);
            // 
            // lbxInvWeapon
            // 
            this.lbxInvWeapon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxInvWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxInvWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxInvWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInvWeapon.FormattingEnabled = true;
            this.lbxInvWeapon.ItemHeight = 29;
            this.lbxInvWeapon.Items.AddRange(new object[] {
            "Shortsword"});
            this.lbxInvWeapon.Location = new System.Drawing.Point(13, 20);
            this.lbxInvWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.lbxInvWeapon.Name = "lbxInvWeapon";
            this.lbxInvWeapon.Size = new System.Drawing.Size(281, 205);
            this.lbxInvWeapon.TabIndex = 16;
            this.lbxInvWeapon.TabStop = false;
            this.lbxInvWeapon.Visible = false;
            this.lbxInvWeapon.Click += new System.EventHandler(this.lbxWeapon_Click);
            this.lbxInvWeapon.DoubleClick += new System.EventHandler(this.lbxInvWeapon_DoubleClick);
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.lblInvNecklace);
            this.groupBox49.Controls.Add(this.lblInvBoots);
            this.groupBox49.Controls.Add(this.lblInvHelmet);
            this.groupBox49.Controls.Add(this.lblInvArmor);
            this.groupBox49.Controls.Add(this.lblInvWeapon);
            this.groupBox49.Controls.Add(this.txtInvGold);
            this.groupBox49.Controls.Add(this.label172);
            this.groupBox49.Controls.Add(this.lblInvN);
            this.groupBox49.Controls.Add(this.label170);
            this.groupBox49.Controls.Add(this.label169);
            this.groupBox49.Controls.Add(this.lblInvB);
            this.groupBox49.Controls.Add(this.label167);
            this.groupBox49.Controls.Add(this.lblInvH);
            this.groupBox49.Controls.Add(this.lblInvA);
            this.groupBox49.Controls.Add(this.lblInvW);
            this.groupBox49.Location = new System.Drawing.Point(0, 0);
            this.groupBox49.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox49.Size = new System.Drawing.Size(307, 414);
            this.groupBox49.TabIndex = 0;
            this.groupBox49.TabStop = false;
            // 
            // lblInvNecklace
            // 
            this.lblInvNecklace.AutoSize = true;
            this.lblInvNecklace.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvNecklace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvNecklace.Location = new System.Drawing.Point(109, 186);
            this.lblInvNecklace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvNecklace.Name = "lblInvNecklace";
            this.lblInvNecklace.Size = new System.Drawing.Size(119, 29);
            this.lblInvNecklace.TabIndex = 14;
            this.lblInvNecklace.Text = "Shoelace";
            // 
            // lblInvBoots
            // 
            this.lblInvBoots.AutoSize = true;
            this.lblInvBoots.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvBoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvBoots.Location = new System.Drawing.Point(109, 144);
            this.lblInvBoots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvBoots.Name = "lblInvBoots";
            this.lblInvBoots.Size = new System.Drawing.Size(105, 29);
            this.lblInvBoots.TabIndex = 13;
            this.lblInvBoots.Text = "Slippers";
            // 
            // lblInvHelmet
            // 
            this.lblInvHelmet.AutoSize = true;
            this.lblInvHelmet.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvHelmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvHelmet.Location = new System.Drawing.Point(109, 102);
            this.lblInvHelmet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvHelmet.Name = "lblInvHelmet";
            this.lblInvHelmet.Size = new System.Drawing.Size(124, 29);
            this.lblInvHelmet.TabIndex = 12;
            this.lblInvHelmet.Text = "Sombrero";
            // 
            // lblInvArmor
            // 
            this.lblInvArmor.AutoSize = true;
            this.lblInvArmor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvArmor.Location = new System.Drawing.Point(109, 60);
            this.lblInvArmor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvArmor.Name = "lblInvArmor";
            this.lblInvArmor.Size = new System.Drawing.Size(164, 29);
            this.lblInvArmor.TabIndex = 11;
            this.lblInvArmor.Text = "Invisible Shirt";
            // 
            // lblInvWeapon
            // 
            this.lblInvWeapon.AutoSize = true;
            this.lblInvWeapon.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvWeapon.Location = new System.Drawing.Point(109, 18);
            this.lblInvWeapon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvWeapon.Name = "lblInvWeapon";
            this.lblInvWeapon.Size = new System.Drawing.Size(140, 29);
            this.lblInvWeapon.TabIndex = 10;
            this.lblInvWeapon.Text = "Shortsword";
            // 
            // txtInvGold
            // 
            this.txtInvGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvGold.Location = new System.Drawing.Point(113, 362);
            this.txtInvGold.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvGold.Name = "txtInvGold";
            this.txtInvGold.ReadOnly = true;
            this.txtInvGold.Size = new System.Drawing.Size(184, 41);
            this.txtInvGold.TabIndex = 9;
            this.txtInvGold.TabStop = false;
            this.txtInvGold.Text = "0";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.Location = new System.Drawing.Point(8, 368);
            this.label172.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(87, 36);
            this.label172.TabIndex = 8;
            this.label172.Text = "Gold:";
            // 
            // lblInvN
            // 
            this.lblInvN.AutoSize = true;
            this.lblInvN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInvN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvN.Location = new System.Drawing.Point(8, 186);
            this.lblInvN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvN.Name = "lblInvN";
            this.lblInvN.Size = new System.Drawing.Size(125, 29);
            this.lblInvN.TabIndex = 7;
            this.lblInvN.Text = "Necklace:";
            this.lblInvN.Click += new System.EventHandler(this.lblInvN_Click);
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.Location = new System.Drawing.Point(8, 311);
            this.label170.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(72, 29);
            this.label170.TabIndex = 6;
            this.label170.Text = "Ring:";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label169.Location = new System.Drawing.Point(8, 228);
            this.label169.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(64, 29);
            this.label169.TabIndex = 5;
            this.label169.Text = "Belt:";
            // 
            // lblInvB
            // 
            this.lblInvB.AutoSize = true;
            this.lblInvB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInvB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvB.Location = new System.Drawing.Point(8, 144);
            this.lblInvB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvB.Name = "lblInvB";
            this.lblInvB.Size = new System.Drawing.Size(85, 29);
            this.lblInvB.TabIndex = 4;
            this.lblInvB.Text = "Boots:";
            this.lblInvB.Click += new System.EventHandler(this.lblInvB_Click);
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label167.Location = new System.Drawing.Point(8, 270);
            this.label167.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(85, 29);
            this.label167.TabIndex = 3;
            this.label167.Text = "Cloak:";
            // 
            // lblInvH
            // 
            this.lblInvH.AutoSize = true;
            this.lblInvH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInvH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvH.Location = new System.Drawing.Point(8, 102);
            this.lblInvH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvH.Name = "lblInvH";
            this.lblInvH.Size = new System.Drawing.Size(101, 29);
            this.lblInvH.TabIndex = 2;
            this.lblInvH.Text = "Helmet:";
            this.lblInvH.Click += new System.EventHandler(this.lblInvH_Click);
            // 
            // lblInvA
            // 
            this.lblInvA.AutoSize = true;
            this.lblInvA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInvA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvA.Location = new System.Drawing.Point(8, 60);
            this.lblInvA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvA.Name = "lblInvA";
            this.lblInvA.Size = new System.Drawing.Size(89, 29);
            this.lblInvA.TabIndex = 1;
            this.lblInvA.Text = "Armor:";
            this.lblInvA.Click += new System.EventHandler(this.lblInvA_Click);
            // 
            // lblInvW
            // 
            this.lblInvW.AutoSize = true;
            this.lblInvW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInvW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvW.Location = new System.Drawing.Point(8, 18);
            this.lblInvW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvW.Name = "lblInvW";
            this.lblInvW.Size = new System.Drawing.Size(114, 29);
            this.lblInvW.TabIndex = 0;
            this.lblInvW.Text = "Weapon:";
            this.lblInvW.Click += new System.EventHandler(this.lblInvW_Click);
            // 
            // lbxArmor
            // 
            this.lbxArmor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxArmor.FormattingEnabled = true;
            this.lbxArmor.ItemHeight = 29;
            this.lbxArmor.Items.AddRange(new object[] {
            "Invisible Shirt"});
            this.lbxArmor.Location = new System.Drawing.Point(339, 734);
            this.lbxArmor.Margin = new System.Windows.Forms.Padding(4);
            this.lbxArmor.Name = "lbxArmor";
            this.lbxArmor.Size = new System.Drawing.Size(281, 292);
            this.lbxArmor.TabIndex = 17;
            this.lbxArmor.TabStop = false;
            this.lbxArmor.Visible = false;
            // 
            // lbxHelmet
            // 
            this.lbxHelmet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxHelmet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxHelmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxHelmet.FormattingEnabled = true;
            this.lbxHelmet.ItemHeight = 29;
            this.lbxHelmet.Items.AddRange(new object[] {
            "Sombrero"});
            this.lbxHelmet.Location = new System.Drawing.Point(336, 767);
            this.lbxHelmet.Margin = new System.Windows.Forms.Padding(4);
            this.lbxHelmet.Name = "lbxHelmet";
            this.lbxHelmet.Size = new System.Drawing.Size(281, 292);
            this.lbxHelmet.TabIndex = 45;
            this.lbxHelmet.TabStop = false;
            this.lbxHelmet.Visible = false;
            // 
            // lbxBoots
            // 
            this.lbxBoots.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxBoots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxBoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBoots.FormattingEnabled = true;
            this.lbxBoots.ItemHeight = 29;
            this.lbxBoots.Items.AddRange(new object[] {
            "Slippers"});
            this.lbxBoots.Location = new System.Drawing.Point(279, 809);
            this.lbxBoots.Margin = new System.Windows.Forms.Padding(4);
            this.lbxBoots.Name = "lbxBoots";
            this.lbxBoots.Size = new System.Drawing.Size(281, 292);
            this.lbxBoots.TabIndex = 46;
            this.lbxBoots.TabStop = false;
            this.lbxBoots.Visible = false;
            // 
            // lbxNecklace
            // 
            this.lbxNecklace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxNecklace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxNecklace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNecklace.FormattingEnabled = true;
            this.lbxNecklace.ItemHeight = 29;
            this.lbxNecklace.Items.AddRange(new object[] {
            "Shoelace"});
            this.lbxNecklace.Location = new System.Drawing.Point(336, 837);
            this.lbxNecklace.Margin = new System.Windows.Forms.Padding(4);
            this.lbxNecklace.Name = "lbxNecklace";
            this.lbxNecklace.Size = new System.Drawing.Size(281, 292);
            this.lbxNecklace.TabIndex = 47;
            this.lbxNecklace.TabStop = false;
            this.lbxNecklace.Visible = false;
            // 
            // imageListArmors
            // 
            this.imageListArmors.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListArmors.ImageStream")));
            this.imageListArmors.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListArmors.Images.SetKeyName(0, "Chain_shirt.jpg");
            this.imageListArmors.Images.SetKeyName(1, "Chainmail.jpg");
            this.imageListArmors.Images.SetKeyName(2, "Half_plate.jpg");
            this.imageListArmors.Images.SetKeyName(3, "Full_plate.jpg");
            // 
            // imageListBootsAndHelmetsAndNecklaces
            // 
            this.imageListBootsAndHelmetsAndNecklaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBootsAndHelmetsAndNecklaces.ImageStream")));
            this.imageListBootsAndHelmetsAndNecklaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(0, "Slippers.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(1, "Carolina-Boots.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(2, "redside_sm.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(3, "timberland-6-premium-waterproof-boots-mens.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(4, "sombrero.png");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(5, "staghelmet.gif");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(6, "wingedhelmet.gif");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(7, "Spikehelmet.gif");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(8, "shoelace_bow.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(9, "fdf.jpg");
            this.imageListBootsAndHelmetsAndNecklaces.Images.SetKeyName(10, "khwab-necklace-set-by-sanskruti-medium_cfcda6ac228f58605c7477cb5f73495e.jpg");
            // 
            // btnResetHero
            // 
            this.btnResetHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetHero.Location = new System.Drawing.Point(251, 709);
            this.btnResetHero.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetHero.Name = "btnResetHero";
            this.btnResetHero.Size = new System.Drawing.Size(108, 31);
            this.btnResetHero.TabIndex = 48;
            this.btnResetHero.Text = "Reset";
            this.btnResetHero.UseVisualStyleBackColor = true;
            this.btnResetHero.Visible = false;
            this.btnResetHero.Click += new System.EventHandler(this.btnRespawn_Click);
            // 
            // gbxDragon
            // 
            this.gbxDragon.BackColor = System.Drawing.Color.Transparent;
            this.gbxDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDragon.Controls.Add(this.groupBox52);
            this.gbxDragon.Controls.Add(this.groupBox53);
            this.gbxDragon.Controls.Add(this.label185);
            this.gbxDragon.Controls.Add(this.label186);
            this.gbxDragon.Controls.Add(this.groupBox54);
            this.gbxDragon.Controls.Add(this.label191);
            this.gbxDragon.Controls.Add(this.groupBox55);
            this.gbxDragon.Controls.Add(this.groupBox56);
            this.gbxDragon.Controls.Add(this.groupBox57);
            this.gbxDragon.Controls.Add(this.groupBox58);
            this.gbxDragon.Controls.Add(this.groupBox59);
            this.gbxDragon.Controls.Add(this.groupBox60);
            this.gbxDragon.Controls.Add(this.pictureBox24);
            this.gbxDragon.Controls.Add(this.groupBox61);
            this.gbxDragon.Controls.Add(this.groupBox62);
            this.gbxDragon.Location = new System.Drawing.Point(1431, 54);
            this.gbxDragon.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDragon.Name = "gbxDragon";
            this.gbxDragon.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDragon.Size = new System.Drawing.Size(468, 578);
            this.gbxDragon.TabIndex = 38;
            this.gbxDragon.TabStop = false;
            this.gbxDragon.Visible = false;
            // 
            // groupBox52
            // 
            this.groupBox52.Controls.Add(this.panel6);
            this.groupBox52.Location = new System.Drawing.Point(20, 453);
            this.groupBox52.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox52.Name = "groupBox52";
            this.groupBox52.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox52.Size = new System.Drawing.Size(433, 113);
            this.groupBox52.TabIndex = 35;
            this.groupBox52.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.label210);
            this.panel6.Controls.Add(this.label168);
            this.panel6.Controls.Add(this.label171);
            this.panel6.Controls.Add(this.label174);
            this.panel6.Controls.Add(this.label175);
            this.panel6.Controls.Add(this.label176);
            this.panel6.Controls.Add(this.label177);
            this.panel6.Controls.Add(this.label178);
            this.panel6.Location = new System.Drawing.Point(5, 16);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(417, 86);
            this.panel6.TabIndex = 10;
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(171, 37);
            this.label210.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(32, 17);
            this.label210.TabIndex = 10;
            this.label210.Text = "+13";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(237, 37);
            this.label168.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(22, 17);
            this.label168.TabIndex = 9;
            this.label168.Text = "x2";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(115, 68);
            this.label171.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(24, 17);
            this.label171.TabIndex = 7;
            this.label171.Text = "21";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(113, 37);
            this.label174.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(37, 17);
            this.label174.TabIndex = 8;
            this.label174.Text = "2-16";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(4, 68);
            this.label175.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(87, 17);
            this.label175.TabIndex = 2;
            this.label175.Text = "Base Attack:";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(113, 9);
            this.label176.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(116, 17);
            this.label176.TabIndex = 5;
            this.label176.Text = "+32/+27/+22/+17";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(3, 37);
            this.label177.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(65, 17);
            this.label177.TabIndex = 3;
            this.label177.Text = "Damage:";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(3, 9);
            this.label178.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(95, 17);
            this.label178.TabIndex = 1;
            this.label178.Text = "Attack Bonus:";
            // 
            // groupBox53
            // 
            this.groupBox53.Controls.Add(this.label179);
            this.groupBox53.Controls.Add(this.label180);
            this.groupBox53.Controls.Add(this.label181);
            this.groupBox53.Controls.Add(this.label182);
            this.groupBox53.Controls.Add(this.label183);
            this.groupBox53.Controls.Add(this.label184);
            this.groupBox53.Location = new System.Drawing.Point(16, 350);
            this.groupBox53.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox53.Name = "groupBox53";
            this.groupBox53.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox53.Size = new System.Drawing.Size(141, 103);
            this.groupBox53.TabIndex = 31;
            this.groupBox53.TabStop = false;
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label179.Location = new System.Drawing.Point(107, 78);
            this.label179.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(27, 20);
            this.label179.TabIndex = 5;
            this.label179.Text = "18";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label180.Location = new System.Drawing.Point(8, 78);
            this.label180.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(54, 26);
            this.label180.TabIndex = 4;
            this.label180.Text = "Will:";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label181.Location = new System.Drawing.Point(107, 46);
            this.label181.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(27, 20);
            this.label181.TabIndex = 3;
            this.label181.Text = "14";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label182.Location = new System.Drawing.Point(8, 46);
            this.label182.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(80, 26);
            this.label182.TabIndex = 2;
            this.label182.Text = "Reflex:";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label183.Location = new System.Drawing.Point(107, 14);
            this.label183.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(27, 20);
            this.label183.TabIndex = 1;
            this.label183.Text = "19";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label184.Location = new System.Drawing.Point(8, 14);
            this.label184.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(103, 26);
            this.label184.TabIndex = 0;
            this.label184.Text = "Fortitude:";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label185.Location = new System.Drawing.Point(271, 21);
            this.label185.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(87, 31);
            this.label185.TabIndex = 33;
            this.label185.Text = "Level:";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label186.Location = new System.Drawing.Point(355, 21);
            this.label186.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(39, 29);
            this.label186.TabIndex = 32;
            this.label186.Text = "23";
            // 
            // groupBox54
            // 
            this.groupBox54.Controls.Add(this.lblDragonHp);
            this.groupBox54.Controls.Add(this.label188);
            this.groupBox54.Controls.Add(this.label189);
            this.groupBox54.Controls.Add(this.label190);
            this.groupBox54.Location = new System.Drawing.Point(16, 273);
            this.groupBox54.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox54.Name = "groupBox54";
            this.groupBox54.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox54.Size = new System.Drawing.Size(127, 76);
            this.groupBox54.TabIndex = 30;
            this.groupBox54.TabStop = false;
            // 
            // lblDragonHp
            // 
            this.lblDragonHp.AutoSize = true;
            this.lblDragonHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragonHp.Location = new System.Drawing.Point(67, 48);
            this.lblDragonHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDragonHp.Name = "lblDragonHp";
            this.lblDragonHp.Size = new System.Drawing.Size(36, 20);
            this.lblDragonHp.TabIndex = 3;
            this.lblDragonHp.Text = "287";
            this.lblDragonHp.TextChanged += new System.EventHandler(this.lblDragonHp_TextChanged);
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label188.Location = new System.Drawing.Point(8, 44);
            this.label188.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(46, 29);
            this.label188.TabIndex = 2;
            this.label188.Text = "HP";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label189.Location = new System.Drawing.Point(67, 20);
            this.label189.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(27, 20);
            this.label189.TabIndex = 1;
            this.label189.Text = "31";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label190.Location = new System.Drawing.Point(8, 14);
            this.label190.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(45, 29);
            this.label190.TabIndex = 0;
            this.label190.Text = "AC";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label191.Location = new System.Drawing.Point(16, 21);
            this.label191.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(103, 31);
            this.label191.TabIndex = 28;
            this.label191.Text = "Dragon";
            // 
            // groupBox55
            // 
            this.groupBox55.Controls.Add(this.label192);
            this.groupBox55.Controls.Add(this.label193);
            this.groupBox55.Controls.Add(this.label194);
            this.groupBox55.Location = new System.Drawing.Point(184, 289);
            this.groupBox55.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox55.Name = "groupBox55";
            this.groupBox55.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox55.Size = new System.Drawing.Size(249, 41);
            this.groupBox55.TabIndex = 27;
            this.groupBox55.TabStop = false;
            // 
            // label192
            // 
            this.label192.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label192.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label192.Location = new System.Drawing.Point(208, 11);
            this.label192.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(35, 23);
            this.label192.TabIndex = 2;
            this.label192.Text = "3";
            this.label192.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label193.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label193.Location = new System.Drawing.Point(160, 11);
            this.label193.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(29, 22);
            this.label193.TabIndex = 1;
            this.label193.Text = "16";
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label194.Location = new System.Drawing.Point(20, 12);
            this.label194.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(112, 26);
            this.label194.TabIndex = 0;
            this.label194.Text = "Charisma:";
            // 
            // groupBox56
            // 
            this.groupBox56.Controls.Add(this.label195);
            this.groupBox56.Controls.Add(this.label196);
            this.groupBox56.Controls.Add(this.label197);
            this.groupBox56.Location = new System.Drawing.Point(184, 196);
            this.groupBox56.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox56.Name = "groupBox56";
            this.groupBox56.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox56.Size = new System.Drawing.Size(249, 41);
            this.groupBox56.TabIndex = 27;
            this.groupBox56.TabStop = false;
            // 
            // label195
            // 
            this.label195.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label195.Location = new System.Drawing.Point(208, 11);
            this.label195.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(35, 23);
            this.label195.TabIndex = 2;
            this.label195.Text = "3";
            this.label195.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label196.Location = new System.Drawing.Point(160, 11);
            this.label196.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(29, 22);
            this.label196.TabIndex = 1;
            this.label196.Text = "17";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label197.Location = new System.Drawing.Point(20, 12);
            this.label197.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(128, 26);
            this.label197.TabIndex = 0;
            this.label197.Text = "Intelligence:";
            // 
            // groupBox57
            // 
            this.groupBox57.Controls.Add(this.label198);
            this.groupBox57.Controls.Add(this.label199);
            this.groupBox57.Controls.Add(this.label200);
            this.groupBox57.Location = new System.Drawing.Point(184, 245);
            this.groupBox57.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox57.Name = "groupBox57";
            this.groupBox57.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox57.Size = new System.Drawing.Size(249, 41);
            this.groupBox57.TabIndex = 26;
            this.groupBox57.TabStop = false;
            // 
            // label198
            // 
            this.label198.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label198.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label198.Location = new System.Drawing.Point(208, 11);
            this.label198.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(35, 23);
            this.label198.TabIndex = 2;
            this.label198.Text = "5";
            this.label198.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label199.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label199.Location = new System.Drawing.Point(160, 11);
            this.label199.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(29, 22);
            this.label199.TabIndex = 1;
            this.label199.Text = "20";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label200.Location = new System.Drawing.Point(20, 12);
            this.label200.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(98, 26);
            this.label200.TabIndex = 0;
            this.label200.Text = "Wisdom:";
            // 
            // groupBox58
            // 
            this.groupBox58.Controls.Add(this.label201);
            this.groupBox58.Controls.Add(this.label202);
            this.groupBox58.Controls.Add(this.label203);
            this.groupBox58.Location = new System.Drawing.Point(184, 105);
            this.groupBox58.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox58.Name = "groupBox58";
            this.groupBox58.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox58.Size = new System.Drawing.Size(249, 41);
            this.groupBox58.TabIndex = 25;
            this.groupBox58.TabStop = false;
            // 
            // label201
            // 
            this.label201.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label201.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label201.Location = new System.Drawing.Point(208, 11);
            this.label201.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(35, 23);
            this.label201.TabIndex = 2;
            this.label201.Text = "1";
            this.label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label202.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label202.Location = new System.Drawing.Point(160, 11);
            this.label202.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(29, 22);
            this.label202.TabIndex = 1;
            this.label202.Text = "12";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label203.Location = new System.Drawing.Point(20, 12);
            this.label203.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(104, 26);
            this.label203.TabIndex = 0;
            this.label203.Text = "Dexterity:";
            // 
            // groupBox59
            // 
            this.groupBox59.Controls.Add(this.label204);
            this.groupBox59.Controls.Add(this.label205);
            this.groupBox59.Controls.Add(this.label206);
            this.groupBox59.Location = new System.Drawing.Point(184, 151);
            this.groupBox59.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox59.Name = "groupBox59";
            this.groupBox59.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox59.Size = new System.Drawing.Size(249, 41);
            this.groupBox59.TabIndex = 26;
            this.groupBox59.TabStop = false;
            // 
            // label204
            // 
            this.label204.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label204.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label204.Location = new System.Drawing.Point(208, 11);
            this.label204.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(35, 23);
            this.label204.TabIndex = 2;
            this.label204.Text = "6";
            this.label204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label205.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label205.Location = new System.Drawing.Point(160, 11);
            this.label205.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(29, 22);
            this.label205.TabIndex = 1;
            this.label205.Text = "22";
            // 
            // label206
            // 
            this.label206.AutoSize = true;
            this.label206.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label206.Location = new System.Drawing.Point(20, 12);
            this.label206.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(133, 26);
            this.label206.TabIndex = 0;
            this.label206.Text = "Constitution:";
            // 
            // groupBox60
            // 
            this.groupBox60.Controls.Add(this.label207);
            this.groupBox60.Controls.Add(this.label208);
            this.groupBox60.Controls.Add(this.label209);
            this.groupBox60.Location = new System.Drawing.Point(184, 59);
            this.groupBox60.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox60.Name = "groupBox60";
            this.groupBox60.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox60.Size = new System.Drawing.Size(249, 41);
            this.groupBox60.TabIndex = 24;
            this.groupBox60.TabStop = false;
            // 
            // label207
            // 
            this.label207.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label207.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label207.Location = new System.Drawing.Point(208, 11);
            this.label207.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(35, 23);
            this.label207.TabIndex = 2;
            this.label207.Text = "11";
            this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label208.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label208.Location = new System.Drawing.Point(160, 11);
            this.label208.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(29, 22);
            this.label208.TabIndex = 1;
            this.label208.Text = "33";
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label209.Location = new System.Drawing.Point(20, 12);
            this.label209.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(100, 26);
            this.label209.TabIndex = 0;
            this.label209.Text = "Strength:";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox24.BackgroundImage")));
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(17, 60);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(155, 209);
            this.pictureBox24.TabIndex = 21;
            this.pictureBox24.TabStop = false;
            // 
            // groupBox61
            // 
            this.groupBox61.Location = new System.Drawing.Point(15, 12);
            this.groupBox61.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox61.Name = "groupBox61";
            this.groupBox61.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox61.Size = new System.Drawing.Size(105, 42);
            this.groupBox61.TabIndex = 31;
            this.groupBox61.TabStop = false;
            // 
            // groupBox62
            // 
            this.groupBox62.Location = new System.Drawing.Point(267, 12);
            this.groupBox62.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox62.Name = "groupBox62";
            this.groupBox62.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox62.Size = new System.Drawing.Size(136, 42);
            this.groupBox62.TabIndex = 34;
            this.groupBox62.TabStop = false;
            // 
            // lblGoldMessage
            // 
            this.lblGoldMessage.AutoSize = true;
            this.lblGoldMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGoldMessage.Location = new System.Drawing.Point(703, 646);
            this.lblGoldMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoldMessage.Name = "lblGoldMessage";
            this.lblGoldMessage.Size = new System.Drawing.Size(576, 31);
            this.lblGoldMessage.TabIndex = 49;
            this.lblGoldMessage.Text = "You gained some gold!!! Check your inventory!";
            this.lblGoldMessage.Visible = false;
            // 
            // gbxPotions
            // 
            this.gbxPotions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxPotions.Controls.Add(this.label211);
            this.gbxPotions.Controls.Add(this.txtHeal50);
            this.gbxPotions.Controls.Add(this.btnHeal50);
            this.gbxPotions.Controls.Add(this.label187);
            this.gbxPotions.Controls.Add(this.txtHeal10);
            this.gbxPotions.Controls.Add(this.btnHeal10);
            this.gbxPotions.Controls.Add(this.label164);
            this.gbxPotions.Controls.Add(this.txtHeal2);
            this.gbxPotions.Controls.Add(this.btnLightHeal);
            this.gbxPotions.Controls.Add(this.lblMinusHeal2);
            this.gbxPotions.Controls.Add(this.lblHeal2);
            this.gbxPotions.Controls.Add(this.lblMinusHeal10);
            this.gbxPotions.Controls.Add(this.lblHeal10);
            this.gbxPotions.Controls.Add(this.lblMinusHeal50);
            this.gbxPotions.Controls.Add(this.lblHeal50);
            this.gbxPotions.Location = new System.Drawing.Point(16, 757);
            this.gbxPotions.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPotions.Name = "gbxPotions";
            this.gbxPotions.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPotions.Size = new System.Drawing.Size(348, 207);
            this.gbxPotions.TabIndex = 50;
            this.gbxPotions.TabStop = false;
            this.gbxPotions.Visible = false;
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label211.Location = new System.Drawing.Point(260, 144);
            this.label211.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(99, 60);
            this.label211.TabIndex = 50;
            this.label211.Text = "Heal critical\r\nwounds\r\n(+50)";
            this.label211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeal50
            // 
            this.txtHeal50.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHeal50.Location = new System.Drawing.Point(281, 23);
            this.txtHeal50.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeal50.Name = "txtHeal50";
            this.txtHeal50.ReadOnly = true;
            this.txtHeal50.Size = new System.Drawing.Size(40, 22);
            this.txtHeal50.TabIndex = 48;
            this.txtHeal50.TabStop = false;
            this.txtHeal50.Text = "0";
            this.txtHeal50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeal50.TextChanged += new System.EventHandler(this.txtHeal50_TextChanged);
            // 
            // btnHeal50
            // 
            this.btnHeal50.Enabled = false;
            this.btnHeal50.Image = ((System.Drawing.Image)(resources.GetObject("btnHeal50.Image")));
            this.btnHeal50.Location = new System.Drawing.Point(281, 63);
            this.btnHeal50.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeal50.Name = "btnHeal50";
            this.btnHeal50.Size = new System.Drawing.Size(41, 74);
            this.btnHeal50.TabIndex = 49;
            this.btnHeal50.TabStop = false;
            this.btnHeal50.UseVisualStyleBackColor = true;
            this.btnHeal50.Click += new System.EventHandler(this.btnHeal50_Click);
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label187.Location = new System.Drawing.Point(128, 144);
            this.label187.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(104, 60);
            this.label187.TabIndex = 47;
            this.label187.Text = "Heal serious\r\nwounds\r\n(+10)";
            this.label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeal10
            // 
            this.txtHeal10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHeal10.Location = new System.Drawing.Point(148, 23);
            this.txtHeal10.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeal10.Name = "txtHeal10";
            this.txtHeal10.ReadOnly = true;
            this.txtHeal10.Size = new System.Drawing.Size(40, 22);
            this.txtHeal10.TabIndex = 45;
            this.txtHeal10.TabStop = false;
            this.txtHeal10.Text = "1";
            this.txtHeal10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeal10.TextChanged += new System.EventHandler(this.txtHeal10_TextChanged);
            // 
            // btnHeal10
            // 
            this.btnHeal10.Image = ((System.Drawing.Image)(resources.GetObject("btnHeal10.Image")));
            this.btnHeal10.Location = new System.Drawing.Point(148, 63);
            this.btnHeal10.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeal10.Name = "btnHeal10";
            this.btnHeal10.Size = new System.Drawing.Size(41, 74);
            this.btnHeal10.TabIndex = 46;
            this.btnHeal10.TabStop = false;
            this.btnHeal10.UseVisualStyleBackColor = true;
            this.btnHeal10.Click += new System.EventHandler(this.btnHeal10_Click);
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(8, 144);
            this.label164.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(80, 60);
            this.label164.TabIndex = 44;
            this.label164.Text = "Heal light\r\nwounds\r\n(+2)";
            this.label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeal2
            // 
            this.txtHeal2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHeal2.Location = new System.Drawing.Point(17, 23);
            this.txtHeal2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeal2.Name = "txtHeal2";
            this.txtHeal2.ReadOnly = true;
            this.txtHeal2.Size = new System.Drawing.Size(40, 22);
            this.txtHeal2.TabIndex = 0;
            this.txtHeal2.TabStop = false;
            this.txtHeal2.Text = "3";
            this.txtHeal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeal2.TextChanged += new System.EventHandler(this.txtHeal2_TextChanged);
            // 
            // lblMinusHeal2
            // 
            this.lblMinusHeal2.AutoSize = true;
            this.lblMinusHeal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusHeal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMinusHeal2.Location = new System.Drawing.Point(19, -9);
            this.lblMinusHeal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinusHeal2.Name = "lblMinusHeal2";
            this.lblMinusHeal2.Size = new System.Drawing.Size(44, 36);
            this.lblMinusHeal2.TabIndex = 55;
            this.lblMinusHeal2.Text = "-1";
            this.lblMinusHeal2.Visible = false;
            // 
            // lblHeal2
            // 
            this.lblHeal2.AutoSize = true;
            this.lblHeal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHeal2.Location = new System.Drawing.Point(16, -9);
            this.lblHeal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeal2.Name = "lblHeal2";
            this.lblHeal2.Size = new System.Drawing.Size(51, 36);
            this.lblHeal2.TabIndex = 52;
            this.lblHeal2.Text = "+1";
            this.lblHeal2.Visible = false;
            // 
            // lblMinusHeal10
            // 
            this.lblMinusHeal10.AutoSize = true;
            this.lblMinusHeal10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusHeal10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMinusHeal10.Location = new System.Drawing.Point(149, -9);
            this.lblMinusHeal10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinusHeal10.Name = "lblMinusHeal10";
            this.lblMinusHeal10.Size = new System.Drawing.Size(44, 36);
            this.lblMinusHeal10.TabIndex = 56;
            this.lblMinusHeal10.Text = "-1";
            this.lblMinusHeal10.Visible = false;
            // 
            // lblHeal10
            // 
            this.lblHeal10.AutoSize = true;
            this.lblHeal10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeal10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHeal10.Location = new System.Drawing.Point(143, -9);
            this.lblHeal10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeal10.Name = "lblHeal10";
            this.lblHeal10.Size = new System.Drawing.Size(51, 36);
            this.lblHeal10.TabIndex = 53;
            this.lblHeal10.Text = "+1";
            this.lblHeal10.Visible = false;
            // 
            // lblMinusHeal50
            // 
            this.lblMinusHeal50.AutoSize = true;
            this.lblMinusHeal50.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusHeal50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMinusHeal50.Location = new System.Drawing.Point(283, -10);
            this.lblMinusHeal50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinusHeal50.Name = "lblMinusHeal50";
            this.lblMinusHeal50.Size = new System.Drawing.Size(44, 36);
            this.lblMinusHeal50.TabIndex = 57;
            this.lblMinusHeal50.Text = "-1";
            this.lblMinusHeal50.Visible = false;
            // 
            // lblHeal50
            // 
            this.lblHeal50.AutoSize = true;
            this.lblHeal50.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeal50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHeal50.Location = new System.Drawing.Point(277, -10);
            this.lblHeal50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeal50.Name = "lblHeal50";
            this.lblHeal50.Size = new System.Drawing.Size(51, 36);
            this.lblHeal50.TabIndex = 54;
            this.lblHeal50.Text = "+1";
            this.lblHeal50.Visible = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(13, 709);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(108, 31);
            this.btnInventory.TabIndex = 51;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Visible = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(133, 709);
            this.btnShop.Margin = new System.Windows.Forms.Padding(4);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(108, 31);
            this.btnShop.TabIndex = 54;
            this.btnShop.TabStop = false;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Visible = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // gbxShop
            // 
            this.gbxShop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxShop.Controls.Add(this.panelShop);
            this.gbxShop.Location = new System.Drawing.Point(1333, 668);
            this.gbxShop.Margin = new System.Windows.Forms.Padding(4);
            this.gbxShop.Name = "gbxShop";
            this.gbxShop.Padding = new System.Windows.Forms.Padding(4);
            this.gbxShop.Size = new System.Drawing.Size(500, 340);
            this.gbxShop.TabIndex = 55;
            this.gbxShop.TabStop = false;
            this.gbxShop.Visible = false;
            // 
            // panelShop
            // 
            this.panelShop.AutoScroll = true;
            this.panelShop.Controls.Add(this.label224);
            this.panelShop.Controls.Add(this.label223);
            this.panelShop.Controls.Add(this.picBoxShopNecklace8);
            this.panelShop.Controls.Add(this.label222);
            this.panelShop.Controls.Add(this.picBoxShopNecklace5);
            this.panelShop.Controls.Add(this.label221);
            this.panelShop.Controls.Add(this.label220);
            this.panelShop.Controls.Add(this.label219);
            this.panelShop.Controls.Add(this.label218);
            this.panelShop.Controls.Add(this.label217);
            this.panelShop.Controls.Add(this.label216);
            this.panelShop.Controls.Add(this.label215);
            this.panelShop.Controls.Add(this.picBoxShopWingHelm);
            this.panelShop.Controls.Add(this.picBoxShopStagHelm);
            this.panelShop.Controls.Add(this.picBoxShopBoots5);
            this.panelShop.Controls.Add(this.picBoxShopBoots3);
            this.panelShop.Controls.Add(this.picBoxShopHalfPlate);
            this.panelShop.Controls.Add(this.picBoxShopChainmail);
            this.panelShop.Controls.Add(this.picBoxShopChainShirt);
            this.panelShop.Controls.Add(this.label214);
            this.panelShop.Controls.Add(this.picBoxShopBastardSword);
            this.panelShop.Controls.Add(this.label213);
            this.panelShop.Controls.Add(this.picBoxShopLongsword);
            this.panelShop.Location = new System.Drawing.Point(4, 9);
            this.panelShop.Margin = new System.Windows.Forms.Padding(4);
            this.panelShop.Name = "panelShop";
            this.panelShop.Size = new System.Drawing.Size(492, 325);
            this.panelShop.TabIndex = 0;
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label224.Location = new System.Drawing.Point(3, 2);
            this.label224.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(536, 62);
            this.label224.TabIndex = 22;
            this.label224.Text = "          Double click to buy. No refund!!!\r\nclick on the item in your inventory " +
    "to refresh";
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label223.Location = new System.Drawing.Point(156, 1567);
            this.label223.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(294, 87);
            this.label223.TabIndex = 21;
            this.label223.Text = "Necklace of Natural Armor\r\nAC+8\r\n6000 gold";
            // 
            // picBoxShopNecklace8
            // 
            this.picBoxShopNecklace8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopNecklace8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopNecklace8.Image")));
            this.picBoxShopNecklace8.Location = new System.Drawing.Point(9, 1550);
            this.picBoxShopNecklace8.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopNecklace8.Name = "picBoxShopNecklace8";
            this.picBoxShopNecklace8.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopNecklace8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopNecklace8.TabIndex = 20;
            this.picBoxShopNecklace8.TabStop = false;
            this.picBoxShopNecklace8.DoubleClick += new System.EventHandler(this.picBoxShopNecklace8_DoubleClick);
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label222.Location = new System.Drawing.Point(156, 1424);
            this.label222.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(294, 87);
            this.label222.TabIndex = 19;
            this.label222.Text = "Necklace of Natural Armor\r\nAC+5\r\n2500 gold";
            // 
            // picBoxShopNecklace5
            // 
            this.picBoxShopNecklace5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopNecklace5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopNecklace5.Image")));
            this.picBoxShopNecklace5.Location = new System.Drawing.Point(9, 1412);
            this.picBoxShopNecklace5.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopNecklace5.Name = "picBoxShopNecklace5";
            this.picBoxShopNecklace5.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopNecklace5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopNecklace5.TabIndex = 18;
            this.picBoxShopNecklace5.TabStop = false;
            this.picBoxShopNecklace5.DoubleClick += new System.EventHandler(this.picBoxShopNecklace5_DoubleClick);
            // 
            // label221
            // 
            this.label221.AutoSize = true;
            this.label221.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label221.Location = new System.Drawing.Point(156, 1282);
            this.label221.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(244, 87);
            this.label221.TabIndex = 17;
            this.label221.Text = "Winged Helmet AC+4\r\n\r\n1000 gold";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label220.Location = new System.Drawing.Point(156, 1153);
            this.label220.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(210, 87);
            this.label220.TabIndex = 16;
            this.label220.Text = "Stag Helmet AC+2\r\n\r\n500 gold";
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label219.Location = new System.Drawing.Point(156, 1019);
            this.label219.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(256, 87);
            this.label219.TabIndex = 15;
            this.label219.Text = "Mountain Boots  AC +5\r\n\r\n2000 gold";
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label218.Location = new System.Drawing.Point(156, 887);
            this.label218.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(296, 87);
            this.label218.TabIndex = 14;
            this.label218.Text = "Cool Leather Boots  AC +3\r\n\r\n1000 gold";
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label217.Location = new System.Drawing.Point(156, 745);
            this.label217.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(193, 87);
            this.label217.TabIndex = 13;
            this.label217.Text = "Half Plate  AC +7\r\n\r\n3000 gold";
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label216.Location = new System.Drawing.Point(156, 596);
            this.label216.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(197, 87);
            this.label216.TabIndex = 12;
            this.label216.Text = "Chainmail  AC +5\r\n\r\n1000 gold";
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label215.Location = new System.Drawing.Point(156, 446);
            this.label215.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(207, 87);
            this.label215.TabIndex = 11;
            this.label215.Text = "Chain Shirt  AC +4\r\n\r\n500 gold";
            // 
            // picBoxShopWingHelm
            // 
            this.picBoxShopWingHelm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopWingHelm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopWingHelm.Image")));
            this.picBoxShopWingHelm.Location = new System.Drawing.Point(9, 1271);
            this.picBoxShopWingHelm.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopWingHelm.Name = "picBoxShopWingHelm";
            this.picBoxShopWingHelm.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopWingHelm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopWingHelm.TabIndex = 10;
            this.picBoxShopWingHelm.TabStop = false;
            this.picBoxShopWingHelm.DoubleClick += new System.EventHandler(this.picBoxShopWingHelm_DoubleClick);
            // 
            // picBoxShopStagHelm
            // 
            this.picBoxShopStagHelm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopStagHelm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopStagHelm.Image")));
            this.picBoxShopStagHelm.Location = new System.Drawing.Point(9, 1137);
            this.picBoxShopStagHelm.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopStagHelm.Name = "picBoxShopStagHelm";
            this.picBoxShopStagHelm.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopStagHelm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopStagHelm.TabIndex = 9;
            this.picBoxShopStagHelm.TabStop = false;
            this.picBoxShopStagHelm.DoubleClick += new System.EventHandler(this.picBoxShopStagHelm_DoubleClick);
            // 
            // picBoxShopBoots5
            // 
            this.picBoxShopBoots5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopBoots5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopBoots5.Image")));
            this.picBoxShopBoots5.Location = new System.Drawing.Point(8, 1006);
            this.picBoxShopBoots5.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopBoots5.Name = "picBoxShopBoots5";
            this.picBoxShopBoots5.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopBoots5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopBoots5.TabIndex = 8;
            this.picBoxShopBoots5.TabStop = false;
            this.picBoxShopBoots5.DoubleClick += new System.EventHandler(this.picBoxShopBoots5_DoubleClick);
            // 
            // picBoxShopBoots3
            // 
            this.picBoxShopBoots3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopBoots3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopBoots3.Image")));
            this.picBoxShopBoots3.Location = new System.Drawing.Point(9, 874);
            this.picBoxShopBoots3.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopBoots3.Name = "picBoxShopBoots3";
            this.picBoxShopBoots3.Size = new System.Drawing.Size(91, 84);
            this.picBoxShopBoots3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopBoots3.TabIndex = 7;
            this.picBoxShopBoots3.TabStop = false;
            this.picBoxShopBoots3.DoubleClick += new System.EventHandler(this.picBoxShopBoots3_DoubleClick);
            // 
            // picBoxShopHalfPlate
            // 
            this.picBoxShopHalfPlate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopHalfPlate.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopHalfPlate.Image")));
            this.picBoxShopHalfPlate.Location = new System.Drawing.Point(8, 727);
            this.picBoxShopHalfPlate.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopHalfPlate.Name = "picBoxShopHalfPlate";
            this.picBoxShopHalfPlate.Size = new System.Drawing.Size(64, 96);
            this.picBoxShopHalfPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopHalfPlate.TabIndex = 6;
            this.picBoxShopHalfPlate.TabStop = false;
            this.picBoxShopHalfPlate.DoubleClick += new System.EventHandler(this.picBoxShopHalfPlate_DoubleClick);
            // 
            // picBoxShopChainmail
            // 
            this.picBoxShopChainmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopChainmail.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopChainmail.Image")));
            this.picBoxShopChainmail.Location = new System.Drawing.Point(8, 581);
            this.picBoxShopChainmail.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopChainmail.Name = "picBoxShopChainmail";
            this.picBoxShopChainmail.Size = new System.Drawing.Size(64, 96);
            this.picBoxShopChainmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopChainmail.TabIndex = 5;
            this.picBoxShopChainmail.TabStop = false;
            this.picBoxShopChainmail.DoubleClick += new System.EventHandler(this.picBoxShopChainmail_DoubleClick);
            // 
            // picBoxShopChainShirt
            // 
            this.picBoxShopChainShirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopChainShirt.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopChainShirt.Image")));
            this.picBoxShopChainShirt.Location = new System.Drawing.Point(8, 434);
            this.picBoxShopChainShirt.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopChainShirt.Name = "picBoxShopChainShirt";
            this.picBoxShopChainShirt.Size = new System.Drawing.Size(64, 96);
            this.picBoxShopChainShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopChainShirt.TabIndex = 4;
            this.picBoxShopChainShirt.TabStop = false;
            this.picBoxShopChainShirt.DoubleClick += new System.EventHandler(this.picBoxShopChainShirt_DoubleClick);
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label214.Location = new System.Drawing.Point(156, 258);
            this.label214.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(240, 145);
            this.label214.TabIndex = 3;
            this.label214.Text = "Bastard Sword\r\nOne-handed weapon\r\nDamage: 1d10\r\n\r\n3000 gold";
            // 
            // picBoxShopBastardSword
            // 
            this.picBoxShopBastardSword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopBastardSword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShopBastardSword.Image")));
            this.picBoxShopBastardSword.Location = new System.Drawing.Point(8, 249);
            this.picBoxShopBastardSword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopBastardSword.Name = "picBoxShopBastardSword";
            this.picBoxShopBastardSword.Size = new System.Drawing.Size(64, 128);
            this.picBoxShopBastardSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopBastardSword.TabIndex = 2;
            this.picBoxShopBastardSword.TabStop = false;
            this.picBoxShopBastardSword.DoubleClick += new System.EventHandler(this.picBoxShopBastardSword_DoubleClick);
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label213.Location = new System.Drawing.Point(156, 85);
            this.label213.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(240, 145);
            this.label213.TabIndex = 1;
            this.label213.Text = "Longsword\r\nOne-handed weapon\r\nDamage: 1d8\r\n\r\n1000 gold";
            // 
            // picBoxShopLongsword
            // 
            this.picBoxShopLongsword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShopLongsword.Image = global::RPG_Simulator.Properties.Resources.Longsword;
            this.picBoxShopLongsword.Location = new System.Drawing.Point(8, 63);
            this.picBoxShopLongsword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxShopLongsword.Name = "picBoxShopLongsword";
            this.picBoxShopLongsword.Size = new System.Drawing.Size(32, 128);
            this.picBoxShopLongsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxShopLongsword.TabIndex = 0;
            this.picBoxShopLongsword.TabStop = false;
            this.picBoxShopLongsword.DoubleClick += new System.EventHandler(this.picBoxShopLongsword_DoubleClick);
            // 
            // btnGoldPlus
            // 
            this.btnGoldPlus.Location = new System.Drawing.Point(16, 971);
            this.btnGoldPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoldPlus.Name = "btnGoldPlus";
            this.btnGoldPlus.Size = new System.Drawing.Size(155, 28);
            this.btnGoldPlus.TabIndex = 56;
            this.btnGoldPlus.TabStop = false;
            this.btnGoldPlus.Text = "+1000 Gold";
            this.btnGoldPlus.UseVisualStyleBackColor = true;
            this.btnGoldPlus.Visible = false;
            this.btnGoldPlus.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // btnXPPlus
            // 
            this.btnXPPlus.Location = new System.Drawing.Point(212, 971);
            this.btnXPPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnXPPlus.Name = "btnXPPlus";
            this.btnXPPlus.Size = new System.Drawing.Size(155, 28);
            this.btnXPPlus.TabIndex = 57;
            this.btnXPPlus.TabStop = false;
            this.btnXPPlus.Text = "+1000 XP";
            this.btnXPPlus.UseVisualStyleBackColor = true;
            this.btnXPPlus.Visible = false;
            this.btnXPPlus.Click += new System.EventHandler(this.btnXPPlus_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1914, 1047);
            this.Controls.Add(this.gbxLvlUp);
            this.Controls.Add(this.btnXPPlus);
            this.Controls.Add(this.btnGoldPlus);
            this.Controls.Add(this.gbxShop);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.gbxPotions);
            this.Controls.Add(this.lblGoldMessage);
            this.Controls.Add(this.btnResetHero);
            this.Controls.Add(this.lbxNecklace);
            this.Controls.Add(this.lbxBoots);
            this.Controls.Add(this.lbxHelmet);
            this.Controls.Add(this.lbxArmor);
            this.Controls.Add(this.gbxInventory);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.gbxFight);
            this.Controls.Add(this.gbxPlayerSheet);
            this.Controls.Add(this.gbxPackage);
            this.Controls.Add(this.gbxCustomize);
            this.Controls.Add(this.gbxRace);
            this.Controls.Add(this.gbxAbilities);
            this.Controls.Add(this.gbxClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.gbxGender);
            this.Controls.Add(this.btnNewCharacter);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.lblGRC);
            this.Controls.Add(this.gbxNewCharacter);
            this.Controls.Add(this.gbxPortraits);
            this.Controls.Add(this.gbxMonsters);
            this.Controls.Add(this.gbxWolf);
            this.Controls.Add(this.gbxFireBeelte);
            this.Controls.Add(this.gbxDragon);
            this.Controls.Add(this.gbxDireBear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG Mini Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxAbilities.ResumeLayout(false);
            this.gbxAbilities.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbxNewCharacter.ResumeLayout(false);
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.gbxRace.ResumeLayout(false);
            this.gbxRace.PerformLayout();
            this.gbxClass.ResumeLayout(false);
            this.gbxPortraits.ResumeLayout(false);
            this.panelPortraits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxPackage.ResumeLayout(false);
            this.gbxPackage.PerformLayout();
            this.gbxCustomize.ResumeLayout(false);
            this.gbxCustomize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerPortrait)).EndInit();
            this.gbxPlayerSheet.ResumeLayout(false);
            this.gbxPlayerSheet.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxWolf.ResumeLayout(false);
            this.gbxWolf.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.gbxFireBeelte.ResumeLayout(false);
            this.gbxFireBeelte.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.gbxMonsters.ResumeLayout(false);
            this.gbxMonsters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxFight.ResumeLayout(false);
            this.gbxFight.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbxLvlUp.ResumeLayout(false);
            this.gbxLvlUp.PerformLayout();
            this.gbxDireBear.ResumeLayout(false);
            this.gbxDireBear.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            this.groupBox42.ResumeLayout(false);
            this.groupBox42.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.gbxInventory.ResumeLayout(false);
            this.gbxInvProperties.ResumeLayout(false);
            this.gbxInvProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreatsword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBastardsword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLongsword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShortsword)).EndInit();
            this.groupBox50.ResumeLayout(false);
            this.groupBox50.PerformLayout();
            this.groupBox49.ResumeLayout(false);
            this.groupBox49.PerformLayout();
            this.gbxDragon.ResumeLayout(false);
            this.gbxDragon.PerformLayout();
            this.groupBox52.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox53.ResumeLayout(false);
            this.groupBox53.PerformLayout();
            this.groupBox54.ResumeLayout(false);
            this.groupBox54.PerformLayout();
            this.groupBox55.ResumeLayout(false);
            this.groupBox55.PerformLayout();
            this.groupBox56.ResumeLayout(false);
            this.groupBox56.PerformLayout();
            this.groupBox57.ResumeLayout(false);
            this.groupBox57.PerformLayout();
            this.groupBox58.ResumeLayout(false);
            this.groupBox58.PerformLayout();
            this.groupBox59.ResumeLayout(false);
            this.groupBox59.PerformLayout();
            this.groupBox60.ResumeLayout(false);
            this.groupBox60.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.gbxPotions.ResumeLayout(false);
            this.gbxPotions.PerformLayout();
            this.gbxShop.ResumeLayout(false);
            this.panelShop.ResumeLayout(false);
            this.panelShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopNecklace8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopNecklace5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopWingHelm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopStagHelm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBoots5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBoots3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopHalfPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopChainmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopChainShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopBastardSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShopLongsword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAbilities;
        private System.Windows.Forms.TextBox txtWisM;
        private System.Windows.Forms.TextBox txtIntM;
        private System.Windows.Forms.TextBox txtConM;
        private System.Windows.Forms.TextBox txtDexM;
        private System.Windows.Forms.TextBox txtStrM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStrInc;
        private System.Windows.Forms.Button btnWisInc;
        private System.Windows.Forms.Button btnIntInc;
        private System.Windows.Forms.Button btnConInc;
        private System.Windows.Forms.Button btnDexInc;
        private System.Windows.Forms.Button btnWisDec;
        private System.Windows.Forms.Button btnIntDec;
        private System.Windows.Forms.Button btnConDec;
        private System.Windows.Forms.Button btnDexDec;
        private System.Windows.Forms.Button btnStrDec;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPointM;
        private System.Windows.Forms.TextBox txtChaM;
        private System.Windows.Forms.Button btnChaInc;
        private System.Windows.Forms.Button btnChaDec;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDmg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWill;
        private System.Windows.Forms.TextBox txtReflex;
        private System.Windows.Forms.TextBox txtFortitude;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.GroupBox gbxNewCharacter;
        private System.Windows.Forms.Button btnGender;
        private System.Windows.Forms.Button btnAbilities;
        private System.Windows.Forms.Button btnPortrait;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.GroupBox gbxRace;
        private System.Windows.Forms.Button btnDwarf;
        private System.Windows.Forms.Button btnGnome;
        private System.Windows.Forms.Button btnElf;
        private System.Windows.Forms.Button btnHuman;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRaceHuman;
        private System.Windows.Forms.Label lblRaceElf;
        private System.Windows.Forms.Label lblRaceGnome;
        private System.Windows.Forms.Label lblRaceDwarf;
        private System.Windows.Forms.GroupBox gbxClass;
        private System.Windows.Forms.Button btnFighter;
        private System.Windows.Forms.Label lblClassWizard;
        private System.Windows.Forms.Label lblClassRogue;
        private System.Windows.Forms.Label lblClassFighter;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.ImageList imageListPortraitsMale;
        private System.Windows.Forms.GroupBox gbxPortraits;
        private System.Windows.Forms.Panel panelPortraits;
        private System.Windows.Forms.ImageList imageListPortraitsFemale;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbilitiesNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStillPoints;
        private System.Windows.Forms.GroupBox gbxPackage;
        private System.Windows.Forms.Button btnPackageNext;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblGRC;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.GroupBox gbxCustomize;
        private System.Windows.Forms.Button btnGenerateLastName;
        private System.Windows.Forms.Button btnGenerateFirstName;
        private System.Windows.Forms.Button btnConfirmCharacter;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pbxPlayerPortrait;
        private System.Windows.Forms.GroupBox gbxPlayerSheet;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPlayerStrM;
        private System.Windows.Forms.Label lblPlayerStr;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblPlayerChaM;
        private System.Windows.Forms.Label lblPlayerCha;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblPlayerIntM;
        private System.Windows.Forms.Label lblPlayerInt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblPlayerWisM;
        private System.Windows.Forms.Label lblPlayerWis;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblPlayerDexM;
        private System.Windows.Forms.Label lblPlayerDex;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblPlayerConM;
        private System.Windows.Forms.Label lblPlayerCon;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblPlayerClass;
        private System.Windows.Forms.Label lblPlayerRace;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblPlayerLvl;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblPlayerAC;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label lblPlayerNextLvlXp;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblPlayerCurrentXp;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label lblPlayerWill;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblPlayerReflex;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblPlayerFortitude;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label lblPlayerBaseAttack;
        private System.Windows.Forms.Label lblWeaponCritical;
        private System.Windows.Forms.Label lblPlayerAttackBonus;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblModifierDmg;
        private System.Windows.Forms.Label lblWeaponDmg;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxWolf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label lblWolfHp;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.GroupBox gbxFireBeelte;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Label lblFBHp;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label lblFBInt;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label lblFBWis;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.Label lblFBDexM;
        private System.Windows.Forms.Label lblFBDex;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.Label lblFBConM;
        private System.Windows.Forms.Label lblFBCon;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Label lblFBStrM;
        private System.Windows.Forms.Label lblFBStr;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.GroupBox gbxMonsters;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Button btnRemoveMonster;
        private System.Windows.Forms.Button btnSpawn;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.RadioButton rbtnDragon;
        private System.Windows.Forms.RadioButton rbtnDireBear;
        private System.Windows.Forms.RadioButton rbtnWolf;
        private System.Windows.Forms.RadioButton rbtnFireBeetle;
        private System.Windows.Forms.GroupBox gbxFight;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.RichTextBox txtFight1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button btnLightHeal;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.GroupBox gbxLvlUp;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox txtLvlUp;
        private System.Windows.Forms.RadioButton rbtnChaUp;
        private System.Windows.Forms.RadioButton rbtnWisUp;
        private System.Windows.Forms.RadioButton rbtnIntUp;
        private System.Windows.Forms.RadioButton rbtnConUp;
        private System.Windows.Forms.RadioButton rbtnDexUp;
        private System.Windows.Forms.RadioButton rbtnStrUp;
        private System.Windows.Forms.Button btnLvlUpConfirm;
        private System.Windows.Forms.GroupBox gbxDireBear;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.Label lblBearHp;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.GroupBox groupBox41;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.GroupBox groupBox43;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.GroupBox groupBox44;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.GroupBox groupBox45;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.GroupBox groupBox46;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.GroupBox groupBox47;
        private System.Windows.Forms.GroupBox groupBox48;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox txtDragonCounter;
        private System.Windows.Forms.TextBox txtBearCounter;
        private System.Windows.Forms.TextBox txtWolfCounter;
        private System.Windows.Forms.TextBox txtBeetleCounter;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.GroupBox gbxInventory;
        private System.Windows.Forms.GroupBox gbxInvProperties;
        private System.Windows.Forms.GroupBox groupBox50;
        private System.Windows.Forms.GroupBox groupBox49;
        private System.Windows.Forms.TextBox txtInvGold;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label lblInvN;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label lblInvB;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label lblInvH;
        private System.Windows.Forms.Label lblInvA;
        private System.Windows.Forms.Label lblInvW;
        private System.Windows.Forms.Label lblInvNecklace;
        private System.Windows.Forms.Label lblInvBoots;
        private System.Windows.Forms.Label lblInvHelmet;
        private System.Windows.Forms.Label lblInvArmor;
        private System.Windows.Forms.Label lblInvWeapon;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.RichTextBox rtxtInv;
        private System.Windows.Forms.PictureBox picBoxInv;
        private System.Windows.Forms.ListBox lbxInvWeapon;
        private System.Windows.Forms.Label lblInvDmgOrArm;
        private System.Windows.Forms.TextBox txtInv;
        private System.Windows.Forms.TextBox txtInvBonusAc;
        private System.Windows.Forms.Label lblInvBonusAc;
        private System.Windows.Forms.Label lblInvName;
        private System.Windows.Forms.ListBox lbxAC;
        private System.Windows.Forms.ListBox lbxArmor;
        private System.Windows.Forms.ListBox lbxHelmet;
        private System.Windows.Forms.ListBox lbxBoots;
        private System.Windows.Forms.ListBox lbxNecklace;
        private System.Windows.Forms.ImageList imageListArmors;
        private System.Windows.Forms.PictureBox picBoxGreatsword;
        private System.Windows.Forms.PictureBox picBoxBastardsword;
        private System.Windows.Forms.PictureBox picBoxLongsword;
        private System.Windows.Forms.PictureBox picBoxShortsword;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.ImageList imageListBootsAndHelmetsAndNecklaces;
        private System.Windows.Forms.Button btnResetHero;
        private System.Windows.Forms.Label lblPlayerMaxHp;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.GroupBox gbxDragon;
        private System.Windows.Forms.GroupBox groupBox52;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.GroupBox groupBox53;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.GroupBox groupBox54;
        private System.Windows.Forms.Label lblDragonHp;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.GroupBox groupBox55;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.GroupBox groupBox56;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.GroupBox groupBox57;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.GroupBox groupBox58;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.GroupBox groupBox59;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.GroupBox groupBox60;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.GroupBox groupBox61;
        private System.Windows.Forms.GroupBox groupBox62;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.Label lblGoldMessage;
        private System.Windows.Forms.GroupBox gbxPotions;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.TextBox txtHeal50;
        private System.Windows.Forms.Button btnHeal50;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.TextBox txtHeal10;
        private System.Windows.Forms.Button btnHeal10;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox txtHeal2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.Label lblHeal50;
        private System.Windows.Forms.Label lblHeal10;
        private System.Windows.Forms.Label lblHeal2;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.GroupBox gbxShop;
        private System.Windows.Forms.Panel panelShop;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.PictureBox picBoxShopWingHelm;
        private System.Windows.Forms.PictureBox picBoxShopStagHelm;
        private System.Windows.Forms.PictureBox picBoxShopBoots5;
        private System.Windows.Forms.PictureBox picBoxShopBoots3;
        private System.Windows.Forms.PictureBox picBoxShopHalfPlate;
        private System.Windows.Forms.PictureBox picBoxShopChainmail;
        private System.Windows.Forms.PictureBox picBoxShopChainShirt;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.PictureBox picBoxShopBastardSword;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.PictureBox picBoxShopLongsword;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.PictureBox picBoxShopNecklace8;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.PictureBox picBoxShopNecklace5;
        private System.Windows.Forms.Label lblMinusHeal2;
        private System.Windows.Forms.Label lblMinusHeal50;
        private System.Windows.Forms.Label lblMinusHeal10;
        private System.Windows.Forms.Button btnGoldPlus;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.Button btnXPPlus;
        private System.Windows.Forms.Label label225;

        
    }
}

