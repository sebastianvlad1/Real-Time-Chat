var createRoomBtn = document.getElementById('create-room');
var createroomModal = document.getElementById('create-room-modal');

createRoomBtn.addEventListener('click', function(){
    createroomModal.classList.add('active');
});

var closeModal = function(){
    createroomModal.classList.remove('active');
}