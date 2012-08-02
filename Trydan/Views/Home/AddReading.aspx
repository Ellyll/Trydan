<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Trydan.Reading>" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<h1>Add Reading</h1>
	<div>
		<% using( Html.BeginForm() ) { %>
			<label>Taken on:</label><input type="text" id="TakenOn" />
		<% } %>
	</div>
</body>
