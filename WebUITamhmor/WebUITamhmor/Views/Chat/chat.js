var firebaseConfig = {
    apiKey: "AIzaSyDKcXzhG21zy5XIHJTinT9hddznAEGngdM",
    authDomain: "tamhomn.firebaseapp.com",
    databaseURL: "https://tamhomn-default-rtdb.firebaseio.com",
    projectId: "tamhomn",
    storageBucket: "tamhomn.appspot.com",
    messagingSenderId: "919411017243",
    appId: "1:919411017243:web:8477a079ed18dc5c15dabe",
    measurementId: "G-BP59ZFJVC9"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();


var name = localStorage.getItem("name");

function send() {
    var msg = document.getElementById('msg_text').value;
    if (msg != "") {
        firebase.database().ref("messages").push({
            msg: msg,
            sender: name

        }).then(function () {
            document.getElementById('msg_text').value = "";
        })
    }
}

firebase.database().ref("messages").on("child_added", function (snapshot) {
    var username = snapshot.val().sender;
    var msg = snapshot.val().msg;
    var html = "";

    if (username == name) {
        html += "<div class='message_me' align='right'><p class='user'>" + username + "</p><p class='msg_me'>" + msg + "</p></div>";
        document.getElementById("box_messages").innerHTML += html;

    } else {
        html += "<div class='message_user' align='left'><p class='user'>" + username + "</p><p class='msg_user'>" + msg + "</p></div>";
        document.getElementById("box_messages").innerHTML += html;
    }

    var div_obj = document.getElementById("box_messages");
    div_obj.scrollTop = div_obj.scrollHeight;
});