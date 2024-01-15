import axios from 'axios';

const UserAPI = {
    getUser: (userId) => axios.get(`http://localhost:8080/users/${id}`,
    {
        headers: { Authorization: `Bearer ${TokenManager.getAccessToken()}` }
    })
    .then(response => response.data),
    getUsers: () => axios.get("http://localhost:8080/users"),
    createUser: newUser => axios.post("http://localhost:8080/postcodes", {id: newUser,BSN: newUser, username: newUser, password: newUser, firstName: newUser, lastName: newUser, postcodeId: newUser, age: newUser}),
    deleteUser: () => axios.delete("http://localhost:8080/users/{{userId}}"),
    updateUser: () => axios.put("http://localhost:8080/users/{{id}}")
}

export default UserAPI;