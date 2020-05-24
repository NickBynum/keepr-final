<template>
  <div class="addNewKeep">
    <form>
      <div>
        <input type="text" placeholder="Name of Keep" v-model="newKeep.name" class="w-100 m-2" />
      </div>
      <div>
        <input type="text" placeholder="Image URL" v-model="newKeep.img" class="w-100 m-2" />
      </div>
      <div>
        <input
          type="text"
          placeholder="Description"
          v-model="newKeep.description"
          class="w-100 m-2"
        />
      </div>

      <div class="custom-control custom-switch">
        <input
          type="checkbox"
          class="custom-control-input"
          id="customSwitch1"
          v-model="newKeep.isPrivate"
        />
        <label class="custom-control-label text-primary" for="customSwitch1">Keep Private</label>
      </div>
    </form>
    <div class="modal-footer justify-content-center">
      <button type="button" class="btn btn-danger mr-4" data-dismiss="modal">Close</button>
      <button type="submit" class="btn btn-primary" @click.prevent="addNewKeep()" data-dismiss="modal">Add Keep!</button>
    </div>
  </div>
</template>


<script>
export default {
  name: 'addNewKeep',
  data() {
    return {
      newKeep: {}
    }
  },
  computed: {},
  methods: {
    addNewKeep() {
      this.$store.dispatch("addNewKeep", this.newKeep)
      newKeep = {}
    }
  },
  components: {}
}
</script>


<style scoped>
</style>