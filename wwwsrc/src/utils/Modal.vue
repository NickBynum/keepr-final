<template>
  <div class="modal fade">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header bg-primary">
          <h5 class="modal-title text-light">{{title}}</h5>
          <button
            type="button"
            class="close text-light"
            id="close-btn"
            data-dismiss="modal"
          >
            <span aria-hidden="true">&times;</span>
          </button>
        </div>
        <div class="modal-body rounded-bottom bg-light">
          <slot></slot>
        </div>
      </div>
    </div>
  </div>
</template>



<script>
export default {
  name: 'component',
  props: ["title"],
  data() {
    return {}
  },
  computed: {},
  methods: {},
  components: {}
}
</script>


<style scoped>
</style>