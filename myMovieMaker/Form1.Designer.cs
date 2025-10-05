
namespace myMovieMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbx_file_list = new System.Windows.Forms.TextBox();
            this.btn_select_image_files = new System.Windows.Forms.Button();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateVideo = new System.Windows.Forms.Button();
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_rename_files = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rchtxtbx_renamed_file_name = new System.Windows.Forms.RichTextBox();
            this.rchtxtbx_original_name = new System.Windows.Forms.RichTextBox();
            this.txtNewNameFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWildcard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.tab_movie_maker = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_move_line_down = new System.Windows.Forms.Button();
            this.btn_delete_line = new System.Windows.Forms.Button();
            this.btn_move_line_up = new System.Windows.Forms.Button();
            this.lbl_renamed_files_folder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_folder_path = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tab_replace_empty_jpg = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_check_for_empty_jpg = new System.Windows.Forms.Button();
            this.rchtxbx_checked_files = new System.Windows.Forms.RichTextBox();
            this.rchtxbx_checking_file = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tab_rename_files.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tab_movie_maker.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_replace_empty_jpg.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_file_list
            // 
            this.txtbx_file_list.Location = new System.Drawing.Point(9, 3);
            this.txtbx_file_list.Multiline = true;
            this.txtbx_file_list.Name = "txtbx_file_list";
            this.txtbx_file_list.Size = new System.Drawing.Size(1065, 228);
            this.txtbx_file_list.TabIndex = 0;
            // 
            // btn_select_image_files
            // 
            this.btn_select_image_files.Location = new System.Drawing.Point(7, 237);
            this.btn_select_image_files.Name = "btn_select_image_files";
            this.btn_select_image_files.Size = new System.Drawing.Size(158, 48);
            this.btn_select_image_files.TabIndex = 1;
            this.btn_select_image_files.Text = "Select Files";
            this.btn_select_image_files.UseVisualStyleBackColor = true;
            this.btn_select_image_files.Click += new System.EventHandler(this.btn_select_image_files_Click);
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Location = new System.Drawing.Point(1184, 18);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(52, 26);
            this.txtFrameRate.TabIndex = 2;
            this.txtFrameRate.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1044, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frame Rate (fps):";
            // 
            // btnCreateVideo
            // 
            this.btnCreateVideo.Location = new System.Drawing.Point(1092, 310);
            this.btnCreateVideo.Name = "btnCreateVideo";
            this.btnCreateVideo.Size = new System.Drawing.Size(158, 53);
            this.btnCreateVideo.TabIndex = 4;
            this.btnCreateVideo.Text = "Create Video";
            this.btnCreateVideo.UseVisualStyleBackColor = true;
            this.btnCreateVideo.Click += new System.EventHandler(this.btn_create_video_Click);
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Location = new System.Drawing.Point(3, 3);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(1035, 360);
            this.rchtxbx_output.TabIndex = 5;
            this.rchtxbx_output.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_replace_empty_jpg);
            this.tabControl1.Controls.Add(this.tab_rename_files);
            this.tabControl1.Controls.Add(this.tab_movie_maker);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1268, 425);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_rename_files
            // 
            this.tab_rename_files.Controls.Add(this.panel3);
            this.tab_rename_files.Location = new System.Drawing.Point(4, 29);
            this.tab_rename_files.Name = "tab_rename_files";
            this.tab_rename_files.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rename_files.Size = new System.Drawing.Size(1260, 392);
            this.tab_rename_files.TabIndex = 0;
            this.tab_rename_files.Text = "Rename Files";
            this.tab_rename_files.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rchtxtbx_renamed_file_name);
            this.panel3.Controls.Add(this.rchtxtbx_original_name);
            this.panel3.Controls.Add(this.txtNewNameFormat);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtWildcard);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnRename);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 386);
            this.panel3.TabIndex = 0;
            // 
            // rchtxtbx_renamed_file_name
            // 
            this.rchtxtbx_renamed_file_name.Location = new System.Drawing.Point(683, 13);
            this.rchtxtbx_renamed_file_name.Name = "rchtxtbx_renamed_file_name";
            this.rchtxtbx_renamed_file_name.Size = new System.Drawing.Size(551, 306);
            this.rchtxtbx_renamed_file_name.TabIndex = 6;
            this.rchtxtbx_renamed_file_name.Text = "";
            // 
            // rchtxtbx_original_name
            // 
            this.rchtxtbx_original_name.Location = new System.Drawing.Point(29, 13);
            this.rchtxtbx_original_name.Name = "rchtxtbx_original_name";
            this.rchtxtbx_original_name.Size = new System.Drawing.Size(551, 306);
            this.rchtxtbx_original_name.TabIndex = 5;
            this.rchtxtbx_original_name.Text = "";
            // 
            // txtNewNameFormat
            // 
            this.txtNewNameFormat.Location = new System.Drawing.Point(547, 328);
            this.txtNewNameFormat.Name = "txtNewNameFormat";
            this.txtNewNameFormat.Size = new System.Drawing.Size(114, 26);
            this.txtNewNameFormat.TabIndex = 4;
            this.txtNewNameFormat.Text = "file_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Name Format:";
            // 
            // txtWildcard
            // 
            this.txtWildcard.Location = new System.Drawing.Point(193, 325);
            this.txtWildcard.Name = "txtWildcard";
            this.txtWildcard.Size = new System.Drawing.Size(114, 26);
            this.txtWildcard.TabIndex = 2;
            this.txtWildcard.Text = "*.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "File Type to Rename:";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(1094, 325);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(140, 51);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tab_movie_maker
            // 
            this.tab_movie_maker.Controls.Add(this.panel1);
            this.tab_movie_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_movie_maker.Name = "tab_movie_maker";
            this.tab_movie_maker.Padding = new System.Windows.Forms.Padding(3);
            this.tab_movie_maker.Size = new System.Drawing.Size(1260, 392);
            this.tab_movie_maker.TabIndex = 1;
            this.tab_movie_maker.Text = "Movie Maker";
            this.tab_movie_maker.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rchtxbx_output);
            this.panel1.Controls.Add(this.btnCreateVideo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFrameRate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 386);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.17808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.82192F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1274, 730);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_move_line_down);
            this.panel2.Controls.Add(this.btn_delete_line);
            this.panel2.Controls.Add(this.btn_move_line_up);
            this.panel2.Controls.Add(this.lbl_renamed_files_folder);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_folder_path);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_select_image_files);
            this.panel2.Controls.Add(this.txtbx_file_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 293);
            this.panel2.TabIndex = 7;
            // 
            // btn_move_line_down
            // 
            this.btn_move_line_down.Location = new System.Drawing.Point(1099, 111);
            this.btn_move_line_down.Name = "btn_move_line_down";
            this.btn_move_line_down.Size = new System.Drawing.Size(158, 48);
            this.btn_move_line_down.TabIndex = 9;
            this.btn_move_line_down.Text = "Move line Down";
            this.btn_move_line_down.UseVisualStyleBackColor = true;
            this.btn_move_line_down.Click += new System.EventHandler(this.btn_move_line_down_Click);
            // 
            // btn_delete_line
            // 
            this.btn_delete_line.Location = new System.Drawing.Point(1099, 57);
            this.btn_delete_line.Name = "btn_delete_line";
            this.btn_delete_line.Size = new System.Drawing.Size(158, 48);
            this.btn_delete_line.TabIndex = 8;
            this.btn_delete_line.Text = "Delete line";
            this.btn_delete_line.UseVisualStyleBackColor = true;
            this.btn_delete_line.Click += new System.EventHandler(this.btn_delete_line_Click);
            // 
            // btn_move_line_up
            // 
            this.btn_move_line_up.Location = new System.Drawing.Point(1099, 3);
            this.btn_move_line_up.Name = "btn_move_line_up";
            this.btn_move_line_up.Size = new System.Drawing.Size(158, 48);
            this.btn_move_line_up.TabIndex = 7;
            this.btn_move_line_up.Text = "Move Line Up";
            this.btn_move_line_up.UseVisualStyleBackColor = true;
            this.btn_move_line_up.Click += new System.EventHandler(this.btn_move_line_up_Click);
            // 
            // lbl_renamed_files_folder
            // 
            this.lbl_renamed_files_folder.AutoSize = true;
            this.lbl_renamed_files_folder.Location = new System.Drawing.Point(868, 251);
            this.lbl_renamed_files_folder.Name = "lbl_renamed_files_folder";
            this.lbl_renamed_files_folder.Size = new System.Drawing.Size(72, 20);
            this.lbl_renamed_files_folder.TabIndex = 6;
            this.lbl_renamed_files_folder.Text = "renamed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renamed File Folder Path:";
            // 
            // lbl_folder_path
            // 
            this.lbl_folder_path.AutoSize = true;
            this.lbl_folder_path.Location = new System.Drawing.Point(307, 251);
            this.lbl_folder_path.Name = "lbl_folder_path";
            this.lbl_folder_path.Size = new System.Drawing.Size(29, 20);
            this.lbl_folder_path.TabIndex = 4;
            this.lbl_folder_path.Text = ".....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder Path:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1099, 237);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(158, 48);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tab_replace_empty_jpg
            // 
            this.tab_replace_empty_jpg.Controls.Add(this.panel4);
            this.tab_replace_empty_jpg.Location = new System.Drawing.Point(4, 29);
            this.tab_replace_empty_jpg.Name = "tab_replace_empty_jpg";
            this.tab_replace_empty_jpg.Size = new System.Drawing.Size(1260, 392);
            this.tab_replace_empty_jpg.TabIndex = 2;
            this.tab_replace_empty_jpg.Text = "Replace Empty jpg";
            this.tab_replace_empty_jpg.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rchtxbx_checked_files);
            this.panel4.Controls.Add(this.rchtxbx_checking_file);
            this.panel4.Controls.Add(this.btn_check_for_empty_jpg);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 392);
            this.panel4.TabIndex = 0;
            // 
            // btn_check_for_empty_jpg
            // 
            this.btn_check_for_empty_jpg.Location = new System.Drawing.Point(544, 332);
            this.btn_check_for_empty_jpg.Name = "btn_check_for_empty_jpg";
            this.btn_check_for_empty_jpg.Size = new System.Drawing.Size(158, 48);
            this.btn_check_for_empty_jpg.TabIndex = 3;
            this.btn_check_for_empty_jpg.Text = "Check Files";
            this.btn_check_for_empty_jpg.UseVisualStyleBackColor = true;
            this.btn_check_for_empty_jpg.Click += new System.EventHandler(this.btn_check_for_empty_jpg_Click);
            // 
            // rchtxbx_checked_files
            // 
            this.rchtxbx_checked_files.Location = new System.Drawing.Point(676, 13);
            this.rchtxbx_checked_files.Name = "rchtxbx_checked_files";
            this.rchtxbx_checked_files.Size = new System.Drawing.Size(551, 306);
            this.rchtxbx_checked_files.TabIndex = 8;
            this.rchtxbx_checked_files.Text = "";
            // 
            // rchtxbx_checking_file
            // 
            this.rchtxbx_checking_file.Location = new System.Drawing.Point(22, 13);
            this.rchtxbx_checking_file.Name = "rchtxbx_checking_file";
            this.rchtxbx_checking_file.Size = new System.Drawing.Size(551, 306);
            this.rchtxbx_checking_file.TabIndex = 7;
            this.rchtxbx_checking_file.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myMovieMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_rename_files.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tab_movie_maker.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_replace_empty_jpg.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_select_image_files;
        private System.Windows.Forms.TextBox txtFrameRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateVideo;
        private System.Windows.Forms.RichTextBox rchtxbx_output;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_rename_files;
        private System.Windows.Forms.TabPage tab_movie_maker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_folder_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWildcard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewNameFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_renamed_files_folder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchtxtbx_renamed_file_name;
        private System.Windows.Forms.RichTextBox rchtxtbx_original_name;
        private System.Windows.Forms.Button btn_move_line_down;
        private System.Windows.Forms.Button btn_delete_line;
        private System.Windows.Forms.Button btn_move_line_up;
        private System.Windows.Forms.TextBox txtbx_file_list;
        private System.Windows.Forms.TabPage tab_replace_empty_jpg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_check_for_empty_jpg;
        private System.Windows.Forms.RichTextBox rchtxbx_checked_files;
        private System.Windows.Forms.RichTextBox rchtxbx_checking_file;
    }
}

