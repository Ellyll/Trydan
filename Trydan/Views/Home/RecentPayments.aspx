<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Trydan.RecentPaymentsViewModel>" %>
<div class="payments">
 <table>
    <caption>Recent Payments</caption>
	<thead>
		<tr>
			<th class="paid_on">Paid On</th>
			<th class="amount">Amount</th>
		</tr>
	</thead>
	<tbody>
	<% foreach (var payment in Model.Payments) { %>
		<tr>
			<td class="paid_on"><%= payment.MadeOn.ToString() %></td>
			<td class="amount">£<%= Math.Round(payment.Amount, 2).ToString() %></td>
		</tr>
	<% } %>
	</tbody>
</table>
<div>