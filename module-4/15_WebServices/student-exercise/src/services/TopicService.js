import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  list() {
    return http.get('/topics');
  },

  get(id) {
    return http.get(`/topics/${id}`);
  },
  newTopic(newTopic){
    return http.post('/topics', newTopic);
  },
  updateTopic(updatedQuestion) {
    return http.put('/topics/' + updatedQuestion.id, updatedQuestion);
  },
  deleteTopic(id) {
    return http.delete('/topics/' +  id );
  }

}
