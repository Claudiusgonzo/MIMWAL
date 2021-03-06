//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//      Copyright (c) Microsoft. All Rights Reserved.
//      Information Contained Herein is Proprietary and Confidential.
//      This code and the corresponding library can only be used if authorized by Microsoft.
// </copyright>
// <summary>
// Global Suppressions
// </summary>
//-----------------------------------------------------------------------------------------------------------------------
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

#region Namespaces Declarations

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assembly is delay signed.")]
