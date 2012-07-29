<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Trydan.IndexViewModel>" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link rel="stylesheet" type="text/css" href="~/Content/css/abermud.css" />
	<title></title>
</head>
<body>
	<div>
		Payments: <%= Model.RecentPayments.Count() %>
		<% Html.RenderPartial("RecentPayments", new Trydan.RecentPaymentsViewModel(Model.RecentPayments)); %>
	</div>
</body>

