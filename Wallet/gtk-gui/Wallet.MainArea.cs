
// This file has been generated by the GUI designer. Do not modify.
namespace Wallet
{
	public partial class MainArea
	{
		private global::Gtk.Notebook notebook1;

		private global::Wallet.WalletLayout walletlayout1;

		private global::Gtk.Label label9;

		private global::Wallet.Widgets.Portfolio.PortfolioLayout portfoliolayout1;

		private global::Gtk.Label label12;

		private global::Wallet.Widgets.Contract.ContractLayout contractlayout1;

		private global::Gtk.Label label14;

		private global::Wallet.LogLayout loglayout1;

		private global::Gtk.Label label19;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Wallet.MainArea
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Wallet.MainArea";
			// Container child Wallet.MainArea.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			this.notebook1.ShowBorder = false;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.walletlayout1 = new global::Wallet.WalletLayout();
			this.walletlayout1.Events = ((global::Gdk.EventMask)(256));
			this.walletlayout1.Name = "walletlayout1";
			this.notebook1.Add(this.walletlayout1);
			// Notebook tab
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("page5");
			this.notebook1.SetTabLabel(this.walletlayout1, this.label9);
			this.label9.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.portfoliolayout1 = new global::Wallet.Widgets.Portfolio.PortfolioLayout();
			this.portfoliolayout1.Events = ((global::Gdk.EventMask)(256));
			this.portfoliolayout1.Name = "portfoliolayout1";
			this.notebook1.Add(this.portfoliolayout1);
			global::Gtk.Notebook.NotebookChild w2 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.portfoliolayout1]));
			w2.Position = 1;
			// Notebook tab
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("page4");
			this.notebook1.SetTabLabel(this.portfoliolayout1, this.label12);
			this.label12.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.contractlayout1 = new global::Wallet.Widgets.Contract.ContractLayout();
			this.contractlayout1.Events = ((global::Gdk.EventMask)(256));
			this.contractlayout1.Name = "contractlayout1";
			this.contractlayout1.CostPerBlock = 0m;
			this.contractlayout1.CostTotal = ulong.Parse("0");
			this.notebook1.Add(this.contractlayout1);
			global::Gtk.Notebook.NotebookChild w3 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.contractlayout1]));
			w3.Position = 2;
			// Notebook tab
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("page2");
			this.notebook1.SetTabLabel(this.contractlayout1, this.label14);
			this.label14.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.loglayout1 = new global::Wallet.LogLayout();
			this.loglayout1.Events = ((global::Gdk.EventMask)(256));
			this.loglayout1.Name = "loglayout1";
			this.notebook1.Add(this.loglayout1);
			global::Gtk.Notebook.NotebookChild w4 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.loglayout1]));
			w4.Position = 3;
			// Notebook tab
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("page3");
			this.notebook1.SetTabLabel(this.loglayout1, this.label19);
			this.label19.ShowAll();
			this.Add(this.notebook1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
