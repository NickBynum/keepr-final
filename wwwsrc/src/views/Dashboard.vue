<template>
  <div class="dashboard container-fluid">
    <div class="row"></div>
    <!-- Button trigger modal -->
    <button
      class="btn btn-outline-primary"
      data-toggle="modal"
      data-target="#addKeepModal"
    >New Keep!</button>

    <Modal title="Keep new Keeps Kept!" id="addKeepModal">
      <addNewKeep></addNewKeep>
    </Modal>
    <!-- //NOTE --------- addKeep form ------------>
  </div>
</template>

<script>
import Modal from "../utils/Modal"
import addNewKeep from "../components/addNewKeep"
export default {
  data() {},
  mounted() { },
  computed: {},
  method: {
  },
  components:  {
    Modal,
    addNewKeep,
  }
};
</script>

<style></style>
