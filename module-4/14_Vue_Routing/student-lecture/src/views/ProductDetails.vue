<template>
  <div>
    <product-info v-bind:productId="productId" />
    <review-list v-bind:productId="productId" />
  </div>
</template>

<script>
import ReviewList from "@/components/ReviewList.vue";
import ProductInfo from '@/components/ProductInfo.vue';

export default {
  name: "product-detail",
  components: {
    ReviewList,
    ProductInfo
  },
  data() {
      return {
          productId: 2,
      }
  },
  created() {
    this.productId = +this.$route.params.productId;

    const product = this.$store.state.products.find(p => p.id == this.productId);
    console.debug('my product iss ', product);
  },
  computed: {
    prodId() {
      return this.$route.params.productId;
    }
  }
};
</script>
