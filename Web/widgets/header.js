/**
 * Created by XX on 2016/11/1.
 */

function search_focus() {
    $(".search>div").toggleClass('active');
}

$(document).ready(function () {
    $(".search input").focusin(search_focus);
    $(".search input").focusout(search_focus);

});
