
namespace AdvertisingAgency
{
    partial class DeliveryOfGoods
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
            System.Windows.Forms.Label goodsTypeLabel;
            System.Windows.Forms.Label dateDeliveryLabel;
            System.Windows.Forms.Label goodsPriceLabel;
            System.Windows.Forms.Label supIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOfGoods));
            this.advertising_agencyDataSet = new AdvertisingAgency.advertising_agencyDataSet();
            this.deliveryOfGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryOfGoodsTableAdapter = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.DeliveryOfGoodsTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.TableAdapterManager();
            this.deliveryOfGoodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.deliveryOfGoodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.goodsTypeTextBox = new System.Windows.Forms.TextBox();
            this.dateDeliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goodsPriceTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new AdvertisingAgency.advertising_agencyDataSetTableAdapters.SupplierTableAdapter();
            this.fKDeliveryOsupId17F790F9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            goodsTypeLabel = new System.Windows.Forms.Label();
            dateDeliveryLabel = new System.Windows.Forms.Label();
            goodsPriceLabel = new System.Windows.Forms.Label();
            supIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advertising_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingNavigator)).BeginInit();
            this.deliveryOfGoodsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeliveryOsupId17F790F9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsTypeLabel
            // 
            goodsTypeLabel.AutoSize = true;
            goodsTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            goodsTypeLabel.Location = new System.Drawing.Point(127, 180);
            goodsTypeLabel.Name = "goodsTypeLabel";
            goodsTypeLabel.Size = new System.Drawing.Size(112, 24);
            goodsTypeLabel.TabIndex = 1;
            goodsTypeLabel.Text = "Тип товара";
            // 
            // dateDeliveryLabel
            // 
            dateDeliveryLabel.AutoSize = true;
            dateDeliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dateDeliveryLabel.Location = new System.Drawing.Point(97, 232);
            dateDeliveryLabel.Name = "dateDeliveryLabel";
            dateDeliveryLabel.Size = new System.Drawing.Size(142, 24);
            dateDeliveryLabel.TabIndex = 3;
            dateDeliveryLabel.Text = "Дата поставки";
            // 
            // goodsPriceLabel
            // 
            goodsPriceLabel.AutoSize = true;
            goodsPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            goodsPriceLabel.Location = new System.Drawing.Point(61, 283);
            goodsPriceLabel.Name = "goodsPriceLabel";
            goodsPriceLabel.Size = new System.Drawing.Size(178, 24);
            goodsPriceLabel.TabIndex = 5;
            goodsPriceLabel.Text = "Стоимость товара";
            // 
            // supIdLabel
            // 
            supIdLabel.AutoSize = true;
            supIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            supIdLabel.Location = new System.Drawing.Point(34, 125);
            supIdLabel.Name = "supIdLabel";
            supIdLabel.Size = new System.Drawing.Size(218, 24);
            supIdLabel.TabIndex = 55;
            supIdLabel.Text = "Название организации";
            // 
            // advertising_agencyDataSet
            // 
            this.advertising_agencyDataSet.DataSetName = "advertising_agencyDataSet";
            this.advertising_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryOfGoodsBindingSource
            // 
            this.deliveryOfGoodsBindingSource.DataMember = "DeliveryOfGoods";
            this.deliveryOfGoodsBindingSource.DataSource = this.advertising_agencyDataSet;
            // 
            // deliveryOfGoodsTableAdapter
            // 
            this.deliveryOfGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DeliveryOfGoodsTableAdapter = this.deliveryOfGoodsTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.ServiceExecutionTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency.advertising_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deliveryOfGoodsBindingNavigator
            // 
            this.deliveryOfGoodsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.deliveryOfGoodsBindingNavigator.BindingSource = this.deliveryOfGoodsBindingSource;
            this.deliveryOfGoodsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.deliveryOfGoodsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.deliveryOfGoodsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deliveryOfGoodsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.deliveryOfGoodsBindingNavigatorSaveItem});
            this.deliveryOfGoodsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.deliveryOfGoodsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.deliveryOfGoodsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.deliveryOfGoodsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.deliveryOfGoodsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.deliveryOfGoodsBindingNavigator.Name = "deliveryOfGoodsBindingNavigator";
            this.deliveryOfGoodsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.deliveryOfGoodsBindingNavigator.Size = new System.Drawing.Size(532, 31);
            this.deliveryOfGoodsBindingNavigator.TabIndex = 0;
            this.deliveryOfGoodsBindingNavigator.Text = "bindingNavigator1";
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
            // deliveryOfGoodsBindingNavigatorSaveItem
            // 
            this.deliveryOfGoodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deliveryOfGoodsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("deliveryOfGoodsBindingNavigatorSaveItem.Image")));
            this.deliveryOfGoodsBindingNavigatorSaveItem.Name = "deliveryOfGoodsBindingNavigatorSaveItem";
            this.deliveryOfGoodsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.deliveryOfGoodsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.deliveryOfGoodsBindingNavigatorSaveItem.Click += new System.EventHandler(this.deliveryOfGoodsBindingNavigatorSaveItem_Click);
            // 
            // goodsTypeTextBox
            // 
            this.goodsTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOfGoodsBindingSource, "goodsType", true));
            this.goodsTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.goodsTypeTextBox.Location = new System.Drawing.Point(258, 177);
            this.goodsTypeTextBox.Name = "goodsTypeTextBox";
            this.goodsTypeTextBox.Size = new System.Drawing.Size(200, 28);
            this.goodsTypeTextBox.TabIndex = 2;
            // 
            // dateDeliveryDateTimePicker
            // 
            this.dateDeliveryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryOfGoodsBindingSource, "dateDelivery", true));
            this.dateDeliveryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateDeliveryDateTimePicker.Location = new System.Drawing.Point(258, 227);
            this.dateDeliveryDateTimePicker.MinDate = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            this.dateDeliveryDateTimePicker.Name = "dateDeliveryDateTimePicker";
            this.dateDeliveryDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.dateDeliveryDateTimePicker.TabIndex = 4;
            // 
            // goodsPriceTextBox
            // 
            this.goodsPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOfGoodsBindingSource, "goodsPrice", true));
            this.goodsPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.goodsPriceTextBox.Location = new System.Drawing.Point(258, 279);
            this.goodsPriceTextBox.Name = "goodsPriceTextBox";
            this.goodsPriceTextBox.Size = new System.Drawing.Size(200, 28);
            this.goodsPriceTextBox.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.Location = new System.Drawing.Point(279, 533);
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
            this.button7.Location = new System.Drawing.Point(279, 477);
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
            this.button6.Location = new System.Drawing.Point(279, 421);
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
            this.button5.Location = new System.Drawing.Point(279, 365);
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
            this.button4.Location = new System.Drawing.Point(73, 533);
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
            this.button3.Location = new System.Drawing.Point(73, 477);
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
            this.button2.Location = new System.Drawing.Point(73, 421);
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
            this.button1.Location = new System.Drawing.Point(73, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 48;
            this.button1.Text = "В начало";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.advertising_agencyDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // fKDeliveryOsupId17F790F9BindingSource
            // 
            this.fKDeliveryOsupId17F790F9BindingSource.DataMember = "FK__DeliveryO__supId__17F790F9";
            this.fKDeliveryOsupId17F790F9BindingSource.DataSource = this.supplierBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveryOfGoodsBindingSource, "supId", true));
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "institutionName";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "supId";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button9.Location = new System.Drawing.Point(73, 589);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(396, 50);
            this.button9.TabIndex = 57;
            this.button9.Text = "Редактировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(152, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Поставка товаров";
            // 
            // DeliveryOfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(supIdLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(goodsPriceLabel);
            this.Controls.Add(this.goodsPriceTextBox);
            this.Controls.Add(dateDeliveryLabel);
            this.Controls.Add(this.dateDeliveryDateTimePicker);
            this.Controls.Add(goodsTypeLabel);
            this.Controls.Add(this.goodsTypeTextBox);
            this.Controls.Add(this.deliveryOfGoodsBindingNavigator);
            this.Name = "DeliveryOfGoods";
            this.Text = "DeliveryOfGoods";
            this.Load += new System.EventHandler(this.DeliveryOfGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertising_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOfGoodsBindingNavigator)).EndInit();
            this.deliveryOfGoodsBindingNavigator.ResumeLayout(false);
            this.deliveryOfGoodsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeliveryOsupId17F790F9BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advertising_agencyDataSet advertising_agencyDataSet;
        private System.Windows.Forms.BindingSource deliveryOfGoodsBindingSource;
        private advertising_agencyDataSetTableAdapters.DeliveryOfGoodsTableAdapter deliveryOfGoodsTableAdapter;
        private advertising_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator deliveryOfGoodsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton deliveryOfGoodsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox goodsTypeTextBox;
        private System.Windows.Forms.DateTimePicker dateDeliveryDateTimePicker;
        private System.Windows.Forms.TextBox goodsPriceTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private advertising_agencyDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource fKDeliveryOsupId17F790F9BindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}