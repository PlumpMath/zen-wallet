
// This file has been generated by the GUI designer. Do not modify.
namespace NodeTester
{
	public partial class SettingsWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.VBox vbox5;

		private global::Gtk.MenuBar menubar2;

		private global::Gtk.CheckButton checkbuttonAutoConfigure;

		private global::Gtk.Frame frame1;

		private global::Gtk.VBox vbox6;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeviewSeeds;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonAddSeed;

		private global::Gtk.Button buttonDeleteSeed;

		private global::Gtk.Label GtkLabel3;

		private global::Gtk.Table table2;

		private global::Gtk.Entry entryMaximumNodeConnection;

		private global::Gtk.Entry entryPeersToFind;

		private global::Gtk.Entry entryServerPort;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Entry entryExternalEndpoint;

		private global::Gtk.Button buttonSetExternalEndpoint;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget NodeTester.SettingsWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "NodeTester.SettingsWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("SettingsWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child NodeTester.SettingsWindow.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(10));
			// Container child vbox5.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name='menubar2'/></ui>");
			this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
			this.menubar2.Name = "menubar2";
			this.vbox5.Add(this.menubar2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.menubar2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.checkbuttonAutoConfigure = new global::Gtk.CheckButton();
			this.checkbuttonAutoConfigure.CanFocus = true;
			this.checkbuttonAutoConfigure.Name = "checkbuttonAutoConfigure";
			this.checkbuttonAutoConfigure.Label = global::Mono.Unix.Catalog.GetString("Auto Configure");
			this.checkbuttonAutoConfigure.Active = true;
			this.checkbuttonAutoConfigure.DrawIndicator = true;
			this.checkbuttonAutoConfigure.UseUnderline = true;
			this.vbox5.Add(this.checkbuttonAutoConfigure);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.checkbuttonAutoConfigure]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewSeeds = new global::Gtk.TreeView();
			this.treeviewSeeds.CanFocus = true;
			this.treeviewSeeds.Name = "treeviewSeeds";
			this.GtkScrolledWindow.Add(this.treeviewSeeds);
			this.vbox6.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow]));
			w5.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonAddSeed = new global::Gtk.Button();
			this.buttonAddSeed.CanFocus = true;
			this.buttonAddSeed.Name = "buttonAddSeed";
			this.buttonAddSeed.UseUnderline = true;
			this.buttonAddSeed.Label = global::Mono.Unix.Catalog.GetString("Add Seed");
			this.hbox4.Add(this.buttonAddSeed);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonAddSeed]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonDeleteSeed = new global::Gtk.Button();
			this.buttonDeleteSeed.CanFocus = true;
			this.buttonDeleteSeed.Name = "buttonDeleteSeed";
			this.buttonDeleteSeed.UseUnderline = true;
			this.buttonDeleteSeed.Label = global::Mono.Unix.Catalog.GetString("Delete Seed");
			this.hbox4.Add(this.buttonDeleteSeed);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonDeleteSeed]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox6.Add(this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.frame1.Add(this.vbox6);
			this.GtkLabel3 = new global::Gtk.Label();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("Seeds");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.vbox5.Add(this.frame1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.frame1]));
			w10.Position = 2;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entryMaximumNodeConnection = new global::Gtk.Entry();
			this.entryMaximumNodeConnection.CanFocus = true;
			this.entryMaximumNodeConnection.Name = "entryMaximumNodeConnection";
			this.entryMaximumNodeConnection.IsEditable = true;
			this.entryMaximumNodeConnection.InvisibleChar = '●';
			this.table2.Add(this.entryMaximumNodeConnection);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.entryMaximumNodeConnection]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryPeersToFind = new global::Gtk.Entry();
			this.entryPeersToFind.CanFocus = true;
			this.entryPeersToFind.Name = "entryPeersToFind";
			this.entryPeersToFind.IsEditable = true;
			this.entryPeersToFind.InvisibleChar = '●';
			this.table2.Add(this.entryPeersToFind);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.entryPeersToFind]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryServerPort = new global::Gtk.Entry();
			this.entryServerPort.CanFocus = true;
			this.entryServerPort.Name = "entryServerPort";
			this.entryServerPort.IsEditable = true;
			this.entryServerPort.InvisibleChar = '●';
			this.table2.Add(this.entryServerPort);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.entryServerPort]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryExternalEndpoint = new global::Gtk.Entry();
			this.entryExternalEndpoint.Sensitive = false;
			this.entryExternalEndpoint.CanFocus = true;
			this.entryExternalEndpoint.Name = "entryExternalEndpoint";
			this.entryExternalEndpoint.IsEditable = true;
			this.entryExternalEndpoint.InvisibleChar = '●';
			this.hbox2.Add(this.entryExternalEndpoint);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryExternalEndpoint]));
			w14.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSetExternalEndpoint = new global::Gtk.Button();
			this.buttonSetExternalEndpoint.Sensitive = false;
			this.buttonSetExternalEndpoint.CanFocus = true;
			this.buttonSetExternalEndpoint.Name = "buttonSetExternalEndpoint";
			this.buttonSetExternalEndpoint.UseUnderline = true;
			this.buttonSetExternalEndpoint.Label = global::Mono.Unix.Catalog.GetString("...");
			this.hbox2.Add(this.buttonSetExternalEndpoint);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSetExternalEndpoint]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.table2.Add(this.hbox2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.hbox2]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Peers to find:");
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Maximum Node Connection:");
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Server Port (internal):");
			this.table2.Add(this.label5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("External Endpoint:");
			this.table2.Add(this.label6);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add(this.table2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.table2]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Save");
			this.hbox3.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonSave]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.hbox3.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonCancel]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox5.Add(this.hbox3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 369;
			this.Show();
			this.buttonAddSeed.Clicked += new global::System.EventHandler(this.Button_AddSeed);
			this.buttonDeleteSeed.Clicked += new global::System.EventHandler(this.Button_DeleteSeed);
			this.buttonSetExternalEndpoint.Clicked += new global::System.EventHandler(this.Button_SetExternalEndpoint);
			this.buttonSave.Clicked += new global::System.EventHandler(this.Button_Save);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.Button_Cancel);
		}
	}
}