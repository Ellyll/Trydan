<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Trydan.RecentPaymentsViewModel>" %>
<div class="payments">
 <table>
    <caption>Recent Payments</caption>
	<thead>
		<tr>
			<th>Paid On</th>
			<th>Amount</th>
		</tr>
	</thead>
	<tbody>
	<% foreach (var payment in Model.Payments) { %>
		<tr>
			<td><%= payment.MadeOn.ToString() %></td>
			<td>£<%= Math.Round(payment.Amount, 2).ToString() %></td>
		</tr>
	<% } %>
	</tbody>
</table>
<div>