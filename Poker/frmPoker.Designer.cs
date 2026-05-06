namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpPouring = new System.Windows.Forms.GroupBox();
            this.lblTotalFunds = new System.Windows.Forms.Label();
            this.txbTotalFunds = new System.Windows.Forms.TextBox();
            this.lblPouring = new System.Windows.Forms.Label();
            this.txbPouring = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.grpButton.SuspendLayout();
            this.grpPouring.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(728, 238);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            this.grpPoker.Paint += new System.Windows.Forms.PaintEventHandler(this.grpPoker_Paint);
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.grpButton.Location = new System.Drawing.Point(12, 341);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(728, 97);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // btnDealCard
            // 
            this.btnDealCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnDealCard.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDealCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnDealCard.Location = new System.Drawing.Point(17, 38);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(70, 43);
            this.btnDealCard.TabIndex = 3;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = false;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnChangeCard.Location = new System.Drawing.Point(93, 38);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(70, 43);
            this.btnChangeCard.TabIndex = 4;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = false;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnCheck.Location = new System.Drawing.Point(169, 38);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 43);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(286, 44);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 31);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPouring
            // 
            this.grpPouring.Controls.Add(this.btnBet);
            this.grpPouring.Controls.Add(this.txbPouring);
            this.grpPouring.Controls.Add(this.lblPouring);
            this.grpPouring.Controls.Add(this.txbTotalFunds);
            this.grpPouring.Controls.Add(this.lblTotalFunds);
            this.grpPouring.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPouring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.grpPouring.Location = new System.Drawing.Point(12, 246);
            this.grpPouring.Name = "grpPouring";
            this.grpPouring.Size = new System.Drawing.Size(728, 97);
            this.grpPouring.TabIndex = 0;
            this.grpPouring.TabStop = false;
            this.grpPouring.Text = "下注";
            // 
            // lblTotalFunds
            // 
            this.lblTotalFunds.AutoSize = true;
            this.lblTotalFunds.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalFunds.Location = new System.Drawing.Point(22, 43);
            this.lblTotalFunds.Name = "lblTotalFunds";
            this.lblTotalFunds.Size = new System.Drawing.Size(72, 25);
            this.lblTotalFunds.TabIndex = 2;
            this.lblTotalFunds.Text = "總資金";
            this.lblTotalFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTotalFunds
            // 
            this.txbTotalFunds.Font = new System.Drawing.Font("微軟正黑體 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbTotalFunds.Location = new System.Drawing.Point(100, 38);
            this.txbTotalFunds.Name = "txbTotalFunds";
            this.txbTotalFunds.ReadOnly = true;
            this.txbTotalFunds.Size = new System.Drawing.Size(156, 34);
            this.txbTotalFunds.TabIndex = 10;
            this.txbTotalFunds.Text = "1000000";
            this.txbTotalFunds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPouring
            // 
            this.lblPouring.AutoSize = true;
            this.lblPouring.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPouring.Location = new System.Drawing.Point(287, 43);
            this.lblPouring.Name = "lblPouring";
            this.lblPouring.Size = new System.Drawing.Size(92, 25);
            this.lblPouring.TabIndex = 4;
            this.lblPouring.Text = "押注金額";
            this.lblPouring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPouring
            // 
            this.txbPouring.Font = new System.Drawing.Font("微軟正黑體 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbPouring.Location = new System.Drawing.Point(385, 38);
            this.txbPouring.Name = "txbPouring";
            this.txbPouring.Size = new System.Drawing.Size(76, 34);
            this.txbPouring.TabIndex = 1;
            this.txbPouring.Text = "500";
            this.txbPouring.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnBet.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnBet.Location = new System.Drawing.Point(480, 33);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(70, 43);
            this.btnBet.TabIndex = 2;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            this.btnBet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBet_KeyDown);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.grpPouring);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.Name = "frmPoker";
            this.Text = "frmPoker";
            this.grpButton.ResumeLayout(false);
            this.grpButton.PerformLayout();
            this.grpPouring.ResumeLayout(false);
            this.grpPouring.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpPouring;
        private System.Windows.Forms.Label lblTotalFunds;
        private System.Windows.Forms.TextBox txbTotalFunds;
        private System.Windows.Forms.Label lblPouring;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txbPouring;
    }
}