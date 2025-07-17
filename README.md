# Selenium + Availity API Automation

This project showcases automation of:
1. Insurance eligibility checks via the Availity API (Python).
2. Dental provider registration via Selenium and Google Sheets (C#).

##  Availity API Project
Located in `availity-api/`  
- `availity_api.py` authenticates and makes coverage requests.  
- `response.json` is a sample of the returned insurance data.  
- `Availity-Success.txt` contains command-line test history.

##  Dental Registration Automation
Located in `dental-registration/`  
- `Program.cs` pulls data from Google Sheets to fill a registration form.  
- `version1-code.txt` is the original hardcoded script.  
- Requires Selenium and ChromeDriver.

 **Note:** Sensitive keys in `.json` files are excluded for security.

---