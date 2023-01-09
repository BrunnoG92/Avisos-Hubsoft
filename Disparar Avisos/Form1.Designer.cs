namespace Disparar_Avisos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn1_Enviar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CmB_Aviso = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtB_Codigo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Atendente = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Cmb_Tecnico = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CLIENTE = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_NomeCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Btn4_Config = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CmB_Aviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Atendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Tecnico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CLIENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn1_Enviar
            // 
            this.Btn1_Enviar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn1_Enviar.Location = new System.Drawing.Point(149, 488);
            this.Btn1_Enviar.Name = "Btn1_Enviar";
            this.Btn1_Enviar.Size = new System.Drawing.Size(114, 31);
            this.Btn1_Enviar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn1_Enviar.StateCommon.Border.Rounding = 10;
            this.Btn1_Enviar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn1_Enviar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn1_Enviar.StateDisabled.Back.Color1 = System.Drawing.Color.DarkGray;
            this.Btn1_Enviar.TabIndex = 7;
            this.Btn1_Enviar.Values.Text = "ENVIAR";
            this.Btn1_Enviar.Click += new System.EventHandler(this.Btn1_Enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Aviso:";
            // 
            // CmB_Aviso
            // 
            this.CmB_Aviso.DropDownWidth = 115;
            this.CmB_Aviso.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.CmB_Aviso.Items.AddRange(new object[] {
            "INSTALAÇÃO",
            "RENOVAÇÃO",
            "MUDANÇA DE ENDEREÇO",
            "MIGRAÇÃO DE VELOCIDADE"});
            this.CmB_Aviso.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.CmB_Aviso.Location = new System.Drawing.Point(190, 52);
            this.CmB_Aviso.Name = "CmB_Aviso";
            this.CmB_Aviso.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.CmB_Aviso.Size = new System.Drawing.Size(179, 27);
            this.CmB_Aviso.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateCommon.ComboBox.Border.ColorAngle = -10F;
            this.CmB_Aviso.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.CmB_Aviso.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmB_Aviso.StateCommon.ComboBox.Border.Rounding = 10;
            this.CmB_Aviso.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.CmB_Aviso.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_Aviso.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmB_Aviso.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmB_Aviso.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CmB_Aviso.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmB_Aviso.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmB_Aviso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "N° Hubsoft";
            // 
            // TxtB_Codigo
            // 
            this.TxtB_Codigo.Location = new System.Drawing.Point(190, 112);
            this.TxtB_Codigo.MaxLength = 30;
            this.TxtB_Codigo.Name = "TxtB_Codigo";
            this.TxtB_Codigo.Size = new System.Drawing.Size(70, 29);
            this.TxtB_Codigo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Codigo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Codigo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Codigo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Codigo.StateCommon.Border.Rounding = 10;
            this.TxtB_Codigo.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Codigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Técnico/Loja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Atendente";
            // 
            // Cmb_Atendente
            // 
            this.Cmb_Atendente.DropDownWidth = 115;
            this.Cmb_Atendente.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Cmb_Atendente.Items.AddRange(new object[] {
            "BRUNO ULHOA",
            "GESSIARA",
            "JANDEILSON",
            "JULIO",
            "RAMON",
            "SAMUEL",
            "VINICIUS"});
            this.Cmb_Atendente.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.Cmb_Atendente.Location = new System.Drawing.Point(190, 231);
            this.Cmb_Atendente.Name = "Cmb_Atendente";
            this.Cmb_Atendente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.Cmb_Atendente.Size = new System.Drawing.Size(179, 27);
            this.Cmb_Atendente.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateCommon.ComboBox.Border.ColorAngle = -10F;
            this.Cmb_Atendente.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.Cmb_Atendente.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Atendente.StateCommon.ComboBox.Border.Rounding = 10;
            this.Cmb_Atendente.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.Cmb_Atendente.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Atendente.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Atendente.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Atendente.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Atendente.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Atendente.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Atendente.TabIndex = 4;
            // 
            // Cmb_Tecnico
            // 
            this.Cmb_Tecnico.DropDownWidth = 115;
            this.Cmb_Tecnico.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Cmb_Tecnico.Items.AddRange(new object[] {
            "ALAN",
            "ANDRINEIA",
            "GESSICA MARQUES",
            "GIRCELIA",
            "GUILHERME",
            "JOANA D\'ARC",
            "JOSÉ AILTON",
            "JOSÉ FELIPE",
            "JUNIOR",
            "KAREM",
            "LEIDIVAN",
            "LIDIA",
            "MAGNA",
            "NATALIA",
            "PEDRO AUGUSTO",
            "PEDRO TEIXEIRA",
            "PETERSON",
            "RAFAEL",
            "TATIANY",
            "VICTOR GABRIEL",
            "VINICIUS"});
            this.Cmb_Tecnico.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.Cmb_Tecnico.Location = new System.Drawing.Point(190, 173);
            this.Cmb_Tecnico.Name = "Cmb_Tecnico";
            this.Cmb_Tecnico.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.Cmb_Tecnico.Size = new System.Drawing.Size(179, 27);
            this.Cmb_Tecnico.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.ColorAngle = -10F;
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Tecnico.StateCommon.ComboBox.Border.Rounding = 10;
            this.Cmb_Tecnico.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.Cmb_Tecnico.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Tecnico.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Tecnico.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Tecnico.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Cmb_Tecnico.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cmb_Tecnico.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmb_Tecnico.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_OK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Atendente);
            this.groupBox1.Controls.Add(this.Cmb_Tecnico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmB_Aviso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtB_Codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 325);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DE ENVIO";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(155, 276);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(87, 31);
            this.Btn_OK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_OK.StateCommon.Border.Rounding = 10;
            this.Btn_OK.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_OK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Values.Text = "OK";
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // CLIENTE
            // 
            this.CLIENTE.Controls.Add(this.label5);
            this.CLIENTE.Controls.Add(this.Txb_NomeCliente);
            this.CLIENTE.Cursor = System.Windows.Forms.Cursors.No;
            this.CLIENTE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CLIENTE.Location = new System.Drawing.Point(3, 356);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(401, 116);
            this.CLIENTE.TabIndex = 77;
            this.CLIENTE.TabStop = false;
            this.CLIENTE.Text = "CLIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 76;
            this.label5.Text = "Cliente";
            // 
            // Txb_NomeCliente
            // 
            this.Txb_NomeCliente.Enabled = false;
            this.Txb_NomeCliente.Location = new System.Drawing.Point(103, 46);
            this.Txb_NomeCliente.MaxLength = 30;
            this.Txb_NomeCliente.Name = "Txb_NomeCliente";
            this.Txb_NomeCliente.ReadOnly = true;
            this.Txb_NomeCliente.Size = new System.Drawing.Size(266, 29);
            this.Txb_NomeCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txb_NomeCliente.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txb_NomeCliente.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txb_NomeCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Txb_NomeCliente.StateCommon.Border.Rounding = 10;
            this.Txb_NomeCliente.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.Txb_NomeCliente.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.Txb_NomeCliente.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_NomeCliente.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_NomeCliente.TabIndex = 6;
            // 
            // Btn4_Config
            // 
            this.Btn4_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4_Config.FlatAppearance.BorderSize = 0;
            this.Btn4_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_Config.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn4_Config.ForeColor = System.Drawing.Color.White;
            this.Btn4_Config.Image = global::Disparar_Avisos.Properties.Resources.configuracao__2_;
            this.Btn4_Config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_Config.Location = new System.Drawing.Point(3, 478);
            this.Btn4_Config.Name = "Btn4_Config";
            this.Btn4_Config.Size = new System.Drawing.Size(43, 51);
            this.Btn4_Config.TabIndex = 78;
            this.Btn4_Config.UseVisualStyleBackColor = true;
            this.Btn4_Config.Click += new System.EventHandler(this.Btn4_Config_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(412, 531);
            this.Controls.Add(this.Btn4_Config);
            this.Controls.Add(this.CLIENTE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn1_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Disparador De Email";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CmB_Aviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Atendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Tecnico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CLIENTE.ResumeLayout(false);
            this.CLIENTE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn1_Enviar;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmB_Aviso;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Cmb_Atendente;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Cmb_Tecnico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CLIENTE;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Txb_NomeCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_OK;
        private System.Windows.Forms.Button Btn4_Config;
    }
}

