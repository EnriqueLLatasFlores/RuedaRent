﻿namespace ACME.LearningCenter_Platform.IAM.Infrastructure.Pipeline.Attributes;

/**
 * This attribute is used to decorate controllers and actions that do not require authorization.
 * It skips authorization if action is decorated with [AllowAnonymous] attribute.
 */
[AttributeUsage(AttributeTargets.Method)]
public class AllowAnonymousAttribute : Attribute
{
}