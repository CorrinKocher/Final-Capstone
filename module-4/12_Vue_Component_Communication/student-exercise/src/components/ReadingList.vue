<template>
  <div class="book-container">
    <book-card v-for="b in displayBooks" v-bind:key="b.isbn" v-bind:book="b"/>
    
  </div>
</template>

<script>
import BookCard from './BookCard.vue';


export default {
    name: 'reading-list',
  components:{
    BookCard,
    
  },
  computed: {
    displayBooks() {
      return this.$store.state.books;    
         
      },
      
    }
  }
        
</script>

<style>
.book-container {
  display: flex;
  justify-content: space-evenly;
  flex-wrap: wrap;
}
</style>