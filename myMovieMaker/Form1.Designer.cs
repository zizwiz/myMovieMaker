
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbx_file_list = new System.Windows.Forms.TextBox();
            this.btn_select_image_files = new System.Windows.Forms.Button();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateVideo = new System.Windows.Forms.Button();
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_replace_empty_jpg = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rchtxtbx_checked_files = new System.Windows.Forms.RichTextBox();
            this.rchtxtbx_checking_file = new System.Windows.Forms.RichTextBox();
            this.btn_check_for_empty_jpg = new System.Windows.Forms.Button();
            this.tab_rename_files = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbx_rename_counter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rchtxtbx_renamed_file_name = new System.Windows.Forms.RichTextBox();
            this.rchtxtbx_original_name = new System.Windows.Forms.RichTextBox();
            this.txtNewNameFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWildcard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.tab_build_images = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_fill_graph = new System.Windows.Forms.Button();
            this.tab_movie_maker = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbx_autoname = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_make_movie = new System.Windows.Forms.Button();
            this.lbl_backup_folder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_backup_files = new System.Windows.Forms.Button();
            this.btn_move_line_down = new System.Windows.Forms.Button();
            this.btn_delete_line = new System.Windows.Forms.Button();
            this.btn_move_line_up = new System.Windows.Forms.Button();
            this.lbl_renamed_files_folder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_folder_path = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.chrt_temperatures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_winds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_pressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tab_replace_empty_jpg.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_rename_files.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tab_build_images.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tab_movie_maker.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_temperatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_winds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_pressure)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_file_list
            // 
            this.txtbx_file_list.Location = new System.Drawing.Point(26, 3);
            this.txtbx_file_list.Multiline = true;
            this.txtbx_file_list.Name = "txtbx_file_list";
            this.txtbx_file_list.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbx_file_list.Size = new System.Drawing.Size(1048, 156);
            this.txtbx_file_list.TabIndex = 0;
            // 
            // btn_select_image_files
            // 
            this.btn_select_image_files.Location = new System.Drawing.Point(26, 182);
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
            this.txtFrameRate.Text = "10";
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
            this.rchtxbx_output.Location = new System.Drawing.Point(3, 31);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(1035, 332);
            this.rchtxbx_output.TabIndex = 5;
            this.rchtxbx_output.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_replace_empty_jpg);
            this.tabControl1.Controls.Add(this.tab_rename_files);
            this.tabControl1.Controls.Add(this.tab_build_images);
            this.tabControl1.Controls.Add(this.tab_movie_maker);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1268, 426);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_replace_empty_jpg
            // 
            this.tab_replace_empty_jpg.Controls.Add(this.panel4);
            this.tab_replace_empty_jpg.Location = new System.Drawing.Point(4, 29);
            this.tab_replace_empty_jpg.Name = "tab_replace_empty_jpg";
            this.tab_replace_empty_jpg.Size = new System.Drawing.Size(1260, 393);
            this.tab_replace_empty_jpg.TabIndex = 2;
            this.tab_replace_empty_jpg.Text = "Replace Empty jpg";
            this.tab_replace_empty_jpg.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.rchtxtbx_checked_files);
            this.panel4.Controls.Add(this.rchtxtbx_checking_file);
            this.panel4.Controls.Add(this.btn_check_for_empty_jpg);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 393);
            this.panel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(672, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Processed Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Files Processed";
            // 
            // rchtxtbx_checked_files
            // 
            this.rchtxtbx_checked_files.Location = new System.Drawing.Point(676, 36);
            this.rchtxtbx_checked_files.Name = "rchtxtbx_checked_files";
            this.rchtxtbx_checked_files.Size = new System.Drawing.Size(551, 283);
            this.rchtxtbx_checked_files.TabIndex = 8;
            this.rchtxtbx_checked_files.Text = "";
            // 
            // rchtxtbx_checking_file
            // 
            this.rchtxtbx_checking_file.Location = new System.Drawing.Point(22, 36);
            this.rchtxtbx_checking_file.Name = "rchtxtbx_checking_file";
            this.rchtxtbx_checking_file.Size = new System.Drawing.Size(551, 283);
            this.rchtxtbx_checking_file.TabIndex = 7;
            this.rchtxtbx_checking_file.Text = "";
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
            // tab_rename_files
            // 
            this.tab_rename_files.Controls.Add(this.panel3);
            this.tab_rename_files.Location = new System.Drawing.Point(4, 29);
            this.tab_rename_files.Name = "tab_rename_files";
            this.tab_rename_files.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rename_files.Size = new System.Drawing.Size(1260, 393);
            this.tab_rename_files.TabIndex = 0;
            this.tab_rename_files.Text = "Rename Files";
            this.tab_rename_files.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtbx_rename_counter);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
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
            this.panel3.Size = new System.Drawing.Size(1254, 387);
            this.panel3.TabIndex = 0;
            // 
            // txtbx_rename_counter
            // 
            this.txtbx_rename_counter.Location = new System.Drawing.Point(884, 348);
            this.txtbx_rename_counter.Name = "txtbx_rename_counter";
            this.txtbx_rename_counter.Size = new System.Drawing.Size(114, 26);
            this.txtbx_rename_counter.TabIndex = 10;
            this.txtbx_rename_counter.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(719, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Counter Start Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Renamed Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Original Name";
            // 
            // rchtxtbx_renamed_file_name
            // 
            this.rchtxtbx_renamed_file_name.Location = new System.Drawing.Point(683, 44);
            this.rchtxtbx_renamed_file_name.Name = "rchtxtbx_renamed_file_name";
            this.rchtxtbx_renamed_file_name.Size = new System.Drawing.Size(551, 292);
            this.rchtxtbx_renamed_file_name.TabIndex = 6;
            this.rchtxtbx_renamed_file_name.Text = "";
            // 
            // rchtxtbx_original_name
            // 
            this.rchtxtbx_original_name.Location = new System.Drawing.Point(29, 44);
            this.rchtxtbx_original_name.Name = "rchtxtbx_original_name";
            this.rchtxtbx_original_name.Size = new System.Drawing.Size(551, 292);
            this.rchtxtbx_original_name.TabIndex = 5;
            this.rchtxtbx_original_name.Text = "";
            // 
            // txtNewNameFormat
            // 
            this.txtNewNameFormat.Location = new System.Drawing.Point(547, 345);
            this.txtNewNameFormat.Name = "txtNewNameFormat";
            this.txtNewNameFormat.Size = new System.Drawing.Size(114, 26);
            this.txtNewNameFormat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Name Format:";
            // 
            // txtWildcard
            // 
            this.txtWildcard.Location = new System.Drawing.Point(193, 342);
            this.txtWildcard.Name = "txtWildcard";
            this.txtWildcard.Size = new System.Drawing.Size(114, 26);
            this.txtWildcard.TabIndex = 2;
            this.txtWildcard.Text = "*.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "File Type to Rename:";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(1094, 342);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(140, 34);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tab_build_images
            // 
            this.tab_build_images.Controls.Add(this.panel5);
            this.tab_build_images.Location = new System.Drawing.Point(4, 29);
            this.tab_build_images.Name = "tab_build_images";
            this.tab_build_images.Size = new System.Drawing.Size(1260, 393);
            this.tab_build_images.TabIndex = 3;
            this.tab_build_images.Text = "Build Images";
            this.tab_build_images.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chrt_pressure);
            this.panel5.Controls.Add(this.chrt_winds);
            this.panel5.Controls.Add(this.chrt_temperatures);
            this.panel5.Controls.Add(this.btn_fill_graph);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1260, 393);
            this.panel5.TabIndex = 0;
            // 
            // btn_fill_graph
            // 
            this.btn_fill_graph.Location = new System.Drawing.Point(1141, 352);
            this.btn_fill_graph.Name = "btn_fill_graph";
            this.btn_fill_graph.Size = new System.Drawing.Size(92, 37);
            this.btn_fill_graph.TabIndex = 0;
            this.btn_fill_graph.Text = "Fill";
            this.btn_fill_graph.UseVisualStyleBackColor = true;
            this.btn_fill_graph.Click += new System.EventHandler(this.btn_fill_graph_Click);
            // 
            // tab_movie_maker
            // 
            this.tab_movie_maker.Controls.Add(this.panel1);
            this.tab_movie_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_movie_maker.Name = "tab_movie_maker";
            this.tab_movie_maker.Padding = new System.Windows.Forms.Padding(3);
            this.tab_movie_maker.Size = new System.Drawing.Size(1260, 393);
            this.tab_movie_maker.TabIndex = 1;
            this.tab_movie_maker.Text = "Movie Maker";
            this.tab_movie_maker.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbx_autoname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.rchtxbx_output);
            this.panel1.Controls.Add(this.btnCreateVideo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFrameRate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 387);
            this.panel1.TabIndex = 0;
            // 
            // chkbx_autoname
            // 
            this.chkbx_autoname.AutoSize = true;
            this.chkbx_autoname.Checked = true;
            this.chkbx_autoname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_autoname.Location = new System.Drawing.Point(1068, 70);
            this.chkbx_autoname.Name = "chkbx_autoname";
            this.chkbx_autoname.Size = new System.Drawing.Size(111, 24);
            this.chkbx_autoname.TabIndex = 7;
            this.chkbx_autoname.Text = "AutoName";
            this.chkbx_autoname.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Processed Files";
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
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_make_movie);
            this.panel2.Controls.Add(this.lbl_backup_folder);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_backup_files);
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
            this.panel2.Location = new System.Drawing.Point(3, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 292);
            this.panel2.TabIndex = 7;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(935, 236);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(158, 48);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_make_movie
            // 
            this.btn_make_movie.Location = new System.Drawing.Point(26, 236);
            this.btn_make_movie.Name = "btn_make_movie";
            this.btn_make_movie.Size = new System.Drawing.Size(158, 48);
            this.btn_make_movie.TabIndex = 13;
            this.btn_make_movie.Text = "Make Movie";
            this.btn_make_movie.UseVisualStyleBackColor = true;
            this.btn_make_movie.Click += new System.EventHandler(this.btn_make_movie_Click);
            // 
            // lbl_backup_folder
            // 
            this.lbl_backup_folder.AutoSize = true;
            this.lbl_backup_folder.Location = new System.Drawing.Point(334, 254);
            this.lbl_backup_folder.Name = "lbl_backup_folder";
            this.lbl_backup_folder.Size = new System.Drawing.Size(29, 20);
            this.lbl_backup_folder.TabIndex = 12;
            this.lbl_backup_folder.Text = ".....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Backup Folder:";
            // 
            // btn_backup_files
            // 
            this.btn_backup_files.Location = new System.Drawing.Point(1099, 168);
            this.btn_backup_files.Name = "btn_backup_files";
            this.btn_backup_files.Size = new System.Drawing.Size(158, 48);
            this.btn_backup_files.TabIndex = 10;
            this.btn_backup_files.Text = "Backup Files";
            this.btn_backup_files.UseVisualStyleBackColor = true;
            this.btn_backup_files.Click += new System.EventHandler(this.btn_backup_files_Click);
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
            this.lbl_renamed_files_folder.Location = new System.Drawing.Point(416, 226);
            this.lbl_renamed_files_folder.Name = "lbl_renamed_files_folder";
            this.lbl_renamed_files_folder.Size = new System.Drawing.Size(29, 20);
            this.lbl_renamed_files_folder.TabIndex = 6;
            this.lbl_renamed_files_folder.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renamed File Folder Path:";
            // 
            // lbl_folder_path
            // 
            this.lbl_folder_path.AutoSize = true;
            this.lbl_folder_path.Location = new System.Drawing.Point(313, 196);
            this.lbl_folder_path.Name = "lbl_folder_path";
            this.lbl_folder_path.Size = new System.Drawing.Size(29, 20);
            this.lbl_folder_path.TabIndex = 4;
            this.lbl_folder_path.Text = ".....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder Path:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1099, 236);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(158, 48);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // chrt_temperatures
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt_temperatures.ChartAreas.Add(chartArea3);
            this.chrt_temperatures.Location = new System.Drawing.Point(7, 27);
            this.chrt_temperatures.Name = "chrt_temperatures";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            this.chrt_temperatures.Series.Add(series3);
            this.chrt_temperatures.Size = new System.Drawing.Size(384, 282);
            this.chrt_temperatures.TabIndex = 1;
            this.chrt_temperatures.Text = "chart1";
            // 
            // chrt_winds
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_winds.ChartAreas.Add(chartArea2);
            this.chrt_winds.Location = new System.Drawing.Point(397, 27);
            this.chrt_winds.Name = "chrt_winds";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series1";
            this.chrt_winds.Series.Add(series2);
            this.chrt_winds.Size = new System.Drawing.Size(393, 282);
            this.chrt_winds.TabIndex = 2;
            this.chrt_winds.Text = "chart1";
            // 
            // chrt_pressure
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_pressure.ChartAreas.Add(chartArea1);
            this.chrt_pressure.Location = new System.Drawing.Point(796, 27);
            this.chrt_pressure.Name = "chrt_pressure";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.chrt_pressure.Series.Add(series1);
            this.chrt_pressure.Size = new System.Drawing.Size(391, 282);
            this.chrt_pressure.TabIndex = 3;
            this.chrt_pressure.Text = "chart1";
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
            this.tab_replace_empty_jpg.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_rename_files.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tab_build_images.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tab_movie_maker.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_temperatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_winds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_pressure)).EndInit();
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
        private System.Windows.Forms.RichTextBox rchtxtbx_checked_files;
        private System.Windows.Forms.RichTextBox rchtxtbx_checking_file;
        private System.Windows.Forms.Button btn_backup_files;
        private System.Windows.Forms.Label lbl_backup_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_rename_counter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_make_movie;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox chkbx_autoname;
        private System.Windows.Forms.TabPage tab_build_images;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_fill_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_temperatures;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_winds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_pressure;
    }
}

