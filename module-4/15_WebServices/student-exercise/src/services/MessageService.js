import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  get(id) {
    return http.get(`/messages/${id}`);
  },
  newMessage(newMessage) {
    return http.post('/messages/' , newMessage);
  },
  UpdateMessage(updatedMessage) {
    return http.put('/messages/' + updatedMessage.id, updatedMessage)
  },
  DeleteMessage(messageToDelete) {
    return http.delete('/message/' + messageToDelete.id);
  }

}
