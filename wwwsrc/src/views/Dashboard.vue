<template>
  <div class="dashboard container-fluid">
    <div class="row"></div>
    <!-- Button trigger modal -->
    <button
      class="btn btn-outline-primary"
      data-toggle="modal"
      data-target="#addKeepModal"
    >New Keep!</button>

    <!-- Modal -->
    <div class="modal fade" id="addKeepModal" tabindex="-1" role="dialog">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5
              class="modal-title text-primary"
              id="exampleModalLabel"
            >Add a new keep to Keep so it's kept!</h5>
            <button type="button" class="close text-danger" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <!-- //NOTE --------- addKeep form ------------>
            <form>
              <div><input type="text" placeholder="Name of Keep" v-model="newKeep.name" ></div>
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
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
            <button type="button" class="btn btn-primary">Save</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  mounted() { },
  computed: {}
};
</script>

<style></style>
