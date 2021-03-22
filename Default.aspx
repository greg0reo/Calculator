<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calc4._Default" %>
 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <div aria-atomic="True">


            <br />
            <asp:Label ID="Label1" runat="server" Text="Input 1"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="input1" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="input1" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">Must be an integer!</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="input1" ErrorMessage="RequiredFieldValidator" ForeColor="Blue">This is a required field</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Input 2"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="Input2" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="Input2" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">Must be an integer!</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Input2" ErrorMessage="RequiredFieldValidator" ForeColor="Blue">This is a required field</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Solve with C#" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            

            <br />
            <br />
            <br />
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />            








            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="redirect using Query String" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="redirect using Context Object" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <!--
            @foreach(var row in db.Query(selectQuesryString))
            <tr> 
            <td>@row.id</td> 
            <td>@row.username</td> 
            <td>@row.email</td>
            <td>@row.create_date</td>
            <td>@row.password</td>
            <td align="right">@row.last_name</td> 
            </tr> 
                -->

            <!--

                @{
var db = Database.Open("SmallBakery"); 
var selectQueryString = "SELECT * FROM Product ORDER BY Name"; 
}




                @foreach(var row in db.Query(selectQueryString))
{
<tr> 
<td>@row.Id</td> 
<td>@row.Name</td> 
<td>@row.Description</td> 
<td align="right">@row.Price</td> 
</tr> 
   }
                -->
            id:<br />
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            username:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            email:<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <br />
            create_date:<br />
            <asp:TextBox ID="create_date" runat="server"></asp:TextBox>
            <br />
            <br />
            password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            last_name:<br />
            <asp:TextBox ID="last" runat="server"></asp:TextBox>
            <br />
            <br />
            first_name:<br />
            <asp:TextBox ID="first" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="TEST BUTTON" />
            <br />
            <br />
            <br />
            <br />


        </div>
    </div>
    


</asp:Content>
