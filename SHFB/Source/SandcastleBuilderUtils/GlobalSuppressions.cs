﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Security", "CA5392:Use DefaultDllImportSearchPaths attribute for P/Invokes", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.MicrosoftHelpViewer.UnsafeNativeMethods.RegOpenKeyEx(System.UIntPtr,System.String,System.UInt32,System.Int32,System.UIntPtr@)~System.Int32")]
[assembly: SuppressMessage("Security", "CA5392:Use DefaultDllImportSearchPaths attribute for P/Invokes", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.MicrosoftHelpViewer.UnsafeNativeMethods.RegQueryValueEx(System.UIntPtr,System.String,System.IntPtr,System.UInt32@,System.Text.StringBuilder,System.UInt32@)~System.Int32")]
[assembly: SuppressMessage("Performance", "CA1838:Avoid 'StringBuilder' parameters for P/Invokes", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.MicrosoftHelpViewer.UnsafeNativeMethods.RegQueryValueEx(System.UIntPtr,System.String,System.IntPtr,System.UInt32@,System.Text.StringBuilder,System.UInt32@)~System.Int32")]
[assembly: SuppressMessage("Security", "CA5392:Use DefaultDllImportSearchPaths attribute for P/Invokes", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.MicrosoftHelpViewer.UnsafeNativeMethods.RegCloseKey(System.UIntPtr)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.MicrosoftHelpViewer.HelpLibraryManagerException")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.ApiFilter.ConvertToString(System.Text.StringBuilder)")]
[assembly: SuppressMessage("Design", "CA1036:Override methods on comparable types", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.Utils.ApiFilter")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~P:SandcastleBuilder.Utils.DocumentationSource.SourceDescription")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.ConceptualContent.TopicCollection.MatchProjectFilesToTopics")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.ConceptualContent.TopicCollection.AddTopicsFromFolder(System.String,System.String,SandcastleBuilder.Utils.SandcastleProject)")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.ConceptualContent.TopicFile.ParseContent(System.Boolean)")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~P:SandcastleBuilder.Utils.FilePath.Exists")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.FilePath.ShouldSerializePath~System.Boolean")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.FilePath.GetHashCode~System.Int32")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.FolderPath.ShouldSerializePath~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1036:Override methods on comparable types", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.Utils.MSHelpKeyword")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.Utils.NamingMethod")]
[assembly: SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildProcess.Build")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildProcess.Build")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildProcess.ValidateDocumentationSources")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.Utils.BuildEngine.BuildProcess")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildProcess.LoadPlugIns")]
[assembly: SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.TransformText(System.String,System.Object[])~System.String")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.WarnOnMissingSourceContext~System.String")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.CodeSnippetGrouping~System.String")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.Locale~System.String")]
[assembly: SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.Copyright~System.String")]
[assembly: SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.CopyrightInfo~System.String")]
[assembly: SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.HtmlEncCopyrightInfo~System.String")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.SubstitutionTagReplacement.SdkLinkTarget~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.TaskRunner.TerminateProcessAndChildren(System.Diagnostics.Process)")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.XmlCommentsFile.LoadXmlComments")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.InheritedDocumentation.IndexedCommentsCache.LoadXmlCommentsFile(System.String)~System.Xml.XPath.XPathDocument")]
[assembly: SuppressMessage("Design", "CA1036:Override methods on comparable types", Justification = "<Pending>", Scope = "type", Target = "~T:SandcastleBuilder.Utils.ConceptualContent.TocEntry")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~P:SandcastleBuilder.Utils.SandcastleProject.ProjectPropertyCache")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.SandcastleProject.LoadProperties")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.SandcastleProject.DefaultBuildAction(System.String)~SandcastleBuilder.Utils.BuildAction")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.SandcastleProject.ReplacementValueFor(System.String)~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.MSBuild.PackageReferenceResolver.LoadPackageReferenceInfo(Microsoft.Build.Evaluation.Project,System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.MSBuild.PackageReferenceResolver.ResolvePackageReferencesInternal(System.Collections.Generic.IEnumerable{System.String})~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildAssemblerInternal.LoadComponent(System.Xml.XPath.XPathNavigator)~Sandcastle.Core.BuildAssembler.BuildComponent.BuildComponentCore")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.BuildProcess.ReportWarning(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "<Pending>", Scope = "member", Target = "~M:SandcastleBuilder.Utils.BuildEngine.TitleAndKeywordHtmlExtract.ParseFiles(System.String,System.String)")]
