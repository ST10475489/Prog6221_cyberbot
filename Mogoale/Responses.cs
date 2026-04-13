using System;

namespace Mogoale
{
    class Responses
    {
        //information for the chatbot to respond to the user input
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
            {
                return "bot: Im doing well, Thank you";
            }
            else if (input.Contains("whats your purpose"))
            {
                return "bot: helping users interact with services, answer questions, and perform tasks automatically";
            }
            else if (input.Contains("what can i ask you about"))
            {
                return "bot: anything related to cybersecurity or topics";
            }
            else if (input.Contains("topics"))
            {
                return "bot: you can ask about phishing, safe passwords, and links";
            }
            else if (input.Contains("safe password practices"))
            {
                return "bot: use long unique passwords and avoid personal info";
            }
            else if (input.Contains("phishing emails"))
            {
                return "bot: phishing emails try to steal your info. Be careful of links.";
            }
            else if (input.Contains("recognising suspicious links") || input.Contains("recognizing suspicious links"))
            {
                return "bot: check URLs carefully and avoid suspicious links";
            }
            else if (input.Contains("malware"))
            {
                return "bot: Install antivirus, don’t download unknown files from suspicious sources";
            }
            else if (input.Contains("ransomware"))
            {
                return "bot: Backup data, avoid suspicious downloads";
            }
            else if (input.Contains("trojan horse"))
            {
                return "bot: Download apps and information from official sites";
            }
            else if (input.Contains("password reuse"))
            {
                return "bot: Use different passwords per account, so not all accounts get hacked";
            }
            else if (input.Contains("lack of training"))
            {
                return "bot: Provide cybersecurity training";
            }
            else if (input.Contains("data breaches"))
            {
                return "bot: Encrypt data, monitor systems to stop unauthorized data access";
            }
            else if (input.Contains("viruses"))
            {
                return "bot: Install reputable antivirus software and Keep OS and apps updated";
            }
            else if (input.Contains("keyloggers"))
            {
                return "bot: Use password managers and Use virtual keyboards for banking";
            }
            else if (input.Contains("botnets"))
            {
                return "bot: Change default credentials so they dont automatically upload themselves";
            }
            else if (input.Contains("qr code phishing"))
            {
                return "bot: Preview QR URL before opening or Use a QR scanner with safety checks";
            }
            else if (input.Contains("evil twin attack"))
            {
                return "bot: Verify network names with staff to ensure its the correct network";
            }
            else if (input.Contains("wifi eavesdropping"))
            {
                return "bot: Avoid open Wi-Fi case they may be infected to steal your information";
            }
            else if (input.Contains("baiting"))
            {
                return "bot: Never plug in unknown USB devices to your devices";
            }
            else if (input.Contains("dark web monitoring"))
            {
                return "bot: Use dark web monitoring services and learn how stolen data is traded";
            
            }
            else if (input.Contains("sql injection"))
            {
                return "bot: Always use parameterized queries and never trust user input in your applications";
            }
            else if (input.Contains("xss"))
            {
                return "bot: Encode all output and implement a strict Content Security Policy on your website";
            }
            else if (input.Contains("ddos"))
            {
                return "bot: Use a DDoS protection service like Cloudflare and implement rate limiting on your servers";
            }
            else if (input.Contains("man in the middle"))
            {
                return "bot: Always use HTTPS and avoid connecting to public Wi-Fi without a VPN";
            }
            else if (input.Contains("phishing"))
            {
                return "bot: is a type of cyberattack where criminals trick individuals into revealing personal or financial information through deceptive messages or websites";
            }
            else if (input.Contains("credential stuffing"))
            {
                return "bot: Use a unique password for every account and enable MFA everywhere";
            }
            else if (input.Contains("zero day"))
            {
                return "bot: Use behavior-based security tools and keep all software updated to limit exposure";
            }
            else if (input.Contains("rootkit"))
            {
                return "bot: Use trusted boot mechanisms and regularly scan with rootkit detection tools";
            }
            else if (input.Contains("spear phishing"))
            {
                return "bot: Always verify unusual requests through a secondary channel before acting on them";
            }
            else if (input.Contains("smishing"))
            {
                return "bot: Never click links in unexpected text messages and verify senders by calling directly";
            }
            else if (input.Contains("vishing"))
            {
                return "bot: Hang up and call back on the official number if you receive a suspicious call";
            }
            else if (input.Contains("tailgating"))
            {
                return "bot: Always challenge unknown individuals in restricted areas and use access control systems";
            }
            else if (input.Contains("pretexting"))
            {
                return "bot: Verify identities rigorously and train staff never to disclose sensitive info without confirmation";
            }
            else if (input.Contains("shoulder surfing"))
            {
                return "bot: Use a privacy screen on your laptop and always lock your screen when stepping away";
            }
            else if (input.Contains("dumpster diving"))
            {
                return "bot: Shred all sensitive documents and wipe storage devices before disposal";
            }
            else if (input.Contains("deepfake"))
            {
                return "bot: Verify sensitive requests through a secondary channel and educate staff on deepfake risks";
            }
            else if (input.Contains("prompt injection"))
            {
                return "bot: Sanitize all inputs to AI systems and limit what actions an LLM can perform";
            }
            else if (input.Contains("supply chain attack"))
            {
                return "bot: Vet all third-party vendors carefully and maintain a software bill of materials";
            }
            else if (input.Contains("cryptojacking"))
            {
                return "bot: Monitor CPU usage for anomalies and use endpoint detection tools to catch rogue processes";
            }
            else if (input.Contains("lateral movement"))
            {
                return "bot: Segment your network and monitor east-west traffic for unusual activity";
            }
            else if (input.Contains("privilege escalation"))
            {
                return "bot: Apply the principle of least privilege and regularly audit user permissions";
            }
            else if (input.Contains("fileless malware"))
            {
                return "bot: Use behavior-based EDR tools and enable PowerShell script block logging";
            }
            else if (input.Contains("honeypot"))
            {
                return "bot: Deploy honeypots in key network areas to detect attackers probing your environment early";
            }
            else if (input.Contains("worm"))
            {
                return "bot: Patch your systems immediately and segment your network to stop worms from spreading";
            }
            else if (input.Contains("adware"))
            {
                return "bot: Install an ad blocker and only download software from reputable trusted sources";
            }
            else if (input.Contains("sim swapping"))
            {
                return "bot: Set a PIN on your carrier account and use an authenticator app instead of SMS for MFA";
            }
            else if (input.Contains("juice jacking"))
            {
                return "bot: Avoid public USB charging stations and carry your own power bank when travelling";
            }
            else if (input.Contains("dns spoofing"))
            {
                return "bot: Enable DNSSEC on your domain and use a trusted DNS resolver to prevent cache poisoning";
            }
            else if (input.Contains("session hijacking"))
            {
                return "bot: Always use HTTPS and regenerate session tokens after every login";
            }
            else if (input.Contains("safe browsing"))
            {
                return "bot:  helps protect over five billion devices every day by showing warnings to users when they attempt to navigate to dangerous sites or download dangerous files";
            }
            else if (input.Contains("password"))
            {
                return "bot: is a string of characters used to verify the identity of a user during the authentication process.";
            }
            else
            {
                return "bot: I don't recognize that topic. Try asking about Phishing, Malware, or Ransomware.";
            }
        
        }
    }
}
