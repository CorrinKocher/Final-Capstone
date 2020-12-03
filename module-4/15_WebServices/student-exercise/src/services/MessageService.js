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
  updateMessage(id, updatedMessage) {
    return http.put('/messages/' + updatedMessage.id, updatedMessage)
  },
  deleteMessage(id) {
    return http.delete('/messages/' + id);
  }

}
