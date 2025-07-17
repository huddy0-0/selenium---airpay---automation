import requests
import json

# STEP 1: Authentication (Get Access Token)
AUTH_URL = "https://api.availity.com/v1/token"

# Replace with your actual credentials from Availity Developer Portal
CLIENT_ID = "1a64871f5162e10408b39e78f9e3020c"
CLIENT_SECRET = "63e60fe1cd8d0baff9ed02a6a8161ad0"

# Request payload for authentication
auth_payload = {
    "grant_type": "client_credentials",
    "client_id": CLIENT_ID,
    "client_secret": CLIENT_SECRET,
    "scope": "hipaa"
}

# Send the request
auth_response = requests.post(AUTH_URL, data=auth_payload)

# Check if authentication was successful
if auth_response.status_code == 200:
    access_token = auth_response.json().get("access_token")
    print("\n✅ Successfully authenticated! Access Token Retrieved.")
else:
    print("\n❌ Authentication Failed:", auth_response.json())
    exit()

# STEP 2: Make an API Request Using the Token
API_URL = "https://api.availity.com/availity/v1/coverages"

# Headers with the access token
headers = {
    "Authorization": f"Bearer {access_token}",
    "Content-Type": "application/x-www-form-urlencoded",
    "X-Api-Mock-Scenario-ID": "Coverages-Complete-i"  # Mock scenario
}

# Request payload for checking coverage
api_payload = {
    "payerId": "123",
    "providerNpi": "1234567893",
    "providerLastName": "Smith",
    "asOfDate": "1990-01-01",
    "serviceType[]": "30",
    "memberId": "ABC123",
    "patientBirthDate": "1985-07-15",
    "patientLastName": "Doe",
    "patientFirstName": "John",
    "patientGender": "M",
    "patientState": "FL",
    "subscriberRelationship": "18"
}

# Send API request
api_response = requests.post(API_URL, headers=headers, data=api_payload)

# STEP 3: Save Response to JSON File
if api_response.status_code == 200:
    print("\n✅ API Call Successful! Response saved to 'response.json'.")
    
    # Save response to a JSON file
    with open("response.json", "w") as json_file:
        json.dump(api_response.json(), json_file, indent=4)
    
    # Print a confirmation message
    print("\n📂 Response saved to 'response.json'!")
else:
    print("\n❌ API Call Failed:", api_response.json())
