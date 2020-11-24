<template>
  <table id="tblUsers">
    <thead>
      <tr>
        <th>First Name</th>
        
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
        <td><input type="text" id="firstNameFilter" v-model="filter.firstName" /></td>
        <td><input type="text" id="lastNameFilter" v-model="filter.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="filter.userName"/></td>
        <td><input type="text" id="emailFilter" v-model="filter.emailAddress"/></td>
        <td>
          <select id="statusFilter" v-model="filter.status" >
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <tr v-for="users of filteredList" v-bind:key="users.username"  v-bind:class="{disabled: users.status === 'Disabled'}" >
        <td>{{ users.firstName }} </td>
        <td>{{ users.lastName }} </td>
        <td>{{ users.username }}</td>
        <td>{{ users.emailAddress }} </td>
        <td>{{ users.status }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
 computed: {
   
   filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.status === this.filter.status
          
        );
      }
      return filteredUsers;
    }, 
  
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
  data() {

    return {
      createUser: {
         firstName: '',
      lastName: '',
      username: '',
      emailAddress:'',
      status: '',
      },
      filter: {
        firstName: '',
         lastName: '',
      username: '',
      emailAddress:'',
      status: '',
      },
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
