using InsaneHardwareMonitor.src.config;
using NetFwTypeLib;
using System;
using System.Linq;
using System.Reflection;

namespace InsaneHardwareMonitor.src.firewall
{
    class FirewallRule
    {

        private const string RULE_NAME = "Insane Hardware Monitor";

        public static void Create(Config config)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            INetFwRule2 existedRule = FindRule(firewallPolicy);
            if (IfExistsWithPort(existedRule, config.Port))
            {
                firewallPolicy.Rules.Remove(RULE_NAME);
                AddRule(firewallPolicy, config.Port);
            }
            else if (IfNotExists(existedRule))
            {
                AddRule(firewallPolicy, config.Port);
            }
        }

        private static INetFwRule2 FindRule(INetFwPolicy2 firewallPolicy)
        {
            return firewallPolicy.Rules.OfType<INetFwRule2>().ToList().Find(rule => RULE_NAME.Equals(rule.Name));
        }

        private static bool IfExistsWithPort(INetFwRule2 existedRule, string port)
        {
            return existedRule != null && !port.Equals(existedRule.LocalPorts);
        }

        private static bool IfNotExists(INetFwRule2 existedRule)
        {
            return existedRule == null;
        }

        private static void AddRule(INetFwPolicy2 firewallPolicy, string port)
        {
            var currentProfiles = firewallPolicy.CurrentProfileTypes;
            INetFwRule2 firewallRule = CreateRule(port, currentProfiles);
            firewallPolicy.Rules.Add(firewallRule);
        }

        private static INetFwRule2 CreateRule(string port, int currentProfiles)
        {
            INetFwRule2 firewallRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRule.Enabled = true;
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            firewallRule.Protocol = 6;
            firewallRule.LocalPorts = port;
            firewallRule.Name = RULE_NAME;
            //firewallRule.ApplicationName = Assembly.GetExecutingAssembly().Location;
            firewallRule.Profiles = currentProfiles;
            return firewallRule;
        }

    }
}
