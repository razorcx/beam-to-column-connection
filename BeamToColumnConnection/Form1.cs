using System;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Point = Tekla.Structures.Geometry3d.Point;

namespace BeamToColumnConnection
{
	public partial class BeamToColumnConnection : Form
	{
		private readonly Model _model;
		private Beam _primaryColumn;
		private Beam _secondaryBeam1;
		private Beam _secondaryBeam2;
		private Beam _secondaryBeam3;

		public BeamToColumnConnection()
		{
			_model = new Model();
			InitializeComponent();
		}

		private void buttonCreateBeamsAndColumn_Click(object sender, EventArgs e)
		{
			_primaryColumn = new Beam(new Point(0, 0, 1000), new Point(0, 0, 4000))
			{
				Name = "COLUMN",
				Class = "3",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W410X39" },
				Material = new Material { MaterialString = "A36" },
				Position = new Position { Plane = Position.PlaneEnum.MIDDLE, Depth = Position.DepthEnum.MIDDLE }
			};

			_secondaryBeam1 = new Beam(new Point(0, 0, 2000), new Point(0, 1000, 2000))
			{
				Name = "BEAM",
				Class = "4",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W250X33" },
				Material = new Material { MaterialString = "A36" }
			};

			_secondaryBeam2 = new Beam(new Point(0, 0, 3000), new Point(0, 1000, 3000))
			{
				Name = "BEAM",
				Class = "5",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W250X33" },
				Material = new Material { MaterialString = "A36" }
			};

			_secondaryBeam3 = new Beam(new Point(0, 0, 4000), new Point(0, 1000, 4000))
			{
				Name = "BEAM",
				Class = "6",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W250X33" },
				Material = new Material { MaterialString = "A36" }
			};

			_primaryColumn.Insert();
			_secondaryBeam1.Insert();
			_secondaryBeam2.Insert();
			_secondaryBeam3.Insert();

			_model.CommitChanges();
		}

		private void buttonClipAngle141_Click(object sender, EventArgs e)
		{
			if (_primaryColumn == null || _secondaryBeam1 == null) return;

			var connection = new Connection
			{
				Name = "Clip angle",
				Number = 141,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection, _primaryColumn, _secondaryBeam1);
		}

		private void buttonEndPlate144_Click(object sender, EventArgs e)
		{
			if (_primaryColumn == null || _secondaryBeam2 == null) return;

			var connection = new Connection
			{
				Name = "End plate",
				Number = 144,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection, _primaryColumn, _secondaryBeam2);
		}

		private void buttonShearPlateSimple146_Click(object sender, EventArgs e)
		{
			if (_primaryColumn == null || _secondaryBeam3 == null) return;

			var connection = new Connection
			{
				Name = "Shear plate simple",
				Number = 146,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection, _primaryColumn, _secondaryBeam3);
		}

		private void InsertConnection(Connection connection, Beam primary, Beam secondary)
		{
			connection.SetPrimaryObject(primary);
			connection.SetSecondaryObject(secondary);

			if (!connection.Insert())
			{
				Console.WriteLine("Connection insert failed");
				return;
			}

			_model.CommitChanges();
		}
	}
}
