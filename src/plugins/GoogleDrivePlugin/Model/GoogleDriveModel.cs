namespace GoogleDrivePlugin.Model
{
    using System;

    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using Model.ClientSecret;

    using EditorPluginInterfaces;

    public class GoogleDriveModel
    {
        /// <summary>
        /// Value which should be used as root folder ID
        /// </summary>
        public const string RootFolderName = "root";

        /// <summary>
        /// Handles events connected with window state
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="info">Info about event</param>
        public delegate void OperationHandler(object sender, OperationProgressArgs info);

        /// <summary>
        /// State of import window was changed
        /// </summary>
        public event OperationHandler ImportWindowStatusChanged;

        /// <summary>
        /// State of export window was changed
        /// </summary>
        public event OperationHandler ExportWindowStatusChanged;

        /// <summary>
        /// Hanles events connected with file list on drive
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="args">Info about file list</param>
        public delegate void FileListHandler(object sender, FileListArgs args);

        /// <summary>
        /// Model received and handled list of files of some directory
        /// </summary>
        public event FileListHandler FileListReceived;

        /// <summary>
        /// Google username
        /// </summary>
        private string username;

        /// <summary>
        /// Model of WpfEditor
        /// </summary>
        private IModel editorModel;

        /// <summary>
        /// Application name
        /// </summary>
        private const string ApplicationName = "REALNET-GoogleDrivePlugin";

        /// <summary>
        /// Initialize new instance of GoogleDriveModel
        /// </summary>
        /// <param name="editorModel">WpfEditor model</param>
        public GoogleDriveModel(IModel editorModel)
        {
            this.editorModel = editorModel;
        }

        /// <summary>
        /// Logs user out of it's Google account
        /// </summary>
        public async Task LogUserOut()
        {
            this.RequestDownloadHide();
            this.RequestUploadHide();
        }

        /// <summary>
        /// Request upload window hide
        /// </summary>
        public void RequestUploadHide()
        {
            this.ExportWindowStatusChanged?.Invoke(
                this, 
                new OperationProgressArgs(OperationType.CloseWindow, this.username));
        }

        /// <summary>
        /// Request download window hide
        /// </summary>
        public void RequestDownloadHide()
        {
            this.ImportWindowStatusChanged?.Invoke(
                this, 
                new OperationProgressArgs(OperationType.CloseWindow, this.username));
        }


        /// <summary>
        /// Request new file creation on Drive
        /// </summary>
        /// <param name="parentID">ID of containing folder</param>
        /// <param name="fileName">Name of new file</param>
        /// <param name="mimeType">Type of new type (see Google Drive docs)</param>
        public async void CreateNewFile(string parentID, string fileName, string mimeType = null)
        {

        }

        /// <summary>
        /// Request new folder creation on Drive
        /// </summary>
        /// <param name="parentID">ID of containing folder</param>
        /// <param name="folderName">New folder name</param>
        public void CreateNewFolder(string parentID, string folderName)
        {
            this.CreateNewFile(parentID, folderName, "application/vnd.google-apps.folder");
        }

        /// <summary>
        /// Request item deletion on Drive
        /// </summary>
        /// <param name="parentID">ID of containing folder</param>
        /// <param name="itemID">ID of item to delete</param>
        public async void DeleteElement(string parentID, string itemID)
        {

        }

        /// <summary>
        /// Request item movement on drive
        /// </summary>
        /// <param name="sourceFolderID">ID of containing folder</param>
        /// <param name="itemID">ID of item</param>
        /// <param name="destFolderID">ID of folder to move to</param>
        public async void MoveElement(string sourceFolderID, string itemID, string destFolderID)
        {

        }

        /// <summary>
        /// Upload give model to Drive
        /// </summary>
        /// <param name="parentID">ID of containing folder</param>
        /// <param name="fileID">ID of file to upload model to</param>
        public async void SaveCurrentModelTo(string parentID, string fileID)
        {

        }

        /// <summary>
        /// Import model from Drive
        /// </summary>
        /// <param name="fileID">ID of file with model</param>
        public async void LoadModelFrom(string fileID)
        {

        }

        /// <summary>
        /// Request file list of folder on Drive
        /// </summary>
        /// <param name="folderID">ID of folder</param>
        public async Task RequestFolderContent(string folderID)
        {

        }

        /// <summary>
        /// Initialize connection with Drive
        /// </summary>
        private async Task InitiateNewSessionWithDrive()
        {

        }

        /// <summary>
        /// Get user's nickname from Google
        /// </summary>
        /// <param name="credential">User credentials</param>
        /// <returns>Username</returns>
        private static async Task<string> GetUserInfo()
        {
            return null;
        }
    }
}
