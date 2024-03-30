namespace WindowsFormsApp
{
    partial class Form2
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
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.buttonWithdrawCash = new System.Windows.Forms.Button();
            this.buttonStartTransfer = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxRecipientCard = new System.Windows.Forms.TextBox();
            this.buttonConfirmTransfer = new System.Windows.Forms.Button();
            this.labelRecipientCard = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.buttonCancelTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.Black;
            this.buttonDeposit.Location = new System.Drawing.Point(16, 249);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(110, 80);
            this.buttonDeposit.TabIndex = 0;
            this.buttonDeposit.Text = "Поповнити картку";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccountInfo.ForeColor = System.Drawing.Color.Black;
            this.buttonAccountInfo.Location = new System.Drawing.Point(134, 249);
            this.buttonAccountInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(110, 80);
            this.buttonAccountInfo.TabIndex = 1;
            this.buttonAccountInfo.Text = "Інформація";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
            // 
            // buttonWithdrawCash
            // 
            this.buttonWithdrawCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithdrawCash.ForeColor = System.Drawing.Color.Black;
            this.buttonWithdrawCash.Location = new System.Drawing.Point(16, 163);
            this.buttonWithdrawCash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonWithdrawCash.Name = "buttonWithdrawCash";
            this.buttonWithdrawCash.Size = new System.Drawing.Size(110, 80);
            this.buttonWithdrawCash.TabIndex = 2;
            this.buttonWithdrawCash.Text = "Зняти";
            this.buttonWithdrawCash.UseVisualStyleBackColor = true;
            this.buttonWithdrawCash.Click += new System.EventHandler(this.buttonWithdrawCash_Click);
            // 
            // buttonStartTransfer
            // 
            this.buttonStartTransfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTransfer.ForeColor = System.Drawing.Color.Black;
            this.buttonStartTransfer.Location = new System.Drawing.Point(134, 163);
            this.buttonStartTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartTransfer.Name = "buttonStartTransfer";
            this.buttonStartTransfer.Size = new System.Drawing.Size(110, 80);
            this.buttonStartTransfer.TabIndex = 3;
            this.buttonStartTransfer.Text = "Переказ";
            this.buttonStartTransfer.UseVisualStyleBackColor = true;
            this.buttonStartTransfer.Click += new System.EventHandler(this.buttonStartTransfer_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmount.Location = new System.Drawing.Point(16, 30);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(224, 29);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxRecipientCard
            // 
            this.textBoxRecipientCard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRecipientCard.Location = new System.Drawing.Point(16, 87);
            this.textBoxRecipientCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRecipientCard.Name = "textBoxRecipientCard";
            this.textBoxRecipientCard.Size = new System.Drawing.Size(224, 29);
            this.textBoxRecipientCard.TabIndex = 5;
            this.textBoxRecipientCard.TextChanged += new System.EventHandler(this.textBoxRecipientCard_TextChanged);
            // 
            // buttonConfirmTransfer
            // 
            this.buttonConfirmTransfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmTransfer.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmTransfer.Location = new System.Drawing.Point(263, 87);
            this.buttonConfirmTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfirmTransfer.Name = "buttonConfirmTransfer";
            this.buttonConfirmTransfer.Size = new System.Drawing.Size(108, 30);
            this.buttonConfirmTransfer.TabIndex = 8;
            this.buttonConfirmTransfer.Text = "Переказати";
            this.buttonConfirmTransfer.UseVisualStyleBackColor = true;
            this.buttonConfirmTransfer.Click += new System.EventHandler(this.buttonConfirmTransfer_Click);
            // 
            // labelRecipientCard
            // 
            this.labelRecipientCard.AutoSize = true;
            this.labelRecipientCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecipientCard.Location = new System.Drawing.Point(13, 62);
            this.labelRecipientCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecipientCard.Name = "labelRecipientCard";
            this.labelRecipientCard.Size = new System.Drawing.Size(184, 19);
            this.labelRecipientCard.TabIndex = 9;
            this.labelRecipientCard.Text = "Номер картки отримувача";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(13, 9);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(47, 19);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Сума:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Location = new System.Drawing.Point(263, 299);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(108, 30);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Вийти";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxCash
            // 
            this.textBoxCash.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCash.Location = new System.Drawing.Point(263, 31);
            this.textBoxCash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.ReadOnly = true;
            this.textBoxCash.Size = new System.Drawing.Size(108, 29);
            this.textBoxCash.TabIndex = 12;
            // 
            // buttonCancelTransfer
            // 
            this.buttonCancelTransfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelTransfer.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelTransfer.Location = new System.Drawing.Point(263, 123);
            this.buttonCancelTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelTransfer.Name = "buttonCancelTransfer";
            this.buttonCancelTransfer.Size = new System.Drawing.Size(108, 30);
            this.buttonCancelTransfer.TabIndex = 13;
            this.buttonCancelTransfer.Text = "Відмінити";
            this.buttonCancelTransfer.UseVisualStyleBackColor = true;
            this.buttonCancelTransfer.Click += new System.EventHandler(this.buttonCancelTransfer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.buttonCancelTransfer);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelRecipientCard);
            this.Controls.Add(this.buttonConfirmTransfer);
            this.Controls.Add(this.textBoxRecipientCard);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonStartTransfer);
            this.Controls.Add(this.buttonWithdrawCash);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.buttonDeposit);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Банкомат";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Button buttonWithdrawCash;
        private System.Windows.Forms.Button buttonStartTransfer;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxRecipientCard;
        private System.Windows.Forms.Button buttonConfirmTransfer;
        private System.Windows.Forms.Label labelRecipientCard;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Button buttonCancelTransfer;
    }
}