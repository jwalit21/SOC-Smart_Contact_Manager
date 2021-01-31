﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.GroupServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Group", Namespace="http://schemas.datacontract.org/2004/07/Backend_Service.Models")]
    [System.SerializableAttribute()]
    public partial class Group : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((this.GroupIdField.Equals(value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GroupContact", Namespace="http://schemas.datacontract.org/2004/07/Backend_Service.Models")]
    [System.SerializableAttribute()]
    public partial class GroupContact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContactId {
            get {
                return this.ContactIdField;
            }
            set {
                if ((this.ContactIdField.Equals(value) != true)) {
                    this.ContactIdField = value;
                    this.RaisePropertyChanged("ContactId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((this.GroupIdField.Equals(value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GroupServiceReference.IGroupService")]
    public interface IGroupService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroups", ReplyAction="http://tempuri.org/IGroupService/GetGroupsResponse")]
        WebClient.GroupServiceReference.Group[] GetGroups(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroups", ReplyAction="http://tempuri.org/IGroupService/GetGroupsResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group[]> GetGroupsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/AddGroup", ReplyAction="http://tempuri.org/IGroupService/AddGroupResponse")]
        WebClient.GroupServiceReference.Group1 AddGroup(WebClient.GroupServiceReference.Group1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/AddGroup", ReplyAction="http://tempuri.org/IGroupService/AddGroupResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> AddGroupAsync(WebClient.GroupServiceReference.Group1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroup", ReplyAction="http://tempuri.org/IGroupService/GetGroupResponse")]
        WebClient.GroupServiceReference.Group1 GetGroup(WebClient.GroupServiceReference.Group1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroup", ReplyAction="http://tempuri.org/IGroupService/GetGroupResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> GetGroupAsync(WebClient.GroupServiceReference.Group1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/UpdateGroup", ReplyAction="http://tempuri.org/IGroupService/UpdateGroupResponse")]
        WebClient.GroupServiceReference.Group1 UpdateGroup(WebClient.GroupServiceReference.Group1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/UpdateGroup", ReplyAction="http://tempuri.org/IGroupService/UpdateGroupResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> UpdateGroupAsync(WebClient.GroupServiceReference.Group1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/DeleteGroup", ReplyAction="http://tempuri.org/IGroupService/DeleteGroupResponse")]
        WebClient.GroupServiceReference.Group1 DeleteGroup(WebClient.GroupServiceReference.Group1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/DeleteGroup", ReplyAction="http://tempuri.org/IGroupService/DeleteGroupResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> DeleteGroupAsync(WebClient.GroupServiceReference.Group1 request);
        
        // CODEGEN: Generating message contract since the wrapper name (GroupContact) of message GroupContact does not match the default value (AddGroupContract)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/AddGroupContract", ReplyAction="http://tempuri.org/IGroupService/AddGroupContractResponse")]
        WebClient.GroupServiceReference.GroupContact1 AddGroupContract(WebClient.GroupServiceReference.GroupContact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/AddGroupContract", ReplyAction="http://tempuri.org/IGroupService/AddGroupContractResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> AddGroupContractAsync(WebClient.GroupServiceReference.GroupContact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroupContacts", ReplyAction="http://tempuri.org/IGroupService/GetGroupContactsResponse")]
        WebClient.GroupServiceReference.GroupContact[] GetGroupContacts(int GroupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/GetGroupContacts", ReplyAction="http://tempuri.org/IGroupService/GetGroupContactsResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact[]> GetGroupContactsAsync(int GroupId);
        
        // CODEGEN: Generating message contract since the wrapper name (GroupContact) of message GroupContact does not match the default value (DeleteGroupContact)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/DeleteGroupContact", ReplyAction="http://tempuri.org/IGroupService/DeleteGroupContactResponse")]
        WebClient.GroupServiceReference.GroupContact1 DeleteGroupContact(WebClient.GroupServiceReference.GroupContact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupService/DeleteGroupContact", ReplyAction="http://tempuri.org/IGroupService/DeleteGroupContactResponse")]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> DeleteGroupContactAsync(WebClient.GroupServiceReference.GroupContact1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Group", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Group1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int GroupId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int UserId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string Name;
        
        public Group1() {
        }
        
        public Group1(int GroupId, int UserId, string Description, string Name) {
            this.GroupId = GroupId;
            this.UserId = UserId;
            this.Description = Description;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GroupContact", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GroupContact1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int ContactId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int GroupId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int Id;
        
        public GroupContact1() {
        }
        
        public GroupContact1(int ContactId, int GroupId, int Id) {
            this.ContactId = ContactId;
            this.GroupId = GroupId;
            this.Id = Id;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGroupServiceChannel : WebClient.GroupServiceReference.IGroupService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupServiceClient : System.ServiceModel.ClientBase<WebClient.GroupServiceReference.IGroupService>, WebClient.GroupServiceReference.IGroupService {
        
        public GroupServiceClient() {
        }
        
        public GroupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebClient.GroupServiceReference.Group[] GetGroups(int userId) {
            return base.Channel.GetGroups(userId);
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group[]> GetGroupsAsync(int userId) {
            return base.Channel.GetGroupsAsync(userId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.Group1 WebClient.GroupServiceReference.IGroupService.AddGroup(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.AddGroup(request);
        }
        
        public void AddGroup(ref int GroupId, ref int UserId, ref string Description, ref string Name) {
            WebClient.GroupServiceReference.Group1 inValue = new WebClient.GroupServiceReference.Group1();
            inValue.GroupId = GroupId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Name = Name;
            WebClient.GroupServiceReference.Group1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).AddGroup(inValue);
            GroupId = retVal.GroupId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Name = retVal.Name;
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> AddGroupAsync(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.AddGroupAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.Group1 WebClient.GroupServiceReference.IGroupService.GetGroup(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.GetGroup(request);
        }
        
        public void GetGroup(ref int GroupId, ref int UserId, ref string Description, ref string Name) {
            WebClient.GroupServiceReference.Group1 inValue = new WebClient.GroupServiceReference.Group1();
            inValue.GroupId = GroupId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Name = Name;
            WebClient.GroupServiceReference.Group1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).GetGroup(inValue);
            GroupId = retVal.GroupId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Name = retVal.Name;
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> GetGroupAsync(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.GetGroupAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.Group1 WebClient.GroupServiceReference.IGroupService.UpdateGroup(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.UpdateGroup(request);
        }
        
        public void UpdateGroup(ref int GroupId, ref int UserId, ref string Description, ref string Name) {
            WebClient.GroupServiceReference.Group1 inValue = new WebClient.GroupServiceReference.Group1();
            inValue.GroupId = GroupId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Name = Name;
            WebClient.GroupServiceReference.Group1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).UpdateGroup(inValue);
            GroupId = retVal.GroupId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Name = retVal.Name;
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> UpdateGroupAsync(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.UpdateGroupAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.Group1 WebClient.GroupServiceReference.IGroupService.DeleteGroup(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.DeleteGroup(request);
        }
        
        public void DeleteGroup(ref int GroupId, ref int UserId, ref string Description, ref string Name) {
            WebClient.GroupServiceReference.Group1 inValue = new WebClient.GroupServiceReference.Group1();
            inValue.GroupId = GroupId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Name = Name;
            WebClient.GroupServiceReference.Group1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).DeleteGroup(inValue);
            GroupId = retVal.GroupId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Name = retVal.Name;
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.Group1> DeleteGroupAsync(WebClient.GroupServiceReference.Group1 request) {
            return base.Channel.DeleteGroupAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.GroupContact1 WebClient.GroupServiceReference.IGroupService.AddGroupContract(WebClient.GroupServiceReference.GroupContact1 request) {
            return base.Channel.AddGroupContract(request);
        }
        
        public void AddGroupContract(ref int ContactId, ref int GroupId, ref int Id) {
            WebClient.GroupServiceReference.GroupContact1 inValue = new WebClient.GroupServiceReference.GroupContact1();
            inValue.ContactId = ContactId;
            inValue.GroupId = GroupId;
            inValue.Id = Id;
            WebClient.GroupServiceReference.GroupContact1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).AddGroupContract(inValue);
            ContactId = retVal.ContactId;
            GroupId = retVal.GroupId;
            Id = retVal.Id;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> WebClient.GroupServiceReference.IGroupService.AddGroupContractAsync(WebClient.GroupServiceReference.GroupContact1 request) {
            return base.Channel.AddGroupContractAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> AddGroupContractAsync(int ContactId, int GroupId, int Id) {
            WebClient.GroupServiceReference.GroupContact1 inValue = new WebClient.GroupServiceReference.GroupContact1();
            inValue.ContactId = ContactId;
            inValue.GroupId = GroupId;
            inValue.Id = Id;
            return ((WebClient.GroupServiceReference.IGroupService)(this)).AddGroupContractAsync(inValue);
        }
        
        public WebClient.GroupServiceReference.GroupContact[] GetGroupContacts(int GroupId) {
            return base.Channel.GetGroupContacts(GroupId);
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact[]> GetGroupContactsAsync(int GroupId) {
            return base.Channel.GetGroupContactsAsync(GroupId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.GroupServiceReference.GroupContact1 WebClient.GroupServiceReference.IGroupService.DeleteGroupContact(WebClient.GroupServiceReference.GroupContact1 request) {
            return base.Channel.DeleteGroupContact(request);
        }
        
        public void DeleteGroupContact(ref int ContactId, ref int GroupId, ref int Id) {
            WebClient.GroupServiceReference.GroupContact1 inValue = new WebClient.GroupServiceReference.GroupContact1();
            inValue.ContactId = ContactId;
            inValue.GroupId = GroupId;
            inValue.Id = Id;
            WebClient.GroupServiceReference.GroupContact1 retVal = ((WebClient.GroupServiceReference.IGroupService)(this)).DeleteGroupContact(inValue);
            ContactId = retVal.ContactId;
            GroupId = retVal.GroupId;
            Id = retVal.Id;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> WebClient.GroupServiceReference.IGroupService.DeleteGroupContactAsync(WebClient.GroupServiceReference.GroupContact1 request) {
            return base.Channel.DeleteGroupContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.GroupServiceReference.GroupContact1> DeleteGroupContactAsync(int ContactId, int GroupId, int Id) {
            WebClient.GroupServiceReference.GroupContact1 inValue = new WebClient.GroupServiceReference.GroupContact1();
            inValue.ContactId = ContactId;
            inValue.GroupId = GroupId;
            inValue.Id = Id;
            return ((WebClient.GroupServiceReference.IGroupService)(this)).DeleteGroupContactAsync(inValue);
        }
    }
}
