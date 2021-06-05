using System;
using System.Diagnostics;
using System.Numerics;

namespace HideousWorks.Fractory.Model
{
	public class SetGenerator : ISetData
	{
		#region ISetData Members

		//----------------------------------------------------------------------
		public event Action SetStarted;

		void RaiseSetStarted()
		{
			SetStarted?.Invoke();
		}

		//----------------------------------------------------------------------
		public event Action EntireSetChanged;

		void RaiseEntireSetChanged()
		{
			EntireSetChanged?.Invoke();
		}

		//----------------------------------------------------------------------
		public event Action< int > RowChanged;

		void RaiseRowChanged( int rowIndex )
		{
			RowChanged?.Invoke( rowIndex );
		}

		//----------------------------------------------------------------------
		public int SampleWidth { get; private set; }

		//----------------------------------------------------------------------
		public int SampleHeight { get; private set; }

		//----------------------------------------------------------------------
		public int[,] Data { get; private set; }


		#endregion

		//----------------------------------------------------------------------
		public GeneratorInfo Info { get; set; }

		//----------------------------------------------------------------------
		public void Generate()
		{
			if( null == Info ) return;

			CreateDataStore();

			RaiseSetStarted();

			StartRecording();

			var thisImaginary = Info.Min.Imaginary;
			var delta         = Info.Extent.Imaginary / SampleHeight;

			for( var row = 0; row < SampleHeight; row++ )
			{
				GenerateRow( row, thisImaginary );

				RaiseRowChanged( row );

				thisImaginary += delta;
			}

			RaiseEntireSetChanged();

			StopRecording();
		}

		//----------------------------------------------------------------------
		void GenerateRow( int row, double thisImaginary )
		{
			var thisReal = Info.Min.Real;

			var delta = Info.Extent.Real / SampleWidth;

			for( var col = 0; col < SampleWidth; col++ )
			{
				var iterations = Info.Evaluator.Evaluate(
					new Complex( thisReal, thisImaginary ), Info.Iterations, Info.ConvergenceLimit );

				Data[ col, row ] = iterations;

				RecordEvaluation( iterations );

				thisReal += delta;
			}
		}

		//----------------------------------------------------------------------
		void CreateDataStore()
		{
			SampleWidth  = Info.Resolution.Width;
			SampleHeight = Info.Resolution.Height;

			Data = new int[SampleWidth, SampleHeight];
		}

		#region Instrumentation

		//----------------------------------------------------------------------
		int TotalIterations { get; set; }

		//----------------------------------------------------------------------
		int ElementsInSet { get; set; }

		//----------------------------------------------------------------------
		Stopwatch Timer { get; } = new Stopwatch();

		//----------------------------------------------------------------------
		void StartRecording()
		{
			TotalIterations = 0;
			ElementsInSet   = 0;
			Timer.Start();
		}

		//----------------------------------------------------------------------
		void RecordEvaluation( int iterations )
		{
			if( 0 == iterations )
			{
				++ElementsInSet;
			}
			else
			{
				TotalIterations += iterations;
			}
		}

		//----------------------------------------------------------------------
		void StopRecording()
		{
			Timer.Stop();

			Console.Write( $"{Info.Evaluator}: {Timer.ElapsedMilliseconds} ms " );
			Console.Write( $" | Points in set: {ElementsInSet} out of {Info.Resolution.Height * Info.Resolution.Width}" );
//			Console.Write( $" | iterations = {TotalIterations}; inSet = {ElementsInSet};" );
//			Console.Write( $" | rate = {(Timer.Elapsed.TotalMilliseconds / TotalIterations) * 1000}" );
//			Console.Write( $" | iter/sec = {(TotalIterations/Timer.ElapsedMilliseconds) * 1000}");
			Console.WriteLine( "" );

			Timer.Reset();
		}

		#endregion
	}
}