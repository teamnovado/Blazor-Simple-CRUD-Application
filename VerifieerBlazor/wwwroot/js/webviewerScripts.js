window.webviewerFunctions = {
	initWebViewer: function () {
		const viewerElement = document.getElementById('viewer');
		WebViewer({
			path: 'lib',
			initialDoc: 'test.pdf',
			fullAPI: true
		},
		viewerElement).then((instance) => {
			console.log(instance);
		});
	},
    base64ToBlob: function(base) {
		var binaryString = window.atob(base);
		var len = binaryString.length;
		var bytes = new Uint8Array(len);
		for (let i = 0; i < len; ++i) {
			bytes[i] = binaryString.charCodeAt(i);
		}

		return new Blob([bytes], { type: 'application/pdf' });
	}
}