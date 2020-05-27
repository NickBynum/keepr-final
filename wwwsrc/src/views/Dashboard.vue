<template>
  <div class="dashboard container-fluid">
    <div class="row mt-2">
      <!-- ---------Add New Keep--------- -->
      <div class="col-3">
        <button
          class="btn btn-outline-primary btn-block"
          data-toggle="modal"
          data-target="#addKeepModal"
        >New Keep!</button>
      </div>
      <div class="col-3">
        <button
          class="btn btn-outline-primary btn-block"
          @click="vaultView = false"
        >Show Your Keeps!</button>
      </div>
      <!-- ---------Add New Vault--------- -->
      <div class="col-3">
        <button
          class="btn btn-outline-secondary btn-block"
          @click="vaultView = true"
        >View Your Vaults</button>
      </div>
      <div class="col-3">
        <button
          class="btn btn-outline-secondary btn-block"
          data-toggle="modal"
          data-target="#addVaultModal"
        >New Vault!</button>
      </div>
      <!-- ---------Slot Modal--------- -->
      <Modal title="Keep your Keeps Kept, in the vault!" id="addVaultModal">
        <addNewVault></addNewVault>
      </Modal>
      <!-- ---------Slot Modal--------- -->
      <Modal title="Keep new Keeps Kept!" id="addKeepModal">
        <addNewKeep></addNewKeep>
      </Modal>
      <!-- //NOTE ---------ALL User's Keeps ------------>
    </div>
    <div v-if="!vaultView" class="row justify-content-start">
      <userKeepCard v-for="userKeep in userKeeps" :keepData="userKeep" :key="userKeep.id"></userKeepCard>
    </div>
    <div v-else class="row justify-content-start">
      <vaultCard v-for="vault in vaults" :vaultData="vault" :key="vault.id"></vaultCard>
    </div>
  </div>
</template>

<script>
import Modal from "../utils/Modal"
import addNewKeep from "../components/addNewKeep"
import userKeepCard from "../components/userKeepCard"
import addNewVault from "../components/addNewVault"
import vaultCard from "../components/vaultCard"
export default {
  data() {
    return {
      vaultView: false,
    }
  },
  mounted() {
    this.$store.dispatch("getUserKeeps");
    this.$store.dispatch("getUserVaults");
  },
  computed: {
    userKeeps() {
      return this.$store.state.userKeeps;
    },
    vaults() {
      return this.$store.state.vaults
    }
  },
  method: {
  },
  components: {
    Modal,
    addNewKeep,
    userKeepCard,
    addNewVault,
    vaultCard
  }
};
</script>

<style></style>
