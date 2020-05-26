<template>
  <div class="KeepDetails">
    {{this.keepData}}
    <div class="modal-footer justify-content-center">
      <button type="button" class="btn btn-danger mr-4" data-dismiss="modal">Close</button>
    </div>
  </div>
</template>


<script>
export default {
  name: 'component',
  props: ['keepData'],
  data(){
    return {}
  },
  computed:{},
  methods:{},
  components:{}
}
</script>


<style scoped>

</style>