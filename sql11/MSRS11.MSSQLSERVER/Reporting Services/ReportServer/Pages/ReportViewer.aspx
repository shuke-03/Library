<%@ Register TagPrefix="RS" Namespace="Microsoft.ReportingServices.WebServer" Assembly="ReportingServicesWebServer" %>
<%@ Page Language="C#" AutoEventWireup="true" Inherits="Microsoft.ReportingServices.WebServer.ReportViewerPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
 <head id="headID" runat="server">
  <title><%= GetPageTitle() %></title>
 </head>
 <body style="margin: 0px; overflow: auto">
  <form style="width:100%;height:100%" runat="server" ID="ReportViewerForm">
   <asp:ScriptManager ID="AjaxScriptManager" AsyncPostBackTimeout="0" runat="server" />
   <RS:ReportViewerHost ID="ReportViewerControl" runat="server" />
  </form>
  <script language="javascript" type="text/javascript">
Sys.WebForms.PageRequestManager.prototype._destroyTree = function(element) {
    var allnodes = element.getElementsByTagName('*'),
        length = allnodes.length;
    var nodes = new Array(length);
    for (var k = 0; k < length; k++) {
        nodes[k] = allnodes[k];
    }
    for (var j = 0, l = nodes.length; j < l; j++) {
        var node = nodes[j];
        if (node.nodeType === 1) {
            if (node.dispose && typeof (node.dispose) === "function") {
                node.dispose();
            }
            else if (node.control && typeof (node.control.dispose) === "function") {
                node.control.dispose();
            }
            var behaviors = node._behaviors;
            if (behaviors) {
                behaviors = Array.apply(null, behaviors);
                for (var k = behaviors.length - 1; k >= 0; k--) {
                    behaviors[k].dispose();
                }
            }
        }
    }
}
  </script>
 </body>
</html>
