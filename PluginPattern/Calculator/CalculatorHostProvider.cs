using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Calculator
{
    public class CalculatorHostProvider
    {
        private static HashSet<CalculatorHost> hosts;
        public static HashSet<CalculatorHost> Calculators
        {
            get
            {
                if (null == hosts)
                    Reload();

                return hosts;
            }
        }

        private static void Reload()
        {
            if (null == hosts)
                hosts = new HashSet<CalculatorHost>();
            else
                hosts.Clear();

            List<Assembly> plugInAssemblies = LoadPlugInAssemblies();
            List<ICalculator> plugIns = GetPlugIns(plugInAssemblies);

            foreach (ICalculator calc in plugIns)
            {
                hosts.Add(new CalculatorHost(calc));
            }
        }

        private static List<ICalculator> GetPlugIns(List<Assembly> plugInAssemblies)
        {
            List<Type> availableTypes = new List<Type>();

            foreach (Assembly currentAssembly in plugInAssemblies)
                availableTypes.AddRange(currentAssembly.GetTypes());

            // get a list of objects that implement the ICalculator interface AND 
            // have the CalculationPlugInAttribute
            List<Type> calculatorList = availableTypes.FindAll((Type t) =>
                {
                    List<Type> interfaceTypes = new List<Type>(t.GetInterfaces());
                    object[] arr = t.GetCustomAttributes(typeof(CalculationPlugInAttribute), true);
                    return !(arr == null || arr.Length == 0) && interfaceTypes.Contains(typeof(ICalculator));
                });

            // convert the list of Objects to an instantiated list of ICalculators
            return calculatorList.ConvertAll((Type t) =>
            {
                return Activator.CreateInstance(t) as ICalculator;
            });
        }

        private static List<Assembly> LoadPlugInAssemblies()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Plugins"));
            FileInfo[] files = dInfo.GetFiles("*.dll");
            List<Assembly> plugInAssemblyList = new List<Assembly>();

            if (null != files)
            {
                foreach (FileInfo file in files)
                {
                    plugInAssemblyList.Add(Assembly.LoadFile(file.FullName));
                }
            }

            return plugInAssemblyList;
        }
    }
}
