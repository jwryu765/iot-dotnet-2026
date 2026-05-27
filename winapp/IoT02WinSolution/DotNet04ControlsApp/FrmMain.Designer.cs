namespace DotNet04ControlsApp
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            BtnDialog = new Button();
            BtnMsgbox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgStatus = new ProgressBar();
            TrkStatus = new TrackBar();
            groupBox3 = new GroupBox();
            BtnAddRoot = new Button();
            BtnAddNode = new Button();
            LvwDummy = new ListView();
            TvwDummy = new TreeView();
            ImgDummy = new ImageList(components);
            groupBox4 = new GroupBox();
            BtnLoadImg = new Button();
            PicImage = new PictureBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            DlgOpenFile = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnDialog);
            groupBox1.Controls.Add(BtnMsgbox);
            groupBox1.Controls.Add(BtnModaless);
            groupBox1.Controls.Add(BtnModal);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "기본 컨트롤";
            // 
            // BtnDialog
            // 
            BtnDialog.Location = new Point(308, 81);
            BtnDialog.Name = "BtnDialog";
            BtnDialog.Size = new Size(62, 23);
            BtnDialog.TabIndex = 9;
            BtnDialog.Text = "...";
            BtnDialog.UseVisualStyleBackColor = true;
            BtnDialog.Click += BtnDialog_Click;
            // 
            // BtnMsgbox
            // 
            BtnMsgbox.Location = new Point(206, 81);
            BtnMsgbox.Name = "BtnMsgbox";
            BtnMsgbox.Size = new Size(96, 23);
            BtnMsgbox.TabIndex = 8;
            BtnMsgbox.Text = "메세지창";
            BtnMsgbox.UseVisualStyleBackColor = true;
            BtnMsgbox.Click += BtnMsgbox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(105, 81);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(95, 23);
            BtnModaless.TabIndex = 7;
            BtnModaless.Text = "모달리스";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(16, 81);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(83, 23);
            BtnModal.TabIndex = 6;
            BtnModal.Text = "모달";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(16, 52);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(354, 23);
            TxtResult.TabIndex = 5;
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Location = new Point(308, 25);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(62, 19);
            ChkItalic.TabIndex = 4;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Location = new Point(252, 25);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 3;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(53, 23);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(193, 23);
            CboFonts.TabIndex = 2;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgStatus);
            groupBox2.Controls.Add(TrkStatus);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 진행바";
            // 
            // PrgStatus
            // 
            PrgStatus.Location = new Point(16, 73);
            PrgStatus.Name = "PrgStatus";
            PrgStatus.Size = new Size(354, 33);
            PrgStatus.TabIndex = 11;
            PrgStatus.Value = 10;
            // 
            // TrkStatus
            // 
            TrkStatus.Location = new Point(16, 22);
            TrkStatus.Maximum = 100;
            TrkStatus.Name = "TrkStatus";
            TrkStatus.Size = new Size(354, 45);
            TrkStatus.TabIndex = 10;
            TrkStatus.TickFrequency = 5;
            TrkStatus.Scroll += TrkStatus_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnAddRoot);
            groupBox3.Controls.Add(BtnAddNode);
            groupBox3.Controls.Add(LvwDummy);
            groupBox3.Controls.Add(TvwDummy);
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 231);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "트리, 리스트뷰";
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(193, 190);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(79, 34);
            BtnAddRoot.TabIndex = 14;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // BtnAddNode
            // 
            BtnAddNode.Location = new Point(288, 190);
            BtnAddNode.Name = "BtnAddNode";
            BtnAddNode.Size = new Size(82, 34);
            BtnAddNode.TabIndex = 15;
            BtnAddNode.Text = "노드추가";
            BtnAddNode.UseVisualStyleBackColor = true;
            BtnAddNode.Click += BtnAddNode_Click;
            // 
            // LvwDummy
            // 
            LvwDummy.Location = new Point(193, 22);
            LvwDummy.Name = "LvwDummy";
            LvwDummy.Size = new Size(177, 162);
            LvwDummy.TabIndex = 13;
            LvwDummy.UseCompatibleStateImageBehavior = false;
            // 
            // TvwDummy
            // 
            TvwDummy.ImageIndex = 0;
            TvwDummy.ImageList = ImgDummy;
            TvwDummy.Location = new Point(16, 22);
            TvwDummy.Name = "TvwDummy";
            TvwDummy.SelectedImageIndex = 0;
            TvwDummy.Size = new Size(171, 162);
            TvwDummy.TabIndex = 12;
            // 
            // ImgDummy
            // 
            ImgDummy.ColorDepth = ColorDepth.Depth32Bit;
            ImgDummy.ImageStream = (ImageListStreamer)resources.GetObject("ImgDummy.ImageStream");
            ImgDummy.TransparentColor = Color.Transparent;
            ImgDummy.Images.SetKeyName(0, "folder.png");
            ImgDummy.Images.SetKeyName(1, "file.png");
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnLoadImg);
            groupBox4.Controls.Add(PicImage);
            groupBox4.Location = new Point(404, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(386, 337);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "픽쳐박스";
            // 
            // BtnLoadImg
            // 
            BtnLoadImg.Location = new Point(285, 299);
            BtnLoadImg.Name = "BtnLoadImg";
            BtnLoadImg.Size = new Size(95, 32);
            BtnLoadImg.TabIndex = 1;
            BtnLoadImg.Text = "이미지";
            BtnLoadImg.UseVisualStyleBackColor = true;
            BtnLoadImg.Click += BtnLoadImg_Click;
            // 
            // PicImage
            // 
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(374, 271);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            PicImage.Click += PicImage_Click;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(404, 355);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(386, 140);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "스레드";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Location = new Point(796, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(376, 483);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "텍스트에디터";
            // 
            // DlgOpenFile
            // 
            DlgOpenFile.FileName = "openFileDialog1";
            DlgOpenFile.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
            DlgOpenFile.InitialDirectory = "C:\\SourceBank";
            DlgOpenFile.Title = "텍스트 파일 열";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 500);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox TxtResult;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private Label label1;
        private Button BtnDialog;
        private Button BtnMsgbox;
        private Button BtnModaless;
        private Button BtnModal;
        private OpenFileDialog DlgOpenFile;
        private ProgressBar PrgStatus;
        private TrackBar TrkStatus;
        private ListView LvwDummy;
        private TreeView TvwDummy;
        private Button BtnAddRoot;
        private Button BtnAddNode;
        private SaveFileDialog saveFileDialog1;
        private ImageList ImgDummy;
        private Button BtnLoadImg;
        private PictureBox PicImage;
    }
}
