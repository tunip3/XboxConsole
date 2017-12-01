// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.Adapter.October2014.XboxConsoleAdapter+Package", Justification = "This is a class that can be instantiated by a serializer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.Adapter.October2014.XboxConsoleAdapter+Application", Justification = "This is a class that can be instantiated by a serializer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.Adapter.October2014.XboxConsoleAdapter+PackageIdentity", Justification = "This is a class that can be instantiated by a serializer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "QFE", Target = "Commonly accepted Quick Fix Engineering abbreviation in the XDK release name.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.Adapter.October2014.XboxXdk")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.Adapter.October2014.XboxConsoleAdapter", Justification = "Resolving this issue will require hefty refactoring of the XboxConsoleAdapter design. This will time and this isn't at a critical level yet.")]
