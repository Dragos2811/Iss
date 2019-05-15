<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

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
						<!-- registration form -->
						<form runat="server" class="sign__form">
							<a href="index.html" class="sign__logo">
								<img src="Style/img/logo.svg" alt="">
							</a>
                            <asp:Label ID="msgLabel" runat="server" Text="" ForeColor="Tomato"></asp:Label>
							<div class="sign__group">
                                <asp:TextBox runat="server" class="sign__input" id="name" placeholder="Name"></asp:TextBox>
							</div>

							<div class="sign__group">
                                <asp:TextBox runat="server" class="sign__input" id="email" placeholder="Email"></asp:TextBox>
							</div>

							<div class="sign__group">
								<asp:TextBox  runat="server" class="sign__input" id="password" placeholder="Pasword"></asp:TextBox>
							</div>

							<div class="sign__group sign__group--checkbox">
								<input id="remember" name="remember" type="checkbox" checked="checked">
								<label for="remember">I agree to the <a href="#">Privacy Policy</a></label>
							</div>
                            <asp:LinkButton ID="signUpBtn" runat="server" class="sign__btn" Text="Sign up" OnClick="signUpBtn_Click" />
							<span class="sign__text">Already have an account? <a href="login.aspx">Sign in!</a></span>
                            
						</form>
						<!-- registration form -->
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>

