﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NY.Dataverse.LINQPadDriver
{
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Metadata;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CDSTemplate : CDSTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Linq;
using Microsoft.PowerPlatform.Cds.Client;
using Microsoft.Crm.Sdk.Messages;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace ");
            
            #line 27 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Namespace));
            
            #line default
            #line hidden
            this.Write(".Entities\r\n{\r\n\t");
            
            #line 29 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
foreach (var entity in Metadata)
	{
            
            #line default
            #line hidden
            this.Write("\t\t[System.Runtime.Serialization.DataContractAttribute()]\r\n\t\t[Microsoft.Xrm.Sdk.Cl" +
                    "ient.EntityLogicalNameAttribute(\"");
            
            #line 32 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\tpublic partial class ");
            
            #line 33 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write(" : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, Syste" +
                    "m.ComponentModel.INotifyPropertyChanged\r\n\t\t{\r\n\t\r\n\t\t\tpublic ");
            
            #line 36 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write("() : \r\n\t\t\t\t\tbase(EntityLogicalName)\r\n\t\t\t{\r\n\t\t\t}\r\n\t\r\n\t\t\tpublic const string Entity" +
                    "LogicalName = \"");
            
            #line 41 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.LogicalName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\t\r\n\t\t\tpublic const string EntitySchemaName = \"");
            
            #line 43 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t\tpublic const string PrimaryIdAttribute = \"");
            
            #line 45 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.PrimaryIdAttribute));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t\tpublic const string PrimaryNameAttribute = \"");
            
            #line 47 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((entity.entityMetadata.PrimaryNameAttribute ?? "")));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\t\r\n\t\t\tpublic const string EntityLogicalCollectionName = \"");
            
            #line 49 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((entity.entityMetadata.LogicalCollectionName ?? "")));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\r\n\t\t\tpublic const int EntityTypeCode = ");
            
            #line 51 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.ObjectTypeCode));
            
            #line default
            #line hidden
            this.Write(@";
	
			public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
			public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
			private void OnPropertyChanged(string propertyName)
			{
				if ((this.PropertyChanged != null))
				{
					this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
				}
			}
	
			private void OnPropertyChanging(string propertyName)
			{
				if ((this.PropertyChanging != null))
				{
					this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
				}
			}
			");
            
            #line 72 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
foreach (var attribute in entity.entityMetadata.Attributes.Where(x=>(!x.IsLogical.GetValueOrDefault() || x.IsRetrievable.GetValueOrDefault()) && x.AttributeType != AttributeTypeCode.Virtual && x.AttributeType != AttributeTypeCode.CalendarRules))
			{
				var attributeType = GetTypeFromCode(attribute.AttributeType);
				var attributeName = attribute.SchemaName == entity.entityMetadata.SchemaName ? $"{attribute.SchemaName}1" : attribute.SchemaName;
			
            
            #line default
            #line hidden
            this.Write("\t\t\t\t");
            
            #line 77 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
if(attribute.LogicalName == entity.entityMetadata.PrimaryIdAttribute) 
				{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t[AttributeLogicalNameAttribute(\"");
            
            #line 79 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\t\t\t\tpublic Guid? ");
            
            #line 80 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tget\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\treturn this.GetAttributeValue<Guid?>(\"");
            
            #line 84 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\tset\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tthis.OnPropertyChanging(\"");
            
            #line 88 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\t\tthis.SetAttributeValue(\"");
            
            #line 89 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\", value);\r\n\t\t\t\t\t\t\tif (value.HasValue)\r\n\t\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\t\tbase.Id = value.Value;\r" +
                    "\n\t\t\t\t\t\t\t}\r\n\t\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\t\tbase.Id = System.Guid.Empty;\r\n\t\t\t\t\t\t\t}" +
                    "\r\n\t\t\t\t\t\t\tthis.OnPropertyChanged(\"");
            
            #line 98 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t\t[AttributeLogicalNameAttribute(\"");
            
            #line 101 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\t\t\t\tpublic override System.Guid Id\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tget\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tretu" +
                    "rn base.Id;\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\tset\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tthis.");
            
            #line 110 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 113 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
} else if(attributeType == "OptionSetValue") 
				{
				   var enumName = $"{entity.entityMetadata.SchemaName}_{attribute.SchemaName}";
				
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t[AttributeLogicalNameAttribute(\"");
            
            #line 117 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\t\t\t\tpublic virtual ");
            
            #line 118 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write("? ");
            
            #line 118 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\t[System.Diagnostics.DebuggerNonUserCode()]\r\n\t\t\t\t\t\tget\r\n\t\t\t\t\t\t{\r\n\t" +
                    "\t\t\t\t\t\treturn (");
            
            #line 123 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write("?)this.GetAttributeValue<OptionSetValue>(\"");
            
            #line 123 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")?.Value;\r\n\t\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 125 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
if(attribute.IsValidForUpdate == true || attribute.IsValidForCreate == true) 
				{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t[System.Diagnostics.DebuggerNonUserCode()]\r\n\t\t\t\t\t\tset\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tthis" +
                    ".OnPropertyChanging(\"");
            
            #line 130 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\t\tthis.SetAttributeValue(\"");
            
            #line 131 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\", value.HasValue ? new OptionSetValue((int)value) : null);\r\n\t\t\t\t\t\t\tthis.OnProper" +
                    "tyChanged(\"");
            
            #line 132 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 134 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 136 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
} else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t[AttributeLogicalNameAttribute(\"");
            
            #line 137 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")]\t\t\r\n\t\t\t\tpublic ");
            
            #line 138 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 138 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t{\r\n\t\t\t\t\tget\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\treturn this.GetAttributeValue<");
            
            #line 142 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeType));
            
            #line default
            #line hidden
            this.Write(">(\"");
            
            #line 142 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\")");
            
            #line 142 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.AttributeType == AttributeTypeCode.DateTime ? "?.ToLocalTime()" : ""));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 144 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
if(attribute.IsValidForUpdate == true || attribute.IsValidForCreate == true) 
				{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tset\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tthis.OnPropertyChanging(\"");
            
            #line 148 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t\tthis.SetAttributeValue(\"");
            
            #line 149 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.LogicalName));
            
            #line default
            #line hidden
            this.Write("\", value);\r\n\t\t\t\t\t\tthis.OnPropertyChanged(\"");
            
            #line 150 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t}\r\n\t\t\t\t");
            
            #line 152 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t\t}\r\n\t\t\t\t");
            
            #line 154 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 155 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t");
            
            #line 157 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("}\r\n\r\nnamespace ");
            
            #line 160 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
	using Entities;

	public static class QueryExtensions
	{
		public static XElement ToFetchXML(this IQueryable<object> linqQuery, CdsServiceClient _client)
		{
			var query = (QueryExpression)(linqQuery).Provider.GetType().InvokeMember(""GetQueryExpression"", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, linqQuery.Provider, new List<object> { linqQuery.Expression, false, false, null, null, null }.ToArray());
			var expressionToFetchXmlRequest = new QueryExpressionToFetchXmlRequest
			{
				Query = query
			};

			var organizationResponse = (QueryExpressionToFetchXmlResponse)_client.Execute(expressionToFetchXmlRequest);
			return XElement.Parse(organizationResponse.FetchXml);
		}	
	}
	
	");
            
            #line 179 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
foreach (var entity in Metadata)
	{
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 181 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
foreach (var optionMetadata in entity.optionMetadata)
		{
            
            #line default
            #line hidden
            this.Write("\t\t\t[System.Runtime.Serialization.DataContractAttribute()]\r\n\t\t\tpublic enum ");
            
            #line 184 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write("_");
            
            #line 184 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionMetadata.attributeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t{\r\n\t\t\t\t");
            
            #line 186 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
foreach (var option in optionMetadata.options)
				{
				
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t[System.Runtime.Serialization.EnumMemberAttribute()]\r\n\t\t\t\t\t");
            
            #line 190 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Label));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 190 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Value));
            
            #line default
            #line hidden
            this.Write(",\r\n\t\t\t\t");
            
            #line 191 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t}\t\t\t\r\n\t\t");
            
            #line 193 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 194 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\tpublic partial class ");
            
            #line 196 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TypeName));
            
            #line default
            #line hidden
            this.Write(" : OrganizationServiceContext\r\n\t{\r\n\t\t\r\n\t\t[System.Diagnostics.DebuggerNonUserCode(" +
                    ")]\r\n\t\tpublic ");
            
            #line 200 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TypeName));
            
            #line default
            #line hidden
            this.Write("(IOrganizationService client) : \r\n\t\t\t\tbase(client)\r\n\t\t{\r\n\t\t\tthis.DataverseClient " +
                    "= (CdsServiceClient)client;\r\n\t\t}\r\n\t\t");
            
            #line 205 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
 foreach (var entity in Metadata)
		{
		
            
            #line default
            #line hidden
            this.Write("\t\tpublic IQueryable<");
            
            #line 208 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 208 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t\t[System.Diagnostics.DebuggerNonUserCode()]\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn th" +
                    "is.CreateQuery<");
            
            #line 213 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.entityMetadata.SchemaName));
            
            #line default
            #line hidden
            this.Write(">();\r\n\t\t\t}\r\n\t\t}\r\n\t\t");
            
            #line 216 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic CdsServiceClient DataverseClient\r\n        {\r\n            get;\r\n       " +
                    "     private set;\r\n        }\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 226 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"

public string Namespace { get; set; }

public string TypeName { get; set; }

        
        #line default
        #line hidden
        
        #line 232 "D:\GitHub\LINQPad-CDS-DriverNY.CommonDataService.LINQPadDriver\src\CDSTemplate.tt"

string GetTypeFromCode(AttributeTypeCode? attributeTypeCode)
{
	var attributeType = "object";
	switch (attributeTypeCode)
	{
		case AttributeTypeCode.BigInt:
		case AttributeTypeCode.Integer:	
			attributeType = "int";
			break;
		case AttributeTypeCode.Boolean:
		case AttributeTypeCode.ManagedProperty:
			attributeType = "bool";
			break;
		case AttributeTypeCode.Customer:
		case AttributeTypeCode.Lookup:	
		case AttributeTypeCode.Owner:		
			attributeType = "EntityReference";
			break;
		case AttributeTypeCode.DateTime:
			attributeType = "DateTime?";
			break;
		case AttributeTypeCode.Decimal:
			attributeType = "decimal";
			break;
		case AttributeTypeCode.Double:
			attributeType = "double";
			break;
		case AttributeTypeCode.EntityName:
		case AttributeTypeCode.Memo:
		case AttributeTypeCode.String:	
			attributeType = "string";
			break;
		case AttributeTypeCode.Money:
			attributeType = "Money";
			break;
		case AttributeTypeCode.Picklist:
		case AttributeTypeCode.State:
		case AttributeTypeCode.Status:
			attributeType = "OptionSetValue";
			break;
		case AttributeTypeCode.Uniqueidentifier:
			attributeType = "Guid";
			break;
	}
	return attributeType;
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class CDSTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
