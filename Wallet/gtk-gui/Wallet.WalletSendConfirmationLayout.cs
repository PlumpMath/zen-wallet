
// This file has been generated by the GUI designer. Do not modify.
namespace Wallet
{
	public partial class WalletSendConfirmationLayout
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hboxTop;

		private global::Gtk.Label label5;

		private global::Gtk.Button buttonBack;

		private global::Gtk.VBox vboxMainInner;

		private global::Gtk.EventBox eventboxDestination;

		private global::Gtk.VBox vboxDestination;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label labelDestination;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Entry entryDestination;

		private global::Gtk.EventBox eventboxAsset;

		private global::Gtk.VBox vboxDestination1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label labelAsset;

		private global::Gtk.HBox hboxAsset;

		private global::Gtk.EventBox eventbox6;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Image imageAsset;

		private global::Gtk.Label labelSelectedAsset;

		private global::Gtk.EventBox eventboxAmount;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label labelAmount;

		private global::Gtk.SpinButton spinbuttonAmount;

		private global::Gtk.Label labelSelectedAsset1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonConfirm;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Wallet.WalletSendConfirmationLayout
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Wallet.WalletSendConfirmationLayout";
			// Container child Wallet.WalletSendConfirmationLayout.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hboxTop = new global::Gtk.HBox();
			this.hboxTop.Name = "hboxTop";
			this.hboxTop.Spacing = 6;
			this.hboxTop.BorderWidth = ((uint)(10));
			// Container child hboxTop.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.hboxTop.Add(this.label5);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.label5]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.buttonBack = new global::Gtk.Button();
			this.buttonBack.CanFocus = true;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.UseUnderline = true;
			this.buttonBack.Label = global::Mono.Unix.Catalog.GetString("Back");
			this.hboxTop.Add(this.buttonBack);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.buttonBack]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox3.Add(this.hboxTop);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hboxTop]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vboxMainInner = new global::Gtk.VBox();
			this.vboxMainInner.Name = "vboxMainInner";
			this.vboxMainInner.Spacing = 15;
			this.vboxMainInner.BorderWidth = ((uint)(40));
			// Container child vboxMainInner.Gtk.Box+BoxChild
			this.eventboxDestination = new global::Gtk.EventBox();
			this.eventboxDestination.Name = "eventboxDestination";
			// Container child eventboxDestination.Gtk.Container+ContainerChild
			this.vboxDestination = new global::Gtk.VBox();
			this.vboxDestination.Name = "vboxDestination";
			// Container child vboxDestination.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.BorderWidth = ((uint)(10));
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelDestination = new global::Gtk.Label();
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.LabelProp = global::Mono.Unix.Catalog.GetString("Destination:");
			this.hbox2.Add(this.labelDestination);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelDestination]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(10));
			this.vboxDestination.Add(this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxDestination[this.hbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vboxDestination.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			this.hbox8.BorderWidth = ((uint)(10));
			// Container child hbox8.Gtk.Box+BoxChild
			this.entryDestination = new global::Gtk.Entry();
			this.entryDestination.Sensitive = false;
			this.entryDestination.CanFocus = true;
			this.entryDestination.Name = "entryDestination";
			this.entryDestination.IsEditable = true;
			this.entryDestination.InvisibleChar = '●';
			this.hbox8.Add(this.entryDestination);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.entryDestination]));
			w6.Position = 0;
			w6.Padding = ((uint)(10));
			this.vboxDestination.Add(this.hbox8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxDestination[this.hbox8]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.eventboxDestination.Add(this.vboxDestination);
			this.vboxMainInner.Add(this.eventboxDestination);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxMainInner[this.eventboxDestination]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			w9.Padding = ((uint)(5));
			// Container child vboxMainInner.Gtk.Box+BoxChild
			this.eventboxAsset = new global::Gtk.EventBox();
			this.eventboxAsset.Name = "eventboxAsset";
			// Container child eventboxAsset.Gtk.Container+ContainerChild
			this.vboxDestination1 = new global::Gtk.VBox();
			this.vboxDestination1.Name = "vboxDestination1";
			// Container child vboxDestination1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.BorderWidth = ((uint)(10));
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelAsset = new global::Gtk.Label();
			this.labelAsset.Name = "labelAsset";
			this.labelAsset.LabelProp = global::Mono.Unix.Catalog.GetString("Asset:");
			this.hbox3.Add(this.labelAsset);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelAsset]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(10));
			this.vboxDestination1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxDestination1[this.hbox3]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxDestination1.Gtk.Box+BoxChild
			this.hboxAsset = new global::Gtk.HBox();
			this.hboxAsset.Name = "hboxAsset";
			this.hboxAsset.BorderWidth = ((uint)(10));
			// Container child hboxAsset.Gtk.Box+BoxChild
			this.eventbox6 = new global::Gtk.EventBox();
			this.eventbox6.Name = "eventbox6";
			this.eventbox6.BorderWidth = ((uint)(10));
			// Container child eventbox6.Gtk.Container+ContainerChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.imageAsset = new global::Gtk.Image();
			this.imageAsset.Name = "imageAsset";
			this.imageAsset.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-connect", global::Gtk.IconSize.Menu);
			this.hbox7.Add(this.imageAsset);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.imageAsset]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelSelectedAsset = new global::Gtk.Label();
			this.labelSelectedAsset.Name = "labelSelectedAsset";
			this.labelSelectedAsset.LabelProp = global::Mono.Unix.Catalog.GetString("Zen");
			this.hbox7.Add(this.labelSelectedAsset);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelSelectedAsset]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.eventbox6.Add(this.hbox7);
			this.hboxAsset.Add(this.eventbox6);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxAsset[this.eventbox6]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			this.vboxDestination1.Add(this.hboxAsset);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxDestination1[this.hboxAsset]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.eventboxAsset.Add(this.vboxDestination1);
			this.vboxMainInner.Add(this.eventboxAsset);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vboxMainInner[this.eventboxAsset]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vboxMainInner.Gtk.Box+BoxChild
			this.eventboxAmount = new global::Gtk.EventBox();
			this.eventboxAmount.Name = "eventboxAmount";
			// Container child eventboxAmount.Gtk.Container+ContainerChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 10;
			this.hbox6.BorderWidth = ((uint)(10));
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelAmount = new global::Gtk.Label();
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.LabelProp = global::Mono.Unix.Catalog.GetString("Amount to send:");
			this.hbox6.Add(this.labelAmount);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelAmount]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(10));
			// Container child hbox6.Gtk.Box+BoxChild
			this.spinbuttonAmount = new global::Gtk.SpinButton(0, 100, 1);
			this.spinbuttonAmount.WidthRequest = 110;
			this.spinbuttonAmount.Sensitive = false;
			this.spinbuttonAmount.CanFocus = true;
			this.spinbuttonAmount.Name = "spinbuttonAmount";
			this.spinbuttonAmount.Adjustment.PageIncrement = 10;
			this.spinbuttonAmount.ClimbRate = 1;
			this.spinbuttonAmount.Digits = ((uint)(3));
			this.spinbuttonAmount.Numeric = true;
			this.spinbuttonAmount.SnapToTicks = true;
			this.hbox6.Add(this.spinbuttonAmount);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spinbuttonAmount]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelSelectedAsset1 = new global::Gtk.Label();
			this.labelSelectedAsset1.Name = "labelSelectedAsset1";
			this.labelSelectedAsset1.LabelProp = global::Mono.Unix.Catalog.GetString("Zen");
			this.hbox6.Add(this.labelSelectedAsset1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelSelectedAsset1]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.eventboxAmount.Add(this.hbox6);
			this.vboxMainInner.Add(this.eventboxAmount);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vboxMainInner[this.eventboxAmount]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			w23.Padding = ((uint)(5));
			// Container child vboxMainInner.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonConfirm = new global::Gtk.Button();
			this.buttonConfirm.WidthRequest = 140;
			this.buttonConfirm.HeightRequest = 50;
			this.buttonConfirm.CanFocus = true;
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.UseUnderline = true;
			this.buttonConfirm.Label = global::Mono.Unix.Catalog.GetString("Confirm");
			this.hbox4.Add(this.buttonConfirm);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonConfirm]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vboxMainInner.Add(this.hbox4);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxMainInner[this.hbox4]));
			w25.PackType = ((global::Gtk.PackType)(1));
			w25.Position = 3;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox3.Add(this.vboxMainInner);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vboxMainInner]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
