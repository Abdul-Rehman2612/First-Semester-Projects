namespace DB_Lab_Management_System.Attendance
{
    partial class ClassAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Title = new System.Windows.Forms.Label();
            this.ClassAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.AttendanceDate = new System.Windows.Forms.Label();
            this.ViewClassAttendances = new System.Windows.Forms.DataGridView();
            this.Back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Add = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MarkAttendance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Home = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClassAttendances)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Title.Location = new System.Drawing.Point(354, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(259, 33);
            this.Title.TabIndex = 13;
            this.Title.Text = "Class Attendance";
            // 
            // ClassAttendanceDate
            // 
            this.ClassAttendanceDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAttendanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAttendanceDate.Location = new System.Drawing.Point(51, 131);
            this.ClassAttendanceDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ClassAttendanceDate.Name = "ClassAttendanceDate";
            this.ClassAttendanceDate.Size = new System.Drawing.Size(344, 31);
            this.ClassAttendanceDate.TabIndex = 15;
            this.ClassAttendanceDate.ValueChanged += new System.EventHandler(this.ClassAttendanceDate_ValueChanged);
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.AutoSize = true;
            this.AttendanceDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttendanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AttendanceDate.Location = new System.Drawing.Point(45, 74);
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.Size = new System.Drawing.Size(240, 33);
            this.AttendanceDate.TabIndex = 16;
            this.AttendanceDate.Text = "Attendance date";
            // 
            // ViewClassAttendances
            // 
            this.ViewClassAttendances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewClassAttendances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewClassAttendances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewClassAttendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClassAttendances.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewClassAttendances.Location = new System.Drawing.Point(632, 54);
            this.ViewClassAttendances.Name = "ViewClassAttendances";
            this.ViewClassAttendances.ReadOnly = true;
            this.ViewClassAttendances.Size = new System.Drawing.Size(340, 328);
            this.ViewClassAttendances.TabIndex = 17;
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
            this.Back.TabIndex = 19;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Back.TextMarginLeft = 0;
            this.Back.TextPadding = new System.Windows.Forms.Padding(0);
            this.Back.UseDefaultRadiusAndThickness = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.AllowAnimations = true;
            this.Add.AllowMouseEffects = true;
            this.Add.AllowToggling = false;
            this.Add.AnimationSpeed = 200;
            this.Add.AutoGenerateColors = false;
            this.Add.AutoRoundBorders = false;
            this.Add.AutoSizeLeftIcon = true;
            this.Add.AutoSizeRightIcon = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BackColor1 = System.Drawing.Color.Silver;
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Add.ButtonText = "Add Class Attendance";
            this.Add.ButtonTextMarginLeft = 0;
            this.Add.ColorContrastOnClick = 45;
            this.Add.ColorContrastOnHover = 45;
            this.Add.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Add.CustomizableEdges = borderEdges2;
            this.Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Add.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Add.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Add.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Add.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Add.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Add.IconMarginLeft = 11;
            this.Add.IconPadding = 10;
            this.Add.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Add.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Add.IconSize = 25;
            this.Add.IdleBorderColor = System.Drawing.Color.Silver;
            this.Add.IdleBorderRadius = 10;
            this.Add.IdleBorderThickness = 3;
            this.Add.IdleFillColor = System.Drawing.Color.Silver;
            this.Add.IdleIconLeftImage = null;
            this.Add.IdleIconRightImage = null;
            this.Add.IndicateFocus = false;
            this.Add.Location = new System.Drawing.Point(51, 194);
            this.Add.Name = "Add";
            this.Add.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Add.OnDisabledState.BorderRadius = 10;
            this.Add.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Add.OnDisabledState.BorderThickness = 3;
            this.Add.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Add.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Add.OnDisabledState.IconLeftImage = null;
            this.Add.OnDisabledState.IconRightImage = null;
            this.Add.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add.onHoverState.BorderRadius = 10;
            this.Add.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Add.onHoverState.BorderThickness = 3;
            this.Add.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Add.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Add.onHoverState.IconLeftImage = null;
            this.Add.onHoverState.IconRightImage = null;
            this.Add.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.Add.OnIdleState.BorderRadius = 10;
            this.Add.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Add.OnIdleState.BorderThickness = 3;
            this.Add.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.Add.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Add.OnIdleState.IconLeftImage = null;
            this.Add.OnIdleState.IconRightImage = null;
            this.Add.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.Add.OnPressedState.BorderRadius = 10;
            this.Add.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Add.OnPressedState.BorderThickness = 3;
            this.Add.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.Add.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Add.OnPressedState.IconLeftImage = null;
            this.Add.OnPressedState.IconRightImage = null;
            this.Add.Size = new System.Drawing.Size(344, 40);
            this.Add.TabIndex = 22;
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Add.TextMarginLeft = 0;
            this.Add.TextPadding = new System.Windows.Forms.Padding(0);
            this.Add.UseDefaultRadiusAndThickness = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MarkAttendance
            // 
            this.MarkAttendance.AllowAnimations = true;
            this.MarkAttendance.AllowMouseEffects = true;
            this.MarkAttendance.AllowToggling = false;
            this.MarkAttendance.AnimationSpeed = 200;
            this.MarkAttendance.AutoGenerateColors = false;
            this.MarkAttendance.AutoRoundBorders = false;
            this.MarkAttendance.AutoSizeLeftIcon = true;
            this.MarkAttendance.AutoSizeRightIcon = true;
            this.MarkAttendance.BackColor = System.Drawing.Color.Transparent;
            this.MarkAttendance.BackColor1 = System.Drawing.Color.Silver;
            this.MarkAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MarkAttendance.BackgroundImage")));
            this.MarkAttendance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MarkAttendance.ButtonText = "Mark Attendance";
            this.MarkAttendance.ButtonTextMarginLeft = 0;
            this.MarkAttendance.ColorContrastOnClick = 45;
            this.MarkAttendance.ColorContrastOnHover = 45;
            this.MarkAttendance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.MarkAttendance.CustomizableEdges = borderEdges3;
            this.MarkAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MarkAttendance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MarkAttendance.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MarkAttendance.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MarkAttendance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.MarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkAttendance.ForeColor = System.Drawing.Color.White;
            this.MarkAttendance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarkAttendance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.MarkAttendance.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.MarkAttendance.IconMarginLeft = 11;
            this.MarkAttendance.IconPadding = 10;
            this.MarkAttendance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MarkAttendance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.MarkAttendance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.MarkAttendance.IconSize = 25;
            this.MarkAttendance.IdleBorderColor = System.Drawing.Color.Silver;
            this.MarkAttendance.IdleBorderRadius = 10;
            this.MarkAttendance.IdleBorderThickness = 3;
            this.MarkAttendance.IdleFillColor = System.Drawing.Color.Silver;
            this.MarkAttendance.IdleIconLeftImage = null;
            this.MarkAttendance.IdleIconRightImage = null;
            this.MarkAttendance.IndicateFocus = false;
            this.MarkAttendance.Location = new System.Drawing.Point(145, 278);
            this.MarkAttendance.Name = "MarkAttendance";
            this.MarkAttendance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MarkAttendance.OnDisabledState.BorderRadius = 10;
            this.MarkAttendance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MarkAttendance.OnDisabledState.BorderThickness = 3;
            this.MarkAttendance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MarkAttendance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MarkAttendance.OnDisabledState.IconLeftImage = null;
            this.MarkAttendance.OnDisabledState.IconRightImage = null;
            this.MarkAttendance.onHoverState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.MarkAttendance.onHoverState.BorderRadius = 10;
            this.MarkAttendance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MarkAttendance.onHoverState.BorderThickness = 3;
            this.MarkAttendance.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.MarkAttendance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.MarkAttendance.onHoverState.IconLeftImage = null;
            this.MarkAttendance.onHoverState.IconRightImage = null;
            this.MarkAttendance.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.MarkAttendance.OnIdleState.BorderRadius = 10;
            this.MarkAttendance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MarkAttendance.OnIdleState.BorderThickness = 3;
            this.MarkAttendance.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.MarkAttendance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.MarkAttendance.OnIdleState.IconLeftImage = null;
            this.MarkAttendance.OnIdleState.IconRightImage = null;
            this.MarkAttendance.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.MarkAttendance.OnPressedState.BorderRadius = 10;
            this.MarkAttendance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MarkAttendance.OnPressedState.BorderThickness = 3;
            this.MarkAttendance.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.MarkAttendance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.MarkAttendance.OnPressedState.IconLeftImage = null;
            this.MarkAttendance.OnPressedState.IconRightImage = null;
            this.MarkAttendance.Size = new System.Drawing.Size(140, 40);
            this.MarkAttendance.TabIndex = 24;
            this.MarkAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MarkAttendance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.MarkAttendance.TextMarginLeft = 0;
            this.MarkAttendance.TextPadding = new System.Windows.Forms.Padding(0);
            this.MarkAttendance.UseDefaultRadiusAndThickness = true;
            this.MarkAttendance.Click += new System.EventHandler(this.MarkAttendance_Click);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Home.CustomizableEdges = borderEdges4;
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
            this.Home.Location = new System.Drawing.Point(51, 409);
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
            this.Home.TabIndex = 33;
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Home.TextMarginLeft = 0;
            this.Home.TextPadding = new System.Windows.Forms.Padding(0);
            this.Home.UseDefaultRadiusAndThickness = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ClassAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.MarkAttendance);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ViewClassAttendances);
            this.Controls.Add(this.AttendanceDate);
            this.Controls.Add(this.ClassAttendanceDate);
            this.Controls.Add(this.Title);
            this.Name = "ClassAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.ViewClassAttendances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker ClassAttendanceDate;
        private System.Windows.Forms.Label AttendanceDate;
        private System.Windows.Forms.DataGridView ViewClassAttendances;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Back;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Add;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton MarkAttendance;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Home;
    }
}