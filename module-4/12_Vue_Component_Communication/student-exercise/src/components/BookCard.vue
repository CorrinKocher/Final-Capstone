<template>
  <div class="card">
      <h2> {{book.title}} </h2>
      <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <h3> {{book.author}} </h3>
    <button v-on:click="toggleClass"  >
        <span class="mark-read" v-if="book.read === false"> Mark Read </span>
        <span  class="mark-unread" v-if="book.read === true"> Mark Unread </span>
    </button>
   
    
    
  </div>
</template>

<script>
export default {
    name: 'book-card',
    props: {
        book: Object,
        
    },
    methods: {
        toggleClass() {
            this.$store.commit('TOGGLE_CLASS', this.book);
        },
       
    },

    

}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>