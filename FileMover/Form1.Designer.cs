﻿namespace FileMover
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStripTop = new MenuStrip();
            toolStripFileButton = new ToolStripMenuItem();
            toolStripFileOpenButton = new ToolStripMenuItem();
            toolStripFileSaveButton = new ToolStripMenuItem();
            toolStripAnalyzeButton = new ToolStripMenuItem();
            toolStripAnalyzeFileCountButton = new ToolStripMenuItem();
            toolStripAnalyzeFolderCountButton = new ToolStripMenuItem();
            toolStripAnalyzeListFilesButton = new ToolStripMenuItem();
            toolStripAnalyzeListFoldersButton = new ToolStripMenuItem();
            toolStripHelpButton = new ToolStripMenuItem();
            toolStripHelpFeatureRequestButton = new ToolStripMenuItem();
            toolStripHelpInfoButton = new ToolStripMenuItem();
            sourceFilesListBox = new ListBox();
            selectSourceFilesButton = new Button();
            startButton = new Button();
            optionsLabel = new Label();
            optionsLeaveSourceFilesCheckbox = new CheckBox();
            optionsSaveActionsListCheckbox = new CheckBox();
            optionsChangeActionsListSaveLocationButton = new Button();
            fileMoveProgressBar = new ProgressBar();
            fileMoveProgressBarLabel = new Label();
            selectFilesDialouge = new OpenFileDialog();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            resources.ApplyResources(menuStripTop, "menuStripTop");
            menuStripTop.Items.AddRange(new ToolStripItem[] { toolStripFileButton, toolStripAnalyzeButton, toolStripHelpButton });
            menuStripTop.Name = "menuStripTop";
            // 
            // toolStripFileButton
            // 
            resources.ApplyResources(toolStripFileButton, "toolStripFileButton");
            toolStripFileButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripFileOpenButton, toolStripFileSaveButton });
            toolStripFileButton.Name = "toolStripFileButton";
            toolStripFileButton.Click += toolStripFileButton_Click;
            // 
            // toolStripFileOpenButton
            // 
            resources.ApplyResources(toolStripFileOpenButton, "toolStripFileOpenButton");
            toolStripFileOpenButton.Name = "toolStripFileOpenButton";
            toolStripFileOpenButton.Click += toolStripFileOpenButton_Click;
            // 
            // toolStripFileSaveButton
            // 
            resources.ApplyResources(toolStripFileSaveButton, "toolStripFileSaveButton");
            toolStripFileSaveButton.Name = "toolStripFileSaveButton";
            toolStripFileSaveButton.Click += toolStripFileSaveButton_Click;
            // 
            // toolStripAnalyzeButton
            // 
            resources.ApplyResources(toolStripAnalyzeButton, "toolStripAnalyzeButton");
            toolStripAnalyzeButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripAnalyzeFileCountButton, toolStripAnalyzeFolderCountButton, toolStripAnalyzeListFilesButton, toolStripAnalyzeListFoldersButton });
            toolStripAnalyzeButton.Name = "toolStripAnalyzeButton";
            toolStripAnalyzeButton.Click += toolStripAnalyzeButton_Click;
            // 
            // toolStripAnalyzeFileCountButton
            // 
            resources.ApplyResources(toolStripAnalyzeFileCountButton, "toolStripAnalyzeFileCountButton");
            toolStripAnalyzeFileCountButton.Name = "toolStripAnalyzeFileCountButton";
            toolStripAnalyzeFileCountButton.Click += toolStripAnalyzeFileCountButton_Click;
            // 
            // toolStripAnalyzeFolderCountButton
            // 
            resources.ApplyResources(toolStripAnalyzeFolderCountButton, "toolStripAnalyzeFolderCountButton");
            toolStripAnalyzeFolderCountButton.Name = "toolStripAnalyzeFolderCountButton";
            toolStripAnalyzeFolderCountButton.Click += toolStripAnalyzeFolderCountButton_Click;
            // 
            // toolStripAnalyzeListFilesButton
            // 
            resources.ApplyResources(toolStripAnalyzeListFilesButton, "toolStripAnalyzeListFilesButton");
            toolStripAnalyzeListFilesButton.Name = "toolStripAnalyzeListFilesButton";
            toolStripAnalyzeListFilesButton.Click += toolStripAnalyzeListFilesButton_Click;
            // 
            // toolStripAnalyzeListFoldersButton
            // 
            resources.ApplyResources(toolStripAnalyzeListFoldersButton, "toolStripAnalyzeListFoldersButton");
            toolStripAnalyzeListFoldersButton.Name = "toolStripAnalyzeListFoldersButton";
            toolStripAnalyzeListFoldersButton.Click += toolStripAnalyzeListFoldersButton_Click;
            // 
            // toolStripHelpButton
            // 
            resources.ApplyResources(toolStripHelpButton, "toolStripHelpButton");
            toolStripHelpButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripHelpFeatureRequestButton, toolStripHelpInfoButton });
            toolStripHelpButton.Name = "toolStripHelpButton";
            toolStripHelpButton.Click += toolStripHelpButton_Click;
            // 
            // toolStripHelpFeatureRequestButton
            // 
            resources.ApplyResources(toolStripHelpFeatureRequestButton, "toolStripHelpFeatureRequestButton");
            toolStripHelpFeatureRequestButton.Name = "toolStripHelpFeatureRequestButton";
            toolStripHelpFeatureRequestButton.Click += toolStripHelpFeatureRequestButton_Click;
            // 
            // toolStripHelpInfoButton
            // 
            resources.ApplyResources(toolStripHelpInfoButton, "toolStripHelpInfoButton");
            toolStripHelpInfoButton.Name = "toolStripHelpInfoButton";
            toolStripHelpInfoButton.Click += toolStripHelpInfoButton_Click;
            // 
            // sourceFilesListBox
            // 
            resources.ApplyResources(sourceFilesListBox, "sourceFilesListBox");
            sourceFilesListBox.FormattingEnabled = true;
            sourceFilesListBox.Name = "sourceFilesListBox";
            // 
            // selectSourceFilesButton
            // 
            resources.ApplyResources(selectSourceFilesButton, "selectSourceFilesButton");
            selectSourceFilesButton.Name = "selectSourceFilesButton";
            selectSourceFilesButton.UseVisualStyleBackColor = true;
            selectSourceFilesButton.Click += selectSourceFilesButton_Click;
            // 
            // startButton
            // 
            resources.ApplyResources(startButton, "startButton");
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            resources.ApplyResources(optionsLabel, "optionsLabel");
            optionsLabel.Name = "optionsLabel";
            // 
            // optionsLeaveSourceFilesCheckbox
            // 
            resources.ApplyResources(optionsLeaveSourceFilesCheckbox, "optionsLeaveSourceFilesCheckbox");
            optionsLeaveSourceFilesCheckbox.BackColor = SystemColors.Control;
            optionsLeaveSourceFilesCheckbox.Name = "optionsLeaveSourceFilesCheckbox";
            optionsLeaveSourceFilesCheckbox.UseVisualStyleBackColor = false;
            // 
            // optionsSaveActionsListCheckbox
            // 
            resources.ApplyResources(optionsSaveActionsListCheckbox, "optionsSaveActionsListCheckbox");
            optionsSaveActionsListCheckbox.Name = "optionsSaveActionsListCheckbox";
            optionsSaveActionsListCheckbox.UseVisualStyleBackColor = true;
            // 
            // optionsChangeActionsListSaveLocationButton
            // 
            resources.ApplyResources(optionsChangeActionsListSaveLocationButton, "optionsChangeActionsListSaveLocationButton");
            optionsChangeActionsListSaveLocationButton.Name = "optionsChangeActionsListSaveLocationButton";
            optionsChangeActionsListSaveLocationButton.UseVisualStyleBackColor = true;
            optionsChangeActionsListSaveLocationButton.Click += actionsListSaveLocationChangeButton_Click;
            // 
            // fileMoveProgressBar
            // 
            resources.ApplyResources(fileMoveProgressBar, "fileMoveProgressBar");
            fileMoveProgressBar.Name = "fileMoveProgressBar";
            // 
            // fileMoveProgressBarLabel
            // 
            resources.ApplyResources(fileMoveProgressBarLabel, "fileMoveProgressBarLabel");
            fileMoveProgressBarLabel.Name = "fileMoveProgressBarLabel";
            // 
            // selectFilesDialouge
            // 
            selectFilesDialouge.FileName = "selectFilesDialougeResult";
            resources.ApplyResources(selectFilesDialouge, "selectFilesDialouge");
            selectFilesDialouge.InitialDirectory = "C:\\";
            selectFilesDialouge.ShowHiddenFiles = true;
            selectFilesDialouge.FileOk += selectFilesDialogue_FileOk;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fileMoveProgressBarLabel);
            Controls.Add(fileMoveProgressBar);
            Controls.Add(optionsChangeActionsListSaveLocationButton);
            Controls.Add(optionsSaveActionsListCheckbox);
            Controls.Add(optionsLeaveSourceFilesCheckbox);
            Controls.Add(optionsLabel);
            Controls.Add(startButton);
            Controls.Add(selectSourceFilesButton);
            Controls.Add(sourceFilesListBox);
            Controls.Add(menuStripTop);
            MainMenuStrip = menuStripTop;
            Name = "MainWindow";
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // All of this needs to be renamed
        private MenuStrip menuStripTop;
        private ToolStripMenuItem toolStripFileButton;
        private ToolStripMenuItem toolStripFileOpenButton;
        private ToolStripMenuItem toolStripFileSaveButton;
        private ToolStripMenuItem toolStripAnalyzeButton;
        private ToolStripMenuItem toolStripAnalyzeFileCountButton;
        private ToolStripMenuItem toolStripAnalyzeFolderCountButton;
        private ToolStripMenuItem toolStripAnalyzeListFilesButton;
        private ToolStripMenuItem toolStripAnalyzeListFoldersButton;
        private ToolStripMenuItem toolStripHelpButton;
        private ToolStripMenuItem toolStripHelpFeatureRequestButton;
        private ToolStripMenuItem toolStripHelpInfoButton;
        private ListBox sourceFilesListBox;
        private Button selectSourceFilesButton;
        private Button startButton;
        private Label optionsLabel;
        private CheckBox optionsLeaveSourceFilesCheckbox;
        private CheckBox optionsSaveActionsListCheckbox;
        private Button optionsChangeActionsListSaveLocationButton;
        private ProgressBar fileMoveProgressBar;
        private Label fileMoveProgressBarLabel;
        private OpenFileDialog selectFilesDialouge;
    }
}