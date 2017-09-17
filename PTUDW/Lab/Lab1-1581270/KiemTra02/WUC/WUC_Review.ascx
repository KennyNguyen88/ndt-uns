<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_Review.ascx.cs" Inherits="KiemTra02.WUC.WUC_Review" %>
<h2>Review</h2>
<asp:LoginView ID="LoginViewReview" runat="server">
    <AnonymousTemplate>
        Please Login to write your comment
    </AnonymousTemplate>
    <LoggedInTemplate>
        <div class="form-horizontal">
            <!-- Multiple Radios (inline) -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="radios">Rating</label>
                <asp:RadioButtonList ID="RadioButtonListRating"
                    runat="server"
                    CssClass="starRating"
                    EnableTheming="false"
                    RepeatDirection="Horizontal"
                    RepeatLayout="Flow">
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>

                </asp:RadioButtonList>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="subject">Subject</label>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxSubject" runat="server" placeholder="Your Subject" CssClass="form-control input-md"></asp:TextBox>
                </div>
            </div>

            <!-- Textarea -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="comment">Comment</label>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxComment" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>

            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="send"></label>
                <div class="col-md-4">
                    <asp:Button ID="ButtonSend" runat="server" Text="Send" CssClass="btn btn-primary" OnClick="ButtonSend_Click" />
                </div>
            </div>
        </div>
    </LoggedInTemplate>
</asp:LoginView>

<div class="container">
    <div class="row">
        <div class="col-md-8">
            <h2 class="page-header">Comments</h2>
            <section class="comment-list">
                <asp:Repeater ID="RepeaterReview" runat="server" DataSourceID="SqlDataSourceReview">
                    <ItemTemplate>
                        <!-- First Comment -->
                        <article class="row">
                            <div class="col-md-2 col-sm-2 hidden-xs">
                                <figure class="thumbnail">
                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive" ImageUrl='<%# UserImagePath(Eval("Username").ToString()) %>' />
                                    <img   />
                                    <figcaption class="text-center"><%# Eval("Username") %></figcaption>
                                </figure>
                            </div>
                            <div class="col-md-10 col-sm-10">
                                <div class="panel panel-default arrow left">
                                    <div class="panel-body">
                                        <header class="text-left">
                                            <div class="comment-user"><i class="fa fa-user"></i><%# Eval("Subject") %></div>
                                            <time class="comment-date" datetime='<%# Eval("PostedDatetime") %>'><i class="fa fa-clock-o"></i><%# Eval("PostedDatetime") %></time>
                                        </header>
                                        <div class="comment-post">
                                            <p>
                                                <%# Eval("Comment") %>
                                            </p>
                                        </div>                                        
                                    </div>
                                </div>
                            </div>
                        </article>
                        <div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>                
            </section>
        </div>
    </div>
</div>



<asp:SqlDataSource ID="SqlDataSourceReview" runat="server" ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" SelectCommand="SELECT * FROM [Review] WHERE (([ProductId] = @ProductId) AND ([Approved] = @Approved))">
    <SelectParameters>
        <asp:QueryStringParameter Name="ProductId" QueryStringField="id" Type="Int32" />
        <asp:Parameter DefaultValue="True" Name="Approved" Type="Boolean" />
    </SelectParameters>
</asp:SqlDataSource>
