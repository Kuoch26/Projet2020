namespace Projet2020
{
    partial class Décomposition
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 111);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(862, 241);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(63, 769);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(811, 272);
            this.cartesianChart2.TabIndex = 2;
            this.cartesianChart2.Text = "cartesianChart3";
            this.cartesianChart2.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart4_ChildChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rentrer son propre signal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Décomposition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(940, 1006);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Recomposition";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(44, 451);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(846, 256);
            this.cartesianChart3.TabIndex = 6;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // Décomposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 1138);
            this.Controls.Add(this.cartesianChart3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Décomposition";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Décomposition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
    }
}

