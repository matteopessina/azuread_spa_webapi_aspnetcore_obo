// Enter Global Config Values & Instantiate MSAL Client application
// tenant Id for single tenant app
// authority https://stackoverflow.com/a/47323987
window.config = {
    clientID: '2845f347-270b-4695-a5f2-0ce39060156a',
    authority: 'https://login.microsoftonline.com/20558054-2a0b-4ee1-83b2-c8ba15d8c786',
    apiUrl: 'https://localhost:44351',
    apiScopes: ['api://65b0f32b-233b-4c04-a896-35e4f872fcad/access_as_user']
};