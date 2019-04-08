// Enter Global Config Values & Instantiate MSAL Client application
// tenant Id for single tenant app
// authority https://stackoverflow.com/a/47323987
window.config = {
    clientID: '61305af3-245c-4e39-b918-72f49d9a7527',
    authority: 'https://login.microsoftonline.com/organizations',
    apiUrl: 'https://localhost:44351',
    apiScopes: ['api://846d54ff-824b-41c6-b09d-ff9df8651c86/access_as_user']
};