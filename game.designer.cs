namespace Eagle
{
    partial class game3
    {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menu_button = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.Button();
            this.HowToPlay_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dialog = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.Panel();
            this.hard = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.donut1 = new System.Windows.Forms.PictureBox();
            this.ecran_pierdut = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.instructiuni = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.poveste_next = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.ecran_castigat = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.donut2 = new System.Windows.Forms.PictureBox();
            this.hole = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heart = new System.Windows.Forms.PictureBox();
            this.healthbar = new System.Windows.Forms.PictureBox();
            this.upwall = new System.Windows.Forms.PictureBox();
            this.spikes = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.menupanel.SuspendLayout();
            this.dialog.SuspendLayout();
            this.levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donut1)).BeginInit();
            this.ecran_pierdut.SuspendLayout();
            this.instructiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poveste_next)).BeginInit();
            this.ecran_castigat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.Location = new System.Drawing.Point(-20, -6);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(214, 45);
            this.menu_button.TabIndex = 12;
            this.menu_button.Text = "Meniu";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menupanel.Controls.Add(this.button2);
            this.menupanel.Controls.Add(this.difficulty);
            this.menupanel.Controls.Add(this.HowToPlay_but);
            this.menupanel.Controls.Add(this.menu_button);
            this.menupanel.Location = new System.Drawing.Point(64, 35);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(177, 32);
            this.menupanel.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(23, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Despre autor";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // difficulty
            // 
            this.difficulty.BackColor = System.Drawing.Color.DodgerBlue;
            this.difficulty.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficulty.ForeColor = System.Drawing.Color.Black;
            this.difficulty.Location = new System.Drawing.Point(23, 133);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(124, 39);
            this.difficulty.TabIndex = 14;
            this.difficulty.Text = "Dificultate";
            this.difficulty.UseVisualStyleBackColor = false;
            this.difficulty.Click += new System.EventHandler(this.difficulty_Click);
            // 
            // HowToPlay_but
            // 
            this.HowToPlay_but.BackColor = System.Drawing.Color.DodgerBlue;
            this.HowToPlay_but.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HowToPlay_but.ForeColor = System.Drawing.Color.Black;
            this.HowToPlay_but.Location = new System.Drawing.Point(23, 59);
            this.HowToPlay_but.Name = "HowToPlay_but";
            this.HowToPlay_but.Size = new System.Drawing.Size(124, 39);
            this.HowToPlay_but.TabIndex = 13;
            this.HowToPlay_but.Text = "Instructiuni";
            this.HowToPlay_but.UseVisualStyleBackColor = false;
            this.HowToPlay_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reguli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(93, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "- Fereste-te de capcane!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(69, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fiecare capcana iti va scadea 10% din viata !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(113, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "- Colecteaza inelele!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(58, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "      Inelele sunt asezate aleatoriu pe harta.\r\n           Colecteaza 20 si vei c" +
    "astiga jocul!";
            // 
            // dialog
            // 
            this.dialog.BackColor = System.Drawing.Color.Black;
            this.dialog.Controls.Add(this.label9);
            this.dialog.Controls.Add(this.label8);
            this.dialog.Controls.Add(this.label7);
            this.dialog.Controls.Add(this.label2);
            this.dialog.Controls.Add(this.label6);
            this.dialog.Controls.Add(this.label3);
            this.dialog.Controls.Add(this.label5);
            this.dialog.Controls.Add(this.label4);
            this.dialog.Location = new System.Drawing.Point(989, 89);
            this.dialog.Name = "dialog";
            this.dialog.Size = new System.Drawing.Size(405, 238);
            this.dialog.TabIndex = 20;
            this.dialog.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(117, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "- Distreaza-te !";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(13, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "           Capcanele sunt interesante, dar ce zici de gropi?\r\nFiecare groapa in c" +
    "are ai pasit iti va scadea 10% din viata!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(117, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "- Ai grija la gropi! ";
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.Color.Black;
            this.levels.Controls.Add(this.hard);
            this.levels.Controls.Add(this.normal);
            this.levels.Controls.Add(this.easy);
            this.levels.Location = new System.Drawing.Point(947, 224);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(405, 238);
            this.levels.TabIndex = 21;
            this.levels.Visible = false;
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Red;
            this.hard.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hard.ForeColor = System.Drawing.Color.Black;
            this.hard.Location = new System.Drawing.Point(79, 161);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(242, 39);
            this.hard.TabIndex = 2;
            this.hard.Text = "Greu";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.Color.Yellow;
            this.normal.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normal.ForeColor = System.Drawing.Color.Black;
            this.normal.Location = new System.Drawing.Point(120, 83);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(168, 39);
            this.normal.TabIndex = 1;
            this.normal.Text = "Mediu";
            this.normal.UseVisualStyleBackColor = false;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Lime;
            this.easy.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easy.Location = new System.Drawing.Point(151, 9);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(99, 39);
            this.easy.TabIndex = 0;
            this.easy.Text = "Usor";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // donut1
            // 
            this.donut1.BackgroundImage = global::Eagle.Properties.Resources.dragon;
            this.donut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donut1.Location = new System.Drawing.Point(145, 105);
            this.donut1.Name = "donut1";
            this.donut1.Size = new System.Drawing.Size(54, 53);
            this.donut1.TabIndex = 8;
            this.donut1.TabStop = false;
            // 
            // ecran_pierdut
            // 
            this.ecran_pierdut.BackColor = System.Drawing.SystemColors.Highlight;
            this.ecran_pierdut.BackgroundImage = global::Eagle.Properties.Resources.poza_sfarsit_joc;
            this.ecran_pierdut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ecran_pierdut.Controls.Add(this.label17);
            this.ecran_pierdut.Controls.Add(this.label15);
            this.ecran_pierdut.Controls.Add(this.label16);
            this.ecran_pierdut.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecran_pierdut.Location = new System.Drawing.Point(0, 0);
            this.ecran_pierdut.Name = "ecran_pierdut";
            this.ecran_pierdut.Size = new System.Drawing.Size(999, 507);
            this.ecran_pierdut.TabIndex = 10;
            this.ecran_pierdut.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(36, 389);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(277, 37);
            this.label17.TabIndex = 2;
            this.label17.Text = "Mai incearca o data!";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            this.label17.MouseEnter += new System.EventHandler(this.label14_MouseEnter);
            this.label17.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(773, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 37);
            this.label15.TabIndex = 1;
            this.label15.Text = "Iesi din joc";
            this.label15.Click += new System.EventHandler(this.label14_Click);
            this.label15.MouseEnter += new System.EventHandler(this.label14_MouseEnter);
            this.label15.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(257, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(509, 95);
            this.label16.TabIndex = 0;
            this.label16.Text = "AI PIERDUT!";
            // 
            // instructiuni
            // 
            this.instructiuni.BackColor = System.Drawing.Color.Transparent;
            this.instructiuni.BackgroundImage = global::Eagle.Properties.Resources.coperta_joc2_blur;
            this.instructiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instructiuni.Controls.Add(this.label18);
            this.instructiuni.Controls.Add(this.label12);
            this.instructiuni.Controls.Add(this.label11);
            this.instructiuni.Controls.Add(this.label10);
            this.instructiuni.Controls.Add(this.label77);
            this.instructiuni.Controls.Add(this.poveste_next);
            this.instructiuni.Controls.Add(this.label41);
            this.instructiuni.Controls.Add(this.label42);
            this.instructiuni.Controls.Add(this.label43);
            this.instructiuni.Location = new System.Drawing.Point(0, 0);
            this.instructiuni.Name = "instructiuni";
            this.instructiuni.Size = new System.Drawing.Size(1005, 466);
            this.instructiuni.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(68, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(781, 29);
            this.label18.TabIndex = 9;
            this.label18.Text = "5. Viata luptatorului este strans legata de scorul din testul anterior.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(914, 58);
            this.label12.TabIndex = 8;
            this.label12.Text = "4. Jocul are 3 nivele de dificultate, ce pot fi selectate in meniul prezent in jo" +
    "c. \r\n              Vrei sa iti testezi aptitudinnile? Incearca un nivel mai greu" +
    "!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(905, 58);
            this.label11.TabIndex = 7;
            this.label11.Text = "3. Atentie! Pe toata harta jocului sunt intinse capcane si gropi! Acestea iti vor" +
    " \r\n              scadea un procent semnificativ din viata ta, asa ca ai grija!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(195, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(571, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "2. Doboara 20 de dragoni pentru a castiga jocul!";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label77.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.Red;
            this.label77.Location = new System.Drawing.Point(334, 395);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(317, 35);
            this.label77.TabIndex = 5;
            this.label77.Text = "AVANSEAZA CATRE JOC";
            this.label77.Click += new System.EventHandler(this.label77_Click);
            this.label77.MouseEnter += new System.EventHandler(this.label77_MouseEnter);
            this.label77.MouseLeave += new System.EventHandler(this.label77_MouseLeave);
            // 
            // poveste_next
            // 
            this.poveste_next.BackColor = System.Drawing.Color.Transparent;
            this.poveste_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("poveste_next.BackgroundImage")));
            this.poveste_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poveste_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poveste_next.Location = new System.Drawing.Point(1043, 41);
            this.poveste_next.Name = "poveste_next";
            this.poveste_next.Size = new System.Drawing.Size(97, 47);
            this.poveste_next.TabIndex = 4;
            this.poveste_next.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(222, 133);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(508, 29);
            this.label41.TabIndex = 3;
            this.label41.Text = "1. Caracterul se misca cu ajutorul sagetilor";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Image = ((System.Drawing.Image)(resources.GetObject("label42.Image")));
            this.label42.Location = new System.Drawing.Point(45, 41);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 29);
            this.label42.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(242, 33);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(441, 74);
            this.label43.TabIndex = 0;
            this.label43.Text = "INSTRUCTIUNI";
            // 
            // ecran_castigat
            // 
            this.ecran_castigat.BackColor = System.Drawing.SystemColors.Highlight;
            this.ecran_castigat.BackgroundImage = global::Eagle.Properties.Resources.poza_sfarsit_joc;
            this.ecran_castigat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ecran_castigat.Controls.Add(this.label14);
            this.ecran_castigat.Controls.Add(this.label13);
            this.ecran_castigat.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecran_castigat.Location = new System.Drawing.Point(0, 0);
            this.ecran_castigat.Name = "ecran_castigat";
            this.ecran_castigat.Size = new System.Drawing.Size(986, 498);
            this.ecran_castigat.TabIndex = 9;
            this.ecran_castigat.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(429, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 37);
            this.label14.TabIndex = 1;
            this.label14.Text = "Iesi din joc";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            this.label14.MouseEnter += new System.EventHandler(this.label14_MouseEnter);
            this.label14.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(234, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(539, 95);
            this.label13.TabIndex = 0;
            this.label13.Text = "AI CASTIGAT!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Eagle.Properties.Resources.dragon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(862, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // donut2
            // 
            this.donut2.BackgroundImage = global::Eagle.Properties.Resources.dragon;
            this.donut2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donut2.Location = new System.Drawing.Point(551, 270);
            this.donut2.Name = "donut2";
            this.donut2.Size = new System.Drawing.Size(54, 53);
            this.donut2.TabIndex = 11;
            this.donut2.TabStop = false;
            // 
            // hole
            // 
            this.hole.Location = new System.Drawing.Point(310, 391);
            this.hole.Name = "hole";
            this.hole.Size = new System.Drawing.Size(202, 103);
            this.hole.TabIndex = 10;
            this.hole.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(358, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // heart
            // 
            this.heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart.BackgroundImage")));
            this.heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart.Location = new System.Drawing.Point(298, 29);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(54, 38);
            this.heart.TabIndex = 6;
            this.heart.TabStop = false;
            // 
            // healthbar
            // 
            this.healthbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("healthbar.BackgroundImage")));
            this.healthbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.healthbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthbar.Location = new System.Drawing.Point(358, 29);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(320, 38);
            this.healthbar.TabIndex = 5;
            this.healthbar.TabStop = false;
            // 
            // upwall
            // 
            this.upwall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upwall.BackgroundImage")));
            this.upwall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upwall.Location = new System.Drawing.Point(110, 164);
            this.upwall.Name = "upwall";
            this.upwall.Size = new System.Drawing.Size(242, 40);
            this.upwall.TabIndex = 3;
            this.upwall.TabStop = false;
            // 
            // spikes
            // 
            this.spikes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spikes.BackgroundImage")));
            this.spikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spikes.Location = new System.Drawing.Point(87, 336);
            this.spikes.Name = "spikes";
            this.spikes.Size = new System.Drawing.Size(154, 64);
            this.spikes.TabIndex = 2;
            this.spikes.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("floor.BackgroundImage")));
            this.floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floor.Location = new System.Drawing.Point(-2000, 391);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(3000, 500);
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(834, 286);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 114);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.instructiuni);
            this.Controls.Add(this.donut1);
            this.Controls.Add(this.ecran_pierdut);
            this.Controls.Add(this.ecran_castigat);
            this.Controls.Add(this.dialog);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.donut2);
            this.Controls.Add(this.hole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.upwall);
            this.Controls.Add(this.spikes);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(452, 286);
            this.Name = "game3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luptatorul stiintific";
            this.Deactivate += new System.EventHandler(this.game3_Deactivate);
            this.Load += new System.EventHandler(this.game3_Load);
            this.menupanel.ResumeLayout(false);
            this.dialog.ResumeLayout(false);
            this.dialog.PerformLayout();
            this.levels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donut1)).EndInit();
            this.ecran_pierdut.ResumeLayout(false);
            this.ecran_pierdut.PerformLayout();
            this.instructiuni.ResumeLayout(false);
            this.instructiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poveste_next)).EndInit();
            this.ecran_castigat.ResumeLayout(false);
            this.ecran_castigat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox spikes;
        private System.Windows.Forms.PictureBox upwall;
        private System.Windows.Forms.PictureBox healthbar;
        private System.Windows.Forms.PictureBox heart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox donut1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hole;
        private System.Windows.Forms.PictureBox donut2;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button HowToPlay_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel dialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button difficulty;
        private System.Windows.Forms.Panel levels;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel instructiuni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.PictureBox poveste_next;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Panel ecran_castigat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel ecran_pierdut;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
    }
}

