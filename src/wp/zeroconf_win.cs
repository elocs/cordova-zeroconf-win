/*  
    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Resources;

namespace WPCordovaClassLib.Cordova.Commands
{
	public class Zeroconf_win : BaseCommand
    {
        public void browse(string options)
        {

            MessageDialog msgbox = new MessageDialog("Message Box is displayed");
            await msgbox.ShowAsync();

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "Everything went as planned, this is a result that is passed to the success handler."));
            return; 
        }
    }
}
