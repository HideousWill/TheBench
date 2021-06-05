using System;
using System.Drawing;
using System.Windows.Forms;
using HideousWorks.CommonWorks.ColorTables;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory.View.Controls
{
	public partial class ImageHostControl : UserControl, IVisualizer
	{
		public ImageHostControl()
		{
			InitializeComponent();

			SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint            |
				ControlStyles.DoubleBuffer, true );
		}

		//----------------------------------------------------------------------
		public event Action< Rectangle > RectangleSelected;
		void RaiseRectangleSelected( Rectangle rectangle )
		{
			RectangleSelected?.Invoke( rectangle );
		}

		//----------------------------------------------------------------------
		public ColorTableBase Palette { get; set; }

		//----------------------------------------------------------------------
		ISetData _Data;
		public ISetData Data
		{
			get => _Data;
			set
			{
				if( null != _Data )
				{
					_Data.EntireSetChanged -= HandleEntireSetChanged;
				}
				_Data = value;
				if( null != _Data )
				{
					_Data.EntireSetChanged += HandleEntireSetChanged;
				}
			}
		}

		//----------------------------------------------------------------------
		int NumRows => Data?.Data.GetLength( 1 ) ?? 0;
		int NumCols => Data?.Data.GetLength( 0 ) ?? 0;

		//----------------------------------------------------------------------
		public void Reload()
		{
			LoadDataToImage();
		}

		//----------------------------------------------------------------------
		void HandleEntireSetChanged()
		{
			LoadDataToImage();
		}

		//----------------------------------------------------------------------
		Bitmap GeneratedImage { get; set; } = new Bitmap( 256, 256 ); // w, h

		//----------------------------------------------------------------------
		PointF ImagePosition { get; set; } = new PointF();

		//----------------------------------------------------------------------
		void CenterImage()
		{
			if( null == GeneratedImage ) return;

			var posX = (ClientRectangle.Width  - GeneratedImage.Width)  / 2;
			var posY = (ClientRectangle.Height - GeneratedImage.Height) / 2;

			ImagePosition = new PointF( posX, posY );
		}

		//----------------------------------------------------------------------
		void PrepareImage()
		{
			if (NumCols != GeneratedImage.Width ||
			    NumRows != GeneratedImage.Height)
			{
				GeneratedImage.Dispose();
				GeneratedImage = new Bitmap(NumCols, NumRows);
				
				CenterImage();
			}
		}

		//----------------------------------------------------------------------
		void LoadDataToImage()
		{
			if( null == Data ) return;
			if( null == Palette ) return;

			PrepareImage();

			for( var row = 0; row < NumRows; row++ )
			{
				LoadRowToImage( row );
			}

//			if (IsPerRowUpdateEnabled) return;

			Invalidate();
		}

		//----------------------------------------------------------------------
		void LoadRowToImage( int row )
		{
			for( var col = 0; col < NumCols; col++ )
			{
				GeneratedImage.SetPixel( col, row, Palette[ Data.Data[ col, row ] ] );
			}

//			if (!IsPerRowUpdateEnabled) return;

			return;

			Invalidate();
			Update();
		}

		//----------------------------------------------------------------------
		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );

			if( null == GeneratedImage ) return;

			e.Graphics.DrawImage( GeneratedImage, ImagePosition );

//			Tracker.DrawDragBox(e.Graphics);
		}

		//----------------------------------------------------------------------
		protected override void OnResize( EventArgs e )
		{
			base.OnResize( e );

			CenterImage();

			Invalidate();
		}

	}
}
