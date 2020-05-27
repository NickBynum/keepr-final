<template>
  <div class="addNewVault">
    <form>
      <div>
        <input type="text" placeholder="Name of Vault" v-model="newVault.name" class="w-100 m-2" />
      </div>
      <div>
        <input
          type="text"
          placeholder="Description"
          v-model="newVault.description"
          class="w-100 m-2"
        />
      </div>
    </form>
    <div class="modal-footer justify-content-center">
      <button type="button" class="btn btn-danger mr-4" data-dismiss="modal">Close</button>
      <button type="submit" class="btn btn-primary" @click.prevent="addNewVault()" data-dismiss="modal">Add Vault!</button>
    </div>
  </div>
</template>


<script>
export default {
  name: 'addNewVault',
  data() {
    return {
      newVault: {}
    }
  },
  computed: {},
  methods: {
    addNewVault() {
      this.$store.dispatch("addNewVault", this.newVault)
      newVault = {}
    }
  },
  components: {}
}
</script>


<style scoped>
</style>