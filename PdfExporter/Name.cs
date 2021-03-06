// Name.cs
// Copyright (C) 2002 Shafqat Ahmed
// email	: raasiel@yahoo.com
// IM		: raasiel@hotmail.com
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.

// UPDATES
// 4 March 2002	:	Created the incode documentation

using System;
using System.IO;

namespace PDFLib.Objects.DataTypes
{
	/// <summary>
	/// Represents a name object accoring to PDF file spcification
	/// </summary>
	public class Name : Base
	{
		/// <summary>
		/// Simple constructor
		/// </summary>
		public Name() : base ()
		{
		}

		/// <summary>
		/// Creates a new Name object with the name
		/// </summary>
		/// <param name="name"></param>
		public Name(string name) : base (name)
		{
		}
		
		/// <summary>
		///  String representation of the name object
		/// </summary>
		/// <returns>Returns the string representation of the name object</returns>
		public override string ToString()
		{
			return "/" + base.ToString(); 
		}
				
		
	}
}
