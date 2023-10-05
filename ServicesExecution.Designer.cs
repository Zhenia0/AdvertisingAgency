
namespace AdvertisingAgency
{
    partial class ServicesExecution
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label servProviderLabel;
            System.Windows.Forms.Label executionTimeLabel;
            System.Windows.Forms.Label servCountLabel;
            System.Windows.Forms.Label servPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesExecution));
            this.advertising_agencyDataSet = new AdvertisingAgency.advertising_agencyDataSet();
            this.serviceExecutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceExecutionTableAdapter = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.ServiceExecutionTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.TableAdapterManager();
            this.serviceExecutionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceExecutionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.servProviderTextBox = new System.Windows.Forms.TextBox();
            this.executionTimeTextBox = new System.Windows.Forms.TextBox();
            this.servCountTextBox = new System.Windows.Forms.TextBox();
            this.servPriceTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deliveryOfGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryOfGoodsTableAdapter = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.DeliveryOfGoodsTableAdapter();
            servProviderLabel = new System.Windows.Forms.Label();
            executionTimeLabel = new System.Windows.Forms.Label();
            servCountLabel = new System.Windows.Forms.Label();
            servPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advertising_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExecutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExecutionBindingNavigator)).BeginInit();
            this.serviceExecutionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // servProviderLabel
            // 
            servProviderLabel.AutoSize = true;
            servProviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            servProviderLabel.Location = new System.Drawing.Point(22, 165);
            servProviderLabel.Name = "servProviderLabel";
            servProviderLabel.Size = new System.Drawing.Size(167, 24);
            servProviderLabel.TabIndex = 1;
            servProviderLabel.Text = "Имя исполнителя";
            // 
            // executionTimeLabel
            // 
            executionTimeLabel.AutoSize = true;
            executionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            executionTimeLabel.Location = new System.Drawing.Point(11, 221);
            executionTimeLabel.Name = "executionTimeLabel";
            executionTimeLabel.Size = new System.Drawing.Size(182, 24);
            executionTimeLabel.TabIndex = 3;
            executionTimeLabel.Text = "Время выполнения";
            // 
            // servCountLabel
            // 
            servCountLabel.AutoSize = true;
            servCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            servCountLabel.Location = new System.Drawing.Point(20, 276);
            servCountLabel.Name = "servCountLabel";
            servCountLabel.Size = new System.Drawing.Size(169, 24);
            servCountLabel.TabIndex = 5;
            servCountLabel.Text = "Количество услуг";
            // 
            // servPriceLabel
            // 
            servPriceLabel.AutoSize = true;
            servPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            servPriceLabel.Location = new System.Drawing.Point(11, 329);
            servPriceLabel.Name = "servPriceLabel";
            servPriceLabel.Size = new System.Drawing.Size(173, 24);
            servPriceLabel.TabIndex = 7;
            servPriceLabel.Text = "Стоимость услуги";
            // 
            // advertising_agencyDataSet
            // 
            this.advertising_agencyDataSet.DataSetName = "advertising_agencyDataSet";
            this.advertising_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceExecutionBindingSource
            // 
            this.serviceExecutionBindingSource.DataMember = "ServiceExecution";
            this.serviceExecutionBindingSource.DataSource = this.advertising_agencyDataSet;
            // 
            // serviceExecutionTableAdapter
            // 
            this.serviceExecutionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DeliveryOfGoodsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.ServiceExecutionTableAdapter = this.serviceExecutionTableAdapter;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency.advertising_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceExecutionBindingNavigator
            // 
            this.serviceExecutionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceExecutionBindingNavigator.BindingSource = this.serviceExecutionBindingSource;
            this.serviceExecutionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceExecutionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviceExecutionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.serviceExecutionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceExecutionBindingNavigatorSaveItem});
            this.serviceExecutionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviceExecutionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviceExecutionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviceExecutionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceExecutionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceExecutionBindingNavigator.Name = "serviceExecutionBindingNavigator";
            this.serviceExecutionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceExecutionBindingNavigator.Size = new System.Drawing.Size(499, 31);
            this.serviceExecutionBindingNavigator.TabIndex = 0;
            this.serviceExecutionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // serviceExecutionBindingNavigatorSaveItem
            // 
            this.serviceExecutionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceExecutionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceExecutionBindingNavigatorSaveItem.Image")));
            this.serviceExecutionBindingNavigatorSaveItem.Name = "serviceExecutionBindingNavigatorSaveItem";
            this.serviceExecutionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.serviceExecutionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.serviceExecutionBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceExecutionBindingNavigatorSaveItem_Click);
            // 
            // servProviderTextBox
            // 
            this.servProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceExecutionBindingSource, "servProvider", true));
            this.servProviderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.servProviderTextBox.Location = new System.Drawing.Point(206, 160);
            this.servProviderTextBox.Name = "servProviderTextBox";
            this.servProviderTextBox.Size = new System.Drawing.Size(266, 28);
            this.servProviderTextBox.TabIndex = 2;
            // 
            // executionTimeTextBox
            // 
            this.executionTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceExecutionBindingSource, "executionTime", true));
            this.executionTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.executionTimeTextBox.Location = new System.Drawing.Point(206, 216);
            this.executionTimeTextBox.Name = "executionTimeTextBox";
            this.executionTimeTextBox.Size = new System.Drawing.Size(266, 28);
            this.executionTimeTextBox.TabIndex = 4;
            // 
            // servCountTextBox
            // 
            this.servCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceExecutionBindingSource, "servCount", true));
            this.servCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.servCountTextBox.Location = new System.Drawing.Point(206, 272);
            this.servCountTextBox.Name = "servCountTextBox";
            this.servCountTextBox.Size = new System.Drawing.Size(266, 28);
            this.servCountTextBox.TabIndex = 6;
            // 
            // servPriceTextBox
            // 
            this.servPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceExecutionBindingSource, "servPrice", true));
            this.servPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.servPriceTextBox.Location = new System.Drawing.Point(206, 326);
            this.servPriceTextBox.Name = "servPriceTextBox";
            this.servPriceTextBox.Size = new System.Drawing.Size(266, 28);
            this.servPriceTextBox.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.Location = new System.Drawing.Point(251, 551);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 50);
            this.button8.TabIndex = 55;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button7.Location = new System.Drawing.Point(251, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 50);
            this.button7.TabIndex = 54;
            this.button7.Text = "Отменить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(251, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 50);
            this.button6.TabIndex = 53;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(251, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 50);
            this.button5.TabIndex = 52;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(45, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 50);
            this.button4.TabIndex = 51;
            this.button4.Text = "В конец";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(45, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 50);
            this.button3.TabIndex = 50;
            this.button3.Text = "Вперёд";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(45, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 50);
            this.button2.TabIndex = 49;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(45, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 48;
            this.button1.Text = "В начало";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(137, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Выполнение услуг";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button9.Location = new System.Drawing.Point(45, 607);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(396, 50);
            this.button9.TabIndex = 58;
            this.button9.Text = "Редактировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.serviceExecutionBindingSource, "delId", true));
            this.comboBox1.DataSource = this.deliveryOfGoodsBindingSource;
            this.comboBox1.DisplayMember = "goodsType";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 30);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.ValueMember = "delId";
            // 
            // deliveryOfGoodsBindingSource
            // 
            this.deliveryOfGoodsBindingSource.DataMember = "DeliveryOfGoods";
            this.deliveryOfGoodsBindingSource.DataSource = this.advertising_agencyDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Тип товара";
            // 
            // deliveryOfGoodsTableAdapter
            // 
            this.deliveryOfGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // ServicesExecution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(servPriceLabel);
            this.Controls.Add(this.servPriceTextBox);
            this.Controls.Add(servCountLabel);
            this.Controls.Add(this.servCountTextBox);
            this.Controls.Add(executionTimeLabel);
            this.Controls.Add(this.executionTimeTextBox);
            this.Controls.Add(servProviderLabel);
            this.Controls.Add(this.servProviderTextBox);
            this.Controls.Add(this.serviceExecutionBindingNavigator);
            this.Name = "ServicesExecution";
            this.Text = "ServicesExecution";
            this.Load += new System.EventHandler(this.ServicesExecution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertising_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExecutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExecutionBindingNavigator)).EndInit();
            this.serviceExecutionBindingNavigator.ResumeLayout(false);
            this.serviceExecutionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advertising_agencyDataSet advertising_agencyDataSet;
        private System.Windows.Forms.BindingSource serviceExecutionBindingSource;
        private advertising_agencyDataSetTableAdapters.ServiceExecutionTableAdapter serviceExecutionTableAdapter;
        private advertising_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviceExecutionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton serviceExecutionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox servProviderTextBox;
        private System.Windows.Forms.TextBox executionTimeTextBox;
        private System.Windows.Forms.TextBox servCountTextBox;
        private System.Windows.Forms.TextBox servPriceTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource deliveryOfGoodsBindingSource;
        private advertising_agencyDataSetTableAdapters.DeliveryOfGoodsTableAdapter deliveryOfGoodsTableAdapter;
    }
}