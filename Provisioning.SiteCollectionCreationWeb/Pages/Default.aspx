<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Contoso.Provisioning.SiteCollectionCreationWeb.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Почати новий сайт</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/AppStyles.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="../Scripts/app.js"></script>

    <script type="text/javascript"> 
        $(document).ready(function () { 
            var isDialog = decodeURIComponent(getQueryStringParameter('IsDlg')); 
            if (isDialog == '1') { 
                MakeSSCDialogPageVisible(); 
                UpdateSSCDialogPageSize(); 
            }
            $('.liSiteType').click(function () {
                $('.liSiteType').removeClass('ms-core-listMenu-selected');
                $(this).addClass('ms-core-listMenu-selected');
                $('#divBasePath').html($(this).attr('data-BasePath'));
                $('#hdnSelectedTemplate').val($(this).attr('data-Template'));
            });
        }); 
 
    </script> 
</head>
<body style="display: none; overflow: auto;">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableCdn="True" AsyncPostBackTimeout="2000" />
        <div id="divSPChrome"></div>
        <asp:UpdateProgress ID="progress" runat="server" AssociatedUpdatePanelID="update" DynamicLayout="true">
            <ProgressTemplate>
                <div id="divWaitingPanel" style="position: absolute; z-index: 3; background: rgb(255, 255, 255); width: 100%; bottom: 0px; top: 0px; margin-left: -180px; text-align: center;">
                    <div style="top: 40%; position: absolute; left: 50%; margin-left: -150px;">
                        <img alt="Працюємо над цим..." src="data:image/gif;base64,R0lGODlhEAAQAIAAAFLOQv///yH/C05FVFNDQVBFMi4wAwEAAAAh+QQFCgABACwJAAIAAgACAAACAoRRACH5BAUKAAEALAwABQACAAIAAAIChFEAIfkEBQoAAQAsDAAJAAIAAgAAAgKEUQAh+QQFCgABACwJAAwAAgACAAACAoRRACH5BAUKAAEALAUADAACAAIAAAIChFEAIfkEBQoAAQAsAgAJAAIAAgAAAgKEUQAh+QQFCgABACwCAAUAAgACAAACAoRRACH5BAkKAAEALAIAAgAMAAwAAAINjAFne8kPo5y02ouzLQAh+QQJCgABACwCAAIADAAMAAACF4wBphvID1uCyNEZM7Ov4v1p0hGOZlAAACH5BAkKAAEALAIAAgAMAAwAAAIUjAGmG8gPW4qS2rscRPp1rH3H1BUAIfkECQoAAQAsAgACAAkADAAAAhGMAaaX64peiLJa6rCVFHdQAAAh+QQJCgABACwCAAIABQAMAAACDYwBFqiX3mJjUM63QAEAIfkECQoAAQAsAgACAAUACQAAAgqMARaol95iY9AUACH5BAkKAAEALAIAAgAFAAUAAAIHjAEWqJeuCgAh+QQJCgABACwFAAIAAgACAAACAoRRADs=" style="width: 32px; height: 32px;" />
                        <span class="ms-accentText" style="font-size: 36px;">&nbsp;Будь ласка, зачекайте...<br/>Це займе декілька хвилин...</span>
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="update" runat="server" ChildrenAsTriggers="true" >
            <ContentTemplate>
                  <div style="width: 450px; margin-left:50px; ">    
                    <div id="inputField">                                             
                        <div id="divFieldTitle" style="display: table;">
                            <h3 class="ms-core-form-line">Назва сайту</h3>
                            <div class="ms-core-form-line">
                                <asp:TextBox ID="txtTitle" runat="server" CssClass="ms-fullWidth"></asp:TextBox>
                                <p class="ms-core-form-line descript">Назва буде відображатися на кожній сторінці цього сайту.</p>
                            </div>
                            <h3 class="ms-core-form-line">URL сайту</h3>
                            <div style="float: left; white-space: nowrap; padding-bottom: 10px; width: 450px;">
                                <div style="width: 320px; font-size: 13px; float: left; padding-top: 2px;" id="divBasePath">
                                    <asp:Label ID="lblBasePath" runat="server" ></asp:Label>
                                </div>
                                <div style="width: 130px; float: left;" >
                                    <asp:TextBox ID="txtUrl" runat="server" CssClass="ms-fullWidth"  OnTextChanged="ExistSite_TextChanged" AutoPostBack="true"></asp:TextBox>                              
                                    <asp:Label ID="ExistName" class="exist-name" runat="server"></asp:Label>
                                    <p class="ms-core-form-line descript url-desc">URL може містити тільки ці символи A-Z, a-z, 0-9</p>
                                </div> 
                            </div>
                        </div>
                        <h3 class="ms-core-form-line">Мова сайту</h3>
                        <div class="ms-core-form-line">
                            <asp:DropDownList ID="DropDownListLCID" runat="server">
                                <asp:ListItem Text="English" Value="1033"  />
                                <asp:ListItem Text="Русский" Value="1049" />
                                <asp:ListItem Text="Українська" Value="1058" Selected="True"/>
                            </asp:DropDownList>
                        </div>
                        <h3 class="ms-core-form-line">Шаблон сайту</h3>
                        <div class="ms-core-form-line">
                            <asp:ListBox ID="listSites" runat="server" CssClass="ms-fullWidth" onchange="OnWebTemplateChange()" Rows="8">
                                <asp:ListItem value="STS#0" Selected="True">Сайт групи</asp:ListItem>   
                                <asp:ListItem value="BLOG#0">Блог</asp:ListItem>
                                <asp:ListItem value="COMMUNITY#0">Сайт спільноти</asp:ListItem> 
                                <asp:ListItem value="PROJECTSITE#0">Сайт проекту</asp:ListItem>
                                <asp:ListItem value="BDR#0">Центр документів</asp:ListItem>  
                                <asp:ListItem value="COMMUNITYPORTAL#0">Портал спільноти</asp:ListItem>  
                                <asp:ListItem value="BLANKINTERNETCONTAINER#0">Портал публікації</asp:ListItem>
                                <asp:ListItem value="ENTERWIKI#0">Корпоративний вікі-сайт</asp:ListItem>   
                            </asp:ListBox>
                        </div>

                        <div class="ms-core-form-line HidDescription" id="HidDescription0" style="display:none"><p class="ms-core-form-line">Розташування для спільної роботи із групою людей.</p></div> 
                        <div class="ms-core-form-line HidDescription" id="HidDescription1" style="display:none"><p class="ms-core-form-line">Сайт, на якому особа чи група можуть публікувати ідеї, спостереження та професійні матеріали, які відвідувачі можуть коментувати.</p></div> 
                        <div class="ms-core-form-line HidDescription" id="HidDescription2" style="display:none"><p class="ms-core-form-line">Розташування, у якому учасники спільноти обговорюють цікаві для них теми. Учасники можуть шукати потрібний вміст, досліджуючи категорії, сортуючи дискусії за популярністю або переглядаючи лише ті дописи, які містять найкращі відповіді. Учасники отримують бали репутації за участь у спільноті, наприклад за початок дискусій і відповіді на них, додавання до дописів позначки ''Подобається'' та визначення найкращих відповідей.</p></div>
                        <div class="ms-core-form-line HidDescription" id="HidDescription3" style="display:none"><p class="ms-core-form-line">Сайт для керування проектом і співпраці над ним. Цей шаблон сайту поєднує в одному місці всі стани, зв’язки та артефакти, які стосуються проекту.</p></div>
                        <div class="ms-core-form-line HidDescription" id="HidDescription4" style="display:none"><p class="ms-core-form-line">Сайт для централізованого керування документами установи.</p></div>
                        <div class="ms-core-form-line HidDescription" id="HidDescription5" style="display:none"><p class="ms-core-form-line">Сайт для пошуку спільнот.</p></div>
                        <div class="ms-core-form-line HidDescription" id="HidDescription6" style="display:none"><p class="ms-core-form-line">Початкова ієрархія сайтів для великого порталу в інтрамережі або веб-сайту для Інтернету. Цей сайт можна легко настроювати за допомогою корпоративної символіки. Він містить домашню сторінку, зразок підсайту для прес-релізів, центр пошуку та сторінку входу. Зазвичай такий сайт має значно більше читачів, ніж кореспондентів, і використовується для публікації веб-сторінок із застосуванням робочих циклів затвердження.</p></div>
                        <div class="ms-core-form-line HidDescription" id="HidDescription7" style="display:none"><p class="ms-core-form-line">Сайт для публікування відомостей, які ви маєте та якими бажаєте поділитися зі співробітниками. Він надає можливість зручного редагування вмісту в одному розташуванні, співавторства, обговорення та керування проектами.</p></div>                   

                        <div id="divFieldDescription">
                            <h3 class="ms-core-form-line">Опис</h3>
                            <div class="ms-core-form-line" onclick="functionUrl">
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="ms-fullWidth" TextMode="MultiLine" Rows="2" ></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div id="finishWarning" style="display: none;">
                        <h1 class="ms-core-form-line">Сайт створено за посиланням </h1>
                        <asp:HyperLink ID="lblFullPath" CssClass="ms-accentText" style="font-size: 20px;" runat="server"  Target="_blank"></asp:HyperLink>
                    </div>
                    <div id="divButtons" style="float: right;">
                        <asp:Button ID="btnCreate" runat="server" Text="Створити" CssClass="ms-ButtonHeightWidth" OnClick="btnCreate_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Відмінити" CssClass="ms-ButtonHeightWidth" OnClick="btnCancel_Click" />
                    </div>                 
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", OnWebTemplateChange);
        function OnWebTemplateChange() {
            var index = document.getElementById("listSites").selectedIndex;
            if (typeof (index) != "undefined") {
                if (index >= 0) {
                    $('.HidDescription').css('display', 'none');
                    var idDescription = "HidDescription" + index;
                    if (document.getElementById(idDescription) != null) {
                        document.getElementById(idDescription).style.display = "block";
                    }
                }
            }
        }
    </script>
</body>
</html>
