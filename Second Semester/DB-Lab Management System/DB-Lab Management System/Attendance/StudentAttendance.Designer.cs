namespace DB_Lab_Management_System.Attendance
{
    partial class StudentAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Title = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AStatus = new System.Windows.Forms.Label();
            this.StudentReg = new System.Windows.Forms.Label();
            this.AttendanceDate = new System.Windows.Forms.Label();
            this.MarkAttendance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AttendanceDatePick = new System.Windows.Forms.DateTimePicker();
            this.Home = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Title.Location = new System.Drawing.Point(357, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(286, 33);
            this.Title.TabIndex = 13;
            this.Title.Text = "Student Attendance";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.SystemColors.Info;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.FormattingEnabled = true;
            this.StudentID.Location = new System.Drawing.Point(276, 186);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(188, 32);
            this.StudentID.TabIndex = 15;
            this.StudentID.SelectedIndexChanged += new System.EventHandler(this.StudentID_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Info;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(702, 95);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(188, 32);
            this.Status.TabIndex = 16;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
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
            this.Back.Location = new System.Drawing.Point(824, 409);
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
            // AStatus
            // 
            this.AStatus.AutoSize = true;
            this.AStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AStatus.Location = new System.Drawing.Point(576, 95);
            this.AStatus.Name = "AStatus";
            this.AStatus.Size = new System.Drawing.Size(85, 29);
            this.AStatus.TabIndex = 22;
            this.AStatus.Text = "Status";
            // 
            // StudentReg
            // 
            this.StudentReg.AutoSize = true;
            this.StudentReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentReg.Location = new System.Drawing.Point(47, 185);
            this.StudentReg.Name = "StudentReg";
            this.StudentReg.Size = new System.Drawing.Size(109, 29);
            this.StudentReg.TabIndex = 21;
            this.StudentReg.Text = "Reg No.";
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.AutoSize = true;
            this.AttendanceDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttendanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AttendanceDate.Location = new System.Drawing.Point(47, 95);
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.Size = new System.Drawing.Size(204, 29);
            this.AttendanceDate.TabIndex = 20;
            this.AttendanceDate.Text = "Attendance Date";
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.MarkAttendance.CustomizableEdges = borderEdges2;
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
            this.MarkAttendance.Location = new System.Drawing.Point(422, 268);
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
            this.MarkAttendance.Size = new System.Drawing.Size(163, 40);
            this.MarkAttendance.TabIndex = 23;
            this.MarkAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MarkAttendance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.MarkAttendance.TextMarginLeft = 0;
            this.MarkAttendance.TextPadding = new System.Windows.Forms.Padding(0);
            this.MarkAttendance.UseDefaultRadiusAndThickness = true;
            this.MarkAttendance.Click += new System.EventHandler(this.Add_Click);
            // 
            // AttendanceDatePick
            // 
            this.AttendanceDatePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDatePick.Location = new System.Drawing.Point(276, 96);
            this.AttendanceDatePick.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.AttendanceDatePick.Name = "AttendanceDatePick";
            this.AttendanceDatePick.Size = new System.Drawing.Size(257, 26);
            this.AttendanceDatePick.TabIndex = 24;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Home.CustomizableEdges = borderEdges3;
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
            this.Home.Location = new System.Drawing.Point(52, 409);
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
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.AttendanceDatePick);
            this.Controls.Add(this.MarkAttendance);
            this.Controls.Add(this.AStatus);
            this.Controls.Add(this.StudentReg);
            this.Controls.Add(this.AttendanceDate);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Status);
            this.Name = "StudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox StudentID;
        private System.Windows.Forms.ComboBox Status;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Back;
        private System.Windows.Forms.Label AStatus;
        private System.Windows.Forms.Label StudentReg;
        private System.Windows.Forms.Label AttendanceDate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton MarkAttendance;
        private System.Windows.Forms.DateTimePicker AttendanceDatePick;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Home;
    }
}