namespace KsaweryWawrzyniakLab3Zadanie
{
    partial class FormPlay
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
            this.dataGridViewRecord = new System.Windows.Forms.DataGridView();
            this.ColumnWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPawn = new System.Windows.Forms.Button();
            this.buttonKnight = new System.Windows.Forms.Button();
            this.buttonBishop = new System.Windows.Forms.Button();
            this.buttonRook = new System.Windows.Forms.Button();
            this.buttonQueen = new System.Windows.Forms.Button();
            this.buttonKing = new System.Windows.Forms.Button();
            this.textBoxMove = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecord
            // 
            this.dataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWhite,
            this.ColumnBlack,
            this.ColumnComment});
            this.dataGridViewRecord.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRecord.Name = "dataGridViewRecord";
            this.dataGridViewRecord.RowHeadersWidth = 51;
            this.dataGridViewRecord.RowTemplate.Height = 24;
            this.dataGridViewRecord.Size = new System.Drawing.Size(429, 150);
            this.dataGridViewRecord.TabIndex = 0;
            // 
            // ColumnWhite
            // 
            this.ColumnWhite.HeaderText = "White";
            this.ColumnWhite.MinimumWidth = 6;
            this.ColumnWhite.Name = "ColumnWhite";
            this.ColumnWhite.Width = 125;
            // 
            // ColumnBlack
            // 
            this.ColumnBlack.HeaderText = "Black";
            this.ColumnBlack.MinimumWidth = 6;
            this.ColumnBlack.Name = "ColumnBlack";
            this.ColumnBlack.Width = 125;
            // 
            // ColumnComment
            // 
            this.ColumnComment.HeaderText = "Comment";
            this.ColumnComment.MinimumWidth = 6;
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.Width = 125;
            // 
            // buttonPawn
            // 
            this.buttonPawn.Location = new System.Drawing.Point(61, 194);
            this.buttonPawn.Name = "buttonPawn";
            this.buttonPawn.Size = new System.Drawing.Size(75, 23);
            this.buttonPawn.TabIndex = 1;
            this.buttonPawn.Text = "Pion";
            this.buttonPawn.UseVisualStyleBackColor = true;
            // 
            // buttonKnight
            // 
            this.buttonKnight.Location = new System.Drawing.Point(269, 194);
            this.buttonKnight.Name = "buttonKnight";
            this.buttonKnight.Size = new System.Drawing.Size(75, 23);
            this.buttonKnight.TabIndex = 2;
            this.buttonKnight.Text = "Skoczek";
            this.buttonKnight.UseVisualStyleBackColor = true;
            // 
            // buttonBishop
            // 
            this.buttonBishop.Location = new System.Drawing.Point(61, 291);
            this.buttonBishop.Name = "buttonBishop";
            this.buttonBishop.Size = new System.Drawing.Size(75, 23);
            this.buttonBishop.TabIndex = 3;
            this.buttonBishop.Text = "Goniec";
            this.buttonBishop.UseVisualStyleBackColor = true;
            // 
            // buttonRook
            // 
            this.buttonRook.Location = new System.Drawing.Point(269, 291);
            this.buttonRook.Name = "buttonRook";
            this.buttonRook.Size = new System.Drawing.Size(75, 23);
            this.buttonRook.TabIndex = 4;
            this.buttonRook.Text = "Wieża";
            this.buttonRook.UseVisualStyleBackColor = true;
            // 
            // buttonQueen
            // 
            this.buttonQueen.Location = new System.Drawing.Point(61, 386);
            this.buttonQueen.Name = "buttonQueen";
            this.buttonQueen.Size = new System.Drawing.Size(75, 23);
            this.buttonQueen.TabIndex = 5;
            this.buttonQueen.Text = "Hetman";
            this.buttonQueen.UseVisualStyleBackColor = true;
            // 
            // buttonKing
            // 
            this.buttonKing.Location = new System.Drawing.Point(269, 386);
            this.buttonKing.Name = "buttonKing";
            this.buttonKing.Size = new System.Drawing.Size(75, 23);
            this.buttonKing.TabIndex = 6;
            this.buttonKing.Text = "Król";
            this.buttonKing.UseVisualStyleBackColor = true;
            // 
            // textBoxMove
            // 
            this.textBoxMove.Location = new System.Drawing.Point(581, 75);
            this.textBoxMove.Name = "textBoxMove";
            this.textBoxMove.Size = new System.Drawing.Size(100, 22);
            this.textBoxMove.TabIndex = 7;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMove);
            this.Controls.Add(this.buttonKing);
            this.Controls.Add(this.buttonQueen);
            this.Controls.Add(this.buttonRook);
            this.Controls.Add(this.buttonBishop);
            this.Controls.Add(this.buttonKnight);
            this.Controls.Add(this.buttonPawn);
            this.Controls.Add(this.dataGridViewRecord);
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBlack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.Button buttonPawn;
        private System.Windows.Forms.Button buttonKnight;
        private System.Windows.Forms.Button buttonBishop;
        private System.Windows.Forms.Button buttonRook;
        private System.Windows.Forms.Button buttonQueen;
        private System.Windows.Forms.Button buttonKing;
        private System.Windows.Forms.TextBox textBoxMove;
    }
}