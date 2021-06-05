using System.IO;
using System.Text;
using System.Windows.Forms;


namespace HideousWorks.CommonWorks
{
	public class TextBoxWriter : TextWriter
	{
		TextBox Target { get; }

		public override Encoding Encoding => Encoding.UTF8;

		public TextBoxWriter( TextBox textBox )
		{
			Target = textBox;
		}

		public override void Write( char value )
		{
			Target.AppendText( value.ToString() );
		}

		public override void Write( string value )
		{
			Target.AppendText( value );
		}
	}
}