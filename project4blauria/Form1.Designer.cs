namespace project4blauria
{
    partial class Form1
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDisplayAllRecords = new System.Windows.Forms.Button();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDeleteRecord = new System.Windows.Forms.TextBox();
            this.txtShowRecord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecordOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(45, 27);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(220, 31);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDisplayAllRecords
            // 
            this.btnDisplayAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllRecords.Location = new System.Drawing.Point(20, 19);
            this.btnDisplayAllRecords.Name = "btnDisplayAllRecords";
            this.btnDisplayAllRecords.Size = new System.Drawing.Size(333, 38);
            this.btnDisplayAllRecords.TabIndex = 1;
            this.btnDisplayAllRecords.Text = "Display All Records";
            this.btnDisplayAllRecords.UseVisualStyleBackColor = true;
            this.btnDisplayAllRecords.Click += new System.EventHandler(this.btnDisplayAllRecords_Click);
            // 
            // btnClearResults
            // 
            this.btnClearResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearResults.Location = new System.Drawing.Point(382, 19);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(338, 38);
            this.btnClearResults.TabIndex = 2;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRecord.Location = new System.Drawing.Point(207, 65);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(146, 39);
            this.btnShowRecord.TabIndex = 3;
            this.btnShowRecord.Text = "Show Record";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(382, 65);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(146, 39);
            this.btnDeleteRecord.TabIndex = 4;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(45, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAddItem
            // 
            this.txtAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddItem.Location = new System.Drawing.Point(288, 27);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(463, 26);
            this.txtAddItem.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(288, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(463, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // txtDeleteRecord
            // 
            this.txtDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteRecord.Location = new System.Drawing.Point(534, 71);
            this.txtDeleteRecord.Name = "txtDeleteRecord";
            this.txtDeleteRecord.Size = new System.Drawing.Size(186, 26);
            this.txtDeleteRecord.TabIndex = 9;
            // 
            // txtShowRecord
            // 
            this.txtShowRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowRecord.Location = new System.Drawing.Point(20, 71);
            this.txtShowRecord.Name = "txtShowRecord";
            this.txtShowRecord.Size = new System.Drawing.Size(173, 26);
            this.txtShowRecord.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplayAllRecords);
            this.groupBox1.Controls.Add(this.txtShowRecord);
            this.groupBox1.Controls.Add(this.btnClearResults);
            this.groupBox1.Controls.Add(this.txtDeleteRecord);
            this.groupBox1.Controls.Add(this.btnShowRecord);
            this.groupBox1.Controls.Add(this.btnDeleteRecord);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtRecordOutput
            // 
            this.txtRecordOutput.Location = new System.Drawing.Point(32, 274);
            this.txtRecordOutput.Name = "txtRecordOutput";
            this.txtRecordOutput.Size = new System.Drawing.Size(700, 217);
            this.txtRecordOutput.TabIndex = 12;
            this.txtRecordOutput.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveToolStripMenuItem,
            this.mnuExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSaveToolStripMenuItem
            // 
            this.mnuSaveToolStripMenuItem.Name = "mnuSaveToolStripMenuItem";
            this.mnuSaveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.mnuSaveToolStripMenuItem.Text = "Save";
            this.mnuSaveToolStripMenuItem.Click += new System.EventHandler(this.mnuSaveToolStripMenuItem_Click);
            // 
            // mnuExitToolStripMenuItem
            // 
            this.mnuExitToolStripMenuItem.Name = "mnuExitToolStripMenuItem";
            this.mnuExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.mnuExitToolStripMenuItem.Text = "Exit";
            this.mnuExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchToolStripMenuItem,
            this.mnuClearResultsToolStripMenuItem,
            this.mnuDisplayAllRecordsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuSearchToolStripMenuItem
            // 
            this.mnuSearchToolStripMenuItem.Name = "mnuSearchToolStripMenuItem";
            this.mnuSearchToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mnuSearchToolStripMenuItem.Text = "Search";
            this.mnuSearchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mnuClearResultsToolStripMenuItem
            // 
            this.mnuClearResultsToolStripMenuItem.Name = "mnuClearResultsToolStripMenuItem";
            this.mnuClearResultsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mnuClearResultsToolStripMenuItem.Text = "Clear Results";
            this.mnuClearResultsToolStripMenuItem.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // mnuDisplayAllRecordsToolStripMenuItem
            // 
            this.mnuDisplayAllRecordsToolStripMenuItem.Name = "mnuDisplayAllRecordsToolStripMenuItem";
            this.mnuDisplayAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mnuDisplayAllRecordsToolStripMenuItem.Text = "Display All Records";
            this.mnuDisplayAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.btnDisplayAllRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 520);
            this.Controls.Add(this.txtRecordOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDisplayAllRecords;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDeleteRecord;
        private System.Windows.Forms.TextBox txtShowRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtRecordOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayAllRecordsToolStripMenuItem;
    }
}

