﻿using OneNX.DesignPatten.SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.SimpleFactory.Model.Cellphone
{
	public class Huawei : ICellphone
	{
		public void Boot()
		{
			Console.WriteLine($"Huawei booting...");
		}
	}
}
