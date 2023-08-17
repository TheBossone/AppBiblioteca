namespace WindowsFormsApp3
{
    partial class Form3
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "El Principito _ Antoine de Saint-Exupéry",
            "\"La Fiesta del Chivo\" Mario Vargas Llosa",
            "\"La Sombra de la Noche\"  Junot Díaz",
            "\"En el Tiempo de las Mariposas\"  Julia de Burgos",
            "\"La Tragedia de Río Verde\" por Marcio Veloz Maggiolo",
            "\"Los Cuentos de la Era de Trujillo\" por Juan Bosch",
            "\"Ybon el Amargo\" por Andrés L. Mateo",
            "\"La Fiesta Ajena\" por Lilian Fondeur",
            "\"Cocorí\" por Joaquín Balaguer",
            "\"La Caída de Amado\" por Rose Mary Santana",
            "\"El Hombre del Vaso de Whisky\" por Freddy Prestol Castillo"});
            this.comboBox2.Location = new System.Drawing.Point(66, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(268, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Listado De Libros";
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 99);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}