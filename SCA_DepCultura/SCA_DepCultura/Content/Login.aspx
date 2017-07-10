<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SCA_DepCultura.Content.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar Sesion</title>    
    <script src="../Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery-3.2.1.min.js" type="text/javascript"></script>
    <link href="../Styles/loginStyle.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login">
<div class="conteiner">
<div class="row">
	<div id="formLogin" class="col-md-4 no-float"></div>
	<div id="formulario" class="col-md-4 no-float text-center" >
		<h1 class="title ">Iniciar sesion</h1>
		<div class="formularios">
            <asp:TextBox ID="txtUser" runat="server" class="form-control" placeholder="Usuario" ></asp:TextBox>
			<asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Contrasena" ></asp:TextBox>
			
		</div>
		<div class="text-left">
			<label>
			<input type="checkbox" name="checkMe" > Recordarme
			</label>
            
		</div>
		 <asp:Button ID="btEnter" runat="server" Text="Entrar" 
            class="btn btn-default normal" onclick="btEnter_Click" />
    </div>
	<div class="col-md-4 no-float" ></div>

</div>	
</div>	
</div>
    </form>
</body>

</html>
