
// This file has been generated by the GUI designer. Do not modify.
namespace Wallet
{
	public partial class MainMenu
	{
		private global::Gtk.HBox hbox3;
		
		private global::Wallet.MenuButton Portfolio;
		
		private global::Wallet.MenuButton Wallet;
		
		private global::Wallet.MenuButton Contract;
		
		private global::Wallet.MenuButton Market;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Wallet.MainMenu
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Wallet.MainMenu";
			// Container child Wallet.MainMenu.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Portfolio = new global::Wallet.MenuButton ();
			this.Portfolio.HeightRequest = 10;
			this.Portfolio.Events = ((global::Gdk.EventMask)(256));
			this.Portfolio.Name = "Portfolio";
			this.hbox3.Add (this.Portfolio);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.Portfolio]));
			w1.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Wallet = new global::Wallet.MenuButton ();
			this.Wallet.HeightRequest = 10;
			this.Wallet.Events = ((global::Gdk.EventMask)(256));
			this.Wallet.Name = "Wallet";
			this.hbox3.Add (this.Wallet);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.Wallet]));
			w2.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Contract = new global::Wallet.MenuButton ();
			this.Contract.HeightRequest = 10;
			this.Contract.Events = ((global::Gdk.EventMask)(256));
			this.Contract.Name = "Contract";
			this.hbox3.Add (this.Contract);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.Contract]));
			w3.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Market = new global::Wallet.MenuButton ();
			this.Market.Events = ((global::Gdk.EventMask)(256));
			this.Market.Name = "Market";
			this.hbox3.Add (this.Market);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.Market]));
			w4.Position = 3;
			this.Add (this.hbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}