// This is a path to the application we'll be communicating with. It can be any server
import axios from 'axios';
// that can handle REST requests.
const myServerUrl = 'https://sallythesquirrelservice.azurewebsites.net';

const http = axios.create({baseURL:myServerUrl})
// TODO: Create our Axios instance used to communicate with the server and set the baseURL

export default {
    getAllQuestions() {
        return http.get('/questions');
    },
    createNewQuestion(newQuestion) {
        return http.post('/questions', newQuestion);
    },
    editQuestion(id, updatedQuestion){
        return http.put('/questions/' + id, updatedQuestion);
    },
    deleteQuestion() {
        return http.delete(`$/questions/{id}`);
    }
}