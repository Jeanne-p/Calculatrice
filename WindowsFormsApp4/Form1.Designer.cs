namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gbVariables = new System.Windows.Forms.GroupBox();
            this.bRCL = new System.Windows.Forms.Button();
            this.bSTO = new System.Windows.Forms.Button();
            this.bI = new System.Windows.Forms.Button();
            this.bH = new System.Windows.Forms.Button();
            this.bG = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.bExp = new System.Windows.Forms.Button();
            this.bMod = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bSous = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEgal = new System.Windows.Forms.Button();
            this.bSigne = new System.Windows.Forms.Button();
            this.gbGN = new System.Windows.Forms.GroupBox();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bLire = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lCalcul = new System.Windows.Forms.Label();
            this.gbCalculcours = new System.Windows.Forms.GroupBox();
            this.bEntrer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbEntrer = new System.Windows.Forms.GroupBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gbVariables.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.gbGN.SuspendLayout();
            this.gbCalculcours.SuspendLayout();
            this.gbEntrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVariables
            // 
            this.gbVariables.Controls.Add(this.bRCL);
            this.gbVariables.Controls.Add(this.bSTO);
            this.gbVariables.Controls.Add(this.bI);
            this.gbVariables.Controls.Add(this.bH);
            this.gbVariables.Controls.Add(this.bG);
            this.gbVariables.Controls.Add(this.bF);
            this.gbVariables.Controls.Add(this.bE);
            this.gbVariables.Controls.Add(this.bD);
            this.gbVariables.Controls.Add(this.bC);
            this.gbVariables.Controls.Add(this.bB);
            this.gbVariables.Controls.Add(this.bA);
            this.gbVariables.Location = new System.Drawing.Point(24, 103);
            this.gbVariables.Name = "gbVariables";
            this.gbVariables.Size = new System.Drawing.Size(169, 187);
            this.gbVariables.TabIndex = 1;
            this.gbVariables.TabStop = false;
            this.gbVariables.Text = "Variables";
            // 
            // bRCL
            // 
            this.bRCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRCL.Location = new System.Drawing.Point(87, 158);
            this.bRCL.Name = "bRCL";
            this.bRCL.Size = new System.Drawing.Size(75, 23);
            this.bRCL.TabIndex = 9;
            this.bRCL.Text = "RCL";
            this.bRCL.UseVisualStyleBackColor = true;
            this.bRCL.Click += new System.EventHandler(this.bRCL_Click);
            // 
            // bSTO
            // 
            this.bSTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSTO.Location = new System.Drawing.Point(6, 158);
            this.bSTO.Name = "bSTO";
            this.bSTO.Size = new System.Drawing.Size(75, 23);
            this.bSTO.TabIndex = 3;
            this.bSTO.Text = "STO";
            this.bSTO.UseVisualStyleBackColor = true;
            this.bSTO.Click += new System.EventHandler(this.bSTO_Click);
            // 
            // bI
            // 
            this.bI.Location = new System.Drawing.Point(114, 107);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(48, 38);
            this.bI.TabIndex = 8;
            this.bI.Tag = "8";
            this.bI.Text = "I";
            this.bI.UseVisualStyleBackColor = true;
            this.bI.Click += new System.EventHandler(this.bA_Click);
            // 
            // bH
            // 
            this.bH.Location = new System.Drawing.Point(60, 107);
            this.bH.Name = "bH";
            this.bH.Size = new System.Drawing.Size(48, 38);
            this.bH.TabIndex = 7;
            this.bH.Tag = "7";
            this.bH.Text = "H";
            this.bH.UseVisualStyleBackColor = true;
            this.bH.Click += new System.EventHandler(this.bA_Click);
            // 
            // bG
            // 
            this.bG.Location = new System.Drawing.Point(6, 107);
            this.bG.Name = "bG";
            this.bG.Size = new System.Drawing.Size(48, 38);
            this.bG.TabIndex = 6;
            this.bG.Tag = "6";
            this.bG.Text = "G";
            this.bG.UseVisualStyleBackColor = true;
            this.bG.Click += new System.EventHandler(this.bA_Click);
            // 
            // bF
            // 
            this.bF.Location = new System.Drawing.Point(114, 63);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(48, 38);
            this.bF.TabIndex = 5;
            this.bF.Tag = "5";
            this.bF.Text = "F";
            this.bF.UseVisualStyleBackColor = true;
            this.bF.Click += new System.EventHandler(this.bA_Click);
            // 
            // bE
            // 
            this.bE.Location = new System.Drawing.Point(60, 63);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(48, 38);
            this.bE.TabIndex = 4;
            this.bE.Tag = "4";
            this.bE.Text = "E";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bA_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(6, 63);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(48, 38);
            this.bD.TabIndex = 3;
            this.bD.Tag = "3";
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bA_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(114, 19);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(48, 38);
            this.bC.TabIndex = 2;
            this.bC.Tag = "2";
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bA_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(60, 19);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(48, 38);
            this.bB.TabIndex = 1;
            this.bB.Tag = "1";
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bA_Click);
            // 
            // bA
            // 
            this.bA.Location = new System.Drawing.Point(6, 19);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(48, 38);
            this.bA.TabIndex = 0;
            this.bA.Tag = "0";
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.bExp);
            this.gbOperations.Controls.Add(this.bMod);
            this.gbOperations.Controls.Add(this.bDiv);
            this.gbOperations.Controls.Add(this.bMulti);
            this.gbOperations.Controls.Add(this.bSous);
            this.gbOperations.Controls.Add(this.bAdd);
            this.gbOperations.Location = new System.Drawing.Point(351, 103);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(174, 145);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Opérations";
            // 
            // bExp
            // 
            this.bExp.Location = new System.Drawing.Point(114, 19);
            this.bExp.Name = "bExp";
            this.bExp.Size = new System.Drawing.Size(48, 38);
            this.bExp.TabIndex = 5;
            this.bExp.Tag = "5";
            this.bExp.Text = "x^y";
            this.bExp.UseVisualStyleBackColor = true;
            this.bExp.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bMod
            // 
            this.bMod.Location = new System.Drawing.Point(114, 63);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(48, 38);
            this.bMod.TabIndex = 4;
            this.bMod.Tag = "4";
            this.bMod.Text = "%";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(60, 63);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(48, 38);
            this.bDiv.TabIndex = 3;
            this.bDiv.Tag = "3";
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(6, 63);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(48, 38);
            this.bMulti.TabIndex = 4;
            this.bMulti.Tag = "2";
            this.bMulti.Text = "x";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSous
            // 
            this.bSous.Location = new System.Drawing.Point(60, 19);
            this.bSous.Name = "bSous";
            this.bSous.Size = new System.Drawing.Size(48, 38);
            this.bSous.TabIndex = 1;
            this.bSous.Tag = "1";
            this.bSous.Text = "-";
            this.bSous.UseVisualStyleBackColor = true;
            this.bSous.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(6, 19);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(48, 38);
            this.bAdd.TabIndex = 0;
            this.bAdd.Tag = "0";
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEgal
            // 
            this.bEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEgal.Location = new System.Drawing.Point(477, 261);
            this.bEgal.Name = "bEgal";
            this.bEgal.Size = new System.Drawing.Size(48, 38);
            this.bEgal.TabIndex = 8;
            this.bEgal.Tag = "6";
            this.bEgal.Text = "=";
            this.bEgal.UseVisualStyleBackColor = true;
            this.bEgal.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSigne
            // 
            this.bSigne.Location = new System.Drawing.Point(351, 261);
            this.bSigne.Name = "bSigne";
            this.bSigne.Size = new System.Drawing.Size(48, 38);
            this.bSigne.TabIndex = 7;
            this.bSigne.Tag = "7";
            this.bSigne.Text = "+/-";
            this.bSigne.UseVisualStyleBackColor = true;
            this.bSigne.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // gbGN
            // 
            this.gbGN.Controls.Add(this.bEnregistrer);
            this.gbGN.Controls.Add(this.bLire);
            this.gbGN.Location = new System.Drawing.Point(216, 103);
            this.gbGN.Name = "gbGN";
            this.gbGN.Size = new System.Drawing.Size(109, 101);
            this.gbGN.TabIndex = 2;
            this.gbGN.TabStop = false;
            this.gbGN.Text = "GN sur fichier";
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(6, 63);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(97, 23);
            this.bEnregistrer.TabIndex = 11;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bLire
            // 
            this.bLire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLire.Location = new System.Drawing.Point(6, 19);
            this.bLire.Name = "bLire";
            this.bLire.Size = new System.Drawing.Size(97, 23);
            this.bLire.TabIndex = 10;
            this.bLire.Text = "Lire";
            this.bLire.UseVisualStyleBackColor = true;
            this.bLire.Click += new System.EventHandler(this.bLire_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(5, 14);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(179, 45);
            this.tbNombre.TabIndex = 5;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lCalcul
            // 
            this.lCalcul.AutoSize = true;
            this.lCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCalcul.Location = new System.Drawing.Point(6, 27);
            this.lCalcul.Name = "lCalcul";
            this.lCalcul.Size = new System.Drawing.Size(0, 17);
            this.lCalcul.TabIndex = 6;
            // 
            // gbCalculcours
            // 
            this.gbCalculcours.Controls.Add(this.lCalcul);
            this.gbCalculcours.Location = new System.Drawing.Point(24, 21);
            this.gbCalculcours.Name = "gbCalculcours";
            this.gbCalculcours.Size = new System.Drawing.Size(317, 59);
            this.gbCalculcours.TabIndex = 7;
            this.gbCalculcours.TabStop = false;
            this.gbCalculcours.Text = "Calcul en cours";
            // 
            // bEntrer
            // 
            this.bEntrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntrer.Location = new System.Drawing.Point(109, 41);
            this.bEntrer.Name = "bEntrer";
            this.bEntrer.Size = new System.Drawing.Size(75, 23);
            this.bEntrer.TabIndex = 10;
            this.bEntrer.Text = "Entrer";
            this.bEntrer.UseVisualStyleBackColor = true;
            this.bEntrer.Click += new System.EventHandler(this.bEntrer_Click);
            // 
            // gbEntrer
            // 
            this.gbEntrer.Controls.Add(this.bEntrer);
            this.gbEntrer.Controls.Add(this.tbNombre);
            this.gbEntrer.Location = new System.Drawing.Point(351, 21);
            this.gbEntrer.Name = "gbEntrer";
            this.gbEntrer.Size = new System.Drawing.Size(190, 70);
            this.gbEntrer.TabIndex = 12;
            this.gbEntrer.TabStop = false;
            this.gbEntrer.Text = "Entrer un nombre";
            this.toolTip1.SetToolTip(this.gbEntrer, " \r\n");
            // 
            // toolTip2
            // 
            this.toolTip2.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 302);
            this.Controls.Add(this.gbEntrer);
            this.Controls.Add(this.bEgal);
            this.Controls.Add(this.gbCalculcours);
            this.Controls.Add(this.bSigne);
            this.Controls.Add(this.gbGN);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbVariables);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVariables.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbGN.ResumeLayout(false);
            this.gbCalculcours.ResumeLayout(false);
            this.gbCalculcours.PerformLayout();
            this.gbEntrer.ResumeLayout(false);
            this.gbEntrer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVariables;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.GroupBox gbGN;
        private System.Windows.Forms.Button bRCL;
        private System.Windows.Forms.Button bSTO;
        private System.Windows.Forms.Button bI;
        private System.Windows.Forms.Button bH;
        private System.Windows.Forms.Button bG;
        private System.Windows.Forms.Button bF;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button bEgal;
        private System.Windows.Forms.Button bExp;
        private System.Windows.Forms.Button bMod;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bSigne;
        private System.Windows.Forms.Button bSous;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bLire;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lCalcul;
        private System.Windows.Forms.GroupBox gbCalculcours;
        private System.Windows.Forms.Button bEntrer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbEntrer;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

