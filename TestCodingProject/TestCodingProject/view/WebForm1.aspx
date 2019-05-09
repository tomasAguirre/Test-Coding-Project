<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestCodingProject.view.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 207px;
		}
		.auto-style2 {
			width: 192px;
		}
		.auto-style3 {
			width: 145px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<span class="" title=""><span class="tlid-translation translation" lang="en">please fill out the employee form<br />
			<br />
			</span>P<span class="tlid-translation translation">lease insert the fisrt name :&nbsp;&nbsp; <span class="tlid-translation translation" lang="en">
			<input id="Text1" class="auto-style1" type="text" runat="server" /><br />
			<br />
			</span>Please insert the last name&nbsp;
			<input id="Text2" class="auto-style2" type="text" runat="server"/><br />
			<br />
			Please insert the phone number&nbsp;
			<input id="Text3" class="auto-style3" dir="ltr" type="text" runat="server"/><br />
			<br />
			Please insert the Zip&nbsp;
			<input id="Text4" type="text" runat="server"/><br />
			<br />
			Please insert the hire date
			<asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
			<br />
			</span><span class="tlid-translation translation" lang="en">
			<br />
			</span><span class="tlid-translation translation">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
			</span></span>
			<br />
			<br />
			<br />
			<br />
			<div>
				<asp:GridView ID="GridView1" runat="server"></asp:GridView>
			</div>			
        </div>
    </form>
</body>
</html>
