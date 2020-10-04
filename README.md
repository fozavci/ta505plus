# TA505+ Adversary Simulation Resources

Larger organisations invest a fortune to their defence to protect the critical assets. However, the security assessments are generally designed to find vulnerabilities in these assets, not protecting the organisation or services. Adversary simulations are a response to this requirement, to analyse the organisation resilience against real life threat actors. The adversary simulations can be called as Red Team, Purple Team or External Penetration Tests based on their implementations. In addition, the financial regulation authorities require tier 1 and 2 level institutions to analyse their resilience using threat intelligence-led exercises outlined in their regulations such as CBEST  or TIBER-EU .  

As described in the Threat Actor Profile section, TA505 is a threat actor that is financially motivated, and actively targeting larger organisations in APAC area. Therefore, this exercise is designed to analyse the resilience of the financial institutions in Australia against TA505. The objectives of the exercise were getting unauthorised access to a financial application, and also stealing sensitive data from a production server. The Target Organisation section explains the target network and system design including an endpoint with fully updated Microsoft Windows 10, Microsoft Office 2019 and Windows Defender, but also legacy servers such as Microsoft Windows 2008 R2 and Ubuntu 14.04. Through this exercise, I planned to demonstrate that when a threat actor reasonably improves their tradecraft, they can break into highly secure systems and achieve their goals such as initiating a SWIFT money transfer, stealing sensitive financial year reports or product designs. 

TA505 threat actor uses open source and commercial software (illegally) in their past and present campaigns. Threat intelligence reports discussed in the profile only outlines the previous Tactics, Techniques and Procedures (TTPs) of the threat actor. I assumed that the threat actor may improve their tradecraft as the software they use already received several updates in time. As a result of this forecast, I named this exercise as TA505+ which includes some improvements but still aligned with TA505 TTPs. 

Since I targeted newest Windows operating system, I needed to develop a set of custom tradecrafts with defence evasions. The Tradecraft Development section describes the tools I developed such as Petaq Command and Control Server, Petaq Malware, a dropper which loads Petaq Malware, a renewed AMSI bypass, and an UAC bypass. I also used public and open source security tools to perform the attacks with known signatures as the threat actor eventually uses some known malicious software in a later stage of their attacks. The Weaponization section describes utilisation of these tools, challenges and solutions for the exercise. 

Finally, I recorded all kill chain phases and demonstrations to provide this exercise as a training as well. These recordings are presented in the Exercise Demonstrations. It’s suggested to watch relevant videos while reading the sections as the report may not have all technical details or data to reproduce the actions due to extensive actions demonstrated. In addition, I will keep a dedicated Github repository (https://github.com/fozavci/ta505plus) for this simulation for additional content and future updates. 


# Exercise Videos
TA505+ Adversary Simulation Video Playlist on YouTube<br>
https://www.youtube.com/playlist?list=PL-o-7RjmFOAUOBb_eZDL__9yM7YOMX-6c

# Tools
Petaq Purple Team Command & Control Server and Malware
https://github.com/fozavci/petaqc2

Ransoblin (Ransomware Bokoblin)
https://github.com/fozavci/ransoblin

Additional Resources (Office files, patches, samples)
https://github.com/fozavci/ta505plus (Resources)