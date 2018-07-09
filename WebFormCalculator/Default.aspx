<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormCalculator._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Calculator.css" rel="stylesheet" type="text/css" />
    <div class="calc_wrapper">
    <div>
        <asp:TextBox ID="txtDisplay" runat="server" class="calc_display" ReadOnly="True" MaxLength="25"></asp:TextBox>
    </div> 
    <div>
        <asp:Button ID="btnSeven" runat="server" Text="7" OnClick="btnSeven_Click" class="calc_button"/>
        <asp:Button ID="btnEight" runat="server" Text="8" OnClick="btnEight_Click" class="calc_button"/>
        <asp:Button ID="btnNine" runat="server" Text="9" OnClick="btnNine_Click" class="calc_button"/>
        <asp:Button ID="btnDivide" runat="server" Text="/" OnClick="btnDivide_Click" class="calc_button"/>

    </div>  
    <div>
        <asp:Button ID="btnFour" runat="server" Text="4" OnClick="btnFour_Click" class="calc_button"/>
        <asp:Button ID="btnFive" runat="server" Text="5" OnClick="btnFive_Click" class="calc_button"/>
        <asp:Button ID="btnSix" runat="server" Text="6" OnClick="btnSix_Click" class="calc_button"/>
        <asp:Button ID="btnMultiply" runat="server" Text="*" OnClick="btnMultiply_Click" class="calc_button"/>
    </div>  
    <div>
        <asp:Button ID="btnOne" runat="server" Text="1" OnClick="btnOne_Click" class="calc_button"/>
        <asp:Button ID="btnTwo" runat="server" Text="2" OnClick="btnTwo_Click" class="calc_button"/>
        <asp:Button ID="btnThree" runat="server" Text="3" OnClick="btnThree_Click" class="calc_button"/>
        <asp:Button ID="btnSubtract" runat="server" Text="-" OnClick="btnSubtract_Click" class="calc_button"/>
    </div>  
    <div>
        <asp:Button ID="btnDecimal" runat="server" Text="." OnClick="btnDecimal_Click" class="calc_button" />
        <asp:Button ID="btnZero" runat="server" Text="0" OnClick="btnZero_Click" class="calc_button"/>
        <asp:Button ID="btnEquals" runat="server" Text="=" OnClick="btnEquals_Click" class="calc_button"/>
        <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" class="calc_button"/>
    </div>
    <div>
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" class="calc_button calc_clear_button"/>
        <asp:Button ID="btnClearEntry" runat="server" Text="CE" OnClick="btnClearEntry_Click" class="calc_button calc_clear_button"/>
    </div> 
        </div>
</asp:Content>
