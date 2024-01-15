import axios from "axios";
import TokenManager from "./TokenManager";

const CustomerAPI = {
    getCustomer: (customerId) => axios.get(`http://localhost:8080/customers/${customerId}`,
        {
            headers: { Authorization: `Bearer ${TokenManager.getAccessToken()}` }
        })
        .then(response => response.data)

}

export default CustomerAPI;