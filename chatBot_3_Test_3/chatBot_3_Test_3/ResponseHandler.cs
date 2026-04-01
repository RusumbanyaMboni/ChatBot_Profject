// Improved responses and handling user input

using System;

class ResponseHandler
{
    static Random random = new Random();

    public static string GetResponse(string input, string name)
    {
        input = input.ToLower();

        

        if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
        {
            string[] greetings =
            {
                $"Hello {name}! How are you doing today?",
                $"Hi {name}! How can I help you stay safe online?",
                $"Hey {name}! How is it going?",
                $"Hello {name}! I'm here to help with cybersecurity awareness.",
                $"Hi {name}! Ready to learn how to stay safe online?"
            };
            return greetings[random.Next(greetings.Length)];
        }

        if (input.Contains("goodmorning") || input.Contains("morning"))
        {
            string[] morning =
            {
                $"Good morning {name}! How can I assist you today?",
                $"Morning {name}! Ready to learn about cybersecurity?",
                $"Good morning {name}! Stay safe online today.",
                "Morning! What cybersecurity topic interests you?"
            };
            return morning[random.Next(morning.Length)];
        }

        if (input.Contains("i am good") || input.Contains("i'm good") || input.Contains("doing well") || input.Contains("i am okay") || input.Contains("i'm okay") || input.Contains("doing great"))
        {
            string[] goodResponses =
            {
                $"That's great to hear {name}! How can I assist you with cybersecurity today?",
                $"Glad you're doing well {name}! What cybersecurity topic interests you?",
                "Awesome! Let's talk about how to stay safe online.",
                "Good to hear! Do you have any questions about cybersecurity?"
            };
            return goodResponses[random.Next(goodResponses.Length)];
        }

        if (input.Contains("how are you") || input.Contains("are you okay"))
        {
            string[] howAreYou =
            {
                "I'm functioning perfectly and ready to help.",
                "I'm doing great! Ready to assist you.",
                "All systems running smoothly!",
                "I'm doing well and ready to talk cybersecurity."
            };
            return howAreYou[random.Next(howAreYou.Length)];
        }

        if(input.Contains("who created you") || input.Contains("who built you"))
        {
            string[] creator =
            {
                "I was created by a cybersecurity experts and developer named Dieume Mboni (School name: RUSUMBANYA MBONI).",
                "I was developed by a dedicated developer named Dieume Mboni (School name: RUSUMBANYA MBONI) to improving online safety.",
                "My creator is Dieume Mboni (School name: RUSUMBANYA MBONI) ."
            };
            return creator[random.Next(creator.Length)];
        }

       



        if (input.Contains("virus and malware") || input.Contains("malware and virus"))
        {
            string[] virusAndMalware =
            {
                "A virus is a type of malware that can replicate itself and spread to other devices, while malware is a broader category of malicious software that includes viruses, spyware, ransomware, and more.",
                "Viruses are a specific type of malware that infects files and spreads, while malware encompasses all types of harmful software including viruses, worms, trojans, and ransomware.",
                "The main difference is that a virus can self-replicate and spread to other devices, while malware is any software designed to harm or exploit systems.",
                "Viruses are a subset of malware that specifically infects files and spreads, while malware includes all kinds of malicious software like viruses, spyware, and ransomware."
            };
            return virusAndMalware[random.Next(virusAndMalware.Length)];
        }

        if (input.Contains("phishing and hacking") || input.Contains("hacking and phishing"))
        {
            string[] phishingAndHacking =
            {
                "Phishing is a social engineering attack that tricks people into revealing sensitive information, while hacking is the act of gaining unauthorized access to systems or data.",
                "Phishing targets individuals to steal information through deception, while hacking involves breaking into systems to access or damage data.",
                "The main difference is that phishing relies on tricking people, while hacking involves technical methods to breach security.",
                "Phishing is a method of attack that uses deception to steal information, while hacking is the broader act of breaking into systems for various purposes."
            };
            return phishingAndHacking[random.Next(phishingAndHacking.Length)];
        }

        if (input.Contains("firewall and antivirus") || input.Contains("antivirus and firewall"))
        {
            string[] firewallAndAntivirus =
            {
                "A firewall is a network security device that monitors and controls incoming and outgoing network traffic based on predetermined security rules, while antivirus software is designed to detect and remove malicious software from a computer.",
                "Firewalls act as a barrier between a trusted internal network and untrusted external networks, while antivirus software scans for and eliminates viruses and other malware on individual devices.",
                "The main difference is that firewalls protect the network by filtering traffic, while antivirus software protects individual devices by detecting and removing malware.",
                "Firewalls are focused on controlling access to networks, while antivirus software is focused on identifying and removing malicious software from devices."
            };
            return firewallAndAntivirus[random.Next(firewallAndAntivirus.Length)];
        }

        if (input.Contains("strong password and weak password") || input.Contains("weak password"))
        {
            string[] strongAndWeakPassword =
            {
                "A strong password typically includes a mix of uppercase and lowercase letters, numbers, and special characters, while a weak password is often short and consists of common words or simple patterns.",
                "Strong passwords are more resistant to brute-force attacks, while weak passwords can be easily guessed or cracked by attackers.",
                "The main difference is that strong passwords are complex and unique, while weak passwords are simple and often reused.",
                "Strong passwords provide better security by being harder to guess, while weak passwords can put your accounts at risk."
            };
            return strongAndWeakPassword[random.Next(strongAndWeakPassword.Length)];
        }

        if (input.Contains("hacker and ethical hacker") || input.Contains("ethical hacker and hacker") || input.Contains("ethical hacker"))
        {
            string[] hackerAndEthicalHacker =
            {
                "A hacker is someone who gains unauthorized access to systems, while an ethical hacker is a cybersecurity professional who uses hacking skills to identify and fix security vulnerabilities with permission.",
                "Hackers can have malicious intent, while ethical hackers work to improve security by finding and addressing weaknesses in systems.",
                "The main difference is that hackers may break the law, while ethical hackers operate within legal boundaries to enhance cybersecurity.",
                "Hackers are often associated with cybercrime, while ethical hackers are respected professionals who help protect against cyber threats."
            };
            return hackerAndEthicalHacker[random.Next(hackerAndEthicalHacker.Length)];
        }

        if (input.Contains("malware and ransomware") || input.Contains("ransomware and malware"))
        {
            string[] malwareAndRansomware =
            {
                "Malware is a broad category of malicious software that includes viruses, worms, trojans, ransomware, and more, while ransomware is a specific type of malware that encrypts a victim's files and demands payment for the decryption key.",
                "Ransomware is a form of malware that specifically targets victims by encrypting their data and demanding a ransom, while malware encompasses all types of harmful software including ransomware.",
                "The main difference is that ransomware is designed to extort money from victims by holding their data hostage, while malware can have various purposes such as stealing information or damaging systems.",
                "Malware includes all kinds of malicious software like viruses and ransomware, while ransomware is a specific type of malware focused on extortion through encryption."
            };
            return malwareAndRansomware[random.Next(malwareAndRansomware.Length)];
        }

        if (input.Contains("encryption") && input.Contains("decryption"))
        {
            string[] encryptionAndDecryption =
            {
                "Encryption is the process of converting data into a coded format to prevent unauthorized access, while decryption is the process of converting the encrypted data back to its original form using a key.",
                "Encryption protects data by making it unreadable without the proper key, while decryption allows authorized users to access the original data.",
                "The main difference is that encryption secures data by encoding it, while decryption restores the original data from its encrypted form.",
                "Encryption and decryption are complementary processes where encryption secures data and decryption allows access to it."
            };
            return encryptionAndDecryption[random.Next(encryptionAndDecryption.Length)];
        }

        




        if (input.Contains("malware"))
        {
            string[] malware =
            {
                "Malware is malicious software designed to harm your computer.",
                "Malware can steal data, damage systems, or spy on users.",
                "Malware includes viruses, spyware, and ransomware.",
                "Malware is harmful software that infects your device."
            };
            return malware[random.Next(malware.Length)];
        }

        if (input.Contains("virus"))
        {
            string[] virus =
            {
                "A virus spreads and damages computer systems.",
                "Computer viruses infect files and spread to other devices.",
                "Viruses can slow down and damage your computer.",
                "A virus is harmful software that spreads automatically."
            };
            return virus[random.Next(virus.Length)];
        }

        if (input.Contains("phishing"))
        {
            string[] phishing =
            {
                "Phishing is when attackers trick you into revealing personal information.",
                "Phishing is a scam where fake emails or websites steal your data.",
                "Phishing attacks try to fool you into sharing passwords or bank details.",
                "Phishing usually comes as fake emails, links, or messages."
            };
            return phishing[random.Next(phishing.Length)];
        }

        if (input.Contains("firewall"))
        {
            string[] firewall =
            {
                "A firewall blocks unauthorized access to your system.",
                "Firewalls help protect networks from hackers.",
                "A firewall monitors incoming and outgoing traffic.",
                "Firewalls are an important layer of cybersecurity."
            };
            return firewall[random.Next(firewall.Length)];
        }

        if (input.Contains("hack") || input.Contains("hacking"))
        {
            string[] hacking =
            {
                "Hacking is gaining unauthorized access to systems.",
                "Hackers try to exploit vulnerabilities in systems.",
                "Hacking can lead to data theft or system damage.",
                "Ethical hackers help improve cybersecurity."
            };
            return hacking[random.Next(hacking.Length)];
        }

        if (input.Contains("hacker"))
        {
            string[] hacker =
            {
                "A hacker is someone who breaks into computer systems.",
                "Hackers can have malicious or ethical intentions.",
                "Hackers exploit weaknesses in security.",
                "Ethical hackers help protect against cyber threats."
            };
            return hacker[random.Next(hacker.Length)];
        }

        if (input.Contains("purpose") || input.Contains("what can you do"))
        {
            string[] purpose =
            {
                "My purpose is to help users understand cybersecurity.",
                "I'm here to help you stay safe online.",
                "I help users learn cybersecurity basics.",
                "I provide cybersecurity awareness and safety tips."
            };
            return purpose[random.Next(purpose.Length)];
        }

        if (input.Contains("cybersecurity") || input.Contains("cyber"))
        {
            string[] cybersecurity =
            {
                "Cybersecurity is the practice of protecting systems and data from cyber threats.",
                "Cybersecurity involves measures to safeguard computers and networks.",
                "Cybersecurity is important for keeping your information safe online.",
                "Cybersecurity helps prevent unauthorized access and cyber attacks."
            };
            return cybersecurity[random.Next(cybersecurity.Length)];
        }

        if (input.Contains("password"))
        {
            string[] password =
            {
                "Use strong passwords with letters, numbers, and symbols.",
                "Never share your password with anyone.",
                "Use different passwords for different accounts.",
                "A strong password protects your personal information."
            };
            return password[random.Next(password.Length)];
        }

        if (input.Contains("safe browsing") || input.Contains("browse safely"))
        {
            string[] safe =
            {
                "Always check URLs before clicking links.",
                "Avoid suspicious websites and downloads.",
                "Only download from trusted sources.",
                "Keep your browser updated for better security."
            };
            return safe[random.Next(safe.Length)];
        }

        if (input.Contains("learn") || input.Contains("teach"))
        {
            string[] learning =
            {
                $"Sure {name}! What would you like to learn about cybersecurity?",
                "I'd be happy to teach you cybersecurity basics.",
                "What cybersecurity topic interests you?",
                "Let's learn how to stay safe online."
            };
            return learning[random.Next(learning.Length)];
        }

        if (input.Contains("what is my name") || input.Contains("what's my name") || input.Contains("do you know my name"))
        {
            string[] myName =
            {
                $"Your name is {name}.",
                $"I know your name is {name}.",
                $"You told me your name is {name}.",
                $"Your name is {name}, nice to meet you!"
            };
            return myName[random.Next(myName.Length)];
        }

        if (input.Contains("difference") || input.Contains("compare"))
        {
            string[] compare =
            {
                "What would you like me to compare?",
                "Which two cybersecurity topics would you like to know the difference between?",
                "Please tell me the two things you want me to compare.",
                "I can compare cybersecurity topics. What would you like to compare?"
            };
            return compare[random.Next(compare.Length)];
        }

        



        string[] unknown =
        {
            $"I didn't quite understand that {name}. Could you rephrase?",
            $"I'm not sure I understand {name}. Try asking about cybersecurity.",
            $"Can you rephrase your question {name}?",
            $"I'm still learning {name}. Try asking about passwords or phishing."
        };

        return unknown[random.Next(unknown.Length)];
    }
}
