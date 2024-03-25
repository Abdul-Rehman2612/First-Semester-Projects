namespace DB_Lab_Management_System.CLOs
{
    partial class CLO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLO));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.CLOName = new System.Windows.Forms.Label();
            this.CLOInput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.CLOsView = new System.Windows.Forms.DataGridView();
            this.Back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ManageRubrics = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddCLO = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Update = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Home = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.CLOsView)).BeginInit();
            this.SuspendLayout();
            // 
            // CLOName
            // 
            this.CLOName.AutoSize = true;
            this.CLOName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CLOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLOName.Location = new System.Drawing.Point(46, 101);
            this.CLOName.Name = "CLOName";
            this.CLOName.Size = new System.Drawing.Size(186, 37);
            this.CLOName.TabIndex = 24;
            this.CLOName.Text = "CLO Name";
            // 
            // CLOInput
            // 
            this.CLOInput.BackColor = System.Drawing.SystemColors.Info;
            this.CLOInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOInput.Location = new System.Drawing.Point(300, 101);
            this.CLOInput.Name = "CLOInput";
            this.CLOInput.Size = new System.Drawing.Size(224, 38);
            this.CLOInput.TabIndex = 23;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Title.Location = new System.Drawing.Point(462, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(78, 33);
            this.Title.TabIndex = 25;
            this.Title.Text = "CLO";
            // 
            // CLOsView
            // 
            this.CLOsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CLOsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CLOsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLOsView.Location = new System.Drawing.Point(559, 101);
            this.CLOsView.Name = "CLOsView";
            this.CLOsView.ReadOnly = true;
            this.CLOsView.Size = new System.Drawing.Size(413, 286);
            this.CLOsView.TabIndex = 26;
            this.CLOsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLOsView_CellContentClick);
            // 
            // Back
            // 
            this.Back.AllowAnimations = true;
            this.Back.AllowMouseEffects = true;
            this.Back.AllowToggling = false;
            this.Back.AnimationSpeed = 200;
            this.Back.AutoGenerateColors = false;
            this.Back.AutoRoundBorders = false;
            this.Back.AutoSizeLeftIcon = true;
            this.Back.AutoSizeRightIcon = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackColor1 = System.Drawing.Color.IndianRed;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.ButtonText = "Back";
            this.Back.ButtonTextMarginLeft = 0;
            this.Back.ColorContrastOnClick = 45;
            this.Back.ColorContrastOnHover = 45;
            this.Back.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Back.CustomizableEdges = borderEdges1;
            this.Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Back.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Back.IconMarginLeft = 11;
            this.Back.IconPadding = 10;
            this.Back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Back.IconSize = 25;
            this.Back.IdleBorderColor = System.Drawing.Color.Black;
            this.Back.IdleBorderRadius = 10;
            this.Back.IdleBorderThickness = 3;
            this.Back.IdleFillColor = System.Drawing.Color.IndianRed;
            this.Back.IdleIconLeftImage = null;
            this.Back.IdleIconRightImage = null;
            this.Back.IndicateFocus = false;
            this.Back.Location = new System.Drawing.Point(872, 409);
            this.Back.Name = "Back";
            this.Back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.OnDisabledState.BorderRadius = 10;
            this.Back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnDisabledState.BorderThickness = 3;
            this.Back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.OnDisabledState.IconLeftImage = null;
            this.Back.OnDisabledState.IconRightImage = null;
            this.Back.onHoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.Back.onHoverState.BorderRadius = 10;
            this.Back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.onHoverState.BorderThickness = 3;
            this.Back.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Back.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Back.onHoverState.IconLeftImage = null;
            this.Back.onHoverState.IconRightImage = null;
            this.Back.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.Back.OnIdleState.BorderRadius = 10;
            this.Back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnIdleState.BorderThickness = 3;
            this.Back.OnIdleState.FillColor = System.Drawing.Color.IndianRed;
            this.Back.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Back.OnIdleState.IconLeftImage = null;
            this.Back.OnIdleState.IconRightImage = null;
            this.Back.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.Back.OnPressedState.BorderRadius = 10;
            this.Back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnPressedState.BorderThickness = 3;
            this.Back.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.Back.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Back.OnPressedState.IconLeftImage = null;
            this.Back.OnPressedState.IconRightImage = null;
            this.Back.Size = new System.Drawing.Size(100, 40);
            this.Back.TabIndex = 27;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Back.TextMarginLeft = 0;
            this.Back.TextPadding = new System.Windows.Forms.Padding(0);
            this.Back.UseDefaultRadiusAndThickness = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ManageRubrics
            // 
            this.ManageRubrics.AllowAnimations = true;
            this.ManageRubrics.AllowMouseEffects = true;
            this.ManageRubrics.AllowToggling = false;
            this.ManageRubrics.AnimationSpeed = 200;
            this.ManageRubrics.AutoGenerateColors = false;
            this.ManageRubrics.AutoRoundBorders = false;
            this.ManageRubrics.AutoSizeLeftIcon = true;
            this.ManageRubrics.AutoSizeRightIcon = true;
            this.ManageRubrics.BackColor = System.Drawing.Color.Transparent;
            this.ManageRubrics.BackColor1 = System.Drawing.Color.Silver;
            this.ManageRubrics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageRubrics.BackgroundImage")));
            this.ManageRubrics.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ManageRubrics.ButtonText = "Manage Rubrics";
            this.ManageRubrics.ButtonTextMarginLeft = 0;
            this.ManageRubrics.ColorContrastOnClick = 45;
            this.ManageRubrics.ColorContrastOnHover = 45;
            this.ManageRubrics.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ManageRubrics.CustomizableEdges = borderEdges2;
            this.ManageRubrics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ManageRubrics.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ManageRubrics.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ManageRubrics.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ManageRubrics.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ManageRubrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRubrics.ForeColor = System.Drawing.Color.White;
            this.ManageRubrics.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageRubrics.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ManageRubrics.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ManageRubrics.IconMarginLeft = 11;
            this.ManageRubrics.IconPadding = 10;
            this.ManageRubrics.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageRubrics.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ManageRubrics.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ManageRubrics.IconSize = 25;
            this.ManageRubrics.IdleBorderColor = System.Drawing.Color.Silver;
            this.ManageRubrics.IdleBorderRadius = 10;
            this.ManageRubrics.IdleBorderThickness = 3;
            this.ManageRubrics.IdleFillColor = System.Drawing.Color.Silver;
            this.ManageRubrics.IdleIconLeftImage = null;
            this.ManageRubrics.IdleIconRightImage = null;
            this.ManageRubrics.IndicateFocus = false;
            this.ManageRubrics.Location = new System.Drawing.Point(218, 347);
            this.ManageRubrics.Name = "ManageRubrics";
            this.ManageRubrics.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ManageRubrics.OnDisabledState.BorderRadius = 10;
            this.ManageRubrics.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ManageRubrics.OnDisabledState.BorderThickness = 3;
            this.ManageRubrics.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ManageRubrics.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ManageRubrics.OnDisabledState.IconLeftImage = null;
            this.ManageRubrics.OnDisabledState.IconRightImage = null;
            this.ManageRubrics.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.ManageRubrics.onHoverState.BorderRadius = 10;
            this.ManageRubrics.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ManageRubrics.onHoverState.BorderThickness = 3;
            this.ManageRubrics.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ManageRubrics.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ManageRubrics.onHoverState.IconLeftImage = null;
            this.ManageRubrics.onHoverState.IconRightImage = null;
            this.ManageRubrics.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.ManageRubrics.OnIdleState.BorderRadius = 10;
            this.ManageRubrics.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ManageRubrics.OnIdleState.BorderThickness = 3;
            this.ManageRubrics.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.ManageRubrics.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ManageRubrics.OnIdleState.IconLeftImage = null;
            this.ManageRubrics.OnIdleState.IconRightImage = null;
            this.ManageRubrics.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.ManageRubrics.OnPressedState.BorderRadius = 10;
            this.ManageRubrics.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ManageRubrics.OnPressedState.BorderThickness = 3;
            this.ManageRubrics.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.ManageRubrics.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ManageRubrics.OnPressedState.IconLeftImage = null;
            this.ManageRubrics.OnPressedState.IconRightImage = null;
            this.ManageRubrics.Size = new System.Drawing.Size(140, 40);
            this.ManageRubrics.TabIndex = 31;
            this.ManageRubrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManageRubrics.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ManageRubrics.TextMarginLeft = 0;
            this.ManageRubrics.TextPadding = new System.Windows.Forms.Padding(0);
            this.ManageRubrics.UseDefaultRadiusAndThickness = true;
            this.ManageRubrics.Click += new System.EventHandler(this.ManageRubrics_Click);
            // 
            // AddCLO
            // 
            this.AddCLO.AllowAnimations = true;
            this.AddCLO.AllowMouseEffects = true;
            this.AddCLO.AllowToggling = false;
            this.AddCLO.AnimationSpeed = 200;
            this.AddCLO.AutoGenerateColors = false;
            this.AddCLO.AutoRoundBorders = false;
            this.AddCLO.AutoSizeLeftIcon = true;
            this.AddCLO.AutoSizeRightIcon = true;
            this.AddCLO.BackColor = System.Drawing.Color.Transparent;
            this.AddCLO.BackColor1 = System.Drawing.Color.Silver;
            this.AddCLO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCLO.BackgroundImage")));
            this.AddCLO.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddCLO.ButtonText = "Add";
            this.AddCLO.ButtonTextMarginLeft = 0;
            this.AddCLO.ColorContrastOnClick = 45;
            this.AddCLO.ColorContrastOnHover = 45;
            this.AddCLO.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.AddCLO.CustomizableEdges = borderEdges3;
            this.AddCLO.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddCLO.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddCLO.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddCLO.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddCLO.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCLO.ForeColor = System.Drawing.Color.White;
            this.AddCLO.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCLO.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddCLO.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddCLO.IconMarginLeft = 11;
            this.AddCLO.IconPadding = 10;
            this.AddCLO.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCLO.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddCLO.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddCLO.IconSize = 25;
            this.AddCLO.IdleBorderColor = System.Drawing.Color.Silver;
            this.AddCLO.IdleBorderRadius = 10;
            this.AddCLO.IdleBorderThickness = 3;
            this.AddCLO.IdleFillColor = System.Drawing.Color.Silver;
            this.AddCLO.IdleIconLeftImage = null;
            this.AddCLO.IdleIconRightImage = null;
            this.AddCLO.IndicateFocus = false;
            this.AddCLO.Location = new System.Drawing.Point(53, 256);
            this.AddCLO.Name = "AddCLO";
            this.AddCLO.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddCLO.OnDisabledState.BorderRadius = 10;
            this.AddCLO.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddCLO.OnDisabledState.BorderThickness = 3;
            this.AddCLO.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddCLO.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddCLO.OnDisabledState.IconLeftImage = null;
            this.AddCLO.OnDisabledState.IconRightImage = null;
            this.AddCLO.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddCLO.onHoverState.BorderRadius = 10;
            this.AddCLO.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddCLO.onHoverState.BorderThickness = 3;
            this.AddCLO.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.AddCLO.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddCLO.onHoverState.IconLeftImage = null;
            this.AddCLO.onHoverState.IconRightImage = null;
            this.AddCLO.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.AddCLO.OnIdleState.BorderRadius = 10;
            this.AddCLO.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddCLO.OnIdleState.BorderThickness = 3;
            this.AddCLO.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.AddCLO.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddCLO.OnIdleState.IconLeftImage = null;
            this.AddCLO.OnIdleState.IconRightImage = null;
            this.AddCLO.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.AddCLO.OnPressedState.BorderRadius = 10;
            this.AddCLO.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddCLO.OnPressedState.BorderThickness = 3;
            this.AddCLO.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.AddCLO.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddCLO.OnPressedState.IconLeftImage = null;
            this.AddCLO.OnPressedState.IconRightImage = null;
            this.AddCLO.Size = new System.Drawing.Size(100, 40);
            this.AddCLO.TabIndex = 30;
            this.AddCLO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddCLO.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddCLO.TextMarginLeft = 0;
            this.AddCLO.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddCLO.UseDefaultRadiusAndThickness = true;
            this.AddCLO.Click += new System.EventHandler(this.AddCLO_Click);
            // 
            // Update
            // 
            this.Update.AllowAnimations = true;
            this.Update.AllowMouseEffects = true;
            this.Update.AllowToggling = false;
            this.Update.AnimationSpeed = 200;
            this.Update.AutoGenerateColors = false;
            this.Update.AutoRoundBorders = false;
            this.Update.AutoSizeLeftIcon = true;
            this.Update.AutoSizeRightIcon = true;
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.BackColor1 = System.Drawing.Color.Silver;
            this.Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update.BackgroundImage")));
            this.Update.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Update.ButtonText = "Update";
            this.Update.ButtonTextMarginLeft = 0;
            this.Update.ColorContrastOnClick = 45;
            this.Update.ColorContrastOnHover = 45;
            this.Update.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Update.CustomizableEdges = borderEdges4;
            this.Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Update.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Update.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Update.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Update.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Update.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Update.IconMarginLeft = 11;
            this.Update.IconPadding = 10;
            this.Update.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Update.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Update.IconSize = 25;
            this.Update.IdleBorderColor = System.Drawing.Color.Silver;
            this.Update.IdleBorderRadius = 10;
            this.Update.IdleBorderThickness = 3;
            this.Update.IdleFillColor = System.Drawing.Color.Silver;
            this.Update.IdleIconLeftImage = null;
            this.Update.IdleIconRightImage = null;
            this.Update.IndicateFocus = false;
            this.Update.Location = new System.Drawing.Point(424, 256);
            this.Update.Name = "Update";
            this.Update.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Update.OnDisabledState.BorderRadius = 10;
            this.Update.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Update.OnDisabledState.BorderThickness = 3;
            this.Update.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Update.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Update.OnDisabledState.IconLeftImage = null;
            this.Update.OnDisabledState.IconRightImage = null;
            this.Update.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.Update.onHoverState.BorderRadius = 10;
            this.Update.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Update.onHoverState.BorderThickness = 3;
            this.Update.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Update.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Update.onHoverState.IconLeftImage = null;
            this.Update.onHoverState.IconRightImage = null;
            this.Update.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.Update.OnIdleState.BorderRadius = 10;
            this.Update.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Update.OnIdleState.BorderThickness = 3;
            this.Update.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.Update.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Update.OnIdleState.IconLeftImage = null;
            this.Update.OnIdleState.IconRightImage = null;
            this.Update.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.Update.OnPressedState.BorderRadius = 10;
            this.Update.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Update.OnPressedState.BorderThickness = 3;
            this.Update.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.Update.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Update.OnPressedState.IconLeftImage = null;
            this.Update.OnPressedState.IconRightImage = null;
            this.Update.Size = new System.Drawing.Size(100, 40);
            this.Update.TabIndex = 29;
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Update.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Update.TextMarginLeft = 0;
            this.Update.TextPadding = new System.Windows.Forms.Padding(0);
            this.Update.UseDefaultRadiusAndThickness = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.AllowAnimations = true;
            this.Delete.AllowMouseEffects = true;
            this.Delete.AllowToggling = false;
            this.Delete.AnimationSpeed = 200;
            this.Delete.AutoGenerateColors = false;
            this.Delete.AutoRoundBorders = false;
            this.Delete.AutoSizeLeftIcon = true;
            this.Delete.AutoSizeRightIcon = true;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.BackColor1 = System.Drawing.Color.Silver;
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Delete.ButtonText = "Delete";
            this.Delete.ButtonTextMarginLeft = 0;
            this.Delete.ColorContrastOnClick = 45;
            this.Delete.ColorContrastOnHover = 45;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Delete.CustomizableEdges = borderEdges5;
            this.Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Delete.IconMarginLeft = 11;
            this.Delete.IconPadding = 10;
            this.Delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Delete.IconSize = 25;
            this.Delete.IdleBorderColor = System.Drawing.Color.Silver;
            this.Delete.IdleBorderRadius = 10;
            this.Delete.IdleBorderThickness = 3;
            this.Delete.IdleFillColor = System.Drawing.Color.Silver;
            this.Delete.IdleIconLeftImage = null;
            this.Delete.IdleIconRightImage = null;
            this.Delete.IndicateFocus = false;
            this.Delete.Location = new System.Drawing.Point(241, 256);
            this.Delete.Name = "Delete";
            this.Delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Delete.OnDisabledState.BorderRadius = 10;
            this.Delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Delete.OnDisabledState.BorderThickness = 3;
            this.Delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Delete.OnDisabledState.IconLeftImage = null;
            this.Delete.OnDisabledState.IconRightImage = null;
            this.Delete.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.Delete.onHoverState.BorderRadius = 10;
            this.Delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Delete.onHoverState.BorderThickness = 3;
            this.Delete.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Delete.onHoverState.IconLeftImage = null;
            this.Delete.onHoverState.IconRightImage = null;
            this.Delete.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.Delete.OnIdleState.BorderRadius = 10;
            this.Delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Delete.OnIdleState.BorderThickness = 3;
            this.Delete.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.Delete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Delete.OnIdleState.IconLeftImage = null;
            this.Delete.OnIdleState.IconRightImage = null;
            this.Delete.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.Delete.OnPressedState.BorderRadius = 10;
            this.Delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Delete.OnPressedState.BorderThickness = 3;
            this.Delete.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.Delete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Delete.OnPressedState.IconLeftImage = null;
            this.Delete.OnPressedState.IconRightImage = null;
            this.Delete.Size = new System.Drawing.Size(100, 40);
            this.Delete.TabIndex = 28;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delete.TextMarginLeft = 0;
            this.Delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.Delete.UseDefaultRadiusAndThickness = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Home
            // 
            this.Home.AllowAnimations = true;
            this.Home.AllowMouseEffects = true;
            this.Home.AllowToggling = false;
            this.Home.AnimationSpeed = 200;
            this.Home.AutoGenerateColors = false;
            this.Home.AutoRoundBorders = false;
            this.Home.AutoSizeLeftIcon = true;
            this.Home.AutoSizeRightIcon = true;
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackColor1 = System.Drawing.Color.IndianRed;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Home.ButtonText = "Home";
            this.Home.ButtonTextMarginLeft = 0;
            this.Home.ColorContrastOnClick = 45;
            this.Home.ColorContrastOnHover = 45;
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.Home.CustomizableEdges = borderEdges6;
            this.Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Home.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Home.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Home.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Home.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Home.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Home.IconMarginLeft = 11;
            this.Home.IconPadding = 10;
            this.Home.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Home.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Home.IconSize = 25;
            this.Home.IdleBorderColor = System.Drawing.Color.Black;
            this.Home.IdleBorderRadius = 10;
            this.Home.IdleBorderThickness = 3;
            this.Home.IdleFillColor = System.Drawing.Color.IndianRed;
            this.Home.IdleIconLeftImage = null;
            this.Home.IdleIconRightImage = null;
            this.Home.IndicateFocus = false;
            this.Home.Location = new System.Drawing.Point(53, 409);
            this.Home.Name = "Home";
            this.Home.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Home.OnDisabledState.BorderRadius = 10;
            this.Home.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Home.OnDisabledState.BorderThickness = 3;
            this.Home.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Home.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Home.OnDisabledState.IconLeftImage = null;
            this.Home.OnDisabledState.IconRightImage = null;
            this.Home.onHoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.Home.onHoverState.BorderRadius = 10;
            this.Home.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Home.onHoverState.BorderThickness = 3;
            this.Home.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Home.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Home.onHoverState.IconLeftImage = null;
            this.Home.onHoverState.IconRightImage = null;
            this.Home.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.Home.OnIdleState.BorderRadius = 10;
            this.Home.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Home.OnIdleState.BorderThickness = 3;
            this.Home.OnIdleState.FillColor = System.Drawing.Color.IndianRed;
            this.Home.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Home.OnIdleState.IconLeftImage = null;
            this.Home.OnIdleState.IconRightImage = null;
            this.Home.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.Home.OnPressedState.BorderRadius = 10;
            this.Home.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Home.OnPressedState.BorderThickness = 3;
            this.Home.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.Home.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Home.OnPressedState.IconLeftImage = null;
            this.Home.OnPressedState.IconRightImage = null;
            this.Home.Size = new System.Drawing.Size(100, 40);
            this.Home.TabIndex = 32;
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Home.TextMarginLeft = 0;
            this.Home.TextPadding = new System.Windows.Forms.Padding(0);
            this.Home.UseDefaultRadiusAndThickness = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.ManageRubrics);
            this.Controls.Add(this.AddCLO);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CLOsView);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CLOName);
            this.Controls.Add(this.CLOInput);
            this.Name = "CLO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLO";
            ((System.ComponentModel.ISupportInitialize)(this.CLOsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLOName;
        private System.Windows.Forms.TextBox CLOInput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView CLOsView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Back;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ManageRubrics;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddCLO;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Update;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Delete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Home;
    }
}