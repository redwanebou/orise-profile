import axios from 'axios';
import { API_BASE_URL } from '../config/api';

const endpoint = `${API_BASE_URL}/person`;

class PersonService {
  async submitPerson(data) {
    const response = await axios.post(endpoint, data);
    return response.data;
  }
}

const personService = new PersonService();
export default personService;