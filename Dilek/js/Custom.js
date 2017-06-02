function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#showImage')
                .attr('src', e.target.result)
            $('#imageDiv')
                .removeClass("hidden");
            $('#saveImage')
                .removeAttr("disabled");
        };

        reader.readAsDataURL(input.files[0]);
    }
}