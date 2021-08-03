//function MakeTopMenuBar() {
//    $("#TopMenuBarContent").load("TopMenuBar.html");
//}

function MakeTopMenuBar() {
    $("#TopMenuBarContent").load("navbar.html");

    var CurrentPage;

    try {
        CurrentPage = document.location.href.match(/[^\/]+$/)[0];
    }
    catch (err) {
        CurrentPage = "index.html";
    }
    finally {
        setTimeout(function () {
            PageLoadTimeOut(CurrentPage);
        }, 200);
    }
}

function PageLoadTimeOut(CurrentPageInfo) {
    $("#TopMenuBarContent ul li").find('a').each(function () {
        if ($(this).attr('href') == CurrentPageInfo) {
            $(this).addClass("MenuCurrentItem");
        }
    });
}