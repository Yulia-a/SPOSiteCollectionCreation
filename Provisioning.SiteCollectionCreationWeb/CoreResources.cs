﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso.Provisioning.SiteCollectionCreationWeb
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CoreResources
    {
        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OfficeDevPnP.Core.CoreResources", typeof(CoreResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Getting authentication context for &apos;{0}&apos;.
        /// </summary>
        internal static string AuthenticationManager_GetContext
        {
            get
            {
                return ResourceManager.GetString("AuthenticationManager_GetContext", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Tenant user &apos;{0}&apos;.
        /// </summary>
        internal static string AuthenticationManager_TenantUser
        {
            get
            {
                return ResourceManager.GetString("AuthenticationManager_TenantUser", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not determine lease for appOnlyAccessToken. Error = {0}.
        /// </summary>
        internal static string AuthenticationManger_ProblemDeterminingTokenLease
        {
            get
            {
                return ResourceManager.GetString("AuthenticationManger_ProblemDeterminingTokenLease", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Applying theme &apos;{0}&apos; in &apos;{1}&apos;.
        /// </summary>
        internal static string BrandingExtension_ApplyTheme
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_ApplyTheme", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Composed look &apos;{0}&apos; not found..
        /// </summary>
        internal static string BrandingExtension_ComposedLookMissing
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_ComposedLookMissing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating composed look &apos;{0}&apos; in &apos;{1}&apos;.
        /// </summary>
        internal static string BrandingExtension_CreateComposedLook
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_CreateComposedLook", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deploying masterpage &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string BrandingExtension_DeployMasterPage
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_DeployMasterPage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deploying page layout &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string BrandingExtension_DeployPageLayout
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_DeployPageLayout", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deploying theme &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        internal static string BrandingExtension_DeployTheme
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_DeployTheme", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Setting custom master URL &apos;{0}&apos; in &apos;{1}&apos;..
        /// </summary>
        internal static string BrandingExtension_SetCustomMasterUrl
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_SetCustomMasterUrl", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Setting master URL &apos;{0}&apos; in &apos;{1}&apos;..
        /// </summary>
        internal static string BrandingExtension_SetMasterUrl
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_SetMasterUrl", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating composed look &apos;{0}&apos; in &apos;{1}&apos;.
        /// </summary>
        internal static string BrandingExtension_UpdateComposedLook
        {
            get
            {
                return ResourceManager.GetString("BrandingExtension_UpdateComposedLook", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Destination file name is required..
        /// </summary>
        internal static string BrandingExtensions_UploadThemeFile_Destination_file_name_is_required_
        {
            get
            {
                return ResourceManager.GetString("BrandingExtensions_UploadThemeFile_Destination_file_name_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Source file path is required..
        /// </summary>
        internal static string BrandingExtensions_UploadThemeFile_Source_file_path_is_required_
        {
            get
            {
                return ResourceManager.GetString("BrandingExtensions_UploadThemeFile_Source_file_path_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument must be a single file name and cannot contain path characters..
        /// </summary>
        internal static string BrandingExtensions_UploadThemeFile_The_argument_must_be_a_single_file_name_and_cannot_contain_path_characters_
        {
            get
            {
                return ResourceManager.GetString("BrandingExtensions_UploadThemeFile_The_argument_must_be_a_single_file_name_and_ca" +
                        "nnot_contain_path_characters_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Url of the site is required..
        /// </summary>
        internal static string ClientContextExtensions_Clone_Url_of_the_site_is_required_
        {
            get
            {
                return ResourceManager.GetString("ClientContextExtensions_Clone_Url_of_the_site_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The passed argument is a zero-length string or contains only whitespace..
        /// </summary>
        internal static string Exception_Message_EmptyString_Arg
        {
            get
            {
                return ResourceManager.GetString("Exception_Message_EmptyString_Arg", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Activating feature {0} in site collection..
        /// </summary>
        internal static string FeatureExtensions_ActivateSiteCollectionFeature
        {
            get
            {
                return ResourceManager.GetString("FeatureExtensions_ActivateSiteCollectionFeature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Activating feature {0} in web..
        /// </summary>
        internal static string FeatureExtensions_ActivateWebFeature
        {
            get
            {
                return ResourceManager.GetString("FeatureExtensions_ActivateWebFeature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deactivating feature {0} in site collection..
        /// </summary>
        internal static string FeatureExtensions_DeactivateSiteCollectionFeature
        {
            get
            {
                return ResourceManager.GetString("FeatureExtensions_DeactivateSiteCollectionFeature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deactivating feature {0} in web..
        /// </summary>
        internal static string FeatureExtensions_DeactivateWebFeature
        {
            get
            {
                return ResourceManager.GetString("FeatureExtensions_DeactivateWebFeature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Problem with activation for feature id {0}. Error = {1}.
        /// </summary>
        internal static string FeatureExtensions_FeatureActivationProblem
        {
            get
            {
                return ResourceManager.GetString("FeatureExtensions_FeatureActivationProblem", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding field ({0}) to content type ({1})..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_AddField0ToContentType1
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_AddField0ToContentType1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Content type &apos;{0}&apos; ({1}) already exists; no changes made..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_ContentType01AlreadyExists
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_ContentType01AlreadyExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating content type &apos;{0}&apos; ({1})..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_CreateContentType01
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_CreateContentType01", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating document set &apos;{0}&apos;..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_CreateDocumentSet
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_CreateDocumentSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating field &apos;{0}&apos; ({1})..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_CreateField01
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_CreateField01", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to New Field as XML: {0}.
        /// </summary>
        internal static string FieldAndContentTypeExtensions_CreateFieldBase
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_CreateFieldBase", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; ({1}) already exists; no changes made..
        /// </summary>
        internal static string FieldAndContentTypeExtensions_Field01AlreadyExists
        {
            get
            {
                return ResourceManager.GetString("FieldAndContentTypeExtensions_Field01AlreadyExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument must be a single document set name and cannot contain path characters..
        /// </summary>
        internal static string FileFolderExtensions_CreateDocumentSet_The_argument_must_be_a_single_document_set_name_and_cannot_contain_path_characters_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_CreateDocumentSet_The_argument_must_be_a_single_document_set" +
                        "_name_and_cannot_contain_path_characters_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument must be a single folder name and cannot contain path characters..
        /// </summary>
        internal static string FileFolderExtensions_CreateFolder_The_argument_must_be_a_single_folder_name_and_cannot_contain_path_characters_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_CreateFolder_The_argument_must_be_a_single_folder_name_and_c" +
                        "annot_contain_path_characters_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating folder &apos;{0}&apos; under {1} &apos;{2}&apos;..
        /// </summary>
        internal static string FileFolderExtensions_CreateFolder0Under12
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_CreateFolder0Under12", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Folder URL is required..
        /// </summary>
        internal static string FileFolderExtensions_EnsureFolderPath_Folder_URL_is_required_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_EnsureFolderPath_Folder_URL_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Target folder does not exist in the web. Web: {0}, Folder: {1}.
        /// </summary>
        internal static string FileFolderExtensions_FolderMissing
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_FolderMissing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Target library does not exist in the web. Web: {0}, List: {1}.
        /// </summary>
        internal static string FileFolderExtensions_LibraryMissing
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_LibraryMissing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Update file &apos;{0}&apos;, change properties: {1}..
        /// </summary>
        internal static string FileFolderExtensions_UpdateFile0Properties1
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_UpdateFile0Properties1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Destination file name is required..
        /// </summary>
        internal static string FileFolderExtensions_UploadFile_Destination_file_name_is_required_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_UploadFile_Destination_file_name_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument must be a single file name and cannot contain path characters..
        /// </summary>
        internal static string FileFolderExtensions_UploadFile_The_argument_must_be_a_single_file_name_and_cannot_contain_path_characters_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_UploadFile_The_argument_must_be_a_single_file_name_and_canno" +
                        "t_contain_path_characters_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Uploading file &apos;{0}&apos; to folder &apos;{1}&apos;..
        /// </summary>
        internal static string FileFolderExtensions_UploadFile0ToFolder1
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_UploadFile0ToFolder1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument must be a single file name and cannot contain path characters..
        /// </summary>
        internal static string FileFolderExtensions_UploadFileWebDav_The_argument_must_be_a_single_file_name_and_cannot_contain_path_characters_
        {
            get
            {
                return ResourceManager.GetString("FileFolderExtensions_UploadFileWebDav_The_argument_must_be_a_single_file_name_and" +
                        "_cannot_contain_path_characters_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating list &apos;{0}&apos; from template {1}{2}..
        /// </summary>
        internal static string ListExtensions_CreateList0Template12
        {
            get
            {
                return ResourceManager.GetString("ListExtensions_CreateList0Template12", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0}; EXCEPTION: {{{1}}}.
        /// </summary>
        internal static string LoggingUtility_MessageWithException
        {
            get
            {
                return ResourceManager.GetString("LoggingUtility_MessageWithException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Mail message could not be sent. SMTP exception attempting to send. Error = {0}.
        /// </summary>
        internal static string MailUtility_SendException
        {
            get
            {
                return ResourceManager.GetString("MailUtility_SendException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Mail message could not be sent. Exception attempting to send email, rethrowing. Exception: {0}.
        /// </summary>
        internal static string MailUtility_SendExceptionRethrow0
        {
            get
            {
                return ResourceManager.GetString("MailUtility_SendExceptionRethrow0", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Mail message could not be sent. Send completed with error {0}..
        /// </summary>
        internal static string MailUtility_SendFailed
        {
            get
            {
                return ResourceManager.GetString("MailUtility_SendFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Mail message was canceled..
        /// </summary>
        internal static string MailUtility_SendMailCancelled
        {
            get
            {
                return ResourceManager.GetString("MailUtility_SendMailCancelled", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Code execution scope ended.
        /// </summary>
        internal static string PnPMonitoredScope_Code_execution_ended
        {
            get
            {
                return ResourceManager.GetString("PnPMonitoredScope_Code_execution_ended", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Code execution scope started.
        /// </summary>
        internal static string PnPMonitoredScope_Code_execution_started
        {
            get
            {
                return ResourceManager.GetString("PnPMonitoredScope_Code_execution_started", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating property {0}.
        /// </summary>
        internal static string PnPMonitoredScopeExtensions_LogPropertyUpdate_Updating_property__0_
        {
            get
            {
                return ResourceManager.GetString("PnPMonitoredScopeExtensions_LogPropertyUpdate_Updating_property__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not initialize AzureStorageConnector. Error = {0}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FailedToInitialize
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FailedToInitialize", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was deleted from Azure storage container {1}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileDeleted
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileDeleted", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from Azure storage container {1}. Error = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileDeleteFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileDeleteFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from Azure storage container {1} because it was not available.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileDeleteNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileDeleteNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} not found in Azure storage container {1}. Exception = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} retrieved from Azure storage container {1}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileRetrieved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileRetrieved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} saved to Azure storage container {1}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileSaved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileSaved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not saved to Azure storage container {1}. Error = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_Azure_FileSaveFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_Azure_FileSaveFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} deleted from folder {1}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileDeleted
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileDeleted", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from folder {1}. Error = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileDeleteFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileDeleteFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from folder {1} because it was not available.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileDeleteNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileDeleteNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} not found in directory {1}. Exception = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} retrieved from folder {1}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileRetrieved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileRetrieved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} saved to folder {1}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileSaved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileSaved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not saved to folder {1}. Error = {2}.
        /// </summary>
        internal static string Provisioning_Connectors_FileSystem_FileSaveFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_FileSystem_FileSaveFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} deleted from site {1}, library {2}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileDeleted
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileDeleted", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from site {1}, library {2}. Error = {3}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileDeleteFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileDeleteFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not deleted from site {1}, library {2} because it was not available.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileDeleteNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileDeleteNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} not found in site {1}, library  {2}. Exception = {3}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0}  found in site {1}, library  {2}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileRetrieved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileRetrieved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} saved to site {1}, library {2}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileSaved
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileSaved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File {0} was not saved to site {1}, library {2}. Error = {3}.
        /// </summary>
        internal static string Provisioning_Connectors_SharePoint_FileSaveFailed
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Connectors_SharePoint_FileSaveFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provisioning extensibility pipeline preparing to invoke, Assembly: {0}. Type {1}.
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_BeforeInvocation
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_BeforeInvocation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ClientContext is NULL. Unable to Invoke Extensibility Pipeline..
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_ClientCtxNull
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_ClientCtxNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to There was an exception invoking the custom extensibility provider. Assembly: {0}, Type: {1}. Exception {2}.
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_Exception
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_Exception", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provider.Assembly missing value. Unable to Invoke Extensibility Pipeline..
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_Missing_AssemblyName
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_Missing_AssemblyName", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provider.Type missing value. Unable to Invoke Extensibility Pipeline..
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_Missing_TypeName
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_Missing_TypeName", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provisioning extensibility pipline invocation successful, Assembly {0}, Type {1}.
        /// </summary>
        internal static string Provisioning_Extensibility_Pipeline_Success
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Extensibility_Pipeline_Success", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The Provisioning Template URI {0} is not valid..
        /// </summary>
        internal static string Provisioning_Formatter_Invalid_Template_URI
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Formatter_Invalid_Template_URI", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Downloading asset: {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ComposedLooks_DownLoadFile_Downloading_asset___0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ComposedLooks_DownLoadFile_Downloading_asset___0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Composed Look Information in Property Bag failed to deserialize. Falling back to detection of current composed look.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_ComposedLookInfoFailedToDeserialize
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_ComposedLookInfoFailedTo" +
                        "Deserialize", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating SharePointConnector.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Creating_SharePointConnector
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Creating_SharePointConne" +
                        "ctor", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieving current composed look.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Retrieving_current_composed_look
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Retrieving_current_compo" +
                        "sed_look", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Using Composed Look Information from Property Bag.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Using_ComposedLookInfoFromPropertyBag
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ComposedLooks_ExtractObjects_Using_ComposedLookInfoFr" +
                        "omPropertyBag", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding content type to template: {0} - {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Adding_content_type_to_template___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Adding_content_type_to_template___0_____" +
                        "1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding field {0} to content type.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Adding_field__0__to_content_type
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Adding_field__0__to_content_type", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Context web is subweb. Skipping content types..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Context_web_is_subweb__Skipping_content_types_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Context_web_is_subweb__Skipping_content_" +
                        "types_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating new Content Type: {0} - {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Creating_new_Content_Type___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Creating_new_Content_Type___0_____1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Content Type {0} with ID {1} cannot be updated because delta handling for DocumentSets is on hold..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_DocumentSet_DeltaHandling_OnHold
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_DocumentSet_DeltaHandling_OnHold", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Field {0} exists in content type.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Field__0__exists_in_content_type
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Field__0__exists_in_content_type", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Content Type {0} with ID {1} cannot be transformed into a DocumentSet.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_InvalidDocumentSet_Update_Request
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_InvalidDocumentSet_Update_Request", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Recreating existing Content Type: {0} - {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Recreating_existing_Content_Type___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Recreating_existing_Content_Type___0____" +
                        "_1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating existing Content Type: {0} - {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ContentTypes_Updating_existing_Content_Type___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ContentTypes_Updating_existing_Content_Type___0_____1" +
                        "_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding custom action &apos;{0}&apos; to scope Site.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Adding_custom_action___0___to_scope_Site
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Adding_custom_action___0___to_scope_Sit" +
                        "e", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding custom action &apos;{0}&apos; to scope Web.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Adding_custom_action___0___to_scope_Web
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Adding_custom_action___0___to_scope_Web" +
                        "", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding site scoped custom action &apos;{0}&apos; to template.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Adding_site_scoped_custom_action___0___to_template
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Adding_site_scoped_custom_action___0___" +
                        "to_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding web scoped custom action &apos;{0}&apos; to template.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Adding_web_scoped_custom_action___0___to_template
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Adding_web_scoped_custom_action___0___t" +
                        "o_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing site scoped custom action &apos;{0}&apos; from template because already available in base template.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Removing_site_scoped_custom_action___0___from_template_because_already_available_in_base_template
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Removing_site_scoped_custom_action___0_" +
                        "__from_template_because_already_available_in_base_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing web scoped custom action &apos;{0}&apos; from template because already available in base template.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_CustomActions_Removing_web_scoped_custom_action___0___from_template_because_already_available_in_base_template
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_CustomActions_Removing_web_scoped_custom_action___0__" +
                        "_from_template_because_already_available_in_base_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Calling extensibility callout {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ExtensibilityProviders_Calling_extensibility_callout__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ExtensibilityProviders_Calling_extensibility_callout_" +
                        "_0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Calling extensibility tokenprovider callout {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ExtensibilityProviders_Calling_tokenprovider_extensibility_callout__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ExtensibilityProviders_Calling_tokenprovider_extensib" +
                        "ility_callout__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Extensibility callout failed: {0} : {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ExtensibilityProviders_callout_failed___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ExtensibilityProviders_callout_failed___0_____1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Extensibility tokenprovider callout failed: {0} : {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ExtensibilityProviders_tokenprovider_callout_failed___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ExtensibilityProviders_tokenprovider_callout_failed__" +
                        "_0_____1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Extraction.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Extraction
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Extraction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Activating {0} scoped feature {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Features_Activating__0__scoped_feature__1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Features_Activating__0__scoped_feature__1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deactivating {0} scoped feature {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Features_Deactivating__0__scoped_feature__1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Features_Deactivating__0__scoped_feature__1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding field {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Adding_field__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Adding_field__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding field {0} to site.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Adding_field__0__to_site
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Adding_field__0__to_site", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Context web is subweb, skipping site columns.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Context_web_is_subweb__skipping_site_columns
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Context_web_is_subweb__skipping_site_columns", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Field {0} ({1}) exists but is of different type. Skipping field..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Field__0____1___exists_but_is_of_different_type__Skipping_field_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Field__0____1___exists_but_is_of_different_typ" +
                        "e__Skipping_field_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating field {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Updating_field__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Updating_field__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating field {0} in site.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Fields_Updating_field__0__in_site
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Fields_Updating_field__0__in_site", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding webpart &apos;{0}&apos; to page.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Files_Adding_webpart___0___to_page
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Files_Adding_webpart___0___to_page", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Uploading and overwriting existing file {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Files_Uploading_and_overwriting_existing_file__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Files_Uploading_and_overwriting_existing_file__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Uploading file {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Files_Uploading_file__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Files_Uploading_file__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to FINISH - Template Extraction.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_FinishExtraction
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_FinishExtraction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to FINISH - Provisioning.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_FinishProvisioning
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_FinishProvisioning", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding list: {0} - {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Adding_list___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Adding_list___0_____1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating field {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_field__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_field__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating field {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_field__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_field__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating list {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_list__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_list__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating list {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_list__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_list__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating view {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_view__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_view__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating view failed: {0} : {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Creating_view_failed___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Creating_view_failed___0_____1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to DraftVersionVisibility not applied because EnableModeration is not set to true.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_DraftVersionVisibility_not_applied_because_EnableModeration_is_not_set_to_true
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_DraftVersionVisibility_not_applied_beca" +
                        "use_EnableModeration_is_not_set_to_true", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Field {0} ({1}) exists in list {2} ({3}) but is of different type. Skipping field..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Field__0____1___exists_in_list__2____3___but_is_of_different_type__Skipping_field_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Field__0____1___exists_in_list__2____3_" +
                        "__but_is_of_different_type__Skipping_field_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Field schema has no ID attribute: {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Field_schema_has_no_ID_attribute___0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Field_schema_has_no_ID_attribute___0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Folder &apos;{0}&apos; already exists in parent folder &apos;{1}&apos;..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_FolderAlreadyExists
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_FolderAlreadyExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ID for field is not a valid Guid: {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_ID_for_field_is_not_a_valid_Guid___0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_ID_for_field_is_not_a_valid_Guid___0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to List {0} ({1}, {2}) exists but is of a different type. Skipping list..
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_List__0____1____2___exists_but_is_of_a_different_type__Skipping_list_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_List__0____1____2___exists_but_is_of_a_" +
                        "different_type__Skipping_list_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating field {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Updating_field__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Updating_field__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating field {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Updating_field__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Updating_field__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating list {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Updating_list__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Updating_list__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating list {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstances_Updating_list__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstances_Updating_list__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Data Rows.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstancesDataRows
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstancesDataRows", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating list item {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstancesDataRows_Creating_list_item__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstancesDataRows_Creating_list_item__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating listitem failed: {0} : {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstancesDataRows_Creating_listitem_failed___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstancesDataRows_Creating_listitem_failed___0___" +
                        "__1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Processing data rows for {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_ListInstancesDataRows_Processing_data_rows_for__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_ListInstancesDataRows_Processing_data_rows_for__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find lookup list with Id: {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_LookupFields_LookupTargetListLookupFailed__0
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_LookupFields_LookupTargetListLookupFailed__0", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Processing lookup fields failed: {0} : {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_LookupFields_Processing_lookup_fields_failed___0_____1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_LookupFields_Processing_lookup_fields_failed___0_____" +
                        "1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating new page {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Pages_Creating_new_page__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Pages_Creating_new_page__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating new page {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Pages_Creating_new_page__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Pages_Creating_new_page__0__failed___1_____2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Overwriting existing page {0}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Pages_Overwriting_existing_page__0_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Pages_Overwriting_existing_page__0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Overwriting existing page {0} failed: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Pages_Overwriting_existing_page__0__failed___1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Pages_Overwriting_existing_page__0__failed___1_____2_" +
                        "", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Persist Template Information.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_PersistTemplateInformation
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_PersistTemplateInformation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating new propertybag entry {0} with value {1}{2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_PropertyBagEntries_Creating_new_propertybag_entry__0__with_value__1__2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_PropertyBagEntries_Creating_new_propertybag_entry__0_" +
                        "_with_value__1__2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Overwriting existing propertybag entry {0} with value {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_PropertyBagEntries_Overwriting_existing_propertybag_entry__0__with_value__1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_PropertyBagEntries_Overwriting_existing_propertybag_e" +
                        "ntry__0__with_value__1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provisioning.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_Provisioning
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_Provisioning", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieve Template Info.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_RetrieveTemplateInfo
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_RetrieveTemplateInfo", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Site policy &apos;{0}&apos; applied to site.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_SitePolicy_PolicyAdded
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_SitePolicy_PolicyAdded", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Site policy &apos;{0}&apos; not found.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_SitePolicy_PolicyNotFound
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_SitePolicy_PolicyNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Add users failed for group &apos;{0}&apos;: {1} : {2}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_SiteSecurity_Add_users_failed_for_group___0_____1_____2_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_SiteSecurity_Add_users_failed_for_group___0_____1____" +
                        "_2_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Context web is subweb, skipping site security provisioning.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_SiteSecurity_Context_web_is_subweb__skipping_site_security_provisioning
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_SiteSecurity_Context_web_is_subweb__skipping_site_sec" +
                        "urity_provisioning", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Skipping label {0}, label is to set to default for language {1} while the default termstore language is also {1}.
        /// </summary>
        internal static string Provisioning_ObjectHandlers_TermGroups_Skipping_label__0___label_is_to_set_to_default_for_language__1__while_the_default_termstore_language_is_also__1_
        {
            get
            {
                return ResourceManager.GetString("Provisioning_ObjectHandlers_TermGroups_Skipping_label__0___label_is_to_set_to_def" +
                        "ault_for_language__1__while_the_default_termstore_language_is_also__1_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot process XML file {0}..
        /// </summary>
        internal static string Provisioning_Providers_XML_InvalidFileFormat
        {
            get
            {
                return ResourceManager.GetString("Provisioning_Providers_XML_InvalidFileFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error provisioning module &apos;{0}&apos; file &apos;{1}&apos;. Error = {2}.
        /// </summary>
        internal static string ProvisioningExtensions_ErrorProvisioningModule0File1
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ErrorProvisioningModule0File1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Path to the element file is required.
        /// </summary>
        internal static string ProvisioningExtensions_ProvisionElementFile_Path_to_the_element_file_is_required
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ProvisionElementFile_Path_to_the_element_file_is_required", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Provisioning Elements file &apos;{0}&apos;..
        /// </summary>
        internal static string ProvisioningExtensions_ProvisionElementFile0
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ProvisionElementFile0", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected element &apos;Elements&apos;..
        /// </summary>
        internal static string ProvisioningExtensions_ProvisionElementXml_Expected_element__Elements__
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ProvisionElementXml_Expected_element__Elements__", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected element &apos;File&apos;..
        /// </summary>
        internal static string ProvisioningExtensions_ProvisionFileInternal_Expected_element__File__
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ProvisionFileInternal_Expected_element__File__", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected element &apos;Module&apos;..
        /// </summary>
        internal static string ProvisioningExtensions_ProvisionModuleInternal_Expected_element__Module__
        {
            get
            {
                return ResourceManager.GetString("ProvisioningExtensions_ProvisionModuleInternal_Expected_element__Module__", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Something wrong happened while visiting securable object: {0}, details: {1}.
        /// </summary>
        internal static string SecurityExtensions_Error_VisitingSecurableObject
        {
            get
            {
                return ResourceManager.GetString("SecurityExtensions_Error_VisitingSecurableObject", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Visiting securable object: {0}.
        /// </summary>
        internal static string SecurityExtensions_Info_VisitingSecurableObject
        {
            get
            {
                return ResourceManager.GetString("SecurityExtensions_Info_VisitingSecurableObject", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Skip visiting the child securable objects for {0}, unique_permission_item_count = {1}, leaf_breadth_limit = {2}.
        /// </summary>
        internal static string SecurityExtensions_Warning_SkipFurtherVisitingForTooManyChildObjects
        {
            get
            {
                return ResourceManager.GetString("SecurityExtensions_Warning_SkipFurtherVisitingForTooManyChildObjects", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Service registration for {0} using endpoint {1} and cachekey {2} failed..
        /// </summary>
        internal static string Service_RegistrationFailed
        {
            get
            {
                return ResourceManager.GetString("Service_RegistrationFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Service requestor is not registered: access denied.
        /// </summary>
        internal static string Services_AccessDenied
        {
            get
            {
                return ResourceManager.GetString("Services_AccessDenied", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The cookie with the cachekey was not found...nothing can be retrieved from cache, so no clientcontext can be created..
        /// </summary>
        internal static string Services_CookieWithCachKeyNotFound
        {
            get
            {
                return ResourceManager.GetString("Services_CookieWithCachKeyNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Service {0} has been registered for endpoint {1} using cachekey {2}..
        /// </summary>
        internal static string Services_Registered
        {
            get
            {
                return ResourceManager.GetString("Services_Registered", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Token for cachekey {0} and hostweburl {1} has been refreshed..
        /// </summary>
        internal static string Services_TokenRefreshed
        {
            get
            {
                return ResourceManager.GetString("Services_TokenRefreshed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to OverwriteSystemPropertyBagValues is to true.
        /// </summary>
        internal static string SiteToTemplateConversion_ApplyRemoteTemplate_OverwriteSystemPropertyBagValues_is_to_true
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_ApplyRemoteTemplate_OverwriteSystemPropertyBagValues_is_" +
                        "to_true", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Base template available: {0}.
        /// </summary>
        internal static string SiteToTemplateConversion_Base_template_available___0_
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_Base_template_available___0_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to IncludeAllTermGroups is set to true.
        /// </summary>
        internal static string SiteToTemplateConversion_IncludeAllTermGroups_is_set_to_true
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_IncludeAllTermGroups_is_set_to_true", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to IncludeSiteCollectionTermGroup is set to true.
        /// </summary>
        internal static string SiteToTemplateConversion_IncludeSiteCollectionTermGroup_is_set_to_true
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_IncludeSiteCollectionTermGroup_is_set_to_true", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to MessagesDelegate registered.
        /// </summary>
        internal static string SiteToTemplateConversion_MessagesDelegate_registered
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_MessagesDelegate_registered", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to PersistComposedLookFiles is set to true.
        /// </summary>
        internal static string SiteToTemplateConversion_PersistComposedLookFiles_is_set_to_true
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_PersistComposedLookFiles_is_set_to_true", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ProgressDelegate registered.
        /// </summary>
        internal static string SiteToTemplateConversion_ProgressDelegate_registered
        {
            get
            {
                return ResourceManager.GetString("SiteToTemplateConversion_ProgressDelegate_registered", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating term &apos;{0}|{1}&apos; under parent &apos;{2}&apos;..
        /// </summary>
        internal static string TaxonomyExtension_CreateTerm01UnderParent2
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_CreateTerm01UnderParent2", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating term group &apos;{0}&apos; in term store &apos;{1}&apos;..
        /// </summary>
        internal static string TaxonomyExtension_CreateTermGroup0InStore1
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_CreateTermGroup0InStore1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating term set &apos;{0}&apos; in term group &apos;{1}&apos;..
        /// </summary>
        internal static string TaxonomyExtension_CreateTermSet0InGroup1
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_CreateTermSet0InGroup1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deleting term &apos;{0}|{1}&apos;..
        /// </summary>
        internal static string TaxonomyExtension_DeleteTerm01
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_DeleteTerm01", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error setting description for term group &apos;{0}&apos; ({1}). Error = {2}.
        /// </summary>
        internal static string TaxonomyExtension_ExceptionUpdateDescriptionGroup01
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ExceptionUpdateDescriptionGroup01", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error setting description for term set &apos;{0}&apos; ({1}). Error = {2}.
        /// </summary>
        internal static string TaxonomyExtension_ExceptionUpdateDescriptionSet01
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ExceptionUpdateDescriptionSet01", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error encountered during import when attempting to delete invalid term with id {0} on line {1}. Error = {2}.
        /// </summary>
        internal static string TaxonomyExtension_ImportErrorDeleteId0Line1
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ImportErrorDeleteId0Line1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error encountered during import. The description &apos;{0}&apos; on line {1} is not valid..
        /// </summary>
        internal static string TaxonomyExtension_ImportErrorDescription0Line1
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ImportErrorDescription0Line1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error encountered during import.  The name &apos;{0}&apos; is not valid on line {1}..
        /// </summary>
        internal static string TaxonomyExtension_ImportErrorName0Line1
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ImportErrorName0Line1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error encountered during import. The available for tagging entry on line {0} is not valid..
        /// </summary>
        internal static string TaxonomyExtension_ImportErrorTaggingLine0
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ImportErrorTaggingLine0", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Importing term set from file stream..
        /// </summary>
        internal static string TaxonomyExtension_ImportTermSet
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_ImportTermSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Term group &apos;{0}&apos; ID ({1}) does not match specified ID ({2})..
        /// </summary>
        internal static string TaxonomyExtension_TermGroup0Id1DoesNotMatchSpecifiedId2
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_TermGroup0Id1DoesNotMatchSpecifiedId2", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Term set &apos;{0}&apos; ID ({1}) does not match specified ID ({2})..
        /// </summary>
        internal static string TaxonomyExtension_TermSet0Id1DoesNotMatchSpecifiedId2
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtension_TermSet0Id1DoesNotMatchSpecifiedId2", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File path is required..
        /// </summary>
        internal static string TaxonomyExtensions_ImportTermSet_File_path_is_required_
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtensions_ImportTermSet_File_path_is_required_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid CSV format; was expecting a comma in the first (header) line..
        /// </summary>
        internal static string TaxonomyExtensions_ImportTermSetImplementation_Invalid_CSV_format__was_expecting_a_comma_in_the_first__header__line_
        {
            get
            {
                return ResourceManager.GetString("TaxonomyExtensions_ImportTermSetImplementation_Invalid_CSV_format__was_expecting_" +
                        "a_comma_in_the_first__header__line_", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ClientContext gets closed after action is completed. Calling ExecuteQuery again returns an error. Verify that you have an open ClientContext object. Error = {0}.
        /// </summary>
        internal static string TenantExtensions_ClosedContextWarning
        {
            get
            {
                return ResourceManager.GetString("TenantExtensions_ClosedContextWarning", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SetSiteLockState: Current: {0} Target: {1}.
        /// </summary>
        internal static string TenantExtensions_SetLockState
        {
            get
            {
                return ResourceManager.GetString("TenantExtensions_SetLockState", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not determine if site exists in tenant. Error = {0}.
        /// </summary>
        internal static string TenantExtensions_UnknownExceptionAccessingSite
        {
            get
            {
                return ResourceManager.GetString("TenantExtensions_UnknownExceptionAccessingSite", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Site {0} url/wildcard added.
        /// </summary>
        internal static string TimerJob_AddSite_Done
        {
            get
            {
                return ResourceManager.GetString("TimerJob_AddSite_Done", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Site url ({0}) contains invalid characters.
        /// </summary>
        internal static string TimerJob_AddSite_InvalidUrl
        {
            get
            {
                return ResourceManager.GetString("TimerJob_AddSite_InvalidUrl", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job authentication set to type App-Only with clientId {0}.
        /// </summary>
        internal static string TimerJob_Authentication_AppOnly
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_AppOnly", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job authentication set to type Azure AD App-Only with clientId {0} and certificate {1}.
        /// </summary>
        internal static string TimerJob_Authentication_AzureADAppOnly
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_AzureADAppOnly", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job authentication set to type NetworkCredentials with user {0} in domain {1}.
        /// </summary>
        internal static string TimerJob_Authentication_Network
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_Network", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job authentication set to type Office 365 with user {0}.
        /// </summary>
        internal static string TimerJob_Authentication_O365
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_O365", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieving credetials with name {0} from the Windows Credential Manager.
        /// </summary>
        internal static string TimerJob_Authentication_RetrieveFromCredMan
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_RetrieveFromCredMan", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve credential manager credentials with name {0} or retrieved credentials don&apos;t have user or password set.
        /// </summary>
        internal static string TimerJob_Authentication_RetrieveFromCredManFailed
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_RetrieveFromCredManFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Tenant admin site set to {0}..
        /// </summary>
        internal static string TimerJob_Authentication_TenantAdmin
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Authentication_TenantAdmin", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to All added sites are cleared.
        /// </summary>
        internal static string TimerJob_ClearAddedSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ClearAddedSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job {0} settings cloned to timer job {0}.
        /// </summary>
        internal static string TimerJob_Clone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Clone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timer job constructed with name {0}, version {1}.
        /// </summary>
        internal static string TimerJob_Constructor
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Constructor", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Work for site {0} done.
        /// </summary>
        internal static string TimerJob_DoWork_Done
        {
            get
            {
                return ResourceManager.GetString("TimerJob_DoWork_Done", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No event receiver connected to the TimerJobRun event.
        /// </summary>
        internal static string TimerJob_DoWork_NoEventHandler
        {
            get
            {
                return ResourceManager.GetString("TimerJob_DoWork_NoEventHandler", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Doing work for site {0}.
        /// </summary>
        internal static string TimerJob_DoWork_Start
        {
            get
            {
                return ResourceManager.GetString("TimerJob_DoWork_Start", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Enumeration credentials specified for on-premises enumeration with user {0} and demain {1}.
        /// </summary>
        internal static string TimerJob_Enumeration_Network
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Enumeration_Network", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No domain specified that can be used for site enumeration. Use the SetEnumerationNetworkCredentials method to provide credentials as app-only does not work with search.
        /// </summary>
        internal static string TimerJob_Enumeration_NoDomain
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Enumeration_NoDomain", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No password specified that can be used for site enumeration. Use the SetEnumeration... method to provide credentials as app-only does not work with search.
        /// </summary>
        internal static string TimerJob_Enumeration_NoPassword
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Enumeration_NoPassword", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No user specified that can be used for site enumeration. Use the SetEnumeration... method to provide credentials as app-only does not work with search.
        /// </summary>
        internal static string TimerJob_Enumeration_NoUser
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Enumeration_NoUser", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Enumeration credentials specified for Office 365 enumeration with user {0}.
        /// </summary>
        internal static string TimerJob_Enumeration_O365
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Enumeration_O365", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Eating exception {0} for site {1}.
        /// </summary>
        internal static string TimerJob_ExpandSite_EatException
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ExpandSite_EatException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ExpandSubSites set to {0}.
        /// </summary>
        internal static string TimerJob_ExpandSubSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ExpandSubSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Manage state set to {0}.
        /// </summary>
        internal static string TimerJob_ManageState
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ManageState", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to If you only want 1 thread then set the UseThreading property to false.
        /// </summary>
        internal static string TimerJob_MaxThread1
        {
            get
            {
                return ResourceManager.GetString("TimerJob_MaxThread1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to You cannot use more than 100 threads.
        /// </summary>
        internal static string TimerJob_MaxThread100
        {
            get
            {
                return ResourceManager.GetString("TimerJob_MaxThread100", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Number of threads must be between 2 and 100.
        /// </summary>
        internal static string TimerJob_MaxThreadLessThan1
        {
            get
            {
                return ResourceManager.GetString("TimerJob_MaxThreadLessThan1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to MaximumThreads set to {0}.
        /// </summary>
        internal static string TimerJob_MaxThreadSet
        {
            get
            {
                return ResourceManager.GetString("TimerJob_MaxThreadSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Calling the eventhandler for site {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_CallEventHandler
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_CallEventHandler", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Eventhandler called for site {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_CallEventHandlerDone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_CallEventHandlerDone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error during timerjob execution of site {0}. Exception message = {1}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_Error
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_Error", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timerjob for site {1}, PreviousRun = {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunRead
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunRead", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Set Timerjob for site {1}, PreviousRun to {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunSet
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timerjob for site {1}, PreviousRunSuccessful = {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunSuccessRead
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunSuccessRead", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Set Timerjob for site {1}, PreviousRunSuccessful to {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunSuccessSet
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunSuccessSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timerjob for site {1}, PreviousRunVersion = {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunVersionRead
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunVersionRead", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Set Timerjob for site {1}, PreviousRunVersion to {0}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PrevRunVersionSet
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PrevRunVersionSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timerjob properties read using key {0} for site {1}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PropertiesRead
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PropertiesRead", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Timerjob properties written using key {0} for site {1}.
        /// </summary>
        internal static string TimerJob_OnTimerJobRun_PropertiesSet
        {
            get
            {
                return ResourceManager.GetString("TimerJob_OnTimerJobRun_PropertiesSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Realm set to {0}.
        /// </summary>
        internal static string TimerJob_Realm
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Realm", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resolving sites done, sub sites have been expanded.
        /// </summary>
        internal static string TimerJob_ResolveSites_Done
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_Done", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resolving sites done, no expansion needed.
        /// </summary>
        internal static string TimerJob_ResolveSites_DoneNoExpansionNeeded
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_DoneNoExpansionNeeded", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expand subsites by launching a thread for each of the {0} work batches.
        /// </summary>
        internal static string TimerJob_ResolveSites_LaunchThreadPerBatch
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_LaunchThreadPerBatch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resolving wildcard site {0}.
        /// </summary>
        internal static string TimerJob_ResolveSites_ResolveSite
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_ResolveSite", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Done resolving wildcard site {0}.
        /// </summary>
        internal static string TimerJob_ResolveSites_ResolveSiteDone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_ResolveSiteDone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Done sequentially expanding all sites.
        /// </summary>
        internal static string TimerJob_ResolveSites_SequentialExpandDone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_SequentialExpandDone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resolving sites started.
        /// </summary>
        internal static string TimerJob_ResolveSites_Started
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_Started", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Start sequentially expanding all sites.
        /// </summary>
        internal static string TimerJob_ResolveSites_StartSequentialExpand
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_StartSequentialExpand", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Thread started to expand a batch of {0} sites.
        /// </summary>
        internal static string TimerJob_ResolveSites_ThreadLaunched
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_ThreadLaunched", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Done waiting for all site expanding threads.
        /// </summary>
        internal static string TimerJob_ResolveSites_ThreadsAreDone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_ResolveSites_ThreadsAreDone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to After calling the virtual ResolveAddedSites method. Current count of site url&apos;s = {0}.
        /// </summary>
        internal static string TimerJob_Run_AfterResolveAddedSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_AfterResolveAddedSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to After calling the virtual UpdateAddedSites method. Current count of site url&apos;s = {0}.
        /// </summary>
        internal static string TimerJob_Run_AfterUpdateAddedSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_AfterUpdateAddedSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Before calling the virtual ResolveAddedSites method. Current count of site url&apos;s = {0}.
        /// </summary>
        internal static string TimerJob_Run_BeforeResolveAddedSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_BeforeResolveAddedSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ready to start a thread for each of the {0} work batches.
        /// </summary>
        internal static string TimerJob_Run_BeforeStartWorkBatches
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_BeforeStartWorkBatches", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Before calling the virtual UpdateAddedSites method. Current count of site url&apos;s = {0}.
        /// </summary>
        internal static string TimerJob_Run_BeforeUpdateAddedSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_BeforeUpdateAddedSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Run of timer job has ended.
        /// </summary>
        internal static string TimerJob_Run_Done
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_Done", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Done processing the {0} work batches.
        /// </summary>
        internal static string TimerJob_Run_DoneProcessingWorkBatches
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_DoneProcessingWorkBatches", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Job does not have sites to process, bailing out.
        /// </summary>
        internal static string TimerJob_Run_NoSites
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_NoSites", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ready to process each of the {0} sites in a sequential manner.
        /// </summary>
        internal static string TimerJob_Run_ProcessSequentially
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_ProcessSequentially", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Done with sequentially processing each of the {0} sites.
        /// </summary>
        internal static string TimerJob_Run_ProcessSequentiallyDone
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_ProcessSequentiallyDone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Run of timer job has started.
        /// </summary>
        internal static string TimerJob_Run_Started
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_Started", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Thread launched for processing {0} sites.
        /// </summary>
        internal static string TimerJob_Run_ThreadLaunched
        {
            get
            {
                return ResourceManager.GetString("TimerJob_Run_ThreadLaunched", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SharePointVersion set to {0}.
        /// </summary>
        internal static string TimerJob_SharePointVersion
        {
            get
            {
                return ResourceManager.GetString("TimerJob_SharePointVersion", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SharePoint version must be 15 or 16.
        /// </summary>
        internal static string TimerJob_SharePointVersion_Versions
        {
            get
            {
                return ResourceManager.GetString("TimerJob_SharePointVersion_Versions", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to UseThreading set to {0}.
        /// </summary>
        internal static string TimerJob_UseThreading
        {
            get
            {
                return ResourceManager.GetString("TimerJob_UseThreading", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating web &apos;{0}&apos; with template &apos;{1}&apos;..
        /// </summary>
        internal static string WebExtensions_CreateWeb
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_CreateWeb", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Deleting web &apos;{0}&apos;..
        /// </summary>
        internal static string WebExtensions_DeleteWeb
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_DeleteWeb", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Installing sandbox solution &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string WebExtensions_InstallSolution
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_InstallSolution", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing app &apos;{0}&apos; instance {1}..
        /// </summary>
        internal static string WebExtensions_RemoveAppInstance
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_RemoveAppInstance", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Request access email addresses exceed 255 characters. Skipping: {0}.
        /// </summary>
        internal static string WebExtensions_RequestAccessEmailLimitExceeded
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_RequestAccessEmailLimitExceeded", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Site search error. Error = {0}.
        /// </summary>
        internal static string WebExtensions_SiteSearchUnhandledException
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_SiteSearchUnhandledException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing sandbox solution &apos;{0}&apos;..
        /// </summary>
        internal static string WebExtensions_UninstallSolution
        {
            get
            {
                return ResourceManager.GetString("WebExtensions_UninstallSolution", resourceCulture);
            }
        }
    }
}
