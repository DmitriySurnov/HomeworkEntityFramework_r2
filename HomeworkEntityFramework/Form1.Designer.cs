namespace HomeworkEntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxChoosePlayer = new ComboBox();
            labelChoosePlayer = new Label();
            labelPlayerName = new Label();
            textBoxPlayerName = new TextBox();
            textBoxLevel = new TextBox();
            labelLevel = new Label();
            textBoxClassName = new TextBox();
            labelClassName = new Label();
            textBoxExperience = new TextBox();
            labelExperience = new Label();
            labelSkills = new Label();
            listBoxSkills = new ListBox();
            buttonRaiseLevel = new Button();
            buttonLowerLevel = new Button();
            SuspendLayout();
            // 
            // comboBoxChoosePlayer
            // 
            comboBoxChoosePlayer.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxChoosePlayer.FormattingEnabled = true;
            comboBoxChoosePlayer.Location = new Point(372, 12);
            comboBoxChoosePlayer.Name = "comboBoxChoosePlayer";
            comboBoxChoosePlayer.Size = new Size(521, 67);
            comboBoxChoosePlayer.TabIndex = 0;
            comboBoxChoosePlayer.SelectedIndexChanged += ComboBoxChoosePlayer_SelectedIndexChanged;
            // 
            // labelChoosePlayer
            // 
            labelChoosePlayer.AutoSize = true;
            labelChoosePlayer.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelChoosePlayer.Location = new Point(12, 9);
            labelChoosePlayer.Name = "labelChoosePlayer";
            labelChoosePlayer.Size = new Size(364, 59);
            labelChoosePlayer.TabIndex = 1;
            labelChoosePlayer.Text = "Выберите игрока";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(12, 100);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(262, 59);
            labelPlayerName.TabIndex = 2;
            labelPlayerName.Text = "Имя Игрока";
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Enabled = false;
            textBoxPlayerName.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlayerName.Location = new Point(372, 97);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(521, 65);
            textBoxPlayerName.TabIndex = 3;
            // 
            // textBoxLevel
            // 
            textBoxLevel.Enabled = false;
            textBoxLevel.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLevel.Location = new Point(372, 172);
            textBoxLevel.Name = "textBoxLevel";
            textBoxLevel.Size = new Size(521, 65);
            textBoxLevel.TabIndex = 5;
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelLevel.Location = new Point(12, 175);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(191, 59);
            labelLevel.TabIndex = 4;
            labelLevel.Text = "Уровень";
            // 
            // textBoxClassName
            // 
            textBoxClassName.Enabled = false;
            textBoxClassName.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClassName.Location = new Point(372, 333);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(521, 65);
            textBoxClassName.TabIndex = 9;
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelClassName.Location = new Point(12, 336);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(354, 59);
            labelClassName.TabIndex = 8;
            labelClassName.Text = "Название класса";
            // 
            // textBoxExperience
            // 
            textBoxExperience.Enabled = false;
            textBoxExperience.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExperience.Location = new Point(372, 258);
            textBoxExperience.Name = "textBoxExperience";
            textBoxExperience.Size = new Size(521, 65);
            textBoxExperience.TabIndex = 7;
            // 
            // labelExperience
            // 
            labelExperience.AutoSize = true;
            labelExperience.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelExperience.Location = new Point(12, 261);
            labelExperience.Name = "labelExperience";
            labelExperience.Size = new Size(131, 59);
            labelExperience.TabIndex = 6;
            labelExperience.Text = "Опыт";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelSkills.Location = new Point(12, 437);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(178, 59);
            labelSkills.TabIndex = 10;
            labelSkills.Text = "Навыки";
            // 
            // listBoxSkills
            // 
            listBoxSkills.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxSkills.FormattingEnabled = true;
            listBoxSkills.ItemHeight = 59;
            listBoxSkills.Location = new Point(372, 437);
            listBoxSkills.Name = "listBoxSkills";
            listBoxSkills.Size = new Size(521, 122);
            listBoxSkills.TabIndex = 11;
            // 
            // buttonRaiseLevel
            // 
            buttonRaiseLevel.Enabled = false;
            buttonRaiseLevel.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRaiseLevel.Location = new Point(705, 632);
            buttonRaiseLevel.Name = "buttonRaiseLevel";
            buttonRaiseLevel.Size = new Size(408, 89);
            buttonRaiseLevel.TabIndex = 12;
            buttonRaiseLevel.Text = "Поднять Уровень";
            buttonRaiseLevel.UseVisualStyleBackColor = true;
            buttonRaiseLevel.Click += ButtonRaiseLevel_Click;
            // 
            // buttonLowerLevel
            // 
            buttonLowerLevel.Enabled = false;
            buttonLowerLevel.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLowerLevel.Location = new Point(12, 632);
            buttonLowerLevel.Name = "buttonLowerLevel";
            buttonLowerLevel.Size = new Size(408, 89);
            buttonLowerLevel.TabIndex = 13;
            buttonLowerLevel.Text = "Опустить Уровень";
            buttonLowerLevel.UseVisualStyleBackColor = true;
            buttonLowerLevel.Click += ButtonLowerLevel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 765);
            Controls.Add(buttonLowerLevel);
            Controls.Add(buttonRaiseLevel);
            Controls.Add(comboBoxChoosePlayer);
            Controls.Add(listBoxSkills);
            Controls.Add(labelSkills);
            Controls.Add(textBoxClassName);
            Controls.Add(labelClassName);
            Controls.Add(textBoxExperience);
            Controls.Add(labelExperience);
            Controls.Add(textBoxLevel);
            Controls.Add(labelLevel);
            Controls.Add(textBoxPlayerName);
            Controls.Add(labelPlayerName);
            Controls.Add(labelChoosePlayer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxChoosePlayer;
        private Label labelChoosePlayer;
        private Label labelPlayerName;
        private TextBox textBoxPlayerName;
        private TextBox textBoxLevel;
        private Label labelLevel;
        private TextBox textBoxClassName;
        private Label labelClassName;
        private TextBox textBoxExperience;
        private Label labelExperience;
        private Label labelSkills;
        private ListBox listBoxSkills;
        private Button buttonRaiseLevel;
        private Button buttonLowerLevel;
    }
}