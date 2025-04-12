function Search() {
    var keyword = $("#keyword").val();
    window.location.href = "/Home/Attractions?keyword=" + keyword;
}

function checkHitEnter(ele) {
    if (event.key === 'Enter') {
        var keyword = $("#keyword").val();
        window.location.href = "/Home/Attractions?keyword=" + keyword;
    }
}

function highLight(ele) {
    const elements = document.querySelectorAll('.list-group-item');
    elements.forEach(element => {
        element.style.borderStyle = "none"; // Hide border of any previously selected
    });

    document.getElementById("AttractionId").value = ele.id;
    ele.style.borderStyle = "solid";
    document.getElementById("btnAttraction").disabled = false;
}

function showAttraction() {
    var AttractionId = $("#AttractionId").val();
    var imgAttraction = $("#img_" + AttractionId).val();
    window.location.href = "/Home/AttDetails?AttractionId=" + AttractionId + "&imageUrl=" + imgAttraction;
}