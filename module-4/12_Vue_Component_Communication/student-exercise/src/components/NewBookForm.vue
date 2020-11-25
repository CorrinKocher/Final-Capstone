<template>
<section>
     <form>     
        <div class="form-element" > 
            <label for="title">Title:</label>
            <input id="title" type="text" v-model.trim="newBook.title" />
        </div>
        <div class="form-element"> 
            <label for="author">Author:</label>
            <input id="author" type="text" v-model.trim="newBook.author" />
        </div>  
        <div class="form-element"> 
            <label for="isbn">ISBN:</label>
            <input id="isbn" type="text" v-model.trim="newBook.isbn" />
        </div>
        <input
            class="form-element"
            type="submit"
            value="Add Book"
            v-on:click.prevent="addBook()" />
            
        
        </form>
    </section>
</template>

<script>
export default {
    name: "NewBookForm",
    data(){
        return {
            newBook: {
                 title: "",
                author: "",
                read: false,
                isbn: "",
            }
        }
    },
   
    
    methods: {
        addBook(){
                this.$store.commit('ADD_BOOK', this.newBook);
                this.newBook = {
                
                title: "",
                author: "",
                read: false,
                isbn: ""
                
                }
            },
    },
}
</script>

<style>

</style>