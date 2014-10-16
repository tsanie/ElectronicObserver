﻿using ElectronicObserver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Observer.kcsapi.api_req_nyukyo {

	public class speedchange : APIBase {


		public override void OnRequestReceived( Dictionary<string, string> data ) {

			KCDatabase.Instance.Docks[int.Parse( data["api_ndock_id"] )].LoadFromResponse( APIName, data );
			
			base.OnRequestReceived( data );
		}


		public override string APIName {
			get { return "api_req_nyukyo/speedchange"; }
		}

	}

}
