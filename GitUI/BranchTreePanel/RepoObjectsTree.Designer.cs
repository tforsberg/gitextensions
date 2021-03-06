﻿using System.ComponentModel;
using System.Windows.Forms;
using GitUI.UserControls;

namespace GitUI.BranchTreePanel
{
    partial class RepoObjectsTree
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeMain = new GitUI.UserControls.NativeTreeView();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBranch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBtnCheckoutLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnBranchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnBranchDeleteForce = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFilterLocalBranchInRevisionGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFilterRemoteBranchInRevisionGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnBranchCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBtnManageRemotesFromRootNode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnRemoteBranchFetchAndCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnPullFromRemoteBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFetchRebase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFetchCreateBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFetchOneBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnubtnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnRebase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnMergeBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnCreateBranchBasedOnRemoteBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnubtnDeleteRemoteBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnFetchAllBranchesFromARemote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnCreateBranchForTag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBtnCheckoutTag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnDeleteTag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBranchPath = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnDeleteAllBranches = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnDeleteAllBranchesForce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoteRepoNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnManageRemotes = new System.Windows.Forms.ToolStripMenuItem();
            this.repoTreePanel = new System.Windows.Forms.TableLayoutPanel();
            this.branchSearchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchBranch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.menuSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.menuBranch.SuspendLayout();
            this.menuRemotes.SuspendLayout();
            this.menuRemote.SuspendLayout();
            this.menuTag.SuspendLayout();
            this.menuBranchPath.SuspendLayout();
            this.menuRemoteRepoNode.SuspendLayout();
            this.repoTreePanel.SuspendLayout();
            this.branchSearchPanel.SuspendLayout();
            this.menuSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMain
            // 
            this.treeMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeMain.ContextMenuStrip = this.menuMain;
            this.treeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMain.FullRowSelect = true;
            this.treeMain.Location = new System.Drawing.Point(3, 41);
            this.treeMain.Name = "treeMain";
            this.treeMain.ShowNodeToolTips = true;
            this.treeMain.Size = new System.Drawing.Size(294, 350);
            this.treeMain.TabIndex = 3;
            this.treeMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnNodeSelected);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnCollapseAll,
            this.mnubtnExpandAll,
            this.mnubtnReload});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(137, 70);
            // 
            // mnubtnCollapseAll
            // 
            this.mnubtnCollapseAll.Image = global::GitUI.Properties.MsVsImages.CollapseAll_16x;
            this.mnubtnCollapseAll.Name = "mnubtnCollapseAll";
            this.mnubtnCollapseAll.Size = new System.Drawing.Size(136, 22);
            this.mnubtnCollapseAll.Text = "Collapse All";
            this.mnubtnCollapseAll.ToolTipText = "Collapse all nodes";
            // 
            // mnubtnExpandAll
            // 
            this.mnubtnExpandAll.Image = global::GitUI.Properties.MsVsImages.ExpandAll_16x;
            this.mnubtnExpandAll.Name = "mnubtnExpandAll";
            this.mnubtnExpandAll.Size = new System.Drawing.Size(136, 22);
            this.mnubtnExpandAll.Text = "Expand All";
            this.mnubtnExpandAll.ToolTipText = "Expand all nodes";
            // 
            // mnubtnReload
            // 
            this.mnubtnReload.Image = global::GitUI.Properties.Resources.arrow_refresh;
            this.mnubtnReload.Name = "mnubtnReload";
            this.mnubtnReload.Size = new System.Drawing.Size(136, 22);
            this.mnubtnReload.Text = "Reload";
            this.mnubtnReload.ToolTipText = "Reload the tree";
            // 
            // menuBranch
            // 
            this.menuBranch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBtnCheckoutLocal,
            this.mnubtnBranchDelete,
            this.mnubtnBranchDeleteForce,
            this.mnubtnFilterLocalBranchInRevisionGrid});
            this.menuBranch.Name = "contextmenuBranch";
            this.menuBranch.Size = new System.Drawing.Size(192, 92);
            // 
            // mnuBtnCheckoutLocal
            // 
            this.mnuBtnCheckoutLocal.Image = global::GitUI.Properties.Resources.IconBranchCheckout;
            this.mnuBtnCheckoutLocal.Name = "mnuBtnCheckoutLocal";
            this.mnuBtnCheckoutLocal.Size = new System.Drawing.Size(191, 22);
            this.mnuBtnCheckoutLocal.Text = "Checkout";
            this.mnuBtnCheckoutLocal.ToolTipText = "Checkout this branch";
            // 
            // mnubtnBranchDelete
            // 
            this.mnubtnBranchDelete.Image = global::GitUI.Properties.Resources.IconBranchDelete;
            this.mnubtnBranchDelete.Name = "mnubtnBranchDelete";
            this.mnubtnBranchDelete.Size = new System.Drawing.Size(191, 22);
            this.mnubtnBranchDelete.Text = "Delete";
            this.mnubtnBranchDelete.ToolTipText = "Delete the branch, which must be fully merged in its upstream branch or in HEAD";
            // 
            // mnubtnBranchDeleteForce
            // 
            this.mnubtnBranchDeleteForce.Image = global::GitUI.Properties.Resources.Delete;
            this.mnubtnBranchDeleteForce.Name = "mnubtnBranchDeleteForce";
            this.mnubtnBranchDeleteForce.Size = new System.Drawing.Size(191, 22);
            this.mnubtnBranchDeleteForce.Text = "Force Delete";
            this.mnubtnBranchDeleteForce.ToolTipText = "Delete the branch, regardless of its merged status";
            // 
            // mnubtnFilterLocalBranchInRevisionGrid
            // 
            this.mnubtnFilterLocalBranchInRevisionGrid.Image = global::GitUI.Properties.Resources.IconFilter;
            this.mnubtnFilterLocalBranchInRevisionGrid.Name = "mnubtnFilterLocalBranchInRevisionGrid";
            this.mnubtnFilterLocalBranchInRevisionGrid.Size = new System.Drawing.Size(191, 22);
            this.mnubtnFilterLocalBranchInRevisionGrid.Text = "Show this branch only";
            // 
            // mnubtnFilterRemoteBranchInRevisionGrid
            // 
            this.mnubtnFilterRemoteBranchInRevisionGrid.Image = global::GitUI.Properties.Resources.IconFilter;
            this.mnubtnFilterRemoteBranchInRevisionGrid.Name = "mnubtnFilterRemoteBranchInRevisionGrid";
            this.mnubtnFilterRemoteBranchInRevisionGrid.Size = new System.Drawing.Size(191, 22);
            this.mnubtnFilterRemoteBranchInRevisionGrid.Text = "Show this branch only";
            // 
            // mnubtnBranchCheckout
            // 
            this.mnubtnBranchCheckout.Image = global::GitUI.Properties.Resources.IconBranchCheckout;
            this.mnubtnBranchCheckout.Name = "mnubtnBranchCheckout";
            this.mnubtnBranchCheckout.Size = new System.Drawing.Size(191, 22);
            this.mnubtnBranchCheckout.Text = "&Checkout";
            this.mnubtnBranchCheckout.ToolTipText = "Checkout this branch";
            // 
            // menuTags
            // 
            this.menuTags.Name = "contextmenuTags";
            this.menuTags.Size = new System.Drawing.Size(61, 4);
            // 
            // menuRemotes
            // 
            this.menuRemotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBtnManageRemotesFromRootNode});
            this.menuRemotes.Name = "contextmenuRemotes";
            this.menuRemotes.Size = new System.Drawing.Size(164, 26);
            // 
            // mnuBtnManageRemotesFromRootNode
            // 
            this.mnuBtnManageRemotesFromRootNode.Image = global::GitUI.Properties.MsVsImages.Repository_16x;
            this.mnuBtnManageRemotesFromRootNode.Name = "mnuBtnManageRemotesFromRootNode";
            this.mnuBtnManageRemotesFromRootNode.Size = new System.Drawing.Size(163, 22);
            this.mnuBtnManageRemotesFromRootNode.Text = "&Manage remotes";
            // 
            // menuRemote
            // 
            this.menuRemote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnRemoteBranchFetchAndCheckout,
            this.mnubtnPullFromRemoteBranch,
            this.mnubtnFetchRebase,
            this.mnubtnFetchCreateBranch,
            this.mnubtnFetchOneBranch,
            this.toolStripSeparator1,
            this.mnubtnBranchCheckout,
            this.mnubtnMergeBranch,
            this.mnubtnRebase,
            this.mnubtnCreateBranchBasedOnRemoteBranch,
            this.mnubtnReset,
            this.toolStripSeparator2,
            this.mnubtnDeleteRemoteBranch,
            this.mnubtnFilterRemoteBranchInRevisionGrid});
            this.menuRemote.Name = "contextmenuRemote";
            this.menuRemote.Size = new System.Drawing.Size(192, 280);
            // 
            // mnubtnRemoteBranchFetchAndCheckout
            // 
            this.mnubtnRemoteBranchFetchAndCheckout.Image = global::GitUI.Properties.Resources.IconBranchCheckout;
            this.mnubtnRemoteBranchFetchAndCheckout.Name = "mnubtnRemoteBranchFetchAndCheckout";
            this.mnubtnRemoteBranchFetchAndCheckout.Size = new System.Drawing.Size(191, 22);
            this.mnubtnRemoteBranchFetchAndCheckout.Text = "&Fetch && Checkout";
            this.mnubtnRemoteBranchFetchAndCheckout.ToolTipText = "Checkout this branch";
            // 
            // mnubtnPullFromRemoteBranch
            // 
            this.mnubtnPullFromRemoteBranch.Image = global::GitUI.Properties.Resources.IconPull;
            this.mnubtnPullFromRemoteBranch.Name = "mnubtnPullFromRemoteBranch";
            this.mnubtnPullFromRemoteBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnPullFromRemoteBranch.Text = "Fetch && Merge (&Pull)";
            // 
            // mnubtnFetchRebase
            // 
            this.mnubtnFetchRebase.Image = global::GitUI.Properties.Resources.IconRebase;
            this.mnubtnFetchRebase.Name = "mnubtnFetchRebase";
            this.mnubtnFetchRebase.Size = new System.Drawing.Size(191, 22);
            this.mnubtnFetchRebase.Text = "Fetch && Re&base";
            this.mnubtnFetchRebase.ToolTipText = "Fetch & Rebase current branch to this branch";
            // 
            // mnubtnFetchCreateBranch
            // 
            this.mnubtnFetchCreateBranch.Image = global::GitUI.Properties.MsVsImages.Branch_16x;
            this.mnubtnFetchCreateBranch.Name = "mnubtnFetchCreateBranch";
            this.mnubtnFetchCreateBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnFetchCreateBranch.Text = "Fetc&h && Create Branch";
            this.mnubtnFetchCreateBranch.ToolTipText = "Fetch then create a local branch from the remote branch";
            // 
            // mnubtnFetchOneBranch
            // 
            this.mnubtnFetchOneBranch.Image = global::GitUI.Properties.Resources.IconStage;
            this.mnubtnFetchOneBranch.Name = "mnubtnFetchOneBranch";
            this.mnubtnFetchOneBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnFetchOneBranch.Text = "Fe&tch";
            this.mnubtnFetchOneBranch.ToolTipText = "Fetch the new remote branch";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnubtnMergeBranch
            // 
            this.mnubtnMergeBranch.Image = global::GitUI.Properties.Resources.IconMerge;
            this.mnubtnMergeBranch.Name = "mnubtnMergeBranch";
            this.mnubtnMergeBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnMergeBranch.Text = "&Merge";
            this.mnubtnMergeBranch.ToolTipText = "Merge remote branch into current branch";
            // 
            // mnubtnRebase
            // 
            this.mnubtnRebase.Image = global::GitUI.Properties.Resources.IconRebase;
            this.mnubtnRebase.Name = "mnubtnRebase";
            this.mnubtnRebase.Size = new System.Drawing.Size(191, 22);
            this.mnubtnRebase.Text = "&Rebase";
            this.mnubtnRebase.ToolTipText = "Rebase current branch to this branch";
            // 
            // mnubtnCreateBranchBasedOnRemoteBranch
            // 
            this.mnubtnCreateBranchBasedOnRemoteBranch.Image = global::GitUI.Properties.MsVsImages.Branch_16x;
            this.mnubtnCreateBranchBasedOnRemoteBranch.Name = "mnubtnCreateBranchBasedOnRemoteBranch";
            this.mnubtnCreateBranchBasedOnRemoteBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnCreateBranchBasedOnRemoteBranch.Text = "Create &Branch...";
            this.mnubtnCreateBranchBasedOnRemoteBranch.ToolTipText = "Create a local branch from the remote branch";
            // 
            // mnubtnReset
            // 
            this.mnubtnReset.Image = global::GitUI.Properties.Resources.IconResetCurrentBranchToHere;
            this.mnubtnReset.Name = "mnubtnReset";
            this.mnubtnReset.Size = new System.Drawing.Size(191, 22);
            this.mnubtnReset.Text = "Re&set";
            this.mnubtnReset.ToolTipText = "Reset current branch to here";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // mnubtnDeleteRemoteBranch
            // 
            this.mnubtnDeleteRemoteBranch.Image = global::GitUI.Properties.Resources.Delete;
            this.mnubtnDeleteRemoteBranch.Name = "mnubtnDeleteRemoteBranch";
            this.mnubtnDeleteRemoteBranch.Size = new System.Drawing.Size(191, 22);
            this.mnubtnDeleteRemoteBranch.Text = "&Delete";
            this.mnubtnDeleteRemoteBranch.ToolTipText = "Delete the branch from the remote";
            // 
            // mnubtnFetchAllBranchesFromARemote
            // 
            this.mnubtnFetchAllBranchesFromARemote.Image = global::GitUI.Properties.Resources.IconStage;
            this.mnubtnFetchAllBranchesFromARemote.Name = "mnubtnFetchAllBranchesFromARemote";
            this.mnubtnFetchAllBranchesFromARemote.Size = new System.Drawing.Size(163, 22);
            this.mnubtnFetchAllBranchesFromARemote.Text = "&Fetch";
            // 
            // menuTag
            // 
            this.menuTag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnCreateBranchForTag,
            this.mnuBtnCheckoutTag,
            this.mnubtnDeleteTag});
            this.menuTag.Name = "contextmenuTag";
            this.menuTag.Size = new System.Drawing.Size(158, 70);
            // 
            // mnubtnCreateBranchForTag
            // 
            this.mnubtnCreateBranchForTag.Image = global::GitUI.Properties.MsVsImages.Branch_16x;
            this.mnubtnCreateBranchForTag.Name = "mnubtnCreateBranchForTag";
            this.mnubtnCreateBranchForTag.Size = new System.Drawing.Size(157, 22);
            this.mnubtnCreateBranchForTag.Text = "Create &Branch...";
            this.mnubtnCreateBranchForTag.ToolTipText = "Fetch then create a local branch from the remote branch";
            // 
            // mnuBtnCheckoutTag
            // 
            this.mnuBtnCheckoutTag.Image = global::GitUI.Properties.Resources.IconBranchCheckout;
            this.mnuBtnCheckoutTag.Name = "mnuBtnCheckoutTag";
            this.mnuBtnCheckoutTag.Size = new System.Drawing.Size(157, 22);
            this.mnuBtnCheckoutTag.Text = "&Checkout";
            this.mnuBtnCheckoutTag.ToolTipText = "Checkout this branch";
            // 
            // mnubtnDeleteTag
            // 
            this.mnubtnDeleteTag.Image = global::GitUI.Properties.Resources.Delete;
            this.mnubtnDeleteTag.Name = "mnubtnDeleteTag";
            this.mnubtnDeleteTag.Size = new System.Drawing.Size(157, 22);
            this.mnubtnDeleteTag.Text = "&Delete";
            this.mnubtnDeleteTag.ToolTipText = "Delete the tag";
            // 
            // menuBranchPath
            // 
            this.menuBranchPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnDeleteAllBranches,
            this.mnubtnDeleteAllBranchesForce});
            this.menuBranchPath.Name = "contextmenuBranch";
            this.menuBranchPath.Size = new System.Drawing.Size(157, 48);
            // 
            // mnubtnDeleteAllBranches
            // 
            this.mnubtnDeleteAllBranches.Image = global::GitUI.Properties.Resources.IconBranchDelete;
            this.mnubtnDeleteAllBranches.Name = "mnubtnDeleteAllBranches";
            this.mnubtnDeleteAllBranches.Size = new System.Drawing.Size(156, 22);
            this.mnubtnDeleteAllBranches.Text = "Delete All";
            this.mnubtnDeleteAllBranches.ToolTipText = "Delete all child branchs, which must all be fully merged in its upstream branch o" +
    "r in HEAD";
            // 
            // mnubtnDeleteAllBranchesForce
            // 
            this.mnubtnDeleteAllBranchesForce.Image = global::GitUI.Properties.Resources.Delete;
            this.mnubtnDeleteAllBranchesForce.Name = "mnubtnDeleteAllBranchesForce";
            this.mnubtnDeleteAllBranchesForce.Size = new System.Drawing.Size(156, 22);
            this.mnubtnDeleteAllBranchesForce.Text = "Force Delete All";
            this.mnubtnDeleteAllBranchesForce.ToolTipText = "Delete all child branches, regardless of their merged status";
            // 
            // menuRemoteRepoNode
            // 
            this.menuRemoteRepoNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnFetchAllBranchesFromARemote,
            this.mnubtnManageRemotes});
            this.menuRemoteRepoNode.Name = "contextmenuRemote";
            this.menuRemoteRepoNode.Size = new System.Drawing.Size(164, 48);
            // 
            // mnubtnManageRemotes
            // 
            this.mnubtnManageRemotes.Image = global::GitUI.Properties.MsVsImages.Repository_16x;
            this.mnubtnManageRemotes.Name = "mnubtnManageRemotes";
            this.mnubtnManageRemotes.Size = new System.Drawing.Size(163, 22);
            this.mnubtnManageRemotes.Text = "&Manage remotes";
            // 
            // repoTreePanel
            // 
            this.repoTreePanel.ColumnCount = 1;
            this.repoTreePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.repoTreePanel.Controls.Add(this.treeMain, 0, 1);
            this.repoTreePanel.Controls.Add(this.branchSearchPanel, 0, 0);
            this.repoTreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repoTreePanel.Location = new System.Drawing.Point(0, 0);
            this.repoTreePanel.Name = "repoTreePanel";
            this.repoTreePanel.RowCount = 2;
            this.repoTreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.repoTreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.repoTreePanel.Size = new System.Drawing.Size(300, 350);
            this.repoTreePanel.TabIndex = 4;
            // 
            // branchSearchPanel
            // 
            this.branchSearchPanel.AutoSize = true;
            this.branchSearchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.branchSearchPanel.BackColor = System.Drawing.SystemColors.Control;
            this.branchSearchPanel.ColumnCount = 4;
            this.branchSearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.branchSearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.branchSearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.branchSearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.branchSearchPanel.Controls.Add(this.lblSearchBranch, 0, 0);
            this.branchSearchPanel.Controls.Add(this.btnSearch, 2, 0);
            this.branchSearchPanel.Controls.Add(this.btnSettings, 3, 0);
            this.branchSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.branchSearchPanel.Name = "branchSearchPanel";
            this.branchSearchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.branchSearchPanel.Size = new System.Drawing.Size(294, 32);
            this.branchSearchPanel.TabIndex = 4;
            // 
            // lblSearchBranch
            // 
            this.lblSearchBranch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchBranch.AutoSize = true;
            this.lblSearchBranch.Location = new System.Drawing.Point(3, 9);
            this.lblSearchBranch.Name = "lblSearchBranch";
            this.lblSearchBranch.Size = new System.Drawing.Size(44, 13);
            this.lblSearchBranch.TabIndex = 0;
            this.lblSearchBranch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Image = global::GitUI.Properties.Resources.IconFind;
            this.btnSearch.Location = new System.Drawing.Point(233, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(26, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.OnBtnSearchClicked);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.ContextMenuStrip = this.menuSettings;
            this.btnSettings.Image = global::GitUI.Properties.Resources.Settings;
            this.btnSettings.Location = new System.Drawing.Point(265, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(2);
            this.btnSettings.Size = new System.Drawing.Size(26, 26);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.OnBtnSettingsClicked);
            // 
            // menuSettings
            // 
            this.menuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTagsToolStripMenuItem});
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(129, 26);
            // 
            // showTagsToolStripMenuItem
            // 
            this.showTagsToolStripMenuItem.CheckOnClick = true;
            this.showTagsToolStripMenuItem.Name = "showTagsToolStripMenuItem";
            this.showTagsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showTagsToolStripMenuItem.Text = "Show &tags";
            this.showTagsToolStripMenuItem.Click += new System.EventHandler(this.ShowTagsToolStripMenuItem_Click);
            // 
            // RepoObjectsTree
            // 
            this.Controls.Add(this.repoTreePanel);
            this.MinimumSize = new System.Drawing.Size(190, 0);
            this.Name = "RepoObjectsTree";
            this.Size = new System.Drawing.Size(300, 350);
            this.menuMain.ResumeLayout(false);
            this.menuBranch.ResumeLayout(false);
            this.menuRemotes.ResumeLayout(false);
            this.menuRemote.ResumeLayout(false);
            this.menuTag.ResumeLayout(false);
            this.menuBranchPath.ResumeLayout(false);
            this.menuRemoteRepoNode.ResumeLayout(false);
            this.repoTreePanel.ResumeLayout(false);
            this.repoTreePanel.PerformLayout();
            this.branchSearchPanel.ResumeLayout(false);
            this.branchSearchPanel.PerformLayout();
            this.menuSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NativeTreeView treeMain;
        private ContextMenuStrip menuBranch;
        private ToolStripMenuItem mnubtnBranchCheckout;
        private ToolStripMenuItem mnubtnBranchDelete;
        private ToolStripMenuItem mnubtnBranchDeleteForce;
        private ToolStripMenuItem mnubtnFilterLocalBranchInRevisionGrid;
        private ToolStripMenuItem mnubtnFilterRemoteBranchInRevisionGrid;
        private ContextMenuStrip menuTags;
        private ContextMenuStrip menuRemotes;
        private ContextMenuStrip menuRemote;
        private ToolStripMenuItem mnubtnDeleteRemoteBranch;
        private ToolStripMenuItem mnubtnFetchAllBranchesFromARemote;
        private ToolStripMenuItem mnubtnPullFromRemoteBranch;
        private ContextMenuStrip menuTag;
        private ContextMenuStrip menuBranchPath;
        private ToolStripMenuItem mnubtnDeleteAllBranches;
        private ToolStripMenuItem mnubtnDeleteAllBranchesForce;
        private ContextMenuStrip menuMain;
        private ToolStripMenuItem mnubtnCollapseAll;
        private ToolStripMenuItem mnubtnExpandAll;
        private ToolStripMenuItem mnubtnReload;
        private ContextMenuStrip menuRemoteRepoNode;
        private ToolStripMenuItem mnubtnCreateBranchBasedOnRemoteBranch;
        private ToolStripMenuItem mnubtnFetchOneBranch;
        private ToolStripMenuItem mnuBtnCheckoutLocal;
        private ToolStripMenuItem mnubtnCreateBranchForTag;
        private ToolStripMenuItem mnubtnDeleteTag;
        private TableLayoutPanel repoTreePanel;
        private TableLayoutPanel branchSearchPanel;
        private Label lblSearchBranch;
        private Button btnSearch;
        private Button btnSettings;
        private ContextMenuStrip menuSettings;
        private ToolStripMenuItem showTagsToolStripMenuItem;
        private ToolStripMenuItem mnubtnMergeBranch;
        private ToolStripMenuItem mnubtnRebase;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnubtnReset;
        private ToolStripMenuItem mnubtnManageRemotes;
        private ToolStripMenuItem mnuBtnManageRemotesFromRootNode;
        private ToolStripMenuItem mnubtnRemoteBranchFetchAndCheckout;
        private ToolStripMenuItem mnuBtnCheckoutTag;
        private ToolStripMenuItem mnubtnFetchRebase;
        private ToolStripMenuItem mnubtnFetchCreateBranch;
    }
}
