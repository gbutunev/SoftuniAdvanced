﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace L7_1to4_Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type type = Type.GetType(investigatedClass);
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(type, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");
            foreach (var field in fields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public);
            MethodInfo[] publicMethods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public);
            MethodInfo[] nonPublicMethods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();
            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (var method in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {type.Name}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");

            var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type type = Type.GetType(className);
            StringBuilder sb = new StringBuilder();

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic
                );

            foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
