<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-GB" xml:lang="en-GB">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <meta name="description" content="A client-server MUDList system for AberMUDs. Download the client and run it for your own MUD a
nd you don't have to worry about keeping it up to date." />
  <meta name="keywords" content="Aber, AberMUD, AberMUDs, MUDList, MUD List, MUD, MUDs, Multi User Dungeon, AberMUD List, Aber MUD
List" />
  <link rel="stylesheet" href="/static/css/abermud.css" type="text/css" />
  <title><%= Html.Encode(ViewData["Title"]) %></title>
</head>
<body>
  <div id="headerContainer">
    <div id="header">
      <h1><img id="headerImage" src="/static/images/20081116-015-Castell-3-c.jpg" alt="" /><span class="maintitle">AberMUD</span><
span class="maintitlesubtitle">.info</span><br /><span class="subtitle">/mudlist</span></h1>
    </div>
    <div id="top_navigation">
      <ul>
        <li class="first"><a href="/">Home</a></li>
        <li><a href="list/">List</a></li>
        <li><a href="download/">Download</a></li>
        <li><a href="news/">News</a></li>
        <li><a href="contact/">Contact Us</a></li>
        <li><a href="links/">Links</a></li>
      </ul>
    </div>
  </div>
  <div id="bodyContainer">
    <div id="content">
<%= Html.Encode(ViewData["Body"]) %>
    </div>
  </div>
  <div id="footer">
    <p>Copyright &copy; 2011 Alfred S Nathan (Ellyll)</p>
  </div>
</body>
</html>
