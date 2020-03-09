<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mostrar</title>
     <meta charset="UTF-8">
    <meta name="description" content="ASP.NET MVC 2 CRUD Video">
    <meta name="Keywords" content="ASP.NET, MVC, FACPYA">
    <meta name="Author" content="Fernando Enrique Mascorro Garcia">
    <meta name="viewport" content="width=Device-width,Initial-scale=1.0">
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
 <a href="/Home/Index">Menu de Videos</a>
      <h1>Lista de videos</h1>

      Hay <%:  ((System.Data.DataTable)ViewData ["DataVideo"]).Rows.Count %> video
      <hr />

      <%
          foreach (System.Data.DataRow video in ((System.Data.DataTable)ViewData["DataVideo"]).Rows)
          { %>


         <p>id: <%:video["idVideo"].ToString()%> </p>
         <p>Titulo: <%:video["titulo"].ToString()%> </p>
         <iframe width="560" height="315" src="<%: video["url"].ToString() %>" 
         frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
          <p> Reproducciones: <%:video["repro"].ToString()%> </p>


        
          <%
          }
          
         %>





    <div>
    





    </div>
</body>
</html>
