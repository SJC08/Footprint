window._AMapSecurityConfig = {
    securityJsCode: 'c68019763999486713f65af69b812d37'
}

function createScene(theme) {
    scene = new L7.Scene({
        id: 'map',
        map: new L7.GaodeMap({
            style: theme,
            token: '3b9a8c37d8a26809a658bb8c59ce17a4'
        })
    });
}