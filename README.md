# SharePoint Online. Site Collection Provisioning

### Summary ###
Solution for create site collections through a customization form using CSOM for Office 365 from provider hosted add-in. This solution based on examples [OfficeDev - Site Collection Provisioning](http://github.com/OfficeDev/PnP/blob/master/Samples/Provisioning.SiteCollectionCreation), [Self-Service Site Provisioning using Apps for SharePoint 2013](http://blogs.msdn.microsoft.com/richard_dizeregas_blog/2013/04/04/self-service-site-provisioning-using-apps-for-sharepoint-2013/)] and [Tenant extensions](https://github.com/OfficeDev/PnP-Sites-Core/tree/master/Core/OfficeDevPnP.Core/AppModelExtensions).

### Applies to ###
-  Office 365 Multi Tenant (MT)

### Solution ###
Solution | Author(s)
---------|----------
Provisioning.SiteCollectionCreation | Yuliia Afanasenko, Ivan Kalinichenko - Donetsk National University
 
### Version history ###
Version  | Date | Comments
---------| -----| --------
1.0  | March 30th 2016 (to update) | Initial release

### Disclaimer ###
**THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.**

----------

# Installation #
**To register by using AppRegNew.aspx**
  1. Navigate to http://SharePointWebsite/_layouts/15/AppRegNew.aspx on the tenancy.
  
      **AppRegNew page form**
      
      ![](https://i-msdn.sec.s-msft.com/dynimg/IC802667.png)
      
  2. Enter values for the follow form fields:
      - **Add-in ID** - Also known as client ID, is a GUID that can be generated (when you choose **Generate**) or **pasted** into AppRegNew.aspx. The value must be unique for each add-in, and must be lower case. The following is an example of an add-in client ID: **a5f89717-5ef9-4ee1-ac7c-5a6be65f5db7**.
      - **Add-in Secret** - Also known as the client secret, an opaque string. It is generated on the AppRegNew.aspx page by using the **Generate** button or **pasted**. The following is an example of an add-in secret: **7834cfGyPWrQITHSKRlhnrWzk2F6ZOUeml9h3v1znOg=**.
      - **Title** - A user-friendly title; for example, **Create Site add-in**. Users are prompted to grant or deny the add-in the permissions that the add-in is requesting. This title appears as the name of the add-in on the consent prompt.
      - **Add-in Domain** - The host name of the remote component of the SharePoint Add-in. If the remote application isn't using port 443, the add-in domain must also include the port number. The add-in domain must match the URL bindings you use for your web application. Do not include protocol ("https:") or "/" characters in this value. If your web application host is using a DNS CNAME alias, use the alias. Some examples: www.domain.com:3333, www.domain.com
      - **Redirect URI** - The endpoint in your remote application to which ACS sends an authentication code. The value must be a complete endpoint URL including the protocol, which must be HTTPS. For example: **https://www.domain.com/Pages/Default.aspx**
      
  3. Choose Create on the form. The page will reload and show a confirmation of the values you entered. Make a record of these values in a form that is eay to copy and paste. **If you need change default client ID and secret**, that you will need to enter the values in web.config and AppManifest.xml files or in the Visual StudioPublish wizard.Else, you can able to use the params from current solution.   

  4. Now you need to grant permissions to the add-in principal.  You will have to navigate to another page in SharePoint which is the **“_layouts/AppInv.aspx”**. This is where you will grant the application Tenant permissions. To do a lookup, you have to remember the client ID (also known as the add-in ID) that was used to register the add-in. The lookup returns the following information for a particular client ID.

```XML
<AppPermissionRequests AllowAppOnlyPolicy="true">
  <AppPermissionRequest Scope="http://sharepoint/content/tenant" Right="FullControl" />
</AppPermissionRequests>
```

**The Solution**
  1. Now go to the Visual Studio. Your solution will comprise of 2 projects:
	 - **App Project** – This is going to be deployed on the SharePoint.
	 - **AppWeb Project** – This is going to be the .Net Web Application. This application can be hosted on any IIS.
  2. Rebuild your solution in **Visual Studio**, which will restore the missing packages.
  3. Look on the **AppManifest.xml**. The **Start page** contains the virtual directory, path, and page name that will be deployed on the remote web.

**To update Web.config and AppManifest.xml**
  1. Copy the client ID and paste that in 2 places:
	 - **Web.Config File** – App Settings.
	 Also copy the client secret and paste in Web.Config File.

```XML
<appSettings>
	<add key="ClientId" value="1de402c2-911a-47f5-8b51-fd8b57144c41"/>
	<add key="ClientSecret" value="7Q1y02pvvWMBW7fzlAEnHsSGGATFWra1YEFCIo117sg="/>
</appSettings>
```
  - **AppManifest.xml** – AppPrincipal.
```XML
<AppPrincipal>
 <RemoteWebApplication ClientId="1de402c2-911a-47f5-8b51-fd8b57144c41" />
</AppPrincipal>
```
  2. After updating the ClientID, we can Rebuild the solution.

**To Publish Provider Hosted App**
  1. If you want to publish to the APPWeb in windows Azure, you need to create a site in windows azure account and download the publish profile. Than Publish the App Web (remote Web):  
     - Right click on **App web project** and click on **Publish**. It will open the window to select the publish target. In Publish Target window click on **Import**. It will prompt the window, where you can browse the profile which you have downloaded from Windows Azure site.
	
	 ![](http://2.bp.blogspot.com/-SkhecibFaI0/VFcpGUls9wI/AAAAAAAAAkQ/e1x0WZV2e6Q/s1600/9.png)

	 - Click on Ok. It will navigate you to the connection tab.

	 ![](http://4.bp.blogspot.com/-PEnOxCS4sms/VFco8n86BtI/AAAAAAAAAhY/4EiRilFIxFA/s1600/10.png)

	 - Click on **Validate Connection** it will validated the connection. Once validation completes you will get the green symbol beside the validate connection button. Click on **Publish**.

  ![](http://4.bp.blogspot.com/-_EGZX_B_Do4/VFco9b1t7BI/AAAAAAAAAh4/GUa8mlNY6yI/s1600/11.png)

	 - After **Publishing** it will navigate to the success page like below screen shot.

	 ![](http://2.bp.blogspot.com/-V0xwEMSdbKw/VFco-2PsTlI/AAAAAAAAAiI/FVF3a41mByI/s1600/14.png)
	  
  2. Right Click on the APP solution and click on publish you will navigate to the  below page.

	 ![](http://1.bp.blogspot.com/-kts0Pcnu__k/VFcpAms8uxI/AAAAAAAAAig/HqlBYZiiHRY/s1600/19.png)

	 - Click Edit and fill out the fields.
	 - Hit OK and then click Package the App. It builds the app package automatically.

**To add App to App Catalog**
 For an app to be consumed, it must be added to an app catalog.

	1. Navigate to the app catalog and select Apps for SharePoint.

	2. Select New App and upload the .app file produced from the last set of steps.

# Dependencies #

- Microsoft.Online.SharePoint.Client.Tenant
- Microsoft.SharePoint.Client.dll
- Microsoft.SharePoint.Client.Runtime.dll
- [OfficeDev - Site Collection Provisioning](http://github.com/OfficeDev/PnP/blob/master/Samples/Provisioning.SiteCollectionCreation)
- [Self-Service Site Provisioning using Apps for SharePoint 2013](http://blogs.msdn.microsoft.com/richard_dizeregas_blog/2013/04/04/self-service-site-provisioning-using-apps-for-sharepoint-2013/)]
- [Setting up provider hosted add-in to Windows Azure for Office365 tenant](http://blogs.msdn.com/b/vesku/archive/2013/11/25/setting-up-provider-hosted-app-to-windows-azure-for-office365-tenant.aspx)
