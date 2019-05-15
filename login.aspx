<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" Runat="Server">
    <div class="sign section--bg" data-bg="Style/img/section/section.jpg">
		<div class="container">
			<div class="row">
				<div class="col-12">
					<div class="sign__content">
						<!-- authorization form -->
						<form runat="server" class="sign__form">
							<a href="index.html" class="sign__logo">
								<img src="Style/img/logo.svg" alt="">
							</a>
                            <asp:Label ID="msgLabel" runat="server" Text="" ForeColor="Tomato"></asp:Label>
							<div class="sign__group">
								<asp:TextBox runat="server" class="sign__input" id="email" placeholder="Email"></asp:TextBox>
							</div>

							<div class="sign__group">
								<asp:TextBox  runat="server" class="sign__input" id="password" placeholder="Pasword"></asp:TextBox>
							</div>
                            <asp:LinkButton ID="signInBtn" runat="server" class="sign__btn" Text="Sign in" OnClick="signInBtn_Click" />
							<span class="sign__text">Don't have an account? <a href="register.aspx">Sign up!</a></span>

						</form>
						<!-- end authorization form -->
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>

