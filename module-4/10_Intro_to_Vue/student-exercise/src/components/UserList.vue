<template>
  <table id="tblUsers">
    <thead>
      <tr>
        <th>First Name</th>
        <!-- do I need to add a for loop and key here -->
        <th>Last Name</th>
        <!-- do I need to add a for loop and key here -->
        <th>Username</th>
        <!-- do I need to add a for loop and key here -->
        <th>Email Address</th>
        <!-- do I need to add a for loop and key here -->
        <th>Status</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" /></td>
        <td><input type="text" id="lastNameFilter" /></td>
        <td><input type="text" id="usernameFilter" /></td>
        <td><input type="text" id="emailFilter" /></td>
        <td>
          <select id="statusFilter">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <tr v-for="user of users" v-bind:key="user.username">
        <td>{{ user.firstName }} /></td>
        <td>{{ user.lastName }} /></td>
        <td>{{ user.Username }}/></td>
        <td>{{ user.emailAddress }} /></td>
        <td>{{ user.status }}/></td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
 computed: {
    returnUser() {
    let user = this.users;
    if(this.users.firstName)  {
        user = user.filter(n => n.firstName.tolower.includes(user.createUser.firstName));
      }
    if(this.users.lastName)  {
      user = user.filter(n => n.LastName.tolower.includes(user.createUser.LastName));
    }
    if(this.users.firstName)  {
      user = user.filter(n => n.username.tolower.includes(user.createUser.username));
    }
    if(this.users.firstName)  {
      user = user.filter(n => n.emailAddress.tolower.includes(user.createUser.emailAddress));
    }
    if(this.users.firstName)  {
      user = user.filter(n => n.status.tolower.includes(user.createUser.status));
    }
      return user;
    }
    
  }, 
  
createUser () {
let user = {
  firstName: '',
  lastName: '',
  username:'',
  emailAddress:'',
  status:'',
};
return user;
  },
  data() {
    return {
      
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ]
    }
  }
}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}
.userData {
  color: blue;
}
</style>
