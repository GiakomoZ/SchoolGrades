﻿namespace SchoolGrades
{
    partial class FrmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.btnTabelle = new System.Windows.Forms.Button();
            this.btnClassi = new System.Windows.Forms.Button();
            this.btnBackupManagement = new System.Windows.Forms.Button();
            this.TxtFileDatabase = new System.Windows.Forms.TextBox();
            this.btnFileDatabase = new System.Windows.Forms.Button();
            this.TxtPathImages = new System.Windows.Forms.TextBox();
            this.btnPathImages = new System.Windows.Forms.Button();
            this.btnSaveConfigurationFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFileDatabase = new System.Windows.Forms.Label();
            this.lblPathDatabase = new System.Windows.Forms.Label();
            this.TxtPathDatabase = new System.Windows.Forms.TextBox();
            this.btnPathDatabase = new System.Windows.Forms.Button();
            this.lblPathImages = new System.Windows.Forms.Label();
            this.btnTopicsManagement = new System.Windows.Forms.Button();
            this.btnTagsManagement = new System.Windows.Forms.Button();
            this.btnStartLinksManagenet = new System.Windows.Forms.Button();
            this.btnQuestionManagement = new System.Windows.Forms.Button();
            this.btnTestManagement = new System.Windows.Forms.Button();
            this.btnRecoverTopics = new System.Windows.Forms.Button();
            this.TxtPathDocuments = new System.Windows.Forms.TextBox();
            this.btnPathDocuments = new System.Windows.Forms.Button();
            this.lblPathDocuments = new System.Windows.Forms.Label();
            this.btnEraseConfigurationFile = new System.Windows.Forms.Button();
            this.BtnUseDemo = new System.Windows.Forms.Button();
            this.btnSchoolSubjectManagement = new System.Windows.Forms.Button();
            this.btnOpenConfigurationFolder = new System.Windows.Forms.Button();
            this.chkAskPassword = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkSaveBackup = new System.Windows.Forms.CheckBox();
            this.btnSchoolPeriodsManagement = new System.Windows.Forms.Button();
            this.btnUsersManagement = new System.Windows.Forms.Button();
            this.btnResetDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTabelle
            // 
            this.btnTabelle.Location = new System.Drawing.Point(8, 12);
            this.btnTabelle.Name = "btnTabelle";
            this.btnTabelle.Size = new System.Drawing.Size(100, 60);
            this.btnTabelle.TabIndex = 0;
            this.btnTabelle.Text = "Gestione tabelle";
            this.toolTip1.SetToolTip(this.btnTabelle, "Modifiche delle tabelle dei dati fissi");
            this.btnTabelle.UseVisualStyleBackColor = true;
            this.btnTabelle.Click += new System.EventHandler(this.BtnTabelle_Click);
            // 
            // btnClassi
            // 
            this.btnClassi.Location = new System.Drawing.Point(109, 12);
            this.btnClassi.Name = "btnClassi";
            this.btnClassi.Size = new System.Drawing.Size(100, 60);
            this.btnClassi.TabIndex = 1;
            this.btnClassi.Text = "Gestione classi";
            this.toolTip1.SetToolTip(this.btnClassi, "Creazione e modifica delle classi");
            this.btnClassi.UseVisualStyleBackColor = true;
            this.btnClassi.Click += new System.EventHandler(this.BtnClassi_Click);
            // 
            // btnBackupManagement
            // 
            this.btnBackupManagement.Location = new System.Drawing.Point(210, 12);
            this.btnBackupManagement.Name = "btnBackupManagement";
            this.btnBackupManagement.Size = new System.Drawing.Size(100, 60);
            this.btnBackupManagement.TabIndex = 2;
            this.btnBackupManagement.Text = "Backup e gen.file";
            this.toolTip1.SetToolTip(this.btnBackupManagement, "Generazione di file e salvataggi di backup");
            this.btnBackupManagement.UseVisualStyleBackColor = true;
            this.btnBackupManagement.Click += new System.EventHandler(this.btnBackupManagement_Click);
            // 
            // TxtFileDatabase
            // 
            this.TxtFileDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFileDatabase.Location = new System.Drawing.Point(8, 153);
            this.TxtFileDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFileDatabase.Name = "TxtFileDatabase";
            this.TxtFileDatabase.Size = new System.Drawing.Size(537, 24);
            this.TxtFileDatabase.TabIndex = 2;
            this.TxtFileDatabase.TextChanged += new System.EventHandler(this.TxtFileDatabase_TextChanged);
            this.TxtFileDatabase.DoubleClick += new System.EventHandler(this.TxtPaths_DoubleClick);
            // 
            // btnFileDatabase
            // 
            this.btnFileDatabase.BackColor = System.Drawing.Color.Transparent;
            this.btnFileDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileDatabase.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFileDatabase.Location = new System.Drawing.Point(555, 144);
            this.btnFileDatabase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFileDatabase.Name = "btnFileDatabase";
            this.btnFileDatabase.Size = new System.Drawing.Size(54, 40);
            this.btnFileDatabase.TabIndex = 84;
            this.btnFileDatabase.Text = "..";
            this.btnFileDatabase.UseVisualStyleBackColor = false;
            this.btnFileDatabase.Click += new System.EventHandler(this.btnScegliFile_Click);
            // 
            // TxtPathImages
            // 
            this.TxtPathImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPathImages.Location = new System.Drawing.Point(8, 203);
            this.TxtPathImages.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPathImages.Name = "TxtPathImages";
            this.TxtPathImages.Size = new System.Drawing.Size(762, 24);
            this.TxtPathImages.TabIndex = 15;
            this.TxtPathImages.TextChanged += new System.EventHandler(this.TxtPathImages_TextChanged);
            this.TxtPathImages.DoubleClick += new System.EventHandler(this.TxtPaths_DoubleClick);
            // 
            // btnPathImages
            // 
            this.btnPathImages.BackColor = System.Drawing.Color.Transparent;
            this.btnPathImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPathImages.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPathImages.Location = new System.Drawing.Point(780, 193);
            this.btnPathImages.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPathImages.Name = "btnPathImages";
            this.btnPathImages.Size = new System.Drawing.Size(54, 40);
            this.btnPathImages.TabIndex = 83;
            this.btnPathImages.Text = "..";
            this.btnPathImages.UseVisualStyleBackColor = false;
            this.btnPathImages.Click += new System.EventHandler(this.btnCartellaImmagini_Click);
            // 
            // btnSaveConfigurationFile
            // 
            this.btnSaveConfigurationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveConfigurationFile.Location = new System.Drawing.Point(1131, 76);
            this.btnSaveConfigurationFile.Name = "btnSaveConfigurationFile";
            this.btnSaveConfigurationFile.Size = new System.Drawing.Size(100, 60);
            this.btnSaveConfigurationFile.TabIndex = 92;
            this.btnSaveConfigurationFile.Text = "Salva config.";
            this.btnSaveConfigurationFile.UseVisualStyleBackColor = true;
            this.btnSaveConfigurationFile.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFileDatabase
            // 
            this.lblFileDatabase.AutoSize = true;
            this.lblFileDatabase.Location = new System.Drawing.Point(5, 132);
            this.lblFileDatabase.Name = "lblFileDatabase";
            this.lblFileDatabase.Size = new System.Drawing.Size(81, 18);
            this.lblFileDatabase.TabIndex = 93;
            this.lblFileDatabase.Text = "File dei dati";
            // 
            // lblPathDatabase
            // 
            this.lblPathDatabase.AutoSize = true;
            this.lblPathDatabase.Location = new System.Drawing.Point(5, 74);
            this.lblPathDatabase.Name = "lblPathDatabase";
            this.lblPathDatabase.Size = new System.Drawing.Size(108, 18);
            this.lblPathDatabase.TabIndex = 96;
            this.lblPathDatabase.Text = "Cartella dei dati";
            // 
            // TxtPathDatabase
            // 
            this.TxtPathDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPathDatabase.Location = new System.Drawing.Point(8, 95);
            this.TxtPathDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPathDatabase.Name = "TxtPathDatabase";
            this.TxtPathDatabase.Size = new System.Drawing.Size(762, 24);
            this.TxtPathDatabase.TabIndex = 94;
            this.TxtPathDatabase.TextChanged += new System.EventHandler(this.TxtPathDatabase_TextChanged);
            this.TxtPathDatabase.DoubleClick += new System.EventHandler(this.TxtPaths_DoubleClick);
            // 
            // btnPathDatabase
            // 
            this.btnPathDatabase.BackColor = System.Drawing.Color.Transparent;
            this.btnPathDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPathDatabase.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPathDatabase.Location = new System.Drawing.Point(780, 86);
            this.btnPathDatabase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPathDatabase.Name = "btnPathDatabase";
            this.btnPathDatabase.Size = new System.Drawing.Size(54, 40);
            this.btnPathDatabase.TabIndex = 95;
            this.btnPathDatabase.Text = "..";
            this.btnPathDatabase.UseVisualStyleBackColor = false;
            this.btnPathDatabase.Click += new System.EventHandler(this.btnPathDatabase_Click);
            // 
            // lblPathImages
            // 
            this.lblPathImages.AutoSize = true;
            this.lblPathImages.Location = new System.Drawing.Point(5, 181);
            this.lblPathImages.Name = "lblPathImages";
            this.lblPathImages.Size = new System.Drawing.Size(155, 18);
            this.lblPathImages.TabIndex = 97;
            this.lblPathImages.Text = "Cartella delle immagini";
            // 
            // btnTopicsManagement
            // 
            this.btnTopicsManagement.Location = new System.Drawing.Point(311, 12);
            this.btnTopicsManagement.Name = "btnTopicsManagement";
            this.btnTopicsManagement.Size = new System.Drawing.Size(100, 60);
            this.btnTopicsManagement.TabIndex = 99;
            this.btnTopicsManagement.Text = "Gestione argomenti";
            this.toolTip1.SetToolTip(this.btnTopicsManagement, "Gestione dell\'albero degli argomenti");
            this.btnTopicsManagement.UseVisualStyleBackColor = true;
            this.btnTopicsManagement.Click += new System.EventHandler(this.btnTopicsManagement_Click);
            // 
            // btnTagsManagement
            // 
            this.btnTagsManagement.Location = new System.Drawing.Point(412, 12);
            this.btnTagsManagement.Name = "btnTagsManagement";
            this.btnTagsManagement.Size = new System.Drawing.Size(100, 60);
            this.btnTagsManagement.TabIndex = 100;
            this.btnTagsManagement.Text = "Gestione tag";
            this.toolTip1.SetToolTip(this.btnTagsManagement, "Gestione dei tag associati agli argomenti ");
            this.btnTagsManagement.UseVisualStyleBackColor = true;
            this.btnTagsManagement.Click += new System.EventHandler(this.btnTagsManagement_Click);
            // 
            // btnStartLinksManagenet
            // 
            this.btnStartLinksManagenet.Location = new System.Drawing.Point(616, 12);
            this.btnStartLinksManagenet.Name = "btnStartLinksManagenet";
            this.btnStartLinksManagenet.Size = new System.Drawing.Size(100, 60);
            this.btnStartLinksManagenet.TabIndex = 101;
            this.btnStartLinksManagenet.Text = "Gestione start links";
            this.toolTip1.SetToolTip(this.btnStartLinksManagenet, "Gestione di link e programmi lanciati all\'apertura di una classe");
            this.btnStartLinksManagenet.UseVisualStyleBackColor = true;
            this.btnStartLinksManagenet.Click += new System.EventHandler(this.btnStartLinksManagenet_Click);
            // 
            // btnQuestionManagement
            // 
            this.btnQuestionManagement.Enabled = false;
            this.btnQuestionManagement.Location = new System.Drawing.Point(513, 12);
            this.btnQuestionManagement.Name = "btnQuestionManagement";
            this.btnQuestionManagement.Size = new System.Drawing.Size(100, 60);
            this.btnQuestionManagement.TabIndex = 102;
            this.btnQuestionManagement.Text = "Gestione domande";
            this.toolTip1.SetToolTip(this.btnQuestionManagement, "Gestione delle domande");
            this.btnQuestionManagement.UseVisualStyleBackColor = true;
            this.btnQuestionManagement.Click += new System.EventHandler(this.btnQuestionManagement_Click);
            // 
            // btnTestManagement
            // 
            this.btnTestManagement.Enabled = false;
            this.btnTestManagement.Location = new System.Drawing.Point(719, 12);
            this.btnTestManagement.Name = "btnTestManagement";
            this.btnTestManagement.Size = new System.Drawing.Size(100, 60);
            this.btnTestManagement.TabIndex = 103;
            this.btnTestManagement.Text = "Gestione prove";
            this.toolTip1.SetToolTip(this.btnTestManagement, "Gestione dei test (da finire e controllare! )");
            this.btnTestManagement.UseVisualStyleBackColor = true;
            this.btnTestManagement.Click += new System.EventHandler(this.btnTestManagement_Click);
            // 
            // btnRecoverTopics
            // 
            this.btnRecoverTopics.Location = new System.Drawing.Point(822, 12);
            this.btnRecoverTopics.Name = "btnRecoverTopics";
            this.btnRecoverTopics.Size = new System.Drawing.Size(100, 60);
            this.btnRecoverTopics.TabIndex = 104;
            this.btnRecoverTopics.Text = "Recover argomenti";
            this.toolTip1.SetToolTip(this.btnRecoverTopics, "Confronto fra versioni dell\'albero degli argomenti (da complatare)");
            this.btnRecoverTopics.UseVisualStyleBackColor = true;
            this.btnRecoverTopics.Click += new System.EventHandler(this.btnRecoverTopics_Click);
            // 
            // TxtPathDocuments
            // 
            this.TxtPathDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPathDocuments.Location = new System.Drawing.Point(8, 258);
            this.TxtPathDocuments.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPathDocuments.Name = "TxtPathDocuments";
            this.TxtPathDocuments.Size = new System.Drawing.Size(762, 24);
            this.TxtPathDocuments.TabIndex = 105;
            this.TxtPathDocuments.TextChanged += new System.EventHandler(this.TxtPathDocuments_TextChanged);
            this.TxtPathDocuments.DoubleClick += new System.EventHandler(this.TxtPaths_DoubleClick);
            // 
            // btnPathDocuments
            // 
            this.btnPathDocuments.BackColor = System.Drawing.Color.Transparent;
            this.btnPathDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPathDocuments.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPathDocuments.Location = new System.Drawing.Point(780, 248);
            this.btnPathDocuments.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPathDocuments.Name = "btnPathDocuments";
            this.btnPathDocuments.Size = new System.Drawing.Size(54, 40);
            this.btnPathDocuments.TabIndex = 106;
            this.btnPathDocuments.Text = "..";
            this.btnPathDocuments.UseVisualStyleBackColor = false;
            this.btnPathDocuments.Click += new System.EventHandler(this.btnPathDocuments_Click);
            // 
            // lblPathDocuments
            // 
            this.lblPathDocuments.AutoSize = true;
            this.lblPathDocuments.Location = new System.Drawing.Point(5, 236);
            this.lblPathDocuments.Name = "lblPathDocuments";
            this.lblPathDocuments.Size = new System.Drawing.Size(154, 18);
            this.lblPathDocuments.TabIndex = 107;
            this.lblPathDocuments.Text = "Cartella dei documenti";
            // 
            // btnEraseConfigurationFile
            // 
            this.btnEraseConfigurationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEraseConfigurationFile.Location = new System.Drawing.Point(1131, 204);
            this.btnEraseConfigurationFile.Name = "btnEraseConfigurationFile";
            this.btnEraseConfigurationFile.Size = new System.Drawing.Size(100, 60);
            this.btnEraseConfigurationFile.TabIndex = 108;
            this.btnEraseConfigurationFile.Text = "Cancella config.";
            this.btnEraseConfigurationFile.UseVisualStyleBackColor = true;
            this.btnEraseConfigurationFile.Click += new System.EventHandler(this.btnEraseConfigurationFile_Click);
            // 
            // BtnUseDemo
            // 
            this.BtnUseDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUseDemo.Location = new System.Drawing.Point(1014, 208);
            this.BtnUseDemo.Name = "BtnUseDemo";
            this.BtnUseDemo.Size = new System.Drawing.Size(100, 60);
            this.BtnUseDemo.TabIndex = 109;
            this.BtnUseDemo.Text = "Usa demo";
            this.BtnUseDemo.UseVisualStyleBackColor = true;
            this.BtnUseDemo.Visible = false;
            this.BtnUseDemo.Click += new System.EventHandler(this.BtnUseDemo_Click);
            // 
            // btnSchoolSubjectManagement
            // 
            this.btnSchoolSubjectManagement.Location = new System.Drawing.Point(1028, 12);
            this.btnSchoolSubjectManagement.Name = "btnSchoolSubjectManagement";
            this.btnSchoolSubjectManagement.Size = new System.Drawing.Size(100, 60);
            this.btnSchoolSubjectManagement.TabIndex = 110;
            this.btnSchoolSubjectManagement.Text = "Gestione materie";
            this.btnSchoolSubjectManagement.UseVisualStyleBackColor = true;
            this.btnSchoolSubjectManagement.Click += new System.EventHandler(this.btnSchoolSubjectManagement_Click);
            // 
            // btnOpenConfigurationFolder
            // 
            this.btnOpenConfigurationFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenConfigurationFolder.Location = new System.Drawing.Point(1131, 140);
            this.btnOpenConfigurationFolder.Name = "btnOpenConfigurationFolder";
            this.btnOpenConfigurationFolder.Size = new System.Drawing.Size(100, 60);
            this.btnOpenConfigurationFolder.TabIndex = 111;
            this.btnOpenConfigurationFolder.Text = "Cartella config.";
            this.btnOpenConfigurationFolder.UseVisualStyleBackColor = true;
            this.btnOpenConfigurationFolder.Click += new System.EventHandler(this.btnOpenConfigurationFolder_Click);
            // 
            // chkAskPassword
            // 
            this.chkAskPassword.AutoSize = true;
            this.chkAskPassword.Enabled = false;
            this.chkAskPassword.Location = new System.Drawing.Point(859, 86);
            this.chkAskPassword.Name = "chkAskPassword";
            this.chkAskPassword.Size = new System.Drawing.Size(152, 22);
            this.chkAskPassword.TabIndex = 112;
            this.chkAskPassword.Text = "Chiedi la password";
            this.toolTip1.SetToolTip(this.chkAskPassword, "Se abilitato il programma chiede una password per entrare");
            this.chkAskPassword.UseVisualStyleBackColor = true;
            // 
            // chkSaveBackup
            // 
            this.chkSaveBackup.AutoSize = true;
            this.chkSaveBackup.Location = new System.Drawing.Point(618, 152);
            this.chkSaveBackup.Name = "chkSaveBackup";
            this.chkSaveBackup.Size = new System.Drawing.Size(213, 22);
            this.chkSaveBackup.TabIndex = 113;
            this.chkSaveBackup.Text = "Salva database alla chiusura";
            this.toolTip1.SetToolTip(this.chkSaveBackup, "Se abilitato il programma chiede una password per entrare");
            this.chkSaveBackup.UseVisualStyleBackColor = true;
            // 
            // btnSchoolPeriodsManagement
            // 
            this.btnSchoolPeriodsManagement.Location = new System.Drawing.Point(1131, 12);
            this.btnSchoolPeriodsManagement.Name = "btnSchoolPeriodsManagement";
            this.btnSchoolPeriodsManagement.Size = new System.Drawing.Size(100, 60);
            this.btnSchoolPeriodsManagement.TabIndex = 115;
            this.btnSchoolPeriodsManagement.Text = "Gestione periodi";
            this.toolTip1.SetToolTip(this.btnSchoolPeriodsManagement, "Gestione periodi scolastici (trimesti, quadrimestri..)");
            this.btnSchoolPeriodsManagement.UseVisualStyleBackColor = true;
            this.btnSchoolPeriodsManagement.Click += new System.EventHandler(this.btnSchoolPeriodsManagement_Click);
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.Enabled = false;
            this.btnUsersManagement.Location = new System.Drawing.Point(925, 12);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.Size = new System.Drawing.Size(100, 60);
            this.btnUsersManagement.TabIndex = 114;
            this.btnUsersManagement.Text = "Gestione Utenti";
            this.toolTip1.SetToolTip(this.btnUsersManagement, "TODO!");
            this.btnUsersManagement.UseVisualStyleBackColor = true;
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
            // 
            // btnResetDatabase
            // 
            this.btnResetDatabase.BackColor = System.Drawing.Color.Red;
            this.btnResetDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetDatabase.ForeColor = System.Drawing.Color.Yellow;
            this.btnResetDatabase.Location = new System.Drawing.Point(843, 203);
            this.btnResetDatabase.Name = "btnResetDatabase";
            this.btnResetDatabase.Size = new System.Drawing.Size(116, 69);
            this.btnResetDatabase.TabIndex = 116;
            this.btnResetDatabase.Text = "Reset database";
            this.btnResetDatabase.UseVisualStyleBackColor = false;
            this.btnResetDatabase.Click += new System.EventHandler(this.btnResetDatabase_Click);
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1249, 302);
            this.Controls.Add(this.btnResetDatabase);
            this.Controls.Add(this.btnSchoolPeriodsManagement);
            this.Controls.Add(this.btnUsersManagement);
            this.Controls.Add(this.chkSaveBackup);
            this.Controls.Add(this.chkAskPassword);
            this.Controls.Add(this.btnOpenConfigurationFolder);
            this.Controls.Add(this.btnSchoolSubjectManagement);
            this.Controls.Add(this.BtnUseDemo);
            this.Controls.Add(this.btnEraseConfigurationFile);
            this.Controls.Add(this.TxtPathDocuments);
            this.Controls.Add(this.btnPathDocuments);
            this.Controls.Add(this.lblPathDocuments);
            this.Controls.Add(this.btnRecoverTopics);
            this.Controls.Add(this.btnTestManagement);
            this.Controls.Add(this.btnQuestionManagement);
            this.Controls.Add(this.btnStartLinksManagenet);
            this.Controls.Add(this.btnTagsManagement);
            this.Controls.Add(this.btnTopicsManagement);
            this.Controls.Add(this.TxtPathImages);
            this.Controls.Add(this.btnPathImages);
            this.Controls.Add(this.lblPathImages);
            this.Controls.Add(this.lblPathDatabase);
            this.Controls.Add(this.TxtPathDatabase);
            this.Controls.Add(this.btnPathDatabase);
            this.Controls.Add(this.btnSaveConfigurationFile);
            this.Controls.Add(this.lblFileDatabase);
            this.Controls.Add(this.TxtFileDatabase);
            this.Controls.Add(this.btnFileDatabase);
            this.Controls.Add(this.btnBackupManagement);
            this.Controls.Add(this.btnClassi);
            this.Controls.Add(this.btnTabelle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSetup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabelle;
        private System.Windows.Forms.Button btnClassi;
        private System.Windows.Forms.Button btnBackupManagement;
        private System.Windows.Forms.TextBox TxtFileDatabase;
        private System.Windows.Forms.Button btnFileDatabase;
        private System.Windows.Forms.TextBox TxtPathImages;
        private System.Windows.Forms.Button btnPathImages;
        private System.Windows.Forms.Button btnSaveConfigurationFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblFileDatabase;
        private System.Windows.Forms.Label lblPathDatabase;
        private System.Windows.Forms.TextBox TxtPathDatabase;
        private System.Windows.Forms.Button btnPathDatabase;
        private System.Windows.Forms.Label lblPathImages;
        private System.Windows.Forms.Button btnTopicsManagement;
        private System.Windows.Forms.Button btnTagsManagement;
        private System.Windows.Forms.Button btnStartLinksManagenet;
        private System.Windows.Forms.Button btnQuestionManagement;
        private System.Windows.Forms.Button btnTestManagement;
        private System.Windows.Forms.Button btnRecoverTopics;
        private System.Windows.Forms.TextBox TxtPathDocuments;
        private System.Windows.Forms.Button btnPathDocuments;
        private System.Windows.Forms.Label lblPathDocuments;
        private System.Windows.Forms.Button btnEraseConfigurationFile;
        private System.Windows.Forms.Button BtnUseDemo;
        private System.Windows.Forms.Button btnSchoolSubjectManagement;
        private System.Windows.Forms.Button btnOpenConfigurationFolder;
        private System.Windows.Forms.CheckBox chkAskPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkSaveBackup;
        private System.Windows.Forms.Button btnUsersManagement;
        private System.Windows.Forms.Button btnSchoolPeriodsManagement;
        private System.Windows.Forms.Button btnResetDatabase;
    }
}