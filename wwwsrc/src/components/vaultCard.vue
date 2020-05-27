<template>
  <div class="vaultCard">
    <div class="card border-0" style="width: 18rem;">
      <div class="card-body">
        <h5 class="card-title">{{vaultData.title}}test</h5>
        <p class="card-text">{{vaultData.description}}</p>
          <div class="p-0 d-flex justify-content-between">
            <button class="btn btn btn-info text-light">View Vault</button>
            <button class="btn btn-danger text-light" @click="deleteVault()">Delete Vault</button>
          </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: 'vaultCard',
  props: ["vaultData"],
  data() {
    return {}
  },
  mounted() {
    this.$store.dispatch("getUserVaults")
  },
  computed: {},
  methods: {
    deleteVault() {
      console.log("pretend deleted vault!");
      
    }
  },
  components: {}
}
</script>


<style scoped>
</style>